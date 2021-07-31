using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.VideoSurveillance;
using Emgu.Util;


namespace Emgu_Color_Track
{
    public partial class Form1 : Form
    {
        private Capture _capture;
        private Tracker laserTracker;
        private Tracker targetTracker;
        private SerialCommunication serial;

        private Stopwatch sw = new Stopwatch();

        public float deltaTime = 1;

        private TrackbarDisplay kp;
        private TrackbarDisplay ki;
        private TrackbarDisplay kd;

        private PID pidX;
        private PID pidY;

        private float angleX, angleY;

        public Form1()
        {
            InitializeComponent();

            hMinLaser.Value = Properties.Settings.Default.laserHMin;
            hMaxLaser.Value = Properties.Settings.Default.laserHMax;
            sMinLaser.Value = Properties.Settings.Default.laserSMin;
            sMaxLaser.Value = Properties.Settings.Default.laserSMax;
            vMinLaser.Value = Properties.Settings.Default.laserVMin;
            vMaxLaser.Value = Properties.Settings.Default.laserVMax;

            hMinTarget.Value = Properties.Settings.Default.targetHMin;
            hMaxTarget.Value = Properties.Settings.Default.targetHMax;
            sMinTarget.Value = Properties.Settings.Default.targetSMin;
            sMaxTarget.Value = Properties.Settings.Default.targetSMax;
            vMinTarget.Value = Properties.Settings.Default.targetVMin;
            vMaxTarget.Value = Properties.Settings.Default.targetVMax;

            proportionalK.Value = Properties.Settings.Default.kp;
            integralK.Value = Properties.Settings.Default.ki;
            derivativeK.Value = Properties.Settings.Default.kd;


            laserTracker = new Tracker(
                new TrackbarDisplay(hMinLaser, hMinLabelLaser, hMinLaser.Value),
            new TrackbarDisplay(sMinLaser, sMinLabelLaser, sMinLaser.Value),
            new TrackbarDisplay(vMinLaser, vMinLabelLaser, vMinLaser.Value),
            new TrackbarDisplay(hMaxLaser, hMaxLabelLaser, hMaxLaser.Value),
            new TrackbarDisplay(sMaxLaser, sMaxLabelLaser, sMaxLaser.Value),
            new TrackbarDisplay(vMaxLaser, vMaxLabelLaser, vMaxLaser.Value),
            maskViewLaser, 5, 50);

            targetTracker = new Tracker(
                new TrackbarDisplay(hMinTarget, hMinLabelTarget, hMinTarget.Value),
            new TrackbarDisplay(sMinTarget, sMinLabelTarget, sMinTarget.Value),
            new TrackbarDisplay(vMinTarget, vMinLabelTarget, vMinTarget.Value),
            new TrackbarDisplay(hMaxTarget, hMaxLabelTarget, hMaxTarget.Value),
            new TrackbarDisplay(sMaxTarget, sMaxLabelTarget, sMaxTarget.Value),
            new TrackbarDisplay(vMaxTarget, vMaxLabelTarget, vMaxTarget.Value),
            maskViewTarget, 15);

            serial = new SerialCommunication();

            kp = new TrackbarDisplay(proportionalK, propValue, proportionalK.Value, 1000);
            ki = new TrackbarDisplay(integralK, intValue, integralK.Value, 1000);
            kd = new TrackbarDisplay(derivativeK, derValue, derivativeK.Value, 1000);

            pidX = new PID(kp, ki, kd);
            pidY = new PID(kp, ki, kd);

            //try to create the capture
            if (_capture == null)
            {
                try
                {
                    _capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {   //show errors if there is any
                    MessageBox.Show(excpt.Message);
                }
            }

            if (_capture != null) //if camera capture has been successfully created
            {
                _capture.ImageGrabbed += ProcessFrame;
                _capture.Start();
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
                deltaTime = sw.ElapsedMilliseconds / 1000f;
                Console.WriteLine("dT = " + deltaTime.ToString());
                sw.Reset();
            }
            sw.Start();

            Mat image = new Mat();
            Mat hsvimg = new Mat();
            Mat mask = new Mat();

            _capture.Retrieve(image);

            CvInvoke.CvtColor(image, hsvimg, ColorConversion.Bgr2Hsv);

            laserTracker.ProcessFrame(image, hsvimg, mask);
            targetTracker.ProcessFrame(image, hsvimg, mask);

            CvInvoke.MedianBlur(mask, mask, 5);
            imageView.Image = image;

            SetServos();

        }

        private void SetServos()
        {
            if (laserTracker.Point.X < 0 || laserTracker.Point.Y < 0 || targetTracker.Point.X < 0 || targetTracker.Point.Y < 0)
            {
                SendAngles(90, 90);
                return;
            }
            float errorX = laserTracker.Point.X - targetTracker.Point.X;
            float errorY = laserTracker.Point.Y - targetTracker.Point.Y;
            float pidUpdateX = pidX.Update(errorX, deltaTime);
            float pidUpdateY = pidY.Update(errorY, deltaTime);
            SendAngles(RoundToInt(Clamp(angleX + pidUpdateX, 30, 150)), RoundToInt(Clamp(angleY + pidUpdateY, 50, 130)));
        }

        private int RoundToInt(float f)
        {
            return (int)Math.Round(f);
        }

        private int Clamp(int i, int min, int max)
        {
            if (i < min)
                return min;
            if (i > max)
                return max;
            return i;
        }

        private float Clamp(float f, float min, float max)
        {
            if (f < min)
                return min;
            if (f > max)
                return max;
            return f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SendAngles(int horizontal, int vertical)
        {
            angleX = horizontal;
            angleY = vertical;
            serial.Send(Convert.ToByte('H')); //Prime Arduino to accept horizontal angle next.
            byte hVal = Convert.ToByte(horizontal);
            serial.Send(hVal);
            serial.Send(Convert.ToByte('V')); //Prime Arduino to accept vertical angle next.
            byte vVal = Convert.ToByte(vertical);
            serial.Send(vVal);
            serial.Write();
        }

        private void saveLaser_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.laserHMin = hMinLaser.Value;
            Properties.Settings.Default.laserHMax = hMaxLaser.Value;
            Properties.Settings.Default.laserSMin = sMinLaser.Value;
            Properties.Settings.Default.laserSMax = sMaxLaser.Value;
            Properties.Settings.Default.laserVMin = vMinLaser.Value;
            Properties.Settings.Default.laserVMax = vMaxLaser.Value;
            Properties.Settings.Default.Save();
        }

        private void pidSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.kp = proportionalK.Value;
            Properties.Settings.Default.ki = integralK.Value;
            Properties.Settings.Default.kd = derivativeK.Value;
            Properties.Settings.Default.Save();
        }

        private void saveTarget_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.targetHMin = hMinTarget.Value;
            Properties.Settings.Default.targetHMax = hMaxTarget.Value;
            Properties.Settings.Default.targetSMin = sMinTarget.Value;
            Properties.Settings.Default.targetSMax = sMaxTarget.Value;
            Properties.Settings.Default.targetVMin = vMinTarget.Value;
            Properties.Settings.Default.targetVMax = vMaxTarget.Value;
            Properties.Settings.Default.Save();
        }
    }

    public class TrackbarDisplay
    {

        public TrackbarDisplay(TrackBar tb, Label l, int v, float _scale = 1)
        {
            trackbar = tb;
            label = l;
            scale = _scale;
            Update(v);
            trackbar.ValueChanged += HandleValueChanged;
        }

        public TrackBar trackbar;
        public Label label;
        private int value;
        public float scale = 1;

        public float Value
        {
            get => value / scale;
        }

        public void HandleValueChanged(object sender, EventArgs e)
        {
            Update(trackbar.Value);
        }

        public void Update(int newValue)
        {
            value = newValue;
            label.Text = (value / scale).ToString();
        }
    }

    public class PID
    {
        public TrackbarDisplay trackbarKp;
        public TrackbarDisplay trackbarKi;
        public TrackbarDisplay trackbarKd;
        float errorPrevious = 0;
        float integ = 0;

        public PID(TrackbarDisplay kp, TrackbarDisplay ki, TrackbarDisplay kd)
        {
            trackbarKp = kp;
            trackbarKi = ki;
            trackbarKd = kd;
        }

        public float Update(float error, float deltaTime)
        {
            integ = (integ + error * deltaTime);
            float der = (error - errorPrevious) / deltaTime;
            errorPrevious = error;
            return trackbarKp.Value * error + trackbarKi.Value * integ + trackbarKd.Value * der;
        }

    }

}

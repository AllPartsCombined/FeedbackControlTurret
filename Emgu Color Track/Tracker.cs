using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.UI;

namespace Emgu_Color_Track
{
    class Tracker
    {
        private TrackbarDisplay hMinDisplay;
        private TrackbarDisplay sMinDisplay;
        private TrackbarDisplay vMinDisplay;
        private TrackbarDisplay hMaxDisplay;
        private TrackbarDisplay sMaxDisplay;
        private TrackbarDisplay vMaxDisplay;

        private Point point = new Point(-1, -1);
        private int resetAfterFrames;
        private int untrackedFrames = 0;
        private Rectangle rect = new Rectangle();

        private MCvScalar rectangleColor = new MCvScalar(255, 255, 0);
        private MCvScalar pointColor = new MCvScalar(0, 255, 0);
        private MCvScalar textColor = new MCvScalar(255, 255, 0);
        private int minContourRadius;

        private ImageBox maskView;

        public Point Point { get => point; }

        public Tracker(TrackbarDisplay h_min, TrackbarDisplay s_min, TrackbarDisplay v_min, TrackbarDisplay h_max, TrackbarDisplay s_max, TrackbarDisplay v_max, ImageBox _maskView = null, 
            int _minContourRadius = 5, int _resetAfterFrames = 10)
        {
            hMinDisplay = h_min;
            sMinDisplay = s_min;
            vMinDisplay = v_min;
            hMaxDisplay = h_max;
            sMaxDisplay = s_max;
            vMaxDisplay = v_max;

            maskView = _maskView;

            minContourRadius = _minContourRadius;
            resetAfterFrames = _resetAfterFrames;

        }

        public void ProcessFrame(Mat image, Mat hsvimg, Mat mask)
        {
            Mat blurredMask = new Mat();

            ScalarArray hsv_min = new ScalarArray(new MCvScalar(hMinDisplay.Value, sMinDisplay.Value, vMinDisplay.Value));
            ScalarArray hsv_max = new ScalarArray(new MCvScalar(hMaxDisplay.Value, sMaxDisplay.Value, vMaxDisplay.Value));

            CvInvoke.InRange(hsvimg, hsv_min, hsv_max, mask);
            CvInvoke.MedianBlur(mask, blurredMask, 5);

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            VectorOfRect hierachy = new VectorOfRect();
            CvInvoke.FindContours(blurredMask, contours, hierachy, RetrType.List, ChainApproxMethod.ChainApproxNone);

            bool tracked = false;
            rect = new Rectangle(-1, -1, 0, 0);
            for(int i = 0; i < contours.Size; i++)
            {
                Rectangle contourRect = CvInvoke.BoundingRectangle(contours[i]);
                if (!(contourRect.Width < minContourRadius || contourRect.Height < minContourRadius)) //If the bounding rectangle is too small, delete it
                {
                    if (contourRect.Width > rect.Width && contourRect.Height > rect.Height)
                        rect = contourRect;
                }
            }
            if (rect.Width > 0 && rect.Height > 0)
            {
                tracked = true;
                point.X = rect.Left + rect.Size.Width / 2;
                point.Y = rect.Top + rect.Size.Height / 2;
                untrackedFrames = 0;
            }
            if (!tracked)
            {
                untrackedFrames++;
                if (untrackedFrames > resetAfterFrames)
                {
                    point.X = -1;
                    point.Y = -1;
                }
            }
            if (point.X != -1 && point.Y != -1)
            {
                CvInvoke.Rectangle(image, rect, new MCvScalar(255, 255, 0), 1);
                CvInvoke.Circle(image, point, 2, new MCvScalar(0, 255, 0), 1);
                CvInvoke.PutText(image, "(" + point.X + ", " + point.Y + ")", new Point(point.X - 30, point.Y + 20), FontFace.HersheyPlain, .75, new MCvScalar(255, 255, 0));
            }

            if (maskView != null)
                maskView.Image = mask;
        }
    }
}

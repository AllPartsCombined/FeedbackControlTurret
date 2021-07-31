namespace Emgu_Color_Track
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageView = new Emgu.CV.UI.ImageBox();
            this.maskViewLaser = new Emgu.CV.UI.ImageBox();
            this.hMinLaser = new System.Windows.Forms.TrackBar();
            this.sMinLaser = new System.Windows.Forms.TrackBar();
            this.vMinLaser = new System.Windows.Forms.TrackBar();
            this.hMaxLaser = new System.Windows.Forms.TrackBar();
            this.sMaxLaser = new System.Windows.Forms.TrackBar();
            this.vMaxLaser = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hMinLabelLaser = new System.Windows.Forms.Label();
            this.sMinLabelLaser = new System.Windows.Forms.Label();
            this.vMinLabelLaser = new System.Windows.Forms.Label();
            this.hMaxLabelLaser = new System.Windows.Forms.Label();
            this.sMaxLabelLaser = new System.Windows.Forms.Label();
            this.vMaxLabelLaser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vMaxLabelTarget = new System.Windows.Forms.Label();
            this.sMaxLabelTarget = new System.Windows.Forms.Label();
            this.hMaxLabelTarget = new System.Windows.Forms.Label();
            this.vMinLabelTarget = new System.Windows.Forms.Label();
            this.sMinLabelTarget = new System.Windows.Forms.Label();
            this.hMinLabelTarget = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.vMaxTarget = new System.Windows.Forms.TrackBar();
            this.sMaxTarget = new System.Windows.Forms.TrackBar();
            this.hMaxTarget = new System.Windows.Forms.TrackBar();
            this.vMinTarget = new System.Windows.Forms.TrackBar();
            this.sMinTarget = new System.Windows.Forms.TrackBar();
            this.hMinTarget = new System.Windows.Forms.TrackBar();
            this.maskViewTarget = new Emgu.CV.UI.ImageBox();
            this.saveLaser = new System.Windows.Forms.Button();
            this.saveTarget = new System.Windows.Forms.Button();
            this.derValue = new System.Windows.Forms.Label();
            this.intValue = new System.Windows.Forms.Label();
            this.propValue = new System.Windows.Forms.Label();
            this.derLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.propLabel = new System.Windows.Forms.Label();
            this.derivativeK = new System.Windows.Forms.TrackBar();
            this.integralK = new System.Windows.Forms.TrackBar();
            this.proportionalK = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.pidSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskViewLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMinLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMinLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMinLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMaxLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMaxLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMaxLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMaxTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMaxTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMaxTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMinTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMinTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMinTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskViewTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derivativeK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proportionalK)).BeginInit();
            this.SuspendLayout();
            // 
            // imageView
            // 
            this.imageView.Location = new System.Drawing.Point(258, 100);
            this.imageView.Name = "imageView";
            this.imageView.Size = new System.Drawing.Size(800, 450);
            this.imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageView.TabIndex = 2;
            this.imageView.TabStop = false;
            this.imageView.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // maskViewLaser
            // 
            this.maskViewLaser.Location = new System.Drawing.Point(1179, 100);
            this.maskViewLaser.Name = "maskViewLaser";
            this.maskViewLaser.Size = new System.Drawing.Size(400, 225);
            this.maskViewLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maskViewLaser.TabIndex = 4;
            this.maskViewLaser.TabStop = false;
            // 
            // hMinLaser
            // 
            this.hMinLaser.Location = new System.Drawing.Point(44, 648);
            this.hMinLaser.Maximum = 255;
            this.hMinLaser.Name = "hMinLaser";
            this.hMinLaser.Size = new System.Drawing.Size(239, 45);
            this.hMinLaser.TabIndex = 5;
            this.hMinLaser.Value = 125;
            this.hMinLaser.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // sMinLaser
            // 
            this.sMinLaser.Location = new System.Drawing.Point(331, 648);
            this.sMinLaser.Maximum = 255;
            this.sMinLaser.Name = "sMinLaser";
            this.sMinLaser.Size = new System.Drawing.Size(239, 45);
            this.sMinLaser.TabIndex = 6;
            this.sMinLaser.Value = 70;
            this.sMinLaser.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // vMinLaser
            // 
            this.vMinLaser.Location = new System.Drawing.Point(611, 648);
            this.vMinLaser.Maximum = 255;
            this.vMinLaser.Name = "vMinLaser";
            this.vMinLaser.Size = new System.Drawing.Size(239, 45);
            this.vMinLaser.TabIndex = 7;
            this.vMinLaser.Value = 70;
            this.vMinLaser.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // hMaxLaser
            // 
            this.hMaxLaser.Location = new System.Drawing.Point(44, 754);
            this.hMaxLaser.Maximum = 255;
            this.hMaxLaser.Name = "hMaxLaser";
            this.hMaxLaser.Size = new System.Drawing.Size(239, 45);
            this.hMaxLaser.TabIndex = 8;
            this.hMaxLaser.Value = 255;
            this.hMaxLaser.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // sMaxLaser
            // 
            this.sMaxLaser.Location = new System.Drawing.Point(331, 754);
            this.sMaxLaser.Maximum = 255;
            this.sMaxLaser.Name = "sMaxLaser";
            this.sMaxLaser.Size = new System.Drawing.Size(239, 45);
            this.sMaxLaser.TabIndex = 9;
            this.sMaxLaser.Value = 255;
            this.sMaxLaser.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // vMaxLaser
            // 
            this.vMaxLaser.Location = new System.Drawing.Point(611, 754);
            this.vMaxLaser.Maximum = 255;
            this.vMaxLaser.Name = "vMaxLaser";
            this.vMaxLaser.Size = new System.Drawing.Size(239, 45);
            this.vMaxLaser.TabIndex = 10;
            this.vMaxLaser.Value = 255;
            this.vMaxLaser.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "H Min";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "S Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 622);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "V Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 723);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "H Max";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 723);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "S Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 723);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "V Max";
            // 
            // hMinLabelLaser
            // 
            this.hMinLabelLaser.AutoSize = true;
            this.hMinLabelLaser.Location = new System.Drawing.Point(130, 680);
            this.hMinLabelLaser.Name = "hMinLabelLaser";
            this.hMinLabelLaser.Size = new System.Drawing.Size(35, 13);
            this.hMinLabelLaser.TabIndex = 17;
            this.hMinLabelLaser.Text = "label7";
            // 
            // sMinLabelLaser
            // 
            this.sMinLabelLaser.AutoSize = true;
            this.sMinLabelLaser.Location = new System.Drawing.Point(442, 680);
            this.sMinLabelLaser.Name = "sMinLabelLaser";
            this.sMinLabelLaser.Size = new System.Drawing.Size(35, 13);
            this.sMinLabelLaser.TabIndex = 18;
            this.sMinLabelLaser.Text = "label8";
            // 
            // vMinLabelLaser
            // 
            this.vMinLabelLaser.AutoSize = true;
            this.vMinLabelLaser.Location = new System.Drawing.Point(711, 680);
            this.vMinLabelLaser.Name = "vMinLabelLaser";
            this.vMinLabelLaser.Size = new System.Drawing.Size(35, 13);
            this.vMinLabelLaser.TabIndex = 19;
            this.vMinLabelLaser.Text = "label9";
            // 
            // hMaxLabelLaser
            // 
            this.hMaxLabelLaser.AutoSize = true;
            this.hMaxLabelLaser.Location = new System.Drawing.Point(127, 786);
            this.hMaxLabelLaser.Name = "hMaxLabelLaser";
            this.hMaxLabelLaser.Size = new System.Drawing.Size(41, 13);
            this.hMaxLabelLaser.TabIndex = 20;
            this.hMaxLabelLaser.Text = "label10";
            // 
            // sMaxLabelLaser
            // 
            this.sMaxLabelLaser.AutoSize = true;
            this.sMaxLabelLaser.Location = new System.Drawing.Point(436, 786);
            this.sMaxLabelLaser.Name = "sMaxLabelLaser";
            this.sMaxLabelLaser.Size = new System.Drawing.Size(41, 13);
            this.sMaxLabelLaser.TabIndex = 21;
            this.sMaxLabelLaser.Text = "label11";
            // 
            // vMaxLabelLaser
            // 
            this.vMaxLabelLaser.AutoSize = true;
            this.vMaxLabelLaser.Location = new System.Drawing.Point(708, 786);
            this.vMaxLabelLaser.Name = "vMaxLabelLaser";
            this.vMaxLabelLaser.Size = new System.Drawing.Size(41, 13);
            this.vMaxLabelLaser.TabIndex = 22;
            this.vMaxLabelLaser.Text = "label12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Laser Filter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1445, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Target Filter";
            // 
            // vMaxLabelTarget
            // 
            this.vMaxLabelTarget.AutoSize = true;
            this.vMaxLabelTarget.Location = new System.Drawing.Point(1717, 786);
            this.vMaxLabelTarget.Name = "vMaxLabelTarget";
            this.vMaxLabelTarget.Size = new System.Drawing.Size(41, 13);
            this.vMaxLabelTarget.TabIndex = 41;
            this.vMaxLabelTarget.Text = "label12";
            // 
            // sMaxLabelTarget
            // 
            this.sMaxLabelTarget.AutoSize = true;
            this.sMaxLabelTarget.Location = new System.Drawing.Point(1445, 786);
            this.sMaxLabelTarget.Name = "sMaxLabelTarget";
            this.sMaxLabelTarget.Size = new System.Drawing.Size(41, 13);
            this.sMaxLabelTarget.TabIndex = 40;
            this.sMaxLabelTarget.Text = "label11";
            // 
            // hMaxLabelTarget
            // 
            this.hMaxLabelTarget.AutoSize = true;
            this.hMaxLabelTarget.Location = new System.Drawing.Point(1136, 786);
            this.hMaxLabelTarget.Name = "hMaxLabelTarget";
            this.hMaxLabelTarget.Size = new System.Drawing.Size(41, 13);
            this.hMaxLabelTarget.TabIndex = 39;
            this.hMaxLabelTarget.Text = "label10";
            // 
            // vMinLabelTarget
            // 
            this.vMinLabelTarget.AutoSize = true;
            this.vMinLabelTarget.Location = new System.Drawing.Point(1720, 680);
            this.vMinLabelTarget.Name = "vMinLabelTarget";
            this.vMinLabelTarget.Size = new System.Drawing.Size(35, 13);
            this.vMinLabelTarget.TabIndex = 38;
            this.vMinLabelTarget.Text = "label9";
            // 
            // sMinLabelTarget
            // 
            this.sMinLabelTarget.AutoSize = true;
            this.sMinLabelTarget.Location = new System.Drawing.Point(1451, 680);
            this.sMinLabelTarget.Name = "sMinLabelTarget";
            this.sMinLabelTarget.Size = new System.Drawing.Size(35, 13);
            this.sMinLabelTarget.TabIndex = 37;
            this.sMinLabelTarget.Text = "label8";
            // 
            // hMinLabelTarget
            // 
            this.hMinLabelTarget.AutoSize = true;
            this.hMinLabelTarget.Location = new System.Drawing.Point(1139, 680);
            this.hMinLabelTarget.Name = "hMinLabelTarget";
            this.hMinLabelTarget.Size = new System.Drawing.Size(35, 13);
            this.hMinLabelTarget.TabIndex = 36;
            this.hMinLabelTarget.Text = "label7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1717, 723);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "V Max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1445, 723);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "S Max";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1139, 723);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "H Max";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1717, 622);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "V Min";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1445, 622);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "S Min";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1139, 622);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "H Min";
            // 
            // vMaxTarget
            // 
            this.vMaxTarget.Location = new System.Drawing.Point(1620, 754);
            this.vMaxTarget.Maximum = 255;
            this.vMaxTarget.Name = "vMaxTarget";
            this.vMaxTarget.Size = new System.Drawing.Size(239, 45);
            this.vMaxTarget.TabIndex = 29;
            this.vMaxTarget.Value = 192;
            // 
            // sMaxTarget
            // 
            this.sMaxTarget.Location = new System.Drawing.Point(1340, 754);
            this.sMaxTarget.Maximum = 255;
            this.sMaxTarget.Name = "sMaxTarget";
            this.sMaxTarget.Size = new System.Drawing.Size(239, 45);
            this.sMaxTarget.TabIndex = 28;
            this.sMaxTarget.Value = 153;
            // 
            // hMaxTarget
            // 
            this.hMaxTarget.Location = new System.Drawing.Point(1053, 754);
            this.hMaxTarget.Maximum = 255;
            this.hMaxTarget.Name = "hMaxTarget";
            this.hMaxTarget.Size = new System.Drawing.Size(239, 45);
            this.hMaxTarget.TabIndex = 27;
            this.hMaxTarget.Value = 71;
            // 
            // vMinTarget
            // 
            this.vMinTarget.Location = new System.Drawing.Point(1620, 648);
            this.vMinTarget.Maximum = 255;
            this.vMinTarget.Name = "vMinTarget";
            this.vMinTarget.Size = new System.Drawing.Size(239, 45);
            this.vMinTarget.TabIndex = 26;
            this.vMinTarget.Value = 58;
            // 
            // sMinTarget
            // 
            this.sMinTarget.Location = new System.Drawing.Point(1340, 648);
            this.sMinTarget.Maximum = 255;
            this.sMinTarget.Name = "sMinTarget";
            this.sMinTarget.Size = new System.Drawing.Size(239, 45);
            this.sMinTarget.TabIndex = 25;
            this.sMinTarget.Value = 19;
            // 
            // hMinTarget
            // 
            this.hMinTarget.Location = new System.Drawing.Point(1053, 648);
            this.hMinTarget.Maximum = 255;
            this.hMinTarget.Name = "hMinTarget";
            this.hMinTarget.Size = new System.Drawing.Size(239, 45);
            this.hMinTarget.TabIndex = 24;
            this.hMinTarget.Value = 28;
            // 
            // maskViewTarget
            // 
            this.maskViewTarget.Location = new System.Drawing.Point(1179, 331);
            this.maskViewTarget.Name = "maskViewTarget";
            this.maskViewTarget.Size = new System.Drawing.Size(400, 225);
            this.maskViewTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maskViewTarget.TabIndex = 43;
            this.maskViewTarget.TabStop = false;
            // 
            // saveLaser
            // 
            this.saveLaser.Location = new System.Drawing.Point(520, 573);
            this.saveLaser.Name = "saveLaser";
            this.saveLaser.Size = new System.Drawing.Size(75, 23);
            this.saveLaser.TabIndex = 44;
            this.saveLaser.Text = "Save";
            this.saveLaser.UseVisualStyleBackColor = true;
            this.saveLaser.Click += new System.EventHandler(this.saveLaser_Click);
            // 
            // saveTarget
            // 
            this.saveTarget.Location = new System.Drawing.Point(1540, 573);
            this.saveTarget.Name = "saveTarget";
            this.saveTarget.Size = new System.Drawing.Size(75, 23);
            this.saveTarget.TabIndex = 45;
            this.saveTarget.Text = "Save";
            this.saveTarget.UseVisualStyleBackColor = true;
            this.saveTarget.Click += new System.EventHandler(this.saveTarget_Click);
            // 
            // derValue
            // 
            this.derValue.AutoSize = true;
            this.derValue.Location = new System.Drawing.Point(1211, 992);
            this.derValue.Name = "derValue";
            this.derValue.Size = new System.Drawing.Size(41, 13);
            this.derValue.TabIndex = 54;
            this.derValue.Text = "label12";
            // 
            // intValue
            // 
            this.intValue.AutoSize = true;
            this.intValue.Location = new System.Drawing.Point(926, 992);
            this.intValue.Name = "intValue";
            this.intValue.Size = new System.Drawing.Size(41, 13);
            this.intValue.TabIndex = 53;
            this.intValue.Text = "label11";
            // 
            // propValue
            // 
            this.propValue.AutoSize = true;
            this.propValue.Location = new System.Drawing.Point(632, 992);
            this.propValue.Name = "propValue";
            this.propValue.Size = new System.Drawing.Size(41, 13);
            this.propValue.TabIndex = 52;
            this.propValue.Text = "label10";
            // 
            // derLabel
            // 
            this.derLabel.AutoSize = true;
            this.derLabel.Location = new System.Drawing.Point(1197, 929);
            this.derLabel.Name = "derLabel";
            this.derLabel.Size = new System.Drawing.Size(55, 13);
            this.derLabel.TabIndex = 51;
            this.derLabel.Text = "Derivative";
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(925, 929);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(42, 13);
            this.intLabel.TabIndex = 50;
            this.intLabel.Text = "Integral";
            // 
            // propLabel
            // 
            this.propLabel.AutoSize = true;
            this.propLabel.Location = new System.Drawing.Point(619, 929);
            this.propLabel.Name = "propLabel";
            this.propLabel.Size = new System.Drawing.Size(63, 13);
            this.propLabel.TabIndex = 49;
            this.propLabel.Text = "Proportional";
            // 
            // derivativeK
            // 
            this.derivativeK.Location = new System.Drawing.Point(1100, 960);
            this.derivativeK.Maximum = 20;
            this.derivativeK.Name = "derivativeK";
            this.derivativeK.Size = new System.Drawing.Size(239, 45);
            this.derivativeK.TabIndex = 48;
            // 
            // integralK
            // 
            this.integralK.Location = new System.Drawing.Point(820, 960);
            this.integralK.Maximum = 20;
            this.integralK.Name = "integralK";
            this.integralK.Size = new System.Drawing.Size(239, 45);
            this.integralK.TabIndex = 47;
            // 
            // proportionalK
            // 
            this.proportionalK.Location = new System.Drawing.Point(533, 960);
            this.proportionalK.Maximum = 20;
            this.proportionalK.Name = "proportionalK";
            this.proportionalK.Size = new System.Drawing.Size(239, 45);
            this.proportionalK.TabIndex = 46;
            this.proportionalK.Value = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(896, 867);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "PID";
            // 
            // pidSave
            // 
            this.pidSave.Location = new System.Drawing.Point(947, 862);
            this.pidSave.Name = "pidSave";
            this.pidSave.Size = new System.Drawing.Size(75, 23);
            this.pidSave.TabIndex = 56;
            this.pidSave.Text = "Save";
            this.pidSave.UseVisualStyleBackColor = true;
            this.pidSave.Click += new System.EventHandler(this.pidSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pidSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.derValue);
            this.Controls.Add(this.intValue);
            this.Controls.Add(this.propValue);
            this.Controls.Add(this.derLabel);
            this.Controls.Add(this.intLabel);
            this.Controls.Add(this.propLabel);
            this.Controls.Add(this.derivativeK);
            this.Controls.Add(this.integralK);
            this.Controls.Add(this.proportionalK);
            this.Controls.Add(this.saveTarget);
            this.Controls.Add(this.saveLaser);
            this.Controls.Add(this.maskViewTarget);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vMaxLabelTarget);
            this.Controls.Add(this.sMaxLabelTarget);
            this.Controls.Add(this.hMaxLabelTarget);
            this.Controls.Add(this.vMinLabelTarget);
            this.Controls.Add(this.sMinLabelTarget);
            this.Controls.Add(this.hMinLabelTarget);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.vMaxTarget);
            this.Controls.Add(this.sMaxTarget);
            this.Controls.Add(this.hMaxTarget);
            this.Controls.Add(this.vMinTarget);
            this.Controls.Add(this.sMinTarget);
            this.Controls.Add(this.hMinTarget);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vMaxLabelLaser);
            this.Controls.Add(this.sMaxLabelLaser);
            this.Controls.Add(this.hMaxLabelLaser);
            this.Controls.Add(this.vMinLabelLaser);
            this.Controls.Add(this.sMinLabelLaser);
            this.Controls.Add(this.hMinLabelLaser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vMaxLaser);
            this.Controls.Add(this.sMaxLaser);
            this.Controls.Add(this.hMaxLaser);
            this.Controls.Add(this.vMinLaser);
            this.Controls.Add(this.sMinLaser);
            this.Controls.Add(this.hMinLaser);
            this.Controls.Add(this.maskViewLaser);
            this.Controls.Add(this.imageView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskViewLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMinLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMinLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMinLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMaxLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMaxLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMaxLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMaxTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMaxTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMaxTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMinTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMinTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMinTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskViewTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derivativeK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proportionalK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageView;
        private Emgu.CV.UI.ImageBox maskViewLaser;
        private System.Windows.Forms.TrackBar hMinLaser;
        private System.Windows.Forms.TrackBar sMinLaser;
        private System.Windows.Forms.TrackBar vMinLaser;
        private System.Windows.Forms.TrackBar hMaxLaser;
        private System.Windows.Forms.TrackBar sMaxLaser;
        private System.Windows.Forms.TrackBar vMaxLaser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hMinLabelLaser;
        private System.Windows.Forms.Label sMinLabelLaser;
        private System.Windows.Forms.Label vMinLabelLaser;
        private System.Windows.Forms.Label hMaxLabelLaser;
        private System.Windows.Forms.Label sMaxLabelLaser;
        private System.Windows.Forms.Label vMaxLabelLaser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label vMaxLabelTarget;
        private System.Windows.Forms.Label sMaxLabelTarget;
        private System.Windows.Forms.Label hMaxLabelTarget;
        private System.Windows.Forms.Label vMinLabelTarget;
        private System.Windows.Forms.Label sMinLabelTarget;
        private System.Windows.Forms.Label hMinLabelTarget;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar vMaxTarget;
        private System.Windows.Forms.TrackBar sMaxTarget;
        private System.Windows.Forms.TrackBar hMaxTarget;
        private System.Windows.Forms.TrackBar vMinTarget;
        private System.Windows.Forms.TrackBar sMinTarget;
        private System.Windows.Forms.TrackBar hMinTarget;
        private Emgu.CV.UI.ImageBox maskViewTarget;
        private System.Windows.Forms.Button saveLaser;
        private System.Windows.Forms.Button saveTarget;
        private System.Windows.Forms.Label derValue;
        private System.Windows.Forms.Label intValue;
        private System.Windows.Forms.Label propValue;
        private System.Windows.Forms.Label derLabel;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label propLabel;
        private System.Windows.Forms.TrackBar derivativeK;
        private System.Windows.Forms.TrackBar integralK;
        private System.Windows.Forms.TrackBar proportionalK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button pidSave;
    }
}


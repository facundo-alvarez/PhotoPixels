namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.photoViewer = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameData = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.heightData = new System.Windows.Forms.Label();
            this.widthData = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whiteData = new System.Windows.Forms.Label();
            this.blackData = new System.Windows.Forms.Label();
            this.greyData = new System.Windows.Forms.Label();
            this.raspberryData = new System.Windows.Forms.Label();
            this.magentaData = new System.Windows.Forms.Label();
            this.violetData = new System.Windows.Forms.Label();
            this.blueData = new System.Windows.Forms.Label();
            this.lblueData = new System.Windows.Forms.Label();
            this.cyanData = new System.Windows.Forms.Label();
            this.turquoiseData = new System.Windows.Forms.Label();
            this.greenData = new System.Windows.Forms.Label();
            this.lgreenData = new System.Windows.Forms.Label();
            this.yellowData = new System.Windows.Forms.Label();
            this.orangeData = new System.Windows.Forms.Label();
            this.redData = new System.Windows.Forms.Label();
            this.whiteLabel = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.greyLabel = new System.Windows.Forms.Label();
            this.raspberryLabel = new System.Windows.Forms.Label();
            this.magentaLabel = new System.Windows.Forms.Label();
            this.violetLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.lblueLabel = new System.Windows.Forms.Label();
            this.cyanLabel = new System.Windows.Forms.Label();
            this.turquoiseLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.lgreenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoViewer
            // 
            this.photoViewer.Location = new System.Drawing.Point(12, 47);
            this.photoViewer.Name = "photoViewer";
            this.photoViewer.Size = new System.Drawing.Size(570, 391);
            this.photoViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoViewer.TabIndex = 0;
            this.photoViewer.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(86, 29);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameData);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.heightData);
            this.groupBox1.Controls.Add(this.widthData);
            this.groupBox1.Controls.Add(this.heightLabel);
            this.groupBox1.Controls.Add(this.widthLabel);
            this.groupBox1.Location = new System.Drawing.Point(588, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meta Data";
            // 
            // nameData
            // 
            this.nameData.AutoSize = true;
            this.nameData.Location = new System.Drawing.Point(111, 19);
            this.nameData.Name = "nameData";
            this.nameData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.nameData.Size = new System.Drawing.Size(0, 20);
            this.nameData.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Location = new System.Drawing.Point(3, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // heightData
            // 
            this.heightData.AutoSize = true;
            this.heightData.Location = new System.Drawing.Point(111, 59);
            this.heightData.Name = "heightData";
            this.heightData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.heightData.Size = new System.Drawing.Size(0, 20);
            this.heightData.TabIndex = 3;
            // 
            // widthData
            // 
            this.widthData.AutoSize = true;
            this.widthData.Location = new System.Drawing.Point(111, 39);
            this.widthData.Name = "widthData";
            this.widthData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.widthData.Size = new System.Drawing.Size(0, 20);
            this.widthData.TabIndex = 2;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.heightLabel.Location = new System.Drawing.Point(3, 39);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.heightLabel.Size = new System.Drawing.Size(46, 20);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.widthLabel.Location = new System.Drawing.Point(3, 19);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.widthLabel.Size = new System.Drawing.Size(42, 20);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whiteData);
            this.groupBox2.Controls.Add(this.blackData);
            this.groupBox2.Controls.Add(this.greyData);
            this.groupBox2.Controls.Add(this.raspberryData);
            this.groupBox2.Controls.Add(this.magentaData);
            this.groupBox2.Controls.Add(this.violetData);
            this.groupBox2.Controls.Add(this.blueData);
            this.groupBox2.Controls.Add(this.lblueData);
            this.groupBox2.Controls.Add(this.cyanData);
            this.groupBox2.Controls.Add(this.turquoiseData);
            this.groupBox2.Controls.Add(this.greenData);
            this.groupBox2.Controls.Add(this.lgreenData);
            this.groupBox2.Controls.Add(this.yellowData);
            this.groupBox2.Controls.Add(this.orangeData);
            this.groupBox2.Controls.Add(this.redData);
            this.groupBox2.Controls.Add(this.whiteLabel);
            this.groupBox2.Controls.Add(this.blackLabel);
            this.groupBox2.Controls.Add(this.greyLabel);
            this.groupBox2.Controls.Add(this.raspberryLabel);
            this.groupBox2.Controls.Add(this.magentaLabel);
            this.groupBox2.Controls.Add(this.violetLabel);
            this.groupBox2.Controls.Add(this.blueLabel);
            this.groupBox2.Controls.Add(this.lblueLabel);
            this.groupBox2.Controls.Add(this.cyanLabel);
            this.groupBox2.Controls.Add(this.turquoiseLabel);
            this.groupBox2.Controls.Add(this.greenLabel);
            this.groupBox2.Controls.Add(this.lgreenLabel);
            this.groupBox2.Controls.Add(this.yellowLabel);
            this.groupBox2.Controls.Add(this.orangeLabel);
            this.groupBox2.Controls.Add(this.redLabel);
            this.groupBox2.Location = new System.Drawing.Point(588, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 309);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pixel Data";
            // 
            // whiteData
            // 
            this.whiteData.AutoSize = true;
            this.whiteData.Location = new System.Drawing.Point(111, 285);
            this.whiteData.Name = "whiteData";
            this.whiteData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.whiteData.Size = new System.Drawing.Size(10, 19);
            this.whiteData.TabIndex = 29;
            this.whiteData.Text = ".";
            // 
            // blackData
            // 
            this.blackData.AutoSize = true;
            this.blackData.Location = new System.Drawing.Point(111, 266);
            this.blackData.Name = "blackData";
            this.blackData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.blackData.Size = new System.Drawing.Size(10, 19);
            this.blackData.TabIndex = 28;
            this.blackData.Text = ".";
            // 
            // greyData
            // 
            this.greyData.AutoSize = true;
            this.greyData.Location = new System.Drawing.Point(111, 247);
            this.greyData.Name = "greyData";
            this.greyData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.greyData.Size = new System.Drawing.Size(10, 19);
            this.greyData.TabIndex = 27;
            this.greyData.Text = ".";
            // 
            // raspberryData
            // 
            this.raspberryData.AutoSize = true;
            this.raspberryData.Location = new System.Drawing.Point(111, 228);
            this.raspberryData.Name = "raspberryData";
            this.raspberryData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.raspberryData.Size = new System.Drawing.Size(10, 19);
            this.raspberryData.TabIndex = 26;
            this.raspberryData.Text = ".";
            // 
            // magentaData
            // 
            this.magentaData.AutoSize = true;
            this.magentaData.Location = new System.Drawing.Point(111, 209);
            this.magentaData.Name = "magentaData";
            this.magentaData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.magentaData.Size = new System.Drawing.Size(10, 19);
            this.magentaData.TabIndex = 25;
            this.magentaData.Text = ".";
            // 
            // violetData
            // 
            this.violetData.AutoSize = true;
            this.violetData.Location = new System.Drawing.Point(111, 190);
            this.violetData.Name = "violetData";
            this.violetData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.violetData.Size = new System.Drawing.Size(10, 19);
            this.violetData.TabIndex = 24;
            this.violetData.Text = ".";
            // 
            // blueData
            // 
            this.blueData.AutoSize = true;
            this.blueData.Location = new System.Drawing.Point(111, 171);
            this.blueData.Name = "blueData";
            this.blueData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.blueData.Size = new System.Drawing.Size(10, 19);
            this.blueData.TabIndex = 23;
            this.blueData.Text = ".";
            // 
            // lblueData
            // 
            this.lblueData.AutoSize = true;
            this.lblueData.Location = new System.Drawing.Point(111, 152);
            this.lblueData.Name = "lblueData";
            this.lblueData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblueData.Size = new System.Drawing.Size(10, 19);
            this.lblueData.TabIndex = 22;
            this.lblueData.Text = ".";
            // 
            // cyanData
            // 
            this.cyanData.AutoSize = true;
            this.cyanData.Location = new System.Drawing.Point(111, 133);
            this.cyanData.Name = "cyanData";
            this.cyanData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.cyanData.Size = new System.Drawing.Size(10, 19);
            this.cyanData.TabIndex = 21;
            this.cyanData.Text = ".";
            // 
            // turquoiseData
            // 
            this.turquoiseData.AutoSize = true;
            this.turquoiseData.Location = new System.Drawing.Point(111, 114);
            this.turquoiseData.Name = "turquoiseData";
            this.turquoiseData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.turquoiseData.Size = new System.Drawing.Size(10, 19);
            this.turquoiseData.TabIndex = 20;
            this.turquoiseData.Text = ".";
            // 
            // greenData
            // 
            this.greenData.AutoSize = true;
            this.greenData.Location = new System.Drawing.Point(111, 95);
            this.greenData.Name = "greenData";
            this.greenData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.greenData.Size = new System.Drawing.Size(10, 19);
            this.greenData.TabIndex = 19;
            this.greenData.Text = ".";
            // 
            // lgreenData
            // 
            this.lgreenData.AutoSize = true;
            this.lgreenData.Location = new System.Drawing.Point(111, 76);
            this.lgreenData.Name = "lgreenData";
            this.lgreenData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lgreenData.Size = new System.Drawing.Size(10, 19);
            this.lgreenData.TabIndex = 18;
            this.lgreenData.Text = ".";
            // 
            // yellowData
            // 
            this.yellowData.AutoSize = true;
            this.yellowData.Location = new System.Drawing.Point(111, 57);
            this.yellowData.Name = "yellowData";
            this.yellowData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.yellowData.Size = new System.Drawing.Size(10, 19);
            this.yellowData.TabIndex = 17;
            this.yellowData.Text = ".";
            // 
            // orangeData
            // 
            this.orangeData.AutoSize = true;
            this.orangeData.Location = new System.Drawing.Point(111, 38);
            this.orangeData.Name = "orangeData";
            this.orangeData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.orangeData.Size = new System.Drawing.Size(10, 19);
            this.orangeData.TabIndex = 16;
            this.orangeData.Text = ".";
            // 
            // redData
            // 
            this.redData.AutoSize = true;
            this.redData.Location = new System.Drawing.Point(111, 19);
            this.redData.Name = "redData";
            this.redData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.redData.Size = new System.Drawing.Size(10, 19);
            this.redData.TabIndex = 15;
            this.redData.Text = ".";
            // 
            // whiteLabel
            // 
            this.whiteLabel.AutoSize = true;
            this.whiteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.whiteLabel.Location = new System.Drawing.Point(3, 285);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.whiteLabel.Size = new System.Drawing.Size(41, 19);
            this.whiteLabel.TabIndex = 14;
            this.whiteLabel.Text = "White:";
            // 
            // blackLabel
            // 
            this.blackLabel.AutoSize = true;
            this.blackLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.blackLabel.Location = new System.Drawing.Point(3, 266);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.blackLabel.Size = new System.Drawing.Size(38, 19);
            this.blackLabel.TabIndex = 13;
            this.blackLabel.Text = "Black:";
            // 
            // greyLabel
            // 
            this.greyLabel.AutoSize = true;
            this.greyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.greyLabel.Location = new System.Drawing.Point(3, 247);
            this.greyLabel.Name = "greyLabel";
            this.greyLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.greyLabel.Size = new System.Drawing.Size(34, 19);
            this.greyLabel.TabIndex = 12;
            this.greyLabel.Text = "Grey:";
            // 
            // raspberryLabel
            // 
            this.raspberryLabel.AutoSize = true;
            this.raspberryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.raspberryLabel.Location = new System.Drawing.Point(3, 228);
            this.raspberryLabel.Name = "raspberryLabel";
            this.raspberryLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.raspberryLabel.Size = new System.Drawing.Size(62, 19);
            this.raspberryLabel.TabIndex = 11;
            this.raspberryLabel.Text = "Raspberry:";
            // 
            // magentaLabel
            // 
            this.magentaLabel.AutoSize = true;
            this.magentaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.magentaLabel.Location = new System.Drawing.Point(3, 209);
            this.magentaLabel.Name = "magentaLabel";
            this.magentaLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.magentaLabel.Size = new System.Drawing.Size(57, 19);
            this.magentaLabel.TabIndex = 10;
            this.magentaLabel.Text = "Magenta:";
            // 
            // violetLabel
            // 
            this.violetLabel.AutoSize = true;
            this.violetLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.violetLabel.Location = new System.Drawing.Point(3, 190);
            this.violetLabel.Name = "violetLabel";
            this.violetLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.violetLabel.Size = new System.Drawing.Size(40, 19);
            this.violetLabel.TabIndex = 9;
            this.violetLabel.Text = "Violet:";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.blueLabel.Location = new System.Drawing.Point(3, 171);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.blueLabel.Size = new System.Drawing.Size(33, 19);
            this.blueLabel.TabIndex = 8;
            this.blueLabel.Text = "Blue:";
            // 
            // lblueLabel
            // 
            this.lblueLabel.AutoSize = true;
            this.lblueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblueLabel.Location = new System.Drawing.Point(3, 152);
            this.lblueLabel.Name = "lblueLabel";
            this.lblueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblueLabel.Size = new System.Drawing.Size(63, 19);
            this.lblueLabel.TabIndex = 7;
            this.lblueLabel.Text = "Light Blue:";
            // 
            // cyanLabel
            // 
            this.cyanLabel.AutoSize = true;
            this.cyanLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cyanLabel.Location = new System.Drawing.Point(3, 133);
            this.cyanLabel.Name = "cyanLabel";
            this.cyanLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.cyanLabel.Size = new System.Drawing.Size(37, 19);
            this.cyanLabel.TabIndex = 6;
            this.cyanLabel.Text = "Cyan:";
            // 
            // turquoiseLabel
            // 
            this.turquoiseLabel.AutoSize = true;
            this.turquoiseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.turquoiseLabel.Location = new System.Drawing.Point(3, 114);
            this.turquoiseLabel.Name = "turquoiseLabel";
            this.turquoiseLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.turquoiseLabel.Size = new System.Drawing.Size(62, 19);
            this.turquoiseLabel.TabIndex = 5;
            this.turquoiseLabel.Text = "Turquoise:";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.greenLabel.Location = new System.Drawing.Point(3, 95);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.greenLabel.Size = new System.Drawing.Size(41, 19);
            this.greenLabel.TabIndex = 4;
            this.greenLabel.Text = "Green:";
            // 
            // lgreenLabel
            // 
            this.lgreenLabel.AutoSize = true;
            this.lgreenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lgreenLabel.Location = new System.Drawing.Point(3, 76);
            this.lgreenLabel.Name = "lgreenLabel";
            this.lgreenLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lgreenLabel.Size = new System.Drawing.Size(71, 19);
            this.lgreenLabel.TabIndex = 3;
            this.lgreenLabel.Text = "Light Green:";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.yellowLabel.Location = new System.Drawing.Point(3, 57);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.yellowLabel.Size = new System.Drawing.Size(44, 19);
            this.yellowLabel.TabIndex = 2;
            this.yellowLabel.Text = "Yellow:";
            // 
            // orangeLabel
            // 
            this.orangeLabel.AutoSize = true;
            this.orangeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orangeLabel.Location = new System.Drawing.Point(3, 38);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.orangeLabel.Size = new System.Drawing.Size(49, 19);
            this.orangeLabel.TabIndex = 1;
            this.orangeLabel.Text = "Orange:";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.redLabel.Location = new System.Drawing.Point(3, 19);
            this.redLabel.Name = "redLabel";
            this.redLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.redLabel.Size = new System.Drawing.Size(30, 19);
            this.redLabel.TabIndex = 0;
            this.redLabel.Text = "Red:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.photoViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox photoViewer;
        private Button openButton;
        private GroupBox groupBox1;
        private Label widthLabel;
        private Label heightData;
        private Label widthData;
        private Label heightLabel;
        private Label nameData;
        private Label nameLabel;
        private GroupBox groupBox2;
        private Label raspberryLabel;
        private Label magentaLabel;
        private Label violetLabel;
        private Label blueLabel;
        private Label lblueLabel;
        private Label cyanLabel;
        private Label turquoiseLabel;
        private Label greenLabel;
        private Label lgreenLabel;
        private Label yellowLabel;
        private Label orangeLabel;
        private Label redLabel;
        private Label whiteData;
        private Label blackData;
        private Label greyData;
        private Label raspberryData;
        private Label magentaData;
        private Label violetData;
        private Label blueData;
        private Label lblueData;
        private Label cyanData;
        private Label turquoiseData;
        private Label greenData;
        private Label lgreenData;
        private Label yellowData;
        private Label orangeData;
        private Label redData;
        private Label whiteLabel;
        private Label blackLabel;
        private Label greyLabel;
    }
}
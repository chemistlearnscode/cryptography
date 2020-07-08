namespace cryptography
{
    partial class FormRSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRSA));
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnRSAtoDES = new System.Windows.Forms.Button();
            this.btnRSAtoAES = new System.Windows.Forms.Button();
            this.btnRSAitself = new System.Windows.Forms.Button();
            this.btnRSAtoSHA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnOpenFolderIn = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnOutOpen = new System.Windows.Forms.Button();
            this.comboBoxLengKey = new System.Windows.Forms.ComboBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.clockRSA = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpenFileIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockRSA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.White;
            this.btnMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMessage.BackgroundImage")));
            this.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Location = new System.Drawing.Point(487, 169);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(275, 103);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnRSAtoDES
            // 
            this.btnRSAtoDES.BackColor = System.Drawing.Color.Transparent;
            this.btnRSAtoDES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRSAtoDES.BackgroundImage")));
            this.btnRSAtoDES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSAtoDES.FlatAppearance.BorderSize = 0;
            this.btnRSAtoDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSAtoDES.Location = new System.Drawing.Point(459, 318);
            this.btnRSAtoDES.Name = "btnRSAtoDES";
            this.btnRSAtoDES.Size = new System.Drawing.Size(84, 83);
            this.btnRSAtoDES.TabIndex = 1;
            this.btnRSAtoDES.UseVisualStyleBackColor = false;
            this.btnRSAtoDES.Click += new System.EventHandler(this.btnRSAtoDES_Click);
            // 
            // btnRSAtoAES
            // 
            this.btnRSAtoAES.BackColor = System.Drawing.Color.Transparent;
            this.btnRSAtoAES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRSAtoAES.BackgroundImage")));
            this.btnRSAtoAES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSAtoAES.FlatAppearance.BorderSize = 0;
            this.btnRSAtoAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSAtoAES.Location = new System.Drawing.Point(540, 318);
            this.btnRSAtoAES.Name = "btnRSAtoAES";
            this.btnRSAtoAES.Size = new System.Drawing.Size(84, 83);
            this.btnRSAtoAES.TabIndex = 1;
            this.btnRSAtoAES.UseVisualStyleBackColor = false;
            this.btnRSAtoAES.Click += new System.EventHandler(this.btnRSAtoAES_Click);
            // 
            // btnRSAitself
            // 
            this.btnRSAitself.BackColor = System.Drawing.Color.Transparent;
            this.btnRSAitself.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRSAitself.BackgroundImage")));
            this.btnRSAitself.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSAitself.FlatAppearance.BorderSize = 0;
            this.btnRSAitself.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSAitself.Location = new System.Drawing.Point(622, 319);
            this.btnRSAitself.Name = "btnRSAitself";
            this.btnRSAitself.Size = new System.Drawing.Size(84, 83);
            this.btnRSAitself.TabIndex = 1;
            this.btnRSAitself.UseVisualStyleBackColor = false;
            this.btnRSAitself.Click += new System.EventHandler(this.btnRSAitself_Click);
            // 
            // btnRSAtoSHA
            // 
            this.btnRSAtoSHA.BackColor = System.Drawing.Color.Transparent;
            this.btnRSAtoSHA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRSAtoSHA.BackgroundImage")));
            this.btnRSAtoSHA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSAtoSHA.FlatAppearance.BorderSize = 0;
            this.btnRSAtoSHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSAtoSHA.Location = new System.Drawing.Point(703, 314);
            this.btnRSAtoSHA.Name = "btnRSAtoSHA";
            this.btnRSAtoSHA.Size = new System.Drawing.Size(85, 86);
            this.btnRSAtoSHA.TabIndex = 1;
            this.btnRSAtoSHA.UseVisualStyleBackColor = false;
            this.btnRSAtoSHA.Click += new System.EventHandler(this.btnRSAtoSHA_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(718, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(131, 82);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(211, 20);
            this.tbInput.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(22, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 28);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(22, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 29);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(22, 253);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 29);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(129, 257);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(210, 20);
            this.tbOutput.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(23, 301);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 53);
            this.btnReset.TabIndex = 11;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.BackgroundImage")));
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(131, 309);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(101, 34);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.BackgroundImage")));
            this.btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Location = new System.Drawing.Point(241, 309);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(101, 34);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnOpenFolderIn
            // 
            this.btnOpenFolderIn.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFolderIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFolderIn.BackgroundImage")));
            this.btnOpenFolderIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFolderIn.FlatAppearance.BorderSize = 0;
            this.btnOpenFolderIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderIn.Location = new System.Drawing.Point(396, 71);
            this.btnOpenFolderIn.Name = "btnOpenFolderIn";
            this.btnOpenFolderIn.Size = new System.Drawing.Size(39, 31);
            this.btnOpenFolderIn.TabIndex = 14;
            this.btnOpenFolderIn.UseVisualStyleBackColor = false;
            this.btnOpenFolderIn.Click += new System.EventHandler(this.btnOpenFolderIn_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateKey.BackgroundImage")));
            this.btnGenerateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateKey.FlatAppearance.BorderSize = 0;
            this.btnGenerateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateKey.Location = new System.Drawing.Point(252, 118);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(39, 31);
            this.btnGenerateKey.TabIndex = 15;
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnOutOpen
            // 
            this.btnOutOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOutOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOutOpen.BackgroundImage")));
            this.btnOutOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutOpen.FlatAppearance.BorderSize = 0;
            this.btnOutOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutOpen.Location = new System.Drawing.Point(362, 251);
            this.btnOutOpen.Name = "btnOutOpen";
            this.btnOutOpen.Size = new System.Drawing.Size(39, 31);
            this.btnOutOpen.TabIndex = 16;
            this.btnOutOpen.UseVisualStyleBackColor = false;
            this.btnOutOpen.Click += new System.EventHandler(this.btnOutOpen_Click);
            // 
            // comboBoxLengKey
            // 
            this.comboBoxLengKey.FormattingEnabled = true;
            this.comboBoxLengKey.Location = new System.Drawing.Point(129, 124);
            this.comboBoxLengKey.Name = "comboBoxLengKey";
            this.comboBoxLengKey.Size = new System.Drawing.Size(93, 21);
            this.comboBoxLengKey.TabIndex = 17;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(133, 173);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(119, 20);
            this.tbN.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(24, 208);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(82, 39);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(132, 214);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(89, 20);
            this.tbD.TabIndex = 20;
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(311, 209);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(89, 20);
            this.tbE.TabIndex = 21;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(227, 199);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(82, 39);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // clockRSA
            // 
            this.clockRSA.BackColor = System.Drawing.Color.Transparent;
            this.clockRSA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clockRSA.BackgroundImage")));
            this.clockRSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clockRSA.Location = new System.Drawing.Point(24, 360);
            this.clockRSA.Name = "clockRSA";
            this.clockRSA.Size = new System.Drawing.Size(82, 62);
            this.clockRSA.TabIndex = 23;
            this.clockRSA.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(135, 382);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 20);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFileIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFileIn.BackgroundImage")));
            this.btnOpenFileIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFileIn.FlatAppearance.BorderSize = 0;
            this.btnOpenFileIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFileIn.Location = new System.Drawing.Point(351, 71);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(39, 31);
            this.btnOpenFileIn.TabIndex = 25;
            this.btnOpenFileIn.UseVisualStyleBackColor = false;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenFileIn_Click);
            // 
            // FormRSA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenFileIn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.clockRSA);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.comboBoxLengKey);
            this.Controls.Add(this.btnOutOpen);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.btnOpenFolderIn);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRSAtoSHA);
            this.Controls.Add(this.btnRSAitself);
            this.Controls.Add(this.btnRSAtoAES);
            this.Controls.Add(this.btnRSAtoDES);
            this.Controls.Add(this.btnMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRSA";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormRSA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockRSA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnRSAtoDES;
        private System.Windows.Forms.Button btnRSAtoAES;
        private System.Windows.Forms.Button btnRSAitself;
        private System.Windows.Forms.Button btnRSAtoSHA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnOpenFolderIn;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnOutOpen;
        private System.Windows.Forms.ComboBox comboBoxLengKey;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox clockRSA;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpenFileIn;
    }
}


namespace cryptography
{
    partial class FormAES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAES));
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnAEStoDES = new System.Windows.Forms.Button();
            this.btnAESitself = new System.Windows.Forms.Button();
            this.btnAEStoRSA = new System.Windows.Forms.Button();
            this.btnAEStoSHA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnOpenFolderIn = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnOutOpen = new System.Windows.Forms.Button();
            this.clockAES = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbSelectKeyLength = new System.Windows.Forms.ComboBox();
            this.btnOpenFileIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockAES)).BeginInit();
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
            // btnAEStoDES
            // 
            this.btnAEStoDES.BackColor = System.Drawing.Color.Transparent;
            this.btnAEStoDES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAEStoDES.BackgroundImage")));
            this.btnAEStoDES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAEStoDES.FlatAppearance.BorderSize = 0;
            this.btnAEStoDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAEStoDES.Location = new System.Drawing.Point(459, 318);
            this.btnAEStoDES.Name = "btnAEStoDES";
            this.btnAEStoDES.Size = new System.Drawing.Size(84, 83);
            this.btnAEStoDES.TabIndex = 1;
            this.btnAEStoDES.UseVisualStyleBackColor = false;
            this.btnAEStoDES.Click += new System.EventHandler(this.btnAEStoDES_Click);
            // 
            // btnAESitself
            // 
            this.btnAESitself.BackColor = System.Drawing.Color.Transparent;
            this.btnAESitself.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAESitself.BackgroundImage")));
            this.btnAESitself.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAESitself.FlatAppearance.BorderSize = 0;
            this.btnAESitself.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAESitself.Location = new System.Drawing.Point(540, 318);
            this.btnAESitself.Name = "btnAESitself";
            this.btnAESitself.Size = new System.Drawing.Size(84, 83);
            this.btnAESitself.TabIndex = 1;
            this.btnAESitself.UseVisualStyleBackColor = false;
            this.btnAESitself.Click += new System.EventHandler(this.btnAESitself_Click);
            // 
            // btnAEStoRSA
            // 
            this.btnAEStoRSA.BackColor = System.Drawing.Color.Transparent;
            this.btnAEStoRSA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAEStoRSA.BackgroundImage")));
            this.btnAEStoRSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAEStoRSA.FlatAppearance.BorderSize = 0;
            this.btnAEStoRSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAEStoRSA.Location = new System.Drawing.Point(622, 319);
            this.btnAEStoRSA.Name = "btnAEStoRSA";
            this.btnAEStoRSA.Size = new System.Drawing.Size(84, 83);
            this.btnAEStoRSA.TabIndex = 1;
            this.btnAEStoRSA.UseVisualStyleBackColor = false;
            this.btnAEStoRSA.Click += new System.EventHandler(this.btnAEStoRSA_Click);
            // 
            // btnAEStoSHA
            // 
            this.btnAEStoSHA.BackColor = System.Drawing.Color.Transparent;
            this.btnAEStoSHA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAEStoSHA.BackgroundImage")));
            this.btnAEStoSHA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAEStoSHA.FlatAppearance.BorderSize = 0;
            this.btnAEStoSHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAEStoSHA.Location = new System.Drawing.Point(703, 314);
            this.btnAEStoSHA.Name = "btnAEStoSHA";
            this.btnAEStoSHA.Size = new System.Drawing.Size(85, 86);
            this.btnAEStoSHA.TabIndex = 1;
            this.btnAEStoSHA.UseVisualStyleBackColor = false;
            this.btnAEStoSHA.Click += new System.EventHandler(this.btnAEStoSHA_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(18, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(131, 108);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(211, 20);
            this.tbInput.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(22, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 28);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(130, 153);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(119, 20);
            this.tbKey.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(22, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 29);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(130, 201);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(210, 21);
            this.comboBoxMode.TabIndex = 8;
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
            this.btnOpenFolderIn.Location = new System.Drawing.Point(407, 97);
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
            this.btnGenerateKey.Location = new System.Drawing.Point(362, 142);
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
            // clockAES
            // 
            this.clockAES.BackColor = System.Drawing.Color.Transparent;
            this.clockAES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clockAES.BackgroundImage")));
            this.clockAES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clockAES.Location = new System.Drawing.Point(26, 378);
            this.clockAES.Name = "clockAES";
            this.clockAES.Size = new System.Drawing.Size(71, 52);
            this.clockAES.TabIndex = 17;
            this.clockAES.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(133, 393);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 22);
            this.progressBar1.TabIndex = 18;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // cbSelectKeyLength
            // 
            this.cbSelectKeyLength.FormattingEnabled = true;
            this.cbSelectKeyLength.Location = new System.Drawing.Point(265, 152);
            this.cbSelectKeyLength.Name = "cbSelectKeyLength";
            this.cbSelectKeyLength.Size = new System.Drawing.Size(76, 21);
            this.cbSelectKeyLength.TabIndex = 19;
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFileIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFileIn.BackgroundImage")));
            this.btnOpenFileIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFileIn.FlatAppearance.BorderSize = 0;
            this.btnOpenFileIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFileIn.Location = new System.Drawing.Point(362, 97);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(39, 31);
            this.btnOpenFileIn.TabIndex = 20;
            this.btnOpenFileIn.UseVisualStyleBackColor = false;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenFileIn_Click);
            // 
            // FormAES
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenFileIn);
            this.Controls.Add(this.cbSelectKeyLength);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.clockAES);
            this.Controls.Add(this.btnOutOpen);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.btnOpenFolderIn);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAEStoSHA);
            this.Controls.Add(this.btnAEStoRSA);
            this.Controls.Add(this.btnAESitself);
            this.Controls.Add(this.btnAEStoDES);
            this.Controls.Add(this.btnMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAES";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormAES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockAES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnAEStoDES;
        private System.Windows.Forms.Button btnAESitself;
        private System.Windows.Forms.Button btnAEStoRSA;
        private System.Windows.Forms.Button btnAEStoSHA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnOpenFolderIn;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnOutOpen;
        private System.Windows.Forms.PictureBox clockAES;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cbSelectKeyLength;
        private System.Windows.Forms.Button btnOpenFileIn;
    }
}


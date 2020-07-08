namespace cryptography
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnDES = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnSHA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            // btnDES
            // 
            this.btnDES.BackColor = System.Drawing.Color.Transparent;
            this.btnDES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDES.BackgroundImage")));
            this.btnDES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDES.FlatAppearance.BorderSize = 0;
            this.btnDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDES.Location = new System.Drawing.Point(459, 318);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(84, 83);
            this.btnDES.TabIndex = 1;
            this.btnDES.UseVisualStyleBackColor = false;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // btnAES
            // 
            this.btnAES.BackColor = System.Drawing.Color.Transparent;
            this.btnAES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAES.BackgroundImage")));
            this.btnAES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAES.FlatAppearance.BorderSize = 0;
            this.btnAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAES.Location = new System.Drawing.Point(540, 318);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(84, 83);
            this.btnAES.TabIndex = 1;
            this.btnAES.UseVisualStyleBackColor = false;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.BackColor = System.Drawing.Color.Transparent;
            this.btnRSA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRSA.BackgroundImage")));
            this.btnRSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSA.FlatAppearance.BorderSize = 0;
            this.btnRSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSA.Location = new System.Drawing.Point(622, 319);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(84, 83);
            this.btnRSA.TabIndex = 1;
            this.btnRSA.UseVisualStyleBackColor = false;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click_1);
            // 
            // btnSHA
            // 
            this.btnSHA.BackColor = System.Drawing.Color.Transparent;
            this.btnSHA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSHA.BackgroundImage")));
            this.btnSHA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSHA.FlatAppearance.BorderSize = 0;
            this.btnSHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHA.Location = new System.Drawing.Point(703, 314);
            this.btnSHA.Name = "btnSHA";
            this.btnSHA.Size = new System.Drawing.Size(85, 86);
            this.btnSHA.TabIndex = 1;
            this.btnSHA.UseVisualStyleBackColor = false;
            this.btnSHA.Click += new System.EventHandler(this.btnSHA_Click);
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
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSHA);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.btnMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnSHA;
        private System.Windows.Forms.Button btnExit;
    }
}


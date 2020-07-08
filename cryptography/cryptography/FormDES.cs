using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Diagnostics;


namespace cryptography
{
    public partial class FormDES : Form
    {
        public FormDES()
        {
            InitializeComponent();
        }

        bool isEncryptFile = true;
        private string inputFileName, outputFileName = "", mode;
        private string key;


        private void FormDES_Load(object sender, EventArgs e)
        {
            comboBoxMode.Items.Add("CBC");
            comboBoxMode.Items.Add("ECB");
            comboBoxMode.Items.Add("CFB");

            comboBoxMode.Text = "CBC";

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Update();

            this.progressBar2.Visible = false;
        }



        //Open file.
        private void btnOpenFileIn_Click(object sender, EventArgs e)
        {
            this.isEncryptFile = true;
            this.tbOutput.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                tbInput.Text = op.FileName;
        }

        private void btnOpenFolderIn_Click(object sender, EventArgs e)
        {
            this.isEncryptFile = false;
            this.tbOutput.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.tbInput.Text = folderBrowserDialog1.SelectedPath;
        }


        void DESAlgorithm(string sInputFilename, string sOutputFilename, string sKey, string mode, bool isEncrypt)
        {

            byte[] bytes = Convert.FromBase64String(sKey);

            FileStream fsInput = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            FileStream fsOutput = new FileStream(sOutputFilename, FileMode.OpenOrCreate, FileAccess.Write);
            fsOutput.SetLength(0);

            byte[] bin = new byte[100];
            long rdlen = 0;
            long totlen = fsInput.Length;
            int len;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = (int)fsInput.Length;

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

            if (mode == "ECB") DES.Mode = CipherMode.ECB;
            else if (mode == "CBC") DES.Mode = CipherMode.CBC;
            else if (mode == "CFB") DES.Mode = CipherMode.CFB;

            CryptoStream encStream;

            if (isEncrypt)
                encStream = new CryptoStream(fsOutput, DES.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            else
                encStream = new CryptoStream(fsOutput, DES.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write);

            while (rdlen < totlen)
            {
                len = fsInput.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                this.progressBar1.Value = (int)rdlen;
                rdlen = rdlen + len;
                this.progressBar1.PerformStep();
            }

            this.progressBar1.Value = this.progressBar1.Maximum;
            this.progressBar1.PerformStep();

            if (progressBar1.IsHandleCreated && isEncryptFile)
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = Path.GetDirectoryName(outputFileName);
                prc.Start();
            }

            encStream.Close();
            fsOutput.Close();
            fsInput.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormMain fe = new FormMain();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(tbInput.Text)) != 0 &&
                Strings.Len(Strings.Trim(tbKey.Text)) != 0 &&
                Strings.Len(Strings.Trim(comboBoxMode.Text)) != 0)
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                this.inputFileName = tbInput.Text;
                this.outputFileName = tbInput.Text + ".tpEn";
                if (isEncryptFile)
                    this.tbOutput.Text = outputFileName;

                this.mode = comboBoxMode.Text;
                this.key = tbKey.Text;

                if (isEncryptFile)
                    DESAlgorithm(this.inputFileName, this.outputFileName, this.key, this.mode, true);
                else
                {
                    //get all files from path.
                    string[] filePaths = Directory.GetFiles(inputFileName);

                    if (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db"))
                    {
                        MessageBox.Show("Empty folder");
                        return;
                    }

                    if (filePaths.Length == 0)
                    {
                        MessageBox.Show("Empty folder");
                        return;
                    }

                    this.progressBar2.Visible = true;
                    this.progressBar2.Minimum = 0;
                    this.progressBar2.Maximum = filePaths.Length;

                    if (filePaths.Length > 0)
                    {
                        this.outputFileName = filePaths[0];
                        this.tbOutput.Text = outputFileName;
                    }


                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        progressBar2.Value = i;

                        if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                            DESAlgorithm(filePaths[i], filePaths[i] + ".tpEn", this.key, this.mode, true);

                        this.progressBar2.PerformStep();
                    }


                    if (progressBar2.IsHandleCreated)
                    {
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = Path.GetDirectoryName(filePaths[0]);
                        prc.Start();
                    }

                }
                sw.Stop();
                double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                MessageBox.Show("Execution time " + elapsedMs.ToString() + "s");
            }
            else
            {
                MessageBox.Show("Data is not enough to encrypt");
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            desCrypto.GenerateKey();
            tbKey.Text = Convert.ToBase64String(desCrypto.Key);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(tbInput.Text)) != 0 &&
                Strings.Len(Strings.Trim(tbKey.Text)) != 0 &&
                Strings.Len(Strings.Trim(comboBoxMode.Text)) != 0
                )
            {
                this.inputFileName = tbInput.Text;



                this.outputFileName = tbInput.Text;
                if (isEncryptFile)
                {
                    if (Path.GetExtension(this.inputFileName) != ".tpEn")
                    {
                        MessageBox.Show("This file is not supported for decrypt");
                        return;
                    }
                    this.outputFileName = this.outputFileName.Substring(0, this.outputFileName.Length - 5);
                    this.tbOutput.Text = outputFileName;
                }
                this.mode = comboBoxMode.Text;
                this.key = tbKey.Text;

                if (isEncryptFile)
                    DESAlgorithm(this.inputFileName, this.outputFileName, this.key, this.mode, false);
                else
                {
                    string[] filePaths = Directory.GetFiles(inputFileName, "*.tpEn");

                    if (filePaths.Length == 0)
                    {
                        MessageBox.Show("The directory does not contain a .tpEn file");
                        return;
                    }

                    this.progressBar2.Visible = true;
                    this.progressBar2.Minimum = 0;
                    this.progressBar2.Maximum = filePaths.Length;

                    this.outputFileName = filePaths[0];
                    this.tbOutput.Text = this.outputFileName;

                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        progressBar2.Value = i;
                        DESAlgorithm(filePaths[i], filePaths[i].Substring(0, filePaths[i].Length - 5), this.key, this.mode, false);
                        this.progressBar2.PerformStep();
                    }

                    if (progressBar2.IsHandleCreated)
                    {
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = Path.GetDirectoryName(filePaths[0]);
                        prc.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data is not enough to decrypt");
            }
        }

        private void btnOutOpen_Click(object sender, EventArgs e)
        {
            if (this.outputFileName.Length > 0)
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = Path.GetDirectoryName(outputFileName);
                prc.Start();
            }
        }

        private void btnDEStoAES_Click(object sender, EventArgs e)
        {
            FormAES fe = new FormAES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnDEStoRSA_Click(object sender, EventArgs e)
        {
            FormRSA fe = new FormRSA();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnDEStoSHA_Click(object sender, EventArgs e)
        {
            FormSHA1 fe = new FormSHA1();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            FormChat fe = new FormChat();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbKey.Clear();
            this.tbInput.Clear();
            this.tbOutput.Clear();
            this.comboBoxMode.Text = "CBC";
            this.outputFileName = "";
            this.inputFileName = "";
            if (this.progressBar1.Value > 0)
                this.progressBar1.Value = 0;
            this.progressBar2.Visible = false;
            MessageBox.Show("Reset successful");
        }

        

        

    }
}

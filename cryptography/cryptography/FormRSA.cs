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
    public partial class FormRSA : Form
    {
        public FormRSA()
        {
            InitializeComponent();
        }

        bool isEncryptFile = true;
        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        FolderBrowserDialog folderBrowserDialog2 = new FolderBrowserDialog();
        string inputFile, outputFile = "";

        private void FormRSA_Load(object sender, EventArgs e)
        {
            this.comboBoxLengKey.Items.Add("512bits");
            this.comboBoxLengKey.Items.Add("1024bits");
            this.comboBoxLengKey.Items.Add("2048bits");
            this.comboBoxLengKey.Items.Add("4096bits");

            this.comboBoxLengKey.Text = "1024bits";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormMain fe = new FormMain();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSAtemp = new RSACryptoServiceProvider();

            RSAParameters parameters = new RSAParameters();
            parameters = RSAtemp.ExportParameters(true);

            RSA.ImportParameters(parameters);

            tbN.Text = Encoding.ASCII.GetString(parameters.Modulus);
            tbE.Text = Encoding.ASCII.GetString(parameters.Exponent);
            tbD.Text = Encoding.ASCII.GetString(parameters.D);
        }

        private void btnOpenFileIn_Click(object sender, EventArgs e)
        {
            this.tbOutput.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                tbInput.Text = op.FileName;
        }

        private void btnOpenFolderIn_Click(object sender, EventArgs e)
        {
            this.tbOutput.Clear();
            this.isEncryptFile = false;
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                this.tbInput.Text = folderBrowserDialog2.SelectedPath;
        }

        private void btnOutOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = Path.GetDirectoryName(outputFile);
            prc.Start();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(tbInput.Text)) != 0)
            {

                inputFile = tbInput.Text;
                outputFile = inputFile + ".tpEn";

                if (isEncryptFile)
                    RSA_Algorithm(inputFile, outputFile, RSA.ExportParameters(true), true);
                else
                {
                    //get all files from path.
                    string[] filePaths = Directory.GetFiles(inputFile);

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
                    if (filePaths.Length > 0)
                    {
                        this.outputFile = filePaths[0];
                        this.tbOutput.Text = outputFile;
                    }


                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                            RSA_Algorithm(filePaths[i], filePaths[i] + ".tpEn", RSA.ExportParameters(true), true);
                    }


                    if (progressBar1.IsHandleCreated)
                    {
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = Path.GetDirectoryName(filePaths[0]);
                        prc.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Not enough data for encryption");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(tbInput.Text)) != 0)
            {
                this.inputFile = tbInput.Text;
                this.outputFile = tbInput.Text;
                if (isEncryptFile)
                {
                    if (Path.GetExtension(this.inputFile) != ".tpEn")
                    {
                        MessageBox.Show("This file is not supported for decrypt");
                        return;
                    }
                    this.outputFile = this.outputFile.Substring(0, this.outputFile.Length - 5);
                    this.tbOutput.Text = outputFile;
                }

                if (isEncryptFile)
                    RSA_Algorithm(this.inputFile, this.outputFile, RSA.ExportParameters(true), false);
                else
                {
                    string[] filePaths = Directory.GetFiles(inputFile, "*.tpEn");

                    if (filePaths.Length == 0)
                    {
                        MessageBox.Show("The directory does not contain a .tpEn file");
                        return;
                    }
                    this.outputFile = filePaths[0];
                    this.tbOutput.Text = this.outputFile;

                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        RSA_Algorithm(filePaths[i], filePaths[i].Substring(0, filePaths[i].Length - 5), RSA.ExportParameters(true), false);
                    }

                    if (progressBar1.IsHandleCreated)
                    {
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = Path.GetDirectoryName(filePaths[0]);
                        prc.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Not enough data for decryption");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbInput.Clear();
            this.tbN.Clear();
            this.tbE.Clear();
            this.tbD.Clear();
            this.tbOutput.Clear();
            if (this.progressBar1.Value > 0)
                this.progressBar1.Value = 0;

            MessageBox.Show("Reset successful");
        }

        private void btnRSAtoDES_Click(object sender, EventArgs e)
        {
            FormDES fe = new FormDES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnRSAtoAES_Click(object sender, EventArgs e)
        {
            FormAES fe = new FormAES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnRSAitself_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnRSAtoSHA_Click(object sender, EventArgs e)
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

        private void RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {

            FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
            fsCiperText.SetLength(0);

            byte[] bin, encryptedData;
            long rdlen = 0;
            long totlen = fsInput.Length;
            int len;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = (int)totlen;

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeyInfo);

            int maxBytesCanEncrypted;
            if (isEncrypt)
                maxBytesCanEncrypted = ((RSA.KeySize - 384) / 8) + 37;
            else
                maxBytesCanEncrypted = RSA.KeySize / 8;

            while (rdlen < totlen)
            {
                bin = new byte[maxBytesCanEncrypted];
                len = fsInput.Read(bin, 0, maxBytesCanEncrypted);

                this.progressBar1.Value = (int)rdlen;
                this.progressBar1.PerformStep();

                if (isEncrypt) encryptedData = RSA.Encrypt(bin, false);
                else encryptedData = RSA.Decrypt(bin, false);

                fsCiperText.Write(encryptedData, 0, encryptedData.Length);
                rdlen = rdlen + len;

            }

            this.progressBar1.Value = this.progressBar1.Maximum;
            this.progressBar1.PerformStep();

            if (progressBar1.IsHandleCreated)
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = Path.GetDirectoryName(outputFile);
                prc.Start();
            }



            fsCiperText.Close();
            fsInput.Close();

        }


    }
}

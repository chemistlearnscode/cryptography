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


namespace cryptography
{
    public partial class FormAES : Form
    {
        public FormAES()
        {
            InitializeComponent();
        }

        

        private void AESAlgorithm(String inputFile, String OutputFile, String keys, bool isEncrypt, String mode)
        {
            FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            FileStream fsCiperText = new FileStream(OutputFile, FileMode.Create, FileAccess.Write);
            fsCiperText.SetLength(0);

            byte[] bin = new byte[100];
            long rdlen = 0;
            long totlen = fsInput.Length;
            int len;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = (int)fsInput.Length;

            AesCryptoServiceProvider AESProvider = new AesCryptoServiceProvider();
            AESProvider.Key = Convert.FromBase64String(keys);
            AESProvider.IV = ASCIIEncoding.ASCII.GetBytes(keys.Substring(0, 16));

            if (mode == "ECB") AESProvider.Mode = CipherMode.ECB;
            else if (mode == "CBC") AESProvider.Mode = CipherMode.CBC;
            else if (mode == "CFB") AESProvider.Mode = CipherMode.CFB;

            CryptoStream cryptStream;
            if (isEncrypt)
                cryptStream = new CryptoStream(fsCiperText, AESProvider.CreateEncryptor(), CryptoStreamMode.Write);
            else
                cryptStream = new CryptoStream(fsCiperText, AESProvider.CreateDecryptor(), CryptoStreamMode.Write);

            while (rdlen < totlen)
            {
                len = fsInput.Read(bin, 0, 100);
                cryptStream.Write(bin, 0, len);
                this.progressBar1.Value = (int)rdlen;
                rdlen = rdlen + len;
                this.progressBar1.PerformStep();
            }

            this.progressBar1.Value = this.progressBar1.Maximum;
            this.progressBar1.PerformStep();

            if (progressBar1.IsHandleCreated)
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = Path.GetDirectoryName(tbOutput.Text);
                prc.Start();
            }

            cryptStream.Close();
            fsInput.Close();
            fsCiperText.Close();
        }

        

        

        

        

        

        

        

        


        

        

        

        

        private void FormAES_Load(object sender, EventArgs e)
        {
            this.comboBoxMode.Items.Add("CBC");
            this.comboBoxMode.Items.Add("ECB");
            this.comboBoxMode.Items.Add("CFB");

            this.comboBoxMode.Text = "CBC";

            this.cbSelectKeyLength.Items.Add("128bits");
            this.cbSelectKeyLength.Items.Add("192bits");
            this.cbSelectKeyLength.Items.Add("256bits");

            this.cbSelectKeyLength.Text = "256bits";
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            if (Strings.Len(Strings.Trim(cbSelectKeyLength.Text)) != 0)
            {
                if (cbSelectKeyLength.Text == "128bits")
                    aes.KeySize = 128;
                else if (cbSelectKeyLength.Text == "192bits")
                    aes.KeySize = 192;
                else aes.KeySize = 256;

                aes.GenerateKey();
                tbKey.Text = Convert.ToBase64String(aes.Key);
            }
        }

        private void btnOpenFileIn_Click(object sender, EventArgs e)
        {
            this.tbOutput.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                tbInput.Text = op.FileName;
            }
        }

        private void btnOpenFolderIn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.tbInput.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnOutOpen_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(tbOutput.Text)) > 0)
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = Path.GetDirectoryName(tbOutput.Text);
                prc.Start();
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(tbInput.Text)) != 0 &&
                Strings.Len(Strings.Trim(tbKey.Text)) != 0 &&
                Strings.Len(Strings.Trim(comboBoxMode.Text)) != 0
                )
            {
                string inputFileName, outputFileName, mode, key;
                inputFileName = tbInput.Text;
                outputFileName = tbInput.Text + ".tpEn";
                this.tbOutput.Text = outputFileName;
                mode = comboBoxMode.Text;
                key = tbKey.Text;
                AESAlgorithm(inputFileName, outputFileName, key, true, mode);
            }
            else
            {
                MessageBox.Show("Can not encrypt!");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(tbInput.Text)) != 0 &&
               Strings.Len(Strings.Trim(tbKey.Text)) != 0 &&
               Strings.Len(Strings.Trim(comboBoxMode.Text)) != 0
               )
            {
                string inputFileName, outputFileName, mode, key;
                inputFileName = tbInput.Text;
                outputFileName = tbInput.Text.Substring(0, tbInput.Text.Length - 5);
                this.tbOutput.Text = outputFileName;
                mode = comboBoxMode.Text;
                key = tbKey.Text;
                AESAlgorithm(inputFileName, outputFileName, key, false, mode);
            }
            else
            {
                MessageBox.Show("Can not decrypt");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbKey.Clear();
            this.tbInput.Clear();
            this.tbOutput.Clear();
            this.comboBoxMode.Text = "CBC";
            this.cbSelectKeyLength.Text = "256bits";
            if (this.progressBar1.Value > 0)
                this.progressBar1.Value = 0;
            MessageBox.Show("Reset successful");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormMain fe = new FormMain();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnAESitself_Click(object sender, EventArgs e)
        {

        }

        private void btnAEStoDES_Click(object sender, EventArgs e)
        {
            FormDES fe = new FormDES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnAEStoRSA_Click(object sender, EventArgs e)
        {
            FormRSA fe = new FormRSA();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnAEStoSHA_Click(object sender, EventArgs e)
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
    }
}

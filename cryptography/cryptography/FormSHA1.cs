using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace cryptography
{
    public partial class FormSHA1 : Form
    {
        public FormSHA1()
        {
            InitializeComponent();
            
        }

        private void FormSHA1_Load(object sender, EventArgs e)
        {
            this.comboBox2.Items.Add("File");
            this.comboBox2.Items.Add("Text");

            this.comboBox2.Text = "File";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormMain fe = new FormMain();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btn_en_brow_sha1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txt_en_brow_sha1.Text = openFileDialog1.FileName;
            }
        }

        private String openfile()
        {
            FileStream fs = new FileStream(txt_en_brow_sha1.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            string str = "";
            int blocksize = 4 * 1024;
            int iteration_number;
            if (fs.Length < blocksize)
                iteration_number = 1;
            else if (fs.Length % blocksize == 0)
                iteration_number = (int)fs.Length / blocksize;
            else
                iteration_number = ((int)fs.Length / blocksize) + 1;
            while (iteration_number-- > 0)
            {
                if (iteration_number == 0)
                    blocksize = (int)fs.Length % blocksize;
                byte[] input = br.ReadBytes(8);
                for (int i = 0; i < input.Length; i++)
                {
                    str = str + input[i];
                }
            }
            br.Close();
            return str;
        }
        private string GetSHA1HashData(string data)
        {
            System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
            byte[] hashData = sha1.ComputeHash(ASCIIEncoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }
            return returnValue.ToString();
        }

        private void btn_en_sha1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox2.Text == "File")
                {
                    txt_en_sha1.Text = GetSHA1HashData(openfile());
                }
                else
                {
                    txt_en_sha1.Text = GetSHA1HashData(txt_en_brow_sha1.Text);
                }
                MessageBox.Show("Encryption succeeded");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed " + ex.Message);
            }
        }

        private void btnSHAtoDES_Click(object sender, EventArgs e)
        {
            FormDES fe = new FormDES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnSHAtoAES_Click(object sender, EventArgs e)
        {
            FormAES fe = new FormAES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnSHAtoRSA_Click(object sender, EventArgs e)
        {
            FormRSA fe = new FormRSA();
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptography
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnExit.BackColor = Color.Transparent;
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            FormRSA fe = new FormRSA();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            FormDES fe = new FormDES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            FormAES fe = new FormAES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRSA_Click_1(object sender, EventArgs e)
        {
            FormRSA fe = new FormRSA();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void btnSHA_Click(object sender, EventArgs e)
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
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Net_Hashing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraHashSHA512_Click(object sender, EventArgs e)
        {
            txtHash.Text = "";
            var hash = new TrataHash(SHA512.Create());
            txtHash.Text = hash.GerarHash(txtTexto.Text);

        }

        private void btnGeraHashMD5_Click(object sender, EventArgs e)
        {
            txtHash.Text = "";
            var hash = new TrataHash(MD5.Create());
            txtHash.Text = hash.GerarHash(txtTexto.Text);
        }

        private void btnGeraHashRIPEMD160_Click(object sender, EventArgs e)
        {
            txtHash.Text = "";
            var hash = new TrataHash(RIPEMD160.Create());
            txtHash.Text = hash.GerarHash(txtTexto.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtHash.Text = "";
            txtTexto.Text = "";
        }

        private void txtHash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

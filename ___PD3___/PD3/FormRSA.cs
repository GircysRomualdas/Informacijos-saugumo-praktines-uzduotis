using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD3
{
    public partial class FormRSA : Form
    {
        public FormRSA()
        {
            InitializeComponent();
        }
        RSA rsa;
        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            rsa = new RSA(int.Parse(textBoxP.Text), int.Parse(textBoxQ.Text));
            textBoxPublicKey.Text = rsa.getE().ToString();
            textBoxPrivateKey.Text = rsa.getD().ToString();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            richTextBoxValue.Text = rsa.encryptR(richTextBoxText.Text);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = rsa.decryptR(richTextBoxValue.Text);
        }
    }
}

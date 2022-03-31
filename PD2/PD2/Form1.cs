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

namespace PD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(save.FileName));
                writer.Write(richTextBoxValue.Text);
                writer.Dispose();
            }
        }

        private void buttonLoud_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(File.OpenRead(open.FileName));
                richTextBoxText.Text = reader.ReadToEnd();
                reader.Dispose();
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (checkLength())
            {
                AES aes = new AES();
                if(comboBoxBlock.SelectedIndex == 1)
                    richTextBoxValue.Text = aes.encrypt(richTextBoxText.Text, textBoxKey.Text, Convert.ToInt32(comboBoxSize.Text), textBoxInitialization.Text);
                else
                    richTextBoxValue.Text = aes.encrypt(richTextBoxText.Text, textBoxKey.Text, Convert.ToInt32(comboBoxSize.Text));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSize.SelectedIndex = 0;
            comboBoxBlock.SelectedIndex = 0;
            textBoxInitialization.Enabled = false;
        }

        private void comboBoxBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxBlock.Text == "CBC")
            {
                textBoxInitialization.Enabled = true;
            }
            else
            {
                textBoxInitialization.Enabled = false;
            }
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSize.SelectedIndex)
            {
                case 0:
                    labelKey.Text = "Key (16 char)";
                    break;
                case 1:
                    labelKey.Text = "Key (24 char)";
                    break;
                case 2:
                    labelKey.Text = "Key (32 char)";
                    break;
                default:
                    // code block
                    break;
            }
        }

        private bool checkLength()
        {
            switch (comboBoxSize.SelectedIndex)
            {
                case 0:
                    if (textBoxKey.Text.Length != 16)
                    {
                        MessageBox.Show("Error Key (16 char)");
                        return false;
                    }
                    break;
                case 1:
                    if (textBoxKey.Text.Length != 24)
                    {
                        MessageBox.Show("Error Key (24 char)");
                        return false;
                    }
                    break;
                case 2:
                    if (textBoxKey.Text.Length != 32)
                    {
                        MessageBox.Show("Error Key (32 char)");
                        return false;
                    }
                    break;
                default:
                    // code block
                    break;
            }

            switch (comboBoxBlock.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    if (textBoxInitialization.Text.Length != 16)
                    {
                        MessageBox.Show("Error Initialization Vector (16 char)");
                        return false;
                    }
                    break;
                default:
                    // code block
                    break;
            }

            return true;

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (checkLength())
            {
                AES aes = new AES();
                if (comboBoxBlock.SelectedIndex == 1)
                    richTextBoxValue.Text = aes.decrypt(richTextBoxText.Text, textBoxKey.Text, Convert.ToInt32(comboBoxSize.Text), textBoxInitialization.Text);
                else
                    richTextBoxValue.Text = aes.decrypt(richTextBoxText.Text, textBoxKey.Text, Convert.ToInt32(comboBoxSize.Text));
            }
        }
    }
}


namespace PD2
{
    partial class Form1
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
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.richTextBoxValue = new System.Windows.Forms.RichTextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.comboBoxBlock = new System.Windows.Forms.ComboBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonLoud = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInitialization = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(21, 38);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(340, 137);
            this.richTextBoxText.TabIndex = 0;
            this.richTextBoxText.Text = "";
            // 
            // richTextBoxValue
            // 
            this.richTextBoxValue.Location = new System.Drawing.Point(390, 38);
            this.richTextBoxValue.Name = "richTextBoxValue";
            this.richTextBoxValue.Size = new System.Drawing.Size(340, 136);
            this.richTextBoxValue.TabIndex = 1;
            this.richTextBoxValue.Text = "";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(99, 197);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(190, 20);
            this.textBoxKey.TabIndex = 2;
            // 
            // comboBoxBlock
            // 
            this.comboBoxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlock.FormattingEnabled = true;
            this.comboBoxBlock.Items.AddRange(new object[] {
            "ECB",
            "CBC"});
            this.comboBoxBlock.Location = new System.Drawing.Point(295, 196);
            this.comboBoxBlock.Name = "comboBoxBlock";
            this.comboBoxBlock.Size = new System.Drawing.Size(66, 21);
            this.comboBoxBlock.TabIndex = 3;
            this.comboBoxBlock.SelectedIndexChanged += new System.EventHandler(this.comboBoxBlock_SelectedIndexChanged);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(99, 182);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(25, 13);
            this.labelKey.TabIndex = 4;
            this.labelKey.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mode";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(21, 241);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(97, 44);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(124, 241);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(97, 44);
            this.buttonDecrypt.TabIndex = 9;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonLoud
            // 
            this.buttonLoud.Location = new System.Drawing.Point(530, 241);
            this.buttonLoud.Name = "buttonLoud";
            this.buttonLoud.Size = new System.Drawing.Size(97, 44);
            this.buttonLoud.TabIndex = 10;
            this.buttonLoud.Text = "Loud";
            this.buttonLoud.UseVisualStyleBackColor = true;
            this.buttonLoud.Click += new System.EventHandler(this.buttonLoud_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(633, 241);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 44);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.comboBoxSize.Location = new System.Drawing.Point(21, 196);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(73, 21);
            this.comboBoxSize.TabIndex = 12;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Key Size";
            // 
            // textBoxInitialization
            // 
            this.textBoxInitialization.Location = new System.Drawing.Point(295, 241);
            this.textBoxInitialization.Name = "textBoxInitialization";
            this.textBoxInitialization.Size = new System.Drawing.Size(145, 20);
            this.textBoxInitialization.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Initialization Vector (16 char)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 298);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInitialization);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoud);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.comboBoxBlock);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.richTextBoxValue);
            this.Controls.Add(this.richTextBoxText);
            this.Name = "Form1";
            this.Text = "AES - Chipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.RichTextBox richTextBoxValue;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.ComboBox comboBoxBlock;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonLoud;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInitialization;
        private System.Windows.Forms.Label label6;
    }
}



namespace PD3
{
    partial class FormDatabase
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewText = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enryptedTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicKeyNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicKeyEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseTextDataSet = new PD3.DatabaseTextDataSet();
            this.tableTableAdapter = new PD3.DatabaseTextDataSetTableAdapters.TableTableAdapter();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectedID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewText
            // 
            this.dataGridViewText.AutoGenerateColumns = false;
            this.dataGridViewText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.enryptedTextDataGridViewTextBoxColumn,
            this.publicKeyNDataGridViewTextBoxColumn,
            this.publicKeyEDataGridViewTextBoxColumn});
            this.dataGridViewText.DataSource = this.tableBindingSource;
            this.dataGridViewText.Location = new System.Drawing.Point(27, 31);
            this.dataGridViewText.Name = "dataGridViewText";
            this.dataGridViewText.Size = new System.Drawing.Size(476, 160);
            this.dataGridViewText.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enryptedTextDataGridViewTextBoxColumn
            // 
            this.enryptedTextDataGridViewTextBoxColumn.DataPropertyName = "EnryptedText";
            this.enryptedTextDataGridViewTextBoxColumn.HeaderText = "EnryptedText";
            this.enryptedTextDataGridViewTextBoxColumn.Name = "enryptedTextDataGridViewTextBoxColumn";
            // 
            // publicKeyNDataGridViewTextBoxColumn
            // 
            this.publicKeyNDataGridViewTextBoxColumn.DataPropertyName = "PublicKeyN";
            this.publicKeyNDataGridViewTextBoxColumn.HeaderText = "PublicKeyN";
            this.publicKeyNDataGridViewTextBoxColumn.Name = "publicKeyNDataGridViewTextBoxColumn";
            // 
            // publicKeyEDataGridViewTextBoxColumn
            // 
            this.publicKeyEDataGridViewTextBoxColumn.DataPropertyName = "PublicKeyE";
            this.publicKeyEDataGridViewTextBoxColumn.HeaderText = "PublicKeyE";
            this.publicKeyEDataGridViewTextBoxColumn.Name = "publicKeyEDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseTextDataSet;
            // 
            // databaseTextDataSet
            // 
            this.databaseTextDataSet.DataSetName = "DatabaseTextDataSet";
            this.databaseTextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(27, 224);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(88, 26);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected ID:";
            // 
            // labelSelectedID
            // 
            this.labelSelectedID.AutoSize = true;
            this.labelSelectedID.Location = new System.Drawing.Point(236, 231);
            this.labelSelectedID.Name = "labelSelectedID";
            this.labelSelectedID.Size = new System.Drawing.Size(16, 13);
            this.labelSelectedID.TabIndex = 3;
            this.labelSelectedID.Text = "...";
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 272);
            this.Controls.Add(this.labelSelectedID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewText);
            this.Name = "FormDatabase";
            this.Text = "Databases";
            this.Load += new System.EventHandler(this.FormDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTextDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewText;
        private DatabaseTextDataSet databaseTextDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseTextDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enryptedTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicKeyNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicKeyEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSelectedID;
    }
}
using Workaholic.RTFEditor;

namespace Course_Outline
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label attributeLabel;
            System.Windows.Forms.Label contentLabel;
            System.Windows.Forms.Label partOfLabel;
            System.Windows.Forms.Label include_Label;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.modelDataSet = new Course_Outline.ModelDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Course_Outline.ModelDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Course_Outline.ModelDataSetTableAdapters.TableAdapterManager();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rtf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeTextBox = new System.Windows.Forms.TextBox();
            this.partOfComboBox = new System.Windows.Forms.ComboBox();
            this.include_CheckBox = new System.Windows.Forms.CheckBox();
            this.rtfEditor1 = new Workaholic.RTFEditor.RTFEditor();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            attributeLabel = new System.Windows.Forms.Label();
            contentLabel = new System.Windows.Forms.Label();
            partOfLabel = new System.Windows.Forms.Label();
            include_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // attributeLabel
            // 
            attributeLabel.AutoSize = true;
            attributeLabel.Location = new System.Drawing.Point(6, 9);
            attributeLabel.Name = "attributeLabel";
            attributeLabel.Size = new System.Drawing.Size(49, 13);
            attributeLabel.TabIndex = 9;
            attributeLabel.Text = "Attribute:";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new System.Drawing.Point(123, 9);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(47, 13);
            contentLabel.TabIndex = 11;
            contentLabel.Text = "Content:";
            // 
            // partOfLabel
            // 
            partOfLabel.AutoSize = true;
            partOfLabel.Location = new System.Drawing.Point(9, 57);
            partOfLabel.Name = "partOfLabel";
            partOfLabel.Size = new System.Drawing.Size(43, 13);
            partOfLabel.TabIndex = 13;
            partOfLabel.Text = "Part Of:";
            // 
            // include_Label
            // 
            include_Label.AutoSize = true;
            include_Label.Location = new System.Drawing.Point(32, 101);
            include_Label.Name = "include_Label";
            include_Label.Size = new System.Drawing.Size(48, 13);
            include_Label.TabIndex = 15;
            include_Label.Text = "Included";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Generate PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.modelDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Course_Outline.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.rtf});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(126, 281);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(702, 180);
            this.tableDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Attribute";
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Attribute";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn2.FillWeight = 125F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Content";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PartOf";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Part of";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Include?";
            this.dataGridViewCheckBoxColumn1.FillWeight = 30F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Include?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // rtf
            // 
            this.rtf.HeaderText = "rtf";
            this.rtf.Name = "rtf";
            this.rtf.Visible = false;
            // 
            // attributeTextBox
            // 
            this.attributeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Attribute", true));
            this.attributeTextBox.Location = new System.Drawing.Point(9, 25);
            this.attributeTextBox.Name = "attributeTextBox";
            this.attributeTextBox.Size = new System.Drawing.Size(108, 20);
            this.attributeTextBox.TabIndex = 10;
            // 
            // partOfComboBox
            // 
            this.partOfComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "PartOf", true));
            this.partOfComboBox.FormattingEnabled = true;
            this.partOfComboBox.Location = new System.Drawing.Point(12, 73);
            this.partOfComboBox.Name = "partOfComboBox";
            this.partOfComboBox.Size = new System.Drawing.Size(90, 21);
            this.partOfComboBox.TabIndex = 14;
            this.partOfComboBox.SelectedIndexChanged += new System.EventHandler(this.partOfComboBox_SelectedIndexChanged);
            // 
            // include_CheckBox
            // 
            this.include_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Include?", true));
            this.include_CheckBox.Location = new System.Drawing.Point(9, 96);
            this.include_CheckBox.Name = "include_CheckBox";
            this.include_CheckBox.Size = new System.Drawing.Size(17, 24);
            this.include_CheckBox.TabIndex = 16;
            this.include_CheckBox.UseVisualStyleBackColor = true;
            // 
            // rtfEditor1
            // 
            this.rtfEditor1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.rtfEditor1.DefaultFontColor = System.Drawing.Color.Black;
            this.rtfEditor1.DefaultFontFamily = "Arial";
            this.rtfEditor1.DefaultFontSize = 8;
            this.rtfEditor1.DefaultWordWrap = false;
            this.rtfEditor1.DocumentRtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil Arial;}}\r\n" +
    "{\\*\\generator Riched20 10.0.17763}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.rtfEditor1.DocumentText = "";
            this.rtfEditor1.EnableNewDocument = true;
            this.rtfEditor1.EnableOpenDocument = true;
            this.rtfEditor1.EnableSaveDocument = true;
            this.rtfEditor1.FilePanelVisible = true;
            this.rtfEditor1.Location = new System.Drawing.Point(126, 25);
            this.rtfEditor1.MenuVisible = true;
            this.rtfEditor1.Name = "rtfEditor1";
            this.rtfEditor1.ReadOnly = false;
            this.rtfEditor1.Size = new System.Drawing.Size(703, 235);
            this.rtfEditor1.TabIndex = 0;
            this.rtfEditor1.ToolStripVisible = true;
            this.rtfEditor1.OnDocumentSave += new Workaholic.RTFEditor.RTFEditorOnSave(this.rtfEditor1_OnSave);
            this.rtfEditor1.Load += new System.EventHandler(this.rtfEditor1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(851, 473);
            this.Controls.Add(attributeLabel);
            this.Controls.Add(this.attributeTextBox);
            this.Controls.Add(contentLabel);
            this.Controls.Add(partOfLabel);
            this.Controls.Add(this.partOfComboBox);
            this.Controls.Add(include_Label);
            this.Controls.Add(this.include_CheckBox);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtfEditor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RTFEditor rtfEditor1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ModelDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.TextBox attributeTextBox;
        private System.Windows.Forms.ComboBox partOfComboBox;
        private System.Windows.Forms.CheckBox include_CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtf;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


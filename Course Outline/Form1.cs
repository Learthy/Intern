using Course_Outline.Models;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Workaholic.RTFEditor;
using iTextSharp.text.html.simpleparser;
using System.Collections;

namespace Course_Outline
{

    public partial class Form1 : Form
    {
        public static List<Template> Templates;
        public static List<string> TemplatesComboList;
        public static List<Object> RTFs;
        public void InitializeTemplates()
        {
            Templates = new List<Template>();
            TemplatesComboList = new List<string>();
            Template template1 = new Template("Template 1");
            Template template2 = new Template("Template 2");
            Template template3 = new Template("Template 3");

            template1.fields.Add("First Name");// Add Attribute for Template 1
            template1.fields.Add("Last Name");// Add Attribute for Template 1
            template1.fields.Add("Email Address");// Add Attribute for Template 1

            template2.fields.Add("Instructor Name");// Add Attribute for Template 2
            template2.fields.Add("Office Hours");// Add Attribute for Template 2
            template2.fields.Add("Textbook");// Add Attribute for Template 2

            template3.fields.Add("Classroom");// Add Attribute for Template 3
            template3.fields.Add("Location");// Add Attribute for Template 3
            template3.fields.Add("Days");// Add Attribute for Template 3

            Templates.Add(template1);
            Templates.Add(template2);
            Templates.Add(template3);

            foreach(Template template in Templates)
            {
                TemplatesComboList.Add(template.Name);
            }
            partOfComboBox.DataSource = TemplatesComboList;
        }
        public Form1()
        {
            InitializeComponent();
            InitializeTemplates();
            RTFs = new List<Object>();
        }

        private void rtfEditor1_OnSave(object sender, RTFEditorEventArgs e)
        {
            e.Cancel = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RichTextBox s = rtfEditor1.getText();
            if (attributeTextBox.Text.ToString() != "")
            {
                bool found = false;
                for(int i = 0; i < tableDataGridView.Rows.Count-1; i++)
                {
                        DataGridViewRow row2 = (DataGridViewRow)tableDataGridView.Rows[i];
                        if (attributeTextBox.Text.ToString() == row2.Cells[0].Value.ToString())
                        {
                            row2.Cells[1].Value = s.Text;
                            //row2.Cells[3].Value = false;
                            RTFs.Add(s);
                            row2.Cells["rtf"].Value = s.Rtf;
                            //string ss = row2.Cells["rtf"].Value.ToString();
                            found = true;
                            break;
                        }
                }
                if (!found)
                {
                    DataGridViewRow row = (DataGridViewRow)tableDataGridView.Rows[0].Clone();
                    row.Cells[0].Value = attributeTextBox.Text;
                    row.Cells[1].Value = s.Text;
                    //row.Cells[3].Value = false;
                    row.Cells[3].ReadOnly = false;
                    tableDataGridView.Rows.Add(row);
                    //tableDataGridView.Rows[tableDataGridView.Rows.Count - 1].Cells[3].ReadOnly = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Attribute Name");
            }
        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads d ata into the 'modelDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.modelDataSet.Table);

        }

        private void partOfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index =partOfComboBox.SelectedIndex;
            if (index != -1)
            {
                try
                {
                    tableDataGridView.DataSource = null;
                    tableDataGridView.RowCount = Templates[index].fields.Count+1;
                    for (int i = 0; i < Templates[index].fields.Count; i++)
                    {
                            tableDataGridView.Rows[i].Cells[0].Value = Templates[index].fields[i].ToString();
                            tableDataGridView.Rows[i].Cells[3].Value = true;
                            tableDataGridView.Rows[i].Cells[3].ReadOnly = true;
                            tableDataGridView.Rows[i].Cells[0].ReadOnly = true;
                    }
                }catch(Exception ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RichTextBox richTextBoxTarget = null;
            //PreviewFunction
            try
            {                
                string result1 = "";
                int i = 0;
                foreach(var rtb in RTFs)
                {
                    if (i == 0)
                    {
                        richTextBoxTarget = (RichTextBox)rtb;
                        result1 = ((RichTextBox)rtb).Rtf;
                    }
                    else
                    {
                        RichTextBox s = (RichTextBox)rtb;
                        result1 += s.Rtf;

                    }
                    i++;
                }
                richTextBoxTarget.Select(richTextBoxTarget.TextLength, 0);
                richTextBoxTarget.SelectedRtf =result1;
            }
            catch (Exception) { }
            DateTime now = DateTime.Now;
            string result = richTextBoxTarget.Rtf.ToString();
            string FilePath = @"C:\Users\adamh\Desktop\Fromatted" + now.Hour + now.Minute + now.Second + now.Millisecond+".doc";
            CreateTextV2(result, FilePath);
            System.Diagnostics.Process.Start(FilePath);

        }
        public static bool CreateTextV2(string text, string filepath)
        {
            try
            {

                string exePath = Application.StartupPath.ToString();
                if (!File.Exists(filepath))
                {
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        sw.WriteLine(text);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine(text);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: ", ex.Message);
                return false;
            }
        }
        private void rtfEditor1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string result1 = "";
                foreach (var rtb in RTFs)
                {
                    RichTextBox s = (RichTextBox)rtb;
                    result1 += s.Rtf;
                }
                string RTFFilePAth = @"C:\Users\adamh\Desktop\RTF\RTFFiles\RTF" + DateTime.Now.Date + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + ".rtf";
                CreateTextV2(result1, RTFFilePAth);

                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == "")
                {
                    MessageBox.Show("Please Select A Directory to save the PDF file");
                }
                else
                {
                   /* Acrobat.AcroAVDocClass _acroDoc = new Acrobat.AcroAVDocClass();

                    Acrobat.AcroPDDoc _pdDoc = null;
                    _acroDoc.Open(RTFFilePAth, saveFileDialog1.FileName+".pdf");

                    _pdDoc = (Acrobat.AcroPDDoc)(_acroDoc.GetPDDoc());

                    _pdDoc.Save(Acrobat.PDSaveFlags.PDSaveFull, strPDFFile);

                    _pdDoc.Close();

                    _pdDoc = null;

                    _acroDoc.Close(1);

                    _acroDoc = null; **/
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception While Generating PDF: "+ex.Message);
            }
        }
    }
}

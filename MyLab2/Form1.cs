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
using System.Xml;
using System.Xml.Xsl;

namespace MyLab2
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\Nikolay\source\repos\MyLab2\MyLab2\ScientificWorksSheet.xml";

        private List<Scientific_works> final;

        public Form1()
        {
            InitializeComponent();

            BuildRichTextBox();

            Clear();
        }

        internal DOM DOM
        {
            get => default;
            set
            {
            }
        }

        internal SAX SAX
        {
            get => default;
            set
            {
            }
        }

        internal LinqToXML LinqToXML
        {
            get => default;
            set
            {
            }
        }

        internal Scientific_works Scientific_works
        {
            get => default;
            set
            {
            }
        }

        public void BuildRichTextBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement Xpath = doc.DocumentElement;
            XmlNodeList childNodes = Xpath.SelectNodes("ScientificWork");

            for (int i = 0; i < childNodes.Count; i++)
            {
                XmlNode n = childNodes.Item(i);
                addItems(n);
            }

            comboBoxFullName.Text = comboBoxFullName.Items[0].ToString();
            comboBoxFaculty.Text = comboBoxFaculty.Items[0].ToString();
            comboBoxDepartment.Text = comboBoxDepartment.Items[0].ToString();
            comboBoxPosition.Text = comboBoxPosition.Items[0].ToString();   
            comboBoxScientific_Work.Text = comboBoxScientific_Work.Items[0].ToString();
            comboBoxCustomer.Text = comboBoxCustomer.Items[0].ToString();
            comboBoxAddress.Text = comboBoxAddress.Items[0].ToString();
            comboBoxSubordination.Text = comboBoxSubordination.Items[0].ToString();
            comboBoxArea.Text = comboBoxArea.Items[0].ToString();

        }

        public void addItems(XmlNode n)
        {
            if (!comboBoxFullName.Items.Contains(n.SelectSingleNode("@FullName").Value))
            {
                comboBoxFullName.Items.Add(n.SelectSingleNode("@FullName").Value);
            }

            if (!comboBoxFaculty.Items.Contains(n.SelectSingleNode("@Faculty").Value))
            {
                comboBoxFaculty.Items.Add(n.SelectSingleNode("@Faculty").Value);
            }

            if (!comboBoxDepartment.Items.Contains(n.SelectSingleNode("@Department").Value))
            {
                comboBoxDepartment.Items.Add(n.SelectSingleNode("@Department").Value);
            }

            if (!comboBoxPosition.Items.Contains(n.SelectSingleNode("@Position").Value))
            {
                comboBoxPosition.Items.Add(n.SelectSingleNode("@Position").Value);
            }

            if (!comboBoxScientific_Work.Items.Contains(n.SelectSingleNode("@Scientific_Work").Value))
            {
                comboBoxScientific_Work.Items.Add(n.SelectSingleNode("@Scientific_Work").Value);
            }

            if (!comboBoxCustomer.Items.Contains(n.SelectSingleNode("@Customer").Value))
            {
                comboBoxCustomer.Items.Add(n.SelectSingleNode("@Customer").Value);
            }

            if (!comboBoxAddress.Items.Contains(n.SelectSingleNode("@Address").Value))
            {
                comboBoxAddress.Items.Add(n.SelectSingleNode("@Address").Value);
            }

            if (!comboBoxSubordination.Items.Contains(n.SelectSingleNode("@Subordination").Value))
            {
                comboBoxSubordination.Items.Add(n.SelectSingleNode("@Subordination").Value);
            }

            if (!comboBoxArea.Items.Contains(n.SelectSingleNode("@Area").Value))
            {
                comboBoxArea.Items.Add(n.SelectSingleNode("@Area").Value);
            }
        }

        public void Clear()
        {
            richTextBox1.Clear();

            comboBoxFullName.Enabled = false;
            comboBoxFaculty.Enabled = false;
            comboBoxDepartment.Enabled = false;
            comboBoxPosition.Enabled = false;
            comboBoxScientific_Work.Enabled = false;
            comboBoxCustomer.Enabled = false;
            comboBoxAddress.Enabled = false;
            comboBoxSubordination.Enabled = false;
            comboBoxArea.Enabled = false;

            DOM_Button.Checked = false;
            SAX_Button.Checked = false;
            LinqToXML_Button.Checked = false;

            comboBoxFullName.Text = null;
            comboBoxFaculty.Text = null;
            comboBoxDepartment.Text = null;
            comboBoxPosition.Text = null;
            comboBoxScientific_Work.Text = null;
            comboBoxCustomer.Text = null;
            comboBoxAddress.Text = null;
            comboBoxSubordination.Text = null;
            comboBoxArea.Text = null;

            checkBox_FullName.Checked = false;
            checkBox_Faculty.Checked = false;
            checkBox_Department.Checked = false;
            checkBox_Position.Checked = false;
            checkBox_Scientific_Work.Checked = false;
            checkBox_Customer.Checked = false;
            checkBox_Address.Checked = false;
            checkBox_Subordination.Checked = false;
            checkBox_Area.Checked = false;
        }
        
        private void checkBox_FullName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_FullName.Checked)
            {
                comboBoxFullName.Enabled = true;
            }
            else
            {
                comboBoxFullName.Text = null;
                comboBoxFullName.Enabled = false;
            }
        }

        private void checkBox_Faculty_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Faculty.Checked)
            {
                comboBoxFaculty.Enabled = true;
            }
            else
            {
                comboBoxFaculty.Text = null;
                comboBoxFaculty.Enabled = false;
            }
        }

        private void checkBox_Department_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Department.Checked)
            {
                comboBoxDepartment.Enabled = true;
            }
            else
            {
                comboBoxDepartment.Text = null;
                comboBoxDepartment.Enabled = false;
            }
        }

        private void checkBox_Position_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Position.Checked)
            {
                comboBoxPosition.Enabled = true;
            }
            else
            {
                comboBoxPosition.Text = null;
                comboBoxPosition.Enabled = false;
            }
        }

        private void checkBox_Scientific_Work_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Scientific_Work.Checked)
            {
                comboBoxScientific_Work.Enabled = true;
            }
            else
            {
                comboBoxScientific_Work.Text = null;
                comboBoxScientific_Work.Enabled = false;
            }
        }

        private void checkBox_Customer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Customer.Checked)
            {
                comboBoxCustomer.Enabled = true;
            }
            else
            {
                comboBoxCustomer.Text = null;
                comboBoxCustomer.Enabled = false;
            }
        }

        private void checkBox_Address_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Address.Checked)
            {
                comboBoxAddress.Enabled = true;
            }
            else
            {
                comboBoxAddress.Text = null;
                comboBoxAddress.Enabled = false;
            }
        }

        private void checkBox_Subordination_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Subordination.Checked)
            {
                comboBoxSubordination.Enabled = true;
            }
            else
            {
                comboBoxSubordination.Text = null;
                comboBoxSubordination.Enabled = false;
            }
        }

        private void checkBox_Area_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Area.Checked)
            {
                comboBoxArea.Enabled = true;
            }
            else
            {
                comboBoxSubordination.Text = null;
                comboBoxArea.Enabled = false;
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Підтверджуєте вихід з програми?", "Значочок", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                //Application.Exit();
            }
            else { e.Cancel = true; }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                Scientific_works sci_works = new Scientific_works();
                if (checkBox_FullName.Checked) sci_works.FullName = comboBoxFullName.SelectedItem.ToString();
                if (checkBox_Faculty.Checked) sci_works.Faculty = comboBoxFaculty.SelectedItem.ToString();
                if (checkBox_Department.Checked) sci_works.Department = comboBoxDepartment.SelectedItem.ToString();
                if (checkBox_Position.Checked) sci_works.Position = comboBoxPosition.SelectedItem.ToString();
                if (checkBox_Scientific_Work.Checked)
                    sci_works.Scientific_Work = comboBoxScientific_Work.SelectedItem.ToString();
                if (checkBox_Customer.Checked) sci_works.Customer = comboBoxCustomer.SelectedItem.ToString();
                if (checkBox_Address.Checked) sci_works.Address = comboBoxAddress.SelectedItem.ToString();
                if (checkBox_Subordination.Checked)
                    sci_works.Subordination = comboBoxSubordination.SelectedItem.ToString();
                if (checkBox_Area.Checked) sci_works.Area = comboBoxArea.SelectedItem.ToString();


                IStrategy Current_analysing;
                if (DOM_Button.Checked)
                {
                    Current_analysing = new DOM(path);
                    final = Current_analysing.AnalyseFile(sci_works, path);
                    Output(final);
                }
                else if (SAX_Button.Checked)
                {
                    Current_analysing = new SAX();
                    final = Current_analysing.AnalyseFile(sci_works, path);
                    Output(final);
                }
                else if (LinqToXML_Button.Checked)
                {
                    Current_analysing = new LinqToXML(path);
                    final = Current_analysing.AnalyseFile(sci_works, path);
                    Output(final);
                }

                StartingXML();
                foreach (Scientific_works scientific111 in final)
                {
                    AddingSelectedItemsToXML(scientific111);
                }

                EndingXML();
            }
            catch
            {
                MessageBox.Show("Ви щось робите не так, перевірте:\n" +
                                "1) Ви НЕ поставили галочку біля значочка(ів)\n" +
                                "2) Ви НЕ вибрали у віконечці напротив значочка якийсь варіант\n" +
                                "3) Ви НЕ клацнули DOM or SAX or LinqToXML!\n");
            }

        }

        void StartingXML()
        {
            StreamWriter resultsFile = new StreamWriter(@"C:\Users\Nikolay\source\repos\MyLab2\MyLab2\Final.xml");
            resultsFile.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            resultsFile.WriteLine("<ScientificWorksSheet>");
            resultsFile.Close();
        }

        void AddingSelectedItemsToXML(Scientific_works scientific111)
        {
            StreamWriter resFile = new StreamWriter(@"C:\Users\Nikolay\source\repos\MyLab2\MyLab2\Final.xml", true);
            resFile.WriteLine("<ScientificWork");
            resFile.WriteLine("FullName = \"" + scientific111.FullName + "\"");
            resFile.WriteLine("Faculty = \"" + scientific111.Faculty + "\"");
            resFile.WriteLine("Department = \"" + scientific111.Department + "\"");
            resFile.WriteLine("Position = \"" + scientific111.Position + "\"");
            resFile.WriteLine("Scientific_Work = \"" + scientific111.Scientific_Work + "\"");
            resFile.WriteLine("Customer = \"" + scientific111.Customer + "\"");
            resFile.WriteLine("Address = \"" + scientific111.Address + "\"");
            resFile.WriteLine("Subordination = \"" + scientific111.Subordination + "\"");
            resFile.WriteLine("Area = \"" + scientific111.Area + "\">");
            resFile.WriteLine("</ScientificWork>");
            resFile.Close();
        }
       
        void EndingXML()
        {
            StreamWriter resultsFile = new StreamWriter(@"C:\Users\Nikolay\source\repos\MyLab2\MyLab2\Final.xml", true);
            resultsFile.WriteLine("</ScientificWorksSheet>");
            resultsFile.Close();
        }

        private void Output(List<Scientific_works> final_text)
        {
            foreach (Scientific_works sci_works in final_text)
            {
                richTextBox1.AppendText("П.І.П: " + sci_works.FullName + "\n");
                richTextBox1.AppendText("Факультет: " + sci_works.Faculty + "\n");
                richTextBox1.AppendText("Кафедра: " + sci_works.Department + "\n");
                richTextBox1.AppendText("Посада: " + sci_works.Position + "\n");
                richTextBox1.AppendText("Назва виконуваної чи дослідної роботи: " + sci_works.Scientific_Work + "\n");
                richTextBox1.AppendText("Замовник: " + sci_works.Customer + "\n");
                richTextBox1.AppendText("Адреса (замовника): " + sci_works.Address + "\n");
                richTextBox1.AppendText("Підпорядкування: " + sci_works.Subordination + "\n");
                richTextBox1.AppendText("Галузь: " + sci_works.Area + "\n");

                richTextBox1.AppendText("\n\n");
            }
        }

        private void toHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(@"C:\Users\Nikolay\source\repos\MyLab2\MyLab2\XSL.xsl");
            string input = @"C:\Users\Nikolay\source\repos\MyLab2\MyLab2\Final.xml";
            string result = @"C:\Users\Nikolay\source\repos\MyLab2\MyLab2\HTML.html";
            xsl.Transform(input, result);
            MessageBox.Show("Виконано!");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перший варіант: Наукові роботи кафедри\n" +
                            "Таблиці містять таку інформацію:\n" +
                            "П.І.П., факультет, кафедра, посада, назва виконуваної наукової чи дослідної роботи, замовник, його адреса, підпорядкування, галузь.\n\n" +
                            "Що вміє робити програма: \n" +
                            "1) Шукати по ключовим словам в таблиці;\n" +
                            "2) Виводити вміст XML файлу за допомогою: DOM, SAX, LinqToXML;\n" +
                            "3) Конвертувати XML таблицю в HTML - для зручного перегляду;\n" +
                            "4) Очищати всі поля та текстовий вивід.\n\n" +
                            "Якщо Ви хочете подивитись весь вміст таблиці, просто клацніть на DOM, SAX, LinqToXML і потім на 'Пошук'.\n\n\n" +
                            "Щасти!");
        }
    }
}

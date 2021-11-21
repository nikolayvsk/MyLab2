
namespace MyLab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox_FullName = new System.Windows.Forms.CheckBox();
            this.checkBox_Faculty = new System.Windows.Forms.CheckBox();
            this.checkBox_Department = new System.Windows.Forms.CheckBox();
            this.checkBox_Position = new System.Windows.Forms.CheckBox();
            this.checkBox_Scientific_Work = new System.Windows.Forms.CheckBox();
            this.checkBox_Customer = new System.Windows.Forms.CheckBox();
            this.checkBox_Address = new System.Windows.Forms.CheckBox();
            this.checkBox_Subordination = new System.Windows.Forms.CheckBox();
            this.checkBox_Area = new System.Windows.Forms.CheckBox();
            this.comboBoxFullName = new System.Windows.Forms.ComboBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxScientific_Work = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.comboBoxSubordination = new System.Windows.Forms.ComboBox();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.DOM_Button = new System.Windows.Forms.RadioButton();
            this.SAX_Button = new System.Windows.Forms.RadioButton();
            this.LinqToXML_Button = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(731, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(875, 584);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // checkBox_FullName
            // 
            this.checkBox_FullName.AutoSize = true;
            this.checkBox_FullName.Location = new System.Drawing.Point(12, 33);
            this.checkBox_FullName.Name = "checkBox_FullName";
            this.checkBox_FullName.Size = new System.Drawing.Size(63, 24);
            this.checkBox_FullName.TabIndex = 1;
            this.checkBox_FullName.Text = "П.І.П";
            this.checkBox_FullName.UseVisualStyleBackColor = true;
            this.checkBox_FullName.CheckedChanged += new System.EventHandler(this.checkBox_FullName_CheckedChanged);
            // 
            // checkBox_Faculty
            // 
            this.checkBox_Faculty.AutoSize = true;
            this.checkBox_Faculty.Location = new System.Drawing.Point(12, 103);
            this.checkBox_Faculty.Name = "checkBox_Faculty";
            this.checkBox_Faculty.Size = new System.Drawing.Size(100, 24);
            this.checkBox_Faculty.TabIndex = 2;
            this.checkBox_Faculty.Text = "Факультет";
            this.checkBox_Faculty.UseVisualStyleBackColor = true;
            this.checkBox_Faculty.CheckedChanged += new System.EventHandler(this.checkBox_Faculty_CheckedChanged);
            // 
            // checkBox_Department
            // 
            this.checkBox_Department.AutoSize = true;
            this.checkBox_Department.Location = new System.Drawing.Point(12, 173);
            this.checkBox_Department.Name = "checkBox_Department";
            this.checkBox_Department.Size = new System.Drawing.Size(91, 24);
            this.checkBox_Department.TabIndex = 3;
            this.checkBox_Department.Text = "Кафедра";
            this.checkBox_Department.UseVisualStyleBackColor = true;
            this.checkBox_Department.CheckedChanged += new System.EventHandler(this.checkBox_Department_CheckedChanged);
            // 
            // checkBox_Position
            // 
            this.checkBox_Position.AutoSize = true;
            this.checkBox_Position.Location = new System.Drawing.Point(12, 243);
            this.checkBox_Position.Name = "checkBox_Position";
            this.checkBox_Position.Size = new System.Drawing.Size(82, 24);
            this.checkBox_Position.TabIndex = 4;
            this.checkBox_Position.Text = "Посада";
            this.checkBox_Position.UseVisualStyleBackColor = true;
            this.checkBox_Position.CheckedChanged += new System.EventHandler(this.checkBox_Position_CheckedChanged);
            // 
            // checkBox_Scientific_Work
            // 
            this.checkBox_Scientific_Work.AutoSize = true;
            this.checkBox_Scientific_Work.Location = new System.Drawing.Point(12, 313);
            this.checkBox_Scientific_Work.Name = "checkBox_Scientific_Work";
            this.checkBox_Scientific_Work.Size = new System.Drawing.Size(173, 44);
            this.checkBox_Scientific_Work.TabIndex = 5;
            this.checkBox_Scientific_Work.Text = "Назва виконуваної \r\nчи дослідної роботи";
            this.checkBox_Scientific_Work.UseVisualStyleBackColor = true;
            this.checkBox_Scientific_Work.CheckedChanged += new System.EventHandler(this.checkBox_Scientific_Work_CheckedChanged);
            // 
            // checkBox_Customer
            // 
            this.checkBox_Customer.AutoSize = true;
            this.checkBox_Customer.Location = new System.Drawing.Point(12, 383);
            this.checkBox_Customer.Name = "checkBox_Customer";
            this.checkBox_Customer.Size = new System.Drawing.Size(100, 24);
            this.checkBox_Customer.TabIndex = 6;
            this.checkBox_Customer.Text = "Замовник";
            this.checkBox_Customer.UseVisualStyleBackColor = true;
            this.checkBox_Customer.CheckedChanged += new System.EventHandler(this.checkBox_Customer_CheckedChanged);
            // 
            // checkBox_Address
            // 
            this.checkBox_Address.AutoSize = true;
            this.checkBox_Address.Location = new System.Drawing.Point(12, 453);
            this.checkBox_Address.Name = "checkBox_Address";
            this.checkBox_Address.Size = new System.Drawing.Size(171, 24);
            this.checkBox_Address.TabIndex = 7;
            this.checkBox_Address.Text = "Адреса (замовника)";
            this.checkBox_Address.UseVisualStyleBackColor = true;
            this.checkBox_Address.CheckedChanged += new System.EventHandler(this.checkBox_Address_CheckedChanged);
            // 
            // checkBox_Subordination
            // 
            this.checkBox_Subordination.AutoSize = true;
            this.checkBox_Subordination.Location = new System.Drawing.Point(12, 523);
            this.checkBox_Subordination.Name = "checkBox_Subordination";
            this.checkBox_Subordination.Size = new System.Drawing.Size(153, 24);
            this.checkBox_Subordination.TabIndex = 8;
            this.checkBox_Subordination.Text = "Підпорядкування";
            this.checkBox_Subordination.UseVisualStyleBackColor = true;
            this.checkBox_Subordination.CheckedChanged += new System.EventHandler(this.checkBox_Subordination_CheckedChanged);
            // 
            // checkBox_Area
            // 
            this.checkBox_Area.AutoSize = true;
            this.checkBox_Area.Location = new System.Drawing.Point(12, 593);
            this.checkBox_Area.Name = "checkBox_Area";
            this.checkBox_Area.Size = new System.Drawing.Size(76, 24);
            this.checkBox_Area.TabIndex = 9;
            this.checkBox_Area.Text = "Галузь";
            this.checkBox_Area.UseVisualStyleBackColor = true;
            this.checkBox_Area.CheckedChanged += new System.EventHandler(this.checkBox_Area_CheckedChanged);
            // 
            // comboBoxFullName
            // 
            this.comboBoxFullName.FormattingEnabled = true;
            this.comboBoxFullName.Location = new System.Drawing.Point(191, 33);
            this.comboBoxFullName.Name = "comboBoxFullName";
            this.comboBoxFullName.Size = new System.Drawing.Size(534, 28);
            this.comboBoxFullName.TabIndex = 10;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(191, 101);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(534, 28);
            this.comboBoxFaculty.TabIndex = 11;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(191, 171);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(534, 28);
            this.comboBoxDepartment.TabIndex = 12;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(191, 241);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(534, 28);
            this.comboBoxPosition.TabIndex = 13;
            // 
            // comboBoxScientific_Work
            // 
            this.comboBoxScientific_Work.FormattingEnabled = true;
            this.comboBoxScientific_Work.Location = new System.Drawing.Point(191, 321);
            this.comboBoxScientific_Work.Name = "comboBoxScientific_Work";
            this.comboBoxScientific_Work.Size = new System.Drawing.Size(534, 28);
            this.comboBoxScientific_Work.TabIndex = 14;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(191, 383);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(534, 28);
            this.comboBoxCustomer.TabIndex = 15;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(191, 453);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(534, 28);
            this.comboBoxAddress.TabIndex = 16;
            // 
            // comboBoxSubordination
            // 
            this.comboBoxSubordination.FormattingEnabled = true;
            this.comboBoxSubordination.Location = new System.Drawing.Point(191, 523);
            this.comboBoxSubordination.Name = "comboBoxSubordination";
            this.comboBoxSubordination.Size = new System.Drawing.Size(534, 28);
            this.comboBoxSubordination.TabIndex = 17;
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(191, 589);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(534, 28);
            this.comboBoxArea.TabIndex = 18;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(731, 620);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(875, 37);
            this.Search_button.TabIndex = 19;
            this.Search_button.Text = "Пошук";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // DOM_Button
            // 
            this.DOM_Button.AutoSize = true;
            this.DOM_Button.Location = new System.Drawing.Point(12, 633);
            this.DOM_Button.Name = "DOM_Button";
            this.DOM_Button.Size = new System.Drawing.Size(65, 24);
            this.DOM_Button.TabIndex = 20;
            this.DOM_Button.TabStop = true;
            this.DOM_Button.Text = "DOM";
            this.DOM_Button.UseVisualStyleBackColor = true;
            // 
            // SAX_Button
            // 
            this.SAX_Button.AutoSize = true;
            this.SAX_Button.Location = new System.Drawing.Point(223, 633);
            this.SAX_Button.Name = "SAX_Button";
            this.SAX_Button.Size = new System.Drawing.Size(57, 24);
            this.SAX_Button.TabIndex = 21;
            this.SAX_Button.TabStop = true;
            this.SAX_Button.Text = "SAX";
            this.SAX_Button.UseVisualStyleBackColor = true;
            // 
            // LinqToXML_Button
            // 
            this.LinqToXML_Button.AutoSize = true;
            this.LinqToXML_Button.Location = new System.Drawing.Point(410, 633);
            this.LinqToXML_Button.Name = "LinqToXML_Button";
            this.LinqToXML_Button.Size = new System.Drawing.Size(103, 24);
            this.LinqToXML_Button.TabIndex = 22;
            this.LinqToXML_Button.TabStop = true;
            this.LinqToXML_Button.Text = "LinqToXML";
            this.LinqToXML_Button.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1611, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toHTMLToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toHTMLToolStripMenuItem
            // 
            this.toHTMLToolStripMenuItem.Name = "toHTMLToolStripMenuItem";
            this.toHTMLToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.toHTMLToolStripMenuItem.Text = "To HTML";
            this.toHTMLToolStripMenuItem.Click += new System.EventHandler(this.toHTMLToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.infoToolStripMenuItem.Text = "Info/Help";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 668);
            this.Controls.Add(this.LinqToXML_Button);
            this.Controls.Add(this.SAX_Button);
            this.Controls.Add(this.DOM_Button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.comboBoxSubordination);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.comboBoxScientific_Work);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.comboBoxFullName);
            this.Controls.Add(this.checkBox_Area);
            this.Controls.Add(this.checkBox_Subordination);
            this.Controls.Add(this.checkBox_Address);
            this.Controls.Add(this.checkBox_Customer);
            this.Controls.Add(this.checkBox_Scientific_Work);
            this.Controls.Add(this.checkBox_Position);
            this.Controls.Add(this.checkBox_Department);
            this.Controls.Add(this.checkBox_Faculty);
            this.Controls.Add(this.checkBox_FullName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Scientific work of the department";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox_FullName;
        private System.Windows.Forms.CheckBox checkBox_Faculty;
        private System.Windows.Forms.CheckBox checkBox_Department;
        private System.Windows.Forms.CheckBox checkBox_Position;
        private System.Windows.Forms.CheckBox checkBox_Scientific_Work;
        private System.Windows.Forms.CheckBox checkBox_Customer;
        private System.Windows.Forms.CheckBox checkBox_Address;
        private System.Windows.Forms.CheckBox checkBox_Subordination;
        private System.Windows.Forms.CheckBox checkBox_Area;
        private System.Windows.Forms.ComboBox comboBoxFullName;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxScientific_Work;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxSubordination;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.RadioButton DOM_Button;
        private System.Windows.Forms.RadioButton SAX_Button;
        private System.Windows.Forms.RadioButton LinqToXML_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}


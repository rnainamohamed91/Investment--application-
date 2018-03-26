namespace Assignment_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthRadio12 = new System.Windows.Forms.RadioButton();
            this.monthRadio6 = new System.Windows.Forms.RadioButton();
            this.monthRadio3 = new System.Windows.Forms.RadioButton();
            this.monthRadio1 = new System.Windows.Forms.RadioButton();
            this.proceedButton = new System.Windows.Forms.Button();
            this.customerInfoGroupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.uIdTextBox = new System.Windows.Forms.TextBox();
            this.cIdTextBox = new System.Windows.Forms.TextBox();
            this.finBalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.intRateTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.teleNoTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.transNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionNumber = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.summaryGroupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.averageTermTextBox5 = new System.Windows.Forms.TextBox();
            this.totalIntrestTextBox4 = new System.Windows.Forms.TextBox();
            this.totalAmountInvestedtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.summaryButton2 = new System.Windows.Forms.Button();
            this.emailSearchTextBox = new System.Windows.Forms.TextBox();
            this.emailSearchButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.investTabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmTabPage2 = new System.Windows.Forms.TabPage();
            this.investedTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryTabPage3 = new System.Windows.Forms.TabPage();
            this.summaryClearButton = new System.Windows.Forms.Button();
            this.serachTabPage4 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.customerInfoGroupBox2.SuspendLayout();
            this.summaryGroupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.investTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.confirmTabPage2.SuspendLayout();
            this.summaryTabPage3.SuspendLayout();
            this.serachTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox1, "Please enter your amount of investment here");
            // 
            // displayButton
            // 
            this.displayButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.displayButton.Location = new System.Drawing.Point(161, 11);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.displayButton, "Click here to display the amount");
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthRadio12);
            this.groupBox1.Controls.Add(this.monthRadio6);
            this.groupBox1.Controls.Add(this.monthRadio3);
            this.groupBox1.Controls.Add(this.monthRadio1);
            this.groupBox1.Location = new System.Drawing.Point(9, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plans";
            // 
            // monthRadio12
            // 
            this.monthRadio12.AutoSize = true;
            this.monthRadio12.Location = new System.Drawing.Point(10, 94);
            this.monthRadio12.Name = "monthRadio12";
            this.monthRadio12.Size = new System.Drawing.Size(74, 17);
            this.monthRadio12.TabIndex = 3;
            this.monthRadio12.TabStop = true;
            this.monthRadio12.Text = "12 months";
            this.monthRadio12.UseVisualStyleBackColor = true;
            // 
            // monthRadio6
            // 
            this.monthRadio6.AutoSize = true;
            this.monthRadio6.Location = new System.Drawing.Point(10, 71);
            this.monthRadio6.Name = "monthRadio6";
            this.monthRadio6.Size = new System.Drawing.Size(68, 17);
            this.monthRadio6.TabIndex = 2;
            this.monthRadio6.TabStop = true;
            this.monthRadio6.Text = "6 months";
            this.monthRadio6.UseVisualStyleBackColor = true;
            // 
            // monthRadio3
            // 
            this.monthRadio3.AutoSize = true;
            this.monthRadio3.Location = new System.Drawing.Point(10, 48);
            this.monthRadio3.Name = "monthRadio3";
            this.monthRadio3.Size = new System.Drawing.Size(68, 17);
            this.monthRadio3.TabIndex = 1;
            this.monthRadio3.TabStop = true;
            this.monthRadio3.Text = "3 months";
            this.monthRadio3.UseVisualStyleBackColor = true;
            // 
            // monthRadio1
            // 
            this.monthRadio1.AutoSize = true;
            this.monthRadio1.Location = new System.Drawing.Point(10, 21);
            this.monthRadio1.Name = "monthRadio1";
            this.monthRadio1.Size = new System.Drawing.Size(66, 17);
            this.monthRadio1.TabIndex = 0;
            this.monthRadio1.TabStop = true;
            this.monthRadio1.Text = "1 month ";
            this.monthRadio1.UseVisualStyleBackColor = true;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(438, 209);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 4;
            this.proceedButton.Text = "&Proceed";
            this.toolTip1.SetToolTip(this.proceedButton, "click here to proceed with investment");
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // customerInfoGroupBox2
            // 
            this.customerInfoGroupBox2.Controls.Add(this.investedTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.label13);
            this.customerInfoGroupBox2.Controls.Add(this.label19);
            this.customerInfoGroupBox2.Controls.Add(this.label18);
            this.customerInfoGroupBox2.Controls.Add(this.label16);
            this.customerInfoGroupBox2.Controls.Add(this.label15);
            this.customerInfoGroupBox2.Controls.Add(this.label14);
            this.customerInfoGroupBox2.Controls.Add(this.uIdTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.cIdTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.finBalTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.label8);
            this.customerInfoGroupBox2.Controls.Add(this.intRateTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.monthTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.label7);
            this.customerInfoGroupBox2.Controls.Add(this.label2);
            this.customerInfoGroupBox2.Controls.Add(this.emailTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.teleNoTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.firstNameTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.lastNameTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.transNumberTextBox);
            this.customerInfoGroupBox2.Controls.Add(this.label6);
            this.customerInfoGroupBox2.Controls.Add(this.label5);
            this.customerInfoGroupBox2.Controls.Add(this.label4);
            this.customerInfoGroupBox2.Controls.Add(this.label3);
            this.customerInfoGroupBox2.Controls.Add(this.transactionNumber);
            this.customerInfoGroupBox2.Location = new System.Drawing.Point(21, 6);
            this.customerInfoGroupBox2.Name = "customerInfoGroupBox2";
            this.customerInfoGroupBox2.Size = new System.Drawing.Size(311, 264);
            this.customerInfoGroupBox2.TabIndex = 5;
            this.customerInfoGroupBox2.TabStop = false;
            this.customerInfoGroupBox2.Text = "Customer Info";
            this.customerInfoGroupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(227, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(158, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(247, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Unique ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(182, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "client ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(103, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "employee ID";
            // 
            // uIdTextBox
            // 
            this.uIdTextBox.Location = new System.Drawing.Point(239, 33);
            this.uIdTextBox.MaxLength = 3;
            this.uIdTextBox.Name = "uIdTextBox";
            this.uIdTextBox.Size = new System.Drawing.Size(52, 20);
            this.uIdTextBox.TabIndex = 18;
            this.uIdTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cIdTextBox
            // 
            this.cIdTextBox.Location = new System.Drawing.Point(174, 33);
            this.cIdTextBox.MaxLength = 4;
            this.cIdTextBox.Name = "cIdTextBox";
            this.cIdTextBox.Size = new System.Drawing.Size(47, 20);
            this.cIdTextBox.TabIndex = 17;
            // 
            // finBalTextBox
            // 
            this.finBalTextBox.Location = new System.Drawing.Point(128, 211);
            this.finBalTextBox.Name = "finBalTextBox";
            this.finBalTextBox.Size = new System.Drawing.Size(100, 20);
            this.finBalTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Final Balance ";
            // 
            // intRateTextBox
            // 
            this.intRateTextBox.Location = new System.Drawing.Point(128, 186);
            this.intRateTextBox.Name = "intRateTextBox";
            this.intRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.intRateTextBox.TabIndex = 14;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(128, 158);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Intrest rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Month";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(128, 132);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // teleNoTextBox
            // 
            this.teleNoTextBox.Location = new System.Drawing.Point(128, 106);
            this.teleNoTextBox.Name = "teleNoTextBox";
            this.teleNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.teleNoTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(127, 56);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(127, 82);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // transNumberTextBox
            // 
            this.transNumberTextBox.Location = new System.Drawing.Point(106, 33);
            this.transNumberTextBox.MaxLength = 3;
            this.transNumberTextBox.Name = "transNumberTextBox";
            this.transNumberTextBox.Size = new System.Drawing.Size(46, 20);
            this.transNumberTextBox.TabIndex = 5;
            this.transNumberTextBox.TextChanged += new System.EventHandler(this.transNumberTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telephone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name";
            // 
            // transactionNumber
            // 
            this.transactionNumber.AutoSize = true;
            this.transactionNumber.Location = new System.Drawing.Point(6, 33);
            this.transactionNumber.Name = "transactionNumber";
            this.transactionNumber.Size = new System.Drawing.Size(101, 13);
            this.transactionNumber.TabIndex = 0;
            this.transactionNumber.Text = "Transaction number";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(21, 276);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "&confirm";
            this.toolTip1.SetToolTip(this.confirmButton, "click here to confirm");
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // summaryGroupBox3
            // 
            this.summaryGroupBox3.Controls.Add(this.listBox1);
            this.summaryGroupBox3.Controls.Add(this.averageTermTextBox5);
            this.summaryGroupBox3.Controls.Add(this.totalIntrestTextBox4);
            this.summaryGroupBox3.Controls.Add(this.totalAmountInvestedtextBox);
            this.summaryGroupBox3.Controls.Add(this.label12);
            this.summaryGroupBox3.Controls.Add(this.label11);
            this.summaryGroupBox3.Controls.Add(this.label10);
            this.summaryGroupBox3.Controls.Add(this.label9);
            this.summaryGroupBox3.Location = new System.Drawing.Point(34, 75);
            this.summaryGroupBox3.Name = "summaryGroupBox3";
            this.summaryGroupBox3.Size = new System.Drawing.Size(284, 218);
            this.summaryGroupBox3.TabIndex = 6;
            this.summaryGroupBox3.TabStop = false;
            this.summaryGroupBox3.Text = "Summary";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(143, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 15;
            // 
            // averageTermTextBox5
            // 
            this.averageTermTextBox5.Location = new System.Drawing.Point(152, 186);
            this.averageTermTextBox5.Name = "averageTermTextBox5";
            this.averageTermTextBox5.Size = new System.Drawing.Size(100, 20);
            this.averageTermTextBox5.TabIndex = 8;
            // 
            // totalIntrestTextBox4
            // 
            this.totalIntrestTextBox4.Location = new System.Drawing.Point(152, 155);
            this.totalIntrestTextBox4.Name = "totalIntrestTextBox4";
            this.totalIntrestTextBox4.Size = new System.Drawing.Size(100, 20);
            this.totalIntrestTextBox4.TabIndex = 7;
            // 
            // totalAmountInvestedtextBox
            // 
            this.totalAmountInvestedtextBox.Location = new System.Drawing.Point(152, 119);
            this.totalAmountInvestedtextBox.Name = "totalAmountInvestedtextBox";
            this.totalAmountInvestedtextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountInvestedtextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Average Terms of investment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total Intrest";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Amount Invested";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "List Of Transaction";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(472, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(169, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(275, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(60, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Clear";
            this.toolTip1.SetToolTip(this.button1, "click here to clear data");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clearButton1_Click);
            // 
            // summaryButton2
            // 
            this.summaryButton2.Location = new System.Drawing.Point(94, 26);
            this.summaryButton2.Name = "summaryButton2";
            this.summaryButton2.Size = new System.Drawing.Size(75, 23);
            this.summaryButton2.TabIndex = 11;
            this.summaryButton2.Text = "&Summary";
            this.summaryButton2.UseVisualStyleBackColor = true;
            this.summaryButton2.Click += new System.EventHandler(this.summaryButton2_Click);
            // 
            // emailSearchTextBox
            // 
            this.emailSearchTextBox.Location = new System.Drawing.Point(169, 57);
            this.emailSearchTextBox.Name = "emailSearchTextBox";
            this.emailSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailSearchTextBox.TabIndex = 12;
            // 
            // emailSearchButton
            // 
            this.emailSearchButton.Location = new System.Drawing.Point(275, 55);
            this.emailSearchButton.Name = "emailSearchButton";
            this.emailSearchButton.Size = new System.Drawing.Size(60, 23);
            this.emailSearchButton.TabIndex = 13;
            this.emailSearchButton.Text = "Searc&h";
            this.emailSearchButton.UseVisualStyleBackColor = true;
            this.emailSearchButton.Click += new System.EventHandler(this.emailSearchButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Search by Transaction Number";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Search by Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.emailSearchButton);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.emailSearchTextBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Location = new System.Drawing.Point(19, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 109);
            this.panel1.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.investTabPage1);
            this.tabControl1.Controls.Add(this.confirmTabPage2);
            this.tabControl1.Controls.Add(this.summaryTabPage3);
            this.tabControl1.Controls.Add(this.serachTabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(535, 332);
            this.tabControl1.TabIndex = 18;
            // 
            // investTabPage1
            // 
            this.investTabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("investTabPage1.BackgroundImage")));
            this.investTabPage1.Controls.Add(this.pictureBox1);
            this.investTabPage1.Controls.Add(this.proceedButton);
            this.investTabPage1.Controls.Add(this.groupBox1);
            this.investTabPage1.Controls.Add(this.displayButton);
            this.investTabPage1.Controls.Add(this.button1);
            this.investTabPage1.Controls.Add(this.textBox1);
            this.investTabPage1.Controls.Add(this.label1);
            this.investTabPage1.Location = new System.Drawing.Point(4, 22);
            this.investTabPage1.Name = "investTabPage1";
            this.investTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.investTabPage1.Size = new System.Drawing.Size(527, 306);
            this.investTabPage1.TabIndex = 0;
            this.investTabPage1.Text = "Investment";
            this.investTabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 123);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // confirmTabPage2
            // 
            this.confirmTabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmTabPage2.BackgroundImage")));
            this.confirmTabPage2.Controls.Add(this.backButton);
            this.confirmTabPage2.Controls.Add(this.clearButton);
            this.confirmTabPage2.Controls.Add(this.customerInfoGroupBox2);
            this.confirmTabPage2.Controls.Add(this.confirmButton);
            this.confirmTabPage2.Location = new System.Drawing.Point(4, 22);
            this.confirmTabPage2.Name = "confirmTabPage2";
            this.confirmTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.confirmTabPage2.Size = new System.Drawing.Size(527, 306);
            this.confirmTabPage2.TabIndex = 1;
            this.confirmTabPage2.Text = "Confirmation";
            this.confirmTabPage2.UseVisualStyleBackColor = true;
            // 
            // investedTextBox
            // 
            this.investedTextBox.Location = new System.Drawing.Point(127, 235);
            this.investedTextBox.Name = "investedTextBox";
            this.investedTextBox.Size = new System.Drawing.Size(100, 20);
            this.investedTextBox.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Intial Amont";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(218, 276);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "&Back";
            this.toolTip1.SetToolTip(this.backButton, "click here to go back to the previous page");
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(115, 276);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // summaryTabPage3
            // 
            this.summaryTabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("summaryTabPage3.BackgroundImage")));
            this.summaryTabPage3.Controls.Add(this.summaryClearButton);
            this.summaryTabPage3.Controls.Add(this.summaryButton2);
            this.summaryTabPage3.Controls.Add(this.summaryGroupBox3);
            this.summaryTabPage3.Location = new System.Drawing.Point(4, 22);
            this.summaryTabPage3.Name = "summaryTabPage3";
            this.summaryTabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.summaryTabPage3.Size = new System.Drawing.Size(527, 306);
            this.summaryTabPage3.TabIndex = 2;
            this.summaryTabPage3.Text = "Summary";
            this.summaryTabPage3.UseVisualStyleBackColor = true;
            this.summaryTabPage3.Click += new System.EventHandler(this.summaryTabPage3_Click);
            // 
            // summaryClearButton
            // 
            this.summaryClearButton.Location = new System.Drawing.Point(233, 26);
            this.summaryClearButton.Name = "summaryClearButton";
            this.summaryClearButton.Size = new System.Drawing.Size(75, 23);
            this.summaryClearButton.TabIndex = 12;
            this.summaryClearButton.Text = "cl&ear";
            this.summaryClearButton.UseVisualStyleBackColor = true;
            this.summaryClearButton.Click += new System.EventHandler(this.summaryClearButton_Click);
            // 
            // serachTabPage4
            // 
            this.serachTabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("serachTabPage4.BackgroundImage")));
            this.serachTabPage4.Controls.Add(this.panel1);
            this.serachTabPage4.Location = new System.Drawing.Point(4, 22);
            this.serachTabPage4.Name = "serachTabPage4";
            this.serachTabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.serachTabPage4.Size = new System.Drawing.Size(527, 306);
            this.serachTabPage4.TabIndex = 3;
            this.serachTabPage4.Text = "Search";
            this.serachTabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 399);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Invest Q";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.customerInfoGroupBox2.ResumeLayout(false);
            this.customerInfoGroupBox2.PerformLayout();
            this.summaryGroupBox3.ResumeLayout(false);
            this.summaryGroupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.investTabPage1.ResumeLayout(false);
            this.investTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.confirmTabPage2.ResumeLayout(false);
            this.summaryTabPage3.ResumeLayout(false);
            this.serachTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton monthRadio12;
        private System.Windows.Forms.RadioButton monthRadio6;
        private System.Windows.Forms.RadioButton monthRadio3;
        private System.Windows.Forms.RadioButton monthRadio1;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.GroupBox customerInfoGroupBox2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox teleNoTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox transNumberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label transactionNumber;
        private System.Windows.Forms.GroupBox summaryGroupBox3;
        private System.Windows.Forms.Button exitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox intRateTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finBalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox averageTermTextBox5;
        private System.Windows.Forms.TextBox totalIntrestTextBox4;
        private System.Windows.Forms.TextBox totalAmountInvestedtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button summaryButton2;
        private System.Windows.Forms.TextBox uIdTextBox;
        private System.Windows.Forms.TextBox cIdTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox emailSearchTextBox;
        private System.Windows.Forms.Button emailSearchButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage investTabPage1;
        private System.Windows.Forms.TabPage confirmTabPage2;
        private System.Windows.Forms.TabPage summaryTabPage3;
        private System.Windows.Forms.TabPage serachTabPage4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button summaryClearButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox investedTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


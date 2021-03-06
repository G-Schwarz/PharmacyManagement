﻿namespace PharmacyManagement
{
    partial class UC_Customers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.lb_CustomerType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxb_Note = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_TaxID = new System.Windows.Forms.TextBox();
            this.txb_Addresses = new System.Windows.Forms.TextBox();
            this.txb_CompanyName = new System.Windows.Forms.TextBox();
            this.txb_CMND = new System.Windows.Forms.TextBox();
            this.txb_PhoneNo = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.rbtn_Sex = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Addresses = new System.Windows.Forms.Label();
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_PhoneNo = new System.Windows.Forms.Label();
            this.lb_CustomerGroup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_CustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.rbtn_Femal = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbtn_Personal = new System.Windows.Forms.RadioButton();
            this.rtbn_Company = new System.Windows.Forms.RadioButton();
            this.txb_CustomerName = new System.Windows.Forms.TextBox();
            this.txb_CustomerID = new System.Windows.Forms.TextBox();
            this.cb_CustomerGroup = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.btn_AddCustomer);
            this.panel1.Controls.Add(this.lb_CustomerType);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 110);
            this.panel1.TabIndex = 20;
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AddCustomer.FlatAppearance.BorderSize = 0;
            this.btn_AddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_AddCustomer.Location = new System.Drawing.Point(1145, 46);
            this.btn_AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(120, 46);
            this.btn_AddCustomer.TabIndex = 25;
            this.btn_AddCustomer.Text = "Thêm";
            this.btn_AddCustomer.UseVisualStyleBackColor = false;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // lb_CustomerType
            // 
            this.lb_CustomerType.AutoSize = true;
            this.lb_CustomerType.BackColor = System.Drawing.Color.Transparent;
            this.lb_CustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_CustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lb_CustomerType.Location = new System.Drawing.Point(20, 30);
            this.lb_CustomerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CustomerType.Name = "lb_CustomerType";
            this.lb_CustomerType.Size = new System.Drawing.Size(165, 20);
            this.lb_CustomerType.TabIndex = 22;
            this.lb_CustomerType.Text = "Nhóm Khách Hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(415, 33);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(4, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 508);
            this.panel2.TabIndex = 21;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(1145, 46);
            this.savebutton.Margin = new System.Windows.Forms.Padding(4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(120, 46);
            this.savebutton.TabIndex = 26;
            this.savebutton.Text = "Lưu";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelbutton.FlatAppearance.BorderSize = 0;
            this.cancelbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.Location = new System.Drawing.Point(945, 46);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(120, 46);
            this.cancelbutton.TabIndex = 27;
            this.cancelbutton.Text = "Hủy";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cancelbutton);
            this.panel6.Controls.Add(this.savebutton);
            this.panel6.Location = new System.Drawing.Point(0, 516);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1267, 110);
            this.panel6.TabIndex = 27;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rtxb_Note);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txb_TaxID);
            this.panel3.Controls.Add(this.txb_Addresses);
            this.panel3.Controls.Add(this.txb_CompanyName);
            this.panel3.Controls.Add(this.txb_CMND);
            this.panel3.Controls.Add(this.txb_PhoneNo);
            this.panel3.Controls.Add(this.txb_Email);
            this.panel3.Controls.Add(this.rbtn_Sex);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btn_Cancel);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lb_Addresses);
            this.panel3.Controls.Add(this.lb_CompanyName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lb_Email);
            this.panel3.Controls.Add(this.lb_PhoneNo);
            this.panel3.Controls.Add(this.lb_CustomerGroup);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lb_CustomerName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.txb_CustomerName);
            this.panel3.Controls.Add(this.txb_CustomerID);
            this.panel3.Controls.Add(this.cb_CustomerGroup);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1297, 508);
            this.panel3.TabIndex = 28;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "Ghi Chú";
            // 
            // rtxb_Note
            // 
            this.rtxb_Note.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_Note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxb_Note.Location = new System.Drawing.Point(45, 401);
            this.rtxb_Note.Margin = new System.Windows.Forms.Padding(4);
            this.rtxb_Note.Name = "rtxb_Note";
            this.rtxb_Note.Size = new System.Drawing.Size(1200, 88);
            this.rtxb_Note.TabIndex = 123;
            this.rtxb_Note.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "Mã Số Thuế";
            // 
            // txb_TaxID
            // 
            this.txb_TaxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TaxID.Location = new System.Drawing.Point(671, 238);
            this.txb_TaxID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TaxID.Name = "txb_TaxID";
            this.txb_TaxID.Size = new System.Drawing.Size(261, 30);
            this.txb_TaxID.TabIndex = 121;
            // 
            // txb_Addresses
            // 
            this.txb_Addresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Addresses.Location = new System.Drawing.Point(45, 321);
            this.txb_Addresses.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Addresses.Name = "txb_Addresses";
            this.txb_Addresses.Size = new System.Drawing.Size(1200, 30);
            this.txb_Addresses.TabIndex = 120;
            // 
            // txb_CompanyName
            // 
            this.txb_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CompanyName.Location = new System.Drawing.Point(352, 238);
            this.txb_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CompanyName.Name = "txb_CompanyName";
            this.txb_CompanyName.Size = new System.Drawing.Size(261, 30);
            this.txb_CompanyName.TabIndex = 119;
            // 
            // txb_CMND
            // 
            this.txb_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CMND.Location = new System.Drawing.Point(45, 143);
            this.txb_CMND.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CMND.Name = "txb_CMND";
            this.txb_CMND.Size = new System.Drawing.Size(261, 30);
            this.txb_CMND.TabIndex = 118;
            // 
            // txb_PhoneNo
            // 
            this.txb_PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PhoneNo.Location = new System.Drawing.Point(352, 143);
            this.txb_PhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_PhoneNo.Name = "txb_PhoneNo";
            this.txb_PhoneNo.Size = new System.Drawing.Size(261, 30);
            this.txb_PhoneNo.TabIndex = 117;
            // 
            // txb_Email
            // 
            this.txb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Email.Location = new System.Drawing.Point(45, 238);
            this.txb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(261, 30);
            this.txb_Email.TabIndex = 116;
            // 
            // rbtn_Sex
            // 
            this.rbtn_Sex.AutoSize = true;
            this.rbtn_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Sex.Location = new System.Drawing.Point(976, 121);
            this.rbtn_Sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rbtn_Sex.Name = "rbtn_Sex";
            this.rbtn_Sex.Size = new System.Drawing.Size(76, 20);
            this.rbtn_Sex.TabIndex = 115;
            this.rbtn_Sex.Text = "Giới Tính";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(976, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 114;
            this.label13.Text = "Loại Khách Hàng";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(1077, 519);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(165, 37);
            this.btn_Cancel.TabIndex = 113;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(883, 519);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 112;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lb_Addresses
            // 
            this.lb_Addresses.AutoSize = true;
            this.lb_Addresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Addresses.Location = new System.Drawing.Point(45, 298);
            this.lb_Addresses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Addresses.Name = "lb_Addresses";
            this.lb_Addresses.Size = new System.Drawing.Size(64, 20);
            this.lb_Addresses.TabIndex = 109;
            this.lb_Addresses.Text = "Địa Chỉ";
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CompanyName.Location = new System.Drawing.Point(348, 214);
            this.lb_CompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(71, 20);
            this.lb_CompanyName.TabIndex = 108;
            this.lb_CompanyName.Text = "Công Ty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(667, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 107;
            this.label9.Text = "Ngày Sinh";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(45, 214);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(51, 20);
            this.lb_Email.TabIndex = 106;
            this.lb_Email.Text = "Email";
            // 
            // lb_PhoneNo
            // 
            this.lb_PhoneNo.AutoSize = true;
            this.lb_PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneNo.Location = new System.Drawing.Point(348, 121);
            this.lb_PhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PhoneNo.Name = "lb_PhoneNo";
            this.lb_PhoneNo.Size = new System.Drawing.Size(42, 20);
            this.lb_PhoneNo.TabIndex = 105;
            this.lb_PhoneNo.Text = "SĐT";
            // 
            // lb_CustomerGroup
            // 
            this.lb_CustomerGroup.AutoSize = true;
            this.lb_CustomerGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerGroup.Location = new System.Drawing.Point(667, 33);
            this.lb_CustomerGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CustomerGroup.Name = "lb_CustomerGroup";
            this.lb_CustomerGroup.Size = new System.Drawing.Size(150, 20);
            this.lb_CustomerGroup.TabIndex = 104;
            this.lb_CustomerGroup.Text = "Nhóm Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "CMND";
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerName.Location = new System.Drawing.Point(348, 33);
            this.lb_CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(134, 20);
            this.lb_CustomerName.TabIndex = 102;
            this.lb_CustomerName.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(671, 146);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtn_Male);
            this.panel4.Controls.Add(this.rbtn_Femal);
            this.panel4.Location = new System.Drawing.Point(980, 146);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 30);
            this.panel4.TabIndex = 99;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.FlatAppearance.BorderSize = 0;
            this.rbtn_Male.Location = new System.Drawing.Point(0, 4);
            this.rbtn_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(58, 21);
            this.rbtn_Male.TabIndex = 28;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Nam";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // rbtn_Femal
            // 
            this.rbtn_Femal.AutoSize = true;
            this.rbtn_Femal.FlatAppearance.BorderSize = 0;
            this.rbtn_Femal.Location = new System.Drawing.Point(139, 4);
            this.rbtn_Femal.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_Femal.Name = "rbtn_Femal";
            this.rbtn_Femal.Size = new System.Drawing.Size(47, 21);
            this.rbtn_Femal.TabIndex = 29;
            this.rbtn_Femal.TabStop = true;
            this.rbtn_Femal.Text = "Nữ";
            this.rbtn_Femal.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbtn_Personal);
            this.panel5.Controls.Add(this.rtbn_Company);
            this.panel5.Location = new System.Drawing.Point(980, 53);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 30);
            this.panel5.TabIndex = 98;
            // 
            // rbtn_Personal
            // 
            this.rbtn_Personal.AutoSize = true;
            this.rbtn_Personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Personal.Location = new System.Drawing.Point(0, 4);
            this.rbtn_Personal.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_Personal.Name = "rbtn_Personal";
            this.rbtn_Personal.Size = new System.Drawing.Size(95, 24);
            this.rbtn_Personal.TabIndex = 28;
            this.rbtn_Personal.TabStop = true;
            this.rbtn_Personal.Text = "Cá Nhân";
            this.rbtn_Personal.UseVisualStyleBackColor = true;
            // 
            // rtbn_Company
            // 
            this.rtbn_Company.AutoSize = true;
            this.rtbn_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbn_Company.Location = new System.Drawing.Point(139, 4);
            this.rtbn_Company.Margin = new System.Windows.Forms.Padding(4);
            this.rtbn_Company.Name = "rtbn_Company";
            this.rtbn_Company.Size = new System.Drawing.Size(92, 24);
            this.rtbn_Company.TabIndex = 29;
            this.rtbn_Company.TabStop = true;
            this.rtbn_Company.Text = "Công Ty";
            this.rtbn_Company.UseVisualStyleBackColor = true;
            // 
            // txb_CustomerName
            // 
            this.txb_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CustomerName.Location = new System.Drawing.Point(352, 57);
            this.txb_CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CustomerName.Name = "txb_CustomerName";
            this.txb_CustomerName.Size = new System.Drawing.Size(261, 30);
            this.txb_CustomerName.TabIndex = 97;
            // 
            // txb_CustomerID
            // 
            this.txb_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CustomerID.Location = new System.Drawing.Point(45, 57);
            this.txb_CustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CustomerID.Name = "txb_CustomerID";
            this.txb_CustomerID.Size = new System.Drawing.Size(261, 30);
            this.txb_CustomerID.TabIndex = 96;
            // 
            // cb_CustomerGroup
            // 
            this.cb_CustomerGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CustomerGroup.FormattingEnabled = true;
            this.cb_CustomerGroup.Location = new System.Drawing.Point(671, 53);
            this.cb_CustomerGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cb_CustomerGroup.Name = "cb_CustomerGroup";
            this.cb_CustomerGroup.Size = new System.Drawing.Size(261, 33);
            this.cb_CustomerGroup.TabIndex = 95;
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(1301, 633);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Label lb_CustomerType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_Addresses;
        private System.Windows.Forms.TextBox txb_CompanyName;
        private System.Windows.Forms.TextBox txb_CMND;
        private System.Windows.Forms.TextBox txb_PhoneNo;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label rbtn_Sex;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Addresses;
        private System.Windows.Forms.Label lb_CompanyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_PhoneNo;
        private System.Windows.Forms.Label lb_CustomerGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.RadioButton rbtn_Femal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbtn_Personal;
        private System.Windows.Forms.RadioButton rtbn_Company;
        private System.Windows.Forms.TextBox txb_CustomerName;
        private System.Windows.Forms.TextBox txb_CustomerID;
        private System.Windows.Forms.ComboBox cb_CustomerGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxb_Note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_TaxID;
    }
}

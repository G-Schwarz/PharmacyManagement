namespace PharmacyManagement
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_CustomerType = new System.Windows.Forms.Label();
            this.btn_CustomerSearch = new System.Windows.Forms.Button();
            this.lb_Keyword = new System.Windows.Forms.Label();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(374, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 26);
            this.textBox2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_AddCustomer);
            this.panel1.Controls.Add(this.lb_Keyword);
            this.panel1.Controls.Add(this.btn_CustomerSearch);
            this.panel1.Controls.Add(this.lb_CustomerType);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 89);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 413);
            this.panel2.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // lb_CustomerType
            // 
            this.lb_CustomerType.AutoSize = true;
            this.lb_CustomerType.BackColor = System.Drawing.Color.White;
            this.lb_CustomerType.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerType.Location = new System.Drawing.Point(13, 21);
            this.lb_CustomerType.Name = "lb_CustomerType";
            this.lb_CustomerType.Size = new System.Drawing.Size(112, 15);
            this.lb_CustomerType.TabIndex = 22;
            this.lb_CustomerType.Text = "Nhóm Khách Hàng";
            // 
            // btn_CustomerSearch
            // 
            this.btn_CustomerSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_CustomerSearch.FlatAppearance.BorderSize = 0;
            this.btn_CustomerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_CustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomerSearch.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerSearch.ForeColor = System.Drawing.Color.White;
            this.btn_CustomerSearch.Location = new System.Drawing.Point(737, 38);
            this.btn_CustomerSearch.Name = "btn_CustomerSearch";
            this.btn_CustomerSearch.Size = new System.Drawing.Size(89, 30);
            this.btn_CustomerSearch.TabIndex = 23;
            this.btn_CustomerSearch.Text = "Tìm Kiếm";
            this.btn_CustomerSearch.UseVisualStyleBackColor = false;
            // 
            // lb_Keyword
            // 
            this.lb_Keyword.AutoSize = true;
            this.lb_Keyword.BackColor = System.Drawing.Color.White;
            this.lb_Keyword.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Keyword.Location = new System.Drawing.Point(371, 21);
            this.lb_Keyword.Name = "lb_Keyword";
            this.lb_Keyword.Size = new System.Drawing.Size(113, 15);
            this.lb_Keyword.TabIndex = 24;
            this.lb_Keyword.Text = "Từ Khóa Tìm Kiếm";
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AddCustomer.FlatAppearance.BorderSize = 0;
            this.btn_AddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_AddCustomer.Location = new System.Drawing.Point(866, 38);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(89, 30);
            this.btn_AddCustomer.TabIndex = 25;
            this.btn_AddCustomer.Text = "Thêm";
            this.btn_AddCustomer.UseVisualStyleBackColor = false;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomersName,
            this.Phone,
            this.Email,
            this.Note});
            this.dataGridView1.Location = new System.Drawing.Point(16, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã KH";
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomersName
            // 
            this.CustomersName.HeaderText = "Họ Tên";
            this.CustomersName.Name = "CustomersName";
            this.CustomersName.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "SĐT";
            this.Phone.Name = "Phone";
            this.Phone.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            this.Note.Width = 200;
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(976, 514);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Label lb_Keyword;
        private System.Windows.Forms.Button btn_CustomerSearch;
        private System.Windows.Forms.Label lb_CustomerType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}

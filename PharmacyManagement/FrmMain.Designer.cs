namespace PharmacyManagement
{
    partial class FrmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Customers = new System.Windows.Forms.Button();
            this.Btn_Storage = new System.Windows.Forms.Button();
            this.Btn_Sale = new System.Windows.Forms.Button();
            this.Btn_Employee = new System.Windows.Forms.Button();
            this.Btn_Overview = new System.Windows.Forms.Button();
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.uC_Customers1 = new PharmacyManagement.UC_Customers();
            this.uC_Storage1 = new PharmacyManagement.UC_Storage();
            this.uC_Sale1 = new PharmacyManagement.UC_Sale();
            this.uC_employee1 = new PharmacyManagement.UC_Employee();
            this.uC_overview1 = new PharmacyManagement.UC_Overview();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.Pnl_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.Btn_Customers);
            this.panel2.Controls.Add(this.Btn_Storage);
            this.panel2.Controls.Add(this.Btn_Sale);
            this.panel2.Controls.Add(this.Btn_Employee);
            this.panel2.Controls.Add(this.Btn_Overview);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 566);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Customers
            // 
            this.Btn_Customers.BackColor = System.Drawing.Color.Black;
            this.Btn_Customers.FlatAppearance.BorderSize = 0;
            this.Btn_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Customers.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Customers.Location = new System.Drawing.Point(0, 317);
            this.Btn_Customers.Name = "Btn_Customers";
            this.Btn_Customers.Size = new System.Drawing.Size(180, 67);
            this.Btn_Customers.TabIndex = 4;
            this.Btn_Customers.Text = "Khách Hàng";
            this.Btn_Customers.UseVisualStyleBackColor = false;
            this.Btn_Customers.Click += new System.EventHandler(this.Btn_Customers_Click);
            // 
            // Btn_Storage
            // 
            this.Btn_Storage.BackColor = System.Drawing.Color.Black;
            this.Btn_Storage.FlatAppearance.BorderSize = 0;
            this.Btn_Storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Storage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Storage.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Storage.Location = new System.Drawing.Point(0, 244);
            this.Btn_Storage.Name = "Btn_Storage";
            this.Btn_Storage.Size = new System.Drawing.Size(180, 67);
            this.Btn_Storage.TabIndex = 3;
            this.Btn_Storage.Text = "Quản lý kho";
            this.Btn_Storage.UseVisualStyleBackColor = false;
            this.Btn_Storage.Click += new System.EventHandler(this.Btn_Storage_Click);
            // 
            // Btn_Sale
            // 
            this.Btn_Sale.BackColor = System.Drawing.Color.Black;
            this.Btn_Sale.FlatAppearance.BorderSize = 0;
            this.Btn_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sale.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sale.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Sale.Location = new System.Drawing.Point(0, 171);
            this.Btn_Sale.Name = "Btn_Sale";
            this.Btn_Sale.Size = new System.Drawing.Size(180, 67);
            this.Btn_Sale.TabIndex = 2;
            this.Btn_Sale.Text = "Bán Hàng";
            this.Btn_Sale.UseVisualStyleBackColor = false;
            this.Btn_Sale.Click += new System.EventHandler(this.Btn_Sale_Click);
            // 
            // Btn_Employee
            // 
            this.Btn_Employee.BackColor = System.Drawing.Color.Black;
            this.Btn_Employee.FlatAppearance.BorderSize = 0;
            this.Btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Employee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Employee.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Employee.Location = new System.Drawing.Point(0, 98);
            this.Btn_Employee.Name = "Btn_Employee";
            this.Btn_Employee.Size = new System.Drawing.Size(180, 67);
            this.Btn_Employee.TabIndex = 1;
            this.Btn_Employee.Text = "Nhân Sự";
            this.Btn_Employee.UseVisualStyleBackColor = false;
            this.Btn_Employee.Click += new System.EventHandler(this.Btn_Employee_Click);
            // 
            // Btn_Overview
            // 
            this.Btn_Overview.BackColor = System.Drawing.Color.Black;
            this.Btn_Overview.FlatAppearance.BorderSize = 0;
            this.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Overview.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Overview.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Overview.Location = new System.Drawing.Point(0, 25);
            this.Btn_Overview.Name = "Btn_Overview";
            this.Btn_Overview.Size = new System.Drawing.Size(180, 67);
            this.Btn_Overview.TabIndex = 0;
            this.Btn_Overview.Text = "Tổng Quan";
            this.Btn_Overview.UseVisualStyleBackColor = false;
            this.Btn_Overview.Click += new System.EventHandler(this.Btn_Overview_Click);
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.Controls.Add(this.uC_Customers1);
            this.Pnl_Main.Controls.Add(this.uC_Storage1);
            this.Pnl_Main.Controls.Add(this.uC_Sale1);
            this.Pnl_Main.Controls.Add(this.uC_employee1);
            this.Pnl_Main.Controls.Add(this.uC_overview1);
            this.Pnl_Main.Location = new System.Drawing.Point(178, 72);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(839, 566);
            this.Pnl_Main.TabIndex = 2;
            // 
            // uC_Customers1
            // 
            this.uC_Customers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customers1.Location = new System.Drawing.Point(0, 0);
            this.uC_Customers1.Name = "uC_Customers1";
            this.uC_Customers1.Size = new System.Drawing.Size(839, 566);
            this.uC_Customers1.TabIndex = 4;
            // 
            // uC_Storage1
            // 
            this.uC_Storage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Storage1.Location = new System.Drawing.Point(0, 0);
            this.uC_Storage1.Name = "uC_Storage1";
            this.uC_Storage1.Size = new System.Drawing.Size(839, 566);
            this.uC_Storage1.TabIndex = 3;
            // 
            // uC_Sale1
            // 
            this.uC_Sale1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sale1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sale1.Name = "uC_Sale1";
            this.uC_Sale1.Size = new System.Drawing.Size(839, 566);
            this.uC_Sale1.TabIndex = 2;
            // 
            // uC_employee1
            // 
            this.uC_employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_employee1.Name = "uC_employee1";
            this.uC_employee1.Size = new System.Drawing.Size(839, 566);
            this.uC_employee1.TabIndex = 1;
            // 
            // uC_overview1
            // 
            this.uC_overview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_overview1.Location = new System.Drawing.Point(0, 0);
            this.uC_overview1.Name = "uC_overview1";
            this.uC_overview1.Size = new System.Drawing.Size(839, 566);
            this.uC_overview1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1017, 638);
            this.Controls.Add(this.Pnl_Main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.Pnl_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.Button Btn_Overview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Customers;
        private System.Windows.Forms.Button Btn_Storage;
        private System.Windows.Forms.Button Btn_Sale;
        private System.Windows.Forms.Button Btn_Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UC_Customers uC_Customers1;
        private UC_Storage uC_Storage1;
        private UC_Sale uC_Sale1;
        private PharmacyManagement.UC_Employee uC_employee1;
        private PharmacyManagement.UC_Overview uC_overview1;
    }
}


using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Pnl_Sidemenu = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Index = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Btn_Customers = new System.Windows.Forms.Button();
            this.Btn_Storage = new System.Windows.Forms.Button();
            this.Btn_Sale = new System.Windows.Forms.Button();
            this.Btn_Overview = new System.Windows.Forms.Button();
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_UControls = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uC_Settings1 = new PharmacyManagement.UC_Settings();
            this.uC_Index1 = new PharmacyManagement.UC_Index();
            this.uC_Customers1 = new PharmacyManagement.UC_Customers();
            this.uC_Storage1 = new PharmacyManagement.UC_Storage();
            this.uC_Sale1 = new PharmacyManagement.UC_Sale();
            this.uC_overview1 = new PharmacyManagement.UC_Overview();
            this.Pnl_Sidemenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Pnl_Main.SuspendLayout();
            this.pnl_UControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Sidemenu
            // 
            this.Pnl_Sidemenu.BackColor = System.Drawing.Color.SteelBlue;
            this.Pnl_Sidemenu.Controls.Add(this.btn_Setting);
            this.Pnl_Sidemenu.Controls.Add(this.btn_Index);
            this.Pnl_Sidemenu.Controls.Add(this.panel3);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Customers);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Storage);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Sale);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Overview);
            this.Pnl_Sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Sidemenu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Sidemenu.Name = "Pnl_Sidemenu";
            this.Pnl_Sidemenu.Size = new System.Drawing.Size(172, 589);
            this.Pnl_Sidemenu.TabIndex = 1;
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Futura", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Setting.ForeColor = System.Drawing.Color.Snow;
            this.btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Setting.Image")));
            this.btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Location = new System.Drawing.Point(0, 450);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(175, 65);
            this.btn_Setting.TabIndex = 6;
            this.btn_Setting.Text = "Cài Đặt";
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Index
            // 
            this.btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Index.FlatAppearance.BorderSize = 0;
            this.btn_Index.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Index.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Index.Font = new System.Drawing.Font("Futura", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Index.ForeColor = System.Drawing.Color.Snow;
            this.btn_Index.Image = ((System.Drawing.Image)(resources.GetObject("btn_Index.Image")));
            this.btn_Index.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Index.Location = new System.Drawing.Point(0, 300);
            this.btn_Index.Name = "btn_Index";
            this.btn_Index.Size = new System.Drawing.Size(175, 65);
            this.btn_Index.TabIndex = 5;
            this.btn_Index.Text = "Danh Mục";
            this.btn_Index.UseVisualStyleBackColor = false;
            this.btn_Index.Click += new System.EventHandler(this.btn_Index_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.Lb_Name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 74);
            this.panel3.TabIndex = 1;
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.BackColor = System.Drawing.Color.Orange;
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lb_Name.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.Location = new System.Drawing.Point(0, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(191, 82);
            this.Lb_Name.TabIndex = 0;
            this.Lb_Name.Text = "G7 Ph";
            // 
            // Btn_Customers
            // 
            this.Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Customers.FlatAppearance.BorderSize = 0;
            this.Btn_Customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customers.Font = new System.Drawing.Font("Futura", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Customers.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Customers.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Customers.Image")));
            this.Btn_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customers.Location = new System.Drawing.Point(0, 375);
            this.Btn_Customers.Name = "Btn_Customers";
            this.Btn_Customers.Size = new System.Drawing.Size(175, 65);
            this.Btn_Customers.TabIndex = 4;
            this.Btn_Customers.Text = "     Khách Hàng";
            this.Btn_Customers.UseVisualStyleBackColor = false;
            this.Btn_Customers.Click += new System.EventHandler(this.Btn_Customers_Click);
            // 
            // Btn_Storage
            // 
            this.Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Storage.FlatAppearance.BorderSize = 0;
            this.Btn_Storage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Storage.Font = new System.Drawing.Font("Futura", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Storage.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Storage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Storage.Image")));
            this.Btn_Storage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Storage.Location = new System.Drawing.Point(0, 225);
            this.Btn_Storage.Name = "Btn_Storage";
            this.Btn_Storage.Size = new System.Drawing.Size(175, 65);
            this.Btn_Storage.TabIndex = 3;
            this.Btn_Storage.Text = "     Quản lý kho";
            this.Btn_Storage.UseVisualStyleBackColor = false;
            this.Btn_Storage.Click += new System.EventHandler(this.Btn_Storage_Click);
            // 
            // Btn_Sale
            // 
            this.Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Sale.FlatAppearance.BorderSize = 0;
            this.Btn_Sale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sale.Font = new System.Drawing.Font("Futura", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Sale.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Sale.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sale.Image")));
            this.Btn_Sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sale.Location = new System.Drawing.Point(0, 150);
            this.Btn_Sale.Name = "Btn_Sale";
            this.Btn_Sale.Size = new System.Drawing.Size(175, 65);
            this.Btn_Sale.TabIndex = 2;
            this.Btn_Sale.Text = "     Bán Hàng";
            this.Btn_Sale.UseVisualStyleBackColor = false;
            this.Btn_Sale.Click += new System.EventHandler(this.Btn_Sale_Click);
            // 
            // Btn_Overview
            // 
            this.Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Overview.FlatAppearance.BorderSize = 0;
            this.Btn_Overview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Overview.Font = new System.Drawing.Font("Futura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Overview.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Overview.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Overview.Image")));
            this.Btn_Overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Overview.Location = new System.Drawing.Point(0, 75);
            this.Btn_Overview.Name = "Btn_Overview";
            this.Btn_Overview.Size = new System.Drawing.Size(175, 65);
            this.Btn_Overview.TabIndex = 0;
            this.Btn_Overview.Text = "     Tổng Quan";
            this.Btn_Overview.UseVisualStyleBackColor = false;
            this.Btn_Overview.Click += new System.EventHandler(this.Btn_Overview_Click);
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.AutoScroll = true;
            this.Pnl_Main.AutoSize = true;
            this.Pnl_Main.BackColor = System.Drawing.Color.White;
            this.Pnl_Main.Controls.Add(this.pnl_UControls);
            this.Pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Main.Location = new System.Drawing.Point(172, 0);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(976, 589);
            this.Pnl_Main.TabIndex = 2;
            // 
            // pnl_UControls
            // 
            this.pnl_UControls.Controls.Add(this.uC_Settings1);
            this.pnl_UControls.Controls.Add(this.uC_Index1);
            this.pnl_UControls.Controls.Add(this.uC_Customers1);
            this.pnl_UControls.Controls.Add(this.uC_Storage1);
            this.pnl_UControls.Controls.Add(this.uC_Sale1);
            this.pnl_UControls.Controls.Add(this.uC_overview1);
            this.pnl_UControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_UControls.Location = new System.Drawing.Point(0, 0);
            this.pnl_UControls.Name = "pnl_UControls";
            this.pnl_UControls.Size = new System.Drawing.Size(976, 589);
            this.pnl_UControls.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uC_Settings1
            // 
            this.uC_Settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Settings1.Location = new System.Drawing.Point(0, 0);
            this.uC_Settings1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Settings1.Name = "uC_Settings1";
            this.uC_Settings1.Size = new System.Drawing.Size(976, 589);
            this.uC_Settings1.TabIndex = 6;
            // 
            // uC_Index1
            // 
            this.uC_Index1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Index1.Location = new System.Drawing.Point(0, 0);
            this.uC_Index1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Index1.Name = "uC_Index1";
            this.uC_Index1.Size = new System.Drawing.Size(976, 589);
            this.uC_Index1.TabIndex = 5;
            // 
            // uC_Customers1
            // 
            this.uC_Customers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uC_Customers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customers1.Location = new System.Drawing.Point(0, 0);
            this.uC_Customers1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Customers1.Name = "uC_Customers1";
            this.uC_Customers1.Size = new System.Drawing.Size(976, 589);
            this.uC_Customers1.TabIndex = 4;
            this.uC_Customers1.Visible = false;
            this.uC_Customers1.Load += new System.EventHandler(this.uC_Customers1_Load);
            // 
            // uC_Storage1
            // 
            this.uC_Storage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Storage1.Location = new System.Drawing.Point(0, 0);
            this.uC_Storage1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Storage1.Name = "uC_Storage1";
            this.uC_Storage1.Size = new System.Drawing.Size(976, 589);
            this.uC_Storage1.TabIndex = 3;
            // 
            // uC_Sale1
            // 
            this.uC_Sale1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sale1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sale1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Sale1.Name = "uC_Sale1";
            this.uC_Sale1.Size = new System.Drawing.Size(976, 589);
            this.uC_Sale1.TabIndex = 2;
            // 
            // uC_overview1
            // 
            this.uC_overview1.AutoScroll = true;
            this.uC_overview1.AutoSize = true;
            this.uC_overview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uC_overview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_overview1.Location = new System.Drawing.Point(0, 0);
            this.uC_overview1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_overview1.Name = "uC_overview1";
            this.uC_overview1.Size = new System.Drawing.Size(976, 589);
            this.uC_overview1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1148, 589);
            this.Controls.Add(this.Pnl_Main);
            this.Controls.Add(this.Pnl_Sidemenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Pnl_Sidemenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Pnl_Main.ResumeLayout(false);
            this.pnl_UControls.ResumeLayout(false);
            this.pnl_UControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Sidemenu;
        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.Button Btn_Overview;
        private System.Windows.Forms.Button Btn_Customers;
        private System.Windows.Forms.Button Btn_Storage;
        private System.Windows.Forms.Button Btn_Sale;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UC_Customers uC_Customers1;
        private UC_Storage uC_Storage1;
        private UC_Sale uC_Sale1;
        //private PharmacyManagement.UC_Employee uC_employee1;
        private PharmacyManagement.UC_Overview uC_overview1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_UControls;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Index;
        private UC_Settings uC_Settings1;
        private UC_Index uC_Index1;
    }
}


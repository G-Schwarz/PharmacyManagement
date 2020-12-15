namespace PharmacyManagement
{
    partial class UC_Sale
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
            this.btn_BanHang = new System.Windows.Forms.Button();
            this.pnl_SaleMain = new System.Windows.Forms.Panel();
            this.pnl_SaleUC = new System.Windows.Forms.Panel();
            this.uC_Sale_Main1 = new PharmacyManagement.UC_Sale_Main();
            this.uC_Sale_Receipt1 = new PharmacyManagement.UC_Sale_Receipt();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.pnl_SaleMain.SuspendLayout();
            this.pnl_SaleUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_BanHang.FlatAppearance.BorderSize = 0;
            this.btn_BanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_BanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanHang.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanHang.ForeColor = System.Drawing.Color.White;
            this.btn_BanHang.Location = new System.Drawing.Point(21, 3);
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.Size = new System.Drawing.Size(130, 42);
            this.btn_BanHang.TabIndex = 0;
            this.btn_BanHang.Text = "Bán Hàng";
            this.btn_BanHang.UseVisualStyleBackColor = false;
            this.btn_BanHang.Click += new System.EventHandler(this.btn_BanHang_Click);
            // 
            // pnl_SaleMain
            // 
            this.pnl_SaleMain.Controls.Add(this.pnl_SaleUC);
            this.pnl_SaleMain.Controls.Add(this.btn_BanHang);
            this.pnl_SaleMain.Controls.Add(this.btn_HoaDon);
            this.pnl_SaleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SaleMain.Location = new System.Drawing.Point(0, 0);
            this.pnl_SaleMain.Name = "pnl_SaleMain";
            this.pnl_SaleMain.Size = new System.Drawing.Size(976, 514);
            this.pnl_SaleMain.TabIndex = 1;
            // 
            // pnl_SaleUC
            // 
            this.pnl_SaleUC.Controls.Add(this.uC_Sale_Main1);
            this.pnl_SaleUC.Controls.Add(this.uC_Sale_Receipt1);
            this.pnl_SaleUC.Location = new System.Drawing.Point(3, 51);
            this.pnl_SaleUC.Name = "pnl_SaleUC";
            this.pnl_SaleUC.Size = new System.Drawing.Size(973, 463);
            this.pnl_SaleUC.TabIndex = 3;
            // 
            // uC_Sale_Main1
            // 
            this.uC_Sale_Main1.AutoScroll = true;
            this.uC_Sale_Main1.BackColor = System.Drawing.Color.White;
            this.uC_Sale_Main1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sale_Main1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sale_Main1.Name = "uC_Sale_Main1";
            this.uC_Sale_Main1.Size = new System.Drawing.Size(973, 463);
            this.uC_Sale_Main1.TabIndex = 0;
            // 
            // uC_Sale_Receipt1
            // 
            this.uC_Sale_Receipt1.BackColor = System.Drawing.Color.White;
            this.uC_Sale_Receipt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sale_Receipt1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sale_Receipt1.Name = "uC_Sale_Receipt1";
            this.uC_Sale_Receipt1.Size = new System.Drawing.Size(973, 463);
            this.uC_Sale_Receipt1.TabIndex = 2;
            this.uC_Sale_Receipt1.Visible = false;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.Location = new System.Drawing.Point(174, 3);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(130, 42);
            this.btn_HoaDon.TabIndex = 1;
            this.btn_HoaDon.Text = "Hóa Đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // UC_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_SaleMain);
            this.Name = "UC_Sale";
            this.Size = new System.Drawing.Size(976, 514);
            this.pnl_SaleMain.ResumeLayout(false);
            this.pnl_SaleUC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BanHang;
        private System.Windows.Forms.Panel pnl_SaleMain;
        private System.Windows.Forms.Button btn_HoaDon;
        private UC_Sale_Main uC_Sale_Main1;
        private UC_Sale_Receipt uC_Sale_Receipt1;
        private System.Windows.Forms.Panel pnl_SaleUC;
    }
}

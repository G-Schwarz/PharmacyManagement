namespace PharmacyManagement
{
    partial class FrmReceiptDetails
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
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RecptDetails = new System.Windows.Forms.DataGridView();
            this.tb_CustomerType = new System.Windows.Forms.TextBox();
            this.txb_Seller = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cb_PaymentMethod = new System.Windows.Forms.ComboBox();
            this.ckb_BanDon = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txb_RecptCode = new System.Windows.Forms.TextBox();
            this.lb_PaymentMethod = new System.Windows.Forms.Label();
            this.lb_CustomerType = new System.Windows.Forms.Label();
            this.lb_Note = new System.Windows.Forms.Label();
            this.lb_Seller = new System.Windows.Forms.Label();
            this.lb_SaleDate = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_RecptCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_SellDate = new System.Windows.Forms.DateTimePicker();
            this.pnl_RecpDetailsBanner = new System.Windows.Forms.Panel();
            this.btn_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecptDetails)).BeginInit();
            this.pnl_RecpDetailsBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(567, 88);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(200, 21);
            this.cb_Status.TabIndex = 49;
            // 
            // Total
            // 
            this.Total.HeaderText = "Thành Tiền";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Giảm Giá";
            this.Discount.Name = "Discount";
            // 
            // Tax
            // 
            this.Tax.HeaderText = "VAT";
            this.Tax.Name = "Tax";
            // 
            // Price
            // 
            this.Price.HeaderText = "Đơn Giá";
            this.Price.Name = "Price";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.Name = "Amount";
            // 
            // BlockNo
            // 
            this.BlockNo.HeaderText = "Số Lô";
            this.BlockNo.Name = "BlockNo";
            // 
            // ProductsName
            // 
            this.ProductsName.HeaderText = "Tên Hàng Hóa";
            this.ProductsName.Name = "ProductsName";
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Mã Hàng Hóa";
            this.ProductID.Name = "ProductID";
            // 
            // dgv_RecptDetails
            // 
            this.dgv_RecptDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_RecptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RecptDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductsName,
            this.BlockNo,
            this.Amount,
            this.Price,
            this.Tax,
            this.Discount,
            this.Total});
            this.dgv_RecptDetails.Location = new System.Drawing.Point(20, 237);
            this.dgv_RecptDetails.Name = "dgv_RecptDetails";
            this.dgv_RecptDetails.Size = new System.Drawing.Size(770, 297);
            this.dgv_RecptDetails.TabIndex = 47;
            // 
            // tb_CustomerType
            // 
            this.tb_CustomerType.Location = new System.Drawing.Point(37, 146);
            this.tb_CustomerType.Name = "tb_CustomerType";
            this.tb_CustomerType.Size = new System.Drawing.Size(200, 20);
            this.tb_CustomerType.TabIndex = 46;
            // 
            // txb_Seller
            // 
            this.txb_Seller.Location = new System.Drawing.Point(567, 146);
            this.txb_Seller.Name = "txb_Seller";
            this.txb_Seller.Size = new System.Drawing.Size(200, 20);
            this.txb_Seller.TabIndex = 45;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(527, 20);
            this.textBox2.TabIndex = 44;
            // 
            // cb_PaymentMethod
            // 
            this.cb_PaymentMethod.FormattingEnabled = true;
            this.cb_PaymentMethod.Location = new System.Drawing.Point(303, 145);
            this.cb_PaymentMethod.Name = "cb_PaymentMethod";
            this.cb_PaymentMethod.Size = new System.Drawing.Size(200, 21);
            this.cb_PaymentMethod.TabIndex = 43;
            // 
            // ckb_BanDon
            // 
            this.ckb_BanDon.AutoSize = true;
            this.ckb_BanDon.Location = new System.Drawing.Point(606, 201);
            this.ckb_BanDon.Name = "ckb_BanDon";
            this.ckb_BanDon.Size = new System.Drawing.Size(68, 17);
            this.ckb_BanDon.TabIndex = 41;
            this.ckb_BanDon.Text = "Bán Đơn";
            this.ckb_BanDon.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txb_RecptCode
            // 
            this.txb_RecptCode.Location = new System.Drawing.Point(37, 88);
            this.txb_RecptCode.Name = "txb_RecptCode";
            this.txb_RecptCode.Size = new System.Drawing.Size(200, 20);
            this.txb_RecptCode.TabIndex = 40;
            // 
            // lb_PaymentMethod
            // 
            this.lb_PaymentMethod.AutoSize = true;
            this.lb_PaymentMethod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PaymentMethod.Location = new System.Drawing.Point(300, 127);
            this.lb_PaymentMethod.Name = "lb_PaymentMethod";
            this.lb_PaymentMethod.Size = new System.Drawing.Size(174, 16);
            this.lb_PaymentMethod.TabIndex = 39;
            this.lb_PaymentMethod.Text = "Phương Thức Thanh Toán";
            // 
            // lb_CustomerType
            // 
            this.lb_CustomerType.AutoSize = true;
            this.lb_CustomerType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerType.Location = new System.Drawing.Point(34, 127);
            this.lb_CustomerType.Name = "lb_CustomerType";
            this.lb_CustomerType.Size = new System.Drawing.Size(85, 16);
            this.lb_CustomerType.TabIndex = 38;
            this.lb_CustomerType.Text = "Khách Hàng";
            // 
            // lb_Note
            // 
            this.lb_Note.AutoSize = true;
            this.lb_Note.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Note.Location = new System.Drawing.Point(34, 183);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Size = new System.Drawing.Size(51, 16);
            this.lb_Note.TabIndex = 37;
            this.lb_Note.Text = "Ghi Chú";
            // 
            // lb_Seller
            // 
            this.lb_Seller.AutoSize = true;
            this.lb_Seller.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Seller.Location = new System.Drawing.Point(564, 127);
            this.lb_Seller.Name = "lb_Seller";
            this.lb_Seller.Size = new System.Drawing.Size(76, 16);
            this.lb_Seller.TabIndex = 36;
            this.lb_Seller.Text = "Người Bán";
            // 
            // lb_SaleDate
            // 
            this.lb_SaleDate.AutoSize = true;
            this.lb_SaleDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SaleDate.Location = new System.Drawing.Point(300, 70);
            this.lb_SaleDate.Name = "lb_SaleDate";
            this.lb_SaleDate.Size = new System.Drawing.Size(69, 16);
            this.lb_SaleDate.TabIndex = 35;
            this.lb_SaleDate.Text = "Ngày Bán";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.Location = new System.Drawing.Point(564, 70);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(76, 16);
            this.lb_Status.TabIndex = 34;
            this.lb_Status.Text = "Trạng Thái";
            // 
            // lb_RecptCode
            // 
            this.lb_RecptCode.AutoSize = true;
            this.lb_RecptCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RecptCode.Location = new System.Drawing.Point(34, 70);
            this.lb_RecptCode.Name = "lb_RecptCode";
            this.lb_RecptCode.Size = new System.Drawing.Size(86, 16);
            this.lb_RecptCode.TabIndex = 33;
            this.lb_RecptCode.Text = "Mã Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // dtp_SellDate
            // 
            this.dtp_SellDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SellDate.Location = new System.Drawing.Point(303, 88);
            this.dtp_SellDate.Name = "dtp_SellDate";
            this.dtp_SellDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_SellDate.TabIndex = 42;
            // 
            // pnl_RecpDetailsBanner
            // 
            this.pnl_RecpDetailsBanner.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_RecpDetailsBanner.Controls.Add(this.label1);
            this.pnl_RecpDetailsBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_RecpDetailsBanner.Location = new System.Drawing.Point(0, 0);
            this.pnl_RecpDetailsBanner.Name = "pnl_RecpDetailsBanner";
            this.pnl_RecpDetailsBanner.Size = new System.Drawing.Size(808, 53);
            this.pnl_RecpDetailsBanner.TabIndex = 32;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Return.FlatAppearance.BorderSize = 0;
            this.btn_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Return.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.Color.White;
            this.btn_Return.Location = new System.Drawing.Point(20, 540);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(157, 42);
            this.btn_Return.TabIndex = 48;
            this.btn_Return.Text = "Trở lại";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // FrmReceiptDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(808, 598);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.dgv_RecptDetails);
            this.Controls.Add(this.tb_CustomerType);
            this.Controls.Add(this.txb_Seller);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cb_PaymentMethod);
            this.Controls.Add(this.ckb_BanDon);
            this.Controls.Add(this.txb_RecptCode);
            this.Controls.Add(this.lb_PaymentMethod);
            this.Controls.Add(this.lb_CustomerType);
            this.Controls.Add(this.lb_Note);
            this.Controls.Add(this.lb_Seller);
            this.Controls.Add(this.lb_SaleDate);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_RecptCode);
            this.Controls.Add(this.dtp_SellDate);
            this.Controls.Add(this.pnl_RecpDetailsBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReceiptDetails";
            this.Text = "FrmReceiptDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecptDetails)).EndInit();
            this.pnl_RecpDetailsBanner.ResumeLayout(false);
            this.pnl_RecpDetailsBanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridView dgv_RecptDetails;
        private System.Windows.Forms.TextBox tb_CustomerType;
        private System.Windows.Forms.TextBox txb_Seller;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cb_PaymentMethod;
        private System.Windows.Forms.CheckBox ckb_BanDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txb_RecptCode;
        private System.Windows.Forms.Label lb_PaymentMethod;
        private System.Windows.Forms.Label lb_CustomerType;
        private System.Windows.Forms.Label lb_Note;
        private System.Windows.Forms.Label lb_Seller;
        private System.Windows.Forms.Label lb_SaleDate;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_RecptCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_SellDate;
        private System.Windows.Forms.Panel pnl_RecpDetailsBanner;
        private System.Windows.Forms.Button btn_Return;
    }
}
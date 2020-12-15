namespace PharmacyManagement
{
    partial class UC_Sale_Main
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
            this.components = new System.ComponentModel.Container();
            this.txb_SearchProduct = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_ThongTinHoaDon = new System.Windows.Forms.Panel();
            this.pnl_ThanhToan = new System.Windows.Forms.Panel();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txb_SearchCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Sum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Discount = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.lb_Changes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_ThongTinHoaDon.SuspendLayout();
            this.pnl_ThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_SearchProduct
            // 
            this.txb_SearchProduct.Location = new System.Drawing.Point(14, 3);
            this.txb_SearchProduct.Name = "txb_SearchProduct";
            this.txb_SearchProduct.Size = new System.Drawing.Size(505, 20);
            this.txb_SearchProduct.TabIndex = 0;
            this.txb_SearchProduct.Text = "Tìm kiếm hàng hóa theo tên hoặc mã vạch";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductsName,
            this.Currency,
            this.Amount,
            this.Price,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(14, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 400);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnl_ThongTinHoaDon
            // 
            this.pnl_ThongTinHoaDon.Controls.Add(this.button3);
            this.pnl_ThongTinHoaDon.Controls.Add(this.txb_SearchProduct);
            this.pnl_ThongTinHoaDon.Controls.Add(this.dataGridView1);
            this.pnl_ThongTinHoaDon.Location = new System.Drawing.Point(3, 3);
            this.pnl_ThongTinHoaDon.Name = "pnl_ThongTinHoaDon";
            this.pnl_ThongTinHoaDon.Size = new System.Drawing.Size(660, 454);
            this.pnl_ThongTinHoaDon.TabIndex = 2;
            // 
            // pnl_ThanhToan
            // 
            this.pnl_ThanhToan.Controls.Add(this.button4);
            this.pnl_ThanhToan.Controls.Add(this.button2);
            this.pnl_ThanhToan.Controls.Add(this.button1);
            this.pnl_ThanhToan.Controls.Add(this.richTextBox1);
            this.pnl_ThanhToan.Controls.Add(this.label6);
            this.pnl_ThanhToan.Controls.Add(this.lb_Changes);
            this.pnl_ThanhToan.Controls.Add(this.lb_Total);
            this.pnl_ThanhToan.Controls.Add(this.lb_Discount);
            this.pnl_ThanhToan.Controls.Add(this.textBox1);
            this.pnl_ThanhToan.Controls.Add(this.lb_Sum);
            this.pnl_ThanhToan.Controls.Add(this.label5);
            this.pnl_ThanhToan.Controls.Add(this.label4);
            this.pnl_ThanhToan.Controls.Add(this.label3);
            this.pnl_ThanhToan.Controls.Add(this.label2);
            this.pnl_ThanhToan.Controls.Add(this.label1);
            this.pnl_ThanhToan.Controls.Add(this.txb_SearchCustomer);
            this.pnl_ThanhToan.Controls.Add(this.dateTimePicker1);
            this.pnl_ThanhToan.Controls.Add(this.cb_NhanVien);
            this.pnl_ThanhToan.Location = new System.Drawing.Point(669, 3);
            this.pnl_ThanhToan.Name = "pnl_ThanhToan";
            this.pnl_ThanhToan.Size = new System.Drawing.Size(304, 454);
            this.pnl_ThanhToan.TabIndex = 3;
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(3, 3);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(156, 21);
            this.cb_NhanVien.TabIndex = 0;
            this.cb_NhanVien.Text = "Tên Nhân Viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txb_SearchCustomer
            // 
            this.txb_SearchCustomer.Location = new System.Drawing.Point(3, 75);
            this.txb_SearchCustomer.Name = "txb_SearchCustomer";
            this.txb_SearchCustomer.Size = new System.Drawing.Size(237, 20);
            this.txb_SearchCustomer.TabIndex = 2;
            this.txb_SearchCustomer.Text = " Nhập Tên hoặc SĐT Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách cần trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khách thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền trả khách";
            // 
            // lb_Sum
            // 
            this.lb_Sum.AutoSize = true;
            this.lb_Sum.Location = new System.Drawing.Point(233, 128);
            this.lb_Sum.Name = "lb_Sum";
            this.lb_Sum.Size = new System.Drawing.Size(42, 13);
            this.lb_Sum.TabIndex = 8;
            this.lb_Sum.Text = "amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lb_Discount
            // 
            this.lb_Discount.AutoSize = true;
            this.lb_Discount.Location = new System.Drawing.Point(233, 160);
            this.lb_Discount.Name = "lb_Discount";
            this.lb_Discount.Size = new System.Drawing.Size(42, 13);
            this.lb_Discount.TabIndex = 13;
            this.lb_Discount.Text = "amount";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(233, 194);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(42, 13);
            this.lb_Total.TabIndex = 14;
            this.lb_Total.Text = "amount";
            // 
            // lb_Changes
            // 
            this.lb_Changes.AutoSize = true;
            this.lb_Changes.Location = new System.Drawing.Point(233, 269);
            this.lb_Changes.Name = "lb_Changes";
            this.lb_Changes.Size = new System.Drawing.Size(42, 13);
            this.lb_Changes.TabIndex = 15;
            this.lb_Changes.Text = "amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ghi Chú:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 56);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "Thanh Toán và In Hóa Đơn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 20);
            this.button3.TabIndex = 19;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 20);
            this.button4.TabIndex = 20;
            this.button4.Text = "Tìm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ProductsName
            // 
            this.ProductsName.HeaderText = "Tên Hàng";
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.ReadOnly = true;
            this.ProductsName.Width = 150;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "ĐVT";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            this.Currency.Width = 110;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 110;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá Bán";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 110;
            // 
            // Total
            // 
            this.Total.HeaderText = "Thành Tiền";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 110;
            // 
            // UC_Sale_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pnl_ThanhToan);
            this.Controls.Add(this.pnl_ThongTinHoaDon);
            this.Name = "UC_Sale_Main";
            this.Size = new System.Drawing.Size(976, 460);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_ThongTinHoaDon.ResumeLayout(false);
            this.pnl_ThongTinHoaDon.PerformLayout();
            this.pnl_ThanhToan.ResumeLayout(false);
            this.pnl_ThanhToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_SearchProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_ThongTinHoaDon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnl_ThanhToan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Changes;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lb_Discount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_SearchCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txb_SearchProduct = new System.Windows.Forms.TextBox();
            this.Dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.ProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_ThongTinHoaDon = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_ThanhToan = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Changes = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.lb_Discount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Sum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_SearchCustomer = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProductList)).BeginInit();
            this.pnl_ThongTinHoaDon.SuspendLayout();
            this.pnl_ThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_SearchProduct
            // 
            this.txb_SearchProduct.Location = new System.Drawing.Point(19, 4);
            this.txb_SearchProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_SearchProduct.Name = "txb_SearchProduct";
            this.txb_SearchProduct.Size = new System.Drawing.Size(672, 22);
            this.txb_SearchProduct.TabIndex = 0;
            this.txb_SearchProduct.Text = "Tìm kiếm hàng hóa theo tên hoặc mã vạch";
            // 
            // Dgv_ProductList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dgv_ProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_ProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_ProductList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_ProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductsName,
            this.Currency,
            this.Amount,
            this.Price,
            this.Total});
            this.Dgv_ProductList.Location = new System.Drawing.Point(19, 36);
            this.Dgv_ProductList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_ProductList.Name = "Dgv_ProductList";
            this.Dgv_ProductList.RowHeadersWidth = 51;
            this.Dgv_ProductList.Size = new System.Drawing.Size(845, 492);
            this.Dgv_ProductList.TabIndex = 1;
            // 
            // ProductsName
            // 
            this.ProductsName.HeaderText = "Tên Hàng";
            this.ProductsName.MinimumWidth = 6;
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.ReadOnly = true;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "ĐVT";
            this.Currency.MinimumWidth = 6;
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá Bán";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Thành Tiền";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // pnl_ThongTinHoaDon
            // 
            this.pnl_ThongTinHoaDon.BackColor = System.Drawing.Color.White;
            this.pnl_ThongTinHoaDon.Controls.Add(this.button3);
            this.pnl_ThongTinHoaDon.Controls.Add(this.txb_SearchProduct);
            this.pnl_ThongTinHoaDon.Controls.Add(this.Dgv_ProductList);
            this.pnl_ThongTinHoaDon.Location = new System.Drawing.Point(4, 4);
            this.pnl_ThongTinHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_ThongTinHoaDon.Name = "pnl_ThongTinHoaDon";
            this.pnl_ThongTinHoaDon.Size = new System.Drawing.Size(880, 559);
            this.pnl_ThongTinHoaDon.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(700, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 25);
            this.button3.TabIndex = 19;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = false;
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
            this.pnl_ThanhToan.Location = new System.Drawing.Point(892, 4);
            this.pnl_ThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_ThanhToan.Name = "pnl_ThanhToan";
            this.pnl_ThanhToan.Size = new System.Drawing.Size(405, 559);
            this.pnl_ThanhToan.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(328, 92);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 25);
            this.button4.TabIndex = 20;
            this.button4.Text = "Tìm";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(220, 473);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Thanh Toán và In Hóa Đơn";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 55);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 396);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 68);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ghi Chú:";
            // 
            // lb_Changes
            // 
            this.lb_Changes.AutoSize = true;
            this.lb_Changes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Changes.Location = new System.Drawing.Point(311, 331);
            this.lb_Changes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Changes.Name = "lb_Changes";
            this.lb_Changes.Size = new System.Drawing.Size(16, 16);
            this.lb_Changes.TabIndex = 15;
            this.lb_Changes.Text = "đ";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(311, 239);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(16, 16);
            this.lb_Total.TabIndex = 14;
            this.lb_Total.Text = "đ";
            // 
            // lb_Discount
            // 
            this.lb_Discount.AutoSize = true;
            this.lb_Discount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Discount.Location = new System.Drawing.Point(311, 197);
            this.lb_Discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Discount.Name = "lb_Discount";
            this.lb_Discount.Size = new System.Drawing.Size(16, 16);
            this.lb_Discount.TabIndex = 13;
            this.lb_Discount.Text = "đ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 278);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 12;
            // 
            // lb_Sum
            // 
            this.lb_Sum.AutoSize = true;
            this.lb_Sum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sum.Location = new System.Drawing.Point(311, 158);
            this.lb_Sum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Sum.Name = "lb_Sum";
            this.lb_Sum.Size = new System.Drawing.Size(16, 16);
            this.lb_Sum.TabIndex = 8;
            this.lb_Sum.Text = "đ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền trả khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khách thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách cần trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng giảm giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền hàng";
            // 
            // txb_SearchCustomer
            // 
            this.txb_SearchCustomer.Location = new System.Drawing.Point(4, 92);
            this.txb_SearchCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_SearchCustomer.Name = "txb_SearchCustomer";
            this.txb_SearchCustomer.Size = new System.Drawing.Size(315, 22);
            this.txb_SearchCustomer.TabIndex = 2;
            this.txb_SearchCustomer.Text = " Nhập Tên hoặc SĐT Khách hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 37);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(4, 4);
            this.cb_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(207, 24);
            this.cb_NhanVien.TabIndex = 0;
            this.cb_NhanVien.Text = "Tên Nhân Viên";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UC_Sale_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_ThanhToan);
            this.Controls.Add(this.pnl_ThongTinHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Sale_Main";
            this.Size = new System.Drawing.Size(1301, 566);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProductList)).EndInit();
            this.pnl_ThongTinHoaDon.ResumeLayout(false);
            this.pnl_ThongTinHoaDon.PerformLayout();
            this.pnl_ThanhToan.ResumeLayout(false);
            this.pnl_ThanhToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_SearchProduct;
        private System.Windows.Forms.DataGridView Dgv_ProductList;
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

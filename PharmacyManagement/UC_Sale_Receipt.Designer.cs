namespace PharmacyManagement
{
    partial class UC_Sale_Receipt
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lb_From = new System.Windows.Forms.Label();
            this.lb_To = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ReceiptList = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReceiptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_ReceiptCodeSearch = new System.Windows.Forms.Label();
            this.lb_ProductsSearch = new System.Windows.Forms.Label();
            this.lb_Type = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReceiptList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(486, 20);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(121, 21);
            this.cb_Status.TabIndex = 1;
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(651, 19);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(121, 21);
            this.cb_Type.TabIndex = 2;
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(14, 20);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(200, 20);
            this.dtp_From.TabIndex = 3;
            // 
            // dtp_To
            // 
            this.dtp_To.Location = new System.Drawing.Point(245, 20);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(200, 20);
            this.dtp_To.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(767, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(11, 4);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(50, 15);
            this.lb_From.TabIndex = 7;
            this.lb_From.Text = "Từ ngày";
            // 
            // lb_To
            // 
            this.lb_To.AutoSize = true;
            this.lb_To.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_To.Location = new System.Drawing.Point(242, 4);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(59, 15);
            this.lb_To.TabIndex = 8;
            this.lb_To.Text = "Đến ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_ReceiptList);
            this.panel1.Location = new System.Drawing.Point(3, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 348);
            this.panel1.TabIndex = 10;
            // 
            // dgv_ReceiptList
            // 
            this.dgv_ReceiptList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReceiptList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.ReceiptCode,
            this.CustomerType,
            this.DateAndTime,
            this.Sum,
            this.PayOut,
            this.Note,
            this.Status});
            this.dgv_ReceiptList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ReceiptList.GridColor = System.Drawing.Color.White;
            this.dgv_ReceiptList.Location = new System.Drawing.Point(0, 0);
            this.dgv_ReceiptList.Name = "dgv_ReceiptList";
            this.dgv_ReceiptList.Size = new System.Drawing.Size(970, 348);
            this.dgv_ReceiptList.TabIndex = 0;
            this.dgv_ReceiptList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ReceiptList_CellContentClick);
            // 
            // Action
            // 
            this.Action.HeaderText = "Thao Tác";
            this.Action.Name = "Action";
            // 
            // ReceiptCode
            // 
            this.ReceiptCode.HeaderText = "Mã Hóa Đơn";
            this.ReceiptCode.Name = "ReceiptCode";
            this.ReceiptCode.ReadOnly = true;
            this.ReceiptCode.Width = 120;
            // 
            // CustomerType
            // 
            this.CustomerType.HeaderText = "Khách hàng";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            this.CustomerType.Width = 120;
            // 
            // DateAndTime
            // 
            this.DateAndTime.HeaderText = "Ngày Giờ Bán Hàng";
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            this.DateAndTime.Width = 150;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Tổng Tiền";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // PayOut
            // 
            this.PayOut.HeaderText = "Thanh Toán";
            this.PayOut.Name = "PayOut";
            this.PayOut.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng Thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_ReceiptCodeSearch);
            this.panel2.Controls.Add(this.lb_ProductsSearch);
            this.panel2.Controls.Add(this.lb_Type);
            this.panel2.Controls.Add(this.lb_Status);
            this.panel2.Controls.Add(this.dtp_From);
            this.panel2.Controls.Add(this.dtp_To);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.lb_To);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.cb_Status);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lb_From);
            this.panel2.Controls.Add(this.cb_Type);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 100);
            this.panel2.TabIndex = 11;
            // 
            // lb_ReceiptCodeSearch
            // 
            this.lb_ReceiptCodeSearch.AutoSize = true;
            this.lb_ReceiptCodeSearch.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ReceiptCodeSearch.Location = new System.Drawing.Point(388, 43);
            this.lb_ReceiptCodeSearch.Name = "lb_ReceiptCodeSearch";
            this.lb_ReceiptCodeSearch.Size = new System.Drawing.Size(153, 15);
            this.lb_ReceiptCodeSearch.TabIndex = 12;
            this.lb_ReceiptCodeSearch.Text = "Tìm kiếm theo mã hóa đơn";
            // 
            // lb_ProductsSearch
            // 
            this.lb_ProductsSearch.AutoSize = true;
            this.lb_ProductsSearch.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductsSearch.Location = new System.Drawing.Point(11, 43);
            this.lb_ProductsSearch.Name = "lb_ProductsSearch";
            this.lb_ProductsSearch.Size = new System.Drawing.Size(140, 15);
            this.lb_ProductsSearch.TabIndex = 11;
            this.lb_ProductsSearch.Text = "Tìm kiếm theo hàng hóa";
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Type.Location = new System.Drawing.Point(648, 4);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(58, 15);
            this.lb_Type.TabIndex = 10;
            this.lb_Type.Text = "Theo đơn";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.Location = new System.Drawing.Point(483, 4);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(65, 15);
            this.lb_Status.TabIndex = 9;
            this.lb_Status.Text = "Trạng thái";
            // 
            // UC_Sale_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Sale_Receipt";
            this.Size = new System.Drawing.Size(976, 460);
            this.Load += new System.EventHandler(this.UC_Sale_Receipt_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReceiptList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_ReceiptList;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_ReceiptCodeSearch;
        private System.Windows.Forms.Label lb_ProductsSearch;
    }
}

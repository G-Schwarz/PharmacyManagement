namespace PharmacyManagement
{
    partial class UC_Import
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
            this.button1 = new System.Windows.Forms.Button();
            this.cb_ImportStatus = new System.Windows.Forms.ComboBox();
            this.lbl_ImportStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dtp_ImportToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_ToDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ImportSearch = new System.Windows.Forms.Button();
            this.dgv_DanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(758, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 27);
            this.button1.TabIndex = 75;
            this.button1.TabStop = false;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_ImportStatus
            // 
            this.cb_ImportStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ImportStatus.FormattingEnabled = true;
            this.cb_ImportStatus.Location = new System.Drawing.Point(502, 35);
            this.cb_ImportStatus.Name = "cb_ImportStatus";
            this.cb_ImportStatus.Size = new System.Drawing.Size(215, 26);
            this.cb_ImportStatus.TabIndex = 74;
            // 
            // lbl_ImportStatus
            // 
            this.lbl_ImportStatus.AutoSize = true;
            this.lbl_ImportStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImportStatus.Location = new System.Drawing.Point(499, 11);
            this.lbl_ImportStatus.Name = "lbl_ImportStatus";
            this.lbl_ImportStatus.Size = new System.Drawing.Size(81, 18);
            this.lbl_ImportStatus.TabIndex = 73;
            this.lbl_ImportStatus.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tìm kiếm theo tên sản phẩm hoặc mã phiếu nhập";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(18, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(699, 26);
            this.textBox4.TabIndex = 71;
            // 
            // dtp_ImportToDate
            // 
            this.dtp_ImportToDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ImportToDate.Location = new System.Drawing.Point(258, 35);
            this.dtp_ImportToDate.Name = "dtp_ImportToDate";
            this.dtp_ImportToDate.Size = new System.Drawing.Size(215, 26);
            this.dtp_ImportToDate.TabIndex = 70;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // lbl_ToDate
            // 
            this.lbl_ToDate.AutoSize = true;
            this.lbl_ToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToDate.Location = new System.Drawing.Point(255, 14);
            this.lbl_ToDate.Name = "lbl_ToDate";
            this.lbl_ToDate.Size = new System.Drawing.Size(74, 18);
            this.lbl_ToDate.TabIndex = 68;
            this.lbl_ToDate.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Từ ngày:";
            // 
            // btn_ImportSearch
            // 
            this.btn_ImportSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ImportSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImportSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportSearch.ForeColor = System.Drawing.Color.White;
            this.btn_ImportSearch.Location = new System.Drawing.Point(758, 34);
            this.btn_ImportSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ImportSearch.Name = "btn_ImportSearch";
            this.btn_ImportSearch.Size = new System.Drawing.Size(160, 26);
            this.btn_ImportSearch.TabIndex = 66;
            this.btn_ImportSearch.TabStop = false;
            this.btn_ImportSearch.Text = "Tìm kiếm";
            this.btn_ImportSearch.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachPhieuNhap
            // 
            this.dgv_DanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhieuNhap.Location = new System.Drawing.Point(18, 147);
            this.dgv_DanhSachPhieuNhap.Name = "dgv_DanhSachPhieuNhap";
            this.dgv_DanhSachPhieuNhap.ReadOnly = true;
            this.dgv_DanhSachPhieuNhap.RowHeadersWidth = 51;
            this.dgv_DanhSachPhieuNhap.Size = new System.Drawing.Size(900, 396);
            this.dgv_DanhSachPhieuNhap.TabIndex = 65;
            this.dgv_DanhSachPhieuNhap.TabStop = false;
            this.dgv_DanhSachPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GioHang_CellContentClick);
            // 
            // UC_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_ImportStatus);
            this.Controls.Add(this.lbl_ImportStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dtp_ImportToDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_ToDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ImportSearch);
            this.Controls.Add(this.dgv_DanhSachPhieuNhap);
            this.Name = "UC_Import";
            this.Size = new System.Drawing.Size(935, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_ImportStatus;
        private System.Windows.Forms.Label lbl_ImportStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dtp_ImportToDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_ToDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ImportSearch;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhieuNhap;
    }
}

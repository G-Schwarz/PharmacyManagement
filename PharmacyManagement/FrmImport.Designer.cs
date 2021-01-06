namespace PharmacyManagement
{
    partial class FrmImport
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
            this.dgv_GioHang = new System.Windows.Forms.DataGridView();
            this.btn_ImportSearch = new System.Windows.Forms.Button();
            this.dtp_ImportToDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ImportFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ToDate = new System.Windows.Forms.Label();
            this.lbl_FromDate = new System.Windows.Forms.Label();
            this.cb_ImportStatus = new System.Windows.Forms.ComboBox();
            this.lbl_ImportStatus = new System.Windows.Forms.Label();
            this.lbl_ImportSearchBox = new System.Windows.Forms.Label();
            this.txt_ImportSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_GioHang
            // 
            this.dgv_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GioHang.Location = new System.Drawing.Point(31, 155);
            this.dgv_GioHang.Name = "dgv_GioHang";
            this.dgv_GioHang.ReadOnly = true;
            this.dgv_GioHang.RowHeadersWidth = 51;
            this.dgv_GioHang.Size = new System.Drawing.Size(900, 396);
            this.dgv_GioHang.TabIndex = 43;
            this.dgv_GioHang.TabStop = false;
            this.dgv_GioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GioHang_CellContentClick);
            // 
            // btn_ImportSearch
            // 
            this.btn_ImportSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ImportSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImportSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportSearch.ForeColor = System.Drawing.Color.White;
            this.btn_ImportSearch.Location = new System.Drawing.Point(771, 42);
            this.btn_ImportSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ImportSearch.Name = "btn_ImportSearch";
            this.btn_ImportSearch.Size = new System.Drawing.Size(160, 26);
            this.btn_ImportSearch.TabIndex = 48;
            this.btn_ImportSearch.TabStop = false;
            this.btn_ImportSearch.Text = "Tìm kiếm";
            this.btn_ImportSearch.UseVisualStyleBackColor = false;
            this.btn_ImportSearch.Click += new System.EventHandler(this.btn_LuuPhieuNhap_Click);
            // 
            // dtp_ImportToDate
            // 
            this.dtp_ImportToDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ImportToDate.Location = new System.Drawing.Point(271, 43);
            this.dtp_ImportToDate.Name = "dtp_ImportToDate";
            this.dtp_ImportToDate.Size = new System.Drawing.Size(215, 26);
            this.dtp_ImportToDate.TabIndex = 52;
            // 
            // dtp_ImportFromDate
            // 
            this.dtp_ImportFromDate.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportFromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ImportFromDate.Location = new System.Drawing.Point(31, 43);
            this.dtp_ImportFromDate.Name = "dtp_ImportFromDate";
            this.dtp_ImportFromDate.Size = new System.Drawing.Size(215, 26);
            this.dtp_ImportFromDate.TabIndex = 51;
            // 
            // lbl_ToDate
            // 
            this.lbl_ToDate.AutoSize = true;
            this.lbl_ToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToDate.Location = new System.Drawing.Point(268, 22);
            this.lbl_ToDate.Name = "lbl_ToDate";
            this.lbl_ToDate.Size = new System.Drawing.Size(74, 18);
            this.lbl_ToDate.TabIndex = 50;
            this.lbl_ToDate.Text = "Đến ngày";
            // 
            // lbl_FromDate
            // 
            this.lbl_FromDate.AutoSize = true;
            this.lbl_FromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FromDate.Location = new System.Drawing.Point(28, 22);
            this.lbl_FromDate.Name = "lbl_FromDate";
            this.lbl_FromDate.Size = new System.Drawing.Size(69, 18);
            this.lbl_FromDate.TabIndex = 49;
            this.lbl_FromDate.Text = "Từ ngày:";
            // 
            // cb_ImportStatus
            // 
            this.cb_ImportStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ImportStatus.FormattingEnabled = true;
            this.cb_ImportStatus.Location = new System.Drawing.Point(515, 43);
            this.cb_ImportStatus.Name = "cb_ImportStatus";
            this.cb_ImportStatus.Size = new System.Drawing.Size(215, 26);
            this.cb_ImportStatus.TabIndex = 56;
            // 
            // lbl_ImportStatus
            // 
            this.lbl_ImportStatus.AutoSize = true;
            this.lbl_ImportStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImportStatus.Location = new System.Drawing.Point(512, 19);
            this.lbl_ImportStatus.Name = "lbl_ImportStatus";
            this.lbl_ImportStatus.Size = new System.Drawing.Size(81, 18);
            this.lbl_ImportStatus.TabIndex = 55;
            this.lbl_ImportStatus.Text = "Trạng Thái";
            // 
            // lbl_ImportSearchBox
            // 
            this.lbl_ImportSearchBox.AutoSize = true;
            this.lbl_ImportSearchBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImportSearchBox.Location = new System.Drawing.Point(28, 80);
            this.lbl_ImportSearchBox.Name = "lbl_ImportSearchBox";
            this.lbl_ImportSearchBox.Size = new System.Drawing.Size(346, 18);
            this.lbl_ImportSearchBox.TabIndex = 54;
            this.lbl_ImportSearchBox.Text = "Tìm kiếm theo tên sản phẩm hoặc mã phiếu nhập";
            // 
            // txt_ImportSearch
            // 
            this.txt_ImportSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImportSearch.Location = new System.Drawing.Point(31, 104);
            this.txt_ImportSearch.Name = "txt_ImportSearch";
            this.txt_ImportSearch.Size = new System.Drawing.Size(699, 26);
            this.txt_ImportSearch.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(771, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 26);
            this.button1.TabIndex = 57;
            this.button1.TabStop = false;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(962, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_ImportStatus);
            this.Controls.Add(this.lbl_ImportStatus);
            this.Controls.Add(this.lbl_ImportSearchBox);
            this.Controls.Add(this.txt_ImportSearch);
            this.Controls.Add(this.dtp_ImportToDate);
            this.Controls.Add(this.dtp_ImportFromDate);
            this.Controls.Add(this.lbl_ToDate);
            this.Controls.Add(this.lbl_FromDate);
            this.Controls.Add(this.btn_ImportSearch);
            this.Controls.Add(this.dgv_GioHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImport";
            this.Load += new System.EventHandler(this.FrmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_GioHang;
        private System.Windows.Forms.Button btn_ImportSearch;
        private System.Windows.Forms.DateTimePicker dtp_ImportToDate;
        private System.Windows.Forms.DateTimePicker dtp_ImportFromDate;
        private System.Windows.Forms.Label lbl_ToDate;
        private System.Windows.Forms.Label lbl_FromDate;
        private System.Windows.Forms.ComboBox cb_ImportStatus;
        private System.Windows.Forms.Label lbl_ImportStatus;
        private System.Windows.Forms.Label lbl_ImportSearchBox;
        private System.Windows.Forms.TextBox txt_ImportSearch;
        private System.Windows.Forms.Button button1;
    }
}
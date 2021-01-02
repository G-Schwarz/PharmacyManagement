namespace PharmacyManagement
{
    partial class UC_Index
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.pn_ThongTinThuoc = new System.Windows.Forms.Panel();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lbl_MaThuoc = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.dgv_DanhMuc = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pn_ThongTinThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(766, 26);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(160, 29);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm sản phẩm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pn_ThongTinThuoc
            // 
            this.pn_ThongTinThuoc.Controls.Add(this.comboBox3);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_MaHang);
            this.pn_ThongTinThuoc.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTinThuoc.Controls.Add(this.btn_Them);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_MaThuoc);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_SoLuong);
            this.pn_ThongTinThuoc.Location = new System.Drawing.Point(16, 25);
            this.pn_ThongTinThuoc.Name = "pn_ThongTinThuoc";
            this.pn_ThongTinThuoc.Size = new System.Drawing.Size(943, 82);
            this.pn_ThongTinThuoc.TabIndex = 42;
            this.pn_ThongTinThuoc.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_ThongTinThuoc_Paint);
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHang.Location = new System.Drawing.Point(0, 28);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(252, 27);
            this.txt_MaHang.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(572, 26);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(160, 29);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lbl_MaThuoc
            // 
            this.lbl_MaThuoc.AutoSize = true;
            this.lbl_MaThuoc.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaThuoc.Location = new System.Drawing.Point(-4, 6);
            this.lbl_MaThuoc.Name = "lbl_MaThuoc";
            this.lbl_MaThuoc.Size = new System.Drawing.Size(104, 19);
            this.lbl_MaThuoc.TabIndex = 16;
            this.lbl_MaThuoc.Text = "Mã sản phẩm";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(283, 7);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(84, 19);
            this.lbl_SoLuong.TabIndex = 28;
            this.lbl_SoLuong.Text = "Loại thuốc:";
            // 
            // dgv_DanhMuc
            // 
            this.dgv_DanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMuc.Location = new System.Drawing.Point(16, 113);
            this.dgv_DanhMuc.Name = "dgv_DanhMuc";
            this.dgv_DanhMuc.ReadOnly = true;
            this.dgv_DanhMuc.RowHeadersWidth = 51;
            this.dgv_DanhMuc.Size = new System.Drawing.Size(943, 385);
            this.dgv_DanhMuc.TabIndex = 43;
            this.dgv_DanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMuc_CellContentClick);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(286, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(252, 27);
            this.comboBox3.TabIndex = 31;
            // 
            // UC_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DanhMuc);
            this.Controls.Add(this.pn_ThongTinThuoc);
            this.Name = "UC_Index";
            this.Size = new System.Drawing.Size(976, 514);
            this.Load += new System.EventHandler(this.UC_Index_Load);
            this.pn_ThongTinThuoc.ResumeLayout(false);
            this.pn_ThongTinThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel pn_ThongTinThuoc;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label lbl_MaThuoc;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.DataGridView dgv_DanhMuc;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
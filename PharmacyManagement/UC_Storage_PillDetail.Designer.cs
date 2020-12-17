
namespace PharmacyManagement
{
    partial class UC_Storage_PillDetail
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
            this.dtp_HSD = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lbl_HSD = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_NgayNhap = new System.Windows.Forms.Label();
            this.lbl_NhaCungCap = new System.Windows.Forms.Label();
            this.txt_NhaCungCap = new System.Windows.Forms.TextBox();
            this.txt_SoLo = new System.Windows.Forms.TextBox();
            this.lbl_SoLo = new System.Windows.Forms.Label();
            this.txt_TenThuoc = new System.Windows.Forms.TextBox();
            this.lbl_TenThuoc = new System.Windows.Forms.Label();
            this.txt_MaThuoc = new System.Windows.Forms.TextBox();
            this.lbl_MaThuoc = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.txt_VAT = new System.Windows.Forms.TextBox();
            this.lvl_VAT = new System.Windows.Forms.Label();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_TroLai = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.pn_ThongTinThuoc = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_ThongTinThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_HSD
            // 
            this.dtp_HSD.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HSD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HSD.Location = new System.Drawing.Point(335, 246);
            this.dtp_HSD.Name = "dtp_HSD";
            this.dtp_HSD.Size = new System.Drawing.Size(200, 26);
            this.dtp_HSD.TabIndex = 27;
            this.dtp_HSD.ValueChanged += new System.EventHandler(this.dtp_HSD_ValueChanged);
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(0, 246);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(200, 26);
            this.dtp_NgayNhap.TabIndex = 23;
            this.dtp_NgayNhap.ValueChanged += new System.EventHandler(this.dtp_NgayNhap_ValueChanged);
            // 
            // lbl_HSD
            // 
            this.lbl_HSD.AutoSize = true;
            this.lbl_HSD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HSD.Location = new System.Drawing.Point(332, 225);
            this.lbl_HSD.Name = "lbl_HSD";
            this.lbl_HSD.Size = new System.Drawing.Size(101, 18);
            this.lbl_HSD.TabIndex = 29;
            this.lbl_HSD.Text = "Hạn sử dụng:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(335, 147);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(215, 26);
            this.txt_SoLuong.TabIndex = 25;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(333, 123);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(78, 18);
            this.lbl_SoLuong.TabIndex = 28;
            this.lbl_SoLuong.Text = "Số lượng:";
            // 
            // lbl_NgayNhap
            // 
            this.lbl_NgayNhap.AutoSize = true;
            this.lbl_NgayNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayNhap.Location = new System.Drawing.Point(-3, 225);
            this.lbl_NgayNhap.Name = "lbl_NgayNhap";
            this.lbl_NgayNhap.Size = new System.Drawing.Size(86, 18);
            this.lbl_NgayNhap.TabIndex = 26;
            this.lbl_NgayNhap.Text = "Ngày nhập:";
            // 
            // lbl_NhaCungCap
            // 
            this.lbl_NhaCungCap.AutoSize = true;
            this.lbl_NhaCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhaCungCap.Location = new System.Drawing.Point(-3, 123);
            this.lbl_NhaCungCap.Name = "lbl_NhaCungCap";
            this.lbl_NhaCungCap.Size = new System.Drawing.Size(107, 18);
            this.lbl_NhaCungCap.TabIndex = 24;
            this.lbl_NhaCungCap.Text = "Nhà cung cấp:";
            // 
            // txt_NhaCungCap
            // 
            this.txt_NhaCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhaCungCap.Location = new System.Drawing.Point(0, 147);
            this.txt_NhaCungCap.Name = "txt_NhaCungCap";
            this.txt_NhaCungCap.Size = new System.Drawing.Size(215, 26);
            this.txt_NhaCungCap.TabIndex = 22;
            this.txt_NhaCungCap.TextChanged += new System.EventHandler(this.txt_NhaCungCap_TextChanged);
            // 
            // txt_SoLo
            // 
            this.txt_SoLo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLo.Location = new System.Drawing.Point(669, 44);
            this.txt_SoLo.Name = "txt_SoLo";
            this.txt_SoLo.Size = new System.Drawing.Size(215, 26);
            this.txt_SoLo.TabIndex = 21;
            this.txt_SoLo.TextChanged += new System.EventHandler(this.txt_SoLo_TextChanged);
            // 
            // lbl_SoLo
            // 
            this.lbl_SoLo.AutoSize = true;
            this.lbl_SoLo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLo.Location = new System.Drawing.Point(666, 23);
            this.lbl_SoLo.Name = "lbl_SoLo";
            this.lbl_SoLo.Size = new System.Drawing.Size(48, 18);
            this.lbl_SoLo.TabIndex = 20;
            this.lbl_SoLo.Text = "Số lô:";
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenThuoc.Location = new System.Drawing.Point(335, 44);
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.Size = new System.Drawing.Size(215, 26);
            this.txt_TenThuoc.TabIndex = 19;
            this.txt_TenThuoc.TextChanged += new System.EventHandler(this.txt_TenThuoc_TextChanged);
            // 
            // lbl_TenThuoc
            // 
            this.lbl_TenThuoc.AutoSize = true;
            this.lbl_TenThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenThuoc.Location = new System.Drawing.Point(332, 23);
            this.lbl_TenThuoc.Name = "lbl_TenThuoc";
            this.lbl_TenThuoc.Size = new System.Drawing.Size(79, 18);
            this.lbl_TenThuoc.TabIndex = 18;
            this.lbl_TenThuoc.Text = "Tên thuốc:";
            // 
            // txt_MaThuoc
            // 
            this.txt_MaThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaThuoc.Location = new System.Drawing.Point(0, 44);
            this.txt_MaThuoc.Name = "txt_MaThuoc";
            this.txt_MaThuoc.Size = new System.Drawing.Size(215, 26);
            this.txt_MaThuoc.TabIndex = 17;
            this.txt_MaThuoc.TextChanged += new System.EventHandler(this.txt_MaThuoc_TextChanged);
            // 
            // lbl_MaThuoc
            // 
            this.lbl_MaThuoc.AutoSize = true;
            this.lbl_MaThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaThuoc.Location = new System.Drawing.Point(-3, 23);
            this.lbl_MaThuoc.Name = "lbl_MaThuoc";
            this.lbl_MaThuoc.Size = new System.Drawing.Size(75, 18);
            this.lbl_MaThuoc.TabIndex = 16;
            this.lbl_MaThuoc.Text = "Mã thuốc:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(666, 147);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(215, 26);
            this.txt_DonGia.TabIndex = 30;
            this.txt_DonGia.TextChanged += new System.EventHandler(this.txt_DonGia_TextChanged);
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(666, 123);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(69, 18);
            this.lbl_DonGia.TabIndex = 31;
            this.lbl_DonGia.Text = "Đơn giá:";
            // 
            // txt_VAT
            // 
            this.txt_VAT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VAT.Location = new System.Drawing.Point(669, 246);
            this.txt_VAT.Name = "txt_VAT";
            this.txt_VAT.Size = new System.Drawing.Size(215, 26);
            this.txt_VAT.TabIndex = 32;
            this.txt_VAT.TextChanged += new System.EventHandler(this.txt_VAT_TextChanged);
            // 
            // lvl_VAT
            // 
            this.lvl_VAT.AutoSize = true;
            this.lvl_VAT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_VAT.Location = new System.Drawing.Point(666, 225);
            this.lvl_VAT.Name = "lvl_VAT";
            this.lvl_VAT.Size = new System.Drawing.Size(39, 18);
            this.lvl_VAT.TabIndex = 33;
            this.lvl_VAT.Text = "VAT:";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Xoa.FlatAppearance.BorderSize = 0;
            this.bt_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Xoa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.ForeColor = System.Drawing.Color.White;
            this.bt_Xoa.Location = new System.Drawing.Point(783, 376);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(143, 42);
            this.bt_Xoa.TabIndex = 34;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Sua.FlatAppearance.BorderSize = 0;
            this.bt_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sua.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.ForeColor = System.Drawing.Color.White;
            this.bt_Sua.Location = new System.Drawing.Point(590, 376);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(143, 42);
            this.bt_Sua.TabIndex = 35;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_TroLai
            // 
            this.bt_TroLai.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_TroLai.FlatAppearance.BorderSize = 0;
            this.bt_TroLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_TroLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_TroLai.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TroLai.ForeColor = System.Drawing.Color.White;
            this.bt_TroLai.Location = new System.Drawing.Point(42, 376);
            this.bt_TroLai.Name = "bt_TroLai";
            this.bt_TroLai.Size = new System.Drawing.Size(143, 42);
            this.bt_TroLai.TabIndex = 37;
            this.bt_TroLai.Text = "Quay lại";
            this.bt_TroLai.UseVisualStyleBackColor = false;
            this.bt_TroLai.Click += new System.EventHandler(this.bt_TroLai_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Luu.FlatAppearance.BorderSize = 0;
            this.bt_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Luu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.Color.White;
            this.bt_Luu.Location = new System.Drawing.Point(590, 376);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(143, 42);
            this.bt_Luu.TabIndex = 38;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Visible = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Huy.FlatAppearance.BorderSize = 0;
            this.bt_Huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Huy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.ForeColor = System.Drawing.Color.White;
            this.bt_Huy.Location = new System.Drawing.Point(407, 376);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(143, 42);
            this.bt_Huy.TabIndex = 39;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // pn_ThongTinThuoc
            // 
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_MaThuoc);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_TenThuoc);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_MaThuoc);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_TenThuoc);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_SoLo);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_VAT);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_SoLo);
            this.pn_ThongTinThuoc.Controls.Add(this.lvl_VAT);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_NhaCungCap);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_DonGia);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_NhaCungCap);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_DonGia);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_NgayNhap);
            this.pn_ThongTinThuoc.Controls.Add(this.dtp_HSD);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_SoLuong);
            this.pn_ThongTinThuoc.Controls.Add(this.dtp_NgayNhap);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_SoLuong);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_HSD);
            this.pn_ThongTinThuoc.Enabled = false;
            this.pn_ThongTinThuoc.Location = new System.Drawing.Point(42, 23);
            this.pn_ThongTinThuoc.Name = "pn_ThongTinThuoc";
            this.pn_ThongTinThuoc.Size = new System.Drawing.Size(884, 347);
            this.pn_ThongTinThuoc.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(883, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "uc_PillsInfo";
            // 
            // UC_Storage_PillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.bt_TroLai);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.pn_ThongTinThuoc);
            this.Name = "UC_Storage_PillDetail";
            this.Size = new System.Drawing.Size(976, 463);
            this.Load += new System.EventHandler(this.UC_Storage_PillDetail_Load);
            this.pn_ThongTinThuoc.ResumeLayout(false);
            this.pn_ThongTinThuoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_HSD;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.Label lbl_HSD;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_NgayNhap;
        private System.Windows.Forms.Label lbl_NhaCungCap;
        private System.Windows.Forms.TextBox txt_NhaCungCap;
        private System.Windows.Forms.TextBox txt_SoLo;
        private System.Windows.Forms.Label lbl_SoLo;
        private System.Windows.Forms.TextBox txt_TenThuoc;
        private System.Windows.Forms.Label lbl_TenThuoc;
        private System.Windows.Forms.TextBox txt_MaThuoc;
        private System.Windows.Forms.Label lbl_MaThuoc;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.TextBox txt_VAT;
        private System.Windows.Forms.Label lvl_VAT;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_TroLai;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Panel pn_ThongTinThuoc;
        private System.Windows.Forms.Label label1;
    }
}

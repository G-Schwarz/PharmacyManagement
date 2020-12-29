﻿namespace PharmacyManagement
{
    partial class UC_Storage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.dgv_Thuoc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_MaThuoc = new System.Windows.Forms.Label();
            this.txt_MaThuoc = new System.Windows.Forms.TextBox();
            this.lbl_TenThuoc = new System.Windows.Forms.Label();
            this.txt_TenThuoc = new System.Windows.Forms.TextBox();
            this.lbl_SoLo = new System.Windows.Forms.Label();
            this.txt_SoLo = new System.Windows.Forms.TextBox();
            this.txt_NhaCungCap = new System.Windows.Forms.TextBox();
            this.lbl_NhaCungCap = new System.Windows.Forms.Label();
            this.lbl_NgayNhap = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_HSD = new System.Windows.Forms.Label();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.dtp_HSD = new System.Windows.Forms.DateTimePicker();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.uC_Storage_PillDetail1 = new PharmacyManagement.UC_Storage_PillDetail();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UC Storage";
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_NhapHang.FlatAppearance.BorderSize = 0;
            this.btn_NhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapHang.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.ForeColor = System.Drawing.Color.White;
            this.btn_NhapHang.Location = new System.Drawing.Point(21, 3);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(130, 42);
            this.btn_NhapHang.TabIndex = 1;
            this.btn_NhapHang.Text = "Nhập Hàng";
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // dgv_Thuoc
            // 
            this.dgv_Thuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Thuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Thuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Thuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.SoLo,
            this.NhaCungCap,
            this.NgayNhap,
            this.SoLuong,
            this.HanDung});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Thuoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Thuoc.Location = new System.Drawing.Point(12, 211);
            this.dgv_Thuoc.Name = "dgv_Thuoc";
            this.dgv_Thuoc.ReadOnly = true;
            this.dgv_Thuoc.RowHeadersWidth = 51;
            this.dgv_Thuoc.ShowRowErrors = false;
            this.dgv_Thuoc.Size = new System.Drawing.Size(941, 290);
            this.dgv_Thuoc.TabIndex = 0;
            this.dgv_Thuoc.TabStop = false;
            this.dgv_Thuoc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Thuoc_CellContentDoubleClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            this.MaThuoc.Width = 96;
            // 
            // TenThuoc
            // 
            this.TenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // SoLo
            // 
            this.SoLo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoLo.HeaderText = "Số lô";
            this.SoLo.MinimumWidth = 6;
            this.SoLo.Name = "SoLo";
            this.SoLo.ReadOnly = true;
            this.SoLo.Width = 69;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NhaCungCap.HeaderText = "Nhà cung cấp";
            this.NhaCungCap.MinimumWidth = 6;
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.ReadOnly = true;
            this.NhaCungCap.Width = 128;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 107;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 99;
            // 
            // HanDung
            // 
            this.HanDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HanDung.HeaderText = "HSD";
            this.HanDung.MinimumWidth = 6;
            this.HanDung.Name = "HanDung";
            this.HanDung.ReadOnly = true;
            this.HanDung.Width = 67;
            // 
            // lbl_MaThuoc
            // 
            this.lbl_MaThuoc.AutoSize = true;
            this.lbl_MaThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaThuoc.Location = new System.Drawing.Point(9, 62);
            this.lbl_MaThuoc.Name = "lbl_MaThuoc";
            this.lbl_MaThuoc.Size = new System.Drawing.Size(75, 18);
            this.lbl_MaThuoc.TabIndex = 3;
            this.lbl_MaThuoc.Text = "Mã thuốc:";
            // 
            // txt_MaThuoc
            // 
            this.txt_MaThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaThuoc.Location = new System.Drawing.Point(12, 83);
            this.txt_MaThuoc.Name = "txt_MaThuoc";
            this.txt_MaThuoc.Size = new System.Drawing.Size(215, 26);
            this.txt_MaThuoc.TabIndex = 4;
            // 
            // lbl_TenThuoc
            // 
            this.lbl_TenThuoc.AutoSize = true;
            this.lbl_TenThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenThuoc.Location = new System.Drawing.Point(244, 62);
            this.lbl_TenThuoc.Name = "lbl_TenThuoc";
            this.lbl_TenThuoc.Size = new System.Drawing.Size(79, 18);
            this.lbl_TenThuoc.TabIndex = 5;
            this.lbl_TenThuoc.Text = "Tên thuốc:";
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenThuoc.Location = new System.Drawing.Point(247, 83);
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.Size = new System.Drawing.Size(215, 26);
            this.txt_TenThuoc.TabIndex = 6;
            // 
            // lbl_SoLo
            // 
            this.lbl_SoLo.AutoSize = true;
            this.lbl_SoLo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLo.Location = new System.Drawing.Point(484, 62);
            this.lbl_SoLo.Name = "lbl_SoLo";
            this.lbl_SoLo.Size = new System.Drawing.Size(48, 18);
            this.lbl_SoLo.TabIndex = 7;
            this.lbl_SoLo.Text = "Số lô:";
            // 
            // txt_SoLo
            // 
            this.txt_SoLo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLo.Location = new System.Drawing.Point(487, 83);
            this.txt_SoLo.Name = "txt_SoLo";
            this.txt_SoLo.Size = new System.Drawing.Size(215, 26);
            this.txt_SoLo.TabIndex = 8;
            // 
            // txt_NhaCungCap
            // 
            this.txt_NhaCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhaCungCap.Location = new System.Drawing.Point(738, 83);
            this.txt_NhaCungCap.Name = "txt_NhaCungCap";
            this.txt_NhaCungCap.Size = new System.Drawing.Size(215, 26);
            this.txt_NhaCungCap.TabIndex = 9;
            // 
            // lbl_NhaCungCap
            // 
            this.lbl_NhaCungCap.AutoSize = true;
            this.lbl_NhaCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhaCungCap.Location = new System.Drawing.Point(735, 62);
            this.lbl_NhaCungCap.Name = "lbl_NhaCungCap";
            this.lbl_NhaCungCap.Size = new System.Drawing.Size(107, 18);
            this.lbl_NhaCungCap.TabIndex = 10;
            this.lbl_NhaCungCap.Text = "Nhà cung cấp:";
            // 
            // lbl_NgayNhap
            // 
            this.lbl_NgayNhap.AutoSize = true;
            this.lbl_NgayNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayNhap.Location = new System.Drawing.Point(9, 136);
            this.lbl_NgayNhap.Name = "lbl_NgayNhap";
            this.lbl_NgayNhap.Size = new System.Drawing.Size(86, 18);
            this.lbl_NgayNhap.TabIndex = 11;
            this.lbl_NgayNhap.Text = "Ngày nhập:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(247, 157);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(215, 26);
            this.txt_SoLuong.TabIndex = 11;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(244, 136);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(78, 18);
            this.lbl_SoLuong.TabIndex = 13;
            this.lbl_SoLuong.Text = "Số lượng:";
            // 
            // lbl_HSD
            // 
            this.lbl_HSD.AutoSize = true;
            this.lbl_HSD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HSD.Location = new System.Drawing.Point(484, 136);
            this.lbl_HSD.Name = "lbl_HSD";
            this.lbl_HSD.Size = new System.Drawing.Size(101, 18);
            this.lbl_HSD.TabIndex = 15;
            this.lbl_HSD.Text = "Hạn sử dụng:";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(12, 157);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(200, 26);
            this.dtp_NgayNhap.TabIndex = 10;
            // 
            // dtp_HSD
            // 
            this.dtp_HSD.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HSD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HSD.Location = new System.Drawing.Point(487, 157);
            this.dtp_HSD.Name = "dtp_HSD";
            this.dtp_HSD.Size = new System.Drawing.Size(200, 26);
            this.dtp_HSD.TabIndex = 12;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_TimKiem.FlatAppearance.BorderSize = 0;
            this.bt_TimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_TimKiem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimKiem.ForeColor = System.Drawing.Color.White;
            this.bt_TimKiem.Location = new System.Drawing.Point(768, 144);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(154, 50);
            this.bt_TimKiem.TabIndex = 13;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            // 
            // uC_Storage_PillDetail1
            // 
            this.uC_Storage_PillDetail1.Location = new System.Drawing.Point(0, 51);
            this.uC_Storage_PillDetail1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Storage_PillDetail1.Name = "uC_Storage_PillDetail1";
            this.uC_Storage_PillDetail1.Size = new System.Drawing.Size(976, 463);
            this.uC_Storage_PillDetail1.TabIndex = 16;
            // 
            // UC_Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Thuoc);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.dtp_HSD);
            this.Controls.Add(this.dtp_NgayNhap);
            this.Controls.Add(this.lbl_HSD);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_NgayNhap);
            this.Controls.Add(this.lbl_NhaCungCap);
            this.Controls.Add(this.txt_NhaCungCap);
            this.Controls.Add(this.txt_SoLo);
            this.Controls.Add(this.lbl_SoLo);
            this.Controls.Add(this.txt_TenThuoc);
            this.Controls.Add(this.lbl_TenThuoc);
            this.Controls.Add(this.txt_MaThuoc);
            this.Controls.Add(this.lbl_MaThuoc);
            this.Controls.Add(this.btn_NhapHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uC_Storage_PillDetail1);
            this.Name = "UC_Storage";
            this.Size = new System.Drawing.Size(976, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.DataGridView dgv_Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanDung;
        private System.Windows.Forms.Label lbl_MaThuoc;
        private System.Windows.Forms.TextBox txt_MaThuoc;
        private System.Windows.Forms.Label lbl_TenThuoc;
        private System.Windows.Forms.TextBox txt_TenThuoc;
        private System.Windows.Forms.Label lbl_SoLo;
        private System.Windows.Forms.TextBox txt_SoLo;
        private System.Windows.Forms.TextBox txt_NhaCungCap;
        private System.Windows.Forms.Label lbl_NhaCungCap;
        private System.Windows.Forms.Label lbl_NgayNhap;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_HSD;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.DateTimePicker dtp_HSD;
        private System.Windows.Forms.Button bt_TimKiem;
        private UC_Storage_PillDetail uC_Storage_PillDetail1;
    }
}

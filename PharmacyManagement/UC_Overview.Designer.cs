namespace PharmacyManagement
{
    partial class UC_Overview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_DoanhSoThangNay = new System.Windows.Forms.Label();
            this.lb_DoanhSoThangTruoc = new System.Windows.Forms.Label();
            this.lb_Doanhso = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_HoaDonThangNay = new System.Windows.Forms.Label();
            this.lb_HoaDonThangTruoc = new System.Windows.Forms.Label();
            this.lb_HoaDon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_BaoCaoDoanhSo = new System.Windows.Forms.Label();
            this.lb_BaoCaoHoaDon = new System.Windows.Forms.Label();
            this.lb_BaoCaoTrongNgay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_CanhBaoHetHang = new System.Windows.Forms.Label();
            this.lb_CanhBaoHangHetHan = new System.Windows.Forms.Label();
            this.lb_CanhBao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(121)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.lb_DoanhSoThangNay);
            this.panel1.Controls.Add(this.lb_DoanhSoThangTruoc);
            this.panel1.Controls.Add(this.lb_Doanhso);
            this.panel1.Location = new System.Drawing.Point(64, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 106);
            this.panel1.TabIndex = 1;
            // 
            // lb_DoanhSoThangNay
            // 
            this.lb_DoanhSoThangNay.AutoSize = true;
            this.lb_DoanhSoThangNay.Font = new System.Drawing.Font("Futura", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_DoanhSoThangNay.ForeColor = System.Drawing.Color.White;
            this.lb_DoanhSoThangNay.Location = new System.Drawing.Point(4, 62);
            this.lb_DoanhSoThangNay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DoanhSoThangNay.Name = "lb_DoanhSoThangNay";
            this.lb_DoanhSoThangNay.Size = new System.Drawing.Size(105, 22);
            this.lb_DoanhSoThangNay.TabIndex = 2;
            this.lb_DoanhSoThangNay.Text = "Tháng này:";
            // 
            // lb_DoanhSoThangTruoc
            // 
            this.lb_DoanhSoThangTruoc.AutoSize = true;
            this.lb_DoanhSoThangTruoc.Font = new System.Drawing.Font("Futura", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DoanhSoThangTruoc.ForeColor = System.Drawing.Color.White;
            this.lb_DoanhSoThangTruoc.Location = new System.Drawing.Point(4, 27);
            this.lb_DoanhSoThangTruoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DoanhSoThangTruoc.Name = "lb_DoanhSoThangTruoc";
            this.lb_DoanhSoThangTruoc.Size = new System.Drawing.Size(118, 22);
            this.lb_DoanhSoThangTruoc.TabIndex = 1;
            this.lb_DoanhSoThangTruoc.Text = "Tháng trước:";
            // 
            // lb_Doanhso
            // 
            this.lb_Doanhso.AutoSize = true;
            this.lb_Doanhso.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Doanhso.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Doanhso.ForeColor = System.Drawing.Color.White;
            this.lb_Doanhso.Location = new System.Drawing.Point(130, 0);
            this.lb_Doanhso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Doanhso.Name = "lb_Doanhso";
            this.lb_Doanhso.Size = new System.Drawing.Size(106, 28);
            this.lb_Doanhso.TabIndex = 0;
            this.lb_Doanhso.Text = "Doanh Số";
            this.lb_Doanhso.Click += new System.EventHandler(this.lb_Doanhso_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(64, 209);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(871, 369);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.lb_HoaDonThangNay);
            this.panel2.Controls.Add(this.lb_HoaDonThangTruoc);
            this.panel2.Controls.Add(this.lb_HoaDon);
            this.panel2.Location = new System.Drawing.Point(383, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 106);
            this.panel2.TabIndex = 2;
            // 
            // lb_HoaDonThangNay
            // 
            this.lb_HoaDonThangNay.AutoSize = true;
            this.lb_HoaDonThangNay.Font = new System.Drawing.Font("Futura", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_HoaDonThangNay.ForeColor = System.Drawing.Color.White;
            this.lb_HoaDonThangNay.Location = new System.Drawing.Point(4, 64);
            this.lb_HoaDonThangNay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HoaDonThangNay.Name = "lb_HoaDonThangNay";
            this.lb_HoaDonThangNay.Size = new System.Drawing.Size(105, 22);
            this.lb_HoaDonThangNay.TabIndex = 3;
            this.lb_HoaDonThangNay.Text = "Tháng này:";
            // 
            // lb_HoaDonThangTruoc
            // 
            this.lb_HoaDonThangTruoc.AutoSize = true;
            this.lb_HoaDonThangTruoc.Font = new System.Drawing.Font("Futura", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_HoaDonThangTruoc.ForeColor = System.Drawing.Color.White;
            this.lb_HoaDonThangTruoc.Location = new System.Drawing.Point(4, 27);
            this.lb_HoaDonThangTruoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HoaDonThangTruoc.Name = "lb_HoaDonThangTruoc";
            this.lb_HoaDonThangTruoc.Size = new System.Drawing.Size(118, 22);
            this.lb_HoaDonThangTruoc.TabIndex = 2;
            this.lb_HoaDonThangTruoc.Text = "Tháng trước:";
            // 
            // lb_HoaDon
            // 
            this.lb_HoaDon.AutoSize = true;
            this.lb_HoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_HoaDon.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoaDon.ForeColor = System.Drawing.Color.White;
            this.lb_HoaDon.Location = new System.Drawing.Point(137, 0);
            this.lb_HoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HoaDon.Name = "lb_HoaDon";
            this.lb_HoaDon.Size = new System.Drawing.Size(99, 28);
            this.lb_HoaDon.TabIndex = 1;
            this.lb_HoaDon.Text = "Hóa Đơn";
            this.lb_HoaDon.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(173)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.lb_BaoCaoDoanhSo);
            this.panel3.Controls.Add(this.lb_BaoCaoHoaDon);
            this.panel3.Controls.Add(this.lb_BaoCaoTrongNgay);
            this.panel3.Location = new System.Drawing.Point(699, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 106);
            this.panel3.TabIndex = 2;
            // 
            // lb_BaoCaoDoanhSo
            // 
            this.lb_BaoCaoDoanhSo.AutoSize = true;
            this.lb_BaoCaoDoanhSo.Font = new System.Drawing.Font("Futura", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_BaoCaoDoanhSo.ForeColor = System.Drawing.Color.White;
            this.lb_BaoCaoDoanhSo.Location = new System.Drawing.Point(4, 64);
            this.lb_BaoCaoDoanhSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BaoCaoDoanhSo.Name = "lb_BaoCaoDoanhSo";
            this.lb_BaoCaoDoanhSo.Size = new System.Drawing.Size(99, 22);
            this.lb_BaoCaoDoanhSo.TabIndex = 3;
            this.lb_BaoCaoDoanhSo.Text = "Doanh Số:";
            // 
            // lb_BaoCaoHoaDon
            // 
            this.lb_BaoCaoHoaDon.AutoSize = true;
            this.lb_BaoCaoHoaDon.Font = new System.Drawing.Font("Futura", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_BaoCaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.lb_BaoCaoHoaDon.Location = new System.Drawing.Point(-4, 27);
            this.lb_BaoCaoHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BaoCaoHoaDon.Name = "lb_BaoCaoHoaDon";
            this.lb_BaoCaoHoaDon.Size = new System.Drawing.Size(97, 22);
            this.lb_BaoCaoHoaDon.TabIndex = 2;
            this.lb_BaoCaoHoaDon.Text = " Hóa Đơn:";
            // 
            // lb_BaoCaoTrongNgay
            // 
            this.lb_BaoCaoTrongNgay.AutoSize = true;
            this.lb_BaoCaoTrongNgay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_BaoCaoTrongNgay.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BaoCaoTrongNgay.ForeColor = System.Drawing.Color.White;
            this.lb_BaoCaoTrongNgay.Location = new System.Drawing.Point(28, 0);
            this.lb_BaoCaoTrongNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BaoCaoTrongNgay.Name = "lb_BaoCaoTrongNgay";
            this.lb_BaoCaoTrongNgay.Size = new System.Drawing.Size(208, 28);
            this.lb_BaoCaoTrongNgay.TabIndex = 1;
            this.lb_BaoCaoTrongNgay.Text = "Báo Cáo Trong Ngày";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.lb_CanhBaoHetHang);
            this.panel4.Controls.Add(this.lb_CanhBaoHangHetHan);
            this.panel4.Controls.Add(this.lb_CanhBao);
            this.panel4.Location = new System.Drawing.Point(1011, 48);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 106);
            this.panel4.TabIndex = 2;
            // 
            // lb_CanhBaoHetHang
            // 
            this.lb_CanhBaoHetHang.AutoSize = true;
            this.lb_CanhBaoHetHang.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CanhBaoHetHang.ForeColor = System.Drawing.Color.White;
            this.lb_CanhBaoHetHang.Location = new System.Drawing.Point(4, 64);
            this.lb_CanhBaoHetHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CanhBaoHetHang.Name = "lb_CanhBaoHetHang";
            this.lb_CanhBaoHetHang.Size = new System.Drawing.Size(123, 24);
            this.lb_CanhBaoHetHang.TabIndex = 3;
            this.lb_CanhBaoHetHang.Text = "Sắp hết hàng:";
            // 
            // lb_CanhBaoHangHetHan
            // 
            this.lb_CanhBaoHangHetHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CanhBaoHangHetHan.AutoSize = true;
            this.lb_CanhBaoHangHetHan.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CanhBaoHangHetHan.ForeColor = System.Drawing.Color.White;
            this.lb_CanhBaoHangHetHan.Location = new System.Drawing.Point(4, 27);
            this.lb_CanhBaoHangHetHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CanhBaoHangHetHan.Name = "lb_CanhBaoHangHetHan";
            this.lb_CanhBaoHangHetHan.Size = new System.Drawing.Size(161, 24);
            this.lb_CanhBaoHangHetHan.TabIndex = 2;
            this.lb_CanhBaoHangHetHan.Text = "Hàng sắp hết hạn:";
            // 
            // lb_CanhBao
            // 
            this.lb_CanhBao.AutoSize = true;
            this.lb_CanhBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
            this.lb_CanhBao.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_CanhBao.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CanhBao.ForeColor = System.Drawing.Color.White;
            this.lb_CanhBao.Location = new System.Drawing.Point(133, 0);
            this.lb_CanhBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CanhBao.Name = "lb_CanhBao";
            this.lb_CanhBao.Size = new System.Drawing.Size(103, 28);
            this.lb_CanhBao.TabIndex = 1;
            this.lb_CanhBao.Text = "Cảnh Báo";
            // 
            // UC_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Overview";
            this.Size = new System.Drawing.Size(1301, 633);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lb_Doanhso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_HoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_BaoCaoTrongNgay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_CanhBao;
        private System.Windows.Forms.Label lb_DoanhSoThangNay;
        private System.Windows.Forms.Label lb_DoanhSoThangTruoc;
        private System.Windows.Forms.Label lb_HoaDonThangNay;
        private System.Windows.Forms.Label lb_HoaDonThangTruoc;
        private System.Windows.Forms.Label lb_BaoCaoDoanhSo;
        private System.Windows.Forms.Label lb_BaoCaoHoaDon;
        private System.Windows.Forms.Label lb_CanhBaoHetHang;
        private System.Windows.Forms.Label lb_CanhBaoHangHetHan;
    }
}

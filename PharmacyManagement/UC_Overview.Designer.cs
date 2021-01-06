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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_DoanhSoThangNayView = new System.Windows.Forms.Label();
            this.lb_DoanhSoThangTruocView = new System.Windows.Forms.Label();
            this.lb_Doanhso = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_HoaDonThangNayView = new System.Windows.Forms.Label();
            this.lb_HoaDonThangTruocView = new System.Windows.Forms.Label();
            this.lb_HoaDon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_BaoCaoDoanhSoView = new System.Windows.Forms.Label();
            this.lb_BaoCaoHoaDonView = new System.Windows.Forms.Label();
            this.lb_BaoCaoTrongNgay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_CanhBaoHangHetHanView = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_CanhBao = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.C_Overview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.C_Overview2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_Overview = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_Overview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Overview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Overview)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(121)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.lb_DoanhSoThangNayView);
            this.panel1.Controls.Add(this.lb_DoanhSoThangTruocView);
            this.panel1.Controls.Add(this.lb_Doanhso);
            this.panel1.Location = new System.Drawing.Point(25, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 125);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_DoanhSoThangNayView
            // 
            this.lb_DoanhSoThangNayView.AutoSize = true;
            this.lb_DoanhSoThangNayView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DoanhSoThangNayView.ForeColor = System.Drawing.Color.White;
            this.lb_DoanhSoThangNayView.Location = new System.Drawing.Point(10, 80);
            this.lb_DoanhSoThangNayView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DoanhSoThangNayView.Name = "lb_DoanhSoThangNayView";
            this.lb_DoanhSoThangNayView.Size = new System.Drawing.Size(116, 22);
            this.lb_DoanhSoThangNayView.TabIndex = 2;
            this.lb_DoanhSoThangNayView.Text = "Tháng này:";
            this.lb_DoanhSoThangNayView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_DoanhSoThangTruocView
            // 
            this.lb_DoanhSoThangTruocView.AutoSize = true;
            this.lb_DoanhSoThangTruocView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DoanhSoThangTruocView.ForeColor = System.Drawing.Color.White;
            this.lb_DoanhSoThangTruocView.Location = new System.Drawing.Point(10, 45);
            this.lb_DoanhSoThangTruocView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DoanhSoThangTruocView.Name = "lb_DoanhSoThangTruocView";
            this.lb_DoanhSoThangTruocView.Size = new System.Drawing.Size(135, 22);
            this.lb_DoanhSoThangTruocView.TabIndex = 1;
            this.lb_DoanhSoThangTruocView.Text = "Tháng trước:";
            this.lb_DoanhSoThangTruocView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_DoanhSoThangTruocView.Click += new System.EventHandler(this.lb_DoanhSoThangTruocView_Click);
            // 
            // lb_Doanhso
            // 
            this.lb_Doanhso.AutoSize = true;
            this.lb_Doanhso.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Doanhso.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Doanhso.ForeColor = System.Drawing.Color.White;
            this.lb_Doanhso.Location = new System.Drawing.Point(260, 0);
            this.lb_Doanhso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Doanhso.Name = "lb_Doanhso";
            this.lb_Doanhso.Size = new System.Drawing.Size(140, 29);
            this.lb_Doanhso.TabIndex = 0;
            this.lb_Doanhso.Text = "DOANH SỐ";
            this.lb_Doanhso.Click += new System.EventHandler(this.lb_Doanhso_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.lb_HoaDonThangNayView);
            this.panel2.Controls.Add(this.lb_HoaDonThangTruocView);
            this.panel2.Controls.Add(this.lb_HoaDon);
            this.panel2.Location = new System.Drawing.Point(450, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 125);
            this.panel2.TabIndex = 2;
            // 
            // lb_HoaDonThangNayView
            // 
            this.lb_HoaDonThangNayView.AutoSize = true;
            this.lb_HoaDonThangNayView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoaDonThangNayView.ForeColor = System.Drawing.Color.White;
            this.lb_HoaDonThangNayView.Location = new System.Drawing.Point(10, 80);
            this.lb_HoaDonThangNayView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HoaDonThangNayView.Name = "lb_HoaDonThangNayView";
            this.lb_HoaDonThangNayView.Size = new System.Drawing.Size(116, 22);
            this.lb_HoaDonThangNayView.TabIndex = 3;
            this.lb_HoaDonThangNayView.Text = "Tháng này:";
            this.lb_HoaDonThangNayView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_HoaDonThangTruocView
            // 
            this.lb_HoaDonThangTruocView.AutoSize = true;
            this.lb_HoaDonThangTruocView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoaDonThangTruocView.ForeColor = System.Drawing.Color.White;
            this.lb_HoaDonThangTruocView.Location = new System.Drawing.Point(10, 45);
            this.lb_HoaDonThangTruocView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HoaDonThangTruocView.Name = "lb_HoaDonThangTruocView";
            this.lb_HoaDonThangTruocView.Size = new System.Drawing.Size(135, 22);
            this.lb_HoaDonThangTruocView.TabIndex = 2;
            this.lb_HoaDonThangTruocView.Text = "Tháng trước:";
            this.lb_HoaDonThangTruocView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_HoaDon
            // 
            this.lb_HoaDon.AutoSize = true;
            this.lb_HoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_HoaDon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoaDon.ForeColor = System.Drawing.Color.White;
            this.lb_HoaDon.Location = new System.Drawing.Point(275, 0);
            this.lb_HoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HoaDon.Name = "lb_HoaDon";
            this.lb_HoaDon.Size = new System.Drawing.Size(125, 29);
            this.lb_HoaDon.TabIndex = 1;
            this.lb_HoaDon.Text = "HÓA ĐƠN";
            this.lb_HoaDon.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(173)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.lb_BaoCaoDoanhSoView);
            this.panel3.Controls.Add(this.lb_BaoCaoHoaDonView);
            this.panel3.Controls.Add(this.lb_BaoCaoTrongNgay);
            this.panel3.Location = new System.Drawing.Point(875, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 125);
            this.panel3.TabIndex = 2;
            // 
            // lb_BaoCaoDoanhSoView
            // 
            this.lb_BaoCaoDoanhSoView.AutoSize = true;
            this.lb_BaoCaoDoanhSoView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BaoCaoDoanhSoView.ForeColor = System.Drawing.Color.White;
            this.lb_BaoCaoDoanhSoView.Location = new System.Drawing.Point(10, 80);
            this.lb_BaoCaoDoanhSoView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BaoCaoDoanhSoView.Name = "lb_BaoCaoDoanhSoView";
            this.lb_BaoCaoDoanhSoView.Size = new System.Drawing.Size(108, 22);
            this.lb_BaoCaoDoanhSoView.TabIndex = 3;
            this.lb_BaoCaoDoanhSoView.Text = "Doanh Số:";
            this.lb_BaoCaoDoanhSoView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BaoCaoHoaDonView
            // 
            this.lb_BaoCaoHoaDonView.AutoSize = true;
            this.lb_BaoCaoHoaDonView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BaoCaoHoaDonView.ForeColor = System.Drawing.Color.White;
            this.lb_BaoCaoHoaDonView.Location = new System.Drawing.Point(10, 45);
            this.lb_BaoCaoHoaDonView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BaoCaoHoaDonView.Name = "lb_BaoCaoHoaDonView";
            this.lb_BaoCaoHoaDonView.Size = new System.Drawing.Size(103, 22);
            this.lb_BaoCaoHoaDonView.TabIndex = 2;
            this.lb_BaoCaoHoaDonView.Text = " Hóa Đơn:";
            this.lb_BaoCaoHoaDonView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_BaoCaoTrongNgay
            // 
            this.lb_BaoCaoTrongNgay.AutoSize = true;
            this.lb_BaoCaoTrongNgay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_BaoCaoTrongNgay.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BaoCaoTrongNgay.ForeColor = System.Drawing.Color.White;
            this.lb_BaoCaoTrongNgay.Location = new System.Drawing.Point(150, 0);
            this.lb_BaoCaoTrongNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BaoCaoTrongNgay.Name = "lb_BaoCaoTrongNgay";
            this.lb_BaoCaoTrongNgay.Size = new System.Drawing.Size(250, 29);
            this.lb_BaoCaoTrongNgay.TabIndex = 1;
            this.lb_BaoCaoTrongNgay.Text = "Báo Cáo Trong Ngày";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.lb_CanhBaoHangHetHanView);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lb_CanhBao);
            this.panel4.Location = new System.Drawing.Point(1300, 50);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 125);
            this.panel4.TabIndex = 2;
            // 
            // lb_CanhBaoHangHetHanView
            // 
            this.lb_CanhBaoHangHetHanView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CanhBaoHangHetHanView.AutoSize = true;
            this.lb_CanhBaoHangHetHanView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CanhBaoHangHetHanView.ForeColor = System.Drawing.Color.White;
            this.lb_CanhBaoHangHetHanView.Location = new System.Drawing.Point(10, 45);
            this.lb_CanhBaoHangHetHanView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CanhBaoHangHetHanView.Name = "lb_CanhBaoHangHetHanView";
            this.lb_CanhBaoHangHetHanView.Size = new System.Drawing.Size(206, 22);
            this.lb_CanhBaoHangHetHanView.TabIndex = 5;
            this.lb_CanhBaoHangHetHanView.Text = "Hàng sắp hết hạng: 0";
            this.lb_CanhBaoHangHetHanView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sắp hết hàng: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_CanhBao
            // 
            this.lb_CanhBao.AutoSize = true;
            this.lb_CanhBao.BackColor = System.Drawing.Color.Transparent;
            this.lb_CanhBao.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_CanhBao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CanhBao.ForeColor = System.Drawing.Color.White;
            this.lb_CanhBao.Location = new System.Drawing.Point(260, 0);
            this.lb_CanhBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CanhBao.Name = "lb_CanhBao";
            this.lb_CanhBao.Size = new System.Drawing.Size(140, 29);
            this.lb_CanhBao.TabIndex = 1;
            this.lb_CanhBao.Text = "CẢNH BÁO";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Controls.Add(this.C_Overview2);
            this.panel5.Controls.Add(this.C_Overview);
            this.panel5.Location = new System.Drawing.Point(25, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1250, 800);
            this.panel5.TabIndex = 6;
            // 
            // C_Overview
            // 
            this.C_Overview.BorderlineColor = System.Drawing.Color.Transparent;
            this.C_Overview.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.C_Overview.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.C_Overview.Legends.Add(legend2);
            this.C_Overview.Location = new System.Drawing.Point(5, 450);
            this.C_Overview.Margin = new System.Windows.Forms.Padding(5);
            this.C_Overview.Name = "C_Overview";
            this.C_Overview.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.C_Overview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu";
            this.C_Overview.Series.Add(series2);
            this.C_Overview.Size = new System.Drawing.Size(1240, 350);
            this.C_Overview.TabIndex = 7;
            this.C_Overview.Text = "chart1";
            // 
            // C_Overview2
            // 
            this.C_Overview2.BackColor = System.Drawing.Color.Transparent;
            this.C_Overview2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.C_Overview2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.C_Overview2.Legends.Add(legend1);
            this.C_Overview2.Location = new System.Drawing.Point(5, 5);
            this.C_Overview2.Margin = new System.Windows.Forms.Padding(5);
            this.C_Overview2.Name = "C_Overview2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Hoa Don";
            this.C_Overview2.Series.Add(series1);
            this.C_Overview2.Size = new System.Drawing.Size(1240, 435);
            this.C_Overview2.TabIndex = 7;
            this.C_Overview2.Text = "chart1";
            // 
            // TB_Overview
            // 
            this.TB_Overview.BackgroundColor = System.Drawing.Color.White;
            this.TB_Overview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TB_Overview.Location = new System.Drawing.Point(1836, 593);
            this.TB_Overview.Name = "TB_Overview";
            this.TB_Overview.RowHeadersWidth = 51;
            this.TB_Overview.RowTemplate.Height = 24;
            this.TB_Overview.Size = new System.Drawing.Size(22, 17);
            this.TB_Overview.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(1300, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 800);
            this.panel6.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(525, 283);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(58, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH HÀNG HẾT HẠN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(350, 700);
            this.dataGridView1.TabIndex = 1;
            // 
            // UC_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TB_Overview);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Overview";
            this.Size = new System.Drawing.Size(1861, 1020);
            this.Load += new System.EventHandler(this.UC_Overview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C_Overview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Overview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Overview)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Doanhso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_HoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_BaoCaoTrongNgay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_CanhBao;
        private System.Windows.Forms.Label lb_DoanhSoThangNayView;
        private System.Windows.Forms.Label lb_DoanhSoThangTruocView;
        private System.Windows.Forms.Label lb_HoaDonThangNayView;
        private System.Windows.Forms.Label lb_HoaDonThangTruocView;
        private System.Windows.Forms.Label lb_BaoCaoDoanhSoView;
        private System.Windows.Forms.Label lb_BaoCaoHoaDonView;
        private System.Windows.Forms.Label lb_CanhBaoHangHetHanView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart C_Overview2;
        private System.Windows.Forms.DataVisualization.Charting.Chart C_Overview;
        private System.Windows.Forms.DataGridView TB_Overview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}

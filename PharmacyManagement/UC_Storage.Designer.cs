namespace PharmacyManagement
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
            this.btn_Import = new System.Windows.Forms.Button();
            this.dgv_Thuoc = new System.Windows.Forms.DataGridView();
            this.lbl_FromDate = new System.Windows.Forms.Label();
            this.lbl_ToDate = new System.Windows.Forms.Label();
            this.lbl_StorageProductType = new System.Windows.Forms.Label();
            this.txt_StorageSearch = new System.Windows.Forms.TextBox();
            this.lbl_StorageSearchBox = new System.Windows.Forms.Label();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.cb_StorageProductType = new System.Windows.Forms.ComboBox();
            this.cb_StorageProductGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_StorageManagement = new System.Windows.Forms.Button();
            this.uC_Import1 = new PharmacyManagement.UC_Import();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Import.Location = new System.Drawing.Point(269, 21);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(173, 52);
            this.btn_Import.TabIndex = 1;
            this.btn_Import.Text = "Nhập Hàng";
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // dgv_Thuoc
            // 
            this.dgv_Thuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Thuoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Thuoc.Location = new System.Drawing.Point(28, 260);
            this.dgv_Thuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Thuoc.Name = "dgv_Thuoc";
            this.dgv_Thuoc.ReadOnly = true;
            this.dgv_Thuoc.RowHeadersWidth = 51;
            this.dgv_Thuoc.ShowRowErrors = false;
            this.dgv_Thuoc.Size = new System.Drawing.Size(1239, 357);
            this.dgv_Thuoc.TabIndex = 0;
            this.dgv_Thuoc.TabStop = false;
            this.dgv_Thuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Thuoc_CellContentClick);
            // 
            // lbl_FromDate
            // 
            this.lbl_FromDate.AutoSize = true;
            this.lbl_FromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FromDate.Location = new System.Drawing.Point(24, 102);
            this.lbl_FromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FromDate.Name = "lbl_FromDate";
            this.lbl_FromDate.Size = new System.Drawing.Size(89, 23);
            this.lbl_FromDate.TabIndex = 3;
            this.lbl_FromDate.Text = "Từ ngày:";
            // 
            // lbl_ToDate
            // 
            this.lbl_ToDate.AutoSize = true;
            this.lbl_ToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToDate.Location = new System.Drawing.Point(344, 102);
            this.lbl_ToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ToDate.Name = "lbl_ToDate";
            this.lbl_ToDate.Size = new System.Drawing.Size(93, 23);
            this.lbl_ToDate.TabIndex = 5;
            this.lbl_ToDate.Text = "Đến ngày";
            // 
            // lbl_StorageProductType
            // 
            this.lbl_StorageProductType.AutoSize = true;
            this.lbl_StorageProductType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StorageProductType.Location = new System.Drawing.Point(661, 102);
            this.lbl_StorageProductType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StorageProductType.Name = "lbl_StorageProductType";
            this.lbl_StorageProductType.Size = new System.Drawing.Size(139, 23);
            this.lbl_StorageProductType.TabIndex = 7;
            this.lbl_StorageProductType.Text = "Loại hàng hóa:";
            // 
            // txt_StorageSearch
            // 
            this.txt_StorageSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StorageSearch.Location = new System.Drawing.Point(28, 207);
            this.txt_StorageSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_StorageSearch.Name = "txt_StorageSearch";
            this.txt_StorageSearch.Size = new System.Drawing.Size(1237, 30);
            this.txt_StorageSearch.TabIndex = 9;
            this.txt_StorageSearch.TextChanged += new System.EventHandler(this.txt_StorageSearch_TextChanged);
            // 
            // lbl_StorageSearchBox
            // 
            this.lbl_StorageSearchBox.AutoSize = true;
            this.lbl_StorageSearchBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StorageSearchBox.Location = new System.Drawing.Point(24, 180);
            this.lbl_StorageSearchBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StorageSearchBox.Name = "lbl_StorageSearchBox";
            this.lbl_StorageSearchBox.Size = new System.Drawing.Size(340, 23);
            this.lbl_StorageSearchBox.TabIndex = 10;
            this.lbl_StorageSearchBox.Text = "Tìm kiếm theo tên hoặc mã sản phẩm";
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FromDate.Location = new System.Drawing.Point(28, 128);
            this.dtp_FromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(285, 30);
            this.dtp_FromDate.TabIndex = 10;
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ToDate.Location = new System.Drawing.Point(348, 128);
            this.dtp_ToDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(285, 30);
            this.dtp_ToDate.TabIndex = 12;
            // 
            // cb_StorageProductType
            // 
            this.cb_StorageProductType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_StorageProductType.FormattingEnabled = true;
            this.cb_StorageProductType.Location = new System.Drawing.Point(665, 128);
            this.cb_StorageProductType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_StorageProductType.Name = "cb_StorageProductType";
            this.cb_StorageProductType.Size = new System.Drawing.Size(285, 31);
            this.cb_StorageProductType.TabIndex = 16;
            this.cb_StorageProductType.SelectedIndexChanged += new System.EventHandler(this.cb_StorageProductType_SelectedIndexChanged);
            // 
            // cb_StorageProductGroup
            // 
            this.cb_StorageProductGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_StorageProductGroup.FormattingEnabled = true;
            this.cb_StorageProductGroup.Location = new System.Drawing.Point(980, 128);
            this.cb_StorageProductGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_StorageProductGroup.Name = "cb_StorageProductGroup";
            this.cb_StorageProductGroup.Size = new System.Drawing.Size(285, 31);
            this.cb_StorageProductGroup.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(976, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nhóm hàng:";
            // 
            // btn_StorageManagement
            // 
            this.btn_StorageManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StorageManagement.FlatAppearance.BorderSize = 0;
            this.btn_StorageManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_StorageManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StorageManagement.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StorageManagement.ForeColor = System.Drawing.Color.White;
            this.btn_StorageManagement.Location = new System.Drawing.Point(28, 21);
            this.btn_StorageManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_StorageManagement.Name = "btn_StorageManagement";
            this.btn_StorageManagement.Size = new System.Drawing.Size(173, 52);
            this.btn_StorageManagement.TabIndex = 20;
            this.btn_StorageManagement.Text = "Tồn kho";
            this.btn_StorageManagement.UseVisualStyleBackColor = false;
            this.btn_StorageManagement.Click += new System.EventHandler(this.btn_StorageManagement_Click);
            // 
            // uC_Import1
            // 
            this.uC_Import1.Location = new System.Drawing.Point(133, 297);
            this.uC_Import1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Import1.Name = "uC_Import1";
            this.uC_Import1.Size = new System.Drawing.Size(1263, 690);
            this.uC_Import1.TabIndex = 21;
            this.uC_Import1.Visible = false;
            // 
            // UC_Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_Import1);
            this.Controls.Add(this.btn_StorageManagement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_StorageProductGroup);
            this.Controls.Add(this.cb_StorageProductType);
            this.Controls.Add(this.dgv_Thuoc);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.lbl_StorageSearchBox);
            this.Controls.Add(this.txt_StorageSearch);
            this.Controls.Add(this.lbl_StorageProductType);
            this.Controls.Add(this.lbl_ToDate);
            this.Controls.Add(this.lbl_FromDate);
            this.Controls.Add(this.btn_Import);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Storage";
            this.Size = new System.Drawing.Size(1295, 777);
            this.Load += new System.EventHandler(this.UC_Storage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.DataGridView dgv_Thuoc;
        private System.Windows.Forms.Label lbl_FromDate;
        private System.Windows.Forms.Label lbl_ToDate;
        private System.Windows.Forms.Label lbl_StorageProductType;
        private System.Windows.Forms.TextBox txt_StorageSearch;
        private System.Windows.Forms.Label lbl_StorageSearchBox;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.ComboBox cb_StorageProductType;
        private System.Windows.Forms.ComboBox cb_StorageProductGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_StorageManagement;
        private UC_Import uC_Import1;
    }
}

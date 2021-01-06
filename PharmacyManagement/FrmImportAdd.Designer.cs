namespace PharmacyManagement
{
    partial class FrmImportAdd
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
            this.dtp_ImportAddDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_FromDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_ImportAddID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ImportAddDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_ImportAddSum = new System.Windows.Forms.TextBox();
            this.lbl_ImportSearchBox = new System.Windows.Forms.Label();
            this.txt_ImportAddProvider = new System.Windows.Forms.TextBox();
            this.dgv_ImportAddProductList = new System.Windows.Forms.DataGridView();
            this.btn_ImportAddSave = new System.Windows.Forms.Button();
            this.btn_ImportAddReturn = new System.Windows.Forms.Button();
            this.cb_ImportAddProductSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_ImportAddNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_ImportAddStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_ImportAddVAT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_ImportAddTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImportAddProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ImportAddDate
            // 
            this.dtp_ImportAddDate.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportAddDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ImportAddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ImportAddDate.Location = new System.Drawing.Point(480, 42);
            this.dtp_ImportAddDate.Name = "dtp_ImportAddDate";
            this.dtp_ImportAddDate.Size = new System.Drawing.Size(182, 26);
            this.dtp_ImportAddDate.TabIndex = 74;
            // 
            // lbl_FromDate
            // 
            this.lbl_FromDate.AutoSize = true;
            this.lbl_FromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FromDate.Location = new System.Drawing.Point(477, 21);
            this.lbl_FromDate.Name = "lbl_FromDate";
            this.lbl_FromDate.Size = new System.Drawing.Size(86, 18);
            this.lbl_FromDate.TabIndex = 73;
            this.lbl_FromDate.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Mã phiếu nhập:";
            // 
            // txb_ImportAddID
            // 
            this.txb_ImportAddID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ImportAddID.Location = new System.Drawing.Point(245, 42);
            this.txb_ImportAddID.Name = "txb_ImportAddID";
            this.txb_ImportAddID.Size = new System.Drawing.Size(179, 26);
            this.txb_ImportAddID.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tổng giảm giá:";
            // 
            // txb_ImportAddDiscount
            // 
            this.txb_ImportAddDiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ImportAddDiscount.Location = new System.Drawing.Point(245, 115);
            this.txb_ImportAddDiscount.Name = "txb_ImportAddDiscount";
            this.txb_ImportAddDiscount.Size = new System.Drawing.Size(179, 26);
            this.txb_ImportAddDiscount.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tổng tiền:";
            // 
            // txb_ImportAddSum
            // 
            this.txb_ImportAddSum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ImportAddSum.Location = new System.Drawing.Point(15, 115);
            this.txb_ImportAddSum.Name = "txb_ImportAddSum";
            this.txb_ImportAddSum.Size = new System.Drawing.Size(179, 26);
            this.txb_ImportAddSum.TabIndex = 67;
            // 
            // lbl_ImportSearchBox
            // 
            this.lbl_ImportSearchBox.AutoSize = true;
            this.lbl_ImportSearchBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImportSearchBox.Location = new System.Drawing.Point(12, 21);
            this.lbl_ImportSearchBox.Name = "lbl_ImportSearchBox";
            this.lbl_ImportSearchBox.Size = new System.Drawing.Size(107, 18);
            this.lbl_ImportSearchBox.TabIndex = 66;
            this.lbl_ImportSearchBox.Text = "Nhà cung cấp:";
            // 
            // txt_ImportAddProvider
            // 
            this.txt_ImportAddProvider.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImportAddProvider.Location = new System.Drawing.Point(15, 42);
            this.txt_ImportAddProvider.Name = "txt_ImportAddProvider";
            this.txt_ImportAddProvider.Size = new System.Drawing.Size(179, 26);
            this.txt_ImportAddProvider.TabIndex = 65;
            // 
            // dgv_ImportAddProductList
            // 
            this.dgv_ImportAddProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ImportAddProductList.Location = new System.Drawing.Point(12, 278);
            this.dgv_ImportAddProductList.Name = "dgv_ImportAddProductList";
            this.dgv_ImportAddProductList.Size = new System.Drawing.Size(888, 150);
            this.dgv_ImportAddProductList.TabIndex = 75;
            // 
            // btn_ImportAddSave
            // 
            this.btn_ImportAddSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ImportAddSave.FlatAppearance.BorderSize = 0;
            this.btn_ImportAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_ImportAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportAddSave.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportAddSave.ForeColor = System.Drawing.Color.White;
            this.btn_ImportAddSave.Location = new System.Drawing.Point(571, 457);
            this.btn_ImportAddSave.Name = "btn_ImportAddSave";
            this.btn_ImportAddSave.Size = new System.Drawing.Size(157, 42);
            this.btn_ImportAddSave.TabIndex = 76;
            this.btn_ImportAddSave.Text = "Lưu";
            this.btn_ImportAddSave.UseVisualStyleBackColor = false;
            // 
            // btn_ImportAddReturn
            // 
            this.btn_ImportAddReturn.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ImportAddReturn.FlatAppearance.BorderSize = 0;
            this.btn_ImportAddReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_ImportAddReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportAddReturn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportAddReturn.ForeColor = System.Drawing.Color.White;
            this.btn_ImportAddReturn.Location = new System.Drawing.Point(743, 457);
            this.btn_ImportAddReturn.Name = "btn_ImportAddReturn";
            this.btn_ImportAddReturn.Size = new System.Drawing.Size(157, 42);
            this.btn_ImportAddReturn.TabIndex = 77;
            this.btn_ImportAddReturn.Text = "Trở lại";
            this.btn_ImportAddReturn.UseVisualStyleBackColor = false;
            this.btn_ImportAddReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_ImportAddProductSelect
            // 
            this.cb_ImportAddProductSelect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ImportAddProductSelect.FormattingEnabled = true;
            this.cb_ImportAddProductSelect.Location = new System.Drawing.Point(15, 243);
            this.cb_ImportAddProductSelect.Name = "cb_ImportAddProductSelect";
            this.cb_ImportAddProductSelect.Size = new System.Drawing.Size(885, 26);
            this.cb_ImportAddProductSelect.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tên sản phẩm hoặc mã sản phẩm:";
            // 
            // txb_ImportAddNote
            // 
            this.txb_ImportAddNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ImportAddNote.Location = new System.Drawing.Point(15, 184);
            this.txb_ImportAddNote.Name = "txb_ImportAddNote";
            this.txb_ImportAddNote.Size = new System.Drawing.Size(885, 26);
            this.txb_ImportAddNote.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "Ghi chú:";
            // 
            // cb_ImportAddStatus
            // 
            this.cb_ImportAddStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ImportAddStatus.FormattingEnabled = true;
            this.cb_ImportAddStatus.Location = new System.Drawing.Point(721, 42);
            this.cb_ImportAddStatus.Name = "cb_ImportAddStatus";
            this.cb_ImportAddStatus.Size = new System.Drawing.Size(179, 26);
            this.cb_ImportAddStatus.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(718, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 83;
            this.label6.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 85;
            this.label7.Text = "VAT:";
            // 
            // txb_ImportAddVAT
            // 
            this.txb_ImportAddVAT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ImportAddVAT.Location = new System.Drawing.Point(480, 115);
            this.txb_ImportAddVAT.Name = "txb_ImportAddVAT";
            this.txb_ImportAddVAT.Size = new System.Drawing.Size(182, 26);
            this.txb_ImportAddVAT.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(718, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 87;
            this.label8.Text = "Thành tiền:";
            // 
            // txb_ImportAddTotal
            // 
            this.txb_ImportAddTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ImportAddTotal.Location = new System.Drawing.Point(721, 115);
            this.txb_ImportAddTotal.Name = "txb_ImportAddTotal";
            this.txb_ImportAddTotal.Size = new System.Drawing.Size(179, 26);
            this.txb_ImportAddTotal.TabIndex = 86;
            // 
            // FrmImportAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 515);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_ImportAddTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_ImportAddVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_ImportAddStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_ImportAddNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_ImportAddProductSelect);
            this.Controls.Add(this.btn_ImportAddReturn);
            this.Controls.Add(this.btn_ImportAddSave);
            this.Controls.Add(this.dgv_ImportAddProductList);
            this.Controls.Add(this.dtp_ImportAddDate);
            this.Controls.Add(this.lbl_FromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_ImportAddID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_ImportAddDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_ImportAddSum);
            this.Controls.Add(this.lbl_ImportSearchBox);
            this.Controls.Add(this.txt_ImportAddProvider);
            this.Name = "FrmImportAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImportAddProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ImportAddDate;
        private System.Windows.Forms.Label lbl_FromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_ImportAddID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ImportAddDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_ImportAddSum;
        private System.Windows.Forms.Label lbl_ImportSearchBox;
        private System.Windows.Forms.TextBox txt_ImportAddProvider;
        private System.Windows.Forms.DataGridView dgv_ImportAddProductList;
        private System.Windows.Forms.Button btn_ImportAddSave;
        private System.Windows.Forms.Button btn_ImportAddReturn;
        private System.Windows.Forms.ComboBox cb_ImportAddProductSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_ImportAddNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_ImportAddStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_ImportAddVAT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_ImportAddTotal;
    }
}
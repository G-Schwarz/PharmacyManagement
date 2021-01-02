namespace PharmacyManagement
{
    partial class FrmIndexAdd
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
            this.components = new System.ComponentModel.Container();
            this.btn_IndexAddCancel = new System.Windows.Forms.Button();
            this.pnl_RecpDetailsBanner = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_IndexAdd = new System.Windows.Forms.Button();
            this.txb_IndexAddPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_IndexAddUnit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_IndexAddOrigin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_IndexAddDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_IndexAddVAT = new System.Windows.Forms.TextBox();
            this.txb_IndexAddProducer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_IndexAddPackage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_IndexAddContents = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_IndexAddIngredients = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_IndexAddProductsID = new System.Windows.Forms.TextBox();
            this.cb_IndexAddProductsGroup = new System.Windows.Forms.ComboBox();
            this.cb_IndexAddProductsType = new System.Windows.Forms.ComboBox();
            this.txb_IndexAddRegisterNo = new System.Windows.Forms.TextBox();
            this.txb_IndexAddProductsName = new System.Windows.Forms.TextBox();
            this.lb_PaymentMethod = new System.Windows.Forms.Label();
            this.lb_Seller = new System.Windows.Forms.Label();
            this.lb_SaleDate = new System.Windows.Forms.Label();
            this.lb_RecptCode = new System.Windows.Forms.Label();
            this.pnl_RecpDetailsBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IndexAddCancel
            // 
            this.btn_IndexAddCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_IndexAddCancel.FlatAppearance.BorderSize = 0;
            this.btn_IndexAddCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_IndexAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IndexAddCancel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IndexAddCancel.ForeColor = System.Drawing.Color.White;
            this.btn_IndexAddCancel.Location = new System.Drawing.Point(341, 434);
            this.btn_IndexAddCancel.Name = "btn_IndexAddCancel";
            this.btn_IndexAddCancel.Size = new System.Drawing.Size(157, 42);
            this.btn_IndexAddCancel.TabIndex = 96;
            this.btn_IndexAddCancel.Text = "Hủy";
            this.btn_IndexAddCancel.UseVisualStyleBackColor = false;
            this.btn_IndexAddCancel.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // pnl_RecpDetailsBanner
            // 
            this.pnl_RecpDetailsBanner.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_RecpDetailsBanner.Controls.Add(this.label1);
            this.pnl_RecpDetailsBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_RecpDetailsBanner.Location = new System.Drawing.Point(0, 0);
            this.pnl_RecpDetailsBanner.Name = "pnl_RecpDetailsBanner";
            this.pnl_RecpDetailsBanner.Size = new System.Drawing.Size(731, 53);
            this.pnl_RecpDetailsBanner.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm mới sản phẩm";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_IndexAdd
            // 
            this.btn_IndexAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_IndexAdd.FlatAppearance.BorderSize = 0;
            this.btn_IndexAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_IndexAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IndexAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IndexAdd.ForeColor = System.Drawing.Color.White;
            this.btn_IndexAdd.Location = new System.Drawing.Point(529, 434);
            this.btn_IndexAdd.Name = "btn_IndexAdd";
            this.btn_IndexAdd.Size = new System.Drawing.Size(157, 42);
            this.btn_IndexAdd.TabIndex = 118;
            this.btn_IndexAdd.Text = "Thêm sản phẩm";
            this.btn_IndexAdd.UseVisualStyleBackColor = false;
            // 
            // txb_IndexAddPrice
            // 
            this.txb_IndexAddPrice.Location = new System.Drawing.Point(258, 330);
            this.txb_IndexAddPrice.Name = "txb_IndexAddPrice";
            this.txb_IndexAddPrice.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddPrice.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 145;
            this.label11.Text = "Giá bán";
            // 
            // cb_IndexAddUnit
            // 
            this.cb_IndexAddUnit.FormattingEnabled = true;
            this.cb_IndexAddUnit.Location = new System.Drawing.Point(36, 330);
            this.cb_IndexAddUnit.Name = "cb_IndexAddUnit";
            this.cb_IndexAddUnit.Size = new System.Drawing.Size(200, 21);
            this.cb_IndexAddUnit.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 143;
            this.label10.Text = "Đơn vị tính";
            // 
            // txb_IndexAddOrigin
            // 
            this.txb_IndexAddOrigin.Location = new System.Drawing.Point(258, 268);
            this.txb_IndexAddOrigin.Name = "txb_IndexAddOrigin";
            this.txb_IndexAddOrigin.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddOrigin.TabIndex = 142;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 141;
            this.label9.Text = "Nước sản xuất";
            // 
            // txb_IndexAddDescription
            // 
            this.txb_IndexAddDescription.Location = new System.Drawing.Point(36, 389);
            this.txb_IndexAddDescription.Name = "txb_IndexAddDescription";
            this.txb_IndexAddDescription.Size = new System.Drawing.Size(650, 20);
            this.txb_IndexAddDescription.TabIndex = 140;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 139;
            this.label8.Text = "Mô tả";
            // 
            // txb_IndexAddVAT
            // 
            this.txb_IndexAddVAT.Location = new System.Drawing.Point(486, 268);
            this.txb_IndexAddVAT.Name = "txb_IndexAddVAT";
            this.txb_IndexAddVAT.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddVAT.TabIndex = 138;
            // 
            // txb_IndexAddProducer
            // 
            this.txb_IndexAddProducer.Location = new System.Drawing.Point(36, 268);
            this.txb_IndexAddProducer.Name = "txb_IndexAddProducer";
            this.txb_IndexAddProducer.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddProducer.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 136;
            this.label6.Text = "VAT(%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 135;
            this.label7.Text = "Hãng sản xuất";
            // 
            // txb_IndexAddPackage
            // 
            this.txb_IndexAddPackage.Location = new System.Drawing.Point(486, 211);
            this.txb_IndexAddPackage.Name = "txb_IndexAddPackage";
            this.txb_IndexAddPackage.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddPackage.TabIndex = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 133;
            this.label5.Text = "Quy cách đóng gói";
            // 
            // txb_IndexAddContents
            // 
            this.txb_IndexAddContents.Location = new System.Drawing.Point(258, 211);
            this.txb_IndexAddContents.Name = "txb_IndexAddContents";
            this.txb_IndexAddContents.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddContents.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 131;
            this.label4.Text = "Hoạt chất";
            // 
            // txb_IndexAddIngredients
            // 
            this.txb_IndexAddIngredients.Location = new System.Drawing.Point(36, 211);
            this.txb_IndexAddIngredients.Name = "txb_IndexAddIngredients";
            this.txb_IndexAddIngredients.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddIngredients.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "Hàm lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 128;
            this.label2.Text = "Nhóm hàng hóa";
            // 
            // txb_IndexAddProductsID
            // 
            this.txb_IndexAddProductsID.Location = new System.Drawing.Point(486, 92);
            this.txb_IndexAddProductsID.Name = "txb_IndexAddProductsID";
            this.txb_IndexAddProductsID.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddProductsID.TabIndex = 127;
            // 
            // cb_IndexAddProductsGroup
            // 
            this.cb_IndexAddProductsGroup.FormattingEnabled = true;
            this.cb_IndexAddProductsGroup.Location = new System.Drawing.Point(258, 150);
            this.cb_IndexAddProductsGroup.Name = "cb_IndexAddProductsGroup";
            this.cb_IndexAddProductsGroup.Size = new System.Drawing.Size(200, 21);
            this.cb_IndexAddProductsGroup.TabIndex = 126;
            // 
            // cb_IndexAddProductsType
            // 
            this.cb_IndexAddProductsType.FormattingEnabled = true;
            this.cb_IndexAddProductsType.Location = new System.Drawing.Point(36, 150);
            this.cb_IndexAddProductsType.Name = "cb_IndexAddProductsType";
            this.cb_IndexAddProductsType.Size = new System.Drawing.Size(200, 21);
            this.cb_IndexAddProductsType.TabIndex = 124;
            // 
            // txb_IndexAddRegisterNo
            // 
            this.txb_IndexAddRegisterNo.Location = new System.Drawing.Point(486, 151);
            this.txb_IndexAddRegisterNo.Name = "txb_IndexAddRegisterNo";
            this.txb_IndexAddRegisterNo.Size = new System.Drawing.Size(200, 20);
            this.txb_IndexAddRegisterNo.TabIndex = 125;
            // 
            // txb_IndexAddProductsName
            // 
            this.txb_IndexAddProductsName.Location = new System.Drawing.Point(36, 92);
            this.txb_IndexAddProductsName.Name = "txb_IndexAddProductsName";
            this.txb_IndexAddProductsName.Size = new System.Drawing.Size(422, 20);
            this.txb_IndexAddProductsName.TabIndex = 123;
            // 
            // lb_PaymentMethod
            // 
            this.lb_PaymentMethod.AutoSize = true;
            this.lb_PaymentMethod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PaymentMethod.Location = new System.Drawing.Point(33, 131);
            this.lb_PaymentMethod.Name = "lb_PaymentMethod";
            this.lb_PaymentMethod.Size = new System.Drawing.Size(100, 16);
            this.lb_PaymentMethod.TabIndex = 122;
            this.lb_PaymentMethod.Text = "Loại hàng hóa";
            // 
            // lb_Seller
            // 
            this.lb_Seller.AutoSize = true;
            this.lb_Seller.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Seller.Location = new System.Drawing.Point(483, 131);
            this.lb_Seller.Name = "lb_Seller";
            this.lb_Seller.Size = new System.Drawing.Size(79, 16);
            this.lb_Seller.TabIndex = 121;
            this.lb_Seller.Text = "Số đăng ký";
            // 
            // lb_SaleDate
            // 
            this.lb_SaleDate.AutoSize = true;
            this.lb_SaleDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SaleDate.Location = new System.Drawing.Point(483, 73);
            this.lb_SaleDate.Name = "lb_SaleDate";
            this.lb_SaleDate.Size = new System.Drawing.Size(93, 16);
            this.lb_SaleDate.TabIndex = 120;
            this.lb_SaleDate.Text = "Mã sản phẩm";
            // 
            // lb_RecptCode
            // 
            this.lb_RecptCode.AutoSize = true;
            this.lb_RecptCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RecptCode.Location = new System.Drawing.Point(33, 74);
            this.lb_RecptCode.Name = "lb_RecptCode";
            this.lb_RecptCode.Size = new System.Drawing.Size(98, 16);
            this.lb_RecptCode.TabIndex = 119;
            this.lb_RecptCode.Text = "Tên sản phẩm";
            // 
            // FrmIndexAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 504);
            this.Controls.Add(this.txb_IndexAddPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_IndexAddUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_IndexAddOrigin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_IndexAddDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_IndexAddVAT);
            this.Controls.Add(this.txb_IndexAddProducer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_IndexAddPackage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_IndexAddContents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_IndexAddIngredients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_IndexAddProductsID);
            this.Controls.Add(this.cb_IndexAddProductsGroup);
            this.Controls.Add(this.cb_IndexAddProductsType);
            this.Controls.Add(this.txb_IndexAddRegisterNo);
            this.Controls.Add(this.txb_IndexAddProductsName);
            this.Controls.Add(this.lb_PaymentMethod);
            this.Controls.Add(this.lb_Seller);
            this.Controls.Add(this.lb_SaleDate);
            this.Controls.Add(this.lb_RecptCode);
            this.Controls.Add(this.btn_IndexAdd);
            this.Controls.Add(this.btn_IndexAddCancel);
            this.Controls.Add(this.pnl_RecpDetailsBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIndexAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIndexAdd";
            this.pnl_RecpDetailsBanner.ResumeLayout(false);
            this.pnl_RecpDetailsBanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_IndexAddCancel;
        private System.Windows.Forms.Panel pnl_RecpDetailsBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_IndexAdd;
        private System.Windows.Forms.TextBox txb_IndexAddPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_IndexAddUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_IndexAddOrigin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_IndexAddDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_IndexAddVAT;
        private System.Windows.Forms.TextBox txb_IndexAddProducer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_IndexAddPackage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_IndexAddContents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_IndexAddIngredients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_IndexAddProductsID;
        private System.Windows.Forms.ComboBox cb_IndexAddProductsGroup;
        private System.Windows.Forms.ComboBox cb_IndexAddProductsType;
        private System.Windows.Forms.TextBox txb_IndexAddRegisterNo;
        private System.Windows.Forms.TextBox txb_IndexAddProductsName;
        private System.Windows.Forms.Label lb_PaymentMethod;
        private System.Windows.Forms.Label lb_Seller;
        private System.Windows.Forms.Label lb_SaleDate;
        private System.Windows.Forms.Label lb_RecptCode;
    }
}
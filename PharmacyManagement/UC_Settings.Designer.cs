namespace PharmacyManagement
{
    partial class UC_Settings
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
            this.components = new System.ComponentModel.Container();
            this.btn_AbtUs = new System.Windows.Forms.Button();
            this.btn_AddAcc = new System.Windows.Forms.Button();
            this.btn_AccManagement = new System.Windows.Forms.Button();
            this.pnl_AccountManagement = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ShowUserName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txb_ShowPassword = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.pnl_AddAcc = new System.Windows.Forms.Panel();
            this.btn_CreateAcc = new System.Windows.Forms.Button();
            this.txb_CreatePassword = new System.Windows.Forms.TextBox();
            this.txb_CreateUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_AccountManagement.SuspendLayout();
            this.pnl_AddAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AbtUs
            // 
            this.btn_AbtUs.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AbtUs.FlatAppearance.BorderSize = 0;
            this.btn_AbtUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AbtUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbtUs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbtUs.ForeColor = System.Drawing.Color.White;
            this.btn_AbtUs.Location = new System.Drawing.Point(23, 15);
            this.btn_AbtUs.Name = "btn_AbtUs";
            this.btn_AbtUs.Size = new System.Drawing.Size(136, 42);
            this.btn_AbtUs.TabIndex = 3;
            this.btn_AbtUs.TabStop = false;
            this.btn_AbtUs.Text = "About us";
            this.btn_AbtUs.UseVisualStyleBackColor = false;
            // 
            // btn_AddAcc
            // 
            this.btn_AddAcc.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AddAcc.FlatAppearance.BorderSize = 0;
            this.btn_AddAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAcc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAcc.ForeColor = System.Drawing.Color.White;
            this.btn_AddAcc.Location = new System.Drawing.Point(395, 15);
            this.btn_AddAcc.Name = "btn_AddAcc";
            this.btn_AddAcc.Size = new System.Drawing.Size(130, 42);
            this.btn_AddAcc.TabIndex = 4;
            this.btn_AddAcc.TabStop = false;
            this.btn_AddAcc.Text = "Thêm tài khoản";
            this.btn_AddAcc.UseVisualStyleBackColor = false;
            this.btn_AddAcc.Click += new System.EventHandler(this.btn_AddAcc_Click);
            // 
            // btn_AccManagement
            // 
            this.btn_AccManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AccManagement.FlatAppearance.BorderSize = 0;
            this.btn_AccManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AccManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccManagement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AccManagement.ForeColor = System.Drawing.Color.White;
            this.btn_AccManagement.Location = new System.Drawing.Point(208, 15);
            this.btn_AccManagement.Name = "btn_AccManagement";
            this.btn_AccManagement.Size = new System.Drawing.Size(141, 42);
            this.btn_AccManagement.TabIndex = 5;
            this.btn_AccManagement.TabStop = false;
            this.btn_AccManagement.Text = "Quản lý tài khoản";
            this.btn_AccManagement.UseVisualStyleBackColor = false;
            this.btn_AccManagement.Click += new System.EventHandler(this.btn_AccManagement_Click);
            // 
            // pnl_AccountManagement
            // 
            this.pnl_AccountManagement.Controls.Add(this.btn_Change);
            this.pnl_AccountManagement.Controls.Add(this.btn_Save);
            this.pnl_AccountManagement.Controls.Add(this.btn_Logout);
            this.pnl_AccountManagement.Controls.Add(this.txb_ShowPassword);
            this.pnl_AccountManagement.Controls.Add(this.txb_ShowUserName);
            this.pnl_AccountManagement.Controls.Add(this.label2);
            this.pnl_AccountManagement.Controls.Add(this.label1);
            this.pnl_AccountManagement.Location = new System.Drawing.Point(3, 63);
            this.pnl_AccountManagement.Name = "pnl_AccountManagement";
            this.pnl_AccountManagement.Size = new System.Drawing.Size(970, 438);
            this.pnl_AccountManagement.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txb_ShowUserName
            // 
            this.txb_ShowUserName.Location = new System.Drawing.Point(34, 121);
            this.txb_ShowUserName.Name = "txb_ShowUserName";
            this.txb_ShowUserName.Size = new System.Drawing.Size(335, 20);
            this.txb_ShowUserName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txb_ShowPassword
            // 
            this.txb_ShowPassword.Location = new System.Drawing.Point(34, 200);
            this.txb_ShowPassword.Name = "txb_ShowPassword";
            this.txb_ShowPassword.Size = new System.Drawing.Size(335, 20);
            this.txb_ShowPassword.TabIndex = 8;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(34, 386);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(141, 37);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Text = "Đăng Xuất";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(228, 266);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 31);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Change.FlatAppearance.BorderSize = 0;
            this.btn_Change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Change.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.ForeColor = System.Drawing.Color.White;
            this.btn_Change.Location = new System.Drawing.Point(34, 266);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(141, 31);
            this.btn_Change.TabIndex = 11;
            this.btn_Change.TabStop = false;
            this.btn_Change.Text = "Thay Đổi";
            this.btn_Change.UseVisualStyleBackColor = false;
            // 
            // pnl_AddAcc
            // 
            this.pnl_AddAcc.Controls.Add(this.txb_ConfirmPassword);
            this.pnl_AddAcc.Controls.Add(this.label5);
            this.pnl_AddAcc.Controls.Add(this.btn_CreateAcc);
            this.pnl_AddAcc.Controls.Add(this.txb_CreatePassword);
            this.pnl_AddAcc.Controls.Add(this.txb_CreateUserName);
            this.pnl_AddAcc.Controls.Add(this.label3);
            this.pnl_AddAcc.Controls.Add(this.label4);
            this.pnl_AddAcc.Location = new System.Drawing.Point(0, 66);
            this.pnl_AddAcc.Name = "pnl_AddAcc";
            this.pnl_AddAcc.Size = new System.Drawing.Size(970, 438);
            this.pnl_AddAcc.TabIndex = 8;
            // 
            // btn_CreateAcc
            // 
            this.btn_CreateAcc.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_CreateAcc.FlatAppearance.BorderSize = 0;
            this.btn_CreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_CreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateAcc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAcc.ForeColor = System.Drawing.Color.White;
            this.btn_CreateAcc.Location = new System.Drawing.Point(34, 325);
            this.btn_CreateAcc.Name = "btn_CreateAcc";
            this.btn_CreateAcc.Size = new System.Drawing.Size(141, 31);
            this.btn_CreateAcc.TabIndex = 11;
            this.btn_CreateAcc.TabStop = false;
            this.btn_CreateAcc.Text = "Tạo";
            this.btn_CreateAcc.UseVisualStyleBackColor = false;
            // 
            // txb_CreatePassword
            // 
            this.txb_CreatePassword.Location = new System.Drawing.Point(34, 187);
            this.txb_CreatePassword.Name = "txb_CreatePassword";
            this.txb_CreatePassword.Size = new System.Drawing.Size(335, 20);
            this.txb_CreatePassword.TabIndex = 8;
            // 
            // txb_CreateUserName
            // 
            this.txb_CreateUserName.Location = new System.Drawing.Point(34, 121);
            this.txb_CreateUserName.Name = "txb_CreateUserName";
            this.txb_CreateUserName.Size = new System.Drawing.Size(335, 20);
            this.txb_CreateUserName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Đăng Nhập";
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(34, 251);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(335, 20);
            this.txb_ConfirmPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập Lại Mật Khẩu";
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_AccountManagement);
            this.Controls.Add(this.pnl_AddAcc);
            this.Controls.Add(this.btn_AccManagement);
            this.Controls.Add(this.btn_AddAcc);
            this.Controls.Add(this.btn_AbtUs);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(976, 514);
            this.pnl_AccountManagement.ResumeLayout(false);
            this.pnl_AccountManagement.PerformLayout();
            this.pnl_AddAcc.ResumeLayout(false);
            this.pnl_AddAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AbtUs;
        private System.Windows.Forms.Button btn_AddAcc;
        private System.Windows.Forms.Button btn_AccManagement;
        private System.Windows.Forms.Panel pnl_AccountManagement;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TextBox txb_ShowPassword;
        private System.Windows.Forms.TextBox txb_ShowUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnl_AddAcc;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CreateAcc;
        private System.Windows.Forms.TextBox txb_CreatePassword;
        private System.Windows.Forms.TextBox txb_CreateUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

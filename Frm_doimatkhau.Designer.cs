namespace DAOVO_QLTC
{
    partial class Frm_doimatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.txt_renewpass = new System.Windows.Forms.TextBox();
            this.btn_doimk = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.ckbShowPwdOld = new System.Windows.Forms.CheckBox();
            this.ckbShowPwdNew = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập lại mật khẩu mới ";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(200, 69);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(195, 20);
            this.txt_taikhoan.TabIndex = 5;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Location = new System.Drawing.Point(200, 108);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.PasswordChar = '*';
            this.txt_oldpass.Size = new System.Drawing.Size(195, 20);
            this.txt_oldpass.TabIndex = 6;
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(200, 153);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.PasswordChar = '*';
            this.txt_newpass.Size = new System.Drawing.Size(195, 20);
            this.txt_newpass.TabIndex = 7;
            // 
            // txt_renewpass
            // 
            this.txt_renewpass.Location = new System.Drawing.Point(200, 190);
            this.txt_renewpass.Name = "txt_renewpass";
            this.txt_renewpass.Size = new System.Drawing.Size(195, 20);
            this.txt_renewpass.TabIndex = 8;
            // 
            // btn_doimk
            // 
            this.btn_doimk.BackColor = System.Drawing.Color.Silver;
            this.btn_doimk.Location = new System.Drawing.Point(71, 262);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(92, 23);
            this.btn_doimk.TabIndex = 9;
            this.btn_doimk.Text = "Đổi mật khẩu ";
            this.btn_doimk.UseVisualStyleBackColor = false;
            this.btn_doimk.Click += new System.EventHandler(this.BtnChangePwdClickEventHandler);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Silver;
            this.btn_thoat.Location = new System.Drawing.Point(269, 262);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát ";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.BtnCloseClickEventHandler);
            // 
            // ckbShowPwdOld
            // 
            this.ckbShowPwdOld.AutoSize = true;
            this.ckbShowPwdOld.BackColor = System.Drawing.Color.Gainsboro;
            this.ckbShowPwdOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowPwdOld.Location = new System.Drawing.Point(401, 108);
            this.ckbShowPwdOld.Name = "ckbShowPwdOld";
            this.ckbShowPwdOld.Size = new System.Drawing.Size(122, 20);
            this.ckbShowPwdOld.TabIndex = 17;
            this.ckbShowPwdOld.Text = "Show password";
            this.ckbShowPwdOld.UseVisualStyleBackColor = false;
            this.ckbShowPwdOld.CheckedChanged += new System.EventHandler(this.ShowPasswordOldChangeEventHandler);
            // 
            // ckbShowPwdNew
            // 
            this.ckbShowPwdNew.AutoSize = true;
            this.ckbShowPwdNew.BackColor = System.Drawing.Color.Gainsboro;
            this.ckbShowPwdNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowPwdNew.Location = new System.Drawing.Point(401, 153);
            this.ckbShowPwdNew.Name = "ckbShowPwdNew";
            this.ckbShowPwdNew.Size = new System.Drawing.Size(122, 20);
            this.ckbShowPwdNew.TabIndex = 18;
            this.ckbShowPwdNew.Text = "Show password";
            this.ckbShowPwdNew.UseVisualStyleBackColor = false;
            this.ckbShowPwdNew.CheckedChanged += new System.EventHandler(this.ShowPasswordNewChangeEventHandler);
            // 
            // Frm_doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(536, 324);
            this.Controls.Add(this.ckbShowPwdNew);
            this.Controls.Add(this.ckbShowPwdOld);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.txt_renewpass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_oldpass);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_doimatkhau";
            this.Text = "HỆ THỐNG QUẢN LÍ THU CHI TRƯỜNG THPT NGUYỄN XUÂN ÔN ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.TextBox txt_renewpass;
        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox ckbShowPwdOld;
        private System.Windows.Forms.CheckBox ckbShowPwdNew;
    }
}
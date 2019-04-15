namespace DAOVO_QLTC
{
    partial class Frm_Lươnggiaovien
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
            this.dgv_lươnggv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.btn_timkiemluong = new System.Windows.Forms.Button();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lươnggv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG LƯƠNG GIÁO VIÊN ";
            // 
            // dgv_lươnggv
            // 
            this.dgv_lươnggv.BackgroundColor = System.Drawing.Color.White;
            this.dgv_lươnggv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lươnggv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magv,
            this.tengv,
            this.ngaysinh,
            this.diachi,
            this.sodt,
            this.maluong,
            this.hsluong,
            this.tongluong});
            this.dgv_lươnggv.Location = new System.Drawing.Point(3, 129);
            this.dgv_lươnggv.Name = "dgv_lươnggv";
            this.dgv_lươnggv.Size = new System.Drawing.Size(822, 273);
            this.dgv_lươnggv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã giáo viên";
            // 
            // txt_magv
            // 
            this.txt_magv.Location = new System.Drawing.Point(502, 93);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(100, 20);
            this.txt_magv.TabIndex = 3;
            // 
            // btn_timkiemluong
            // 
            this.btn_timkiemluong.Location = new System.Drawing.Point(656, 91);
            this.btn_timkiemluong.Name = "btn_timkiemluong";
            this.btn_timkiemluong.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiemluong.TabIndex = 4;
            this.btn_timkiemluong.Text = "Tìm kiếm ";
            this.btn_timkiemluong.UseVisualStyleBackColor = true;
            // 
            // magv
            // 
            this.magv.HeaderText = "Mã giáo viên ";
            this.magv.Name = "magv";
            // 
            // tengv
            // 
            this.tengv.HeaderText = "Tên giáo viên ";
            this.tengv.Name = "tengv";
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ ";
            this.diachi.Name = "diachi";
            // 
            // sodt
            // 
            this.sodt.HeaderText = "Số diện thoại ";
            this.sodt.Name = "sodt";
            // 
            // maluong
            // 
            this.maluong.HeaderText = "Mã lương";
            this.maluong.Name = "maluong";
            // 
            // hsluong
            // 
            this.hsluong.HeaderText = "Hệ số lương";
            this.hsluong.Name = "hsluong";
            // 
            // tongluong
            // 
            this.tongluong.HeaderText = "Tổng lương";
            this.tongluong.Name = "tongluong";
            // 
            // Frm_Lươnggiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(837, 405);
            this.Controls.Add(this.btn_timkiemluong);
            this.Controls.Add(this.txt_magv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_lươnggv);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Lươnggiaovien";
            this.Text = "HỆ THỐNG QUẢN LÍ THU CHI TRƯỜNG THPT NGUYỄN XUÂN ÔN ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lươnggv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_lươnggv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.Button btn_timkiemluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
    }
}
namespace DAOVO_QLTC
{
    partial class Frm_Danhsachhocphi
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
            this.grd_dshp = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_mhs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_timkiemhp = new System.Windows.Forms.Button();
            this.btn_phieuthu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dshp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỌC PHÍ CỦA HỌC SINH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // grd_dshp
            // 
            this.grd_dshp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dshp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSV,
            this.Column1,
            this.ngaysinh,
            this.lop,
            this.mahp,
            this.mamg,
            this.tongtien});
            this.grd_dshp.Location = new System.Drawing.Point(3, 186);
            this.grd_dshp.Name = "grd_dshp";
            this.grd_dshp.Size = new System.Drawing.Size(873, 268);
            this.grd_dshp.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MSV
            // 
            this.MSV.HeaderText = "MSV";
            this.MSV.Name = "MSV";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ Tên ";
            this.Column1.Name = "Column1";
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh ";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp ";
            this.lop.Name = "lop";
            // 
            // mahp
            // 
            this.mahp.HeaderText = "Mã loại học phí ";
            this.mahp.Name = "mahp";
            // 
            // mamg
            // 
            this.mamg.HeaderText = "Mã miễn giảm ";
            this.mamg.Name = "mamg";
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền ";
            this.tongtien.Name = "tongtien";
            // 
            // txt_mhs
            // 
            this.txt_mhs.Location = new System.Drawing.Point(465, 92);
            this.txt_mhs.Name = "txt_mhs";
            this.txt_mhs.Size = new System.Drawing.Size(100, 20);
            this.txt_mhs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã học sinh ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_timkiemhp
            // 
            this.btn_timkiemhp.Location = new System.Drawing.Point(621, 89);
            this.btn_timkiemhp.Name = "btn_timkiemhp";
            this.btn_timkiemhp.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiemhp.TabIndex = 5;
            this.btn_timkiemhp.Text = "Tìm kiếm ";
            this.btn_timkiemhp.UseVisualStyleBackColor = true;
            // 
            // btn_phieuthu
            // 
            this.btn_phieuthu.Location = new System.Drawing.Point(728, 89);
            this.btn_phieuthu.Name = "btn_phieuthu";
            this.btn_phieuthu.Size = new System.Drawing.Size(75, 23);
            this.btn_phieuthu.TabIndex = 6;
            this.btn_phieuthu.Text = "Phiếu thu";
            this.btn_phieuthu.UseVisualStyleBackColor = true;
            // 
            // Frm_Thuhocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(902, 466);
            this.Controls.Add(this.btn_phieuthu);
            this.Controls.Add(this.btn_timkiemhp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mhs);
            this.Controls.Add(this.grd_dshp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Thuhocphi";
            this.Text = "HỆ THỐNG THU CHI TRƯỜNG THPT NGUYÊN XUÂN ÔN ";
            ((System.ComponentModel.ISupportInitialize)(this.grd_dshp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grd_dshp;
        private System.Windows.Forms.TextBox txt_mhs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_timkiemhp;
        private System.Windows.Forms.Button btn_phieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}
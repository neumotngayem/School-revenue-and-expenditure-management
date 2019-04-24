namespace DAOVO_QLTC
{
    partial class FrmDanhmuchocphi
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
            this.btntaomoihp = new System.Windows.Forms.Button();
            this.btnsuahp = new System.Windows.Forms.Button();
            this.btnxoahp = new System.Windows.Forms.Button();
            this.btntimkiemhp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnamhoc = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txttenhp = new System.Windows.Forms.TextBox();
            this.txtmaloaihp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDMhocphi = new System.Windows.Forms.DataGridView();
            this.maloaihocphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaihocphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMhocphi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC QUY ĐỊNH HỌC PHÍ ";
            // 
            // btntaomoihp
            // 
            this.btntaomoihp.Location = new System.Drawing.Point(367, 218);
            this.btntaomoihp.Name = "btntaomoihp";
            this.btntaomoihp.Size = new System.Drawing.Size(75, 23);
            this.btntaomoihp.TabIndex = 9;
            this.btntaomoihp.Text = "Tạo mới ";
            this.btntaomoihp.UseVisualStyleBackColor = true;
            this.btntaomoihp.Click += new System.EventHandler(this.btntaomoihp_Click);
            // 
            // btnsuahp
            // 
            this.btnsuahp.Location = new System.Drawing.Point(460, 218);
            this.btnsuahp.Name = "btnsuahp";
            this.btnsuahp.Size = new System.Drawing.Size(75, 23);
            this.btnsuahp.TabIndex = 11;
            this.btnsuahp.Text = "Sửa";
            this.btnsuahp.UseVisualStyleBackColor = true;
            // 
            // btnxoahp
            // 
            this.btnxoahp.Location = new System.Drawing.Point(551, 218);
            this.btnxoahp.Name = "btnxoahp";
            this.btnxoahp.Size = new System.Drawing.Size(75, 23);
            this.btnxoahp.TabIndex = 12;
            this.btnxoahp.Text = "Xóa ";
            this.btnxoahp.UseVisualStyleBackColor = true;
            // 
            // btntimkiemhp
            // 
            this.btntimkiemhp.Location = new System.Drawing.Point(641, 218);
            this.btntimkiemhp.Name = "btntimkiemhp";
            this.btntimkiemhp.Size = new System.Drawing.Size(75, 23);
            this.btntimkiemhp.TabIndex = 13;
            this.btntimkiemhp.Text = "Tìm Kiếm ";
            this.btntimkiemhp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnamhoc);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.txttenhp);
            this.groupBox1.Controls.Add(this.txtmaloaihp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 119);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập đầy đủ thông tin ";
            // 
            // txtnamhoc
            // 
            this.txtnamhoc.Location = new System.Drawing.Point(203, 82);
            this.txtnamhoc.Name = "txtnamhoc";
            this.txtnamhoc.Size = new System.Drawing.Size(100, 20);
            this.txtnamhoc.TabIndex = 16;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(574, 78);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(100, 20);
            this.txttongtien.TabIndex = 15;
            // 
            // txttenhp
            // 
            this.txttenhp.Location = new System.Drawing.Point(574, 28);
            this.txttenhp.Name = "txttenhp";
            this.txttenhp.Size = new System.Drawing.Size(100, 20);
            this.txttenhp.TabIndex = 14;
            // 
            // txtmaloaihp
            // 
            this.txtmaloaihp.Location = new System.Drawing.Point(203, 25);
            this.txtmaloaihp.Name = "txtmaloaihp";
            this.txtmaloaihp.Size = new System.Drawing.Size(100, 20);
            this.txtmaloaihp.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Năm học ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên học phí ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã loại học phí ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDMhocphi);
            this.groupBox2.Location = new System.Drawing.Point(30, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 172);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục học phí ";
            // 
            // dgvDMhocphi
            // 
            this.dgvDMhocphi.BackgroundColor = System.Drawing.Color.White;
            this.dgvDMhocphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMhocphi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaihocphi,
            this.tenloaihocphi,
            this.namhoc,
            this.tienhoc});
            this.dgvDMhocphi.Location = new System.Drawing.Point(6, 16);
            this.dgvDMhocphi.Name = "dgvDMhocphi";
            this.dgvDMhocphi.Size = new System.Drawing.Size(735, 150);
            this.dgvDMhocphi.TabIndex = 0;
            // 
            // maloaihocphi
            // 
            this.maloaihocphi.DataPropertyName = "maloaihocphi";
            this.maloaihocphi.HeaderText = "Mã loại học phí ";
            this.maloaihocphi.MaxInputLength = 39767;
            this.maloaihocphi.Name = "maloaihocphi";
            // 
            // tenloaihocphi
            // 
            this.tenloaihocphi.DataPropertyName = "tenloaihocphi";
            this.tenloaihocphi.HeaderText = "Tên học phí ";
            this.tenloaihocphi.Name = "tenloaihocphi";
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Năm học ";
            this.namhoc.Name = "namhoc";
            // 
            // tienhoc
            // 
            this.tienhoc.DataPropertyName = "tienhoc";
            this.tienhoc.HeaderText = "Tổng tiền ";
            this.tienhoc.Name = "tienhoc";
            // 
            // FrmDanhmuchocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(826, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntimkiemhp);
            this.Controls.Add(this.btnxoahp);
            this.Controls.Add(this.btnsuahp);
            this.Controls.Add(this.btntaomoihp);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanhmuchocphi";
            this.Text = "HỆ THỐNG QUẢN LÍ THU CHI TRƯỜNG THPT NGUYỄN XUÂN ÔN ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMhocphi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntaomoihp;
        private System.Windows.Forms.Button btnsuahp;
        private System.Windows.Forms.Button btnxoahp;
        private System.Windows.Forms.Button btntimkiemhp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnamhoc;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox txttenhp;
        private System.Windows.Forms.TextBox txtmaloaihp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDMhocphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaihocphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaihocphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienhoc;
    }
}
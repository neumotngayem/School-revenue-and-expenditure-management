namespace DAOVO_QLTC
{
    partial class Frm_Quanlinguonchi
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
            this.txtmaphieuchi = new System.Windows.Forms.TextBox();
            this.txtlidochi = new System.Windows.Forms.TextBox();
            this.txtsotienchi = new System.Windows.Forms.TextBox();
            this.cbbmagv = new System.Windows.Forms.ComboBox();
            this.dgvnguonchi = new System.Windows.Forms.DataGridView();
            this.machi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lidochi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaychi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoichi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxuatphieuchi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguonchi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NGUỒN CHI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu chi ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã gv đề xuất ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lí do chi ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền chi ";
            // 
            // txtmaphieuchi
            // 
            this.txtmaphieuchi.Location = new System.Drawing.Point(203, 70);
            this.txtmaphieuchi.Name = "txtmaphieuchi";
            this.txtmaphieuchi.Size = new System.Drawing.Size(100, 20);
            this.txtmaphieuchi.TabIndex = 7;
            // 
            // txtlidochi
            // 
            this.txtlidochi.Location = new System.Drawing.Point(629, 114);
            this.txtlidochi.Name = "txtlidochi";
            this.txtlidochi.Size = new System.Drawing.Size(100, 20);
            this.txtlidochi.TabIndex = 9;
            // 
            // txtsotienchi
            // 
            this.txtsotienchi.Location = new System.Drawing.Point(629, 63);
            this.txtsotienchi.Name = "txtsotienchi";
            this.txtsotienchi.Size = new System.Drawing.Size(100, 20);
            this.txtsotienchi.TabIndex = 10;
            // 
            // cbbmagv
            // 
            this.cbbmagv.FormattingEnabled = true;
            this.cbbmagv.Location = new System.Drawing.Point(203, 118);
            this.cbbmagv.Name = "cbbmagv";
            this.cbbmagv.Size = new System.Drawing.Size(121, 21);
            this.cbbmagv.TabIndex = 12;
            // 
            // dgvnguonchi
            // 
            this.dgvnguonchi.BackgroundColor = System.Drawing.Color.White;
            this.dgvnguonchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnguonchi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machi,
            this.magv,
            this.lidochi,
            this.sotienchi,
            this.ngaychi,
            this.nguoichi});
            this.dgvnguonchi.Location = new System.Drawing.Point(36, 215);
            this.dgvnguonchi.Name = "dgvnguonchi";
            this.dgvnguonchi.Size = new System.Drawing.Size(702, 196);
            this.dgvnguonchi.TabIndex = 13;
            // 
            // machi
            // 
            this.machi.DataPropertyName = "machi";
            this.machi.HeaderText = "Mã phiếu chi";
            this.machi.Name = "machi";
            // 
            // magv
            // 
            this.magv.DataPropertyName = "magv";
            this.magv.HeaderText = "Mã giáo viên đề xuất chi";
            this.magv.Name = "magv";
            // 
            // lidochi
            // 
            this.lidochi.DataPropertyName = "lidochi";
            this.lidochi.HeaderText = "Lí do chi ";
            this.lidochi.Name = "lidochi";
            // 
            // sotienchi
            // 
            this.sotienchi.DataPropertyName = "sotienchi";
            this.sotienchi.HeaderText = "Số tiền chi";
            this.sotienchi.Name = "sotienchi";
            // 
            // ngaychi
            // 
            this.ngaychi.DataPropertyName = "ngaychi";
            this.ngaychi.HeaderText = "Ngày chi";
            this.ngaychi.Name = "ngaychi";
            // 
            // nguoichi
            // 
            this.nguoichi.DataPropertyName = "nguoichi";
            this.nguoichi.HeaderText = "Người chi";
            this.nguoichi.Name = "nguoichi";
            // 
            // btnxuatphieuchi
            // 
            this.btnxuatphieuchi.Location = new System.Drawing.Point(598, 170);
            this.btnxuatphieuchi.Name = "btnxuatphieuchi";
            this.btnxuatphieuchi.Size = new System.Drawing.Size(91, 23);
            this.btnxuatphieuchi.TabIndex = 16;
            this.btnxuatphieuchi.Text = "Xuất phiếu chi ";
            this.btnxuatphieuchi.UseVisualStyleBackColor = true;
            this.btnxuatphieuchi.Click += new System.EventHandler(this.btnxuatphieuchi_Click);
            // 
            // Frm_Quanlinguonchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(773, 423);
            this.Controls.Add(this.btnxuatphieuchi);
            this.Controls.Add(this.dgvnguonchi);
            this.Controls.Add(this.cbbmagv);
            this.Controls.Add(this.txtsotienchi);
            this.Controls.Add(this.txtlidochi);
            this.Controls.Add(this.txtmaphieuchi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Quanlinguonchi";
            this.Text = "HỆ THỐNG QUẢN LÍ THU CHI TRƯỜNG THPT NGUYỄN XUÂN ÔN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguonchi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaphieuchi;
        private System.Windows.Forms.TextBox txtlidochi;
        private System.Windows.Forms.TextBox txtsotienchi;
        private System.Windows.Forms.ComboBox cbbmagv;
        private System.Windows.Forms.DataGridView dgvnguonchi;
        private System.Windows.Forms.Button btnxuatphieuchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn machi;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidochi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaychi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoichi;
    }
}
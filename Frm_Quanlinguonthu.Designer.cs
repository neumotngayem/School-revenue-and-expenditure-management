namespace DAOVO_QLTC
{
    partial class Frm_Quanlinguonthu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grdnguonthu = new System.Windows.Forms.DataGridView();
            this.mathu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manguoinop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lidothu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoithu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatPhieuThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdnguonthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NGUỒN THU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thu: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // grdnguonthu
            // 
            this.grdnguonthu.AllowUserToAddRows = false;
            this.grdnguonthu.AllowUserToDeleteRows = false;
            this.grdnguonthu.AllowUserToResizeColumns = false;
            this.grdnguonthu.AllowUserToResizeRows = false;
            this.grdnguonthu.BackgroundColor = System.Drawing.Color.White;
            this.grdnguonthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdnguonthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathu,
            this.manguoinop,
            this.lidothu,
            this.sotienthu,
            this.ngaythu,
            this.nguoithu});
            this.grdnguonthu.Location = new System.Drawing.Point(12, 108);
            this.grdnguonthu.Name = "grdnguonthu";
            this.grdnguonthu.ReadOnly = true;
            this.grdnguonthu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdnguonthu.Size = new System.Drawing.Size(714, 299);
            this.grdnguonthu.TabIndex = 13;
            // 
            // mathu
            // 
            this.mathu.HeaderText = "Mã thu";
            this.mathu.Name = "mathu";
            this.mathu.ReadOnly = true;
            // 
            // manguoinop
            // 
            this.manguoinop.DataPropertyName = "manguoinop";
            this.manguoinop.HeaderText = "Mã người nộp";
            this.manguoinop.Name = "manguoinop";
            this.manguoinop.ReadOnly = true;
            // 
            // lidothu
            // 
            this.lidothu.DataPropertyName = "lidothu";
            this.lidothu.HeaderText = "Lí do thu";
            this.lidothu.Name = "lidothu";
            this.lidothu.ReadOnly = true;
            // 
            // sotienthu
            // 
            this.sotienthu.DataPropertyName = "sotienthu";
            this.sotienthu.HeaderText = "Số tiền thu";
            this.sotienthu.Name = "sotienthu";
            this.sotienthu.ReadOnly = true;
            // 
            // ngaythu
            // 
            this.ngaythu.DataPropertyName = "ngaythu";
            this.ngaythu.HeaderText = "Ngày thu";
            this.ngaythu.Name = "ngaythu";
            this.ngaythu.ReadOnly = true;
            // 
            // nguoithu
            // 
            this.nguoithu.DataPropertyName = "nguoithu";
            this.nguoithu.HeaderText = "Người thu";
            this.nguoithu.Name = "nguoithu";
            this.nguoithu.ReadOnly = true;
            // 
            // btnXuatPhieuThu
            // 
            this.btnXuatPhieuThu.Location = new System.Drawing.Point(586, 44);
            this.btnXuatPhieuThu.Name = "btnXuatPhieuThu";
            this.btnXuatPhieuThu.Size = new System.Drawing.Size(98, 31);
            this.btnXuatPhieuThu.TabIndex = 17;
            this.btnXuatPhieuThu.Text = "Xuất phiếu thu ";
            this.btnXuatPhieuThu.UseVisualStyleBackColor = true;
            this.btnXuatPhieuThu.Click += new System.EventHandler(this.btnXuatPhieuThu_Click);
            // 
            // Frm_Quanlinguonthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(738, 419);
            this.Controls.Add(this.btnXuatPhieuThu);
            this.Controls.Add(this.grdnguonthu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Quanlinguonthu";
            this.Text = "HỆ THỐNG QUẢN LÍ THU CHI TRƯỜNG THPT NGUYỄN XUÂN ÔN ";
            ((System.ComponentModel.ISupportInitialize)(this.grdnguonthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grdnguonthu;
        private System.Windows.Forms.Button btnXuatPhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathu;
        private System.Windows.Forms.DataGridViewTextBoxColumn manguoinop;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidothu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoithu;
    }
}
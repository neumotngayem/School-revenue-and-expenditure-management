namespace DAOVO_QLTC
{
    partial class Frm_Danhmucmiengiam
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
            this.txt_mamiengiam = new System.Windows.Forms.TextBox();
            this.txt_tenmiengiam = new System.Windows.Forms.TextBox();
            this.txt_phantrammiengiam = new System.Windows.Forms.TextBox();
            this.btn_taomoimg = new System.Windows.Forms.Button();
            this.btn_themmg = new System.Windows.Forms.Button();
            this.btn_xoamg = new System.Windows.Forms.Button();
            this.btn_suamg = new System.Windows.Forms.Button();
            this.btn_timkiemmg = new System.Windows.Forms.Button();
            this.btn_thoatmg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC QUY ĐỊNH MIỄN GIẢM ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã miễn giảm ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên miễn giảm ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phần trăm miễn giảm ";
            // 
            // txt_mamiengiam
            // 
            this.txt_mamiengiam.Location = new System.Drawing.Point(204, 92);
            this.txt_mamiengiam.Name = "txt_mamiengiam";
            this.txt_mamiengiam.Size = new System.Drawing.Size(100, 20);
            this.txt_mamiengiam.TabIndex = 4;
            // 
            // txt_tenmiengiam
            // 
            this.txt_tenmiengiam.Location = new System.Drawing.Point(204, 142);
            this.txt_tenmiengiam.Name = "txt_tenmiengiam";
            this.txt_tenmiengiam.Size = new System.Drawing.Size(100, 20);
            this.txt_tenmiengiam.TabIndex = 5;
            // 
            // txt_phantrammiengiam
            // 
            this.txt_phantrammiengiam.Location = new System.Drawing.Point(204, 194);
            this.txt_phantrammiengiam.Name = "txt_phantrammiengiam";
            this.txt_phantrammiengiam.Size = new System.Drawing.Size(100, 20);
            this.txt_phantrammiengiam.TabIndex = 6;
            this.txt_phantrammiengiam.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_taomoimg
            // 
            this.btn_taomoimg.Location = new System.Drawing.Point(404, 90);
            this.btn_taomoimg.Name = "btn_taomoimg";
            this.btn_taomoimg.Size = new System.Drawing.Size(75, 23);
            this.btn_taomoimg.TabIndex = 7;
            this.btn_taomoimg.Text = "Tạo mới ";
            this.btn_taomoimg.UseVisualStyleBackColor = true;
            // 
            // btn_themmg
            // 
            this.btn_themmg.Location = new System.Drawing.Point(404, 139);
            this.btn_themmg.Name = "btn_themmg";
            this.btn_themmg.Size = new System.Drawing.Size(75, 23);
            this.btn_themmg.TabIndex = 8;
            this.btn_themmg.Text = "Thêm";
            this.btn_themmg.UseVisualStyleBackColor = true;
            // 
            // btn_xoamg
            // 
            this.btn_xoamg.Location = new System.Drawing.Point(404, 194);
            this.btn_xoamg.Name = "btn_xoamg";
            this.btn_xoamg.Size = new System.Drawing.Size(75, 23);
            this.btn_xoamg.TabIndex = 9;
            this.btn_xoamg.Text = "Xóa ";
            this.btn_xoamg.UseVisualStyleBackColor = true;
            // 
            // btn_suamg
            // 
            this.btn_suamg.Location = new System.Drawing.Point(560, 89);
            this.btn_suamg.Name = "btn_suamg";
            this.btn_suamg.Size = new System.Drawing.Size(75, 23);
            this.btn_suamg.TabIndex = 10;
            this.btn_suamg.Text = "Sửa";
            this.btn_suamg.UseVisualStyleBackColor = true;
            // 
            // btn_timkiemmg
            // 
            this.btn_timkiemmg.Location = new System.Drawing.Point(560, 142);
            this.btn_timkiemmg.Name = "btn_timkiemmg";
            this.btn_timkiemmg.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiemmg.TabIndex = 11;
            this.btn_timkiemmg.Text = "Tìm kiếm";
            this.btn_timkiemmg.UseVisualStyleBackColor = true;
            // 
            // btn_thoatmg
            // 
            this.btn_thoatmg.BackColor = System.Drawing.Color.Red;
            this.btn_thoatmg.Location = new System.Drawing.Point(560, 194);
            this.btn_thoatmg.Name = "btn_thoatmg";
            this.btn_thoatmg.Size = new System.Drawing.Size(75, 23);
            this.btn_thoatmg.TabIndex = 12;
            this.btn_thoatmg.Text = "Thoát ";
            this.btn_thoatmg.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 185);
            this.dataGridView1.TabIndex = 13;
            // 
            // Frm_Danhmucmiengiam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(732, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_thoatmg);
            this.Controls.Add(this.btn_timkiemmg);
            this.Controls.Add(this.btn_suamg);
            this.Controls.Add(this.btn_xoamg);
            this.Controls.Add(this.btn_themmg);
            this.Controls.Add(this.btn_taomoimg);
            this.Controls.Add(this.txt_phantrammiengiam);
            this.Controls.Add(this.txt_tenmiengiam);
            this.Controls.Add(this.txt_mamiengiam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Danhmucmiengiam";
            this.Text = "HỆ THỐNG QUẢN LÍ THU CHI TRƯỜNG THPT NGUYỄN XUÂN ÔN ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mamiengiam;
        private System.Windows.Forms.TextBox txt_tenmiengiam;
        private System.Windows.Forms.TextBox txt_phantrammiengiam;
        private System.Windows.Forms.Button btn_taomoimg;
        private System.Windows.Forms.Button btn_themmg;
        private System.Windows.Forms.Button btn_xoamg;
        private System.Windows.Forms.Button btn_suamg;
        private System.Windows.Forms.Button btn_timkiemmg;
        private System.Windows.Forms.Button btn_thoatmg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
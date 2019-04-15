namespace DAOVO_QLTC
{
    partial class Frm_trangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_trangchu));
            this.btn_hocsinh = new System.Windows.Forms.Button();
            this.btn_banquanli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hocsinh
            // 
            resources.ApplyResources(this.btn_hocsinh, "btn_hocsinh");
            this.btn_hocsinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_hocsinh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_hocsinh.Name = "btn_hocsinh";
            this.btn_hocsinh.UseVisualStyleBackColor = false;
            // 
            // btn_banquanli
            // 
            resources.ApplyResources(this.btn_banquanli, "btn_banquanli");
            this.btn_banquanli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_banquanli.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_banquanli.Name = "btn_banquanli";
            this.btn_banquanli.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ptb_image
            // 
            resources.ApplyResources(this.ptb_image, "ptb_image");
            this.ptb_image.Image = global::DAOVO_QLTC.Properties.Resources._1_82710;
            this.ptb_image.Name = "ptb_image";
            this.ptb_image.TabStop = false;
            // 
            // Frm_trangchu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.ptb_image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_banquanli);
            this.Controls.Add(this.btn_hocsinh);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Frm_trangchu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hocsinh;
        private System.Windows.Forms.Button btn_banquanli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_image;
    }
}


namespace DAOVO_QLTC
{
    partial class Frm_BaoCaoHocPhi
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
            this.crv_hocphi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_hocphi
            // 
            this.crv_hocphi.ActiveViewIndex = -1;
            this.crv_hocphi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_hocphi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_hocphi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_hocphi.Location = new System.Drawing.Point(0, 0);
            this.crv_hocphi.Name = "crv_hocphi";
            this.crv_hocphi.Size = new System.Drawing.Size(800, 450);
            this.crv_hocphi.TabIndex = 0;
            // 
            // Frm_BaoCaoHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_hocphi);
            this.Name = "Frm_BaoCaoHocPhi";
            this.Text = "Frm_BaoCaoHocPhi";
            this.Load += new System.EventHandler(this.Frm_BaoCaoHocPhi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_hocphi;
    }
}
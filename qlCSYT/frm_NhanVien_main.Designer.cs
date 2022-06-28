namespace qlCSYT
{
    partial class frm_NhanVien_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.m_viewNV = new System.Windows.Forms.ToolStripMenuItem();
            this.m_modifyNV = new System.Windows.Forms.ToolStripMenuItem();
            this.m_YsBs = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Nc = new System.Windows.Forms.ToolStripMenuItem();
            this.m_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_viewNV,
            this.m_modifyNV,
            this.m_YsBs,
            this.m_Nc,
            this.m_logout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // m_viewNV
            // 
            this.m_viewNV.Name = "m_viewNV";
            this.m_viewNV.Size = new System.Drawing.Size(117, 24);
            this.m_viewNV.Text = "Xem thông tin";
            this.m_viewNV.Click += new System.EventHandler(this.m_viewNV_Click);
            // 
            // m_modifyNV
            // 
            this.m_modifyNV.Name = "m_modifyNV";
            this.m_modifyNV.Size = new System.Drawing.Size(112, 24);
            this.m_modifyNV.Text = "Sửa thông tin";
            this.m_modifyNV.Click += new System.EventHandler(this.m_modifyNV_Click);
            // 
            // m_YsBs
            // 
            this.m_YsBs.Name = "m_YsBs";
            this.m_YsBs.Size = new System.Drawing.Size(61, 24);
            this.m_YsBs.Text = "Bác sĩ";
            this.m_YsBs.Click += new System.EventHandler(this.m_YsBs_Click);
            // 
            // m_Nc
            // 
            this.m_Nc.Name = "m_Nc";
            this.m_Nc.Size = new System.Drawing.Size(99, 24);
            this.m_Nc.Text = "Nghiên cứu";
            this.m_Nc.Click += new System.EventHandler(this.m_Nc_Click);
            // 
            // m_logout
            // 
            this.m_logout.Name = "m_logout";
            this.m_logout.Size = new System.Drawing.Size(91, 24);
            this.m_logout.Text = "Đăng xuất";
            this.m_logout.Click += new System.EventHandler(this.m_logout_Click);
            // 
            // frm_NhanVien_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_NhanVien_main";
            this.Text = "Nhân viên";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem m_viewNV;
        private System.Windows.Forms.ToolStripMenuItem m_modifyNV;
        private System.Windows.Forms.ToolStripMenuItem m_YsBs;
        private System.Windows.Forms.ToolStripMenuItem m_Nc;
        private System.Windows.Forms.ToolStripMenuItem m_logout;
    }
}
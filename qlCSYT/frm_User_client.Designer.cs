
namespace qlCSYT
{
    partial class frm_User_client
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ThongTInCN_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.ThanhTra_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.BacSi_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.QLDL_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.NghienCuu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.logout_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_anouncement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTInCN_strip,
            this.ThanhTra_strip,
            this.BacSi_strip,
            this.QLDL_strip,
            this.NghienCuu_strip,
            this.Admin_strip,
            this.m_anouncement,
            this.logout_strip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(872, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThongTInCN_strip
            // 
            this.ThongTInCN_strip.Name = "ThongTInCN_strip";
            this.ThongTInCN_strip.Size = new System.Drawing.Size(146, 25);
            this.ThongTInCN_strip.Text = "Thông tin cá nhân";
            this.ThongTInCN_strip.Click += new System.EventHandler(this.ThongTInCN_strip_Click);
            // 
            // ThanhTra_strip
            // 
            this.ThanhTra_strip.Name = "ThanhTra_strip";
            this.ThanhTra_strip.Size = new System.Drawing.Size(90, 25);
            this.ThanhTra_strip.Text = "Thanh Tra";
            this.ThanhTra_strip.Click += new System.EventHandler(this.ThanhTra_strip_Click);
            // 
            // BacSi_strip
            // 
            this.BacSi_strip.Name = "BacSi_strip";
            this.BacSi_strip.Size = new System.Drawing.Size(61, 25);
            this.BacSi_strip.Text = "Bác sĩ";
            this.BacSi_strip.Click += new System.EventHandler(this.BacSi_strip_Click);
            // 
            // QLDL_strip
            // 
            this.QLDL_strip.Name = "QLDL_strip";
            this.QLDL_strip.Size = new System.Drawing.Size(123, 25);
            this.QLDL_strip.Text = "Quản lí dữ liệu";
            this.QLDL_strip.Click += new System.EventHandler(this.QLDL_strip_Click);
            // 
            // NghienCuu_strip
            // 
            this.NghienCuu_strip.Name = "NghienCuu_strip";
            this.NghienCuu_strip.Size = new System.Drawing.Size(102, 25);
            this.NghienCuu_strip.Text = "Nghiên cứu";
            this.NghienCuu_strip.Click += new System.EventHandler(this.NghienCuu_strip_Click);
            // 
            // Admin_strip
            // 
            this.Admin_strip.Name = "Admin_strip";
            this.Admin_strip.Size = new System.Drawing.Size(68, 25);
            this.Admin_strip.Text = "Admin";
            this.Admin_strip.Click += new System.EventHandler(this.Admin_strip_Click);
            // 
            // logout_strip
            // 
            this.logout_strip.Name = "logout_strip";
            this.logout_strip.Size = new System.Drawing.Size(92, 25);
            this.logout_strip.Text = "Đăng xuất";
            this.logout_strip.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // m_anouncement
            // 
            this.m_anouncement.Name = "m_anouncement";
            this.m_anouncement.Size = new System.Drawing.Size(128, 25);
            this.m_anouncement.Text = "Xem thông báo";
            this.m_anouncement.Click += new System.EventHandler(this.m_anouncement_Click);
            // 
            // frm_User_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlCSYT.Properties.Resources.ATBMCQ_4_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(872, 366);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_User_client";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frm_User_client_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThongTInCN_strip;
        private System.Windows.Forms.ToolStripMenuItem ThanhTra_strip;
        private System.Windows.Forms.ToolStripMenuItem BacSi_strip;
        private System.Windows.Forms.ToolStripMenuItem QLDL_strip;
        private System.Windows.Forms.ToolStripMenuItem NghienCuu_strip;
        private System.Windows.Forms.ToolStripMenuItem Admin_strip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logout_strip;
        private System.Windows.Forms.ToolStripMenuItem m_anouncement;
    }
}
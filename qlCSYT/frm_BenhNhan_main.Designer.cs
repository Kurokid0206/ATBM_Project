﻿namespace qlCSYT
{
    partial class frm_BenhNhan_main
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
            this.m_viewBN = new System.Windows.Forms.ToolStripMenuItem();
            this.m_modifyBN = new System.Windows.Forms.ToolStripMenuItem();
            this.m_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_viewBN,
            this.m_modifyBN,
            this.m_logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_viewBN
            // 
            this.m_viewBN.Name = "m_viewBN";
            this.m_viewBN.Size = new System.Drawing.Size(117, 24);
            this.m_viewBN.Text = "Xem thông tin";
            this.m_viewBN.Click += new System.EventHandler(this.m_viewBN_Click);
            // 
            // m_modifyBN
            // 
            this.m_modifyBN.Name = "m_modifyBN";
            this.m_modifyBN.Size = new System.Drawing.Size(112, 24);
            this.m_modifyBN.Text = "Sửa thông tin";
            this.m_modifyBN.Click += new System.EventHandler(this.m_modifyBN_Click);
            // 
            // m_logout
            // 
            this.m_logout.Name = "m_logout";
            this.m_logout.Size = new System.Drawing.Size(91, 24);
            this.m_logout.Text = "Đăng xuất";
            this.m_logout.Click += new System.EventHandler(this.m_logout_Click);
            // 
            // frm_BenhNhan_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_BenhNhan_main";
            this.Text = "Bệnh nhân";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_viewBN;
        private System.Windows.Forms.ToolStripMenuItem m_modifyBN;
        private System.Windows.Forms.ToolStripMenuItem m_logout;
    }
}
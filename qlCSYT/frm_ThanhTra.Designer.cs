namespace qlCSYT
{
    partial class frm_ThanhTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThanhTra));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thanhTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSBADVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benhNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSYTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhTraToolStripMenuItem,
            this.hSBADVToolStripMenuItem,
            this.benhNhanToolStripMenuItem,
            this.cSYTToolStripMenuItem,
            this.nhanVienToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thanhTraToolStripMenuItem
            // 
            this.thanhTraToolStripMenuItem.Name = "thanhTraToolStripMenuItem";
            this.thanhTraToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thanhTraToolStripMenuItem.Text = "HSBA";
            // 
            // hSBADVToolStripMenuItem
            // 
            this.hSBADVToolStripMenuItem.Name = "hSBADVToolStripMenuItem";
            this.hSBADVToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.hSBADVToolStripMenuItem.Text = "HSBA_DV";
            // 
            // benhNhanToolStripMenuItem
            // 
            this.benhNhanToolStripMenuItem.Name = "benhNhanToolStripMenuItem";
            this.benhNhanToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.benhNhanToolStripMenuItem.Text = "BenhNhan";
            // 
            // cSYTToolStripMenuItem
            // 
            this.cSYTToolStripMenuItem.Name = "cSYTToolStripMenuItem";
            this.cSYTToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.cSYTToolStripMenuItem.Text = "CSYT";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.nhanVienToolStripMenuItem.Text = "NhanVien";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frm_ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ThanhTra";
            this.Text = " Thanh Tra";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thanhTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSBADVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benhNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSYTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}
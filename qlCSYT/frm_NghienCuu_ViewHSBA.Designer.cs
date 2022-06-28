namespace qlCSYT
{
    partial class frm_NghienCuu_ViewHSBA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NghienCuu_ViewHSBA));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nghiênCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHSBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHSBADVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_NghienCuu = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NghienCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nghiênCứuToolStripMenuItem,
            this.xemHSBAToolStripMenuItem,
            this.xemHSBADVToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nghiênCứuToolStripMenuItem
            // 
            this.nghiênCứuToolStripMenuItem.Name = "nghiênCứuToolStripMenuItem";
            this.nghiênCứuToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.nghiênCứuToolStripMenuItem.Text = "Nghiên Cứu";
            // 
            // xemHSBAToolStripMenuItem
            // 
            this.xemHSBAToolStripMenuItem.Name = "xemHSBAToolStripMenuItem";
            this.xemHSBAToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.xemHSBAToolStripMenuItem.Text = "Xem HSBA";
            // 
            // xemHSBADVToolStripMenuItem
            // 
            this.xemHSBADVToolStripMenuItem.Name = "xemHSBADVToolStripMenuItem";
            this.xemHSBADVToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.xemHSBADVToolStripMenuItem.Text = "Xem HSBA_DV";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // gv_NghienCuu
            // 
            this.gv_NghienCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_NghienCuu.Location = new System.Drawing.Point(12, 31);
            this.gv_NghienCuu.Name = "gv_NghienCuu";
            this.gv_NghienCuu.RowHeadersWidth = 51;
            this.gv_NghienCuu.RowTemplate.Height = 24;
            this.gv_NghienCuu.Size = new System.Drawing.Size(776, 407);
            this.gv_NghienCuu.TabIndex = 1;
            // 
            // frm_NghienCuu_ViewHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_NghienCuu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_NghienCuu_ViewHSBA";
            this.Text = "ATBMCQ-4";
            this.Load += new System.EventHandler(this.frm_NghienCuu_ViewHSBA_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NghienCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nghiênCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHSBAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHSBADVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridView gv_NghienCuu;
    }
}
namespace qlCSYT
{
    partial class frm_NghienCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NghienCuu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_xemHSBA = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_xemHSBADV = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_NghienCuu = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NghienCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_xemHSBA,
            this.menu_xemHSBADV,
            this.menu_logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_xemHSBA
            // 
            this.menu_xemHSBA.Name = "menu_xemHSBA";
            this.menu_xemHSBA.Size = new System.Drawing.Size(61, 24);
            this.menu_xemHSBA.Text = "HSBA";
            this.menu_xemHSBA.Click += new System.EventHandler(this.menu_xemHSBA_Click);
            // 
            // menu_xemHSBADV
            // 
            this.menu_xemHSBADV.Name = "menu_xemHSBADV";
            this.menu_xemHSBADV.Size = new System.Drawing.Size(87, 24);
            this.menu_xemHSBADV.Text = "HSBA_DV";
            this.menu_xemHSBADV.Click += new System.EventHandler(this.menu_xemHSBADV_Click);
            // 
            // menu_logout
            // 
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Size = new System.Drawing.Size(91, 24);
            this.menu_logout.Text = "Đăng xuất";
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
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
            // frm_NghienCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_NghienCuu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_NghienCuu";
            this.Text = " Nghiên cứu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NghienCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_xemHSBA;
        private System.Windows.Forms.ToolStripMenuItem menu_xemHSBADV;
        private System.Windows.Forms.DataGridView gv_NghienCuu;
        private System.Windows.Forms.ToolStripMenuItem menu_logout;
    }
}
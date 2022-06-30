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
            this.menuNghienCuu = new System.Windows.Forms.MenuStrip();
            this.menu_xemHSBA = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_xemHSBADV = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_NghienCuu = new System.Windows.Forms.DataGridView();
            this.menuNghienCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NghienCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuNghienCuu
            // 
            this.menuNghienCuu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNghienCuu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_xemHSBA,
            this.menu_xemHSBADV});
            this.menuNghienCuu.Location = new System.Drawing.Point(0, 0);
            this.menuNghienCuu.Name = "menuNghienCuu";
            this.menuNghienCuu.Size = new System.Drawing.Size(1077, 28);
            this.menuNghienCuu.TabIndex = 0;
            this.menuNghienCuu.Text = "menuStrip1";
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
            // gv_NghienCuu
            // 
            this.gv_NghienCuu.AllowUserToAddRows = false;
            this.gv_NghienCuu.AllowUserToDeleteRows = false;
            this.gv_NghienCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_NghienCuu.Enabled = false;
            this.gv_NghienCuu.Location = new System.Drawing.Point(12, 31);
            this.gv_NghienCuu.Name = "gv_NghienCuu";
            this.gv_NghienCuu.ReadOnly = true;
            this.gv_NghienCuu.RowHeadersWidth = 51;
            this.gv_NghienCuu.RowTemplate.Height = 24;
            this.gv_NghienCuu.Size = new System.Drawing.Size(1053, 329);
            this.gv_NghienCuu.TabIndex = 1;
            // 
            // frm_NghienCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 372);
            this.Controls.Add(this.gv_NghienCuu);
            this.Controls.Add(this.menuNghienCuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuNghienCuu;
            this.Name = "frm_NghienCuu";
            this.Text = " Nghiên cứu";
            this.menuNghienCuu.ResumeLayout(false);
            this.menuNghienCuu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NghienCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuNghienCuu;
        private System.Windows.Forms.ToolStripMenuItem menu_xemHSBA;
        private System.Windows.Forms.ToolStripMenuItem menu_xemHSBADV;
        private System.Windows.Forms.DataGridView gv_NghienCuu;
    }
}
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
            this.menuThanhTra = new System.Windows.Forms.MenuStrip();
            this.menu_xemHSBA = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_xemHSBA_DV = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_xemBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_xemCSYT = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_xemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_ThanhTra = new System.Windows.Forms.DataGridView();
            this.menuThanhTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThanhTra)).BeginInit();
            this.SuspendLayout();
            // 
            // menuThanhTra
            // 
            this.menuThanhTra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuThanhTra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_xemHSBA,
            this.menu_xemHSBA_DV,
            this.menu_xemBenhNhan,
            this.menu_xemCSYT,
            this.menu_xemNhanVien});
            this.menuThanhTra.Location = new System.Drawing.Point(0, 0);
            this.menuThanhTra.Name = "menuThanhTra";
            this.menuThanhTra.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuThanhTra.Size = new System.Drawing.Size(760, 24);
            this.menuThanhTra.TabIndex = 0;
            this.menuThanhTra.Text = "menuStrip1";
            // 
            // menu_xemHSBA
            // 
            this.menu_xemHSBA.Name = "menu_xemHSBA";
            this.menu_xemHSBA.Size = new System.Drawing.Size(49, 20);
            this.menu_xemHSBA.Text = "HSBA";
            this.menu_xemHSBA.Click += new System.EventHandler(this.menu_xemHSBA_Click);
            // 
            // menu_xemHSBA_DV
            // 
            this.menu_xemHSBA_DV.Name = "menu_xemHSBA_DV";
            this.menu_xemHSBA_DV.Size = new System.Drawing.Size(69, 20);
            this.menu_xemHSBA_DV.Text = "HSBA_DV";
            this.menu_xemHSBA_DV.Click += new System.EventHandler(this.menu_xemHSBA_DV_Click);
            // 
            // menu_xemBenhNhan
            // 
            this.menu_xemBenhNhan.Name = "menu_xemBenhNhan";
            this.menu_xemBenhNhan.Size = new System.Drawing.Size(75, 20);
            this.menu_xemBenhNhan.Text = "BenhNhan";
            this.menu_xemBenhNhan.Click += new System.EventHandler(this.menu_xemBenhNhan_Click);
            // 
            // menu_xemCSYT
            // 
            this.menu_xemCSYT.Name = "menu_xemCSYT";
            this.menu_xemCSYT.Size = new System.Drawing.Size(46, 20);
            this.menu_xemCSYT.Text = "CSYT";
            this.menu_xemCSYT.Click += new System.EventHandler(this.menu_xemCSYT_Click);
            // 
            // menu_xemNhanVien
            // 
            this.menu_xemNhanVien.Name = "menu_xemNhanVien";
            this.menu_xemNhanVien.Size = new System.Drawing.Size(71, 20);
            this.menu_xemNhanVien.Text = "NhanVien";
            this.menu_xemNhanVien.Click += new System.EventHandler(this.menu_xemNhanVien_Click);
            // 
            // gv_ThanhTra
            // 
            this.gv_ThanhTra.AllowUserToAddRows = false;
            this.gv_ThanhTra.AllowUserToDeleteRows = false;
            this.gv_ThanhTra.AllowUserToOrderColumns = true;
            this.gv_ThanhTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ThanhTra.Location = new System.Drawing.Point(9, 25);
            this.gv_ThanhTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gv_ThanhTra.Name = "gv_ThanhTra";
            this.gv_ThanhTra.ReadOnly = true;
            this.gv_ThanhTra.RowHeadersWidth = 51;
            this.gv_ThanhTra.RowTemplate.Height = 24;
            this.gv_ThanhTra.Size = new System.Drawing.Size(742, 331);
            this.gv_ThanhTra.TabIndex = 1;
            // 
            // frm_ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 366);
            this.Controls.Add(this.gv_ThanhTra);
            this.Controls.Add(this.menuThanhTra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuThanhTra;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ThanhTra";
            this.Text = " Thanh Tra";
            this.menuThanhTra.ResumeLayout(false);
            this.menuThanhTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThanhTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuThanhTra;
        private System.Windows.Forms.ToolStripMenuItem menu_xemHSBA;
        private System.Windows.Forms.ToolStripMenuItem menu_xemHSBA_DV;
        private System.Windows.Forms.ToolStripMenuItem menu_xemBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem menu_xemCSYT;
        private System.Windows.Forms.ToolStripMenuItem menu_xemNhanVien;
        private System.Windows.Forms.DataGridView gv_ThanhTra;
    }
}
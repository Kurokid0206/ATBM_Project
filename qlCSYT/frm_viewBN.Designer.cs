namespace qlCSYT
{
    partial class frm_viewBN
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
            this.gv_viewSelf = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_modifyBN = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gv_viewSelf)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_viewSelf
            // 
            this.gv_viewSelf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_viewSelf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_viewSelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_viewSelf.Location = new System.Drawing.Point(7, 30);
            this.gv_viewSelf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_viewSelf.Name = "gv_viewSelf";
            this.gv_viewSelf.RowHeadersWidth = 51;
            this.gv_viewSelf.RowTemplate.Height = 24;
            this.gv_viewSelf.Size = new System.Drawing.Size(1487, 76);
            this.gv_viewSelf.TabIndex = 2;
            this.gv_viewSelf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_viewSelf_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_modifyBN});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1506, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_modifyBN
            // 
            this.m_modifyBN.Name = "m_modifyBN";
            this.m_modifyBN.Size = new System.Drawing.Size(151, 24);
            this.m_modifyBN.Text = "Chỉnh sửa thông tin";
            this.m_modifyBN.Click += new System.EventHandler(this.m_modifyBN_Click);
            // 
            // frm_viewBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 113);
            this.Controls.Add(this.gv_viewSelf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_viewBN";
            this.Text = "Xem thông tin cá nhân";
            ((System.ComponentModel.ISupportInitialize)(this.gv_viewSelf)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_viewSelf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_modifyBN;
    }
}
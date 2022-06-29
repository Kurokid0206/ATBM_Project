namespace qlCSYT
{
    partial class frm_YsBs_viewHSBA
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
            this.gv_HSBA = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_viewPatient = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSBA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_HSBA
            // 
            this.gv_HSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_HSBA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_HSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_HSBA.Location = new System.Drawing.Point(12, 36);
            this.gv_HSBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_HSBA.Name = "gv_HSBA";
            this.gv_HSBA.RowHeadersWidth = 51;
            this.gv_HSBA.RowTemplate.Height = 24;
            this.gv_HSBA.Size = new System.Drawing.Size(1170, 416);
            this.gv_HSBA.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_viewPatient});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_viewPatient
            // 
            this.m_viewPatient.Name = "m_viewPatient";
            this.m_viewPatient.Size = new System.Drawing.Size(166, 24);
            this.m_viewPatient.Text = "Xem hồ sơ bệnh nhân";
            this.m_viewPatient.Click += new System.EventHandler(this.m_viewPatient_Click);
            // 
            // frm_YsBs_viewHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 453);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gv_HSBA);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_YsBs_viewHSBA";
            this.Text = "Xem hồ sơ bệnh án";
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSBA)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_HSBA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_viewPatient;
    }
}
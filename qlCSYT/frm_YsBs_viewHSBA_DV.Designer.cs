namespace qlCSYT
{
    partial class frm_YsBs_viewHSBA_DV
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
            this.gv_HSBA_DV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSBA_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_HSBA_DV
            // 
            this.gv_HSBA_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_HSBA_DV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_HSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_HSBA_DV.Location = new System.Drawing.Point(12, 11);
            this.gv_HSBA_DV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_HSBA_DV.Name = "gv_HSBA_DV";
            this.gv_HSBA_DV.RowHeadersWidth = 51;
            this.gv_HSBA_DV.RowTemplate.Height = 24;
            this.gv_HSBA_DV.Size = new System.Drawing.Size(776, 428);
            this.gv_HSBA_DV.TabIndex = 2;
            // 
            // frm_YsBs_viewHSBA_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_HSBA_DV);
            this.Name = "frm_YsBs_viewHSBA_DV";
            this.Text = "Xem dịch vụ của hồ sơ bệnh án";
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSBA_DV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_HSBA_DV;
    }
}
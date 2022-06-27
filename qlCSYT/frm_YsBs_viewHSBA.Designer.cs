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
            this.gv_HSBA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_HSBA
            // 
            this.gv_HSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_HSBA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_HSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_HSBA.Location = new System.Drawing.Point(12, 11);
            this.gv_HSBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_HSBA.Name = "gv_HSBA";
            this.gv_HSBA.RowHeadersWidth = 51;
            this.gv_HSBA.RowTemplate.Height = 24;
            this.gv_HSBA.Size = new System.Drawing.Size(776, 428);
            this.gv_HSBA.TabIndex = 1;
            // 
            // frm_YsBs_viewHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_HSBA);
            this.Name = "frm_YsBs_viewHSBA";
            this.Text = "Xem hồ sơ bệnh án";
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSBA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_HSBA;
    }
}
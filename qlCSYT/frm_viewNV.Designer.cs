namespace qlCSYT
{
    partial class frm_viewNV
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
            ((System.ComponentModel.ISupportInitialize)(this.gv_viewSelf)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_viewSelf
            // 
            this.gv_viewSelf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_viewSelf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_viewSelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_viewSelf.Location = new System.Drawing.Point(3, 11);
            this.gv_viewSelf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_viewSelf.Name = "gv_viewSelf";
            this.gv_viewSelf.RowHeadersWidth = 51;
            this.gv_viewSelf.RowTemplate.Height = 24;
            this.gv_viewSelf.Size = new System.Drawing.Size(1218, 58);
            this.gv_viewSelf.TabIndex = 3;
            // 
            // frm_viewNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 84);
            this.Controls.Add(this.gv_viewSelf);
            this.Name = "frm_viewNV";
            this.Text = "Xem thông tin cá nhân";
            ((System.ComponentModel.ISupportInitialize)(this.gv_viewSelf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_viewSelf;
    }
}
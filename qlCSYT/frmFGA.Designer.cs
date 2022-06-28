
namespace qlCSYT
{
    partial class frmFGA
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
            this.gv_fgaData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fgaData)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_fgaData
            // 
            this.gv_fgaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_fgaData.Location = new System.Drawing.Point(42, 83);
            this.gv_fgaData.Name = "gv_fgaData";
            this.gv_fgaData.Size = new System.Drawing.Size(715, 263);
            this.gv_fgaData.TabIndex = 0;
            // 
            // frmFGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_fgaData);
            this.Name = "frmFGA";
            this.Text = "frmFGA";
            this.Load += new System.EventHandler(this.frmFGA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_fgaData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_fgaData;
    }
}
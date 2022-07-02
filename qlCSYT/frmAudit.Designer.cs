
namespace qlCSYT
{
    partial class frmAudit
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
            this.gv_AuditData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AuditData)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_AuditData
            // 
            this.gv_AuditData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_AuditData.Location = new System.Drawing.Point(0, 0);
            this.gv_AuditData.Name = "gv_AuditData";
            this.gv_AuditData.Size = new System.Drawing.Size(385, 188);
            this.gv_AuditData.TabIndex = 0;
            // 
            // frmAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 183);
            this.Controls.Add(this.gv_AuditData);
            this.Name = "frmAudit";
            this.Text = "frmAudit";
            this.Load += new System.EventHandler(this.frmAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_AuditData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_AuditData;
    }
}
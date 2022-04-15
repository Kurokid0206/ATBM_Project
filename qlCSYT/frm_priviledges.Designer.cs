
namespace qlCSYT
{
    partial class frm_priviledges
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
            this.gv_tables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tables)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_tables
            // 
            this.gv_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_tables.Location = new System.Drawing.Point(58, 121);
            this.gv_tables.Name = "gv_tables";
            this.gv_tables.Size = new System.Drawing.Size(692, 150);
            this.gv_tables.TabIndex = 0;
            // 
            // frm_priviledges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_tables);
            this.Name = "frm_priviledges";
            this.Text = "Thêm role";
            this.Load += new System.EventHandler(this.frm_priviledges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_tables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_tables;
    }
}
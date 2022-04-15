
namespace qlCSYT
{
    partial class frm_ViewRole
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
            this.GridView_ShowRole = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ShowRole)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_ShowRole
            // 
            this.GridView_ShowRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_ShowRole.Location = new System.Drawing.Point(83, 36);
            this.GridView_ShowRole.Name = "GridView_ShowRole";
            this.GridView_ShowRole.RowHeadersWidth = 51;
            this.GridView_ShowRole.RowTemplate.Height = 24;
            this.GridView_ShowRole.Size = new System.Drawing.Size(657, 373);
            this.GridView_ShowRole.TabIndex = 0;
            // 
            // frm_ViewRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 526);
            this.Controls.Add(this.GridView_ShowRole);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ViewRole";
            this.Text = "Phân quyền User/Role";
            this.Load += new System.EventHandler(this.Frm_Edit_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ShowRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_ShowRole;
    }
}
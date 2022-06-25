
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ViewRole));
            this.GridView_ShowRole = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_Update_col_priv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ShowRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Update_col_priv)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_ShowRole
            // 
            this.GridView_ShowRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_ShowRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_ShowRole.Location = new System.Drawing.Point(38, 31);
            this.GridView_ShowRole.Name = "GridView_ShowRole";
            this.GridView_ShowRole.RowHeadersWidth = 51;
            this.GridView_ShowRole.RowTemplate.Height = 24;
            this.GridView_ShowRole.Size = new System.Drawing.Size(983, 245);
            this.GridView_ShowRole.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table privileges";
            // 
            // gv_Update_col_priv
            // 
            this.gv_Update_col_priv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Update_col_priv.Location = new System.Drawing.Point(38, 334);
            this.gv_Update_col_priv.Name = "gv_Update_col_priv";
            this.gv_Update_col_priv.RowHeadersWidth = 51;
            this.gv_Update_col_priv.RowTemplate.Height = 24;
            this.gv_Update_col_priv.Size = new System.Drawing.Size(991, 211);
            this.gv_Update_col_priv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update column privileges";
            // 
            // frm_ViewRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gv_Update_col_priv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView_ShowRole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ViewRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền User/Role";
            this.Load += new System.EventHandler(this.Frm_Edit_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ShowRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Update_col_priv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_ShowRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_Update_col_priv;
        private System.Windows.Forms.Label label2;
    }
}
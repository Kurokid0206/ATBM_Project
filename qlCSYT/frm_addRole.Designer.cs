
namespace qlCSYT
{
    partial class frm_addRole
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
            this.lb_roleName = new System.Windows.Forms.Label();
            this.tb_roleName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_roleName
            // 
            this.lb_roleName.AutoSize = true;
            this.lb_roleName.Location = new System.Drawing.Point(85, 62);
            this.lb_roleName.Name = "lb_roleName";
            this.lb_roleName.Size = new System.Drawing.Size(46, 13);
            this.lb_roleName.TabIndex = 0;
            this.lb_roleName.Text = "Tên role";
            // 
            // tb_roleName
            // 
            this.tb_roleName.Location = new System.Drawing.Point(151, 62);
            this.tb_roleName.Name = "tb_roleName";
            this.tb_roleName.Size = new System.Drawing.Size(100, 20);
            this.tb_roleName.TabIndex = 1;
            // 
            // frm_addRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_roleName);
            this.Controls.Add(this.lb_roleName);
            this.Name = "frm_addRole";
            this.Text = "Thêm role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_roleName;
        private System.Windows.Forms.TextBox tb_roleName;
    }
}
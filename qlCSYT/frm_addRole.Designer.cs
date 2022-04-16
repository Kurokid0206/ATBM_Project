
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addRole));
            this.lb_roleName = new System.Windows.Forms.Label();
            this.tb_roleName = new System.Windows.Forms.TextBox();
            this.btn_addRole = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_roleName
            // 
            this.lb_roleName.AutoSize = true;
            this.lb_roleName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_roleName.Location = new System.Drawing.Point(22, 31);
            this.lb_roleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_roleName.Name = "lb_roleName";
            this.lb_roleName.Size = new System.Drawing.Size(92, 27);
            this.lb_roleName.TabIndex = 0;
            this.lb_roleName.Text = "Tên role";
            // 
            // tb_roleName
            // 
            this.tb_roleName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_roleName.Location = new System.Drawing.Point(138, 31);
            this.tb_roleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_roleName.Name = "tb_roleName";
            this.tb_roleName.Size = new System.Drawing.Size(232, 34);
            this.tb_roleName.TabIndex = 1;
            // 
            // btn_addRole
            // 
            this.btn_addRole.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRole.Location = new System.Drawing.Point(138, 74);
            this.btn_addRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addRole.Name = "btn_addRole";
            this.btn_addRole.Size = new System.Drawing.Size(112, 46);
            this.btn_addRole.TabIndex = 2;
            this.btn_addRole.Text = "Thêm role";
            this.btn_addRole.UseVisualStyleBackColor = true;
            this.btn_addRole.Click += new System.EventHandler(this.btn_addRole_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(271, 74);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 46);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_addRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 164);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addRole);
            this.Controls.Add(this.tb_roleName);
            this.Controls.Add(this.lb_roleName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_addRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_roleName;
        private System.Windows.Forms.TextBox tb_roleName;
        private System.Windows.Forms.Button btn_addRole;
        private System.Windows.Forms.Button btn_cancel;
    }
}
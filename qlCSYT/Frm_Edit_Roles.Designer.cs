
namespace qlCSYT
{
    partial class Frm_Edit_Roles
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
            this.Grant_priv_btn = new System.Windows.Forms.Button();
            this.Revoke_priv_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Grant_priv_btn
            // 
            this.Grant_priv_btn.Location = new System.Drawing.Point(2, 2);
            this.Grant_priv_btn.Name = "Grant_priv_btn";
            this.Grant_priv_btn.Size = new System.Drawing.Size(118, 36);
            this.Grant_priv_btn.TabIndex = 0;
            this.Grant_priv_btn.Text = "Cấp quyền";
            this.Grant_priv_btn.UseVisualStyleBackColor = true;
            this.Grant_priv_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Revoke_priv_btn
            // 
            this.Revoke_priv_btn.Location = new System.Drawing.Point(126, 2);
            this.Revoke_priv_btn.Name = "Revoke_priv_btn";
            this.Revoke_priv_btn.Size = new System.Drawing.Size(117, 36);
            this.Revoke_priv_btn.TabIndex = 1;
            this.Revoke_priv_btn.Text = "Thu hồi quyền";
            this.Revoke_priv_btn.UseVisualStyleBackColor = true;
            // 
            // Frm_Edit_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 526);
            this.Controls.Add(this.Revoke_priv_btn);
            this.Controls.Add(this.Grant_priv_btn);
            this.Name = "Frm_Edit_Roles";
            this.Text = "Phân quyền User/Role";
            this.Load += new System.EventHandler(this.Frm_Edit_Roles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Grant_priv_btn;
        private System.Windows.Forms.Button Revoke_priv_btn;
    }
}
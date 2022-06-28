namespace qlCSYT
{
    partial class frm_modifyBN
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
            this.tb_MaBN = new System.Windows.Forms.TextBox();
            this.lb_MaBN = new System.Windows.Forms.Label();
            this.cbMedFac = new System.Windows.Forms.ComboBox();
            this.lb_csytID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_MaBN
            // 
            this.tb_MaBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaBN.Location = new System.Drawing.Point(148, 6);
            this.tb_MaBN.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaBN.Name = "tb_MaBN";
            this.tb_MaBN.Size = new System.Drawing.Size(353, 31);
            this.tb_MaBN.TabIndex = 4;
            // 
            // lb_MaBN
            // 
            this.lb_MaBN.AutoSize = true;
            this.lb_MaBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBN.Location = new System.Drawing.Point(4, 9);
            this.lb_MaBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MaBN.Name = "lb_MaBN";
            this.lb_MaBN.Size = new System.Drawing.Size(130, 23);
            this.lb_MaBN.TabIndex = 3;
            this.lb_MaBN.Text = "Mã bệnh nhân";
            // 
            // cbMedFac
            // 
            this.cbMedFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedFac.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedFac.FormattingEnabled = true;
            this.cbMedFac.Location = new System.Drawing.Point(148, 45);
            this.cbMedFac.Margin = new System.Windows.Forms.Padding(4);
            this.cbMedFac.Name = "cbMedFac";
            this.cbMedFac.Size = new System.Drawing.Size(354, 31);
            this.cbMedFac.TabIndex = 36;
            // 
            // lb_csytID
            // 
            this.lb_csytID.AutoSize = true;
            this.lb_csytID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_csytID.Location = new System.Drawing.Point(4, 45);
            this.lb_csytID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_csytID.Name = "lb_csytID";
            this.lb_csytID.Size = new System.Drawing.Size(89, 23);
            this.lb_csytID.TabIndex = 35;
            this.lb_csytID.Text = "Mã CSYT:";
            // 
            // frm_modifyBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.cbMedFac);
            this.Controls.Add(this.lb_csytID);
            this.Controls.Add(this.tb_MaBN);
            this.Controls.Add(this.lb_MaBN);
            this.Name = "frm_modifyBN";
            this.Text = "Chỉnh sửa thông tin bệnh nhân";
            this.Load += new System.EventHandler(this.frm_modifyBN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MaBN;
        private System.Windows.Forms.Label lb_MaBN;
        private System.Windows.Forms.ComboBox cbMedFac;
        private System.Windows.Forms.Label lb_csytID;
    }
}
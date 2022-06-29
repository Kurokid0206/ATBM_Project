namespace qlCSYT
{
    partial class frm_YsBs_viewPatient
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
            this.btn_searchCMND = new System.Windows.Forms.Button();
            this.btn_searchMaBN = new System.Windows.Forms.Button();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbMaBN = new System.Windows.Forms.TextBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbMaBN = new System.Windows.Forms.Label();
            this.gv_viewPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_viewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_searchCMND
            // 
            this.btn_searchCMND.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchCMND.Location = new System.Drawing.Point(386, 36);
            this.btn_searchCMND.Name = "btn_searchCMND";
            this.btn_searchCMND.Size = new System.Drawing.Size(66, 23);
            this.btn_searchCMND.TabIndex = 11;
            this.btn_searchCMND.Text = "Xem";
            this.btn_searchCMND.UseVisualStyleBackColor = true;
            this.btn_searchCMND.Click += new System.EventHandler(this.btn_searchCMND_Click);
            // 
            // btn_searchMaBN
            // 
            this.btn_searchMaBN.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchMaBN.Location = new System.Drawing.Point(386, 2);
            this.btn_searchMaBN.Name = "btn_searchMaBN";
            this.btn_searchMaBN.Size = new System.Drawing.Size(66, 23);
            this.btn_searchMaBN.TabIndex = 10;
            this.btn_searchMaBN.Text = "Xem";
            this.btn_searchMaBN.UseVisualStyleBackColor = true;
            this.btn_searchMaBN.Click += new System.EventHandler(this.btn_searchMaBN_Click);
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(147, 37);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(233, 22);
            this.tbCMND.TabIndex = 9;
            // 
            // tbMaBN
            // 
            this.tbMaBN.Location = new System.Drawing.Point(147, 3);
            this.tbMaBN.Name = "tbMaBN";
            this.tbMaBN.Size = new System.Drawing.Size(233, 22);
            this.tbMaBN.TabIndex = 8;
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(1, 36);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(69, 23);
            this.lbCMND.TabIndex = 7;
            this.lbCMND.Text = "CMND:";
            // 
            // lbMaBN
            // 
            this.lbMaBN.AutoSize = true;
            this.lbMaBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBN.Location = new System.Drawing.Point(1, 3);
            this.lbMaBN.Name = "lbMaBN";
            this.lbMaBN.Size = new System.Drawing.Size(135, 23);
            this.lbMaBN.TabIndex = 6;
            this.lbMaBN.Text = "Mã bệnh nhân:";
            // 
            // gv_viewPatient
            // 
            this.gv_viewPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_viewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_viewPatient.Location = new System.Drawing.Point(5, 64);
            this.gv_viewPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_viewPatient.Name = "gv_viewPatient";
            this.gv_viewPatient.RowHeadersWidth = 51;
            this.gv_viewPatient.RowTemplate.Height = 24;
            this.gv_viewPatient.Size = new System.Drawing.Size(1606, 112);
            this.gv_viewPatient.TabIndex = 12;
            this.gv_viewPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_viewPatient_CellContentClick);
            // 
            // frm_YsBs_viewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 187);
            this.Controls.Add(this.gv_viewPatient);
            this.Controls.Add(this.btn_searchCMND);
            this.Controls.Add(this.btn_searchMaBN);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.tbMaBN);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbMaBN);
            this.Name = "frm_YsBs_viewPatient";
            this.Text = "Xem hồ sơ bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.gv_viewPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_searchCMND;
        private System.Windows.Forms.Button btn_searchMaBN;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbMaBN;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbMaBN;
        private System.Windows.Forms.DataGridView gv_viewPatient;
    }
}
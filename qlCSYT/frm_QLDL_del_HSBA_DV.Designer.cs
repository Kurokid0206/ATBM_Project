
namespace qlCSYT
{
    partial class frm_QLDL_del_HSBA_DV
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
            this.del_HSBA_btn = new System.Windows.Forms.Button();
            this.MaHSBA_del_input = new System.Windows.Forms.TextBox();
            this.del_HSBA_title = new System.Windows.Forms.Label();
            this.input_MaHSBA_lable = new System.Windows.Forms.Label();
            this.MaDV_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // del_HSBA_btn
            // 
            this.del_HSBA_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.del_HSBA_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_HSBA_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_HSBA_btn.Location = new System.Drawing.Point(539, 276);
            this.del_HSBA_btn.Name = "del_HSBA_btn";
            this.del_HSBA_btn.Size = new System.Drawing.Size(133, 38);
            this.del_HSBA_btn.TabIndex = 9;
            this.del_HSBA_btn.Text = "Xóa";
            this.del_HSBA_btn.UseVisualStyleBackColor = false;
            this.del_HSBA_btn.Click += new System.EventHandler(this.del_HSBA_btn_Click);
            // 
            // MaHSBA_del_input
            // 
            this.MaHSBA_del_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHSBA_del_input.Location = new System.Drawing.Point(97, 127);
            this.MaHSBA_del_input.Name = "MaHSBA_del_input";
            this.MaHSBA_del_input.Size = new System.Drawing.Size(575, 32);
            this.MaHSBA_del_input.TabIndex = 8;
            // 
            // del_HSBA_title
            // 
            this.del_HSBA_title.AutoSize = true;
            this.del_HSBA_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_HSBA_title.Location = new System.Drawing.Point(217, 9);
            this.del_HSBA_title.Name = "del_HSBA_title";
            this.del_HSBA_title.Size = new System.Drawing.Size(381, 29);
            this.del_HSBA_title.TabIndex = 7;
            this.del_HSBA_title.Text = "XÓA DỊCH VỤ HỒ SƠ BỆNH ÁN";
            // 
            // input_MaHSBA_lable
            // 
            this.input_MaHSBA_lable.AutoSize = true;
            this.input_MaHSBA_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_MaHSBA_lable.Location = new System.Drawing.Point(93, 98);
            this.input_MaHSBA_lable.Name = "input_MaHSBA_lable";
            this.input_MaHSBA_lable.Size = new System.Drawing.Size(250, 26);
            this.input_MaHSBA_lable.TabIndex = 6;
            this.input_MaHSBA_lable.Text = "Nhập mã hồ sơ bệnh án:";
            this.input_MaHSBA_lable.UseMnemonic = false;
            // 
            // MaDV_input
            // 
            this.MaDV_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDV_input.Location = new System.Drawing.Point(97, 208);
            this.MaDV_input.Name = "MaDV_input";
            this.MaDV_input.Size = new System.Drawing.Size(575, 32);
            this.MaDV_input.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập mã dịch vụ:";
            this.label1.UseMnemonic = false;
            // 
            // frm_QLDL_del_HSBA_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.MaDV_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_HSBA_btn);
            this.Controls.Add(this.MaHSBA_del_input);
            this.Controls.Add(this.del_HSBA_title);
            this.Controls.Add(this.input_MaHSBA_lable);
            this.Name = "frm_QLDL_del_HSBA_DV";
            this.Text = "Xóa dịch vụ hồ sơ bệnh án";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_HSBA_btn;
        private System.Windows.Forms.TextBox MaHSBA_del_input;
        private System.Windows.Forms.Label del_HSBA_title;
        private System.Windows.Forms.Label input_MaHSBA_lable;
        private System.Windows.Forms.TextBox MaDV_input;
        private System.Windows.Forms.Label label1;
    }
}
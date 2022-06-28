
namespace qlCSYT
{
    partial class frm_QLDL_del_HSBA
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
            this.input_MaHSBA_lable = new System.Windows.Forms.Label();
            this.del_HSBA_title = new System.Windows.Forms.Label();
            this.MaHSBA_input = new System.Windows.Forms.TextBox();
            this.del_HSBA_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_MaHSBA_lable
            // 
            this.input_MaHSBA_lable.AutoSize = true;
            this.input_MaHSBA_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_MaHSBA_lable.Location = new System.Drawing.Point(82, 89);
            this.input_MaHSBA_lable.Name = "input_MaHSBA_lable";
            this.input_MaHSBA_lable.Size = new System.Drawing.Size(250, 26);
            this.input_MaHSBA_lable.TabIndex = 0;
            this.input_MaHSBA_lable.Text = "Nhập mã hồ sơ bệnh án:";
            this.input_MaHSBA_lable.UseMnemonic = false;
            // 
            // del_HSBA_title
            // 
            this.del_HSBA_title.AutoSize = true;
            this.del_HSBA_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_HSBA_title.Location = new System.Drawing.Point(258, 9);
            this.del_HSBA_title.Name = "del_HSBA_title";
            this.del_HSBA_title.Size = new System.Drawing.Size(272, 29);
            this.del_HSBA_title.TabIndex = 1;
            this.del_HSBA_title.Text = "XÓA HỒ SƠ BỆNH ÁN";
            // 
            // MaHSBA_input
            // 
            this.MaHSBA_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHSBA_input.Location = new System.Drawing.Point(86, 118);
            this.MaHSBA_input.Name = "MaHSBA_input";
            this.MaHSBA_input.Size = new System.Drawing.Size(328, 32);
            this.MaHSBA_input.TabIndex = 2;
            // 
            // del_HSBA_btn
            // 
            this.del_HSBA_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.del_HSBA_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_HSBA_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_HSBA_btn.Location = new System.Drawing.Point(463, 118);
            this.del_HSBA_btn.Name = "del_HSBA_btn";
            this.del_HSBA_btn.Size = new System.Drawing.Size(127, 32);
            this.del_HSBA_btn.TabIndex = 5;
            this.del_HSBA_btn.Text = "Xóa";
            this.del_HSBA_btn.UseVisualStyleBackColor = false;
            this.del_HSBA_btn.Click += new System.EventHandler(this.del_HSBA_btn_Click);
            // 
            // frm_QLDL_del_HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.del_HSBA_btn);
            this.Controls.Add(this.MaHSBA_input);
            this.Controls.Add(this.del_HSBA_title);
            this.Controls.Add(this.input_MaHSBA_lable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QLDL_del_HSBA";
            this.Text = "frm_QLDL_del_HSBA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_MaHSBA_lable;
        private System.Windows.Forms.Label del_HSBA_title;
        private System.Windows.Forms.TextBox MaHSBA_input;
        private System.Windows.Forms.Button del_HSBA_btn;
    }
}
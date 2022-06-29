
namespace qlCSYT
{
    partial class frm_ThongBao
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
            this.gv_ThongBao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_ThongBao
            // 
            this.gv_ThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ThongBao.Location = new System.Drawing.Point(2, 0);
            this.gv_ThongBao.Name = "gv_ThongBao";
            this.gv_ThongBao.Size = new System.Drawing.Size(542, 205);
            this.gv_ThongBao.TabIndex = 0;
            // 
            // frm_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 208);
            this.Controls.Add(this.gv_ThongBao);
            this.Name = "frm_ThongBao";
            this.Text = "frm_ThongBao";
            this.Load += new System.EventHandler(this.frm_ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_ThongBao;
    }
}
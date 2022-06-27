
namespace qlCSYT
{
    partial class frm_QLDL_main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.QLDL_menustrip = new System.Windows.Forms.MenuStrip();
            this.add_HSBA_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.del_HSBA_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.add_HSBADV_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.del_HSBADV_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.add_HSBA_group = new System.Windows.Forms.GroupBox();
            this.add_HSBA_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Khoa_select = new System.Windows.Forms.Label();
            this.ChanDoan_input = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NgayLap_input = new System.Windows.Forms.Label();
            this.MaBN_select = new System.Windows.Forms.ComboBox();
            this.select_mabn_lable = new System.Windows.Forms.Label();
            this.QLDL_menustrip.SuspendLayout();
            this.add_HSBA_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // QLDL_menustrip
            // 
            this.QLDL_menustrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.QLDL_menustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.QLDL_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_HSBA_strip,
            this.del_HSBA_strip,
            this.add_HSBADV_strip,
            this.del_HSBADV_strip});
            this.QLDL_menustrip.Location = new System.Drawing.Point(0, 0);
            this.QLDL_menustrip.Name = "QLDL_menustrip";
            this.QLDL_menustrip.Size = new System.Drawing.Size(800, 31);
            this.QLDL_menustrip.TabIndex = 2;
            this.QLDL_menustrip.Text = "menuStrip1";
            // 
            // add_HSBA_strip
            // 
            this.add_HSBA_strip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.add_HSBA_strip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.add_HSBA_strip.Name = "add_HSBA_strip";
            this.add_HSBA_strip.Size = new System.Drawing.Size(114, 27);
            this.add_HSBA_strip.Text = "Thêm HSBA";
            this.add_HSBA_strip.Click += new System.EventHandler(this.thêmHSBAToolStripMenuItem_Click);
            // 
            // del_HSBA_strip
            // 
            this.del_HSBA_strip.Name = "del_HSBA_strip";
            this.del_HSBA_strip.Size = new System.Drawing.Size(100, 27);
            this.del_HSBA_strip.Text = "Xóa HSBA";
            // 
            // add_HSBADV_strip
            // 
            this.add_HSBADV_strip.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.add_HSBADV_strip.Name = "add_HSBADV_strip";
            this.add_HSBADV_strip.Size = new System.Drawing.Size(206, 27);
            this.add_HSBADV_strip.Text = "Thêm dịch vụ vào HSBA";
            // 
            // del_HSBADV_strip
            // 
            this.del_HSBADV_strip.Name = "del_HSBADV_strip";
            this.del_HSBADV_strip.Size = new System.Drawing.Size(181, 27);
            this.del_HSBADV_strip.Text = "Xóa dịch vụ từ HSBA";
            // 
            // add_HSBA_group
            // 
            this.add_HSBA_group.Controls.Add(this.add_HSBA_btn);
            this.add_HSBA_group.Controls.Add(this.comboBox1);
            this.add_HSBA_group.Controls.Add(this.label1);
            this.add_HSBA_group.Controls.Add(this.comboBox2);
            this.add_HSBA_group.Controls.Add(this.Khoa_select);
            this.add_HSBA_group.Controls.Add(this.ChanDoan_input);
            this.add_HSBA_group.Controls.Add(this.textBox1);
            this.add_HSBA_group.Controls.Add(this.dateTimePicker1);
            this.add_HSBA_group.Controls.Add(this.NgayLap_input);
            this.add_HSBA_group.Controls.Add(this.MaBN_select);
            this.add_HSBA_group.Controls.Add(this.select_mabn_lable);
            this.add_HSBA_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_HSBA_group.Location = new System.Drawing.Point(21, 52);
            this.add_HSBA_group.Name = "add_HSBA_group";
            this.add_HSBA_group.Size = new System.Drawing.Size(744, 367);
            this.add_HSBA_group.TabIndex = 3;
            this.add_HSBA_group.TabStop = false;
            this.add_HSBA_group.Text = "Thêm hồ sơ bệnh án";
            // 
            // add_HSBA_btn
            // 
            this.add_HSBA_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_HSBA_btn.Location = new System.Drawing.Point(618, 330);
            this.add_HSBA_btn.Name = "add_HSBA_btn";
            this.add_HSBA_btn.Size = new System.Drawing.Size(120, 31);
            this.add_HSBA_btn.TabIndex = 11;
            this.add_HSBA_btn.Text = "Thêm";
            this.add_HSBA_btn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(376, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bác sĩ:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(292, 33);
            this.comboBox2.TabIndex = 8;
            // 
            // Khoa_select
            // 
            this.Khoa_select.AutoSize = true;
            this.Khoa_select.Location = new System.Drawing.Point(26, 127);
            this.Khoa_select.Name = "Khoa_select";
            this.Khoa_select.Size = new System.Drawing.Size(65, 25);
            this.Khoa_select.TabIndex = 7;
            this.Khoa_select.Text = "Khoa:";
            // 
            // ChanDoan_input
            // 
            this.ChanDoan_input.AutoSize = true;
            this.ChanDoan_input.Location = new System.Drawing.Point(30, 199);
            this.ChanDoan_input.Name = "ChanDoan_input";
            this.ChanDoan_input.Size = new System.Drawing.Size(115, 25);
            this.ChanDoan_input.TabIndex = 6;
            this.ChanDoan_input.Text = "Chẩn đoán:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 227);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(685, 65);
            this.textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(376, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 30);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // NgayLap_input
            // 
            this.NgayLap_input.AutoSize = true;
            this.NgayLap_input.Location = new System.Drawing.Point(373, 44);
            this.NgayLap_input.Name = "NgayLap_input";
            this.NgayLap_input.Size = new System.Drawing.Size(95, 25);
            this.NgayLap_input.TabIndex = 3;
            this.NgayLap_input.Text = "Ngày lập:";
            // 
            // MaBN_select
            // 
            this.MaBN_select.FormattingEnabled = true;
            this.MaBN_select.Location = new System.Drawing.Point(31, 69);
            this.MaBN_select.Name = "MaBN_select";
            this.MaBN_select.Size = new System.Drawing.Size(292, 33);
            this.MaBN_select.TabIndex = 2;
            // 
            // select_mabn_lable
            // 
            this.select_mabn_lable.AutoSize = true;
            this.select_mabn_lable.Location = new System.Drawing.Point(26, 41);
            this.select_mabn_lable.Name = "select_mabn_lable";
            this.select_mabn_lable.Size = new System.Drawing.Size(113, 25);
            this.select_mabn_lable.TabIndex = 1;
            this.select_mabn_lable.Text = "Bệnh nhân:";
            // 
            // frm_QLDL_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_HSBA_group);
            this.Controls.Add(this.QLDL_menustrip);
            this.MainMenuStrip = this.QLDL_menustrip;
            this.Name = "frm_QLDL_main";
            this.Text = "frm_QLDL_main";
            this.QLDL_menustrip.ResumeLayout(false);
            this.QLDL_menustrip.PerformLayout();
            this.add_HSBA_group.ResumeLayout(false);
            this.add_HSBA_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip QLDL_menustrip;
        private System.Windows.Forms.ToolStripMenuItem add_HSBA_strip;
        private System.Windows.Forms.ToolStripMenuItem del_HSBA_strip;
        private System.Windows.Forms.ToolStripMenuItem add_HSBADV_strip;
        private System.Windows.Forms.ToolStripMenuItem del_HSBADV_strip;
        private System.Windows.Forms.GroupBox add_HSBA_group;
        private System.Windows.Forms.Label NgayLap_input;
        private System.Windows.Forms.ComboBox MaBN_select;
        private System.Windows.Forms.Label select_mabn_lable;
        private System.Windows.Forms.Label ChanDoan_input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Khoa_select;
        private System.Windows.Forms.Button add_HSBA_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
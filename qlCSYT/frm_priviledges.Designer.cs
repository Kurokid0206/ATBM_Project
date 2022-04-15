
namespace qlCSYT
{
    partial class frm_priviledges
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
            this.gv_tables = new System.Windows.Forms.DataGridView();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.btn_addDelPriv = new System.Windows.Forms.Button();
            this.btn_addInsPriv = new System.Windows.Forms.Button();
            this.cb_tblList = new System.Windows.Forms.ComboBox();
            this.rbtn_user = new System.Windows.Forms.RadioButton();
            this.rbtn_role = new System.Windows.Forms.RadioButton();
            this.cb_roles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tables)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_tables
            // 
            this.gv_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_tables.Location = new System.Drawing.Point(58, 121);
            this.gv_tables.Name = "gv_tables";
            this.gv_tables.Size = new System.Drawing.Size(692, 150);
            this.gv_tables.TabIndex = 0;
            // 
            // cb_user
            // 
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(94, 46);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(121, 21);
            this.cb_user.TabIndex = 1;
            // 
            // btn_addDelPriv
            // 
            this.btn_addDelPriv.Location = new System.Drawing.Point(134, 332);
            this.btn_addDelPriv.Name = "btn_addDelPriv";
            this.btn_addDelPriv.Size = new System.Drawing.Size(165, 59);
            this.btn_addDelPriv.TabIndex = 2;
            this.btn_addDelPriv.Text = "Cấp quyền xóa dữ liệu";
            this.btn_addDelPriv.UseVisualStyleBackColor = true;
            // 
            // btn_addInsPriv
            // 
            this.btn_addInsPriv.Location = new System.Drawing.Point(445, 332);
            this.btn_addInsPriv.Name = "btn_addInsPriv";
            this.btn_addInsPriv.Size = new System.Drawing.Size(157, 59);
            this.btn_addInsPriv.TabIndex = 3;
            this.btn_addInsPriv.Text = "Cấp quyền thêm dữ liệu";
            this.btn_addInsPriv.UseVisualStyleBackColor = true;
            // 
            // cb_tblList
            // 
            this.cb_tblList.FormattingEnabled = true;
            this.cb_tblList.Location = new System.Drawing.Point(561, 46);
            this.cb_tblList.Name = "cb_tblList";
            this.cb_tblList.Size = new System.Drawing.Size(121, 21);
            this.cb_tblList.TabIndex = 4;
            // 
            // rbtn_user
            // 
            this.rbtn_user.AutoSize = true;
            this.rbtn_user.Location = new System.Drawing.Point(74, 49);
            this.rbtn_user.Name = "rbtn_user";
            this.rbtn_user.Size = new System.Drawing.Size(14, 13);
            this.rbtn_user.TabIndex = 5;
            this.rbtn_user.TabStop = true;
            this.rbtn_user.UseVisualStyleBackColor = true;
            this.rbtn_user.CheckedChanged += new System.EventHandler(this.rbtn_user_CheckedChanged);
            // 
            // rbtn_role
            // 
            this.rbtn_role.AutoSize = true;
            this.rbtn_role.Location = new System.Drawing.Point(74, 76);
            this.rbtn_role.Name = "rbtn_role";
            this.rbtn_role.Size = new System.Drawing.Size(14, 13);
            this.rbtn_role.TabIndex = 7;
            this.rbtn_role.TabStop = true;
            this.rbtn_role.UseVisualStyleBackColor = true;
            this.rbtn_role.CheckedChanged += new System.EventHandler(this.rbtn_role_CheckedChanged);
            // 
            // cb_roles
            // 
            this.cb_roles.FormattingEnabled = true;
            this.cb_roles.Location = new System.Drawing.Point(94, 73);
            this.cb_roles.Name = "cb_roles";
            this.cb_roles.Size = new System.Drawing.Size(121, 21);
            this.cb_roles.TabIndex = 6;
            // 
            // frm_priviledges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_role);
            this.Controls.Add(this.cb_roles);
            this.Controls.Add(this.rbtn_user);
            this.Controls.Add(this.cb_tblList);
            this.Controls.Add(this.btn_addInsPriv);
            this.Controls.Add(this.btn_addDelPriv);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.gv_tables);
            this.Name = "frm_priviledges";
            this.Text = "Thêm quyền";
            this.Load += new System.EventHandler(this.frm_priviledges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_tables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_tables;
        private System.Windows.Forms.ComboBox cb_user;
        private System.Windows.Forms.Button btn_addDelPriv;
        private System.Windows.Forms.Button btn_addInsPriv;
        private System.Windows.Forms.ComboBox cb_tblList;
        private System.Windows.Forms.RadioButton rbtn_user;
        private System.Windows.Forms.RadioButton rbtn_role;
        private System.Windows.Forms.ComboBox cb_roles;
    }
}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_priviledges));
            this.gv_tables = new System.Windows.Forms.DataGridView();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.btn_addDelPriv = new System.Windows.Forms.Button();
            this.btn_addInsPriv = new System.Windows.Forms.Button();
            this.cb_tblList = new System.Windows.Forms.ComboBox();
            this.rbtn_user = new System.Windows.Forms.RadioButton();
            this.rbtn_role = new System.Windows.Forms.RadioButton();
            this.cb_roles = new System.Windows.Forms.ComboBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Role = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tables)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_tables
            // 
            this.gv_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_tables.Location = new System.Drawing.Point(13, 86);
            this.gv_tables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_tables.Name = "gv_tables";
            this.gv_tables.RowHeadersWidth = 51;
            this.gv_tables.Size = new System.Drawing.Size(558, 185);
            this.gv_tables.TabIndex = 0;
            // 
            // cb_user
            // 
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(78, 13);
            this.cb_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(160, 24);
            this.cb_user.TabIndex = 1;
            // 
            // btn_addDelPriv
            // 
            this.btn_addDelPriv.Location = new System.Drawing.Point(40, 291);
            this.btn_addDelPriv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addDelPriv.Name = "btn_addDelPriv";
            this.btn_addDelPriv.Size = new System.Drawing.Size(220, 73);
            this.btn_addDelPriv.TabIndex = 2;
            this.btn_addDelPriv.Text = "Cấp quyền xóa dữ liệu";
            this.btn_addDelPriv.UseVisualStyleBackColor = true;
            // 
            // btn_addInsPriv
            // 
            this.btn_addInsPriv.Location = new System.Drawing.Point(335, 291);
            this.btn_addInsPriv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addInsPriv.Name = "btn_addInsPriv";
            this.btn_addInsPriv.Size = new System.Drawing.Size(209, 73);
            this.btn_addInsPriv.TabIndex = 3;
            this.btn_addInsPriv.Text = "Cấp quyền thêm dữ liệu";
            this.btn_addInsPriv.UseVisualStyleBackColor = true;
            // 
            // cb_tblList
            // 
            this.cb_tblList.FormattingEnabled = true;
            this.cb_tblList.Location = new System.Drawing.Point(411, 13);
            this.cb_tblList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_tblList.Name = "cb_tblList";
            this.cb_tblList.Size = new System.Drawing.Size(160, 24);
            this.cb_tblList.TabIndex = 4;
            // 
            // rbtn_user
            // 
            this.rbtn_user.AutoSize = true;
            this.rbtn_user.Location = new System.Drawing.Point(53, 16);
            this.rbtn_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_user.Name = "rbtn_user";
            this.rbtn_user.Size = new System.Drawing.Size(17, 16);
            this.rbtn_user.TabIndex = 5;
            this.rbtn_user.TabStop = true;
            this.rbtn_user.UseVisualStyleBackColor = true;
            this.rbtn_user.CheckedChanged += new System.EventHandler(this.rbtn_user_CheckedChanged);
            // 
            // rbtn_role
            // 
            this.rbtn_role.AutoSize = true;
            this.rbtn_role.Location = new System.Drawing.Point(53, 57);
            this.rbtn_role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_role.Name = "rbtn_role";
            this.rbtn_role.Size = new System.Drawing.Size(17, 16);
            this.rbtn_role.TabIndex = 7;
            this.rbtn_role.TabStop = true;
            this.rbtn_role.UseVisualStyleBackColor = true;
            this.rbtn_role.CheckedChanged += new System.EventHandler(this.rbtn_role_CheckedChanged);
            // 
            // cb_roles
            // 
            this.cb_roles.FormattingEnabled = true;
            this.cb_roles.Location = new System.Drawing.Point(78, 54);
            this.cb_roles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_roles.Name = "cb_roles";
            this.cb_roles.Size = new System.Drawing.Size(160, 24);
            this.cb_roles.TabIndex = 6;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(10, 16);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(36, 16);
            this.lb_User.TabIndex = 8;
            this.lb_User.Text = "User";
            this.lb_User.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Role
            // 
            this.lb_Role.AutoSize = true;
            this.lb_Role.Location = new System.Drawing.Point(10, 57);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(36, 16);
            this.lb_Role.TabIndex = 9;
            this.lb_Role.Text = "Role";
            // 
            // frm_priviledges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 379);
            this.Controls.Add(this.lb_Role);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.rbtn_role);
            this.Controls.Add(this.cb_roles);
            this.Controls.Add(this.rbtn_user);
            this.Controls.Add(this.cb_tblList);
            this.Controls.Add(this.btn_addInsPriv);
            this.Controls.Add(this.btn_addDelPriv);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.gv_tables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_priviledges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Role;
    }
}
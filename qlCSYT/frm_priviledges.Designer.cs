
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
            this.lb_Table = new System.Windows.Forms.Label();
            this.GrantOpt_btn = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_showPriv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tables)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_tables
            // 
            this.gv_tables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_tables.Location = new System.Drawing.Point(13, 180);
            this.gv_tables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_tables.Name = "gv_tables";
            this.gv_tables.RowHeadersWidth = 51;
            this.gv_tables.Size = new System.Drawing.Size(754, 321);
            this.gv_tables.TabIndex = 0;
            // 
            // cb_user
            // 
            this.cb_user.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(77, 14);
            this.cb_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(362, 31);
            this.cb_user.TabIndex = 1;
            this.cb_user.SelectedIndexChanged += new System.EventHandler(this.cb_user_SelectedIndexChanged);
            // 
            // btn_addDelPriv
            // 
            this.btn_addDelPriv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDelPriv.Location = new System.Drawing.Point(511, 68);
            this.btn_addDelPriv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addDelPriv.Name = "btn_addDelPriv";
            this.btn_addDelPriv.Size = new System.Drawing.Size(256, 54);
            this.btn_addDelPriv.TabIndex = 2;
            this.btn_addDelPriv.Text = "Cấp quyền xóa dữ liệu";
            this.btn_addDelPriv.UseVisualStyleBackColor = true;
            this.btn_addDelPriv.Click += new System.EventHandler(this.btn_addDelPriv_Click);
            // 
            // btn_addInsPriv
            // 
            this.btn_addInsPriv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addInsPriv.Location = new System.Drawing.Point(511, 13);
            this.btn_addInsPriv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addInsPriv.Name = "btn_addInsPriv";
            this.btn_addInsPriv.Size = new System.Drawing.Size(256, 53);
            this.btn_addInsPriv.TabIndex = 3;
            this.btn_addInsPriv.Text = "Cấp quyền thêm dữ liệu";
            this.btn_addInsPriv.UseVisualStyleBackColor = true;
            this.btn_addInsPriv.Click += new System.EventHandler(this.btn_addInsPriv_Click);
            // 
            // cb_tblList
            // 
            this.cb_tblList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tblList.FormattingEnabled = true;
            this.cb_tblList.Location = new System.Drawing.Point(77, 91);
            this.cb_tblList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_tblList.Name = "cb_tblList";
            this.cb_tblList.Size = new System.Drawing.Size(362, 31);
            this.cb_tblList.TabIndex = 4;
            // 
            // rbtn_user
            // 
            this.rbtn_user.AutoSize = true;
            this.rbtn_user.Location = new System.Drawing.Point(447, 22);
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
            this.rbtn_role.Location = new System.Drawing.Point(447, 62);
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
            this.cb_roles.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_roles.FormattingEnabled = true;
            this.cb_roles.Location = new System.Drawing.Point(77, 52);
            this.cb_roles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_roles.Name = "cb_roles";
            this.cb_roles.Size = new System.Drawing.Size(362, 31);
            this.cb_roles.TabIndex = 6;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(15, 16);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(50, 23);
            this.lb_User.TabIndex = 8;
            this.lb_User.Text = "User";
            this.lb_User.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Role
            // 
            this.lb_Role.AutoSize = true;
            this.lb_Role.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Role.Location = new System.Drawing.Point(15, 55);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(48, 23);
            this.lb_Role.TabIndex = 9;
            this.lb_Role.Text = "Role";
            // 
            // lb_Table
            // 
            this.lb_Table.AutoSize = true;
            this.lb_Table.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Table.Location = new System.Drawing.Point(15, 94);
            this.lb_Table.Name = "lb_Table";
            this.lb_Table.Size = new System.Drawing.Size(56, 23);
            this.lb_Table.TabIndex = 10;
            this.lb_Table.Text = "Table";
            // 
            // GrantOpt_btn
            // 
            this.GrantOpt_btn.AutoSize = true;
            this.GrantOpt_btn.Location = new System.Drawing.Point(19, 143);
            this.GrantOpt_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrantOpt_btn.Name = "GrantOpt_btn";
            this.GrantOpt_btn.Size = new System.Drawing.Size(262, 21);
            this.GrantOpt_btn.TabIndex = 11;
            this.GrantOpt_btn.Text = "With grant option (for select, update)";
            this.GrantOpt_btn.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(661, 125);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(106, 46);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_showPriv
            // 
            this.btn_showPriv.Font = new System.Drawing.Font("Cambria", 12F);
            this.btn_showPriv.Location = new System.Drawing.Point(511, 125);
            this.btn_showPriv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_showPriv.Name = "btn_showPriv";
            this.btn_showPriv.Size = new System.Drawing.Size(149, 46);
            this.btn_showPriv.TabIndex = 13;
            this.btn_showPriv.Text = "Xem quyền";
            this.btn_showPriv.UseVisualStyleBackColor = true;
            this.btn_showPriv.Click += new System.EventHandler(this.btn_showPriv_Click);
            // 
            // frm_priviledges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 521);
            this.Controls.Add(this.btn_showPriv);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.GrantOpt_btn);
            this.Controls.Add(this.lb_Table);
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
        private System.Windows.Forms.Label lb_Table;
        private System.Windows.Forms.CheckBox GrantOpt_btn;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_showPriv;
    }
}
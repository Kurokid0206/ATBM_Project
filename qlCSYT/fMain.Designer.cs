namespace qlCSYT
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.m_main = new System.Windows.Forms.MenuStrip();
            this.m_title = new System.Windows.Forms.ToolStripMenuItem();
            this.m_user = new System.Windows.Forms.ToolStripMenuItem();
            this.m_showUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.m_role = new System.Windows.Forms.ToolStripMenuItem();
            this.m_showRoleList = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addRole = new System.Windows.Forms.ToolStripMenuItem();
            this.m_grantPriv = new System.Windows.Forms.ToolStripMenuItem();
            this.m_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_main = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_InvalidAccessAudit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_CSYT_ADMIN = new System.Windows.Forms.ToolStripMenuItem();
            this.m_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_main
            // 
            this.m_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_title,
            this.m_user,
            this.m_role,
            this.m_grantPriv,
            this.m_logout});
            this.m_main.Location = new System.Drawing.Point(0, 0);
            this.m_main.Name = "m_main";
            this.m_main.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.m_main.Size = new System.Drawing.Size(720, 24);
            this.m_main.TabIndex = 3;
            this.m_main.Text = "main_menu";
            this.m_main.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.m_main_ItemClicked);
            // 
            // m_title
            // 
            this.m_title.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_InvalidAccessAudit,
            this.m_CSYT_ADMIN});
            this.m_title.Name = "m_title";
            this.m_title.Size = new System.Drawing.Size(130, 20);
            this.m_title.Text = "Quản lý cơ sở dữ liệu";
            // 
            // m_user
            // 
            this.m_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_showUserList,
            this.m_addUser});
            this.m_user.Name = "m_user";
            this.m_user.Size = new System.Drawing.Size(42, 20);
            this.m_user.Text = "User";
            this.m_user.Click += new System.EventHandler(this.m_user_Click);
            // 
            // m_showUserList
            // 
            this.m_showUserList.Name = "m_showUserList";
            this.m_showUserList.Size = new System.Drawing.Size(180, 22);
            this.m_showUserList.Text = "Xem danh sách";
            this.m_showUserList.Click += new System.EventHandler(this.m_showUserList_Click);
            // 
            // m_addUser
            // 
            this.m_addUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_addEmp,
            this.m_addPatient});
            this.m_addUser.Name = "m_addUser";
            this.m_addUser.Size = new System.Drawing.Size(180, 22);
            this.m_addUser.Text = "Thêm mới";
            // 
            // m_addEmp
            // 
            this.m_addEmp.Name = "m_addEmp";
            this.m_addEmp.Size = new System.Drawing.Size(131, 22);
            this.m_addEmp.Text = "Nhân viên";
            this.m_addEmp.Click += new System.EventHandler(this.m_addEmp_Click);
            // 
            // m_addPatient
            // 
            this.m_addPatient.Name = "m_addPatient";
            this.m_addPatient.Size = new System.Drawing.Size(131, 22);
            this.m_addPatient.Text = "Bênh nhân";
            this.m_addPatient.Click += new System.EventHandler(this.m_addPatient_Click);
            // 
            // m_role
            // 
            this.m_role.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_showRoleList,
            this.m_addRole});
            this.m_role.Name = "m_role";
            this.m_role.Size = new System.Drawing.Size(42, 20);
            this.m_role.Text = "Role";
            // 
            // m_showRoleList
            // 
            this.m_showRoleList.Name = "m_showRoleList";
            this.m_showRoleList.Size = new System.Drawing.Size(155, 22);
            this.m_showRoleList.Text = "Xem danh sách";
            this.m_showRoleList.Click += new System.EventHandler(this.m_showRoleList_Click);
            // 
            // m_addRole
            // 
            this.m_addRole.Name = "m_addRole";
            this.m_addRole.Size = new System.Drawing.Size(155, 22);
            this.m_addRole.Text = "Thêm mới";
            this.m_addRole.Click += new System.EventHandler(this.m_addRole_Click);
            // 
            // m_grantPriv
            // 
            this.m_grantPriv.Name = "m_grantPriv";
            this.m_grantPriv.Size = new System.Drawing.Size(76, 20);
            this.m_grantPriv.Text = "Cấp quyền";
            this.m_grantPriv.Click += new System.EventHandler(this.m_grantPriv_Click);
            // 
            // m_logout
            // 
            this.m_logout.Name = "m_logout";
            this.m_logout.Size = new System.Drawing.Size(73, 20);
            this.m_logout.Text = "Đăng xuất";
            this.m_logout.Click += new System.EventHandler(this.m_logout_Click);
            // 
            // gv_main
            // 
            this.gv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_main.Location = new System.Drawing.Point(2, 2);
            this.gv_main.Margin = new System.Windows.Forms.Padding(2);
            this.gv_main.Name = "gv_main";
            this.gv_main.RowHeadersWidth = 51;
            this.gv_main.RowTemplate.Height = 24;
            this.gv_main.Size = new System.Drawing.Size(712, 332);
            this.gv_main.TabIndex = 0;
            this.gv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_main_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gv_main);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 340);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // m_InvalidAccessAudit
            // 
            this.m_InvalidAccessAudit.Name = "m_InvalidAccessAudit";
            this.m_InvalidAccessAudit.Size = new System.Drawing.Size(219, 22);
            this.m_InvalidAccessAudit.Text = "Truy cập bất hợp pháp";
            this.m_InvalidAccessAudit.Click += new System.EventHandler(this.m_InvalidAccessAudit_Click);
            // 
            // m_CSYT_ADMIN
            // 
            this.m_CSYT_ADMIN.Name = "m_CSYT_ADMIN";
            this.m_CSYT_ADMIN.Size = new System.Drawing.Size(219, 22);
            this.m_CSYT_ADMIN.Text = "Sửa thông tin bất hợp pháp";
            this.m_CSYT_ADMIN.Click += new System.EventHandler(this.m_CSYT_ADMIN_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATBMCQ-4";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.m_main.ResumeLayout(false);
            this.m_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip m_main;
        private System.Windows.Forms.ToolStripMenuItem m_user;
        private System.Windows.Forms.ToolStripMenuItem m_showUserList;
        private System.Windows.Forms.ToolStripMenuItem m_addUser;
        private System.Windows.Forms.ToolStripMenuItem m_role;
        private System.Windows.Forms.ToolStripMenuItem m_showRoleList;
        private System.Windows.Forms.ToolStripMenuItem m_addRole;
        private System.Windows.Forms.ToolStripMenuItem m_logout;
        private System.Windows.Forms.ToolStripMenuItem m_addEmp;
        private System.Windows.Forms.ToolStripMenuItem m_addPatient;
        private System.Windows.Forms.DataGridView gv_main;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem m_title;
        private System.Windows.Forms.ToolStripMenuItem m_grantPriv;
        private System.Windows.Forms.ToolStripMenuItem m_InvalidAccessAudit;
        private System.Windows.Forms.ToolStripMenuItem m_CSYT_ADMIN;
    }
}
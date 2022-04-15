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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_main = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_user = new System.Windows.Forms.ToolStripMenuItem();
            this.m_showUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.m_role = new System.Windows.Forms.ToolStripMenuItem();
            this.m_showRoleList = new System.Windows.Forms.ToolStripMenuItem();
            this.m_addRole = new System.Windows.Forms.ToolStripMenuItem();
            this.m_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gv_main);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 339);
            this.panel1.TabIndex = 1;
            // 
            // gv_main
            // 
            this.gv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_main.Location = new System.Drawing.Point(9, 0);
            this.gv_main.Margin = new System.Windows.Forms.Padding(2);
            this.gv_main.Name = "gv_main";
            this.gv_main.RowHeadersWidth = 51;
            this.gv_main.RowTemplate.Height = 24;
            this.gv_main.Size = new System.Drawing.Size(700, 323);
            this.gv_main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Location = new System.Drawing.Point(777, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 255);
            this.panel2.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(2, 2);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(147, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_user,
            this.m_role,
            this.m_logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_user
            // 
            this.m_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_showUserList,
            this.m_addUser});
            this.m_user.Name = "m_user";
            this.m_user.Size = new System.Drawing.Size(42, 20);
            this.m_user.Text = "User";
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
            this.m_addEmp.Size = new System.Drawing.Size(180, 22);
            this.m_addEmp.Text = "Nhân viên";
            this.m_addEmp.Click += new System.EventHandler(this.m_addEmp_Click);
            // 
            // m_addPatient
            // 
            this.m_addPatient.Name = "m_addPatient";
            this.m_addPatient.Size = new System.Drawing.Size(180, 22);
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
            // 
            // m_logout
            // 
            this.m_logout.Name = "m_logout";
            this.m_logout.Size = new System.Drawing.Size(73, 20);
            this.m_logout.Text = "Đăng xuất";
            this.m_logout.Click += new System.EventHandler(this.m_logout_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATBMCQ-4";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView gv_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_user;
        private System.Windows.Forms.ToolStripMenuItem m_showUserList;
        private System.Windows.Forms.ToolStripMenuItem m_addUser;
        private System.Windows.Forms.ToolStripMenuItem m_role;
        private System.Windows.Forms.ToolStripMenuItem m_showRoleList;
        private System.Windows.Forms.ToolStripMenuItem m_addRole;
        private System.Windows.Forms.ToolStripMenuItem m_logout;
        private System.Windows.Forms.ToolStripMenuItem m_addEmp;
        private System.Windows.Forms.ToolStripMenuItem m_addPatient;
    }
}
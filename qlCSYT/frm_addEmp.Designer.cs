
namespace qlCSYT
{
    partial class frm_addEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addEmp));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addPatient = new System.Windows.Forms.Button();
            this.txt_origin = new System.Windows.Forms.TextBox();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.txt_idNumber = new System.Windows.Forms.TextBox();
            this.lb_origin = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_csytNo = new System.Windows.Forms.Label();
            this.lb_telephone = new System.Windows.Forms.Label();
            this.lb_birth = new System.Windows.Forms.Label();
            this.lb_idNumber = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.txt_specialist = new System.Windows.Forms.TextBox();
            this.lb_specialist = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.time_Birth = new System.Windows.Forms.DateTimePicker();
            this.cb_MedFac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(809, 232);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 49);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addPatient
            // 
            this.btn_addPatient.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPatient.Location = new System.Drawing.Point(635, 234);
            this.btn_addPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addPatient.Name = "btn_addPatient";
            this.btn_addPatient.Size = new System.Drawing.Size(153, 49);
            this.btn_addPatient.TabIndex = 59;
            this.btn_addPatient.Text = "Thêm";
            this.btn_addPatient.UseVisualStyleBackColor = true;
            this.btn_addPatient.Click += new System.EventHandler(this.btn_addPatient_Click);
            // 
            // txt_origin
            // 
            this.txt_origin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_origin.Location = new System.Drawing.Point(645, 13);
            this.txt_origin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_origin.Name = "txt_origin";
            this.txt_origin.Size = new System.Drawing.Size(310, 31);
            this.txt_origin.TabIndex = 55;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(124, 250);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(344, 31);
            this.txt_telephone.TabIndex = 52;
            // 
            // txt_idNumber
            // 
            this.txt_idNumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idNumber.Location = new System.Drawing.Point(124, 133);
            this.txt_idNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idNumber.Name = "txt_idNumber";
            this.txt_idNumber.Size = new System.Drawing.Size(344, 31);
            this.txt_idNumber.TabIndex = 49;
            this.txt_idNumber.TextChanged += new System.EventHandler(this.txt_idNumber_TextChanged);
            // 
            // lb_origin
            // 
            this.lb_origin.AutoSize = true;
            this.lb_origin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_origin.Location = new System.Drawing.Point(502, 16);
            this.lb_origin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_origin.Name = "lb_origin";
            this.lb_origin.Size = new System.Drawing.Size(96, 23);
            this.lb_origin.TabIndex = 45;
            this.lb_origin.Text = "Quê quán:";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.Location = new System.Drawing.Point(502, 94);
            this.lb_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(72, 23);
            this.lb_role.TabIndex = 44;
            this.lb_role.Text = "Vai trò:";
            // 
            // lb_csytNo
            // 
            this.lb_csytNo.AutoSize = true;
            this.lb_csytNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_csytNo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lb_csytNo.Location = new System.Drawing.Point(502, 55);
            this.lb_csytNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_csytNo.Name = "lb_csytNo";
            this.lb_csytNo.Size = new System.Drawing.Size(98, 23);
            this.lb_csytNo.TabIndex = 43;
            this.lb_csytNo.Text = "Cơ sở y tế:";
            this.lb_csytNo.Click += new System.EventHandler(this.lb_csytNo_Click);
            // 
            // lb_telephone
            // 
            this.lb_telephone.AutoSize = true;
            this.lb_telephone.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telephone.Location = new System.Drawing.Point(13, 253);
            this.lb_telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_telephone.Name = "lb_telephone";
            this.lb_telephone.Size = new System.Drawing.Size(50, 23);
            this.lb_telephone.TabIndex = 42;
            this.lb_telephone.Text = "SĐT:";
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birth.Location = new System.Drawing.Point(13, 178);
            this.lb_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(60, 23);
            this.lb_birth.TabIndex = 41;
            this.lb_birth.Text = "NTNS";
            // 
            // lb_idNumber
            // 
            this.lb_idNumber.AutoSize = true;
            this.lb_idNumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idNumber.Location = new System.Drawing.Point(13, 136);
            this.lb_idNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idNumber.Name = "lb_idNumber";
            this.lb_idNumber.Size = new System.Drawing.Size(69, 23);
            this.lb_idNumber.TabIndex = 40;
            this.lb_idNumber.Text = "CMND:";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(13, 214);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(53, 23);
            this.lb_Gender.TabIndex = 39;
            this.lb_Gender.Text = "Phái:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(124, 94);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(344, 31);
            this.txt_name.TabIndex = 38;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(13, 97);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(46, 23);
            this.lb_name.TabIndex = 37;
            this.lb_name.Text = "Tên:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(124, 52);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(344, 31);
            this.txt_password.TabIndex = 36;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(124, 13);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(344, 31);
            this.txt_username.TabIndex = 35;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(13, 58);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(99, 23);
            this.lb_password.TabIndex = 34;
            this.lb_password.Text = "Password:";
            this.lb_password.Click += new System.EventHandler(this.lb_password_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(13, 13);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(103, 23);
            this.lb_username.TabIndex = 33;
            this.lb_username.Text = "Username:";
            // 
            // txt_specialist
            // 
            this.txt_specialist.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_specialist.Location = new System.Drawing.Point(645, 130);
            this.txt_specialist.Margin = new System.Windows.Forms.Padding(4);
            this.txt_specialist.Name = "txt_specialist";
            this.txt_specialist.Size = new System.Drawing.Size(310, 31);
            this.txt_specialist.TabIndex = 62;
            // 
            // lb_specialist
            // 
            this.lb_specialist.AutoSize = true;
            this.lb_specialist.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_specialist.Location = new System.Drawing.Point(502, 133);
            this.lb_specialist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_specialist.Name = "lb_specialist";
            this.lb_specialist.Size = new System.Drawing.Size(125, 23);
            this.lb_specialist.TabIndex = 61;
            this.lb_specialist.Text = "Chuyên khoa:";
            // 
            // cb_role
            // 
            this.cb_role.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(645, 91);
            this.cb_role.Margin = new System.Windows.Forms.Padding(4);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(310, 31);
            this.cb_role.TabIndex = 63;
            this.cb_role.SelectedIndexChanged += new System.EventHandler(this.cb_role_SelectedIndexChanged);
            // 
            // cb_gender
            // 
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(124, 211);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(93, 31);
            this.cb_gender.TabIndex = 66;
            this.cb_gender.SelectedIndexChanged += new System.EventHandler(this.cb_gender_SelectedIndexChanged);
            // 
            // time_Birth
            // 
            this.time_Birth.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Birth.Location = new System.Drawing.Point(124, 172);
            this.time_Birth.Margin = new System.Windows.Forms.Padding(4);
            this.time_Birth.Name = "time_Birth";
            this.time_Birth.Size = new System.Drawing.Size(344, 31);
            this.time_Birth.TabIndex = 65;
            // 
            // cb_MedFac
            // 
            this.cb_MedFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MedFac.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MedFac.FormattingEnabled = true;
            this.cb_MedFac.Location = new System.Drawing.Point(645, 52);
            this.cb_MedFac.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MedFac.Name = "cb_MedFac";
            this.cb_MedFac.Size = new System.Drawing.Size(310, 31);
            this.cb_MedFac.TabIndex = 64;
            this.cb_MedFac.SelectedIndexChanged += new System.EventHandler(this.cb_MedFac_SelectedIndexChanged);
            // 
            // frm_addEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 306);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.time_Birth);
            this.Controls.Add(this.cb_MedFac);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.txt_specialist);
            this.Controls.Add(this.lb_specialist);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addPatient);
            this.Controls.Add(this.txt_origin);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_idNumber);
            this.Controls.Add(this.lb_origin);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_csytNo);
            this.Controls.Add(this.lb_telephone);
            this.Controls.Add(this.lb_birth);
            this.Controls.Add(this.lb_idNumber);
            this.Controls.Add(this.lb_Gender);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_addEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên mới";
            this.Load += new System.EventHandler(this.frm_addEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_addPatient;
        private System.Windows.Forms.TextBox txt_origin;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.TextBox txt_idNumber;
        private System.Windows.Forms.Label lb_origin;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label lb_csytNo;
        private System.Windows.Forms.Label lb_telephone;
        private System.Windows.Forms.Label lb_birth;
        private System.Windows.Forms.Label lb_idNumber;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox txt_specialist;
        private System.Windows.Forms.Label lb_specialist;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker time_Birth;
        private System.Windows.Forms.ComboBox cb_MedFac;
    }
}


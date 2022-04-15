
namespace qlCSYT
{
    partial class frm_addPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addPatient));
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_idNumber = new System.Windows.Forms.Label();
            this.lb_birth = new System.Windows.Forms.Label();
            this.lb_houseNo = new System.Windows.Forms.Label();
            this.lb_street = new System.Windows.Forms.Label();
            this.lb_district = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.lb_sickHis = new System.Windows.Forms.Label();
            this.lb_famSickHis = new System.Windows.Forms.Label();
            this.lb_allergy = new System.Windows.Forms.Label();
            this.txt_idNumber = new System.Windows.Forms.TextBox();
            this.txt_houseNo = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_district = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.rtxt_sickHis = new System.Windows.Forms.RichTextBox();
            this.rtxt_famSickHis = new System.Windows.Forms.RichTextBox();
            this.rtxt_allergy = new System.Windows.Forms.RichTextBox();
            this.btn_addPatient = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_csytID = new System.Windows.Forms.Label();
            this.cbMedFac = new System.Windows.Forms.ComboBox();
            this.time_Birth = new System.Windows.Forms.DateTimePicker();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(13, 16);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(103, 23);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username:";
            this.lb_username.Click += new System.EventHandler(this.lb_username_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(13, 56);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(99, 23);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Password:";
            this.lb_password.Click += new System.EventHandler(this.lb_password_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(157, 13);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(353, 31);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(157, 52);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(353, 31);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(13, 94);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(46, 23);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Tên:";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(157, 91);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(353, 31);
            this.txt_name.TabIndex = 7;
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(13, 211);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(53, 23);
            this.lb_Gender.TabIndex = 8;
            this.lb_Gender.Text = "Phái:";
            this.lb_Gender.Click += new System.EventHandler(this.lb_Gender_Click);
            // 
            // lb_idNumber
            // 
            this.lb_idNumber.AutoSize = true;
            this.lb_idNumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idNumber.Location = new System.Drawing.Point(13, 133);
            this.lb_idNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idNumber.Name = "lb_idNumber";
            this.lb_idNumber.Size = new System.Drawing.Size(69, 23);
            this.lb_idNumber.TabIndex = 9;
            this.lb_idNumber.Text = "CMND:";
            this.lb_idNumber.Click += new System.EventHandler(this.lb_idNumber_Click);
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birth.Location = new System.Drawing.Point(13, 175);
            this.lb_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(60, 23);
            this.lb_birth.TabIndex = 10;
            this.lb_birth.Text = "NTNS";
            this.lb_birth.Click += new System.EventHandler(this.lb_birth_Click);
            // 
            // lb_houseNo
            // 
            this.lb_houseNo.AutoSize = true;
            this.lb_houseNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_houseNo.Location = new System.Drawing.Point(13, 250);
            this.lb_houseNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_houseNo.Name = "lb_houseNo";
            this.lb_houseNo.Size = new System.Drawing.Size(72, 23);
            this.lb_houseNo.TabIndex = 11;
            this.lb_houseNo.Text = "Số nhà:";
            this.lb_houseNo.Click += new System.EventHandler(this.lb_houseNo_Click);
            // 
            // lb_street
            // 
            this.lb_street.AutoSize = true;
            this.lb_street.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_street.Location = new System.Drawing.Point(13, 289);
            this.lb_street.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_street.Name = "lb_street";
            this.lb_street.Size = new System.Drawing.Size(106, 23);
            this.lb_street.TabIndex = 12;
            this.lb_street.Text = "Tên đường:";
            this.lb_street.Click += new System.EventHandler(this.lb_street_Click);
            // 
            // lb_district
            // 
            this.lb_district.AutoSize = true;
            this.lb_district.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_district.Location = new System.Drawing.Point(13, 328);
            this.lb_district.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_district.Name = "lb_district";
            this.lb_district.Size = new System.Drawing.Size(117, 23);
            this.lb_district.TabIndex = 13;
            this.lb_district.Text = "Quận huyện:";
            this.lb_district.Click += new System.EventHandler(this.lb_district_Click);
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_city.Location = new System.Drawing.Point(13, 367);
            this.lb_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(87, 23);
            this.lb_city.TabIndex = 14;
            this.lb_city.Text = "Tỉnh/TP:";
            this.lb_city.Click += new System.EventHandler(this.lb_city_Click);
            // 
            // lb_sickHis
            // 
            this.lb_sickHis.AutoSize = true;
            this.lb_sickHis.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sickHis.Location = new System.Drawing.Point(571, 58);
            this.lb_sickHis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sickHis.Name = "lb_sickHis";
            this.lb_sickHis.Size = new System.Drawing.Size(126, 23);
            this.lb_sickHis.TabIndex = 15;
            this.lb_sickHis.Text = "Tiền sử bệnh:";
            this.lb_sickHis.Click += new System.EventHandler(this.lb_sickHis_Click);
            // 
            // lb_famSickHis
            // 
            this.lb_famSickHis.AutoSize = true;
            this.lb_famSickHis.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_famSickHis.Location = new System.Drawing.Point(571, 183);
            this.lb_famSickHis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_famSickHis.Name = "lb_famSickHis";
            this.lb_famSickHis.Size = new System.Drawing.Size(155, 23);
            this.lb_famSickHis.TabIndex = 16;
            this.lb_famSickHis.Text = "Tiền sử bệnh GĐ:";
            this.lb_famSickHis.Click += new System.EventHandler(this.lb_famSickHis_Click);
            // 
            // lb_allergy
            // 
            this.lb_allergy.AutoSize = true;
            this.lb_allergy.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_allergy.Location = new System.Drawing.Point(571, 309);
            this.lb_allergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_allergy.Name = "lb_allergy";
            this.lb_allergy.Size = new System.Drawing.Size(124, 23);
            this.lb_allergy.TabIndex = 17;
            this.lb_allergy.Text = "Dị ứng thuốc:";
            this.lb_allergy.Click += new System.EventHandler(this.lb_allergy_Click);
            // 
            // txt_idNumber
            // 
            this.txt_idNumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idNumber.Location = new System.Drawing.Point(157, 130);
            this.txt_idNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idNumber.Name = "txt_idNumber";
            this.txt_idNumber.Size = new System.Drawing.Size(353, 31);
            this.txt_idNumber.TabIndex = 18;
            // 
            // txt_houseNo
            // 
            this.txt_houseNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_houseNo.Location = new System.Drawing.Point(157, 247);
            this.txt_houseNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_houseNo.Name = "txt_houseNo";
            this.txt_houseNo.Size = new System.Drawing.Size(353, 31);
            this.txt_houseNo.TabIndex = 21;
            // 
            // txt_street
            // 
            this.txt_street.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_street.Location = new System.Drawing.Point(157, 286);
            this.txt_street.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(353, 31);
            this.txt_street.TabIndex = 22;
            // 
            // txt_district
            // 
            this.txt_district.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_district.Location = new System.Drawing.Point(157, 325);
            this.txt_district.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_district.Name = "txt_district";
            this.txt_district.Size = new System.Drawing.Size(353, 31);
            this.txt_district.TabIndex = 23;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(157, 364);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(353, 31);
            this.txt_city.TabIndex = 24;
            // 
            // rtxt_sickHis
            // 
            this.rtxt_sickHis.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_sickHis.Location = new System.Drawing.Point(744, 56);
            this.rtxt_sickHis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_sickHis.Name = "rtxt_sickHis";
            this.rtxt_sickHis.Size = new System.Drawing.Size(319, 117);
            this.rtxt_sickHis.TabIndex = 28;
            this.rtxt_sickHis.Text = "";
            this.rtxt_sickHis.TextChanged += new System.EventHandler(this.rtxt_sickHis_TextChanged);
            // 
            // rtxt_famSickHis
            // 
            this.rtxt_famSickHis.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_famSickHis.Location = new System.Drawing.Point(744, 180);
            this.rtxt_famSickHis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_famSickHis.Name = "rtxt_famSickHis";
            this.rtxt_famSickHis.Size = new System.Drawing.Size(319, 117);
            this.rtxt_famSickHis.TabIndex = 29;
            this.rtxt_famSickHis.Text = "";
            // 
            // rtxt_allergy
            // 
            this.rtxt_allergy.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_allergy.Location = new System.Drawing.Point(744, 306);
            this.rtxt_allergy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_allergy.Name = "rtxt_allergy";
            this.rtxt_allergy.Size = new System.Drawing.Size(319, 117);
            this.rtxt_allergy.TabIndex = 30;
            this.rtxt_allergy.Text = "";
            // 
            // btn_addPatient
            // 
            this.btn_addPatient.AutoSize = true;
            this.btn_addPatient.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPatient.Location = new System.Drawing.Point(323, 452);
            this.btn_addPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addPatient.Name = "btn_addPatient";
            this.btn_addPatient.Size = new System.Drawing.Size(153, 49);
            this.btn_addPatient.TabIndex = 31;
            this.btn_addPatient.Text = "Thêm";
            this.btn_addPatient.UseVisualStyleBackColor = true;
            this.btn_addPatient.Click += new System.EventHandler(this.btn_addPatient_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(524, 452);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 49);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lb_csytID
            // 
            this.lb_csytID.AutoSize = true;
            this.lb_csytID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_csytID.Location = new System.Drawing.Point(571, 16);
            this.lb_csytID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_csytID.Name = "lb_csytID";
            this.lb_csytID.Size = new System.Drawing.Size(89, 23);
            this.lb_csytID.TabIndex = 33;
            this.lb_csytID.Text = "Mã CSYT:";
            this.lb_csytID.Click += new System.EventHandler(this.lb_csytID_Click);
            // 
            // cbMedFac
            // 
            this.cbMedFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedFac.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedFac.FormattingEnabled = true;
            this.cbMedFac.Location = new System.Drawing.Point(744, 16);
            this.cbMedFac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMedFac.Name = "cbMedFac";
            this.cbMedFac.Size = new System.Drawing.Size(319, 31);
            this.cbMedFac.TabIndex = 34;
            // 
            // time_Birth
            // 
            this.time_Birth.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Birth.Location = new System.Drawing.Point(157, 169);
            this.time_Birth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.time_Birth.Name = "time_Birth";
            this.time_Birth.Size = new System.Drawing.Size(353, 31);
            this.time_Birth.TabIndex = 35;
            // 
            // cb_gender
            // 
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(157, 208);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(99, 31);
            this.cb_gender.TabIndex = 36;
            // 
            // frm_addPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1076, 524);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.time_Birth);
            this.Controls.Add(this.cbMedFac);
            this.Controls.Add(this.lb_csytID);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addPatient);
            this.Controls.Add(this.rtxt_allergy);
            this.Controls.Add(this.rtxt_famSickHis);
            this.Controls.Add(this.rtxt_sickHis);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_district);
            this.Controls.Add(this.txt_street);
            this.Controls.Add(this.txt_houseNo);
            this.Controls.Add(this.txt_idNumber);
            this.Controls.Add(this.lb_allergy);
            this.Controls.Add(this.lb_famSickHis);
            this.Controls.Add(this.lb_sickHis);
            this.Controls.Add(this.lb_city);
            this.Controls.Add(this.lb_district);
            this.Controls.Add(this.lb_street);
            this.Controls.Add(this.lb_houseNo);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_addPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bệnh nhân mới";
            this.Load += new System.EventHandler(this.frm_addPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_idNumber;
        private System.Windows.Forms.Label lb_birth;
        private System.Windows.Forms.Label lb_houseNo;
        private System.Windows.Forms.Label lb_street;
        private System.Windows.Forms.Label lb_district;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.Label lb_sickHis;
        private System.Windows.Forms.Label lb_famSickHis;
        private System.Windows.Forms.TextBox txt_idNumber;
        private System.Windows.Forms.TextBox txt_houseNo;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_district;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.RichTextBox rtxt_sickHis;
        private System.Windows.Forms.RichTextBox rtxt_famSickHis;
        private System.Windows.Forms.RichTextBox rtxt_allergy;
        private System.Windows.Forms.Button btn_addPatient;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lb_csytID;
        private System.Windows.Forms.ComboBox cbMedFac;
        private System.Windows.Forms.DateTimePicker time_Birth;
        private System.Windows.Forms.ComboBox cb_gender;
        protected internal System.Windows.Forms.Label lb_allergy;
    }
}

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
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(76, 81);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(102, 24);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(485, 81);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(97, 24);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Password:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(198, 78);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(240, 29);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(588, 81);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(174, 29);
            this.txt_password.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(76, 175);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 24);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Tên:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(238, 170);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 29);
            this.txt_name.TabIndex = 7;
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(76, 280);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(52, 24);
            this.lb_Gender.TabIndex = 8;
            this.lb_Gender.Text = "Phái:";
            // 
            // lb_idNumber
            // 
            this.lb_idNumber.AutoSize = true;
            this.lb_idNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idNumber.Location = new System.Drawing.Point(76, 210);
            this.lb_idNumber.Name = "lb_idNumber";
            this.lb_idNumber.Size = new System.Drawing.Size(71, 24);
            this.lb_idNumber.TabIndex = 9;
            this.lb_idNumber.Text = "CMND:";
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birth.Location = new System.Drawing.Point(76, 245);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(62, 24);
            this.lb_birth.TabIndex = 10;
            this.lb_birth.Text = "NTNS";
            // 
            // lb_houseNo
            // 
            this.lb_houseNo.AutoSize = true;
            this.lb_houseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_houseNo.Location = new System.Drawing.Point(76, 315);
            this.lb_houseNo.Name = "lb_houseNo";
            this.lb_houseNo.Size = new System.Drawing.Size(75, 24);
            this.lb_houseNo.TabIndex = 11;
            this.lb_houseNo.Text = "Số nhà:";
            // 
            // lb_street
            // 
            this.lb_street.AutoSize = true;
            this.lb_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_street.Location = new System.Drawing.Point(76, 350);
            this.lb_street.Name = "lb_street";
            this.lb_street.Size = new System.Drawing.Size(110, 24);
            this.lb_street.TabIndex = 12;
            this.lb_street.Text = "Tên đường:";
            // 
            // lb_district
            // 
            this.lb_district.AutoSize = true;
            this.lb_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_district.Location = new System.Drawing.Point(76, 385);
            this.lb_district.Name = "lb_district";
            this.lb_district.Size = new System.Drawing.Size(120, 24);
            this.lb_district.TabIndex = 13;
            this.lb_district.Text = "Quận huyện:";
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_city.Location = new System.Drawing.Point(76, 420);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(82, 24);
            this.lb_city.TabIndex = 14;
            this.lb_city.Text = "Tỉnh/TP:";
            // 
            // lb_sickHis
            // 
            this.lb_sickHis.AutoSize = true;
            this.lb_sickHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sickHis.Location = new System.Drawing.Point(485, 175);
            this.lb_sickHis.Name = "lb_sickHis";
            this.lb_sickHis.Size = new System.Drawing.Size(127, 24);
            this.lb_sickHis.TabIndex = 15;
            this.lb_sickHis.Text = "Tiền sử bệnh:";
            // 
            // lb_famSickHis
            // 
            this.lb_famSickHis.AutoSize = true;
            this.lb_famSickHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_famSickHis.Location = new System.Drawing.Point(485, 280);
            this.lb_famSickHis.Name = "lb_famSickHis";
            this.lb_famSickHis.Size = new System.Drawing.Size(159, 24);
            this.lb_famSickHis.TabIndex = 16;
            this.lb_famSickHis.Text = "Tiền sử bệnh GĐ:";
            // 
            // lb_allergy
            // 
            this.lb_allergy.AutoSize = true;
            this.lb_allergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_allergy.Location = new System.Drawing.Point(485, 385);
            this.lb_allergy.Name = "lb_allergy";
            this.lb_allergy.Size = new System.Drawing.Size(122, 24);
            this.lb_allergy.TabIndex = 17;
            this.lb_allergy.Text = "Dị ứng thuốc:";
            // 
            // txt_idNumber
            // 
            this.txt_idNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idNumber.Location = new System.Drawing.Point(238, 205);
            this.txt_idNumber.Name = "txt_idNumber";
            this.txt_idNumber.Size = new System.Drawing.Size(200, 29);
            this.txt_idNumber.TabIndex = 18;
            // 
            // txt_houseNo
            // 
            this.txt_houseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_houseNo.Location = new System.Drawing.Point(238, 310);
            this.txt_houseNo.Name = "txt_houseNo";
            this.txt_houseNo.Size = new System.Drawing.Size(200, 29);
            this.txt_houseNo.TabIndex = 21;
            // 
            // txt_street
            // 
            this.txt_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_street.Location = new System.Drawing.Point(238, 345);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(200, 29);
            this.txt_street.TabIndex = 22;
            // 
            // txt_district
            // 
            this.txt_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_district.Location = new System.Drawing.Point(238, 380);
            this.txt_district.Name = "txt_district";
            this.txt_district.Size = new System.Drawing.Size(200, 29);
            this.txt_district.TabIndex = 23;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(238, 415);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(200, 29);
            this.txt_city.TabIndex = 24;
            // 
            // rtxt_sickHis
            // 
            this.rtxt_sickHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_sickHis.Location = new System.Drawing.Point(651, 170);
            this.rtxt_sickHis.Name = "rtxt_sickHis";
            this.rtxt_sickHis.Size = new System.Drawing.Size(237, 96);
            this.rtxt_sickHis.TabIndex = 28;
            this.rtxt_sickHis.Text = "";
            // 
            // rtxt_famSickHis
            // 
            this.rtxt_famSickHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_famSickHis.Location = new System.Drawing.Point(651, 275);
            this.rtxt_famSickHis.Name = "rtxt_famSickHis";
            this.rtxt_famSickHis.Size = new System.Drawing.Size(237, 96);
            this.rtxt_famSickHis.TabIndex = 29;
            this.rtxt_famSickHis.Text = "";
            // 
            // rtxt_allergy
            // 
            this.rtxt_allergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_allergy.Location = new System.Drawing.Point(651, 380);
            this.rtxt_allergy.Name = "rtxt_allergy";
            this.rtxt_allergy.Size = new System.Drawing.Size(237, 96);
            this.rtxt_allergy.TabIndex = 30;
            this.rtxt_allergy.Text = "";
            // 
            // btn_addPatient
            // 
            this.btn_addPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPatient.Location = new System.Drawing.Point(238, 532);
            this.btn_addPatient.Name = "btn_addPatient";
            this.btn_addPatient.Size = new System.Drawing.Size(115, 40);
            this.btn_addPatient.TabIndex = 31;
            this.btn_addPatient.Text = "Thêm";
            this.btn_addPatient.UseVisualStyleBackColor = true;
            this.btn_addPatient.Click += new System.EventHandler(this.btn_addPatient_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_cancel.Location = new System.Drawing.Point(505, 532);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 40);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lb_csytID
            // 
            this.lb_csytID.AutoSize = true;
            this.lb_csytID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_csytID.Location = new System.Drawing.Point(76, 452);
            this.lb_csytID.Name = "lb_csytID";
            this.lb_csytID.Size = new System.Drawing.Size(90, 24);
            this.lb_csytID.TabIndex = 33;
            this.lb_csytID.Text = "Mã CSYT";
            // 
            // cbMedFac
            // 
            this.cbMedFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedFac.FormattingEnabled = true;
            this.cbMedFac.Location = new System.Drawing.Point(238, 454);
            this.cbMedFac.Name = "cbMedFac";
            this.cbMedFac.Size = new System.Drawing.Size(200, 32);
            this.cbMedFac.TabIndex = 34;
            // 
            // time_Birth
            // 
            this.time_Birth.Location = new System.Drawing.Point(238, 245);
            this.time_Birth.Name = "time_Birth";
            this.time_Birth.Size = new System.Drawing.Size(200, 20);
            this.time_Birth.TabIndex = 35;
            // 
            // cb_gender
            // 
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(238, 272);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(200, 32);
            this.cb_gender.TabIndex = 36;
            // 
            // frm_addPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 666);
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
            this.Name = "frm_addPatient";
            this.Text = "Thêm bệnh nhân";
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
        private System.Windows.Forms.Label lb_allergy;
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
    }
}
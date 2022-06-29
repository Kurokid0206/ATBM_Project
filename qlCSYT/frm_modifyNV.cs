using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;


namespace qlCSYT
{
    public partial class frm_modifyNV : Form
    {
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        public frm_modifyNV()
        {
            InitializeComponent();
            cb_Phai.DisplayMember = "Phai";
            cb_Phai.ValueMember = "Phai";
            var gender = new[] {
            new { Phai = "Nam"},
            new { Phai = "Nữ"}
            };
            cb_Phai.DataSource = gender;

        }

        private void bt_Hoten_Click(object sender, EventArgs e)
        {
            if (tb_HoTen.Text == null || tb_HoTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.NHANVIEN_UPDATE_HOTEN", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_HoTen.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo!");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }

        private void bt_Phai_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.NHANVIEN_UPDATE_PHAI", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", cb_Phai.SelectedValue.ToString());//here
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo!");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }

        private void bt_ngaysinh_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.NHANVIEN_UPDATE_NGAYSINH", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_ngaysinh.Value.Date);//here
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo!");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }

        private void bt_CMND_Click(object sender, EventArgs e)
        {
            if (tb_CMND.Text == null || tb_CMND.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập CMND!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.NHANVIEN_UPDATE_CMND", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", RemoveUnicode(tb_CMND.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo!");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }

        private void bt_QueQuan_Click(object sender, EventArgs e)
        {
            if (tb_QueQuan.Text == null || tb_QueQuan.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập quê quán!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.NHANVIEN_UPDATE_QUEQUAN", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", RemoveUnicode(tb_QueQuan.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo!");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }

        private void bt_SDT_Click(object sender, EventArgs e)
        {
            if (tb_SDT.Text == null || tb_SDT.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.NHANVIEN_UPDATE_SDT", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", RemoveUnicode(tb_SDT.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo!");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }
    }
}

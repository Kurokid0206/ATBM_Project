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
    public partial class frm_modifyBN : Form
    {
        public frm_modifyBN()
        {
            InitializeComponent();
        }


        private void frm_modifyBN_Load(object sender, EventArgs e)
        {

        }

        private void bt_TenBN_Click(object sender, EventArgs e)
        {
            if (tb_TenBN.Text == null || tb_TenBN.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên bệnh nhân!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_TENBN", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_TenBN.Text);
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
                MessageBox.Show("Bạn chưa nhập số cmnd!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_CMND", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_CMND.Text);//here
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
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_NGAYSINH", conn);
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

        private void bt_SoNha_Click(object sender, EventArgs e)
        {
            if (tb_SoNha.Text == null || tb_SoNha.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số nhà!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_SONHA", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_SoNha.Text);//here
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

        private void bt_TenDuong_Click(object sender, EventArgs e)
        {
            if (tb_TenDuong.Text == null || tb_TenDuong.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên đường!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_TENDUONG", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_TenDuong.Text);//here
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

        private void bt_QuanHuyen_Click(object sender, EventArgs e)
        {
            if (tb_QuanHuyen.Text == null || tb_QuanHuyen.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập quận huyện!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_QUANHUYEN", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_QuanHuyen.Text);//here
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

        private void bt_TinhTP_Click(object sender, EventArgs e)
        {
            if (tb_TinhTP.Text == null || tb_TinhTP.Text.Equals(""))//here
            {
                MessageBox.Show("Bạn chưa nhập tỉnh/thành phố!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_TINHTP", conn);//here
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_TinhTP.Text);//here
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

        private void bt_tiensubenh_Click(object sender, EventArgs e)
        {
            if (tb_tiensubenh.Text == null || tb_tiensubenh.Text.Equals(""))//here
            {
                MessageBox.Show("Bạn chưa nhập tiền sử bệnh!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_TIENSUBENH", conn);//here
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_tiensubenh.Text);//here
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

        private void bt_tiensubenhgd_Click(object sender, EventArgs e)
        {
            if (tb_tiensubenhgd.Text == null || tb_tiensubenhgd.Text.Equals(""))//here
            {
                MessageBox.Show("Bạn chưa nhập tiền sử bệnh gia đình!", "Thông báo!");//here
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_TIENSUBENHGD", conn);//here
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_tiensubenhgd.Text);//here
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

        private void bt_diungthuoc_Click(object sender, EventArgs e)
        {
            if (tb_diungthuoc.Text == null || tb_diungthuoc.Text.Equals(""))//here
            {
                MessageBox.Show("Bạn chưa nhập dị ứng thuốc!", "Thông báo!");//here
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_DIUNGTHUOC", conn);//here
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_diungthuoc.Text);//here
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

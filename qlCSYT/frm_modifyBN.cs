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
        //private void LoadBN()
        //{
        //    OracleConnection conn = DBUtils.GetDBConnection();
        //    try
        //    {
        //        conn.Open();
        //        OracleCommand cmd = new OracleCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandText = "Select* from CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW";
        //        using (DbDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    int MaBN_index = reader.GetOrdinal("MaBN");
        //                    string MaBN = reader.GetString(1);

        //                    int MaCSYT_index = reader.GetOrdinal("MaCSYT");
        //                    int TenBN_index = reader.GetOrdinal("TenBN");
        //                    int CMND_index = reader.GetOrdinal("CMND");
        //                    int NgaySinh_index = reader.GetOrdinal("NgaySinh");
        //                    int SoNha_index = reader.GetOrdinal("SoNha");
        //                    int TenDuong_index = reader.GetOrdinal("TenDuong");
        //                    int QuanHuyen_index = reader.GetOrdinal("QuanHuyen");
        //                    int TinhTP_index = reader.GetOrdinal("TinhTP");
        //                    int TienSuBenh_index = reader.GetOrdinal("TienSuBenh");
        //                    int TienSuBenhGD_index = reader.GetOrdinal("TienSuBenhGD");
        //                    int DiUngThuoc_index = reader.GetOrdinal("DiUngThuoc");
        //                    int Username_index = reader.GetOrdinal("MaBN");

        //                    string MaCSYT= reader.GetString(MaCSYT_index);
        //                    string TenBN = reader.GetString(TenBN_index);
        //                    string CMND = reader.GetString(CMND_index);
        //                    DateTime NgaySinh = reader.GetDateTime(NgaySinh_index);
        //                    string SoNha = reader.GetString(SoNha_index);
        //                    string TenDuong = reader.GetString(TenDuong_index);
        //                    string QuanHuyen = reader.GetString(QuanHuyen_index);
        //                    string TinhTP = reader.GetString(TinhTP_index);
        //                    string TienSuBenh = reader.GetString(TienSuBenh_index);
        //                    string TienSuBenhGD = reader.GetString(TienSuBenhGD_index);
        //                    string DiUngThuoc = reader.GetString(DiUngThuoc_index);
        //                    string Username = reader.GetString(Username_index);
        //                    Console.WriteLine(MaBN);
        //                    TextBox Mytextbox = new TextBox();
        //                    Mytextbox.Text = MaBN;
        //                    this.Controls.Add(Mytextbox);


        //                    //int empNameIndex = reader.GetOrdinal("Emp_Name");// 2
        //                    //string empName = reader.GetString(empNameIndex);
        //                    //int  userindex= reader.GetOrdinal("user");
        //                    //string id = reader.GetString(userindex);
        //                    //id = reader.GetString(0);
        //                }

        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error: " + e);
        //        Console.WriteLine(e.StackTrace);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //        conn.Dispose();
        //    }
        //    Console.Read();
        //}
    }
}

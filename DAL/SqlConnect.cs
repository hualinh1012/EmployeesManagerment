using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;
namespace DAL
{
    public class SqlConnect
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6ABMGHP\SQLEXPRESS;Initial Catalog=EmployeesManagerment;Integrated Security=True");
            return conn;
        }
    }


    /// <summary>
    /// BANG DU AN
    /// </summary>
    public class tblDuAn_DAL
    {
        /// <summary>
        /// LAY TAT CA DU LIEU TU BANG DU AN CUA DATABASE
        /// </summary>
        /// <returns></returns>
        public static DataTable getDuAn()
        {
            SqlConnection conn = SqlConnect.Connect();
            SqlCommand command = new SqlCommand("XEM_DU_AN", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        public static void ThemDuAn(tblDu_An Duan)
        {
            SqlConnection conn = SqlConnect.Connect();
            SqlCommand cmd = new SqlCommand("THEM_DU_AN");
            cmd.CommandType = CommandType.StoredProcedure;
            /*cmd.Parameters.Add("@maDA", SqlDbType.Int);*/
            cmd.Parameters.Add("@tenDA", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@diaDiem", SqlDbType.NVarChar,100);
            cmd.Parameters.Add("@ngayBatDau", SqlDbType.Date);
            cmd.Parameters.Add("@ngayKetThuc", SqlDbType.Date);
            cmd.Parameters.Add("@maPB", SqlDbType.Int);
          /*  cmd.Parameters["@maDA"].Value = Duan.MaDuan;*/
            cmd.Parameters["@tenDA"].Value = Duan.TenDuan;
            cmd.Parameters["@diaDiem"].Value = Duan.DiaDiem;
            cmd.Parameters["@ngayBatDau"].Value = Duan.NgayBd;
            cmd.Parameters["@ngayKetThuc"].Value = Duan.NgayKt;
            cmd.Parameters["@maPB"].Value = Duan.MaPb;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

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
    }
}

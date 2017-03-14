using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblNhanVien_DAL
    {
        public static String getEmplNameById(int emplId)
        {
            SqlConnection conn = SqlConnect.Connect();
            SqlCommand command = new SqlCommand("GET_EMPL_NAME", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MA_NV", SqlDbType.Int);
            command.Parameters["@MA_NV"].Value = emplId;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt.Rows[0].Field<String>("TenNV");
        }
    }
}

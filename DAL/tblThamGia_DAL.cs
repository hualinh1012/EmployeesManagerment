using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblThamGia_DAL
    {

        public static DataTable getThamGia(int maduan)
        {
            SqlConnection conn = SqlConnect.Connect();
            SqlCommand command = new SqlCommand("XEM_THAM_GIA", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MA_DA", SqlDbType.Int);
            command.Parameters["@MA_DA"].Value = maduan;
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

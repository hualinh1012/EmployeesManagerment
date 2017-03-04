using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;
namespace BUS
{
    public class tblThamgia_BUS
    {
        public static DataTable loadThamgia(int maduan)
        {
            return tblDuAn_DAL.getThamGia(maduan);
        }
    }
}

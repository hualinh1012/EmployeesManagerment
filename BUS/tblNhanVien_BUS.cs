using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tblNhanVien_BUS
    {
        public static String getEmplName(int manv)
        {
            return tblNhanVien_DAL.getEmplNameById(manv);
        }

    }
}

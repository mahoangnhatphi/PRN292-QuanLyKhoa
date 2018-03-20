using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Models.DKien
{
    class DKienData
    {
        public static bool DeleteByMaKhoa(string MaKhoa)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("Delete From DKIEN Where MAMH IN (Select MAMH From MHOC Where MAKH = @1)", MaKhoa);
        }
    }
}

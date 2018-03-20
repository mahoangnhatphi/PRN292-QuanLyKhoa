using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Models.HPhan
{
    class HPhanData
    {
        public static bool DeleteByMaKhoa(string MaKhoa)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("Delete From HPHAN Where MAMH in (Select MAMH From MHOC Where MAKH = @1)", MaKhoa);
        }
    }
}

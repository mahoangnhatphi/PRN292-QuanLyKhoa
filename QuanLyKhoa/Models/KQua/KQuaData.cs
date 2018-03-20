using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Models.KQua
{
    class KQuaData
    {
        public static bool DeleteKQuaByMaKhoa(string maKhoa)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("Delete From KQUA Where MASV in (Select MASV From SVien Where MAKH = @1)", maKhoa);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Models.MHoc
{
    class MHocData
    {
        public static bool DeleteByMaKhoa(string MaKhoa)
        {
            DKien.DKienData.DeleteByMaKhoa(MaKhoa);
            HPhan.HPhanData.DeleteByMaKhoa(MaKhoa);
            return DataProvider.DataProvider.ExecuteNonQuery("Delete From MHOC Where MAKH = @1", MaKhoa);
        }
    }
}

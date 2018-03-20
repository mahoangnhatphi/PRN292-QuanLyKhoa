using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Models.SVien
{
    class SVienData
    {
        public static bool DeleteByMaKhoa(string maKhoa)
        {
            KQua.KQuaData.DeleteKQuaByMaKhoa(maKhoa);
            return DataProvider.DataProvider.ExecuteNonQuery("Delete From SVien Where MAKH = @1", maKhoa);
        }

        public static int CountNumberStudent(string maKhoa)
        {
            SqlDataReader dr = DataProvider.DataProvider.ExecuteDataReader("Select Count(*) as [NoStudent] From SVien Where MAKH = @1", maKhoa);
            int number = 0;
            if (dr.Read()) {
                number = (int) dr["NoStudent"];
            }
            dr.Close();
            return number;
        }
    }
}

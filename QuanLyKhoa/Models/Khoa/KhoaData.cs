using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Models.Khoa
{
    class KhoaData
    {
        public static List<Khoa> FindAll()
        {
            List<Khoa> dsKhoa = null;
            string MaKhoa = null, TenKhoa = null;
            int NamThanhLap = 0;
            Khoa khoa = null;
            SqlDataReader dr = DataProvider.DataProvider.ExecuteDataReader("Select * From KHOA");
            while (dr.Read())
            {
                MaKhoa = (string)dr["MAKHOA"];
                TenKhoa = (string) dr["TENKHOA"];
                NamThanhLap = (int)dr["NAMTHANHLAP"];
                khoa = new Khoa(MaKhoa, TenKhoa, NamThanhLap);
                if (dsKhoa == null) dsKhoa = new List<Khoa>();
                dsKhoa.Add(khoa);
            }
            return dsKhoa;
        }

        public static bool AddNewKhoa(string MaKhoa, string TenKhoa, int NamThanhLap)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("Insert into KHOA(MAKHOA, TENKHOA, NAMTHANHLAP) Values(@1, @2, @3)", MaKhoa, TenKhoa, NamThanhLap);
        }

        public static bool UpdateKhoa(string MaKhoa, string TenKhoa, int NamThanhLap)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("Update KHOA Set TENKHOA = @2, NAMTHANHLAP = @3 Where MAKHOA = @1", MaKhoa, TenKhoa, NamThanhLap);
        }

        public static bool DeleteKhoa(string MaKhoa)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("Delete From KHOA Where MAKHOA = @1", MaKhoa);
        }
    }
}

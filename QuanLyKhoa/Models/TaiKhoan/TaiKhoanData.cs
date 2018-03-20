using QuanLyKhoa.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Models.TaiKhoan
{
    class TaiKhoanData
    {
        public static bool AddNewAccount(string TenDangNhap, string MatKhau, string HoTen)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("Insert into TAIKHOAN(TENDANGNHAP, MATKHAU, HOTEN) Values(@1, @2, @3)", TenDangNhap, PasswordUtilities.EncodingPassword(MatKhau), HoTen);
        }

        public static bool CheckLogin(string TenDangNhap, string MatKhau)
        {
            return DataProvider.DataProvider.ExecuteDataReader("Select * From TAIKHOAN Where TENDANGNHAP = @1 And MATKHAU = @2", TenDangNhap, PasswordUtilities.EncodingPassword(MatKhau)).Read();
        }

        public static byte[] GetAvatar(string TenDangNhap)
        {
            SqlDataReader dr = DataProvider.DataProvider.ExecuteDataReader("Select ANHDAIDIEN From TAIKHOAN Where TENDANGNHAP = @1", TenDangNhap);
            byte[] avatar = null; 
            while (dr.Read())
            {
                avatar = (byte[])dr["ANHDAIDIEN"];
            }
            dr.Close();
            return avatar;
        }

        public static string GetHoTen(string TenDangNhap)
        {
            SqlDataReader dr = DataProvider.DataProvider.ExecuteDataReader("Select HOTEN From TAIKHOAN Where TENDANGNHAP = @1", TenDangNhap);
            string FullName = null;
            while (dr.Read())
            {
                FullName = (string)dr["HOTEN"];
            }
            dr.Close();
            return FullName;
        }
    }
}

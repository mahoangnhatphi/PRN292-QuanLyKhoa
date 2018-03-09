using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QuanLyKhoa.Models.Khoa
{
    public class Khoa
    {
        [Display(Name ="Mã Khoa")]
        public string MaKhoa { get; set; }
        [Display(Name = "Tên Khoa")]
        public string TenKhoa { get; set; }
        [Display(Name = "Năm Thành Lập")]
        public int NamThanhLap { get; set; }

        public bool TuyenSinh { get; set; }

        public Khoa(string MaKhoa, string TenKhoa, int NamThanhLap)
        {
            this.MaKhoa = MaKhoa;
            this.TenKhoa = TenKhoa;
            this.NamThanhLap = NamThanhLap;
        }

        public Khoa(string maKhoa, string tenKhoa, int namThanhLap, bool tuyenSinh)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            NamThanhLap = namThanhLap;
            TuyenSinh = tuyenSinh;
        }
    }
}

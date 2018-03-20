using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QuanLyKhoa.Models.Khoa
{
    public class Khoa
    {
        [DisplayName("Mã Khoa")]
        public string MaKhoa { get; set; }
        [DisplayName("Tên Khoa")]
        public string TenKhoa { get; set; }
        [DisplayName("Năm Thành Lập")]
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

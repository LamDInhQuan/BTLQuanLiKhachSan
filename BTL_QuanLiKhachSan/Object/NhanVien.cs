using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLiKhachSan.Object
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public int? GioiTinh { get; set; }  // 0: Nam, 1: Nữ
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public double? Luong { get; set; }
        public string GhiChu { get; set; }

        public NhanVien()
        {

        }
        public NhanVien(string hoTen, DateTime ngaySinh, string chucVu, string diaChi, int? gioiTinh, string soDienThoai, string email, double? luong, string ghiChu)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            ChucVu = chucVu;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            SoDienThoai = soDienThoai;
            Email = email;
            Luong = luong;
            GhiChu = ghiChu;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private String _MaKhachHang;
        private String _TenKhachHang;
        private String _NgaySinh;
        private String _GioiTinh;
        private String _CMND;
        private String _DiaChi;
        private String _Email;
        private String _SoDienThoai;
        private String _TenDangNhap;

        public String MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public String TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
        public String NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public String GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public String CMND { get => _CMND; set => _CMND = value; }
        public String DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public String SoDienThoai { get => _SoDienThoai; set => _SoDienThoai = value; }
        public String TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public String Email { get => _Email; set => _Email = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private String _MaNhanVien;
        private String _TenNhanVien;
        private String _NgaySinh;
        private String _GioiTinh;
        private String _CMND;
        private String _DiaChi;
        private String _SoDienThoai;
        private String _TenDangNhap;
        private String _ViTri;
        private String _Email;

        public String MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public String TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public String NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public String GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public String CMND { get => _CMND; set => _CMND = value; }
        public String DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public String SoDienThoai { get => _SoDienThoai; set => _SoDienThoai = value; }
        public String TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public String ViTri { get => _ViTri; set => _ViTri = value; }
        public String Email { get => _Email; set => _Email = value; }
    }
}

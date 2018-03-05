using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyDTO
    {
        private String _MaQuanLy;
        private String _TenDangNhap;
        private String _Email;
        private String _HoTen;
        private String _NgaySinh;
        private String _GioiTinh;
        private String _CMND;
        private String _SoDienThoai;
        private String _DiaChi;

        public String MaQuanLy { get => _MaQuanLy; set => _MaQuanLy = value; }
        public String TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public String Email { get => _Email; set => _Email = value; }
        public String HoTen { get => _HoTen; set => _HoTen = value; }
        public String NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public String GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public String CMND { get => _CMND; set => _CMND = value; }
        public String SoDienThoai { get => _SoDienThoai; set => _SoDienThoai = value; }
        public String DiaChi { get => _DiaChi; set => _DiaChi = value; }
    }
}

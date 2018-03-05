using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private String _TenDangNhap;
        private String _MatKhau;
        private String _ChucNang;

        public String TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public String MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public String ChucNang { get => _ChucNang; set => _ChucNang = value; }
    }
}

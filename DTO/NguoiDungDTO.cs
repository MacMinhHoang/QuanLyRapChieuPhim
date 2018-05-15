using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        private Int32 _MaNguoiDung;
        private String _TenDangNhap;
        private String _HoTen;
        private String _NgaySinh;
        private Boolean _GioiTinh;
        private String _DiaChi;
        private String _SDT;
        
        public int MaNguoiDung { get => _MaNguoiDung; set => _MaNguoiDung = value; }
        public String TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public String HoTen { get => _HoTen; set => _HoTen = value; }
        public String NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public bool GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public String DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public String SDT { get => _SDT; set => _SDT = value; }

    }
}

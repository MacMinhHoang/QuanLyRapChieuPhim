﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KeToanDTO
    {
        private Int32 _MaKeToan;
        private String _TenDangNhap;
        private String _HoTen;
        private String _NgaySinh;
        private Boolean _GioiTinh;
        private String _DiaChi;
        private String _SDT;

        public int MaKeToan { get => _MaKeToan; set => _MaKeToan = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public bool GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
    }
}

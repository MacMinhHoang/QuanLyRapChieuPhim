﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private Int32 _MaNhanVien;
        private String _HoTen;
        private String _NgaySinh;
        private Boolean _GioiTinh;
        private String _DiaChi;
        private String _SDT;
        private float _Luong;
        private String _LichLamViec;

        public int MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public bool GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public float Luong { get => _Luong; set => _Luong = value; }
        public string LichLamViec { get => _LichLamViec; set => _LichLamViec = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private Int32 _MaNhanVien;
        private float _Luong;
        private String _LichLamViec;
       

        public int MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public float Luong { get => _Luong; set => _Luong = value; }
        public String LichLamViec { get => _LichLamViec; set => _LichLamViec = value; }
        
    }
}

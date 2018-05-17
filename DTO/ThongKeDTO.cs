using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDTO
    {
        private Int32 _MaHoatDong;
        private String _TenHoatDong;
        private float _ChiPhi;

        public int MaHoatDong { get => _MaHoatDong; set => _MaHoatDong = value; }
        public string TenHoatDong { get => _TenHoatDong; set => _TenHoatDong = value; }
        public float ChiPhi { get => _ChiPhi; set => _ChiPhi = value; }
    }
}

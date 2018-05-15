using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VeDTO
    {
        
        private int _MaVe;
        private int _MaKhachHang;
        private int _MaSuatChieu;
        private String _Ghe;
        private Boolean _LoaiVe;
        private float _GiaVe;
        private Boolean _ThanhToan;
        private Boolean _TinhTrang;
        

        
        public int MaVe { get => _MaVe; set => _MaVe = value; }
        public int MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public int MaSuatChieu { get => _MaSuatChieu; set => _MaSuatChieu = value; }
        public string Ghe { get => _Ghe; set => _Ghe = value; }
        public bool LoaiVe { get => _LoaiVe; set => _LoaiVe = value; }
        public float GiaVe { get => _GiaVe; set => _GiaVe = value; }
        public bool ThanhToan { get => _ThanhToan; set => _ThanhToan = value; }
        public bool TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
    }
}

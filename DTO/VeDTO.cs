using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VeDTO
    {
        private String _MaKhachHang;
        private String _MaVe;
        private String _TenPhim;
        private String _NgayChieu;
        private String _SuatChieu;
        private String _MaPhongChieu;
        private String _ViTriNgoi;
        private Int32 _Gia;

        public String MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public String MaVe { get => _MaVe; set => _MaVe = value; }
        public String TenPhim { get => _TenPhim; set => _TenPhim = value; }
        public String NgayChieu { get => _NgayChieu; set => _NgayChieu = value; }
        public String MaPhongChieu { get => _MaPhongChieu; set => _MaPhongChieu = value; }
        
        public int Gia { get => _Gia; set => _Gia = value; }
        public string SuatChieu { get => _SuatChieu; set => _SuatChieu = value; }
        public string ViTriNgoi { get => _ViTriNgoi; set => _ViTriNgoi = value; }
    }
}

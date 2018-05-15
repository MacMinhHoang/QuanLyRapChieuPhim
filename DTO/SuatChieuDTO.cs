using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuatChieuDTO
    {
        private Int32 _MaSuatChieu;
        private Int32 _MaPhongChieu;
        private String _NgayChieu;
        private String _GioChieu;
        private int _MaPhim;

        public int MaPhongChieu { get => _MaPhongChieu; set => _MaPhongChieu = value; }
        public int MaSuatChieu { get => _MaSuatChieu; set => _MaSuatChieu = value; }
        public String NgayChieu { get => _NgayChieu; set => _NgayChieu = value; }
        public String GioChieu { get => _GioChieu; set => _GioChieu = value; }
        public int MaPhim { get => _MaPhim; set => _MaPhim = value; }
    }
}

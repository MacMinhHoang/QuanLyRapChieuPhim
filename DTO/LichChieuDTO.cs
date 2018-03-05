using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuDTO
    {
        private String _TenPhim;
        private String _NgayChieu;
        private String _SuatChieu;
        private String _MaPhongChieu;

        public string TenPhim { get => _TenPhim; set => _TenPhim = value; }
        public string NgayChieu { get => _NgayChieu; set => _NgayChieu = value; }
        public string SuatChieu { get => _SuatChieu; set => _SuatChieu = value; }
        public string MaPhongChieu { get => _MaPhongChieu; set => _MaPhongChieu = value; }
    }
}

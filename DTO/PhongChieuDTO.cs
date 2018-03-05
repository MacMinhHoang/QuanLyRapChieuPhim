using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieuDTO
    {
        private String _MaPhongChieu;
        private Int32 _SoLuongChoNgoi;
        private String _LoaiMayChieu;
        private String _LoaiAmThanh;
        private String _TinhTrang;

        public String MaPhongChieu { get => _MaPhongChieu; set => _MaPhongChieu = value; }
        public String LoaiMayChieu { get => _LoaiMayChieu; set => _LoaiMayChieu = value; }
        public String LoaiAmThanh { get => _LoaiAmThanh; set => _LoaiAmThanh = value; }
        public String TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
        public int SoLuongChoNgoi { get => _SoLuongChoNgoi; set => _SoLuongChoNgoi = value; }
    }
}

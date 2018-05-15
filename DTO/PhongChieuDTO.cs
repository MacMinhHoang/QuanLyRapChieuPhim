using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieuDTO
    {
        private Int32 _MaPhongChieu;
        private String _TenPhongChieu;
        private Int32 _SoLuongGhe;
        private Boolean _TinhTrang;

        public int MaPhongChieu { get => _MaPhongChieu; set => _MaPhongChieu = value; }
        public String TenPhongChieu { get => _TenPhongChieu; set => _TenPhongChieu = value; }
        public int SoLuongGhe { get => _SoLuongGhe; set => _SoLuongGhe = value; }
        public Boolean TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
    }
}

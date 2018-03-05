using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhimDTO
    {
        private String _MaPhim;
        private String _TenPhim;
        private String _TheLoai;
        private String _DaoDien;
        private String _DienVien;
        private String _GioiHanDoTuoi;
        private String _NoiDung;
        private Int32 _NamSanXuat;
        private String _Poster;
        private String _Trailer;


        public String MaPhim { get => _MaPhim; set => _MaPhim = value; }
        public String TenPhim { get => _TenPhim; set => _TenPhim = value; }
        public String TheLoai { get => _TheLoai; set => _TheLoai = value; }
        public String DaoDien { get => _DaoDien; set => _DaoDien = value; }
        public String DienVien { get => _DienVien; set => _DienVien = value; }
        public String GioiHanDoTuoi { get => _GioiHanDoTuoi; set => _GioiHanDoTuoi = value; }
        public String NoiDung { get => _NoiDung; set => _NoiDung = value; }
        public String Poster { get => _Poster; set => _Poster = value; }
        public String Trailer { get => _Trailer; set => _Trailer = value; }
        public int NamSanXuat { get => _NamSanXuat; set => _NamSanXuat = value; }
    }
}

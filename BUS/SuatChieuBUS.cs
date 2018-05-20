using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SuatChieuBUS
    {
        private SuatChieuDAO suatChieuDAO;

        public SuatChieuBUS()
        {
            suatChieuDAO = new SuatChieuDAO();
        }

        public List<SuatChieuDTO> LayDanhSach()
        {
            return suatChieuDAO.LayDanhSach();
        }

        public SuatChieuDTO LayThongTin(int id)
        {
            return suatChieuDAO.LayThongTin(id);
        }

        public int LayMaSuatChieu(string ngay, string gio, int phong)
        {
            return suatChieuDAO.LayMaSuatChieu(ngay, gio, phong);
        }

        public List<String> LayDSNgayChieuCuaPhim(int id)
        {
            return suatChieuDAO.LayDSNgayChieuCuaPhim(id);
        }

        public List<String> LayDSSuatChieuCuaPhimTheoNgay(int id, string ngaychieu)
        {
            return suatChieuDAO.LayDSSuatChieuCuaPhimTheoNgay(id, ngaychieu);
        }

        public int LayMaPhongChieu(int id, string ngaychieu, string giochieu)
        {
            return suatChieuDAO.LayMaPhongChieu(id, ngaychieu, giochieu);
        }

        public bool ThemSuatChieu(SuatChieuDTO sc)
        {
            return suatChieuDAO.ThemSuatChieu(sc);
        }

        public void XoaSuatChieu(int ma)
        {
            suatChieuDAO.XoaSuatChieu(ma);
        }

        public List<int> ListGheTrong(SuatChieuDTO sc, string day)
        {
            return suatChieuDAO.ListGheTrong(sc, day);
        }
    }
}

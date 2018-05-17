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

        public List<String> LayDSNgayChieuCuaPhim(string tenphim)
        {
            return suatChieuDAO.LayDSNgayChieuCuaPhim(tenphim);
        }

        public List<String> LayDSSuatChieuCuaPhimTheoNgay(string tenphim, string ngaychieu)
        {
            return suatChieuDAO.LayDSSuatChieuCuaPhimTheoNgay(tenphim, ngaychieu);
        }

        public String LayTenPhongChieu(string tenphim, string ngaychieu, string giochieu)
        {
            return suatChieuDAO.LayTenPhongChieu(tenphim, ngaychieu, giochieu);
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

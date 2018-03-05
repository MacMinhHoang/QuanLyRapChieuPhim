using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongChieuBUS
    {
        private PhongChieuDAO phongChieuDAO;

        public PhongChieuBUS()
        {
            phongChieuDAO = new PhongChieuDAO();
        }

        public List<PhongChieuDTO> LayDanhSach()
        {
            return phongChieuDAO.LayDanhSach();
        }

        public bool ThemPhongChieu(string mapc, string soluongcho, string loaimaychieu, string loaiamthanh, string tinhtrang)
        {
            return phongChieuDAO.ThemPhongChieu(mapc, soluongcho, loaimaychieu, loaiamthanh, tinhtrang);
        }

        public void XoaPhongChieu(string mpc)
        {
            phongChieuDAO.XoaPhongChieu(mpc);
        }

        public List<String> LayDanhSachMaPhongChieu()
        {
            return phongChieuDAO.LayDanhSachMaPhongChieu();
        }

        public PhongChieuDTO LayThongTin(string mapc)
        {
            return phongChieuDAO.LayThongTin(mapc);
        }

        public List<Char> LayDanhSachDayGhe(string mapc)
        {
            return phongChieuDAO.LayDanhSachDayGhe(mapc);
        }
    }
}

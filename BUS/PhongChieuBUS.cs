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

        public bool ThemPhongChieu(PhongChieuDTO pc)
        {
            return phongChieuDAO.ThemPhongChieu(pc);
        }

        public void XoaPhongChieu(int mpc)
        {
            phongChieuDAO.XoaPhongChieu(mpc);
        }

        public List<String> LayDanhSachMaPhongChieu()
        {
            return phongChieuDAO.LayDanhSachMaPhongChieu();
        }

        public PhongChieuDTO LayThongTin(int mapc)
        {
            return phongChieuDAO.LayThongTin(mapc);
        }

        public List<Char> LayDanhSachDayGhe(int mapc)
        {
            return phongChieuDAO.LayDanhSachDayGhe(mapc);
        }
    }
}

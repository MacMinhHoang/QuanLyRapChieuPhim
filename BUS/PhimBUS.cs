using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhimBUS
    {
        private PhimDAO phimDAO;

        public PhimBUS()
        {
            phimDAO = new PhimDAO();
        }

        public List<PhimDTO> LayDanhSach()
        {
            return phimDAO.LayDanhSach();
        }

        public List<PhimDTO> TimKiemTheoTen(string tenphim)
        {
            return phimDAO.TimKiemTheoTen(tenphim);
        }

        public List<PhimDTO> TimKiemTheoTheLoai(string theloai)
        {
            return phimDAO.TimKiemTheoTheLoai(theloai);
        }

        public void ThemPhim(string maphim, string tenphim, string theloai, string daodien, string dienvien,
                              string gioihandotuoi, string noidung, int namsx, string poster, string trailer)
        {
            phimDAO.ThemPhim(maphim, tenphim, theloai, daodien, dienvien,
                              gioihandotuoi, noidung, namsx, poster, trailer);
        }

        public int SoLuongPhim()
        {
            return phimDAO.SoLuongPhim();
        }

        public void XoaPhim(string maphim)
        {
            phimDAO.XoaPhim(maphim);
        }

        public List<String> LayDanhSachTenPhim()
        {
            return phimDAO.LayDanhSachTenPhim();
        }
    }
}

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LichChieuBUS
    {
        private LichChieuDAO lichChieuDAO;

        public LichChieuBUS()
        {
            lichChieuDAO = new LichChieuDAO();
        }

        public List<LichChieuDTO> LayDanhSach()
        {
            return lichChieuDAO.LayDanhSach();
        }

        public List<LichChieuDTO> LayLichTheoTen(string tenphim)
        {
            return lichChieuDAO.LayLichChieuTheoTen(tenphim);
        }

        public List<String> LayDanhSachNgayChieu(string tenphim)
        {
            return lichChieuDAO.LayDanhSachNgayChieu(tenphim);
        }

        public List<String> LayDanhSachSuatChieu(string tenphim, string ngaychieu)
        {
            return lichChieuDAO.LayDanhSachSuatChieu(tenphim, ngaychieu);
        }

        public String LayMaPhongChieu(string ngaychieu, string suatchieu)
        {
            return lichChieuDAO.LayMaPhongChieu(ngaychieu, suatchieu);
        }

        public List<int> ListGheTrong(string ngaychieu, string suatchieu, string day)
        {
            return lichChieuDAO.ListGheTrong(ngaychieu, suatchieu, day);
        }
    }
}

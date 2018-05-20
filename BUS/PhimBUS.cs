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

        public PhimDTO LayThongTin(int id)
        {
            return phimDAO.LayThongTin(id);
        }

        public List<PhimDTO> TimKiemTheoTen(string tenphim)
        {
            return phimDAO.TimKiemTheoTen(tenphim);
        }

        public List<PhimDTO> TimKiemTheoTheLoai(string theloai)
        {
            return phimDAO.TimKiemTheoTheLoai(theloai);
        }

        public void ThemPhim(PhimDTO ph)
        {
            phimDAO.ThemPhim(ph);
        }

        public int SoLuongPhim()
        {
            return phimDAO.SoLuongPhim();
        }

        public void XoaPhim(int maphim)
        {
            phimDAO.XoaPhim(maphim);
        }

        public List<String> LayDanhSachTenPhim()
        {
            return phimDAO.LayDanhSachTenPhim();
        }

        public List<PhimDTO> LayTop3()
        {
            List<PhimDTO> listPhim = new List<PhimDTO>();
            List<int> listMa = phimDAO.LayTop3();
            foreach(int id in listMa)
            {
                listPhim.Add(phimDAO.LayThongTin(id));
            }
            return listPhim;
        }

        public List<int> LayDanhSachIDPhim()
        {
            return phimDAO.LayDanhSachIDPhim();
        }
    }
}

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyBUS
    {
        private QuanLyDAO quanLyDAO;

        public QuanLyBUS()
        {
            quanLyDAO = new QuanLyDAO();
        }

        public List<QuanLyDTO> LayDanhSach()
        {
            return quanLyDAO.LayDanhSach();
        }

        public QuanLyDTO LayThongTin(string tendangnhap)
        {
            return quanLyDAO.LayThongTin(tendangnhap);
        }

        public void ThemQuanLy(QuanLyDTO ql)
        {
            quanLyDAO.ThemQuanLy(ql);
        }
        public int SoLuongQuanLy()
        {
            return SoLuongQuanLy();
        }

        public void XoaQuanLy(int maql)
        {
            quanLyDAO.XoaQuanLy(maql);
        }

        public void SuaThongTin(QuanLyDTO ql)
        {
            quanLyDAO.SuaThongTin(ql);
        }
    }
}

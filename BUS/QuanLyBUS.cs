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

        public void ThemQuanLy(string maql, string tendangnhap, string email, string hoten, string ngaysinh,
          string CMND, string gioitinh, string sodienthoai, string diachi)
        {
            quanLyDAO.ThemQuanLy(maql, tendangnhap, email, hoten, ngaysinh, CMND, gioitinh, sodienthoai, diachi);
        }
        public int SoLuongQuanLy()
        {
            return SoLuongQuanLy();
        }

        public void XoaQuanLy(string maql)
        {
            quanLyDAO.XoaQuanLy(maql);
        }

        public void SuaThongTin(string maql, string hoten, string ngaysinh, string gioitinh,
                                string cmnd, string sdt, string diachi, string email)
        {
            quanLyDAO.SuaThongTin(maql, hoten, ngaysinh, gioitinh, cmnd, sdt, diachi, email);
        }
    }
}

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBUS
    {
        private ThongKeDAO thongKeDAO;

        public ThongKeBUS()
        {
            thongKeDAO = new ThongKeDAO();
        }

        public List<ThongKeDTO> LayDanhSach()
        {
            return thongKeDAO.LayDanhSach();
        }

        public ThongKeDTO LayThongTin(string tendangnhap)
        {
            return thongKeDAO.LayThongTin(tendangnhap);
        }

        public void SuaThongTin(ThongKeDTO kt)
        {
            thongKeDAO.SuaThongTin(kt);
        }

        public void ThemHoatDong(ThongKeDTO tkDTO)
        {
            thongKeDAO.ThemHoatDong(tkDTO);
        }

        public void XoaHoatDong(int id)
        {
            thongKeDAO.XoaHoatDong(id);
        }
    }
}

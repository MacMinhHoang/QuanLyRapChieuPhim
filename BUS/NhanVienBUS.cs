using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nvDAO;

        public NhanVienBUS()
        {
            nvDAO = new NhanVienDAO();
        }

        public List<NhanVienDTO> LayDanhSach()
        {
            return nvDAO.LayDanhSach();
        }

        public NhanVienDTO LayThongTin(int id)
        {
            return nvDAO.LayThongTin(id);
        }

        public bool ThemNhanVien(NhanVienDTO nv)
        {
            return nvDAO.ThemNhanVien(nv);
        }

        public void XoaNhanVien(int mnv)
        {
            nvDAO.XoaNhanVien(mnv);
        }

        public int SoLuongNhanVien()
        {
            return nvDAO.SoLuongNhanVien();
        }

        public void SuaThongTin(NhanVienDTO nv)
        {
            nvDAO.SuaThongTin(nv);
        }
    }
}

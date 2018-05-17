using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienKTBUS
    {
        private NhanVienKTDAO nhanVienKTDAO;

        public NhanVienKTBUS()
        {
            nhanVienKTDAO = new NhanVienKTDAO();
        }

        public List<NhanVienKTDTO> LayDanhSach()
        {
            return nhanVienKTDAO.LayDanhSach();
        }

        public NhanVienKTDTO LayThongTin(string tendangnhap)
        {
            return nhanVienKTDAO.LayThongTin(tendangnhap);
        }

        public void SuaThongTin(NhanVienKTDTO kt)
        {
            nhanVienKTDAO.SuaThongTin(kt);
        }
    }
}

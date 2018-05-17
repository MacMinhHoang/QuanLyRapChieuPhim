using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO taiKhoanDAO;

        public TaiKhoanBUS()
        {
            taiKhoanDAO = new TaiKhoanDAO();
        }

        public List<TaiKhoanDTO> LayDanhSach()
        {
            return taiKhoanDAO.LayDanhSach();
        }

        public TaiKhoanDTO DangNhap(String username, String password)
        {
            return taiKhoanDAO.DangNhap(username, password);
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            return taiKhoanDAO.ThemTaiKhoan(tk);
        }

        public void XoaTaiKhoan(string tdn)
        {
            taiKhoanDAO.XoaTaiKhoan(tdn);
        }
    }
}

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO khachHangDAO;

        public KhachHangBUS()
        {
            khachHangDAO = new KhachHangDAO();
        }

        public List<KhachHangDTO> LayDanhSach()
        {
            return khachHangDAO.LayDanhSach();
        }

        public void ThemKhachHang(KhachHangDTO kh, TaiKhoanDTO tk)
        {
            khachHangDAO.ThemKhachHang(kh, tk);
        }

        public void XoaKhachHang(int mnv)
        {
            khachHangDAO.XoaKhachHang(mnv);
        }

        public int SoLuongKhachHang()
        {
            return khachHangDAO.SoLuongKhachHang();
        }

        public int LayMaKH(string tendn)
        {
            return khachHangDAO.LayMaKH(tendn);
        }

        public void SuaThongTin(KhachHangDTO kh)
        {
            khachHangDAO.SuaThongTin(kh);
        }

        public KhachHangDTO LayThongTin(string tendangnhap)
        {
            return khachHangDAO.LayThongTin(tendangnhap);
        }
    }
}

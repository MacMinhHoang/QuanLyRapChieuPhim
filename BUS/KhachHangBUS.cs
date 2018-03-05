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

        public void ThemKhachHang(string makh, string tenkh, string ngaysinh, string gioitinh, string cmnd,
                                string diachi, string email, string sdt, string tendn)
        {
            khachHangDAO.ThemKhachHang(makh, tenkh, ngaysinh, gioitinh, cmnd, diachi, email, sdt, tendn);
        }

        public void XoaKhachHang(string mnv)
        {
            khachHangDAO.XoaKhachHang(mnv);
        }

        public int SoLuongKhachHang()
        {
            return khachHangDAO.SoLuongKhachHang();
        }

        public string LayMaKH(string tendn)
        {
            return khachHangDAO.LayMaKH(tendn);
        }

        public void SuaThongTin(string makh, string hoten, string ngaysinh, string gioitinh, string cmnd, string sdt,
                                string diachi, string email)
        {
            khachHangDAO.SuaThongTin(makh, hoten, ngaysinh, gioitinh, cmnd, sdt, diachi, email);
        }

        public KhachHangDTO LayThongTin(string tendangnhap)
        {
            return khachHangDAO.LayThongTin(tendangnhap);
        }
    }
}

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

        public NhanVienDTO LayThongTin(string tendangnhap)
        {
            return nvDAO.LayThongTin(tendangnhap);
        }

        public bool ThemNhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string cmnd,
                                string sdt, string diachi, string vitri, string tendn, string email)
        {
            return nvDAO.ThemNhanVien(manv, tennv, ngaysinh, gioitinh, cmnd, sdt, diachi, vitri, tendn, email);
        }

        public void XoaNhanVien(string mnv)
        {
            nvDAO.XoaNhanVien(mnv);
        }

        public int SoLuongNhanVien()
        {
            return nvDAO.SoLuongNhanVien();
        }

        public void SuaThongTin(string manv, string hoten, string ngaysinh, string gioitinh, string cmnd, string sdt,
                                string diachi, string email, string vitri)
        {
            nvDAO.SuaThongTin(manv, hoten, ngaysinh, gioitinh, cmnd, sdt, diachi, email, vitri);
        }
    }
}

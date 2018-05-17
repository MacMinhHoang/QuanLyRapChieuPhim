using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienKTDAO
    {
        public List<NhanVienKTDTO> LayDanhSach()
        {
            List<NhanVienKTDTO> listAdminDTO = new List<NhanVienKTDTO>();

            String query = "SELECT * FROM NguoiDung WHERE TenDangNhap = " +
                                                    "(SELECT TenDangNhap FROM TaiKhoan WHERE PhanQuyen = 'NV')";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                NhanVienKTDTO nhanVienKTDTO = new NhanVienKTDTO();
                nhanVienKTDTO.MaNhanVienKT = Convert.ToInt32(dr["MaNguoiDung"]);
                nhanVienKTDTO.HoTen = dr["HoTen"].ToString();
                nhanVienKTDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                nhanVienKTDTO.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
                nhanVienKTDTO.DiaChi = dr["DiaChi"].ToString();
                nhanVienKTDTO.SDT = dr["SDT"].ToString();
                nhanVienKTDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                listAdminDTO.Add(nhanVienKTDTO);
            }
            return listAdminDTO;
        }

        public NhanVienKTDTO LayThongTin(string tendangnhap)
        {
            NhanVienKTDTO nhanVienKTDTO = null;
            String query = "SELECT * FROM NguoiDung WHERE TenDangNhap = '" + tendangnhap + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                nhanVienKTDTO = new NhanVienKTDTO();
                nhanVienKTDTO.MaNhanVienKT = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);
                nhanVienKTDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
                nhanVienKTDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
                nhanVienKTDTO.GioiTinh = Convert.ToBoolean(dt.Rows[0]["GioiTinh"]);
                nhanVienKTDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                nhanVienKTDTO.SDT = dt.Rows[0]["SDT"].ToString();
                nhanVienKTDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            }
            return nhanVienKTDTO;
        }

        public void SuaThongTin(NhanVienKTDTO nvkt)
        {
            String updateSQL = @"UPDATE NguoiDung SET HoTen = N'{0}', NgaySinh = N'{1}', GioiTinh = '{2}', DiaChi = N'{3}', SDT = '{4}' WHERE MaNguoiDung = '{5}'";
            String query = string.Format(updateSQL, nvkt.HoTen, nvkt.NgaySinh, nvkt.GioiTinh, nvkt.DiaChi, nvkt.SDT, nvkt.MaNhanVienKT);
            DataProvider.ExecuteQuery(query);
        }
    }
}

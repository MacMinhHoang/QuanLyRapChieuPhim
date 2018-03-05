using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        public List<NhanVienDTO> LayDanhSach()
        {
            List<NhanVienDTO> listNhanVienDTO = new List<NhanVienDTO>();

            String query = "SELECT * FROM NhanVien";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                NhanVienDTO nhanVienDTO = new NhanVienDTO();
                nhanVienDTO.MaNhanVien = dr["MaNhanVien"].ToString();
                nhanVienDTO.TenNhanVien = dr["TenNhanVien"].ToString();
                nhanVienDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                nhanVienDTO.GioiTinh = dr["GioiTinh"].ToString();
                nhanVienDTO.CMND = dr["CMND"].ToString();
                nhanVienDTO.DiaChi = dr["DiaChi"].ToString();
                nhanVienDTO.SoDienThoai = dr["SoDienThoai"].ToString();
                nhanVienDTO.ViTri = dr["ViTri"].ToString();
                nhanVienDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                nhanVienDTO.Email = dr["Email"].ToString();

                listNhanVienDTO.Add(nhanVienDTO);
            }

            return listNhanVienDTO;
        }

        public NhanVienDTO LayThongTin(string tendangnhap)
        {
            String query = "SELECT * FROM NhanVien WHERE TenDangNhap = '" + tendangnhap + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            NhanVienDTO nhanVienDTO = new NhanVienDTO();
            nhanVienDTO.MaNhanVien = dt.Rows[0]["MaNhanVien"].ToString();
            nhanVienDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            nhanVienDTO.Email = dt.Rows[0]["Email"].ToString();
            nhanVienDTO.TenNhanVien = dt.Rows[0]["TenNhanVien"].ToString();
            nhanVienDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
            nhanVienDTO.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            nhanVienDTO.CMND = dt.Rows[0]["CMND"].ToString();
            nhanVienDTO.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
            nhanVienDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            nhanVienDTO.ViTri = dt.Rows[0]["ViTri"].ToString();

            return nhanVienDTO;
        }

        public bool ThemNhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string cmnd,
                               string diachi, string sdt, string vitri, string tendn, string email)
        {
            String test_manv = "SELECT * FROM NhanVien WHERE NhanVien.MaNhanVien = '" + manv + "'";
            DataTable dt_manv = DataProvider.ExecuteQuery(test_manv);
            if (dt_manv.Rows.Count > 0)
                return false;
            String query = @"INSERT INTO Nhanvien VALUES ('" + manv + "', N'" + tennv + "', '" + ngaysinh + "', N'" + gioitinh + "', '" 
                + cmnd + "',N'" + diachi + "', '" + sdt + "', N'" + vitri + "', '" + tendn + "', '" + email + "')";
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaNhanVien(string manv)
        {
            String query = "DELETE FROM NhanVien WHERE MaNhanVien = '" + manv + "' ";
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongNhanVien()
        {
            int count = 0;
            String query = "SELECT count(NhanVien.MaNhanVien) as SoLuong FROM NhanVien";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                count = Convert.ToInt32(dr["SoLuong"].ToString());
            }
            return count;
        }

        public void SuaThongTin(string manv, string hoten, string ngaysinh, string gioitinh, string cmnd, string sdt,
                                string diachi, string email, string vitri)
        {
            String query = @"UPDATE NhanVien SET TenNhanVien = N'" + hoten + "', NgaySinh = '" + ngaysinh + "', " +
                "GioiTinh = N'" + gioitinh + "', CMND = '" + cmnd + "', SoDienThoai = '" + sdt + "', " +
                "DiaChi = N'" + diachi + "', Email = '" + email + "', ViTri = N'" + vitri + "' WHERE MaNhanVien = '" + manv + "'";
            DataProvider.ExecuteQuery(query);
        }
    }
}

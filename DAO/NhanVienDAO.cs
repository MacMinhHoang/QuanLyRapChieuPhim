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
                nhanVienDTO.MaNhanVien = (int) dr["MaNhanVien"];
                nhanVienDTO.Luong = (float)dr["Luong"];
                nhanVienDTO.LichLamViec = dr["LichLamViec"].ToString() ;
                
                listNhanVienDTO.Add(nhanVienDTO);
            }

            return listNhanVienDTO;
        }

        public NhanVienDTO LayThongTin(string tendangnhap)
        {
            String query = "select * from NhanVien N, NguoiDung D where D.TenDangNhap = '" + tendangnhap + "' " +
                "and N.MaNhanVien = D.MaNguoiDung";
            DataTable dt = DataProvider.ExecuteQuery(query);
            NhanVienDTO nhanVienDTO = new NhanVienDTO();
            NguoiDungDTO nguoidungDTO = new NguoiDungDTO();
            nhanVienDTO.MaNhanVien = (int) dt.Rows[0]["MaNhanVien"];
            nguoidungDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            nguoidungDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
            nguoidungDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
            nguoidungDTO.GioiTinh =(bool)  dt.Rows[0]["GioiTinh"];
            nguoidungDTO.SDT = dt.Rows[0]["SDT"].ToString();
            nguoidungDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            nhanVienDTO.LichLamViec = dt.Rows[0]["LichLamViec"].ToString();

            return nhanVienDTO;
        }

        public bool ThemNhanVien(string manv, string luong, string lichlamviec)
        {
            String test_manv = "SELECT * FROM NhanVien WHERE NhanVien.MaNhanVien = '" + manv + "'";
            DataTable dt_manv = DataProvider.ExecuteQuery(test_manv);
            if (dt_manv.Rows.Count > 0)
                return false;
            String query = @"INSERT INTO Nhanvien VALUES ('" + manv + "', N'" + luong + "', '" + lichlamviec + "')";
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

        public void SuaThongTin(string manv, string luong, string lichlamviec)
        {
            String query = @"UPDATE NhanVien SET TenNhanVien = N'" + luong + "', NgaySinh = '" + lichlamviec + "' WHERE MaNhanVien = '" + manv + "'";
            DataProvider.ExecuteQuery(query);
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public List<KhachHangDTO> LayDanhSach()
        {
            List<KhachHangDTO> listKhachHangDTO = new List<KhachHangDTO>();

            String query = "SELECT * FROM KhachHang";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                KhachHangDTO khachHangDTO = new KhachHangDTO();
                khachHangDTO.MaKhachHang = dr["MaKhachHang"].ToString();
                khachHangDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                khachHangDTO.TenKhachHang = dr["TenKhachHang"].ToString();
                khachHangDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                khachHangDTO.GioiTinh = dr["GioiTinh"].ToString();
                khachHangDTO.CMND = dr["CMND"].ToString();
                khachHangDTO.Email = dr["Email"].ToString();
                khachHangDTO.SoDienThoai = dr["SoDienThoai"].ToString();
                khachHangDTO.DiaChi = dr["DiaChi"].ToString();

                listKhachHangDTO.Add(khachHangDTO);
            }
            return listKhachHangDTO;
        }

        public void ThemKhachHang(string makh, string tenkh, string ngaysinh, string gioitinh, string cmnd,
                                string diachi, string email, string sdt, string tendn)
        {
            String query = @"INSERT INTO KhachHang VALUES ('" + makh + "', N'" + tenkh + "', '" + ngaysinh + "', N'" + gioitinh + "', '"
                + cmnd + "',N'" + diachi + "', '" + email + "', '" + sdt + "', '" + tendn + "')";
            DataProvider.ExecuteQuery(query);
        }

        public void XoaKhachHang(string makh)
        {
            String query = "DELETE FROM KhachHang WHERE MaKhachHang = '" + makh + "' ";
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongKhachHang()
        {
            int count = 0;
            String query = "SELECT count(KhachHang.MaKhachHang) as SoLuong FROM KhachHang";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                count = Convert.ToInt32(dr["SoLuong"].ToString());
            }
            return count;
        }

        public string LayMaKH(string tendn)
        {
            String query = "SELECT MaKhachHang FROM KhachHang WHERE TenDangNhap = '" + tendn + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            return dt.Rows[0]["MaKhachHang"].ToString();
        }

        public void SuaThongTin(string makh, string hoten, string ngaysinh, string gioitinh, string cmnd, string sdt,
                                string diachi, string email)
        {
            String query = @"UPDATE KhachHang SET TenKhachHang = N'" + hoten + "', NgaySinh = '" + ngaysinh + "', " +
                "GioiTinh = N'" + gioitinh + "', CMND = '" + cmnd + "', SoDienThoai = '" + sdt + "', " +
                "DiaChi = N'" + diachi + "', Email = '" + email + "' WHERE MaKhachHang = '" + makh + "'";
            DataProvider.ExecuteQuery(query);            
        }

        public KhachHangDTO LayThongTin(string tendangnhap)
        {
            String query = "SELECT * FROM KhachHang WHERE TenDangNhap = '" + tendangnhap + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            KhachHangDTO khachHangDTO = null;
            if (dt.Rows.Count > 0)
            {
                khachHangDTO = new KhachHangDTO();
                khachHangDTO.MaKhachHang = dt.Rows[0]["MaKhachHang"].ToString();
                khachHangDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                khachHangDTO.TenKhachHang = dt.Rows[0]["TenKhachHang"].ToString();
                khachHangDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
                khachHangDTO.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
                khachHangDTO.Email = dt.Rows[0]["Email"].ToString();
                khachHangDTO.CMND = dt.Rows[0]["CMND"].ToString();
                khachHangDTO.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
                khachHangDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            }
            return khachHangDTO;
        }
    }
}

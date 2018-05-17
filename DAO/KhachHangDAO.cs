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

            String query = "SELECT * FROM NguoiDung ND, KhachHang KH WHERE KH.MaKhachHang = ND.MaNguoiDung";
            DataTable dt = DataProvider.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                KhachHangDTO khachHangDTO = new KhachHangDTO();
                khachHangDTO.MaKhachHang = Convert.ToInt32(dr["MaKhachHang"]);
                khachHangDTO.HoTen = dr["HoTen"].ToString();
                khachHangDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                khachHangDTO.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
                khachHangDTO.DiaChi = dr["DiaChi"].ToString();
                khachHangDTO.SDT = dr["SDT"].ToString();
                khachHangDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                khachHangDTO.DiemTichLuy = Convert.ToInt32(dr["DiemTichLuy"]);
                listKhachHangDTO.Add(khachHangDTO);
            }
            return listKhachHangDTO;
        }

        public void ThemKhachHang(KhachHangDTO kh, TaiKhoanDTO tk)
        {
            String insertSQL = @"INSERT INTO TaiKhoan VALUES ('{0}', '{1}', '{2}')";
            String query = string.Format(insertSQL, tk.TenDangNhap, tk.MatKhau, tk.PhanQuyen);
            DataProvider.ExecuteQuery(query);

            insertSQL = @"INSERT INTO NguoiDung VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
            query = string.Format(insertSQL, kh.TenDangNhap, kh.HoTen, kh.NgaySinh, kh.GioiTinh, kh.DiaChi, kh.SDT);
            DataProvider.ExecuteQuery(query);

            //Lấy mã người dùng mà CSDL mới tạo
            String SQL = string.Format("SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = '{0}'", tk.TenDangNhap);
            DataTable dt = DataProvider.ExecuteQuery(query);
            int makh = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);

            insertSQL = @"INSERT INTO KhachHang VALUES ('{0}', '{1}')";
            query = string.Format(insertSQL, makh, kh.DiemTichLuy);
            DataProvider.ExecuteQuery(query);
        }

        public void XoaKhachHang(int makh)
        {
            String query = string.Format("DELETE FROM NguoiDung WHERE MaNguoiDung = '{0}'", makh);
            DataProvider.ExecuteQuery(query);
            query = string.Format("DELETE FROM KhachHang WHERE MaKhachHang = '{0}'", makh);
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

        /*   Hàm tối nghĩa  */

        //public string LayMaKH(string makh)
        //{
        //    String query = "SELECT MaKhachHang FROM KhachHang WHERE MaKhachHang = '" + makh + "'";
        //    DataTable dt = DataProvider.ExecuteQuery(query);
        //    return dt.Rows[0]["MaKhachHang"].ToString();
        //}

        public void SuaThongTin(KhachHangDTO kh)
        {
            String updateSQL = @"UPDATE NguoiDung SET HoTen = N'{0}', NgaySinh = N'{1}', GioiTinh = '{2}', DiaChi = N'{3}', SDT = '{4}' Where MaNguoiDung = '{5}'";
            String query = string.Format(updateSQL, kh.HoTen, kh.NgaySinh, kh.GioiTinh, kh.DiaChi, kh.SDT, kh.MaKhachHang);
            DataProvider.ExecuteQuery(query);

            updateSQL = @"UPDATE KhachHang SET DiemTichLuy = '{0}' WHERE MaKhachHang = '{1}'";
            query = string.Format(updateSQL, kh.DiemTichLuy, kh.MaKhachHang);
            DataProvider.ExecuteQuery(query);
        }
    }
}

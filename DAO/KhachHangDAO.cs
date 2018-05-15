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
                khachHangDTO.MaKhachHang = Convert.ToInt32(dr["MaKhachHang"]);
                khachHangDTO.DiemTichLuy = Convert.ToInt32(dr["DiemTichLuy"]);


                listKhachHangDTO.Add(khachHangDTO);
            }
            return listKhachHangDTO;
        }

        public void ThemKhachHang(string makh, string diemtichluy)
        {
            String query = @"INSERT INTO KhachHang VALUES ('" + makh + "', '" + diemtichluy + "')";
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

        public string LayMaKH(string makh)
        {
            String query = "SELECT MaKhachHang FROM KhachHang WHERE MaKhachHang = '" + makh + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            return dt.Rows[0]["MaKhachHang"].ToString();
        }

        public void SuaThongTin(string makh, string hoten, string ngaysinh, string gioitinh, string diachi, string sdt)
        {
            String query = @"update NguoiDung set HoTen = N'" + hoten +"' where NguoiDung.MaNguoiDung = '"+ makh + "'";
            DataProvider.ExecuteQuery(query);            
        }

        public NguoiDungDTO LayThongTin(string tendangnhap)
        {
            String query = "SELECT * FROM KhachHang, NguoiDung WHERE NguoiDung.TenDangNhap = '" + tendangnhap  +"' and NguoiDung.MaNguoiDung = KhachHang.MaKhachHang";
            DataTable dt = DataProvider.ExecuteQuery(query);
            NguoiDungDTO nguoidungDTO = null; 
            if (dt.Rows.Count > 0)
            {
                nguoidungDTO = new NguoiDungDTO();
                nguoidungDTO.MaNguoiDung = (int) dt.Rows[0]["MaNguoiDung"];
                nguoidungDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                nguoidungDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
                nguoidungDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
                nguoidungDTO.GioiTinh = (bool) (dt.Rows[0]["GioiTinh"]);
                nguoidungDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                nguoidungDTO.SDT = dt.Rows[0]["SDT"].ToString();
            }
            return nguoidungDTO;
        }
    }
}

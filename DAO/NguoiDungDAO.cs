using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguoiDungDAO
    {
        public List<NguoiDungDTO> LayDanhSach()
        {
            List<NguoiDungDTO> listNguoiDungDTO = new List<NguoiDungDTO>();

            String query = "SELECT * FROM NguoiDung";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                NguoiDungDTO nguoidungDTO = new NguoiDungDTO();
                nguoidungDTO.MaNguoiDung = (int)dt.Rows[0]["MaNguoiDung"];
                nguoidungDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                nguoidungDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
                nguoidungDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
                nguoidungDTO.GioiTinh = (bool)(dt.Rows[0]["GioiTinh"]);
                nguoidungDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                nguoidungDTO.SDT = dt.Rows[0]["SDT"].ToString();

                listNguoiDungDTO.Add(nguoidungDTO);
            }
            return listNguoiDungDTO;
        }

        public void ThemNguoiDung(string tendangnhap, string hoten, string ngaysinh, string giotinh, string diachi, string sdt)
        {
            String query = @"INSERT INTO KhachHang VALUES ('" + tendangnhap + "', '" + hoten + "','" + ngaysinh + "','" + giotinh + "','" + diachi + "','" + sdt + "',)";
            DataProvider.ExecuteQuery(query);
        }

        public void XoaNguoiDung(string manguoidung)
        {
            String query = "DELETE FROM KhachHang WHERE MaNguoiDung = '" + manguoidung + "' ";
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongNguoiDung()
        {
            int count = 0;
            String query = "SELECT count(NguoiDung.MaNguoiDung) as SoLuong FROM NguoiDung";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                count = Convert.ToInt32(dr["SoLuong"].ToString());
            }
            return count;
        }
    }
}

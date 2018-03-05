using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyDAO
    {
        public List<QuanLyDTO> LayDanhSach()
        {
            List<QuanLyDTO> listQuanLyDTO = new List<QuanLyDTO>();

            String query = "SELECT * FROM QuanLy";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                QuanLyDTO quanLyDTO = new QuanLyDTO();
                quanLyDTO.MaQuanLy = dr["MaQuanLy"].ToString();
                quanLyDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                quanLyDTO.Email = dr["Email"].ToString();
                quanLyDTO.HoTen = dr["HoTen"].ToString();
                quanLyDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                quanLyDTO.GioiTinh = dr["GioiTinh"].ToString();
                quanLyDTO.CMND = dr["CMND"].ToString();
                quanLyDTO.SoDienThoai = dr["SoDienThoai"].ToString();
                quanLyDTO.DiaChi = dr["DiaChi"].ToString();

                listQuanLyDTO.Add(quanLyDTO);
            }
            return listQuanLyDTO;
        }

        public QuanLyDTO LayThongTin(string tendangnhap)
        {
            String query = "SELECT * FROM QuanLy WHERE TenDangNhap = '" + tendangnhap + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            QuanLyDTO quanLyDTO = new QuanLyDTO();
            quanLyDTO.MaQuanLy = dt.Rows[0]["MaQuanLy"].ToString();
            quanLyDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            quanLyDTO.Email = dt.Rows[0]["Email"].ToString();
            quanLyDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
            quanLyDTO.NgaySinh = Convert.ToDateTime(dt.Rows[0]["NgaySinh"]).ToShortDateString();
            quanLyDTO.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            quanLyDTO.CMND = dt.Rows[0]["CMND"].ToString();
            quanLyDTO.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
            quanLyDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();

            return quanLyDTO;
        }

        public void ThemQuanLy(string maql, string tendangnhap, string email, string hoten, string ngaysinh,
            string gioitinh, string cmnd, string sodienthoai, string diachi)
        {
            String query = @"INSERT INTO QuanLy VALUES ('" + maql + "','" + tendangnhap + "','" + email + "',N'" + hoten + "','"
                + ngaysinh + "',N'" + gioitinh + "','" + cmnd + "','" + sodienthoai + "',N'" + diachi + "')";
            DataProvider.ExecuteQuery(query);
        }

        public void XoaQuanLy(string maql)
        {
            String query = @"delete from QuanLy where MaQuanLy = '" + maql + "' ";
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongQuanLy()
        {
            int count = 0;
            String query = "SELECT count(QuanLy.MaQuanLy) as SoLuong FROM QuanLy";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                count = Convert.ToInt32(dr["SoLuong"].ToString());
            }
            return count;
        }

        public void SuaThongTin(string maql, string hoten, string ngaysinh, string gioitinh,
                                string cmnd, string sdt, string diachi, string email)
        {
            String query = @"UPDATE QuanLy SET HoTen = N'" + hoten + "', NgaySinh = '" + ngaysinh + "', " +
                "GioiTinh = N'" + gioitinh + "', CMND = '" + cmnd + "', SoDienThoai = '" + sdt + "', " +
                "DiaChi = N'" + diachi + "', Email = '" + email + "' WHERE MaQuanLy = '" + maql + "'";
            DataProvider.ExecuteQuery(query);
        }
    }

}

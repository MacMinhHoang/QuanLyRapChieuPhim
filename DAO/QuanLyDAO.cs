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
                quanLyDTO.MaQuanLy = Convert.ToInt32(dr["MaNguoiDung"]);
                quanLyDTO.HoTen = dr["HoTen"].ToString();
                quanLyDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                quanLyDTO.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
                quanLyDTO.DiaChi = dr["DiaChi"].ToString();
                quanLyDTO.SDT = dr["SDT"].ToString();
                quanLyDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                listQuanLyDTO.Add(quanLyDTO);
            }
            return listQuanLyDTO;
        }

        public QuanLyDTO LayThongTin(string tendangnhap)
        {
            String query = string.Format("SELECT * FROM NguoiDung WHERE TenDangNhap = '{0}'", tendangnhap);
            DataTable dt = DataProvider.ExecuteQuery(query);
            QuanLyDTO quanLyDTO = new QuanLyDTO();
            quanLyDTO.MaQuanLy = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);
            quanLyDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
            quanLyDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
            quanLyDTO.GioiTinh = Convert.ToBoolean(dt.Rows[0]["GioiTinh"]);
            quanLyDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            quanLyDTO.SDT = dt.Rows[0]["SDT"].ToString();
            quanLyDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();

            return quanLyDTO;
        }

        public void ThemQuanLy(QuanLyDTO ql)
        {
            //String insertSQL = "INSERT INTO QuanLy VALUES ()";
            //String query = string.Format(insertSQL )
            //DataProvider.ExecuteQuery(query);
        }

        public void XoaQuanLy(int maql)
        {
            String query = string.Format(@"DELETE FROM QuanLy WHERE MaQuanLy = {0}", maql);
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongQuanLy()
        {
            int count = 0;
            String query = "SELECT count(ND.MaNguoiDung) as SoLuong FROM NguoiDung ND, TaiKhoan TK " +
                "WHERE ND.TenDangNhap = TK.TenDangNhap AND TK.PhanQuyen = 'QL'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                count = Convert.ToInt32(dr["SoLuong"].ToString());
            }
            return count;
        }

        public void SuaThongTin(QuanLyDTO ql)
        {
            String updateSQL = @"UPDATE NguoiDung SET HoTen = N'{0}', NgaySinh = '{1}', GioiTinh = {2}, DiaChi = N'{3}', SDT = '{4}' WHERE MaNguoiDung = {5}";
            String query = string.Format(updateSQL, ql.HoTen, ql.NgaySinh, ql.GioiTinh, ql.DiaChi, ql.SDT, ql.MaQuanLy);
            DataProvider.ExecuteQuery(query);
        }
    }

}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AdminDAO
    {
        public List<AdminDTO> LayDanhSach()
        {
            List<AdminDTO> listAdminDTO = new List<AdminDTO>();

            String query = "SELECT * FROM NguoiDung WHERE TenDangNhap = " +
                                                    "(SELECT TenDangNhap FROM TaiKhoan WHERE PhanQuyen = 'AD')";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                AdminDTO adminDTO = new AdminDTO();
                adminDTO.MaAdmin = Convert.ToInt32(dr["MaNguoiDung"]);
                adminDTO.HoTen = dr["HoTen"].ToString();
                adminDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                adminDTO.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
                adminDTO.DiaChi = dr["DiaChi"].ToString();
                adminDTO.SDT = dr["SDT"].ToString();
                adminDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                listAdminDTO.Add(adminDTO);
            }
            return listAdminDTO;
        }

        public AdminDTO LayThongTin(string tendangnhap)
        {
            AdminDTO adminDTO = null;
            String query = String.Format("SELECT * FROM NguoiDung WHERE TenDangNhap = '{0}'", tendangnhap);
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                adminDTO = new AdminDTO();
                adminDTO.MaAdmin = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);
                adminDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
                adminDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
                adminDTO.GioiTinh = Convert.ToBoolean(dt.Rows[0]["GioiTinh"]);
                adminDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                adminDTO.SDT = dt.Rows[0]["SDT"].ToString();
                adminDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            }    
            return adminDTO;
        }

        public void SuaThongTin(AdminDTO ad)
        {
            String updateSQL = @"UPDATE NguoiDung SET HoTen = N'{0}', NgaySinh = '{1}', GioiTinh = '{2}', DiaChi = N'{3}', SDT = '{4}' WHERE MaNguoiDung = {5}";
            String query = string.Format(updateSQL, ad.HoTen, ad.NgaySinh, ad.GioiTinh, ad.DiaChi, ad.SDT, ad.MaAdmin);
            DataProvider.ExecuteQuery(query);
        }
    }

}

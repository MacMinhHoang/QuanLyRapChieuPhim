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

            String query = "SELECT * FROM Admin";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                AdminDTO adminDTO = new AdminDTO();
                adminDTO.AdminID = dr["AdminID"].ToString();
                adminDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                adminDTO.Email = dr["Email"].ToString();
                adminDTO.HoTen = dr["HoTen"].ToString();
                adminDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                adminDTO.GioiTinh = dr["GioiTinh"].ToString();
                adminDTO.CMND = dr["CMND"].ToString();
                adminDTO.SoDienThoai = dr["SoDienThoai"].ToString();
                adminDTO.DiaChi = dr["DiaChi"].ToString();

                listAdminDTO.Add(adminDTO);
            }

            return listAdminDTO;
        }

        public AdminDTO LayThongTin(string tendangnhap)
        {
            String query = "SELECT * FROM Admin WHERE TenDangNhap = '" + tendangnhap + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            AdminDTO adminDTO = new AdminDTO();
            adminDTO.AdminID = dt.Rows[0]["AdminID"].ToString();
            adminDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            adminDTO.Email = dt.Rows[0]["Email"].ToString();
            adminDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
            adminDTO.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
            adminDTO.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            adminDTO.CMND = dt.Rows[0]["CMND"].ToString();
            adminDTO.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
            adminDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();

            return adminDTO;
        }

        public void SuaThongTin(string adminID, string hoten, string ngaysinh, string gioitinh,
                                string cmnd, string sdt, string diachi, string email)
        {
            String query = "UPDATE Admin SET HoTen = N'" + hoten + "', NgaySinh = '" + ngaysinh + "', " +
                "GioiTinh = N'" + gioitinh + "', CMND = '" + cmnd + "', SoDienThoai = '" + sdt + "', " +
                "DiaChi = N'" + diachi + "', Email = '" + email + "' WHERE AdminID = '" + adminID + "'";
            DataProvider.ExecuteQuery(query);
        }
    }

}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public List<TaiKhoanDTO> LayDanhSach()
        {
            List<TaiKhoanDTO> listTaiKhoanDTO = new List<TaiKhoanDTO>();

            String query = "SELECT * FROM TaiKhoan";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                taiKhoanDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                taiKhoanDTO.MatKhau = dr["MatKhau"].ToString();
                taiKhoanDTO.ChucNang = dr["ChucNang"].ToString();
                listTaiKhoanDTO.Add(taiKhoanDTO);
            }

            return listTaiKhoanDTO;
        }

        public TaiKhoanDTO DangNhap(String username, String password)
        {
            String query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + username + "' AND MatKhau = '" + password + "' ";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                taiKhoanDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                taiKhoanDTO.MatKhau = dt.Rows[0]["MatKhau"].ToString();
                taiKhoanDTO.ChucNang = dt.Rows[0]["ChucNang"].ToString();
                return taiKhoanDTO;
            }
            return null;
        }

        public bool ThemTaiKhoan(string tendn, string mk, string chucnang)
        {
            String test_tendn = "SELECT * FROM TaiKhoan WHERE TaiKhoan.TenDangNhap = '" + tendn + "'";
            DataTable dt_test = DataProvider.ExecuteQuery(test_tendn);
            if (dt_test.Rows.Count > 0)
                return false;
            String query = "INSERT INTO TaiKhoan VALUES ('" + tendn + "','" + mk + "', N'" + chucnang + "')";
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaTaiKhoan(string tdn)
        {
            String query = "DELETE FROM TaiKhoan WHERE TenDangNhap = '" + tdn + "' ";
            DataProvider.ExecuteQuery(query);
        }
    }
}

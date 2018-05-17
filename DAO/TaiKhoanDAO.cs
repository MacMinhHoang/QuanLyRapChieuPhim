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
                taiKhoanDTO.PhanQuyen = dr["PhanQuyen"].ToString();
                listTaiKhoanDTO.Add(taiKhoanDTO);
            }

            return listTaiKhoanDTO;
        }

        public TaiKhoanDTO DangNhap(String username, String password)
        {
            String query = string.Format("SELECT * FROM TaiKhoan WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'", username, password);
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                taiKhoanDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                taiKhoanDTO.MatKhau = dt.Rows[0]["MatKhau"].ToString();
                taiKhoanDTO.PhanQuyen = dt.Rows[0]["PhanQuyen"].ToString();
                return taiKhoanDTO;
            }
            return null;
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            String test_tendn = string.Format("SELECT * FROM TaiKhoan WHERE TaiKhoan.TenDangNhap = '{0}'", tk.TenDangNhap);
            DataTable dt_test = DataProvider.ExecuteQuery(test_tendn);
            if (dt_test.Rows.Count > 0)
                return false;
            String query = string.Format("INSERT INTO TaiKhoan VALUES ('{0}', '{1}')", tk.TenDangNhap, tk.MatKhau, tk.PhanQuyen);
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaTaiKhoan(string tdn)
        {
            String query = string.Format(@"DELETE FROM TaiKhoan WHERE TenDangNhap = '{0}'", tdn);
            DataProvider.ExecuteQuery(query);
        }
    }
}

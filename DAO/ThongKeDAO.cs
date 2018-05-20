using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO
    {
        public List<ThongKeDTO> LayDanhSach()
        {
            List<ThongKeDTO> listThongKeDTO = new List<ThongKeDTO>();

            String query = "SELECT * FROM ThongKe";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                ThongKeDTO thongKeDTO = new ThongKeDTO();
                thongKeDTO.MaHoatDong = Convert.ToInt32(dr["MaHoatDong"]);
                thongKeDTO.TenHoatDong = dr["TenHoatDong"].ToString();
                thongKeDTO.ChiPhi = (float)Convert.ToDouble(dt.Rows[0]["ChiPhi"]);
                listThongKeDTO.Add(thongKeDTO);
            }
            return listThongKeDTO;
        }

        public ThongKeDTO LayThongTin(string tendangnhap)
        {
            ThongKeDTO ThongKeDTO = null;
            String query = string.Format("SELECT * FROM NguoiDung WHERE TenDangNhap = '{0}'", tendangnhap);
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                ThongKeDTO thongKeDTO = new ThongKeDTO();
                thongKeDTO.MaHoatDong = Convert.ToInt32(dt.Rows[0]["MaHoatDong"]);
                thongKeDTO.TenHoatDong = dt.Rows[0]["TenHoatDong"].ToString();
                thongKeDTO.ChiPhi = Convert.ToInt64(dt.Rows[0]["ChiPhi"]);
            }
            return ThongKeDTO;
        }

        public void SuaThongTin(ThongKeDTO tk)
        {
            String updateSQL = @"UPDATE ThongKe SET TenHoatDong = N'{0}', ChiPhi = {1}";
            String query = string.Format(updateSQL, tk.TenHoatDong, tk.ChiPhi);
            DataProvider.ExecuteQuery(query);
        }

        public void ThemHoatDong(ThongKeDTO tkDTO)
        {
            String SQL = @"INSERT INTO ThongKe VALUES ('{0}', {1})";
            String query = string.Format(SQL, tkDTO.TenHoatDong, tkDTO.ChiPhi);
            DataProvider.ExecuteQuery(query);
        }

        public void XoaHoatDong(int id)
        {
            String query = string.Format("DELETE FROM ThongKe WHERE MaHoatDong = {0}", id);
            DataProvider.ExecuteQuery(query);
        }
    }
}

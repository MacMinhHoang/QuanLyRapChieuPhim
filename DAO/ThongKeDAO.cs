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
                thongKeDTO.ChiPhi = Convert.ToInt64(dr["ChiPhi"]);
                listThongKeDTO.Add(thongKeDTO);
            }
            return listThongKeDTO;
        }

        public ThongKeDTO LayThongTin(string tendangnhap)
        {
            ThongKeDTO ThongKeDTO = null;
            String query = "SELECT * FROM NguoiDung WHERE TenDangNhap = '" + tendangnhap + "'";
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
            String updateSQL = @"UPDATE ThongKe SET TenHoatDong = N'{0}', ChiPhi = '{1}'";
            String query = string.Format(updateSQL, tk.TenHoatDong, tk.ChiPhi);
            DataProvider.ExecuteQuery(query);
        }
    }
}

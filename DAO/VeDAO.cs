using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VeDAO
    {
        public List<VeDTO> LayDanhSach()
        {
            List<VeDTO> listVeDTO = new List<VeDTO>();

            String query = "SELECT * FROM Ve";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                VeDTO VeDTO = new VeDTO();
                VeDTO.MaKhachHang = dr["MaKhachHang"].ToString();
                VeDTO.MaVe = dr["MaVe"].ToString();
                VeDTO.TenPhim = dr["TenPhim"].ToString();
                VeDTO.NgayChieu = dr["NgayChieu"].ToString();
                VeDTO.SuatChieu = dr["SuatChieu"].ToString();
                VeDTO.MaPhongChieu = dr["MaPhongChieu"].ToString();
                VeDTO.ViTriNgoi = dr["ViTriNgoi"].ToString();
                VeDTO.Gia = Convert.ToInt32(dr["Gia"]);

                listVeDTO.Add(VeDTO);
            }

            return listVeDTO;
        }

        public void ThemVe(string makh, string mave, string tenphim, string ngaychieu, string suatchieu,
            string mapc, string vitringoi, int gia)
        {
            String query = @"insert into Ve values ('" + makh + "','" + mave + "', N'" + tenphim +
                "','" + ngaychieu + "','" + suatchieu + "' , '" + mapc + "','" + vitringoi + "'," + gia.ToString() + ")";
            DataProvider.ExecuteQuery(query);
        }

        public void XoaVe(string mave)
        {
            String query = "delete from Ve where MaVe = '" + mave + "' ";
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongVe()
        {
            int count = 0;
            String query = "SELECT count(Ve.MaVe) as SoLuong FROM Ve";
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

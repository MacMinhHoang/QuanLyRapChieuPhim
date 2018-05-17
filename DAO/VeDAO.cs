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
                VeDTO veDTO = new VeDTO();
                veDTO.MaVe = Convert.ToInt32(dr["MaVe"]);
                veDTO.MaKhachHang = Convert.ToInt32(dr["MaKhachHang"]);
                veDTO.MaSuatChieu = Convert.ToInt32(dr["MaSuatChieu"]);
                veDTO.Ghe = dr["Ghe"].ToString();
                veDTO.LoaiVe = Convert.ToBoolean(dr["LoaiVe"]);
                veDTO.GiaVe = Convert.ToInt64(dr["GiaVe"]);
                veDTO.ThanhToan = Convert.ToBoolean(dr["ThanhToan"]);
                veDTO.TinhTrang = Convert.ToBoolean(dr["TinhTrang"]);

                listVeDTO.Add(veDTO);
            }

            return listVeDTO;
        }

        public void ThemVe(VeDTO ve)
        {
            String insertSQL = @"INSERT INTO Ve values ('{0}','{1}', '{2}', '{3}', '{4}', '{5}','{6}')";
            String query = string.Format(insertSQL, ve.MaKhachHang, ve.MaSuatChieu, ve.Ghe, ve.LoaiVe, ve.GiaVe, ve.ThanhToan, ve.TinhTrang);
            DataProvider.ExecuteQuery(query);
        }

        public void XoaVe(int mave)
        {
            String query = string.Format("DELETE FROM Ve where MaVe = '{0}'", mave);
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

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

        public VeDTO LayThongTin(int id)
        {
            VeDTO veDTO = null;
            String query = string.Format("SELECT * FROM Ve WHERE MaVe = {0}", id);
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                veDTO = new VeDTO();
                veDTO.MaVe = Convert.ToInt32(dt.Rows[0]["MaVe"]);
                veDTO.MaKhachHang = Convert.ToInt32(dt.Rows[0]["MaKhachHang"]);
                veDTO.MaSuatChieu = Convert.ToInt32(dt.Rows[0]["MaSuatChieu"]);
                veDTO.Ghe = dt.Rows[0]["Ghe"].ToString();
                veDTO.LoaiVe = Convert.ToBoolean(dt.Rows[0]["LoaiVe"]);
                veDTO.GiaVe = Convert.ToInt64(dt.Rows[0]["GiaVe"]);
                veDTO.ThanhToan = Convert.ToBoolean(dt.Rows[0]["ThanhToan"]);
                veDTO.TinhTrang = Convert.ToBoolean(dt.Rows[0]["TinhTrang"]);
            }

            return veDTO;
        }

        public DataTable LayCacVeDaDat(int MaKH)
        {
            String SQL = "SELECT V.MaVe, P.Ten, S.NgayChieu, S.GioChieu, V.Ghe, V.GiaVe FROM Ve V, Phim P, SuatChieu S " +
                "WHERE MaKhachHang = {0} AND V.MaSuatChieu = S.MaSuatChieu AND S.MaPhim = P.MaPhim";
            String query = string.Format(SQL, MaKH);
            DataTable dt = DataProvider.ExecuteQuery(query);

            return dt;
        }

        public void ThemVe(VeDTO ve)
        {
            String insertSQL = @"INSERT INTO Ve values ({0}, {1}, '{2}', '{3}', {4}, '{5}', '{6}')";
            String query = string.Format(insertSQL, ve.MaKhachHang, ve.MaSuatChieu, ve.Ghe, ve.LoaiVe, ve.GiaVe, ve.ThanhToan, ve.TinhTrang);
            DataProvider.ExecuteQuery(query);
        }

        public void XoaVe(int mave)
        {
            String query = string.Format("DELETE FROM Ve where MaVe = {0}", mave);
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

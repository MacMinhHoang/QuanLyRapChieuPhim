using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KeToanDAO
    {
        public List<KeToanDTO> LayDanhSach()
        {
            List<KeToanDTO> listKeToanDTO = new List<KeToanDTO>();

            String query = "SELECT * FROM NguoiDung WHERE TenDangNhap = " +
                                                    "(SELECT TenDangNhap FROM TaiKhoan WHERE PhanQuyen = 'KT')";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                KeToanDTO keToanDTO = new KeToanDTO();
                keToanDTO.MaKeToan = Convert.ToInt32(dr["MaNguoiDung"]);
                keToanDTO.HoTen = dr["HoTen"].ToString();
                keToanDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                keToanDTO.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
                keToanDTO.DiaChi = dr["DiaChi"].ToString();
                keToanDTO.SDT = dr["SDT"].ToString();
                keToanDTO.TenDangNhap = dr["TenDangNhap"].ToString();
                listKeToanDTO.Add(keToanDTO);
            }
            return listKeToanDTO;
        }

        public KeToanDTO LayThongTin(string tendangnhap)
        {
            KeToanDTO keToanDTO = null;
            String query = "SELECT * FROM NguoiDung WHERE TenDangNhap = '" + tendangnhap + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                keToanDTO = new KeToanDTO();
                keToanDTO.MaKeToan = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);
                keToanDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
                keToanDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
                keToanDTO.GioiTinh = Convert.ToBoolean(dt.Rows[0]["GioiTinh"]);
                keToanDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                keToanDTO.SDT = dt.Rows[0]["SDT"].ToString();
                keToanDTO.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            }
            return keToanDTO;
        }

        public void SuaThongTin(KeToanDTO kt)
        {
            String updateSQL = @"UPDATE NguoiDung SET HoTen = N'{0}', NgaySinh = N'{1}', GioiTinh = '{2}', DiaChi = N'{3}', SDT = '{4}'";
            String query = string.Format(updateSQL, kt.HoTen, kt.NgaySinh, kt.GioiTinh, kt.DiaChi, kt.SDT);
            DataProvider.ExecuteQuery(query);
        }
    }
}

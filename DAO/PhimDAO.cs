using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhimDAO
    {
        public List<PhimDTO> LayDanhSach()
        {
            List<PhimDTO> listPhimDTO = new List<PhimDTO>();

            String query = "SELECT * FROM Phim";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PhimDTO phimDTO = new PhimDTO();
                phimDTO.MaPhim = Convert.ToInt32(dr["MaPhim"]);
                phimDTO.Ten = dr["Ten"].ToString();
                phimDTO.TheLoai = dr["TheLoai"].ToString();
                phimDTO.DaoDien = dr["DaoDien"].ToString();
                phimDTO.DienVien = dr["DienVien"].ToString();
                phimDTO.GioiHanDoTuoi = Convert.ToInt32(dr["GioiHanDoTuoi"]);
                phimDTO.NoiDung = dr["NoiDung"].ToString();
                phimDTO.NamSanXuat = Convert.ToInt32(dr["NamSanXuat"]);
                phimDTO.Poster = dr["Poster"].ToString();
                phimDTO.Trailer = dr["Trailer"].ToString();

                listPhimDTO.Add(phimDTO);
            }

            return listPhimDTO;
        }

        public List<PhimDTO> TimKiemTheoTen(string ten)
        {
            List<PhimDTO> listPhimDTO = new List<PhimDTO>();
            String query = string.Format("SELECT * FROM Phim WHERE Ten LIKE N'% '{0}' %'", ten);
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PhimDTO phimDTO = new PhimDTO();
                phimDTO.Ten = dr["Ten"].ToString();
                phimDTO.TheLoai = dr["TheLoai"].ToString();
                phimDTO.DaoDien = dr["DaoDien"].ToString();
                phimDTO.DienVien = dr["DienVien"].ToString();
                phimDTO.GioiHanDoTuoi = Convert.ToInt32(dr["GioiHanDoTuoi"]);
                phimDTO.NoiDung = dr["NoiDung"].ToString();
                phimDTO.NamSanXuat = Convert.ToInt32(dr["NamSanXuat"]);
                phimDTO.Poster = dr["Poster"].ToString();
                phimDTO.Trailer = dr["Trailer"].ToString();
            }
            return listPhimDTO;
        }

        public List<PhimDTO> TimKiemTheoTheLoai(string theloai)
        {
            List<PhimDTO> listPhimDTO = new List<PhimDTO>();

            String query = string.Format("SELECT * FROM Phim WHERE TheLoai = N'{0}'", theloai);
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PhimDTO phimDTO = new PhimDTO();
                phimDTO.Ten = dr["Ten"].ToString();
                phimDTO.TheLoai = dr["TheLoai"].ToString();
                phimDTO.DaoDien = dr["DaoDien"].ToString();
                phimDTO.DienVien = dr["DienVien"].ToString();
                phimDTO.GioiHanDoTuoi = Convert.ToInt32(dr["GioiHanDoTuoi"]);
                phimDTO.NoiDung = dr["NoiDung"].ToString();
                phimDTO.NamSanXuat = Convert.ToInt32(dr["NamSanXuat"]);
                phimDTO.Poster = dr["Poster"].ToString();
                phimDTO.Trailer = dr["Trailer"].ToString();

                listPhimDTO.Add(phimDTO);
            }
            return listPhimDTO;
        }

        public void ThemPhim(PhimDTO ph)
        {
            String insertSQL = @"INSERT INTO Phim VALUES " +
                "(N'{0}', N'{1}', N'{2}', N'{3}',N'{4}', N'{5}', '{6}' , '{7}', '{8}')";

            String query = string.Format(insertSQL, ph.Ten, ph.TheLoai, ph.DaoDien, ph.DienVien, ph.GioiHanDoTuoi, 
                ph.NoiDung, ph.NamSanXuat, ph.Poster, ph.Trailer);

            DataProvider.ExecuteQuery(query);
        }

        public void XoaPhim(int maphim)
        {
            String query = string.Format("DELETE FROM SuatChieu WHERE MaPhim = '{0}'", maphim); ;
            DataProvider.ExecuteQuery(query);

            query = string.Format("DELETE FROM Phim WHERE MaPhim = '{0}'", maphim);
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongPhim()
        {
            int count = 0;
            String query = "SELECT count(Phim.MaPhim) as SoLuong FROM Phim";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                count = Convert.ToInt32(dr["SoLuong"].ToString());
            }
            return count;
        }

        public List<String> LayDanhSachTenPhim()
        {
            List<String> listTen = new List<String>();

            String query = "SELECT Ten FROM Phim";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                listTen.Add(dr["Ten"].ToString());
            }

            return listTen;
        }
    }
}
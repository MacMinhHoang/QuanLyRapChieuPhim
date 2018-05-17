using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SuatChieuDAO
    {
        public List<SuatChieuDTO> LayDanhSach()
        {
            List<SuatChieuDTO> listSuatChieuDTO = new List<SuatChieuDTO>();

            String query = "SELECT * FROM SuatChieu";
            DataTable dt = DataProvider.ExecuteQuery(query);    
            foreach (DataRow dr in dt.Rows)
            {
                SuatChieuDTO suatchieuDTO = new SuatChieuDTO();
                suatchieuDTO.MaSuatChieu = Convert.ToInt32(dr["MaSuatChieu"]);
                suatchieuDTO.MaPhongChieu = Convert.ToInt32(dr["MaPhongChieu"]);
                suatchieuDTO.NgayChieu = dr["NgayChieu"].ToString();
                suatchieuDTO.GioChieu = dr["GioChieu"].ToString();
                suatchieuDTO.MaPhim = Convert.ToInt32(dr["MaPhim"]);
                
                listSuatChieuDTO.Add(suatchieuDTO);
            }
            return listSuatChieuDTO;
        }

        public List<String> LayDSNgayChieuCuaPhim(string tenphim)
        {
            List<String> listNgay = new List<String>();

            String SQL = "SELECT SC.NgayChieu FROM SuatChieu SC, Phim P WHERE SC.MaPhim = P.MaPhim AND P.Ten = '{0}'";
            String query = string.Format(SQL, tenphim);
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                listNgay.Add(dr["NgayChieu"].ToString());
            } 

            return listNgay;
        }

        public List<String> LayDSSuatChieuCuaPhimTheoNgay(string tenphim, string ngaychieu)
        {
            List<String> listSuat = new List<String>();

            String SQL = "SELECT SC.GioChieu FROM SuatChieu SC, Phim P WHERE SC.MaPhim = P.MaPhim AND P.Ten = '{0}' AND SC.MgayChieu = '{1}'";
            String query = string.Format(SQL, tenphim, ngaychieu);
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                listSuat.Add(dr["GioChieu"].ToString());
            }

            return listSuat;
        }

        public String LayTenPhongChieu(string tenphim, string ngaychieu, string giochieu)
        {
            String SQL = "SELECT TenPhongChieu FROM PhongChieu WHERE MaPhongChieu = " +
                "(SELECT SC.GioChieu FROM SuatChieu SC, Phim P WHERE SC.MaPhim = P.MaPhim AND P.Ten = '{0}' AND SC.MgayChieu = '{1}' AND SC.GioChieu = '{2}')";
            String query = string.Format(SQL, tenphim, ngaychieu, giochieu);
            DataTable dt = DataProvider.ExecuteQuery(query);
            String tenpc = dt.Rows[0]["TenPhongChieu"].ToString();
            return tenpc;
        }

        //public List<SuatChieuDTO> LaySuatChieuTheoTen(string tenphim)
        //{
        //    List<SuatChieuDTO> listSuatChieuDTO = new List<SuatChieuDTO>();

        //    String query = "select * from SuatChieu S, Phim P where P.Ten = N'" + tenphim + "' and P.MaPhim = S.MaPhim";
        //    DataTable dt = DataProvider.ExecuteQuery(query);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        SuatChieuDTO suatchieuDTO = new SuatChieuDTO();
        //        PhimDTO phimDTO = new PhimDTO();
        //        suatchieuDTO.MaPhongChieu = (int) dr["MaPhongChieu"];
        //        suatchieuDTO.NgayChieu = dr["NgayChieu"].ToString();
        //        suatchieuDTO.GioChieu = dr["GioChieu"].ToString();
        //        listSuatChieuDTO.Add(suatchieuDTO);
        //    }
        //    return listSuatChieuDTO;
        //}

        public bool ThemSuatChieu(SuatChieuDTO sc)
        {
            String SQL = "SELECT * FROM SuatChieu WHERE MaPhongChieu = '{0}' AND NgayChieu = '{1}' AND GioChieu = '{2}'";
            String query = string.Format(SQL, sc.MaPhongChieu, sc.NgayChieu, sc.GioChieu);
            DataTable dt = DataProvider.ExecuteQuery(SQL);
            if (dt.Rows.Count > 0)
                return false;
            SQL = @"INSERT INTO SuatChieu VALUES (N'{0}', '{1}', '{2}','{3}')";
            query = string.Format(SQL, sc.MaPhongChieu, sc.NgayChieu, sc.GioChieu, sc.MaPhim);
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaSuatChieu(int ma)
        {
            String query = string.Format("DELETE FROM NhanVien WHERE MaSuatChieu = '{0}'", ma);
            DataProvider.ExecuteQuery(query);

            //Ve có khoa ngoai đến suatchieu
            
            //
        }

        public List<int> ListGheTrong(SuatChieuDTO sc, string day)
        {
            String SQL = "SELECT Ghe FROM Ve WHERE MaSuatCHieu = '{0}' AND ViTriNgoi LIKE '{1}%' ";
            String query = string.Format(SQL, sc.MaSuatChieu, day);
            DataTable dt = DataProvider.ExecuteQuery(query);
            List<int> listGheTrong = new List<int>();
            List<int> listGheDat = new List<int>();
            string tmp;
            foreach (DataRow dr in dt.Rows)
            {
                tmp = dr["Ghe"].ToString();
                tmp = tmp.Substring(1);
                listGheDat.Add(Convert.ToInt32(tmp));
            }
            bool isSelected;
            for (int i = 1; i <= 10; i++)
            {
                isSelected = false;
                for (int j = 0; j < listGheDat.Count; j++)
                {
                    if (listGheDat[j] == i)
                    {
                        isSelected = true;
                        break;
                    }
                }
                if (!isSelected)
                    listGheTrong.Add(i);
            }
            return listGheTrong;
        } 
    }
}

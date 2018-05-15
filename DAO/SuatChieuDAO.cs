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

            String query = "SELECT * FROM SuatChieu, Phim where SuatChieu.MaPhim = Phim.MaPhim";
            DataTable dt = DataProvider.ExecuteQuery(query);    
            foreach (DataRow dr in dt.Rows)
            {
                SuatChieuDTO suatchieuDTO = new SuatChieuDTO();
                PhimDTO phimDTO = new PhimDTO();
                suatchieuDTO.NgayChieu = dr["NgayChieu"].ToString();
                suatchieuDTO.GioChieu = dr["GioChieu"].ToString();
                suatchieuDTO.MaPhim = (int) dr["MaPhim"];
                phimDTO.Ten = dr["Ten"].ToString();
                listSuatChieuDTO.Add(suatchieuDTO);
                ////////
            }
            return listSuatChieuDTO;
        }

        public List<String> LayDanhSachNgayChieu(string tenphim)
        {
            List<String> listNgay = new List<String>();

            String query = "select S.NgayChieu from SuatChieu S, Phim P where P.Ten = N'" + tenphim +"' and P.MaPhim = S.MaPhim ";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                listNgay.Add(dr["NgayChieu"].ToString());
            } 

            return listNgay;
        }

        public List<String> LayDanhSachSuatChieu(string tenphim, string ngaychieu)
        {
            List<String> listSuat = new List<String>();

            String query = "select S.GioChieu from SuatChieu S, Phim P where P.Ten = N'" + tenphim + "' and S.NgayChieu = '" + ngaychieu + "' and P.MaPhim = S.MaPhim";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                listSuat.Add(dr["GioChieu"].ToString());
            }

            return listSuat;
        }

        public String LayMaPhongChieu(string tenphim, string ngaychieu, string giochieu)
        {
            String query = "select S.MaPhongChieu from SuatChieu S, Phim P where P.Ten = N'" + tenphim + "' and S.NgayChieu = '" + ngaychieu + "' and S.GioChieu = '" + giochieu +"' and S.MaPhim = P.MaPhim";
            DataTable dt = DataProvider.ExecuteQuery(query);
            String mapc = dt.Rows[0]["MaPhongChieu"].ToString();
            return mapc;
        }

        public List<SuatChieuDTO> LaySuatChieuTheoTen(string tenphim)
        {
            List<SuatChieuDTO> listSuatChieuDTO = new List<SuatChieuDTO>();

            String query = "select * from SuatChieu S, Phim P where P.Ten = N'" + tenphim + "' and P.MaPhim = S.MaPhim";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                SuatChieuDTO suatchieuDTO = new SuatChieuDTO();
                PhimDTO phimDTO = new PhimDTO();
                suatchieuDTO.MaPhongChieu = (int) dr["MaPhongChieu"];
                suatchieuDTO.NgayChieu = dr["NgayChieu"].ToString();
                suatchieuDTO.GioChieu = dr["GioChieu"].ToString();
                listSuatChieuDTO.Add(suatchieuDTO);
            }
            return listSuatChieuDTO;
        }

        public bool ThemSuatChieu(string maphim, string maphongchieu, string ngaychieu, string giochieu)
        {
            String test = "SELECT * FROM SuatChieu WHERE MaPhongChieu = '" + maphongchieu + "' AND NgayChieu = '" + ngaychieu + "' AND GioChieu = '" + giochieu + "' ";
            DataTable dt = DataProvider.ExecuteQuery(test);
            if (dt.Rows.Count > 0)
                return false;
            String query = "INSERT INTO SuatChieu VALUES (N'" + maphongchieu + "', '" + ngaychieu + "', '" + giochieu + "','" + maphim + "')";
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaSuatChieu(string maphongchieu, string ngaychieu, string giochieu)
        {
            String query = "DELETE FROM NhanVien WHERE MaPhongChieu = '" + maphongchieu + "' AND NgayChieu = '" + ngaychieu + "' AND GioChieu = '" + giochieu + "' ";
            DataProvider.ExecuteQuery(query);
        }

        public List<int> ListGheTrong(string ngaychieu, string suatchieu, string day)
        {
            String query = "SELECT ViTriNgoi FROM Ve WHERE NgayChieu = '" + ngaychieu + "' AND SuatChieu = '" + suatchieu + "' AND ViTriNgoi LIKE '" + day + "%' ";
            DataTable dt = DataProvider.ExecuteQuery(query);
            List<int> listGheTrong = new List<int>();
            List<int> listGheDat = new List<int>();
            string tmp;
            foreach (DataRow dr in dt.Rows)
            {
                tmp = dr["ViTriNgoi"].ToString();
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
        } //
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichChieuDAO
    {
        public List<LichChieuDTO> LayDanhSach()
        {
            List<LichChieuDTO> listLichChieuDTO = new List<LichChieuDTO>();

            String query = "SELECT * FROM LichChieu";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                LichChieuDTO lichChieuDTO = new LichChieuDTO();
                lichChieuDTO.TenPhim = dr["TenPhim"].ToString();
                lichChieuDTO.NgayChieu = dr["NgayChieu"].ToString();
                lichChieuDTO.SuatChieu = dr["SuatChieu"].ToString();
                lichChieuDTO.MaPhongChieu = dr["MaPhongChieu"].ToString();
                listLichChieuDTO.Add(lichChieuDTO);
            }
            return listLichChieuDTO;
        }

        public List<String> LayDanhSachNgayChieu(string tenphim)
        {
            List<String> listNgay = new List<String>();

            String query = "SELECT NgayChieu FROM LichChieu WHERE TenPhim = N'" + tenphim + "' ";
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

            String query = "SELECT SuatChieu FROM LichChieu WHERE TenPhim = N'" + tenphim + "' AND NgayChieu = '" + ngaychieu + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                listSuat.Add(dr["SuatChieu"].ToString());
            }

            return listSuat;
        }

        public String LayMaPhongChieu(string ngaychieu, string suatchieu)
        {
            String query = "SELECT MaPhongChieu FROM LichChieu WHERE NgayChieu = '" + ngaychieu + "' AND SuatChieu = '" + suatchieu + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            String mapc = dt.Rows[0]["MaPhongChieu"].ToString();
            return mapc;
        }

        public List<LichChieuDTO> LayLichChieuTheoTen(string tenphim)
        {
            List<LichChieuDTO> listLichChieuDTO = new List<LichChieuDTO>();

            String query = "SELECT * FROM LichChieu WHERE TenPhim = N'" + tenphim + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                LichChieuDTO lichChieuDTO = new LichChieuDTO();
                lichChieuDTO.TenPhim = dr["TenPhim"].ToString();
                lichChieuDTO.NgayChieu = dr["NgayChieu"].ToString();
                lichChieuDTO.SuatChieu = dr["SuatChieu"].ToString();
                lichChieuDTO.MaPhongChieu = dr["MaPhongChieu"].ToString();
                listLichChieuDTO.Add(lichChieuDTO);
            }
            return listLichChieuDTO;
        }

        public bool ThemLichChieu(string tenphim, string maphongchieu, string ngaychieu, string suatchieu)
        {
            String test = "SELECT * FROM LichChieu WHERE MaPhongChieu = '" + maphongchieu + "' AND NgayChieu = '" + ngaychieu + "' AND SuatChieu = '" + suatchieu + "' ";
            DataTable dt = DataProvider.ExecuteQuery(test);
            if (dt.Rows.Count > 0)
                return false;
            String query = "INSERT INTO LichChieu VALUES (N'" + tenphim + "', '" + maphongchieu + "', '" + ngaychieu + "', '" + suatchieu + "')";
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaLichChieu(string maphongchieu, string ngaychieu, string suatchieu)
        {
            String query = "DELETE FROM NhanVien WHERE MaPhongChieu = '" + maphongchieu + "' AND NgayChieu = '" + ngaychieu + "' AND SuatChieu = '" + suatchieu + "' ";
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
        }
    }
}

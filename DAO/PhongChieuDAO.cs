using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongChieuDAO
    {
        public List<PhongChieuDTO> LayDanhSach()
        {
            List<PhongChieuDTO> listPhongChieuDTO = new List<PhongChieuDTO>();

            String query = "SELECT * FROM PhongChieu";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PhongChieuDTO phongChieuDTO = new PhongChieuDTO();
                phongChieuDTO.MaPhongChieu = Convert.ToInt32(dr["MaPhongChieu"]);
                phongChieuDTO.TenPhongChieu = dr["TenPhongChieu"].ToString();
                phongChieuDTO.SoLuongGhe = Convert.ToInt32(dr["SoLuongGhe"]);
                phongChieuDTO.TinhTrang = Convert.ToBoolean(dr["TinhTrang"]);
                listPhongChieuDTO.Add(phongChieuDTO);
            }
            return listPhongChieuDTO;
        }

        public PhongChieuDTO LayThongTin(string mapc)
        {
            PhongChieuDTO phongChieuDTO = null;

            String query = string.Format("SELECT * FROM PhongChieu WHERE MaPhongChieu = '{0}'", mapc);
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                phongChieuDTO = new PhongChieuDTO();
                phongChieuDTO.MaPhongChieu = Convert.ToInt32(dr["MaPhongChieu"]);
                phongChieuDTO.TenPhongChieu = dr["TenPhongChieu"].ToString();
                phongChieuDTO.SoLuongGhe = Convert.ToInt32(dr["SoLuongGhe"]);
                phongChieuDTO.TinhTrang = Convert.ToBoolean(dr["TinhTrang"]);
            }
            return phongChieuDTO;
        }

        public bool ThemPhongChieu(PhongChieuDTO pc)
        {
            String test_mapc = string.Format("SELECT * FROM PhongChieu WHERE MaPhongChieu = '{0}'", pc.MaPhongChieu);
            DataTable dt_mapc = DataProvider.ExecuteQuery(test_mapc);
            if (dt_mapc.Rows.Count > 0)
                return false;
            String query = string.Format(@"INSERT INTO PhongChieu VALUES ('N{0}', '{1}',  '{2}')", 
                pc.TenPhongChieu, pc.SoLuongGhe, pc.TinhTrang);
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaPhongChieu(int mpc)
        {
            String query = string.Format("DELETE FROM PhongChieu WHERE MaPhongChieu = '{0}'", mpc);
            DataProvider.ExecuteQuery(query);
        }

        public List<String> LayDanhSachMaPhongChieu()
        {
            List<String> listMa = new List<String>();

            String query = "SELECT MaPhongChieu FROM PhongChieu";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                listMa.Add(dr["MaPhongChieu"].ToString());
            }

            return listMa;
        }

        public List<Char> LayDanhSachDayGhe(int mapc)
        {
            List<Char> listDay = new List<Char>();

            String query = string.Format("SELECT SoLuongGhe FROM PhongChieu WHERE MaPhongChieu = '{0}'", mapc);
            DataTable dt = DataProvider.ExecuteQuery(query);
            int size = Convert.ToInt32(dt.Rows[0]["SoLuongGhe"]);
            Char c = 'A';
            for (int i = 0; i < size / 10; i++)
            {
                listDay.Add(c);
                c++;
            }
            return listDay;
        }
    }
}


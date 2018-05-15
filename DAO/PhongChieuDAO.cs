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
                phongChieuDTO.TenPhongChieu = dr["TenPhongChieu"].ToString();
                phongChieuDTO.SoLuongGhe = Convert.ToInt32(dr["SoLuongGhe"]);
                phongChieuDTO.TinhTrang = (bool) dr["TinhTrang"];
                listPhongChieuDTO.Add(phongChieuDTO);
            }
            return listPhongChieuDTO;
        }

        public PhongChieuDTO LayThongTin(string mapc)
        {
            PhongChieuDTO phongChieuDTO = null;

            String query = "SELECT * FROM PhongChieu WHERE MaPhongChieu = '" + mapc + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                phongChieuDTO = new PhongChieuDTO();
                phongChieuDTO.MaPhongChieu = (int)dr["MaPhongChieu"];
                phongChieuDTO.TenPhongChieu = dr["TenPhongChieu"].ToString();
                phongChieuDTO.SoLuongGhe = Convert.ToInt32(dr["SoLuongGhe"]);
                phongChieuDTO.TinhTrang = (bool)dr["TinhTrang"];
            }
            return phongChieuDTO;
        }

        public bool ThemPhongChieu(string mapc, string tenpc, string soluongghe,  string tinhtrang)
        {
            String test_mapc = "SELECT * FROM PhongChieu WHERE PhongChieu.MaPhongChieu = '" + mapc + "'";
            DataTable dt_mapc = DataProvider.ExecuteQuery(test_mapc);
            if (dt_mapc.Rows.Count > 0)
                return false;
            String query = @"INSERT INTO PhongChieu VALUES ('" + tenpc + "', '" + soluongghe + "',  N'"
                + tinhtrang + "')";
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaPhongChieu(string mpc)
        {
            String query = "DELETE FROM PhongChieu WHERE MaPhongChieu = '" + mpc + "' ";
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

        public List<Char> LayDanhSachDayGhe(string mapc)
        {
            List<Char> listDay = new List<Char>();

            String query = "SELECT SoLuongGhe FROM PhongChieu WHERE MaPhongChieu = '" + mapc + "'";
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


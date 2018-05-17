using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        //Nhân viên thường
        public List<NhanVienDTO> LayDanhSach()
        {
            List<NhanVienDTO> listNhanVienDTO = new List<NhanVienDTO>();

            //Nhân viên bình thường ko có tài khoản, NV kĩ thuật thì có
            String query = "SELECT * FROM NguoiDung ND, NhanVien NV WHERE NV.MaNhanVien = ND.MaNguoiDung " +
                "AND ND.TenDangNhap = NULL";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                NhanVienDTO nhanVienDTO = new NhanVienDTO();
                nhanVienDTO.MaNhanVien = Convert.ToInt32(dr["MaNhanVien"]);
                nhanVienDTO.HoTen = dr["HoTen"].ToString();
                nhanVienDTO.NgaySinh = (dr["NgaySinh"]).ToString();
                nhanVienDTO.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
                nhanVienDTO.DiaChi = dr["DiaChi"].ToString();
                nhanVienDTO.SDT = dr["SDT"].ToString();
                nhanVienDTO.Luong = Convert.ToInt32(dr["Luong"]);
                nhanVienDTO.LichLamViec = dr["LichLamViec"].ToString() ;
                
                listNhanVienDTO.Add(nhanVienDTO);
            }

            return listNhanVienDTO;
        }

        public NhanVienDTO LayThongTin(string id)
        {
            NhanVienDTO nhanVienDTO = null;
            String query = string.Format("SELECT * FROM NguoiDung ND, NhanVien NV WHERE NV.MaNhanVien = {0} " +
                "AND NV.MaNhanVien = ND.MaNguoiDung", id);
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                nhanVienDTO = new NhanVienDTO();
                nhanVienDTO.MaNhanVien = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);
                nhanVienDTO.HoTen = dt.Rows[0]["HoTen"].ToString();
                nhanVienDTO.NgaySinh = (dt.Rows[0]["NgaySinh"]).ToString();
                nhanVienDTO.GioiTinh = Convert.ToBoolean(dt.Rows[0]["GioiTinh"]);
                nhanVienDTO.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                nhanVienDTO.SDT = dt.Rows[0]["SDT"].ToString();
                nhanVienDTO.Luong = Convert.ToInt32(dt.Rows[0]["Luong"]);
                nhanVienDTO.LichLamViec = dt.Rows[0]["LichLamViec"].ToString();
            }
            return nhanVienDTO;
        }

        public bool ThemNhanVien(NhanVienDTO nv)
        {
            String insertSQL = @"INSERT INTO NguoiDung VALUES ({0}, N'{1}', '{2}', {3}, N'{4}', '{5}')";
            String query = string.Format(insertSQL, null, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.SDT);
            DataProvider.ExecuteQuery(query);

            //Lấy mã người dùng mà CSDL mới tạo
            String SQL = string.Format("SELECT MaNguoiDung FROM NguoiDung WHERE HoTen = N'{0}' AND NgaySinh = ", nv.HoTen, nv.NgaySinh);
            DataTable dt = DataProvider.ExecuteQuery(query);
            int manv = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);

            query = string.Format(@"INSERT INTO Nhanvien VALUES ({0}, {1}, '{2}')", manv, nv.Luong, nv.LichLamViec);
            DataProvider.ExecuteQuery(query);
            return true;
        }

        public void XoaNhanVien(int manv)
        {
            String query = string.Format("DELETE FROM NhanVien WHERE MaNhanVien = {0}", manv);
            DataProvider.ExecuteQuery(query);
            query = string.Format("DELETE FROM NguoiDung WHERE MaNguoiDung = {0}", manv);
            DataProvider.ExecuteQuery(query);
        }

        public int SoLuongNhanVien()
        {
            int count = 0;
            String query = "SELECT count(NhanVien.MaNhanVien) as SoLuong FROM NhanVien";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                count = Convert.ToInt32(dr["SoLuong"].ToString());
            }
            return count;
        }

        public void SuaThongTin(NhanVienDTO nv)
        {
            String SQL = @"UPDATE NhanVien SET Luong = {0}, LichlamViec = '{1}' WHERE MaNhanVien = {2}";
            String query = string.Format(SQL, nv.Luong, nv.LichLamViec, nv.MaNhanVien);
            DataProvider.ExecuteQuery(query);

            SQL = @"UPDATE NguoiDung SET HoTen = N'{0}', NgaySinh = '{1}', GioiTinh = {2}, DiaChi = N'{3}', SDT = '{4}' WHERE MaNguoiDung = {5}";
            query = string.Format(SQL, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.SDT, nv.MaNhanVien);
            DataProvider.ExecuteQuery(query);
        }
    }
}

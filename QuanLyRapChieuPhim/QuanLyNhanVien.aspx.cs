using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyNhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachNhanVien();
        }

        private void FilGVDanhSachNhanVien()
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            gvDanhSachNhanVien.DataSource = nvBUS.LayDanhSach();
            gvDanhSachNhanVien.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //bool flag_tk = false;
            //TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            //flag_tk = tkBUS.ThemTaiKhoan(tbTenDN.Text, tbMatKhau.Text, "NV");
            //if (flag_tk == false)
            //{
            //    string strBuilder = "<script language='javascript'>alert('" + "Tên đăng nhập đã tồn tại" + "')</script>";
            //    Response.Write(strBuilder);
            //    ResetTextBoxes();
            //    return;
            //}

            NhanVienBUS nvBUS = new NhanVienBUS();
            NhanVienDTO nv = new NhanVienDTO();
            nv.HoTen = tbTenNV.Text;
            nv.NgaySinh = tbNgaySinh.Text;
            nv.GioiTinh = (tbGioiTinh.Text == "Nữ");
            nv.DiaChi = tbDiaChi.Text;
            nv.SDT = tbSDT.Text;
            nv.Luong = Convert.ToInt64(tbLuong.Text);
            nv.LichLamViec = tbLLV.Text;
            nvBUS.ThemNhanVien(nv);

            //int count = nvBUS.SoLuongNhanVien();
            //string manv = "";
            //if (count / 10 == 0)
            //    manv = "NV000" + count.ToString();
            //else if (count / 100 == 0)
            //    manv = "NV00" + count.ToString();
            //else if (count / 1000 == 0)
            //    manv = "NV0" + count.ToString();
            //else
            //    manv = "NV" + count.ToString();
            string strBuilder = "<script language='javascript'>alert('" + "Thêm thành công" + "')</script>";
            Response.Write(strBuilder);
            ResetTextBoxes();
            FilGVDanhSachNhanVien();
        }

        protected void gvDanhSachNhanVien_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            NhanVienBUS nvBUS = new NhanVienBUS();
            TableCell cell = gvDanhSachNhanVien.Rows[e.RowIndex].Cells[0];
            nvBUS.XoaNhanVien(Convert.ToInt32(cell.Text));
            cell = gvDanhSachNhanVien.Rows[e.RowIndex].Cells[8];
            tkBUS.XoaTaiKhoan(cell.Text);
            string strBuilder = "<script language='javascript'>alert('" + "Xóa thành công" + "')</script>";
            Response.Write(strBuilder);
            FilGVDanhSachNhanVien();
        }

        private void ResetTextBoxes()
        {
            tbTenNV.Text = "";
            tbGioiTinh.Text = "";
            tbNgaySinh.Text = "";
            tbLuong.Text = "";
            tbSDT.Text = "";
            tbDiaChi.Text = "";
            tbLuong.Text = "";
            tbLLV.Text = "";
        }
    }
}
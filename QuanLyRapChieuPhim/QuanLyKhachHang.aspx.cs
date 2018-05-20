using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachKhachHang();

        }

        private void FilGVDanhSachKhachHang()
        {
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            gvDanhSachKhachHang.DataSource = khachHangBUS.LayDanhSach();
            gvDanhSachKhachHang.DataBind();

        }

        //protected void btnAddKH_Click(object sender, EventArgs e)
        //{
        //    bool flag_tk = false;
        //    TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        //    flag_tk = tkBUS.ThemTaiKhoan(tbTenDNKH.Text, tbMatKhauKH.Text, "KH");
        //    if (flag_tk == false)
        //    {
        //        string strBuilder = "<script language='javascript'>alert('" + "Ten Khach Hang da ton tai" + "')</script>";
        //        Response.Write(strBuilder);
        //        tbMaKH.Text = "";
        //        tbTenKH.Text = "";
        //        tbGioiTinhKH.Text = "";
        //        tbNgaySinhKH.Text = "";
        //        tbCMNDKH.Text = "";
        //        tbSDTKH.Text = "";
        //        tbDiaChiKH.Text = "";
        //        tbTenDNKH.Text = "";
        //        tbMatKhauKH.Text = "";
        //        return;
        //    }
        //    bool flag_nv = false;
        //    KhachHangBUS khBUS = new KhachHangBUS();
        //    flag_nv = khBUS.ThemKhachHang(tbMaKH.Text, tbTenKH.Text, tbNgaySinhKH.Text, tbGioiTinhKH.Text, tbCMNDKH.Text,
        //                        tbDiaChiKH.Text, tbSDTKH.Text, tbTenDNKH.Text);
        //    if (flag_nv == false)
        //    {
        //        string strBuilder = "<script language='javascript'>alert('" + "Ma Nhan Vien da ton tai" + "')</script>";
        //        Response.Write(strBuilder);
        //        tbMaKH.Text = "";
        //        tbTenKH.Text = "";
        //        tbGioiTinhKH.Text = "";
        //        tbNgaySinhKH.Text = "";
        //        tbCMNDKH.Text = "";
        //        tbSDTKH.Text = "";
        //        tbDiaChiKH.Text = "";
        //        tbTenDNKH.Text = "";
        //        tbMatKhauKH.Text = "";
        //        return;
        //    }
        //    tbMaKH.Text = "";
        //    tbTenKH.Text = "";
        //    tbGioiTinhKH.Text = "";
        //    tbNgaySinhKH.Text = "";
        //    tbCMNDKH.Text = "";
        //    tbSDTKH.Text = "";
        //    tbDiaChiKH.Text = "";
        //    tbTenDNKH.Text = "";
        //    tbMatKhauKH.Text = "";
        //    FilGVDanhSachKhachHang();
        //}

        protected void gvDanhSachKhachHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            KhachHangBUS nvBUS = new KhachHangBUS();
            TableCell cell = gvDanhSachKhachHang.Rows[e.RowIndex].Cells[0];
            nvBUS.XoaKhachHang(Convert.ToInt32(cell.Text));
            cell = gvDanhSachKhachHang.Rows[e.RowIndex].Cells[8];
            tkBUS.XoaTaiKhoan(cell.Text);
            string strBuilder = "<script language='javascript'>alert('" + "Xóa thành công" + "')</script>";
            Response.Write(strBuilder);
            FilGVDanhSachKhachHang();
        }
    }
}
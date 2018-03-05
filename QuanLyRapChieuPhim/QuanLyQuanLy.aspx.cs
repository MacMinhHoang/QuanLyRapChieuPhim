using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyQuanLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachQuanLy();
        }

        private void FilGVDanhSachQuanLy()
        {
            QuanLyBUS quanLyBUS = new QuanLyBUS();
            gvDanhSachQuanLy.DataSource = quanLyBUS.LayDanhSach();
            gvDanhSachQuanLy.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag_tk = false;
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            flag_tk = tkBUS.ThemTaiKhoan(tbTenDN.Text, tbMatKhau.Text, "QL");
            if (flag_tk == false)
            {
                string strBuilder = "<script language='javascript'>alert('" + "Ten Dang Nhap da ton tai" + "')</script>";
                Response.Write(strBuilder);
                ResetTextBoxes();
                return;
            }

            QuanLyBUS qlBUS = new QuanLyBUS();
            int count = qlBUS.SoLuongQuanLy();
            string maql = "";
            if (count / 10 == 0)
                maql = "QL0" + count.ToString();
            else
                maql = "QL" + count.ToString();
            qlBUS.ThemQuanLy(maql, tbTenDN.Text, tbEmail.Text, tbTenQL.Text, tbNgaySinh.Text, tbGioiTinh.Text, tbCMND.Text,
                                 tbSDT.Text, tbDiaChi.Text);

            ResetTextBoxes();
            FilGVDanhSachQuanLy();
        }
        private void ResetTextBoxes()
        {
            tbTenQL.Text = "";
            tbGioiTinh.Text = "";
            tbNgaySinh.Text = "";
            tbCMND.Text = "";
            tbSDT.Text = "";
            tbDiaChi.Text = "";
            tbTenDN.Text = "";
            tbMatKhau.Text = "";
            tbEmail.Text = "";
        }

        protected void gvDanhSachQuanLy_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            QuanLyBUS nvBUS = new QuanLyBUS();
            TableCell cell = gvDanhSachQuanLy.Rows[e.RowIndex].Cells[0];
            nvBUS.XoaQuanLy(cell.Text);
            cell = gvDanhSachQuanLy.Rows[e.RowIndex].Cells[8];
            tkBUS.XoaTaiKhoan(cell.Text);
            FilGVDanhSachQuanLy();
        }
    }
}
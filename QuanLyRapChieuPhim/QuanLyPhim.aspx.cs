using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyPhim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachPhim();
        }

        private void FilGVDanhSachPhim()
        {
            PhimBUS phimBUS = new PhimBUS();
            gvDanhSachPhim.DataSource = phimBUS.LayDanhSach();
            gvDanhSachPhim.DataBind();
        }

        protected void btnAddPhim_Click(object sender, EventArgs e)
        {
            PhimBUS pBUS = new PhimBUS();
            int count = pBUS.SoLuongPhim();
            string map = "";
            if (count / 10 == 0)
                map = "P00" + count.ToString();
            else if (count / 100 == 0)
                map = "P0" + count.ToString();
            else
                map = "P" + count.ToString();
            pBUS.ThemPhim(map, tbTenPhim.Text, tbTheLoai.Text, tbDaoDien.Text, tbDienVien.Text,
                                tbNoiDung.Text, tbGHDT.Text, Convert.ToInt32(tbNamSX.Text), tbPoster.Text, tbTrailer.Text);
            ResetTextBoxes();
            FilGVDanhSachPhim();
        }
        private void ResetTextBoxes()
        {
            tbTenPhim.Text = "";
            tbDaoDien.Text = "";
            tbTheLoai.Text = "";
            tbDienVien.Text = "";
            tbGHDT.Text = "";
            tbNoiDung.Text = "";
            tbNamSX.Text = "";
            tbPoster.Text = "";
            tbTrailer.Text = "";
        }

        protected void gvDanhSachPhim_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PhimBUS pBUS = new PhimBUS();
            TableCell cell = gvDanhSachPhim.Rows[e.RowIndex].Cells[0];
            pBUS.XoaPhim(cell.Text);
            cell = gvDanhSachPhim.Rows[e.RowIndex].Cells[8];
            FilGVDanhSachPhim();
        }
    }
}
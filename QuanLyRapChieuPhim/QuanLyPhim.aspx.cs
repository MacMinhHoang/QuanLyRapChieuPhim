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
            //int count = pBUS.SoLuongPhim();
            //string map = "";
            //if (count / 10 == 0)
            //    map = "P00" + count.ToString();
            //else if (count / 100 == 0)
            //    map = "P0" + count.ToString();
            //else
            //    map = "P" + count.ToString();
            PhimDTO ph = new PhimDTO();
            ph.Ten = tbTenPhim.Text;
            ph.TheLoai = tbTheLoai.Text;
            ph.DaoDien = tbDaoDien.Text;
            ph.DienVien = tbDienVien.Text;
            ph.GioiHanDoTuoi = Convert.ToInt32(tbGHDT.Text);
            ph.NoiDung = tbNoiDung.Text;
            ph.NamSanXuat = Convert.ToInt32(tbNamSX.Text);
            ph.Poster = tbPoster.Text;
            ph.Trailer = tbTrailer.Text;
            pBUS.ThemPhim(ph);

            string strBuilder = "<script language='javascript'>alert('" + "Thêm thành công" + "')</script>";
            Response.Write(strBuilder);
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
            pBUS.XoaPhim(Convert.ToInt32(cell.Text));
            cell = gvDanhSachPhim.Rows[e.RowIndex].Cells[8];
            string strBuilder = "<script language='javascript'>alert('" + "Thêm thành công" + "')</script>";
            Response.Write(strBuilder);
            FilGVDanhSachPhim();
        }
    }
}
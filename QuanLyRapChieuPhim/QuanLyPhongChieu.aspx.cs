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
    public partial class QuanLyPhongChieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachPhongChieu();
        }

        private void FilGVDanhSachPhongChieu()
        {
            PhongChieuBUS phongChieuBUS = new PhongChieuBUS();
            gvDanhSachPhongChieu.DataSource = phongChieuBUS.LayDanhSach();
            gvDanhSachPhongChieu.DataBind();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //bool flag_pc = false;
            PhongChieuBUS pcBUS = new PhongChieuBUS();
            PhongChieuDTO pc = new PhongChieuDTO();
            pc.TenPhongChieu = tbTenPC.Text;
            pc.SoLuongGhe = Convert.ToInt32(tbSoLuongCho.Text);
            pc.TinhTrang = (tbTinhTrang.Text == "Hoạt động");

            pcBUS.ThemPhongChieu(pc);

            //if (flag_pc == false)
            //{
            //    string strBuilder = "<script language='javascript'>alert('" + "Ma Phong Chieu da ton tai" + "')</script>";
            //    Response.Write(strBuilder);
            //    tbMaPC.Text = "";
            //    tbSoLuongCho.Text = "";
            //    tbLoaiMC.Text = "";
            //    tbLoaiAT.Text = "";
            //    tbTinhTrang.Text = "";
            //    return;
            //}
            tbTenPC.Text = "";
            tbSoLuongCho.Text = "";
            tbTinhTrang.Text = "";
            string strBuilder = "<script language='javascript'>alert('" + "Thêm thành công" + "')</script>";
            Response.Write(strBuilder);
            FilGVDanhSachPhongChieu();
        }

        protected void gvDanhSachPhongChieu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PhongChieuBUS pcBUS = new PhongChieuBUS();
            TableCell cell = gvDanhSachPhongChieu.Rows[e.RowIndex].Cells[0];
            pcBUS.XoaPhongChieu(Convert.ToInt32(cell.Text));
            string strBuilder = "<script language='javascript'>alert('" + "Xóa thành công" + "')</script>";
            Response.Write(strBuilder);
            FilGVDanhSachPhongChieu();
        }
    }
}
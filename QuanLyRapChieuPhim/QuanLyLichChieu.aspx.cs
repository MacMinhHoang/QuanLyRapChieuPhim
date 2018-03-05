using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyLichChieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachLichChieu();
        }

        private void FilGVDanhSachLichChieu()
        {
            LichChieuBUS lichChieuBUS = new LichChieuBUS();
            gvDanhSachLichChieu.DataSource = lichChieuBUS.LayDanhSach();
            gvDanhSachLichChieu.DataBind();

            PhimBUS phimBUS = new PhimBUS();
            ddl_tenphim.DataSource = phimBUS.LayDanhSachTenPhim();
            ddl_tenphim.DataBind();

            PhongChieuBUS phongChieuBUS = new PhongChieuBUS();
            ddl_maphongchieu.DataSource = phongChieuBUS.LayDanhSachMaPhongChieu();
            ddl_maphongchieu.DataBind();
        }

        protected void gvDanhSachLichChieu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
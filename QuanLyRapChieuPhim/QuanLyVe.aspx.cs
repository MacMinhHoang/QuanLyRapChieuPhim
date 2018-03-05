using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyVe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachVe();
        }

        private void FilGVDanhSachVe()
        {
            VeBUS veBUS = new VeBUS();
            gvDanhSachVe.DataSource = veBUS.LayDanhSach();
            gvDanhSachVe.DataBind();
        }
    }
}
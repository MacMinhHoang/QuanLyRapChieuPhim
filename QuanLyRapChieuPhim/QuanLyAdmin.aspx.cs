using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachAdmin();
        }

        private void FilGVDanhSachAdmin()
        {
            AdminBUS adminBUS = new AdminBUS();
            gvDanhSachAdmin.DataSource = adminBUS.LayDanhSach();
            gvDanhSachAdmin.DataBind();
        }
    }
}
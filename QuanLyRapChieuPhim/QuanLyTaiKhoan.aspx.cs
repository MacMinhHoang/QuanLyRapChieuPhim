using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyTaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachTaiKhoan();
        }

        private void FilGVDanhSachTaiKhoan()
        {
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            gvDanhSachTaiKhoan.DataSource = taiKhoanBUS.LayDanhSach();
            gvDanhSachTaiKhoan.DataBind();
        }
    }
}
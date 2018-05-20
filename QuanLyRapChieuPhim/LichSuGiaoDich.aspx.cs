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
    public partial class LichSuGiaoDich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                KhachHangBUS khachHangBUS = new KhachHangBUS();
                int ma = khachHangBUS.LayMaKH(Session["TenDangNhap"].ToString());

                VeBUS veBUS = new VeBUS();
                gvDSVe.DataSource = veBUS.LayCacVeDaDat(ma);
                gvDSVe.DataBind();

            }
        }
    }
}
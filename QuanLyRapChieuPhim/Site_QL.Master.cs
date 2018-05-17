using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class Site_QL : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Home_Click(object sender, ImageClickEventArgs e)
        {
            switch (Session["ChucNang"])
            {
                case "AD":
                    Response.Redirect("Admin.aspx");
                    break;
                case "NV":
                    Response.Redirect("NhanVien.aspx");
                    break;
                case "QL":
                    Response.Redirect("QuanLy.aspx");
                    break;
            }

        }

        protected void btn_LogOut_Click(object sender, ImageClickEventArgs e)
        {
            Session["isLogin"] = false;
            Session["TenDangNhap"] = null;
            Session["ChucNang"] = null;
            string strBuilder = "<script language='javascript'>alert('" + "Đã đăng xuất" + "')</script>";
            Response.Write(strBuilder);
            Server.Transfer("Default.aspx");
        }
    }
}
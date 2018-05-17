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
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] == null || (bool)Session["isLogin"] == false)
            {
                labelTenNguoiDung.Text = "";
                labelLogout.Visible = false;
                btn_LogOut.Visible = false;
                labelLogin.Visible = true;
                linkLogin.Visible = true;
            }
            else
            {
                KhachHangBUS khachHangBUS = new KhachHangBUS();
                KhachHangDTO khachHangDTO = khachHangBUS.LayThongTin(Session["TenDangNhap"].ToString());
                if (khachHangDTO == null)
                {
                    labelTenNguoiDung.Text = "";
                    labelLogout.Visible = false;
                    btn_LogOut.Visible = false;
                    labelLogin.Visible = true;
                    linkLogin.Visible = true;
                }
                else
                {
                    labelTenNguoiDung.Text = khachHangDTO.TenDangNhap;
                    labelLogout.Visible = true;
                    btn_LogOut.Visible = true;
                    labelLogin.Visible = false;
                    linkLogin.Visible = false;

                }
            }
        }

        protected void btn_LogOut_Click(object sender, EventArgs e)
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
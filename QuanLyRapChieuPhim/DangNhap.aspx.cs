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
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorMessage1.Visible = false;
            ErrorMessage2.Visible = false;


        }

        protected void btn_LoginKH_Click(object sender, ImageClickEventArgs e)
        {
            var username = tb_KHUsername.Text;
            var password = tb_KHPassword.Text;
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            TaiKhoanDTO taiKhoanDTO = taiKhoanBUS.DangNhap(username, password);
            if (taiKhoanDTO != null)
            {

                if (taiKhoanDTO.ChucNang == "KH")
                {
                    Session["isLogin"] = true;
                    Session["TenDangNhap"] = taiKhoanDTO.TenDangNhap;
                    Session["ChucNang"] = taiKhoanDTO.ChucNang;
                    Response.Redirect("KhachHang.aspx");
                }
                else
                {
                    ErrorMessage1.Text = "Mục này chỉ dành cho khách hàng. Xin hãy kéo xuống";
                    ErrorMessage1.Visible = true;
                }

            }
            else
            {
                Session["isLogin"] = false;
                ErrorMessage1.Text = "Sai tên đăng nhập/mật khẩu";
                ErrorMessage1.Visible = true;
            }
        }

        protected void btn_LoginNV_Click(object sender, ImageClickEventArgs e)
        {
            var username = tb_NVUsername.Text;
            var password = tb_NVPassword.Text;
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            TaiKhoanDTO taiKhoanDTO = taiKhoanBUS.DangNhap(username, password);

            if (taiKhoanDTO != null)
            {
                Session["isLogin"] = true;
                Session["TenDangNhap"] = taiKhoanDTO.TenDangNhap;
                Session["ChucNang"] = taiKhoanDTO.ChucNang;
                switch (taiKhoanDTO.ChucNang)
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
                    case "KH":
                        ErrorMessage2.Text = "Mục này chỉ dành cho nhân viên. Xin hãy kéo lên";
                        ErrorMessage2.Visible = true;
                        break;
                }

            }
            else
            {
                Session["isLogin"] = false;
                ErrorMessage2.Visible = true;
                ErrorMessage2.Text = "Sai tên đăng nhập/mật khẩu";
            }
        }
    }
}
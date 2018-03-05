using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Convert.ToString(Request.Form["__EVENTARGUMENT"]) == "submit")
                {
                    TaiKhoanBUS tkBUS = new TaiKhoanBUS();
                    KhachHangBUS khBUS = new KhachHangBUS();

                    // Tự phát sinh MaKhachHang
                    int count = khBUS.SoLuongKhachHang();
                    string makh = "";
                    if (count / 10 == 0)
                        makh = "KH0000" + count.ToString();
                    else if (count / 100 == 0)
                        makh = "KH000" + count.ToString();
                    else if (count / 1000 == 0)
                        makh = "KH00" + count.ToString();
                    else if (count / 10000 == 0)
                        makh = "KH0" + count.ToString();
                    else
                        makh = "KH" + count.ToString();

                    string tenkh = Request.Form["fullname"];
                    string ngaysinh = Request.Form["birthday"];
                    string gioitinh = Request.Form["sex"];
                    string cmnd = Request.Form["cmnd"];
                    string diachi = Request.Form["address"];
                    string email = Request.Form["email"];
                    string sdt = Request.Form["phone"];
                    string tendn = Request.Form["username"];
                    string mk = Request.Form["password"];

                    tkBUS.ThemTaiKhoan(tendn, mk, "KH");
                    khBUS.ThemKhachHang(makh, tenkh, ngaysinh, gioitinh, cmnd, diachi, email, sdt, tendn);


                    string strBuilder = "<script language='javascript'>alert('" + "Đăng ký thành công" + "')</script>";
                    Response.Write(strBuilder);
                    Server.Transfer("DangNhap.aspx");
                }
            }
        }
    }
}
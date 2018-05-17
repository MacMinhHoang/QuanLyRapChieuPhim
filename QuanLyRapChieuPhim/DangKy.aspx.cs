using DTO;
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
                    // Tự phát sinh MaKhachHang
                    //int count = khBUS.SoLuongKhachHang();
                    //string makh = "";
                    //if (count / 10 == 0)
                    //    makh = "KH0000" + count.ToString();
                    //else if (count / 100 == 0)
                    //    makh = "KH000" + count.ToString();
                    //else if (count / 1000 == 0)
                    //    makh = "KH00" + count.ToString();
                    //else if (count / 10000 == 0)
                    //    makh = "KH0" + count.ToString();
                    //else
                    //    makh = "KH" + count.ToString();

                    //string cmnd = Request.Form["cmnd"];
                    //string email = Request.Form["email"];

                    KhachHangBUS khBUS = new KhachHangBUS();
                    TaiKhoanDTO tk = new TaiKhoanDTO();
                    tk.TenDangNhap = Request.Form["username"];
                    tk.MatKhau = Request.Form["password"];
                    tk.PhanQuyen = "KH";

                    KhachHangDTO kh = new KhachHangDTO();
                    kh.TenDangNhap = tk.TenDangNhap;
                    kh.HoTen = Request.Form["fullname"];
                    kh.NgaySinh = Request.Form["birthday"];
                    if (Request.Form["sex"].Equals("Nam"))
                        kh.GioiTinh = true;
                    else kh.GioiTinh = false;
                    kh.DiaChi = Request.Form["address"];
                    kh.SDT = Request.Form["phone"];
                    khBUS.ThemKhachHang(kh, tk);


                    string strBuilder = "<script language='javascript'>alert('" + "Đăng ký thành công" + "')</script>";
                    Response.Write(strBuilder);
                    Server.Transfer("DangNhap.aspx");
                }
            }
        }
    }
}
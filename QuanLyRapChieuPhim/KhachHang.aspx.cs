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
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lb_TenDangNhap.Text = Session["TenDangNhap"].ToString();
                KhachHangBUS khachHangBUS = new KhachHangBUS();
                KhachHangDTO khachHangDTO = khachHangBUS.LayThongTin(lb_TenDangNhap.Text);

                lb_ID.Text = khachHangDTO.MaKhachHang;
                tb_HoTen.Text = khachHangDTO.TenKhachHang;
                tb_NgaySinh.Text = khachHangDTO.NgaySinh;
                tb_GioiTinh.Text = khachHangDTO.GioiTinh;
                tb_CMND.Text = khachHangDTO.CMND;
                tb_SDT.Text = khachHangDTO.SoDienThoai;
                tb_DiaChi.Text = khachHangDTO.DiaChi;
                tb_Email.Text = khachHangDTO.Email;
            }
        }

        protected void ID_EditButton_Click(object sender, EventArgs e)
        {
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            khachHangBUS.SuaThongTin(lb_ID.Text, tb_HoTen.Text, tb_NgaySinh.Text, tb_GioiTinh.Text, tb_CMND.Text,
                tb_SDT.Text, tb_DiaChi.Text, tb_Email.Text);
        }
    }
}
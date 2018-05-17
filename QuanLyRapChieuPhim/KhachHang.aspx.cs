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

                lb_ID.Text = khachHangDTO.MaKhachHang.ToString();
                tb_HoTen.Text = khachHangDTO.HoTen;
                tb_NgaySinh.Text = khachHangDTO.NgaySinh;
                tb_GioiTinh.Text = (khachHangDTO.GioiTinh) ? "Nữ" : "Nam";
                tb_DiaChi.Text = khachHangDTO.DiaChi;
                tb_SDT.Text = khachHangDTO.SDT;
                tb_Diem.Text = khachHangDTO.DiemTichLuy.ToString();
            }
        }

        protected void ID_EditButton_Click(object sender, EventArgs e)
        {
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKhachHang = Convert.ToInt32(lb_ID.Text);
            kh.HoTen = tb_HoTen.Text;
            kh.NgaySinh = tb_NgaySinh.Text;
            kh.GioiTinh = (tb_GioiTinh.Text == "Nữ");
            kh.DiaChi = tb_DiaChi.Text;
            kh.SDT = tb_SDT.Text;
            kh.DiemTichLuy = Convert.ToInt32(tb_Diem.Text);

            khachHangBUS.SuaThongTin(kh);
        }
    }
}
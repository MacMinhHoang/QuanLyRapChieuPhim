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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String tendangnhap = Session["TenDangNhap"].ToString();
                AdminBUS adminBUS = new AdminBUS();
                NhanVienKTDTO adminDTO = adminBUS.LayThongTin(tendangnhap);
                lb_TenDangNhap.Text = tendangnhap;

                lb_ID.Text = adminDTO.AdminID;
                tb_HoTen.Text = adminDTO.HoTen;
                tb_NgaySinh.Text = adminDTO.NgaySinh;
                tb_GioiTinh.Text = adminDTO.GioiTinh;
                tb_CMND.Text = adminDTO.CMND;
                tb_SDT.Text = adminDTO.SoDienThoai;
                tb_DiaChi.Text = adminDTO.DiaChi;
                tb_Email.Text = adminDTO.Email;
            }
        }

        protected void btn_Sua_Click(object sender, EventArgs e)
        {
            AdminBUS adminBUS = new AdminBUS();
            adminBUS.SuaThongTin(lb_ID.Text, tb_HoTen.Text, tb_NgaySinh.Text, tb_GioiTinh.Text, tb_CMND.Text, tb_SDT.Text, tb_DiaChi.Text, tb_Email.Text);
        }
    }
}
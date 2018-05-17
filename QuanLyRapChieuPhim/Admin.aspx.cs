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
                AdminDTO adminDTO = adminBUS.LayThongTin(tendangnhap);
                lb_TenDangNhap.Text = tendangnhap;

                lb_ID.Text = adminDTO.MaAdmin.ToString();
                tb_HoTen.Text = adminDTO.HoTen;
                tb_NgaySinh.Text = adminDTO.NgaySinh;
                //0 : Nam, 1 : Nữ
                tb_GioiTinh.Text = (adminDTO.GioiTinh) ? "Nữ" : "Nam";
                tb_DiaChi.Text = adminDTO.DiaChi;
                tb_SDT.Text = adminDTO.SDT;
            }
        }

        protected void btn_Sua_Click(object sender, EventArgs e)
        {
            AdminDTO adminDTO = new AdminDTO();
            adminDTO.MaAdmin = Convert.ToInt32(lb_ID.Text);
            adminDTO.HoTen = tb_HoTen.Text;
            adminDTO.NgaySinh = tb_NgaySinh.Text;
            adminDTO.GioiTinh = (tb_GioiTinh.Text == "Nữ");
            adminDTO.DiaChi = tb_DiaChi.Text;
            adminDTO.SDT = tb_SDT.Text;

            AdminBUS adminBUS = new AdminBUS();
            adminBUS.SuaThongTin(adminDTO);
        }
    }
}
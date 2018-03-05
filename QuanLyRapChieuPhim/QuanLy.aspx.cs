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
    public partial class QuanLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lb_TenDangNhap.Text = Session["TenDangNhap"].ToString();
                QuanLyBUS quanLyBUS = new QuanLyBUS();
                QuanLyDTO quanLyDTO = quanLyBUS.LayThongTin(lb_TenDangNhap.Text);

                lb_ID.Text = quanLyDTO.MaQuanLy;
                tb_HoTen.Text = quanLyDTO.HoTen;
                tb_NgaySinh.Text = quanLyDTO.NgaySinh;
                tb_GioiTinh.Text = quanLyDTO.GioiTinh;
                tb_CMND.Text = quanLyDTO.CMND;
                tb_SDT.Text = quanLyDTO.SoDienThoai;
                tb_DiaChi.Text = quanLyDTO.DiaChi;
                tb_Email.Text = quanLyDTO.Email;
            }
        }

        protected void btn_Sua_Click(object sender, EventArgs e)
        {
            QuanLyBUS quanLyBUS = new QuanLyBUS();
            quanLyBUS.SuaThongTin(lb_ID.Text, tb_HoTen.Text, tb_NgaySinh.Text, tb_GioiTinh.Text, tb_CMND.Text,
                tb_SDT.Text, tb_DiaChi.Text, tb_Email.Text);
        }
    }
}
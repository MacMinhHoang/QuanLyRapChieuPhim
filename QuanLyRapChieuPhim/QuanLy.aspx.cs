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

                lb_ID.Text = quanLyDTO.MaQuanLy.ToString();
                tb_HoTen.Text = quanLyDTO.HoTen;
                tb_NgaySinh.Text = quanLyDTO.NgaySinh;
                tb_GioiTinh.Text = (quanLyDTO.GioiTinh) ? "Nữ" : "Nam";
                tb_DiaChi.Text = quanLyDTO.DiaChi;
                tb_SDT.Text = quanLyDTO.SDT;
            }
        }

        protected void btn_Sua_Click(object sender, EventArgs e)
        {
            QuanLyBUS quanLyBUS = new QuanLyBUS();
            QuanLyDTO ql = new QuanLyDTO();
            ql.MaQuanLy = Convert.ToInt32(lb_ID.Text);
            ql.HoTen = tb_HoTen.Text;
            ql.NgaySinh = tb_NgaySinh.Text;
            ql.GioiTinh = (tb_GioiTinh.Text == "Nữ");
            ql.DiaChi = tb_DiaChi.Text;
            ql.SDT = tb_SDT.Text;

            quanLyBUS.SuaThongTin(ql);
        }
    }
}
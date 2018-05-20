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
    public partial class KeToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String tendangnhap = Session["TenDangNhap"].ToString();
                KeToanBUS keToanBUS = new KeToanBUS();
                KeToanDTO keToanDTO = keToanBUS.LayThongTin(tendangnhap);
                lb_TenDangNhap.Text = tendangnhap;

                lb_ID.Text = keToanDTO.MaKeToan.ToString();
                tb_HoTen.Text = keToanDTO.HoTen;
                tb_NgaySinh.Text = keToanDTO.NgaySinh;
                //0 : Nam, 1 : Nữ
                tb_GioiTinh.Text = (keToanDTO.GioiTinh) ? "Nữ" : "Nam";
                tb_DiaChi.Text = keToanDTO.DiaChi;
                tb_SDT.Text = keToanDTO.SDT;
            }
        }

        protected void btn_Sua_Click(object sender, EventArgs e)
        {
            KeToanDTO keToanDTO = new KeToanDTO();
            keToanDTO.MaKeToan = Convert.ToInt32(lb_ID.Text);
            keToanDTO.HoTen = tb_HoTen.Text;
            keToanDTO.NgaySinh = tb_NgaySinh.Text;
            keToanDTO.GioiTinh = (tb_GioiTinh.Text == "Nữ");
            keToanDTO.DiaChi = tb_DiaChi.Text;
            keToanDTO.SDT = tb_SDT.Text;

            KeToanBUS keToanBUS = new KeToanBUS();
            keToanBUS.SuaThongTin(keToanDTO);
            string strBuilder = "<script language='javascript'>alert('" + "Cập nhật thành công" + "')</script>";
            Response.Write(strBuilder);
        }
    }
}
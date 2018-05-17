using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class NhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lb_TenDangNhap.Text = Session["TenDangNhap"].ToString();
                NhanVienKTBUS nhanVienKTBUS = new NhanVienKTBUS();
                NhanVienKTDTO nhanVienKTDTO = nhanVienKTBUS.LayThongTin(lb_TenDangNhap.Text);

                lb_ID.Text = nhanVienKTDTO.MaNhanVienKT.ToString();
                tb_HoTen.Text = nhanVienKTDTO.HoTen;
                tb_NgaySinh.Text = nhanVienKTDTO.NgaySinh;
                tb_GioiTinh.Text = (nhanVienKTDTO.GioiTinh) ? "Nữ" : "Nam";
                tb_SDT.Text = nhanVienKTDTO.SDT;
                tb_DiaChi.Text = nhanVienKTDTO.DiaChi;
            }
        }

        protected void ID_EditButton_Click(object sender, EventArgs e)
        {
            NhanVienKTBUS nhanVienKTBUS = new NhanVienKTBUS();
            NhanVienKTDTO nv = new NhanVienKTDTO();
            nv.MaNhanVienKT = Convert.ToInt32(lb_ID.Text);
            nv.HoTen = tb_HoTen.Text;
            nv.NgaySinh = tb_NgaySinh.Text;
            nv.GioiTinh = (tb_GioiTinh.Text == "Nữ");
            nv.DiaChi = tb_DiaChi.Text;
            nv.SDT = tb_SDT.Text;

            nhanVienKTBUS.SuaThongTin(nv);
        }
    }
}
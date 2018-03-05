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
                NhanVienBUS nhanVienBUS = new NhanVienBUS();
                NhanVienDTO nhanVienDTO = nhanVienBUS.LayThongTin(lb_TenDangNhap.Text);

                lb_ID.Text = nhanVienDTO.MaNhanVien;
                tb_HoTen.Text = nhanVienDTO.TenNhanVien;
                tb_NgaySinh.Text = nhanVienDTO.NgaySinh;
                tb_GioiTinh.Text = nhanVienDTO.GioiTinh;
                tb_CMND.Text = nhanVienDTO.CMND;
                tb_SDT.Text = nhanVienDTO.SoDienThoai;
                tb_DiaChi.Text = nhanVienDTO.DiaChi;
                tb_Email.Text = nhanVienDTO.Email;
                tb_ViTri.Text = nhanVienDTO.ViTri;
            }
        }

        protected void ID_EditButton_Click(object sender, EventArgs e)
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            nhanVienBUS.SuaThongTin(lb_ID.Text, tb_HoTen.Text, tb_NgaySinh.Text,
                                    tb_GioiTinh.Text, tb_CMND.Text, tb_SDT.Text,
                                    tb_DiaChi.Text, tb_Email.Text, tb_ViTri.Text);
        }
    }
}
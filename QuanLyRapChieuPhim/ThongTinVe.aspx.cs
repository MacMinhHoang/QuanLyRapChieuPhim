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
    public partial class ThongTinVe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String MaVe = Request.QueryString["id"];
            VeBUS veBUS = new VeBUS();
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            PhimBUS phimBUS = new PhimBUS();
            PhongChieuBUS phongChieuBUS = new PhongChieuBUS();

            VeDTO veDTO = veBUS.LayThongTin(Convert.ToInt32(MaVe));
            SuatChieuDTO suatChieuDTO = suatChieuBUS.LayThongTin(veDTO.MaSuatChieu);
            PhimDTO phimDTO = phimBUS.LayThongTin(suatChieuDTO.MaPhim);
            PhongChieuDTO phongChieuDTO = phongChieuBUS.LayThongTin(suatChieuDTO.MaPhongChieu);

            VeID.Text += veDTO.MaVe.ToString();
            Phim.Text += phimDTO.Ten;
            PhongChieu.Text += phongChieuDTO.TenPhongChieu;
            NgayChieu.Text += suatChieuDTO.NgayChieu;
            SuatCHieu.Text += suatChieuDTO.GioChieu;
            SoGhe.Text += veDTO.Ghe;
            LoaiVe.Text += (veDTO.LoaiVe) ? "VIP" : "Thường";
            GiaVe.Text += veDTO.GiaVe.ToString() + " VNĐ";
        }
    }
}
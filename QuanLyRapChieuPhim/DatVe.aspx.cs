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
    public partial class DatVe : System.Web.UI.Page
    {
        private static int maPhim;
        private static string ngayChieu;
        private static string gioChieu;
        private static string dayNgoi;
        private static string gheNgoi;
        private static bool thanhToan = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                maPhim = Convert.ToInt32(Request.QueryString["id"]);
                PhimBUS phimBUS = new PhimBUS();
                PhimDTO phimDTO = phimBUS.LayThongTin(maPhim);

                lbl_name.Text = phimDTO.Ten;

                SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
                rdl_ngaychieu.DataSource = suatChieuBUS.LayDSNgayChieuCuaPhim(maPhim);
                rdl_ngaychieu.DataBind();
            }
        }

        protected bool xacDinhLoaiVe()
        {
            return ('E' <= dayNgoi[0] && dayNgoi[0] <= 'G');
        }

        protected void rdl_ngaychieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ngayChieu = rdl_ngaychieu.SelectedItem.Text;
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            rdl_suatchieu.DataSource = suatChieuBUS.LayDSSuatChieuCuaPhimTheoNgay(maPhim, ngayChieu);
            rdl_suatchieu.DataBind();
        }

        protected void rdl_suatchieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            gioChieu = rdl_suatchieu.SelectedItem.Text;
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            PhongChieuBUS phongChieuBUS = new PhongChieuBUS();
            int mapc = suatChieuBUS.LayMaPhongChieu(maPhim, ngayChieu, gioChieu);
            ddl_day.DataSource = phongChieuBUS.LayDanhSachDayGhe(mapc);
            ddl_day.DataBind();
        }

        protected void ddl_day_DataBound(object sender, EventArgs e)
        {
            dayNgoi = ddl_day.SelectedItem.Text;
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            SuatChieuDTO suatChieuDTO = new SuatChieuDTO();
            suatChieuDTO.MaPhim = maPhim;
            suatChieuDTO.NgayChieu = ngayChieu;
            suatChieuDTO.GioChieu = gioChieu;
            ddl_soghe.DataSource = suatChieuBUS.ListGheTrong(suatChieuDTO, dayNgoi);
            ddl_soghe.DataBind();
        }

        protected void ddl_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayNgoi = ddl_day.SelectedItem.Text;
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            SuatChieuDTO suatChieuDTO = new SuatChieuDTO();
            suatChieuDTO.MaPhim = maPhim;
            suatChieuDTO.NgayChieu = ngayChieu;
            suatChieuDTO.GioChieu = gioChieu;
            ddl_soghe.DataSource = suatChieuBUS.ListGheTrong(suatChieuDTO, dayNgoi);
            ddl_soghe.DataBind();
        }

        protected void ddl_soghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            gheNgoi = ddl_soghe.SelectedItem.Text;
        }

        protected void ddl_soghe_DataBound(object sender, EventArgs e)
        {
            gheNgoi = ddl_soghe.SelectedItem.Text;
        }

        protected void btn_DatVe_Click(object sender, EventArgs e)
        {
            //Thiếu hình thức thanh toán

            VeBUS veBUS = new VeBUS();
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            //int count = veBUS.SoLuongVe();
            //string mave = "";
            //if (count / 10 == 0)
            //    mave = "V00" + count.ToString();
            //else if (count / 100 == 0)
            //    mave = "V0" + count.ToString();
            //else
            //    mave = "V" + count.ToString();
            int mapc = suatChieuBUS.LayMaPhongChieu(maPhim, ngayChieu, gioChieu);
            int makh = khachHangBUS.LayMaKH(Session["TenDangNhap"].ToString());
            int masuat = suatChieuBUS.LayMaSuatChieu(ngayChieu, gioChieu, mapc);
            VeDTO ve = new VeDTO();
            ve.MaKhachHang = makh;
            ve.MaSuatChieu = masuat;
            ve.Ghe = dayNgoi + gheNgoi;
            ve.LoaiVe = xacDinhLoaiVe();
            ve.GiaVe = (ve.LoaiVe) ? 80000 : 50000;
            ve.ThanhToan = thanhToan;
            ve.TinhTrang = false;

            veBUS.ThemVe(ve);

            KhachHangDTO khachHangDTO = khachHangBUS.LayThongTin(Session["TenDangNhap"].ToString());
            int bonus = (int)(ve.GiaVe / 10000);
            khachHangDTO.DiemTichLuy += bonus;
            khachHangBUS.SuaThongTin(khachHangDTO);

            string strBuilder = "<script language='javascript'>alert('" + "Đặt vé thành công. Bạn được cộng " + bonus.ToString() + " điểm." + "')</script>";
            Response.Write(strBuilder);

            List<VeDTO> listVe = veBUS.LayDanhSach();
            int id = listVe[listVe.Count - 1].MaVe;
            Server.Transfer("ThongTinVe.aspx?id=" + id.ToString());
        }

        protected void ddl_thanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            thanhToan = (ddl_thanhtoan.SelectedValue == "1");
        }
    }
}
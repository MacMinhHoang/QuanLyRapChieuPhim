using BUS;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl_name.Text = Session["TenPhim"].ToString();

                SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
                rdl_ngaychieu.DataSource = suatChieuBUS.LayDanhSachNgayChieu(lbl_name.Text);
                rdl_ngaychieu.DataBind();
            }
        }

        protected void rdl_ngaychieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            rdl_suatchieu.DataSource = suatChieuBUS.LayDanhSachSuatChieu(Session["TenPhim"].ToString(), rdl_ngaychieu.SelectedItem.Text);
            rdl_suatchieu.DataBind();
        }

        protected void rdl_suatchieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            PhongChieuBUS phongChieuBUS = new PhongChieuBUS();
            String mapc = suatChieuBUS.LayMaPhongChieu(rdl_ngaychieu.SelectedItem.Text, rdl_suatchieu.SelectedItem.Text);
            ddl_day.DataSource = phongChieuBUS.LayDanhSachDayGhe(mapc);
            ddl_day.DataBind();
        }

        protected void ddl_day_DataBound(object sender, EventArgs e)
        {
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            ddl_soghe.DataSource = suatChieuBUS.ListGheTrong(rdl_ngaychieu.SelectedItem.Text, rdl_suatchieu.SelectedItem.Text, ddl_day.SelectedItem.Text);
            ddl_soghe.DataBind();
        }

        protected void btn_DatVe_Click(object sender, EventArgs e)
        {
            VeBUS veBUS = new VeBUS();
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            int count = veBUS.SoLuongVe();
            string mave = "";
            if (count / 10 == 0)
                mave = "V00" + count.ToString();
            else if (count / 100 == 0)
                mave = "V0" + count.ToString();
            else
                mave = "V" + count.ToString();

            String mapc = suatChieuBUS.LayMaPhongChieu(rdl_ngaychieu.SelectedItem.Text, rdl_suatchieu.SelectedItem.Text);
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            string makh = khachHangBUS.LayMaKH(Session["TenDangNhap"].ToString());
            int gia = 75000;
            string ViTri = ddl_day.SelectedItem.Text + ddl_soghe.SelectedItem.Text;
            veBUS.ThemVe(makh, mave, lbl_name.Text, rdl_ngaychieu.SelectedItem.Text, rdl_suatchieu.SelectedItem.Text, mapc, ViTri, gia);

            string strBuilder = "<script language='javascript'>alert('" + "Đặt vé thành công" + "')</script>";
            Response.Write(strBuilder);
            Server.Transfer("PhimDangChieu.aspx");
        }

        protected void ddl_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
            ddl_soghe.DataSource = suatChieuBUS.ListGheTrong(rdl_ngaychieu.SelectedItem.Text, rdl_suatchieu.SelectedItem.Text, ddl_day.SelectedItem.Text);
            ddl_soghe.DataBind();
        }
    }
}
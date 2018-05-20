using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyLichChieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachLichChieu();
        }

        private void FilGVDanhSachLichChieu()
        {
            SuatChieuBUS SuatChieuBUS = new SuatChieuBUS();
            gvDanhSachLichChieu.DataSource = SuatChieuBUS.LayDanhSach();
            gvDanhSachLichChieu.DataBind();

            PhimBUS phimBUS = new PhimBUS();
            ddl_maphim.DataSource = phimBUS.LayDanhSachIDPhim();
            ddl_maphim.DataBind();

            PhongChieuBUS phongChieuBUS = new PhongChieuBUS();
            ddl_maphongchieu.DataSource = phongChieuBUS.LayDanhSachMaPhongChieu();
            ddl_maphongchieu.DataBind();
        }

        protected void gvDanhSachLichChieu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SuatChieuBUS scBUS = new SuatChieuBUS();
            TableCell cell = gvDanhSachLichChieu.Rows[e.RowIndex].Cells[0];
            scBUS.XoaSuatChieu(Convert.ToInt32(cell.Text));
            FilGVDanhSachLichChieu();
        }

        protected void btn_Them_Click(object sender, EventArgs e)
        {
            SuatChieuDTO scDTO = new SuatChieuDTO();
            scDTO.MaPhim = Convert.ToInt32(ddl_maphim.SelectedItem.Text);
            scDTO.MaPhongChieu = Convert.ToInt32(ddl_maphongchieu.SelectedItem.Text);
            DateTime dt = new DateTime();
            DateTime.TryParseExact(tbNgayChieu.Text, "yyyy-mm-dd", null, DateTimeStyles.None, out dt);
            scDTO.NgayChieu = dt.ToString("dd/mm/yyyy");
            scDTO.GioChieu = tbGioChieu.Text;

            SuatChieuBUS scBUS = new SuatChieuBUS();
            scBUS.ThemSuatChieu(scDTO);

            tbNgayChieu.Text = "";
            tbGioChieu.Text = "";
            FilGVDanhSachLichChieu();
        }
    }
}
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
    public partial class QuanLyDoanhThu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FilGVDanhSachHoatDong();
        }

        private void FilGVDanhSachHoatDong()
        {
            ThongKeBUS tkBUS = new ThongKeBUS();
            gvDanhSachHoatDong.DataSource = tkBUS.LayDanhSach();
            gvDanhSachHoatDong.DataBind();
        }

        protected void gvDanhSachHoatDong_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ThongKeBUS tkBUS = new ThongKeBUS();
            TableCell cell = gvDanhSachHoatDong.Rows[e.RowIndex].Cells[0];
            tkBUS.XoaHoatDong(Convert.ToInt32(cell.Text));
            FilGVDanhSachHoatDong();
        }

        protected void btn_Them_Click(object sender, EventArgs e)
        {
            ThongKeDTO tkDTO = new ThongKeDTO();
            tkDTO.TenHoatDong = tbTenHD.Text;
            tkDTO.ChiPhi = (float)Convert.ToDouble(tbChiPhi.Text);

            ThongKeBUS tkBUS = new ThongKeBUS();
            tkBUS.ThemHoatDong(tkDTO);
            FilGVDanhSachHoatDong();
        }
    }
}
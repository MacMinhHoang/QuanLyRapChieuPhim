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
    public partial class QuanLyLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDSLuong();
            }
        }

        private void FillDSLuong()
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            List<NhanVienDTO> listNV = nhanVienBUS.LayDanhSach();
            gvDSLuong.DataSource = listNV;
            gvDSLuong.DataBind();
        }

        protected void gvDSLuong_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDSLuong.EditIndex = e.NewEditIndex;
        }

        protected void gvDSLuong_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            GridViewRow row = (GridViewRow)gvDSLuong.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            String txt = (row.Cells[1].Controls[0] as TextBox).Text;
            float luong = Convert.ToInt64(txt);
            NhanVienDTO nhanVienDTO = nhanVienBUS.LayThongTin(id);
            nhanVienDTO.Luong = luong;
            nhanVienBUS.SuaThongTin(nhanVienDTO);
            gvDSLuong.EditIndex = -1;
            FillDSLuong();
        }

        protected void gvDSLuong_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDSLuong.EditIndex = -1;
        }    
    }
}
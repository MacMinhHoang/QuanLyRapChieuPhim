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
    public partial class QuanLyLichLamViec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NhanVienBUS nhanVienBUS = new NhanVienBUS();
                List<NhanVienDTO> listNV = nhanVienBUS.LayDanhSach();
                gvDSLLV.DataSource = listNV;
                gvDSLLV.DataBind();

                CheckBox cb;
                String lichLamViec;
                for (int i = 0; i < listNV.Count; i++)
                {
                    lichLamViec = listNV[i].LichLamViec;
                    for (int j = 2; j < 9; j++)
                    {
                        cb = (CheckBox)gvDSLLV.Rows[i].FindControl("CheckBox" + j);
                        cb.Checked = lichLamViec.Contains(j.ToString());
                    }
                }
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            GridViewRow row = (GridViewRow)checkBox.Parent.Parent;
            CheckBox cb;
            String lichMoi = "";
            for (int i = 2; i < 9; i++)
            {
                cb = (CheckBox)row.FindControl("CheckBox" + i);
                if (cb.Checked)
                    lichMoi += i.ToString();
            }

            int id = Convert.ToInt32(row.Cells[0].Text);
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            NhanVienDTO nv = nhanVienBUS.LayThongTin(id);
            nv.LichLamViec = lichMoi;
            nhanVienBUS.SuaThongTin(nv);
        }
    }
}
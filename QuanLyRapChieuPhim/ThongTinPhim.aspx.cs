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
    public class ListPhim
    {
        public static List<PhimDTO> val;
        public static int len = 0;
        public static int index = 0;
        public static bool isSearchName;
        public static bool isError = false;
    }

    public partial class ThongTinPhim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PhimBUS phimBUS = new PhimBUS();

            ListPhim listPhim = new ListPhim();

            ListPhim.isSearchName = (bool)Session["isSearchName"];
            if (ListPhim.isSearchName)
            {
                if (phimBUS.TimKiemTheoTen(Session["TenPhim"].ToString()) == null)
                    ListPhim.isError = true;
                else ListPhim.val = phimBUS.TimKiemTheoTen(Session["TenPhim"].ToString());
                lbl_error.Text = "Không tìm thấy tên phim bạn nhập";
            }
            else
            {
                if (phimBUS.TimKiemTheoTheLoai(Session["TheLoai"].ToString()) == null)
                    ListPhim.isError = true;
                else ListPhim.val = phimBUS.TimKiemTheoTheLoai(Session["TheLoai"].ToString());
                lbl_error.Text = "Không tìm thấy phim nào thuộc thể loại " + Session["TheLoai"].ToString();
            }
            if (ListPhim.isError)
            {
                //Lỗi không tìm thấy phim yêu cầu
                //Session["TenPhim"] = null;
                lbl_error.Visible = true;
                img_Phim.Visible = false;
                btn_DatVe.Visible = false;
                btn_Trailer.Visible = false;
                lbl_NoiDung.Visible = false;

                lbl_Tenphim.Visible = false;
                lbl_Theloai.Visible = false;
                lbl_NamSX.Visible = false;
                lbl_Daodien.Visible = false;
                lbl_Dienvien.Visible = false;
                lbl_Dotuoi.Visible = false;
                lbl_TheloaiTD.Visible = false;
                lbl_NamSXTD.Visible = false;
                lbl_DaodienTD.Visible = false;
                lbl_DienvienTD.Visible = false;
                lbl_DotuoiTD.Visible = false;
            }
            else
            {
                lbl_error.Visible = false;
                img_Phim.Visible = true;
                btn_DatVe.Visible = true;
                btn_Trailer.Visible = true;
                lbl_NoiDung.Visible = true;

                lbl_Theloai.Visible = true;
                lbl_NamSX.Visible = true;
                lbl_Daodien.Visible = true;
                lbl_Dienvien.Visible = true;
                lbl_Dotuoi.Visible = true;
                lbl_TheloaiTD.Visible = true;
                lbl_NamSXTD.Visible = true;
                lbl_DaodienTD.Visible = true;
                lbl_DienvienTD.Visible = true;
                lbl_DotuoiTD.Visible = true;

                ListPhim.len = ListPhim.val.Count;
                if (ListPhim.index == ListPhim.len - 1 || ListPhim.len == 1)
                {
                    lnk_back.Visible = true;
                    lnk_forward.Visible = false;
                }
                else
                {
                    lnk_back.Visible = true;
                    lnk_forward.Visible = true;
                }
                img_Phim.ImageUrl = ListPhim.val[ListPhim.index].Poster;
                img_Phim.DataBind();
                lbl_NoiDung.Text = ListPhim.val[ListPhim.index].NoiDung;
                lbl_Tenphim.Text = ListPhim.val[ListPhim.index].TenPhim;
                lbl_Theloai.Text = ListPhim.val[ListPhim.index].TheLoai;
                lbl_NamSX.Text = ListPhim.val[ListPhim.index].NamSanXuat.ToString();
                lbl_Daodien.Text = ListPhim.val[ListPhim.index].DaoDien;
                lbl_Dienvien.Text = ListPhim.val[ListPhim.index].DienVien;
                lbl_Dotuoi.Text = ListPhim.val[ListPhim.index].GioiHanDoTuoi;
            }
        }

        protected void btn_DatVe_Click(object sender, EventArgs e)
        {
            if (Session["TenDangNhap"] == null)
                Response.Redirect("DangNhap.aspx");
            
            Session["TenPhim"] = ListPhim.val[ListPhim.index].TenPhim;
            Response.Redirect("DatVe.aspx");
        }

        protected void lnk_back_Click(object sender, EventArgs e)
        {
            if (ListPhim.index == 0)
            {
                Session["TenPhim"] = null;
                Session["isSearchName"] = null;
                Session["TheLoai"] = null;
                ListPhim.val.Clear();
                ListPhim.len = 0;
                ListPhim.isError = false;
                ListPhim.index = 0;
                Response.Redirect("PhimDangChieu.aspx");
    }
            else
            {
                ListPhim.index--;
                Response.Redirect("ThongTinPhim.aspx");
            }
        }

        protected void lnk_forward_Click(object sender, EventArgs e)
        {
            ListPhim.index++;
            Response.Redirect("ThongTinPhim.aspx");
        }

        protected void btn_Trailer_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(
                this.GetType(), "OpenWindow", "window.open('" + ListPhim.val[ListPhim.index].Trailer + "', '_newtab');", true);
            //Response.Redirect(ListPhim.val[ListPhim.index].Trailer);
        }
    }
}

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
    public partial class ThongTinPhim : System.Web.UI.Page
    {
        private static List<PhimDTO> listResults = new List<PhimDTO>();
        private static int countResults = 0;
        private static int curResult = 0;
        private static bool byName;
        private static bool isError = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            PhimBUS phimBUS = new PhimBUS();

            String search = Request.QueryString["search"].ToString();
            if (search == "false")
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                listResults.Clear();
                listResults.Add(phimBUS.LayThongTin(id));
            }
            else
            {
                String str;
                if (search == "name")
                {
                    string name = Request.QueryString["name"];
                    List<PhimDTO> result = phimBUS.TimKiemTheoTen(name);
                    if (result == null || result.Count == 0)
                        isError = true;
                    else listResults = result;
                    lbl_error.Text = "Không tìm thấy kết quả cho : " + name;
                    byName = true;
                }
                else
                {
                    int type = Convert.ToInt32(Request.QueryString["type"]);
                    switch(type)
                    {
                        case 0:
                            str = "Hành động";
                            break;
                        case 1:
                            str = "Viễn tưởng";
                            break;
                        case 2:
                            str = "Lãng mạn";
                            break;
                        case 3:
                            str = "Tâm lý";
                            break;
                        case 4:
                            str = "Kinh dị";
                            break;
                        default:
                            str = "Hoạt hình";
                            break;
                    }
                    List<PhimDTO> result = phimBUS.TimKiemTheoTheLoai(str);
                    if (result == null || result.Count == 0)
                        isError = true;
                    else listResults = result;
                    lbl_error.Text = "Không tìm thấy phim nào thuộc thể loại " + str;
                    byName = false;
                }
            }

            if (isError)
            {
                //Lỗi không tìm thấy phim yêu cầu
                //Session["TenPhim"] = null;
                lbl_error.Visible = true;
                img_Phim.Visible = btn_DatVe.Visible = btn_Trailer.Visible = lbl_NoiDung.Visible = false;

                lbl_Tenphim.Visible = lbl_Theloai.Visible = lbl_NamSX.Visible = lbl_Daodien.Visible = false;
                lbl_Dienvien.Visible = lbl_Dotuoi.Visible = lbl_TheloaiTD.Visible = lbl_NamSXTD.Visible = false;
                lbl_DaodienTD.Visible = lbl_DienvienTD.Visible = lbl_DotuoiTD.Visible = false;

                lnk_back.Visible = lnk_forward.Visible = false;
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

                countResults = listResults.Count;
                if (curResult == countResults - 1 || countResults == 1)
                {
                    lnk_back.Visible = true;
                    lnk_forward.Visible = false;
                }
                else
                {
                    lnk_back.Visible = true;
                    lnk_forward.Visible = true;
                }
                img_Phim.ImageUrl = listResults[curResult].Poster;
                img_Phim.DataBind();
                lbl_NoiDung.Text = listResults[curResult].NoiDung;
                lbl_Tenphim.Text = listResults[curResult].Ten;
                lbl_Theloai.Text = listResults[curResult].TheLoai;
                lbl_NamSX.Text = listResults[curResult].NamSanXuat.ToString();
                lbl_Daodien.Text = listResults[curResult].DaoDien;
                lbl_Dienvien.Text = listResults[curResult].DienVien;
                lbl_Dotuoi.Text = listResults[curResult].GioiHanDoTuoi.ToString();
            }
        }

        protected void btn_DatVe_Click(object sender, EventArgs e)
        {
            if (Session["TenDangNhap"] == null)
            {
                string strBuilder = "<script language='javascript'>alert('" + "Bạn phải đăng nhập để thực hiện chức năng này." + "')</script>";
                Response.Write(strBuilder);
                Server.Transfer("DangNhap.aspx");
            }            
            Response.Redirect("DatVe.aspx?id=" + listResults[curResult].MaPhim.ToString());
        }

        protected void lnk_back_Click(object sender, EventArgs e)
        {
            if (curResult == 0)
            {
                //Session["TenPhim"] = null;
                //Session["isSearchName"] = null;
                //Session["TheLoai"] = null;
                listResults.Clear();
                countResults = 0;
                isError = false;
                curResult = 0;
                Response.Redirect("PhimDangChieu.aspx");
    }
            else
            {
                curResult--;
                if (byName)
                    Response.Redirect("ThongTinPhim.aspx?search=name&name=" + Request.QueryString["name"]);
                else Response.Redirect("ThongTinPhim.aspx?search=type&type=" + Request.QueryString["type"]);
            }
        }

        protected void lnk_forward_Click(object sender, EventArgs e)
        {
            curResult++;
            if (byName)
                Response.Redirect("ThongTinPhim.aspx?search=name&name=" + Request.QueryString["name"]);
            else Response.Redirect("ThongTinPhim.aspx?search=type&type=" + Request.QueryString["type"]);
        }

        protected void btn_Trailer_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(
                this.GetType(), "OpenWindow", "window.open('" + listResults[curResult].Trailer + "', '_newtab');", true);
        }
    }
}

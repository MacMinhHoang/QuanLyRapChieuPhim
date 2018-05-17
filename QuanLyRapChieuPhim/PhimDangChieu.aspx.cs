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
    public partial class PhimDangChieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PhimBUS phimBUS = new PhimBUS();
            List<PhimDTO> listPhim = phimBUS.LayDanhSach();
            Image image;
            LinkButton linkButton;
            for (int i = 0; i < listPhim.Count; i++)
            {
                image = new Image();
                image.ImageUrl = listPhim[i].Poster;

                linkButton = new LinkButton();
                linkButton.Text = listPhim[i].Ten;
                int maphim = listPhim[i].MaPhim;
                linkButton.Click += (s, ev) =>
                {
                    Response.Redirect("ThongTinPhim.aspx?search=false&id=" + maphim.ToString());
                };
                
                
                if (i % 2 == 0)
                {
                    Panel3.Controls.Add(image);
                    Panel3.Controls.Add(new LiteralControl("<br />"));
                    Panel3.Controls.Add(linkButton);
                    Panel3.Controls.Add(new LiteralControl("<br /><br />"));
                }
                else
                {
                    Panel2.Controls.Add(image);
                    Panel2.Controls.Add(new LiteralControl("<br />"));
                    Panel2.Controls.Add(linkButton);
                    Panel2.Controls.Add(new LiteralControl("<br /><br />"));
                }
            }
        }

        //private void LinkButton_Click(object sender, EventArgs e)
        //{
        //    LinkButton lnk = sender as LinkButton;
        //    Session["TenPhim"] = lnk.Text;
        //    Session["isSearchName"] = true;
        //    Response.Redirect("ThongTinPhim.aspx");
        //}

        //protected void BT_Login_Click(object sender, EventArgs e)
        //{
            
        //}

        protected void btn_search_name_Click(object sender, ImageClickEventArgs e)
        {
            if (txt_name.Text == "")
            {
                string strBuilder = "<script language='javascript'>alert('" + "Hãy nhập tên phim" + "')</script>";
                Response.Write(strBuilder);
            }
            else
            {
                //Session["TenPhim"] = txt_name.Text;
                //Session["isSearchName"] = true;
                Response.Redirect("ThongTinPhim.aspx?search=name&name=" + txt_name.Text);
            }
        }

        protected void btn_search_category_Click(object sender, ImageClickEventArgs e)
        {
            //Session["TheLoai"] = DropDownList1.SelectedItem.Text;
            //Session["isSearchName"] = false;
            Response.Redirect("ThongTinPhim.aspx?search=type&type=" + DropDownList1.SelectedItem.Value);
        }
    }
}
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace QuanLyRapChieuPhim
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PhimBUS phimBUS = new PhimBUS();
            List<PhimDTO> top3 = phimBUS.LayTop3();
            HyperLink link = new HyperLink();
            link.Style.Add("text-align", "center");
            link.Style.Add("color", "orange");
            link.Style.Add("Font-Size", "Large");
            link.Text = top3[0].Ten;
            link.NavigateUrl = "ThongTinPhim.aspx?search=false&id=" + top3[0].MaPhim.ToString();
            Image img = new Image();
            img.ImageUrl = top3[0].Poster;
            MyPanel1.Controls.Add(link);
            MyPanel1.Controls.Add(img);

            link = new HyperLink();
            link.Style.Add("text-align", "center");
            link.Style.Add("color", "orange");
            link.Style.Add("Font-Size", "Large");
            link.Text = top3[1].Ten;
            link.NavigateUrl = "ThongTinPhim.aspx?search=false&id=" + top3[1].MaPhim.ToString();
            img = new Image();
            img.ImageUrl = top3[1].Poster;
            MyPanel2.Controls.Add(link);
            MyPanel2.Controls.Add(img);

            link = new HyperLink();
            link.Style.Add("text-align", "center");
            link.Style.Add("color", "orange");
            link.Style.Add("Font-Size", "Large");
            link.Text = top3[2].Ten;
            link.NavigateUrl = "ThongTinPhim.aspx?search=false&id=" + top3[2].MaPhim.ToString();
            img = new Image();
            img.ImageUrl = top3[2].Poster;
            MyPanel3.Controls.Add(link);
            MyPanel3.Controls.Add(img);
        }
    }
}
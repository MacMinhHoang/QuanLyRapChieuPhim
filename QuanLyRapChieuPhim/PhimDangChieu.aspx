<%@ Page Title="Phim Đang Chiếu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhimDangChieu.aspx.cs" Inherits="QuanLyRapChieuPhim.PhimDangChieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" DefaultButton="btn_search_name" BackColor="White" runat="server">
        <br><br>
        <h1 style="font-size:xx-large; text-align:center"><strong>TÌM KIẾM PHIM</strong></h1>
        <p style="text-align:left; padding:2cm; font-family:'Segoe UI'; font-size:x-large">
            <strong>Theo tên</strong>:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txt_name" runat="server" Width="238px" Height="28px" BorderStyle="Solid"></asp:TextBox>
            &nbsp;
            <asp:ImageButton ID="btn_search_name" ImageUrl="./Images/icon_search.png" Onclick="btn_search_name_Click" runat="server" Height="36px" Width="41px" />
            <br><br>
            <strong>Theo thể loại</strong>:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="34px" Width="158px" BackColor="#99CCFF">
                <asp:ListItem Value="0">Hành động</asp:ListItem>
                <asp:ListItem Value="1">Viễn tưởng</asp:ListItem>
                <asp:ListItem Value="2">Lãng mạn</asp:ListItem>
                <asp:ListItem Value="3">Tâm lý</asp:ListItem>
                <asp:ListItem Value="4">Kinh dị</asp:ListItem>
                <asp:ListItem Value="5">Hoạt hình</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="btn_search_category"  ImageUrl="./Images/icon_search.png" Onclick="btn_search_category_Click" runat="server" Height="36px" Width="41px" />
            &nbsp;&nbsp;&nbsp;
        </p>
    </asp:Panel>
    <hr />
    
    <h1 style="font-size:xx-large; font-family:'Segoe UI'; color:chocolate; text-align:center"><strong>ĐANG CHIẾU</strong></h1>
    <div class="row" style="text-align:center; font-size:larger">
        <div class="col-md-6">
            <asp:Panel ID="Panel2" runat="server"></asp:Panel>
        </div>
        
        <div class="col-md-6">
            <asp:Panel ID="Panel3" runat="server"></asp:Panel>
        </div>
    </div>
</asp:Content>

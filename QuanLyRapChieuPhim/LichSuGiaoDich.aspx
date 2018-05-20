<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LichSuGiaoDich.aspx.cs" Inherits="QuanLyRapChieuPhim.LichSuGiaoDich" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
   
    <div>
        <asp:GridView ID="gvDSVe" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
        <Columns>
            <asp:BoundField DataField="MaVe" HeaderText="Mã Vé" />
            <asp:BoundField DataField="Ten" HeaderText="Tên Phim" />
            <asp:BoundField DataField="NgayChieu" HeaderText="Ngày Chiếu" />
            <asp:BoundField DataField="GioChieu" HeaderText="Giờ Chiếu" />
            <asp:BoundField DataField="Ghe" HeaderText="Ghế" />
            <asp:BoundField DataField="GiaVe" HeaderText="Giá Vé" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>

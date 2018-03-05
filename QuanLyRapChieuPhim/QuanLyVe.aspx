<%@ Page Title="Quản Lý Vé" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyVe.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyVe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <asp:GridView ID="gvDanhSachVe" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
             
        <Columns>
            <asp:BoundField DataField="MaKhachHang" HeaderText="Mã Khách Hàng" />
            <asp:BoundField DataField="MaVe" HeaderText="Mã Vé" />
            <asp:BoundField DataField="TenPhim" HeaderText="Tên Phim" />
            <asp:BoundField DataField="NgayChieu" HeaderText="Ngày Chiếu" />
            <asp:BoundField DataField="MaPhongChieu" HeaderText="Mã Phòng Chiếu" />
            <asp:BoundField DataField="ViTriNgoi" HeaderText="Vị Trí Ngồi" />
            <asp:BoundField DataField="Gia" HeaderText="Giá" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>

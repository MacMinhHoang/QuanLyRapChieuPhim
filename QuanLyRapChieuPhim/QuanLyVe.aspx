<%@ Page Title="Quản Lý Vé" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyVe.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyVe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <asp:GridView ID="gvDanhSachVe" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
             
        <Columns>
            <asp:BoundField DataField="MaVe" HeaderText="Mã Vé" />
            <asp:BoundField DataField="MaKhachHang" HeaderText="Mã Khách Hàng" />
            <asp:BoundField DataField="MaSuatChieu" HeaderText="Mã Suất Chiếu" />
            <asp:BoundField DataField="Ghe" HeaderText="Ghế" />
            <asp:BoundField DataField="LoaiVe" HeaderText="Loại Vé" />
            <asp:BoundField DataField="GiaVe" HeaderText="Giá Vé" />
            <asp:BoundField DataField="ThanhToan" HeaderText="Hình Thức Thanh Toán" />
            <asp:BoundField DataField="TinhTrang" HeaderText="Tình Trạng Sử Dụng" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>

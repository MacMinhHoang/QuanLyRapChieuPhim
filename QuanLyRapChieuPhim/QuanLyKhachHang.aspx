<%@ Page Title="Quản Lý Khách Hàng" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyKhachHang.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyKhachHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
   
    <div>
        <asp:GridView ID="gvDanhSachKhachHang" OnRowDeleting="gvDanhSachKhachHang_RowDeleting" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
        <Columns>
            <asp:BoundField DataField="MaKhachHang" HeaderText="Mã Khách Hàng" />
            <asp:BoundField DataField="TenKhachHang" HeaderText="Tên Khách Hàng" />
            <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh" />
            <asp:BoundField DataField="GioiTinh" HeaderText="Giới Tính" />
            <asp:BoundField DataField="CMND" HeaderText="CMND" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />
            <asp:BoundField DataField="SoDienThoai" HeaderText="SĐT" />
            <asp:BoundField DataField="TenDangNhap" HeaderText="Tên Đăng Nhập" />
            <asp:CommandField ButtonType="Image" ShowDeleteButton="True" DeleteImageUrl="Images/icon_delete.png" DeleteText="" ShowCancelButton="False" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>

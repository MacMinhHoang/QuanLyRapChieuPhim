<%@ Page Title="Quản lý Tài Khoản" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyTaiKhoan.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyTaiKhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <asp:GridView ID="gvDanhSachTaiKhoan" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
             
        <Columns>
            <asp:BoundField DataField="TenDangNhap" HeaderText="Tên đăng nhập" />
            <asp:BoundField DataField="MatKhau" HeaderText="Mật khẩu" />
            <asp:BoundField DataField="ChucNang" HeaderText="Loại người dùng" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>

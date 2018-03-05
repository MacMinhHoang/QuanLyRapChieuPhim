<%@ Page Title="Quản Lý Admin" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyAdmin.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <asp:GridView ID="gvDanhSachAdmin" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
             
        <Columns>
            <asp:BoundField DataField="AdminID" HeaderText="Mã" />
            <asp:BoundField DataField="TenDangNhap" HeaderText="ID" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" />
            <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh" />
            <asp:BoundField DataField="GioiTinh" HeaderText="Giới Tính" />
            <asp:BoundField DataField="CMND" HeaderText="CMND" />
            <asp:BoundField DataField="SoDienThoai" HeaderText="SĐT" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>

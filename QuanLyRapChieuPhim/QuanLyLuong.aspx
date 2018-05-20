<%@ Page Title="" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyLuong.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyLuong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />
    <center>
    <asp:GridView ID="gvDSLuong" runat="server" AutoGenerateColumns="False" Width="550px" OnRowCancelingEdit="gvDSLuong_RowCancelingEdit" OnRowEditing="gvDSLuong_RowEditing" OnRowUpdating="gvDSLuong_RowUpdating">
        <Columns>
            <asp:BoundField DataField="MaNhanVien" HeaderText="Mã Nhân VIên" ReadOnly="True" />
            <asp:BoundField DataField="Luong" HeaderText="Lương" />
            <asp:CommandField ShowEditButton="True" />
        </Columns>

    </asp:GridView>
    </center>
</asp:Content>

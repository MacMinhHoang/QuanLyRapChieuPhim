<%@ Page Title="Đăng Nhập" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="QuanLyRapChieuPhim.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href='https://fonts.googleapis.com/css?family=Ubuntu:500' rel='stylesheet' type='text/css'>
    <link href="Content/LogIn.css" rel="stylesheet" />
    <link href="Content/ButtonHover.css" rel="stylesheet" />

    
    <div class="login" runat="server">
        <div class="login-header">
            <br>
            <h1 style="color:white"><strong>DÀNH CHO KHÁCH HÀNG</strong></h1>
        </div>
        <div class="login-form">
            <asp:Panel ID="Panel1" DefaultButton="btn_LoginKH" runat="server">
                <h3 style="color: darkcyan"><strong>Tên đăng nhập:</strong></h3>
                <asp:TextBox ID="tb_KHUsername" runat="server"></asp:TextBox>
                <h3 style="color: darkcyan"><strong>Mật khẩu:</strong></h3>
                <asp:TextBox ID="tb_KHPassword" TextMode="password" runat="server"> </asp:TextBox>
                <br>
                <br>
                <asp:ImageButton ID="btn_LoginKH" ImageUrl="./Images/icon_login.png" OnClick="btn_LoginKH_Click" runat="server" />
                <br>
                
                <br>
                <a class="sign-up" href="DangKy.aspx" runat="server" >Đăng Ký!</a>
                <br>
                <asp:Label ID="ErrorMessage1" runat="server" Font-Size="Large"></asp:Label>
            </asp:Panel>
        </div>
    </div>
    <hr />
    <br>
    
    <div class="login">
        <div class="login-header">
            <br>
            <h1 style="color:white"><strong>DÀNH CHO NHÂN VIÊN</strong></h1>
        </div>
        <div class="login-form">
            <asp:Panel ID="Panel2" DefaultButton="btn_LoginNV" runat="server">
                <h3 style="color: darkcyan"><strong>Tên đăng nhập:</strong></h3>
                <asp:TextBox ID="tb_NVUsername" runat="server"></asp:TextBox>
                <h3 style="color: darkcyan"><strong>Mật khẩu:</strong></h3>
                <asp:TextBox ID="tb_NVPassword" TextMode="password" runat="server"> </asp:TextBox>
                <br>
                <br>
                <asp:ImageButton ID="btn_LoginNV" ImageUrl="./Images/icon_login.png" OnClick="btn_LoginNV_Click" runat="server" />
                <br>
                <br>
                <asp:Label ID="ErrorMessage2" runat="server" Font-Size="Large"></asp:Label>
            </asp:Panel>
        </div>
    </div>
</asp:Content>




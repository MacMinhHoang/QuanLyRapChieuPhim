<%@ Page Title="Đăng Ký" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="QuanLyRapChieuPhim.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/DangKy.css" rel="stylesheet" />
    
    
    <br>
    <div id="login-box">
        <div class="top" style="left: 0px; top: 3px">
            <h1>Đăng ký</h1>
        </div>

        <div class="center" style="left: 0px; top: 95px; height: 350px;">
            <div class="left" style="left: 0px; top: -28px">
                <input id="fullname" type="text" name="fullname" placeholder="Họ tên" value="" />
                <input id="birthday" type="text" name="birthday" placeholder="Ngày sinh" value="" />
                <input id="sex" type="text" name="sex" placeholder="Giới tính (Nam/Nữ)" value="" />
                <input id="cmnd" type="text" name="cmnd" placeholder="CMND" value="" />
                <input id="address" type="text" name="address" placeholder="Địa chỉ" value="" />
            </div>

            <div class="right" style="right: 0px; top: -28px">
                <input id="phone" type="text" name="phone" placeholder="Số điện thoại" value="" />
                <input id="email" type="text" name="email" placeholder="E-mail" value="" />
                <input id="username" type="text" name="username" placeholder="Tên đăng nhập" value="" />
                <input id="password" type="password" name="password" placeholder="Mật khẩu" value="" />
            </div>
        </div>
        
        <div class="bottom" style="left: 0px; bottom: 0px">
            <input id="btnGui" type="submit" name="signup_submit" value="Gửi" runat="server" onclick="__doPostBack('btnGui', 'submit');"/>
        </div>
    </div>
    
</asp:Content>

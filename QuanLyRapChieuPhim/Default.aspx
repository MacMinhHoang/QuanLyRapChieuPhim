<%@ Page Title="Trang Chủ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuanLyRapChieuPhim._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1 style="color:darkorange; font-family:Arial; font-size: 60px; text-align:center ">
        <strong>MIGOS</strong> <img src="./Images/cinema.jpg" width="400" height="160" >
    </h1>
    <div class="row">
        <div class="col-md-3"></div>
        <div class="col-md-3">
            <iframe width="640" height="360" src="https://www.youtube.com/embed/ue80QwXMRHg" frameborder="0" gesture="media" allowfullscreen="true"></iframe>
        </div>
    </div>
    <h2 style="color:darkred"><strong>PHIM HOT</strong></h2>
    <div class="row">
        <div class="col-md-4">
            <h3 style="text-align:center; color:orange">Black Panther</h3>
            <a href="https://www.youtube.com/watch?v=xjDjIWPwcPU">
                <img src ="./Images/black-panther.jpg" width="400">
            </a>
        </div>
        <div class="col-md-4">
            <h3 style="text-align:center; color:orange">Justice League</h3>
            <a href="https://www.youtube.com/watch?v=r9-DM9uBtVI">
                <img src ="./Images/Justice-League-banner.jpg" width="400">
            </a>
        </div>
        <div class="col-md-4">
            <h3 style="text-align:center; color:orange">Insidious: The Last Key</h3>
            <a href="https://www.youtube.com/watch?v=acQyrwQyCOk&pbjreload=10">
                <img src ="./Images/insidous.jpg" width="400">
            </a>
        </div>
    </div>

</asp:Content>

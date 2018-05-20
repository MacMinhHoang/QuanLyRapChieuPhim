<%@ Page Title="Trang Chủ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuanLyRapChieuPhim._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1 style="color:darkorange; font-family:Arial; font-size: 60px; text-align:center ">
        <strong>MIGOS</strong> <img src="./Images/cinema.jpg" width="400" height="160" >
    </h1>
    <div class="row">
        <div class="col-md-3"></div>
        <div class="col-md-3">
            <iframe width="640" height="360" src="https://www.youtube.com/embed/D86RtevtfrA" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
        </div>
    </div>
    <h2 style="color:darkred"><strong>PHIM HOT</strong></h2>
    <div class="row" style="text-align:center">
        <div class="col-md-4">
            <asp:Panel ID="MyPanel1" runat="server"></asp:Panel>
        </div>
        <div class="col-md-4">
            <asp:Panel ID="MyPanel2" runat="server"></asp:Panel>
        </div>
        <div class="col-md-4">
            <asp:Panel ID="MyPanel3" runat="server"></asp:Panel>
        </div>
    </div>

</asp:Content>

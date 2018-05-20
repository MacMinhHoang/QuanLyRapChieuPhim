<%@ Page Title="Đặt Vé" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatVe.aspx.cs" Inherits="QuanLyRapChieuPhim.DatVe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/CheckBoxList.css" rel="stylesheet" />

    <h1 style="color:darkorange; font-family:'Segoe UI'; font-size: 60px; text-align:center ">
        LỊCH CHIẾU
        <br /><br />
        <asp:Label ID="lbl_name" Font-Bold="true" runat="server"></asp:Label>
    </h1>

    <asp:Panel ID="Panel1" BackColor="White" ForeColor="Black" Font-Size="XX-Large" Font-Bold="true" Font-Names="Segoe UI" runat="server">
    <div class="row">
        <div class="col-md-4">
            <p style="text-align:center; color:orangered">
                CHỌN NGÀY
                <br /><br />
                <asp:RadioButtonList ID="rdl_ngaychieu" AutoPostBack="true" 
                    OnSelectedIndexChanged="rdl_ngaychieu_SelectedIndexChanged" runat="server"></asp:RadioButtonList>
            </p>
        </div>
        <div class="col-md-4">
            <p style="text-align:center; color:orangered">
                CHỌN SUẤT CHIẾU
                <br /><br />
                <asp:RadioButtonList ID="rdl_suatchieu" AutoPostBack="true" 
                    OnSelectedIndexChanged="rdl_suatchieu_SelectedIndexChanged" runat="server"></asp:RadioButtonList>
            </p>
        </div>
        <div class="col-md-4">
            <p style="text-align:center; color:orangered">CHỌN GHẾ NGỒI</p>
            CHỌN DÃY<br />
            
            <asp:DropDownList ID="ddl_day" OnDataBound="ddl_day_DataBound" OnSelectedIndexChanged="ddl_day_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList><br />
            CHỌN SỐ GHẾ<br />
            <asp:DropDownList ID="ddl_soghe" runat="server" OnDataBound="ddl_soghe_DataBound" OnSelectedIndexChanged="ddl_soghe_SelectedIndexChanged"></asp:DropDownList><br /><br />
            
        </div>
    </div>

    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <p style="text-align:center; color:orangered">
                CHỌN HÌNH THỨC THANH TOÁN
                <br /><br />
                <asp:RadioButtonList ID="ddl_thanhtoan" AutoPostBack="true" 
                    OnSelectedIndexChanged="ddl_thanhtoan_SelectedIndexChanged" runat="server">
                    <asp:ListItem Text="Online" Value="0" Selected></asp:ListItem>
                    <asp:ListItem Text="Trực tiếp tại rạp" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="btn_DatVe" OnClick="btn_DatVe_Click" runat="server" Text="Đặt Vé" />
            </p>
        </div>
    </div>
    </asp:Panel>
</asp:Content>

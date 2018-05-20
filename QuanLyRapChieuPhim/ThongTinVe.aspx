<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThongTinVe.aspx.cs" Inherits="QuanLyRapChieuPhim.ThongTinVe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel BackColor="White" runat="server">
        <br><br>
        <h1 style="font-size:xx-large; text-align:center"><strong>VÉ CỦA BẠN</strong></h1>
        <br><br><br><br>
        <div class="row" style="font-size:larger; font-weight:bold; margin-left: 400px;">
            <div class="col-md-4">
                <asp:Label ID="VeID"        runat="server">Mã vé :      </asp:Label> <br /><br /><br />
                <asp:Label ID="Phim"        runat="server">Tên Phim :   </asp:Label> <br /><br /><br />
                <asp:Label ID="PhongChieu"  runat="server">Phòng Chiếu: </asp:Label> <br /><br /><br />
                <asp:Label ID="NgayChieu"   runat="server">Ngày Chiếu : </asp:Label> <br /><br /><br />
            </div>
            <div class="col-md-4">
                <asp:Label ID="SuatCHieu"   runat="server">Suất Chiếu : </asp:Label> <br /><br /><br />
                <asp:Label ID="SoGhe"       runat="server">Số Ghế :     </asp:Label> <br /><br /><br />
                <asp:Label ID="LoaiVe"      runat="server">Loại vé :    </asp:Label> <br /><br /><br />
                <asp:Label ID="GiaVe"       runat="server">Giá vé :     </asp:Label> <br /><br /><br />
            </div>
        </div>
    </asp:Panel>

</asp:Content>

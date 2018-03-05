<%@ Page Title="Thông Tin Phim" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThongTinPhim.aspx.cs" Inherits="QuanLyRapChieuPhim.ThongTinPhim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:LinkButton ID="lnk_back" OnClick="lnk_back_Click" runat="server">QUAY LẠI</asp:LinkButton>
    &nbsp; |&nbsp;
    <asp:LinkButton ID="lnk_forward" OnClick="lnk_forward_Click" runat="server">TIẾP TỤC</asp:LinkButton><br />

    <br />
    <p style="color: white; font-size:x-large;text-align: center">
    <asp:Label ID="lbl_error" runat="server"></asp:Label>
    </p>
    <div class="row">
        <div class="col-md-5">
            <asp:Image  ID="img_Phim"  runat="server" /><br />
        </div>
        
        <div class="col-md-7" >
        <p style ="color: white; font-size:xx-large; font-weight: bolder;font-family:Verdana">
            <asp:Label ID="lbl_Tenphim" ForeColor="#ffcc00" runat="server"></asp:Label><br/>
        </p>
        <hr /> 
          
        <div>
            
            <p style ="color: white; font-family: Verdana; font-size:larger">
                
                <asp:Label ID="lbl_TheloaiTD" runat="server" Text="THỂ LOẠI: "></asp:Label>
                
                <asp:Label ID="lbl_Theloai" runat="server"> </asp:Label>
                <br/>  
            
                <asp:Label ID="lbl_DaodienTD" runat="server" Text="ĐẠO DIỄN: "></asp:Label>
            
                <asp:Label ID="lbl_Daodien" runat="server"> </asp:Label>
                <br/>  
             
                <asp:Label ID="lbl_DienvienTD" runat="server" Text="DIỄN VIÊN: "></asp:Label>
             
                <asp:Label ID="lbl_Dienvien" runat="server" ></asp:Label>
                <br/>  
            
                <asp:Label ID="lbl_DotuoiTD" runat="server" Text="ĐỘ TUỔI XEM PHIM: "></asp:Label>
            
                <asp:Label ID="lbl_Dotuoi" runat="server" ></asp:Label>
                <br/>  
            
                <asp:Label ID="lbl_NamSXTD" runat="server" Text="NĂM SẢN XUẤT: "></asp:Label>
            
                <asp:Label ID="lbl_NamSX" runat="server" ></asp:Label>
            </p>
        </div>
        <p style ="color: white; font-size:large">
        <br/><asp:Label ID="lbl_NoiDung" runat="server"></asp:Label>
        </p>
     </div>
    </div>
    <div class="row">
   <div class="col-md-5" style="text-align:center">
            
        <asp:Button ID="btn_DatVe" OnClick="btn_DatVe_Click" runat="server" Font-Bold="true" Text="Đặt Vé" BackColor="#9900CC" BorderColor="#9900CC" BorderStyle="Groove" Font-Names="Verdana" ForeColor="White" Height="46px" Width="89px" />
        <asp:Button ID="btn_Trailer" OnClick="btn_Trailer_Click" runat="server" Font-Bold="true" Text="Trailer" BackColor="#9900CC" BorderColor="#9900CC" BorderStyle="Groove" Font-Names="Verdana" ForeColor="White" Height="47px" Width="88px" />
         
   </div>
        </div>
       
</asp:Content>

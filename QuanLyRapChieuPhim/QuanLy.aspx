<%@ Page Title="Quản Lý" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLy.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLy" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <asp:Panel ID="Panel1" DefaultButton="btn_Sua" runat="server">
    <div>
        <center style="text-align: left; font-family:'Segoe UI'; font-size:larger">
            <table align="left" cellspacing="0" style="width: 1150px; margin-bottom: 0px;">
                <tr>
                    <td colspan="6" style="text-align: center; font-size: xx-large;">
                        Xin chào quản lý 
                        <asp:label runat="server" Font-Bold="true" ForeColor="Orange" ID="lb_TenDangNhap"></asp:label>
                        <br />
                        <br />
                        <span style="text-decoration: underline"><strong>THÔNG TIN CÁ NHÂN<br />
                        </strong></span>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 131px; height: 41px"></td>
                    <td style="width: 141px; height: 41px"><strong>ID :</strong></td>
                    <td style="width: 312px; height: 41px">
                        <asp:Label ID="lb_ID" runat="server"></asp:Label>
                    </td>
                    <td style="height: 41px; width: 116px">&nbsp;</td>
                    <td style="height: 41px; width: 187px"></td>
                    <td style="height: 41px"></td>
                </tr>
                <tr>
                    <td style="height: 24px; width: 131px"></td>
                    <td style="height: 24px; width: 141px">
                        &nbsp;</td>
                    <td style="height: 24px; width: 312px">
                        &nbsp;</td>
                    <td style="height: 24px; width: 116px"></td>
                    <td style="height: 24px; width: 187px"></td>
                    <td style="height: 24px"></td>
                </tr>
                <tr>
                    <td style="width: 131px; height: 41px"></td>
                    <td style="height: 41px; width: 141px"><strong>Họ Tên :</strong></td>
                    <td style="width: 312px; height: 41px">
                        <asp:TextBox ID="tb_HoTen" runat="server" Height="35px" Width="242px"></asp:TextBox>
                    </td>
                    <td style="height: 41px; width: 116px"><strong>Ngày Sinh :</strong></td>
                    <td style="height: 41px; width: 187px">
                        <asp:TextBox ID="tb_NgaySinh" runat="server" Height="35px" TabIndex="1" Width="242px"></asp:TextBox>
                    </td>
                    <td style="height: 41px"></td>
                </tr>
                <tr>
                    <td style="width: 131px; height: 24px"></td>
                    <td style="height: 24px; width: 141px"></td>
                    <td style="width: 312px; height: 24px"></td>
                    <td style="height: 24px; width: 116px"></td>
                    <td style="height: 24px; width: 187px"></td>
                    <td style="height: 24px"></td>
                </tr>
                <tr>
                    <td style="height: 41px; width: 131px"></td>
                    <td style="height: 41px; width: 141px"><strong>Giới tính :</strong></td>
                    <td style="height: 41px; width: 312px">
                        <asp:TextBox ID="tb_GioiTinh" runat="server" Height="35px" TabIndex="2" Width="242px"></asp:TextBox>
                    </td>
                    <td style="height: 41px; width: 116px"><strong>Số điện thoại :</strong></td>
                    <td style="height: 41px; width: 187px">
                        <asp:TextBox ID="tb_SDT" runat="server" Height="35px" TabIndex="4" TextMode="Phone" Width="242px"></asp:TextBox>
                    </td>
                    <td style="height: 41px"></td>
                </tr>
                <tr>
                    <td style="width: 131px; height: 24px"></td>
                    <td style="height: 24px; width: 141px"></td>
                    <td style="width: 312px; height: 24px"></td>
                    <td style="height: 24px; width: 116px"></td>
                    <td style="height: 24px; width: 187px"></td>
                    <td style="height: 24px"></td>
                </tr>
                <%--<tr>
                    <td class="text-left" style="height: 41px; width: 131px;"></td>
                    <td class="text-left" style="height: 41px; width: 141px;">&nbsp;</td>
                    <td class="text-left" style="height: 41px; width: 312px;">
                        &nbsp;</td>
                    <td class="text-left" style="height: 41px; width: 116px;">&nbsp;</td>
                    <td class="text-left" style="height: 41px; width: 187px;">
                        &nbsp;</td>
                    <td class="text-left" style="height: 41px"></td>
                </tr>
                <tr>
                    <td class="text-left" style="height: 24px; width: 131px;">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 141px;">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 312px;">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 116px;">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 187px;">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                </tr>--%>
                <tr>
                    <td style="width: 131px; height: 24px"></td>
                    <td style="width: 141px; height: 24px"><strong>Địa chỉ&nbsp;:</strong></td>
                    <td style="width: 312px; height: 24px">
                        <asp:TextBox ID="tb_DiaChi" runat="server" Height="70px" TabIndex="6" TextMode="MultiLine" Width="235px"></asp:TextBox>
                    </td>
                    <td style="width: 116px; height: 24px"></td>
                    <td style="width: 187px; height: 24px"></td>
                    <td style="height: 24px"></td>
                </tr>
                <tr>
                    <td style="width: 131px; height: 45px"></td>
                    <td style="height: 45px; width: 141px"></td>
                    <td style="width: 312px; height: 45px"></td>
                    <td style="height: 45px; width: 116px"></td>
                    <td style="height: 45px; width: 187px"></td>
                    <td style="height: 45px"></td>
                </tr>
                <tr>
                    <td class="text-center" colspan="6" style="height: 24px; font-size: larger;">
                        <asp:Button ID="btn_Sua" runat="server" OnClick="btn_Sua_Click" Text="Hoàn tất" />
                    </td>
                </tr>
                <tr>
                    <td class="text-center" colspan="6" style="height: 8px; font-size: xx-large;">
                        <br />
                        <br />
                        <span style="text-decoration: underline"><strong>CHỨC NĂNG<br />
                        <br />
                        </strong></span></td>
                </tr>
                <tr>
                    <td class="text-center" colspan="6" style="height: 8px; font-size: larger;">
                        <br />
                        <asp:Button ID="Button3" runat="server" Height="53px" Text="Quản lý nhân viên" Width="200px" BorderStyle="Double" PostBackUrl="~/QuanLyNhanVien.aspx" BorderColor="Black" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button5" runat="server" BorderColor="Black" BorderStyle="Double" Height="53px" Text="Quản lý lịch làm việc" Width="200px" PostBackUrl="~/QuanLyLichLamViec.aspx" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </asp:Panel>
    
</asp:Content>

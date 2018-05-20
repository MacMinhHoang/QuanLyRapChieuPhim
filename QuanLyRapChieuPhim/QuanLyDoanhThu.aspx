<%@ Page Title="" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyDoanhThu.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyDoanhThu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <center style="text-align: left">
            <table align="left" cellspacing="0" style="width: 1150px">
                <tr>
                    <td colspan="6" style="text-align: center; font-size: xx-large;"><strong>Hoạt Động</strong></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 22px"></td>
                    <td style="width: 254px; height: 22px"></td>
                    <td style="width: 127px; height: 22px"></td>
                    <td style="height: 22px; width: 262px"></td>
                    <td style="height: 22px; width: 135px"></td>
                    <td style="height: 22px"></td>
                </tr>
                <tr>
                    <td style="height: 24px; width: 106px">&nbsp;</td>
                    <td style="height: 24px; width: 254px">
                        &nbsp;</td>
                    <td style="height: 24px; width: 127px">Tên hoạt động</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbTenHD" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 135px">&nbsp;</td>
                    <td style="height: 24px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 22px"></td>
                    <td style="height: 22px; width: 254px"></td>
                    <td style="width: 127px; height: 22px"></td>
                    <td style="height: 22px; width: 262px"></td>
                    <td style="height: 22px; width: 135px"></td>
                    <td style="height: 22px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 254px">
                        &nbsp;</td>
                    <td style="width: 127px; height: 24px">Chi phí</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbChiPhi" runat="server" Width="200px" TextMode="Number"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 135px">&nbsp;</td>
                    <td style="height: 24px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 27px; width: 106px"></td>
                    <td style="height: 27px; width: 254px"></td>
                    <td style="height: 27px; width: 127px"></td>
                    <td style="height: 27px; width: 262px"></td>
                    <td style="height: 27px; width: 135px"></td>
                    <td style="height: 27px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 254px">
                        &nbsp;</td>
                    <td style="height: 24px; width: 262px">
                        &nbsp;</td>
                    <td style="height: 24px">
                        <asp:Button ID="btn_Them" runat="server" Text="Thêm" Width="170px" OnClick="btn_Them_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="text-left" style="height: 24px"></td>
                    <td class="text-left" style="height: 24px"></td>
                    <td class="text-left" style="height: 24px">
                        &nbsp;</td>
                    <td class="text-left" style="height: 24px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="width: 254px; height: 24px">&nbsp;</td>
                    <td style="width: 127px; height: 24px">&nbsp;</td>
                    <td style="width: 262px; height: 24px">
                        &nbsp;</td>
                    <td style="width: 135px; height: 24px"></td>
                    <td style="height: 24px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px"></td>
                    <td style="height: 24px; width: 254px"></td>
                    <td style="width: 127px; height: 24px"></td>
                    <td style="height: 24px; width: 262px">
                    </td>
                    <td style="height: 24px; width: 135px"></td>
                    <td style="height: 24px"></td>
                </tr>
                </table>
        </center>
    </div>
    <div>
        <asp:GridView ID="gvDanhSachHoatDong" OnRowDeleting="gvDanhSachHoatDong_RowDeleting" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
        <Columns>
            <asp:BoundField DataField="MaHoatDong" HeaderText="Mã Hoạt Động" />
            <asp:BoundField DataField="TenHoatDong" HeaderText="Tên Hoạt Động" />
            <asp:BoundField DataField="ChiPhi" HeaderText="Chi Phí" />
            <asp:CommandField ButtonType="Image" ShowDeleteButton="True" DeleteImageUrl="Images/icon_delete.png" DeleteText="" ShowCancelButton="False" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>

<%@ Page Title="Quản Lý Phòng Chiếu" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyPhongChieu.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyPhongChieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <center style="text-align: left">
            <table align="left" cellspacing="0" style="width: 1150px">
                <tr>
                    <td colspan="6" style="text-align: center; font-size: xx-large;"><strong>Thông Tin Phòng Chiếu</strong></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 22px"></td>
                    <td style="width: 254px; height: 22px"></td>
                    <td style="width: 127px; height: 22px"></td>
                    <td style="height: 22px; width: 262px"></td>
                    <td style="height: 22px; width: 113px"></td>
                    <td style="height: 22px"></td>
                </tr>
                <tr>
                    <td style="height: 24px; width: 127px">Tên Phòng Chiếu</td>
                    <td style="height: 24px; width: 254px">
                        <asp:TextBox ID="tbTenPC" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 127px">Số Lượng Chỗ</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbSoLuongCho" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 113px">Tình Trạng</td>
                    <td style="height: 24px">
                        <asp:DropDownList ID="tbTinhTrang" runat="server" Height="39px" Width="198px">
                            <asp:ListItem Value="1">Hoạt động</asp:ListItem>
                            <asp:ListItem Value="0">Không hoạt động</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 22px"></td>
                    <td style="height: 22px; width: 254px"></td>
                    <td style="width: 127px; height: 22px"></td>
                    <td style="height: 22px; width: 262px">
                        <asp:Button ID="btnAdd" runat="server" Text="Thêm" Width="115px" OnClick="btnAdd_Click" />
                    </td>
                    <td style="height: 22px; width: 113px"></td>
                    <td style="height: 22px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px"></td>
                    <td style="height: 24px; width: 254px">
                    </td>
                    <td style="width: 127px; height: 24px"></td>
                    <td style="height: 24px; width: 262px">
                        
                    </td>
                     <td class="text-right" style="width: 113px; height: 24px">
                        
                    </td>
                </tr>
                <tr>
                    <td style="height: 27px; width: 106px"></td>
                    <td style="height: 27px; width: 254px"></td>
                    <td style="height: 27px; width: 127px"></td>
                    <td style="height: 27px; width: 262px"></td>
                    <td style="height: 27px; width: 113px"></td>
                    <td style="height: 27px">&nbsp;</td>
                </tr>
    </div>

    <div>
        <asp:GridView ID="gvDanhSachPhongChieu" OnRowDeleting="gvDanhSachPhongChieu_RowDeleting" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">             
        <Columns>
            <asp:BoundField DataField="MaPhongChieu" HeaderText="Mã Phòng Chiếu" />
            <asp:BoundField DataField="TenPhongChieu" HeaderText="Tên Phòng Chiếu" />
            <asp:BoundField DataField="SoLuongGhe" HeaderText="Số Lượng Ghế Ngồi" />
            <asp:BoundField DataField="TinhTrang" HeaderText="Tình Trạng" />
            <asp:CommandField ButtonType="Image" ShowDeleteButton="True" DeleteImageUrl="Images/icon_delete.png" DeleteText="" ShowCancelButton="False" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</div>
    </div>

</asp:Content>
<%@ Page Title="Quản Lý Phim" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyPhim.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyPhim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <center style="text-align: left">
            <table align="left" cellspacing="0" style="width: 1150px">
                <tr>
                    <td colspan="6" style="text-align: center; font-size: xx-large; height: 47px;"><strong>Thông Tin Phim</strong></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 22px"></td>
                    <td style="width: 262px; height: 22px"></td>
                    <td style="width: 162px; height: 22px"></td>
                    <td style="height: 22px; width: 262px"></td>
                    <td style="height: 22px; width: 135px"></td>
                    <td style="height: 22px"></td>
                </tr>
                <tr>
                    <td style="height: 24px; width: 262px">
                        Tên Phim</td>
                    <td style="height: 24px; width: 127px">
                        <asp:TextBox ID="tbTenPhim" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 162px">Thể Loại</td>
                    <td style="height: 24px; width: 262px">
                        <asp:DropDownList ID="tbTheLoai" runat="server" Height="40px" Width="203px">
                            <asp:ListItem>Hành động</asp:ListItem>
                            <asp:ListItem>Tâm lý</asp:ListItem>
                            <asp:ListItem>Kinh dị</asp:ListItem>
                            <asp:ListItem>Hoạt hình</asp:ListItem>
                            <asp:ListItem>Viễn tưởng</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="height: 24px; width: 135px">Đạo Diễn</td>
                    <td style="height: 24px">
                        <asp:TextBox ID="tbDaoDien" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 22px"></td>
                    <td style="height: 22px; width: 262px"></td>
                    <td style="width: 162px; height: 22px"></td>
                    <td style="height: 22px; width: 262px"></td>
                    <td style="height: 22px; width: 135px"></td>
                    <td style="height: 22px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">Diễn Viên</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbDienVien" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 162px; height: 24px">Giới Hạn Độ Tuổi</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbGHDT" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 135px">Nội Dung</td>
                    <td style="height: 24px">
                        <asp:TextBox ID="tbNoiDung" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 27px; width: 106px"></td>
                    <td style="height: 27px; width: 262px"></td>
                    <td style="height: 27px; width: 162px"></td>
                    <td style="height: 27px; width: 262px"></td>
                    <td style="height: 27px; width: 135px"></td>
                    <td style="height: 27px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">Năm Sản Xuất</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbNamSX" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 162px; height: 24px">Poster</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbPoster" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 135px">Trailer</td>
                    <td style="height: 24px">
                        <asp:TextBox ID="tbTrailer" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-left" style="height: 24px"></td>
                    <td class="text-left" style="height: 24px; width: 262px;"></td>
                    <td class="text-left" style="height: 24px; width: 162px;"></td>
                    <td class="text-left" style="height: 24px"></td>
                    <td class="text-left" style="height: 24px"></td>
                    <td class="text-left" style="height: 24px"></td>
                </tr>
                <tr>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 262px;">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 162px;">
                        &nbsp;</td>
                    <td class="text-left" style="height: 24px">
                        <asp:Button ID="btnAddPhim" runat="server" Text="Thêm" Width="170px" OnClick="btnAddPhim_Click" />
                    </td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 262px;">&nbsp;</td>
                    <td class="text-left" style="height: 24px; width: 162px;">
                        &nbsp;</td>
                    <td class="text-left" style="height: 24px">
                        &nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                    <td class="text-left" style="height: 24px">&nbsp;</td>
                </tr>
                </table>
        </center>
    </div>
    <div>
        <asp:GridView ID="gvDanhSachPhim" OnRowDeleting="gvDanhSachPhim_RowDeleting" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
        <Columns>
            <asp:BoundField DataField="MaPhim" HeaderText="Mã Phim" />
            <asp:BoundField DataField="Ten" HeaderText="Tên Phim" />
            <asp:BoundField DataField="TheLoai" HeaderText="Thể Loại" />
            <asp:BoundField DataField="DaoDien" HeaderText="Đạo Diễn" />
            <asp:BoundField DataField="DienVien" HeaderText="Diễn Viên" />
            <asp:BoundField DataField="GioiHanDoTuoi" HeaderText="Giới Hạn Độ Tuổi" />
            <asp:BoundField DataField="NoiDung" HeaderText="Nội Dung" />
            <asp:BoundField DataField="NamSanXuat" HeaderText="Năm Sản Xuất" />
            <asp:BoundField DataField="Poster" HeaderText="Poster" />
            <asp:BoundField DataField="Trailer" HeaderText="Trailer" />
            <asp:CommandField ButtonType="Image" ShowDeleteButton="True" DeleteImageUrl="Images/icon_delete.png" DeleteText="" ShowCancelButton="False" />
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>
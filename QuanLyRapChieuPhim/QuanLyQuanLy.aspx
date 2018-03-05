<%@ Page Title="Quản Lý Quản Lý" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyQuanLy.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyQuanLy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/GridView.css" rel="stylesheet" />
    <div>
        <center style="text-align: left">
            <table align="left" cellspacing="0" style="width: 1150px">
                <tr>
                     <td colspan="6" style="text-align: center; font-size: xx-large;"><strong>Thông Tin Cá Nhân</strong></td>
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
                    <td style="height: 24px; width: 106px">Tên Quản Lý</td>
                    <td style="height: 24px; width: 254px">
                        <asp:TextBox ID="tbTenQL" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 127px">Ngày Sinh</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbNgaySinh" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 135px">Giới Tính</td>
                    <td style="height: 24px">
                        <asp:TextBox ID="tbGioiTinh" runat="server" Width="200px"></asp:TextBox>
                    </td>
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
                    <td style="width: 106px; height: 24px">CMND</td>
                    <td style="height: 24px; width: 254px">
                        <asp:TextBox ID="tbCMND" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 127px; height: 24px">Số Điện Thoại</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbSDT" runat="server" Width="200px" TextMode="Phone"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 135px">Địa Chỉ</td>
                    <td style="height: 24px">
                        <asp:TextBox ID="tbDiaChi" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 27px; width: 106px"></td>
                    <td style="height: 27px; width: 254px"></td>
                    <td style="height: 27px; width: 127px"></td>
                    <td style="height: 27px; width: 262px"></td>
                    <td style="height: 27px; width: 135px"></td>
                    <td style="height: 27px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">Email</td>
                    <td style="height: 24px; width: 254px">
                        <asp:TextBox ID="tbEmail" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 127px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 262px">
                        &nbsp;</td>
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
                    <td class="text-center" colspan="6" style="height: 24px; font-size: xx-large;"><strong>Thông Tin Đăng Ký Tài Khoản</strong></td>
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
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="width: 254px; height: 24px">&nbsp;</td>
                    <td style="width: 127px; height: 24px">Tên Đăng Nhập</td>
                    <td style="width: 262px; height: 24px">
                        <asp:TextBox ID="tbTenDN" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 135px; height: 24px"></td>
                    <td style="height: 24px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 254px">&nbsp;</td>
                    <td style="width: 127px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 262px">&nbsp;</td>
                    <td style="height: 24px; width: 135px">&nbsp;</td>
                    <td style="height: 24px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 254px">&nbsp;</td>
                    <td style="width: 127px; height: 24px">Mật Khẩu</td>
                    <td style="height: 24px; width: 262px">
                        <asp:TextBox ID="tbMatKhau" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td style="height: 24px; width: 135px">&nbsp;</td>
                    <td style="height: 24px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 254px">&nbsp;</td>
                    <td style="width: 127px; height: 24px">&nbsp;</td>
                    <td style="height: 24px; width: 262px">&nbsp;</td>
                    <td style="height: 24px; width: 135px">&nbsp;</td>
                    <td style="height: 24px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px"></td>
                    <td style="width: 254px; height: 24px"></td>
                    <td style="width: 127px; height: 24px"></td>
                    <td class="text-left" style="width: 262px; height: 24px">
                        <asp:Button ID="btnAdd" runat="server" Text="Thêm" Width="170px" OnClick="btnAdd_Click" />
                    </td>
                    <td style="width: 135px; height: 24px"></td>
                    <td style="height: 24px"></td>
                </tr>
                <tr>
                    <td style="width: 106px; height: 24px">&nbsp;</td>
                    <td style="width: 254px; height: 24px">&nbsp;</td>
                    <td style="width: 127px; height: 24px">&nbsp;</td>
                    <td class="text-left" style="width: 262px; height: 24px">&nbsp;</td>
                    <td style="width: 135px; height: 24px">&nbsp;</td>
                    <td style="height: 24px">&nbsp;</td>
                </tr>
            </table>
        </center>
    </div>
    <div>
         <asp:GridView ID="gvDanhSachQuanLy" OnRowDeleting="gvDanhSachQuanLy_RowDeleting" runat="server" class="mydatagrid" PagerStyle-CssClass="pager" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center" Width="1100px">
   
        <Columns>
            <asp:BoundField DataField="MaQuanLy" HeaderText="Mã " />
            <asp:BoundField DataField="TenDangNhap" HeaderText="ID" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="HoTen" HeaderText="Tên Quản Lý" />
            <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh" />
            <asp:BoundField DataField="GioiTinh" HeaderText="Giới Tính" />
            <asp:BoundField DataField="CMND" HeaderText="CMND" />
            <asp:BoundField DataField="SoDienThoai" HeaderText="SĐT" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />
             <asp:CommandField ButtonType="Image" ShowDeleteButton="True" DeleteImageUrl="Images/icon_delete.png" DeleteText="" ShowCancelButton="False" />
       
        </Columns>
        <HeaderStyle CssClass="header"></HeaderStyle>
        <PagerStyle CssClass="pager"></PagerStyle>
        <RowStyle CssClass="rows"></RowStyle>

        </asp:GridView>
    </div>

</asp:Content>
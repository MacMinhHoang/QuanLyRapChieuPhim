<%@ Page Title="" Language="C#" MasterPageFile="~/Site_QL.Master" AutoEventWireup="true" CodeBehind="QuanLyLichLamViec.aspx.cs" Inherits="QuanLyRapChieuPhim.QuanLyLichLamViec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />

    <asp:GridView ID="gvDSLLV" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1162px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="MaNhanVien" HeaderText="Mã Nhân Viên" />
            <asp:TemplateField HeaderText="Thứ 2">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox2" OnCheckedChanged="CheckBox2_CheckedChanged" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thứ 3">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox3" OnCheckedChanged="CheckBox2_CheckedChanged" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thứ 4">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox4" OnCheckedChanged="CheckBox2_CheckedChanged" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thứ 5">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox5" OnCheckedChanged="CheckBox2_CheckedChanged" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thứ 6">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox6" OnCheckedChanged="CheckBox2_CheckedChanged" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thứ 7">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox7" OnCheckedChanged="CheckBox2_CheckedChanged" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Chủ nhật">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox8" OnCheckedChanged="CheckBox2_CheckedChanged" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

    

</asp:Content>

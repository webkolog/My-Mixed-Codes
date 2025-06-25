<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="WebApplication2.Kategoriler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <ul>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                    <%# Eval("KategoriAdi") %><br />
                </li>
            </ItemTemplate>
            <HeaderTemplate>
                <hr />
            </HeaderTemplate>
            <FooterTemplate>
                <hr />
            </FooterTemplate>
        </asp:Repeater>
    </ul>
    <br />
    <h3>
        Kategori Ekleme:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Kategori Adı: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="KategoriAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Açıklama: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Aciklama" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" Text="Ekle" />
    </form>
</body>
</html>

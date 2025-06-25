<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Odev_CB_Valudaor_kontrol.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="CheckBox1" runat="server" ValidationGroup="cbKontrol" />
        <asp:CheckBox ID="CheckBox2" runat="server" ValidationGroup="cbKontrol" /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" 
            ValidationGroup="cbKontrol" />
    
    </div>
    <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ErrorMessage="Checkboxlar seçili değil!" 
        onservervalidate="CustomValidator1_ServerValidate" 
        ValidationGroup="cbKontrol"></asp:CustomValidator>
        <br />
    </form>
</body>
</html>

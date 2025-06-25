<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sayfalamaDeneme.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
        <%# Eval("UrunAdi") %><br />
        </ItemTemplate>
        </asp:ListView>
    </div>
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" 
        QueryStringField="sayfa">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" FirstPageText="İlk" 
                LastPageText="Son" NextPageText="Sonraki" PreviousPageText="Önceki" 
                ShowFirstPageButton="True" ShowNextPageButton="False" 
                ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" FirstPageText="ilk" 
                LastPageText="Son" NextPageText="Sonraki" PreviousPageText="Önceki" 
                ShowLastPageButton="True" ShowNextPageButton="False" 
                ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    </form>
</body>
</html>

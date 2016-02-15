<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" BorderWidth="5" BorderStyle="Solid" CellPadding="5" style="text-align: center">
            <asp:TableRow>
                <asp:TableHeaderCell>Sl.NO</asp:TableHeaderCell>
                <asp:TableHeaderCell>Contestent Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Party</asp:TableHeaderCell>
                <asp:TableHeaderCell>Party Image</asp:TableHeaderCell>
                <asp:TableHeaderCell>Selection</asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="show" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>

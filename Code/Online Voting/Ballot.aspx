<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Ballot.aspx.vb" Inherits="Ballot" %>

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
        <asp:Button ID="Button1" runat="server" Text="Vote" Height="31px" Width="94px"  />
    </div>
    </form>
</body>
</html>

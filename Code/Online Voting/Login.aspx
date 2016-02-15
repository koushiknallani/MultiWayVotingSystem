<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table ID="Table1" runat="server" Style="text-align: center; margin-left: auto; margin-right: auto;margin-top: 2cm; ">
        <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">Online Voting System</asp:TableHeaderCell>
            </asp:TableHeaderRow>    
        <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">Login</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableHeaderCell>UserName</asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox1" runat="server" required></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>Password</asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" required ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    <asp:RadioButton ID="radMP" runat="server" GroupName="Selection" Text="MP" Checked="true" />
                    <asp:RadioButton ID="radMLA" runat="server" GroupName="Selection" Text="MLA"  />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow>
                <asp:TableCell ColumnSpan="2">
                    <asp:Button ID="Login" runat="server" Text="Login" />
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>

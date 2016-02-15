<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MLABallot.aspx.vb" Inherits="MLABallot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MLABallot</title>
    <style>
        table {
            border-collapse: collapse;
        }

        table, td, th {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; margin-left: auto; margin-right: auto; margin-top: 2cm;">
            <asp:Table ID="Table3" runat="server" Style="margin-left: auto; margin-right: auto; margin-top: 2cm;">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        Online Voting System
                    </asp:TableHeaderCell> 
                </asp:TableHeaderRow>
                               
            </asp:Table>
            <asp:Table ID="Table2" runat="server" Style="margin-left: auto; margin-right: auto; margin-top: 2cm;">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        <h2>Constituency Number:</h2>
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                              <asp:Label ID="Label1" runat="server" Text="Number"></asp:Label>

                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        <h2>Constituency Name:</h2>
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                              <asp:Label ID="Label2" runat="server" Text="Number"></asp:Label>

                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                
            </asp:Table>
            <asp:Table ID="Table1" runat="server" Style="text-align: center; margin-left: auto; margin-right: auto; margin-top: 1cm;">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell ColumnSpan="5"><h2>Ballot</h2></asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableHeaderCell><h2>Sl.NO</h2></asp:TableHeaderCell>
                    <asp:TableHeaderCell><h2>Contestent Name</h2></asp:TableHeaderCell>
                    <asp:TableHeaderCell><h2>Party</h2></asp:TableHeaderCell>
                    <asp:TableHeaderCell><h2>Party Image</h2></asp:TableHeaderCell>
                    <asp:TableHeaderCell><h2>Selection</h2></asp:TableHeaderCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button ID="Button1" runat="server" Text="Vote" Height="31px" Width="94px" />
        </div>
    </form>
</body>
</html>

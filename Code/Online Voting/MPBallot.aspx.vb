Imports System.Data
Imports System.Data.OleDb

Partial Class MPBallot
    Inherits System.Web.UI.Page
    Dim uid As String
    Dim consti As String
    Dim votecount(30) As Integer
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = ""
        Dim i As Integer
        For Each tr As TableRow In Table1.Rows
            For Each tc As TableCell In tr.Cells
                For Each c As Control In tc.Controls
                    If c.GetType Is GetType(RadioButton) Then
                        Dim rBtn As RadioButton = CType(c, RadioButton)
                        If rBtn.Checked Then
                            id = rBtn.ID
                            'MsgBox(votecount(id))
                        End If
                    End If
                Next
            Next
        Next
        If id <> "" Then
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koushik\Desktop\project\Code\VotingDB.accdb"
            con.Open()
            cmd.CommandText = "select Votecount,Contestantno from ContestantDB  where ConID='" + id + "' "
            cmd.Connection = con
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                i = Val(reader("Votecount"))
                'reader = reader("Contestantno")
            End If
            reader.Close()
            i = i + 1
            cmd.CommandText = "update ContestantDB set Votecount='" + i.ToString + "' where ConID='" + id + "'"
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            reader.Close()
            cmd.CommandText = "update  VoterDB  set MP='Yes' where VID='" + uid + "'"
            cmd.Connection = con
            cmd.ExecuteNonQuery()

            Response.Redirect("~/thankyou.aspx")
        End If
        
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        uid = Request.Cookies("data1").Value
        'MsgBox(uid)
        'consti = Request.Cookies("data1").Value
        Dim Coname As String = ""
        Dim i As Integer = 1
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koushik\Desktop\project\Code\VotingDB.accdb"
        con.Open()
        cmd.CommandText = "select Constituency,ConstName from VoterDB where VID='" + uid + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            consti = reader("Constituency")
            Coname = reader("ConstName")
        End If
        Label1.Text = consti
        Label2.Text = Coname

        reader.Close()
        cmd.CommandText = "select * from ContestantDB where   Constituency='" + consti + "' and Post='MP'"
        cmd.Connection = con
        reader = cmd.ExecuteReader()

        While reader.Read()
            Dim tablerow As New TableRow()

            Dim tcell1 As New TableCell()
            Dim tcell2 As New TableCell()
            Dim tcell3 As New TableCell()
            Dim tcell4 As New TableCell()
            Dim tcell5 As New TableCell()

            Dim slno As New Label
            Dim cname As New Label
            Dim cparty As New Label
            Dim img As New Image()
            Dim rad As New RadioButton

            slno.ID = "Slno" + i.ToString
            slno.Text = i.ToString

            cname.Text = reader("ContestantName")

            cparty.Text = reader("Party")

            img.ImageUrl = reader("PartyImage")
            img.Height = 50
            img.Width = 50

            rad.ID = reader("ConID")
            rad.GroupName = "List"
            If i = 1 Then
                rad.Checked = True
            End If

            votecount(i) = reader("Votecount")

            tcell1.Controls.Add(slno)
            tcell2.Controls.Add(cname)
            tcell3.Controls.Add(cparty)
            tcell4.Controls.Add(img)
            tcell5.Controls.Add(rad)

            tablerow.Controls.Add(tcell1)
            tablerow.Controls.Add(tcell2)
            tablerow.Controls.Add(tcell3)
            tablerow.Controls.Add(tcell4)
            tablerow.Controls.Add(tcell5)

            Table1.Controls.Add(tablerow)

            i = i + 1
        End While
        reader.Close()
        con.Close()
    End Sub
End Class

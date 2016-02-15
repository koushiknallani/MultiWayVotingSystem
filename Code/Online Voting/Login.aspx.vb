Imports System.Data
Imports System.Data.OleDb

Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koushik\Desktop\project\Code\VotingDB.accdb"
        con.Open()
        
        cmd.CommandText = "select * from VoterDB where VID='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader()
        If (reader.Read()) Then
            Dim mla As String = reader("MLA")
            Dim mp As String = reader("MP")

            Dim cook1 As New HttpCookie("data1")
            Dim cook2 As New HttpCookie("data2")
            cook1.Value = TextBox1.Text
            cook1.Expires = DateTime.Now.AddHours(1)
            
            cook2.Value = TextBox2.Text
            cook2.Expires = DateTime.Now.AddHours(1)


            Response.Cookies.Add(cook1)
            Response.Cookies.Add(cook2)
            If radMLA.Checked Then
                If mla = "NO" Then

                    Response.Redirect("~/MLABallot.aspx")
                Else
                    MsgBox("Already voted for MLA")
                End If
            ElseIf radMP.Checked Then
                If mp = "NO" Then
                    Response.Redirect("~/MPBallot.aspx")
                Else
                    MsgBox("Already voted for MP")
                End If
            End If


        Else
            MsgBox("VoterID or Password might be wrong")
        End If
    End Sub

End Class

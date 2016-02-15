Imports System.Data.OleDb
Imports System.Diagnostics

Public Class Form1
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader

    Private Sub Form1_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles Me.ContextMenuStripChanged

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VotingDBDataSet.ContestantDB' table. You can move, or remove it, as needed.
        Me.ContestantDBTableAdapter.Fill(Me.VotingDBDataSet.ContestantDB)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles B1.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "1"
        End If

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Hash_Click(sender As Object, e As EventArgs) Handles Hash.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "#"
        End If
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Star_Click(sender As Object, e As EventArgs) Handles Star.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "*"
        End If
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If TextBox1.TextLength <= 9 Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub BEnd_Click(sender As Object, e As EventArgs) Handles BEnd.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        If TextBox1.TextLength <> 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.TextLength - 1, 1)
        End If
    End Sub

    Private Sub BCall_Click(sender As Object, e As EventArgs) Handles BCall.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koushik\Desktop\project\Code\VotingDB.accdb"
        Dim v, c As String
        Dim id, position, Constituency As String
        Dim votecount As Integer
        Dim cmd As New OleDbCommand
        v = TextBox2.Text

        c = TextBox1.Text
        con.Open()
        cmd.CommandText = "select * from ContestantDB where Contestantno='" + c + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            'MsgBox(reader("Contestant"))
            id = reader("ConID")
            Constituency = reader("Constituency")
            position = reader("Post")
            votecount = Val(reader("Votecount"))
            'MsgBox(votecount)
        Else
            con.Close()
            MsgBox("Invalid Contestant", MsgBoxStyle.Exclamation, "Status")
            Exit Sub
        End If
        reader.Close()
        'Checking of voter
        cmd.CommandText = "select * from VoterDB where VPhno='" + v + "' and Constituency = '" + Constituency + "'"
        reader = cmd.ExecuteReader()
        If Not reader.Read() Then
            con.Close()
            MsgBox("Invalid Voter", MsgBoxStyle.Exclamation, "Status")
            Exit Sub
        End If
        reader.Close()
        'Counting Or Ignoring
        cmd.CommandText = "select * from VoterDB where VPhno='" + v + "' and " + position + "='NO'"
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            reader.Close()
            votecount = votecount + 1
            ' MsgBox(votecount)
            cmd.CommandText = "update ContestantDB set Votecount='" + votecount.ToString + "' where Contestantno='" + c + "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update VoterDB set " + position + "='Yes' where VPhno='" + v + "'"
            cmd.ExecuteNonQuery()
            MsgBox("You Have been voted sucessfully", MsgBoxStyle.Information, "Status")
            con.Close()

        Else
            con.Close()
            MsgBox("Alredy Voted", MsgBoxStyle.Exclamation, "Status")
            Exit Sub
        End If
        con.Close()
    End Sub

    Private Sub BCall_ContextMenuChanged(sender As Object, e As EventArgs) Handles BCall.ContextMenuChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Module1.main()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class
Imports System.Console
Imports System.Data.OleDb
Module Module1
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader
    Sub Main()
        Dim mode As Integer
        Dim pno As String
        'Dim cons As String = ""
        'Dim i As Integer = 1
        'Dim votsel As Integer = 1
        'Dim str As String

        Console.Write("Enter Your Phone Number:")
        pno = ReadLine()

        
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koushik\Desktop\project\Code\VotingDB.accdb"
        con.Open()
        cmd.CommandText = "select * from VoterDB where VPhno='" + pno + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader()

        If reader.Read() Then
        Else

            con.Close()
            MsgBox("Invalid Voter", MsgBoxStyle.Exclamation, "Status")
            System.Threading.Thread.Sleep(2000)
            Exit Sub
        End If
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        Console.WriteLine("Call Connecting....")
Line1:
        WriteLine("Press 1 to vote MP")
        SAPI.Speak("Press 1 to vote MP")
        WriteLine("Press 2 to vote MLA")
        SAPI.Speak("Press 2 to vote MLA")
        mode = ReadLine()
        If mode = 1 Then
            MP.Main(pno)
        ElseIf mode = 2 Then
            MLA.Main(pno)
        Else
            SAPI.Speak("You have selected Invalid option")
            GoTo Line1

        End If
        System.Threading.Thread.Sleep(1000)
        'con.Open()
        'cmd.CommandText = "select Constituency from 105 where vphno='" + pno + "'"
        'cmd.Connection = con
        'reader = cmd.ExecuteReader()

        'While reader.Read()
        '    cons = reader("Constituency")
        '    ' MsgBox(cons)
        'End While
        'reader.Close()
        'Dim SAPI
        'SAPI = CreateObject("SAPI.spvoice")
        'If mode = 1 Then
        '    'MsgBox(cons)
        '    cmd.CommandText = "select * from conlist where constituency ='" + cons + "' and Post='MP'"
        '    cmd.Connection = con
        '    reader = cmd.ExecuteReader()
        '    While reader.Read()

        '        str = "Press " + i.ToString + " to vote " + reader("Contestant")
        '        Console.WriteLine(str)
        '        SAPI.Speak(str)
        '        i = i + 1
        '    End While

        '    votsel = ReadLine()
        '    WriteLine("You have selected")
        'End If
        'con.Close()
        'Console.ReadLine()

    End Sub

End Module

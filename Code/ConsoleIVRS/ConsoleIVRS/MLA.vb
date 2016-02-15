Imports System.Console
Imports System.Data.OleDb
Module MLA
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader
    Sub Main(pno As String)

        ' Dim pno As String
        Dim cons As String = ""
        Dim i As Integer = 0
        Dim votsel As Integer = 1
        Dim str As String
        Dim voterstatus As String = ""
        Dim conid(30) As String
        Dim votint(30) As Integer

        'Console.WriteLine("Enter Your Phone Number:")
        'pno = ReadLine()
        'Console.WriteLine("Call Connecting....")
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koushik\Desktop\project\Code\VotingDB.accdb"
        con.Open()
        cmd.CommandText = "select Constituency,MLA from VoterDB where VPhno='" + pno + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader()
        While reader.Read()
            cons = reader("Constituency")
            voterstatus = reader("MLA")
            ' MsgBox(cons)
        End While
        reader.Close()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        If voterstatus = "NO" Then
            'MsgBox(cons)
line1:
            i = 0
            cmd.CommandText = "select * from ContestantDB where Constituency ='" + cons + "' and Post='MLA'"
            cmd.Connection = con
            reader = cmd.ExecuteReader()
            i = 0
            While reader.Read()

                votint(i) = Convert.ToInt32(reader("Votecount"))
                conid(i) = reader("ConID")
                i = i + 1
                str = "Press " + i.ToString + " to vote " + reader("ContestantName")
                Console.WriteLine(str)
                SAPI.Speak(str)


            End While
            reader.Close()
            votsel = ReadLine()
            If votsel > i Or votsel < 1 Then
                SAPI.speak("Please Select a valid Contestant")
                GoTo line1
            End If

            votint(votsel - 1) = votint(votsel - 1) + 1

            cmd.CommandText = "update ContestantDB set Votecount='" + votint(votsel - 1).ToString + "' where ConID='" + conid(votsel - 1) + "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update VoterDB set MLA='Yes' where VPhno='" + pno + "'"
            cmd.ExecuteNonQuery()
            WriteLine("You have been voted Sucessfully")
            SAPI.speak("You have been voted Sucessfully")
        Else
            WriteLine("You have been voted already")
            SAPI.speak("You have been voted already")

        End If
        con.Close()
        System.Threading.Thread.Sleep(1000)
    End Sub
End Module

Imports System.Data.OleDb

Partial Class Ballot
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each tr As TableRow In Table1.Rows
            For Each tc As TableCell In tr.Cells
                For Each c As Control In tc.Controls
                    If c.GetType Is GetType(RadioButton) Then
                        Dim rBtn As RadioButton = CType(c, RadioButton)
                        If rBtn.Checked Then
                            MsgBox(rBtn.ID)
                        End If
                    End If
                Next
            Next
        Next

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim vid As String = "16814386"
        Dim i As Integer = 1
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koushik\Downloads\MSVS1\MSVS1\MSVS1\MSVD.accdb"
        con.Open()
        cmd.CommandText = "select * from 105 where ='" + vid + "'"
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

            cname = reader("Contestant")

            cparty = reader("Post")

            img.ImageUrl = "1.jpg"
            img.Height = 40
            img.Width = 40

            rad.ID = reader("ConID")
            rad.GroupName = "List"

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

        'For i As Integer = 1 To 5
        '    Dim tablerow As New TableRow()

        '    Dim tcell1 As New TableCell()
        '    Dim tcell2 As New TableCell()
        '    Dim tcell3 As New TableCell()
        '    Dim tcell4 As New TableCell()
        '    Dim tcell5 As New TableCell()

        '    Dim slno As New Label
        '    Dim cname As New Label
        '    Dim cparty As New Label
        '    Dim img As New Image()
        '    Dim rad As New RadioButton



        '    img.ImageUrl = "1.jpg"
        '    img.Height = 40
        '    img.Width = 40
        '    rad.ID = "rad" + i.ToString
        '    rad.GroupName = "a"

        '    slno.ID = "Slno" + i.ToString
        '    slno.Text = i.ToString

        '    tcell1.Controls.Add(slno)
        '    tcell2.Controls.Add(rad)
        '    tcell3.Controls.Add(img)

        '    tablerow.Controls.Add(tcell1)
        '    tablerow.Controls.Add(tcell2)
        '    tablerow.Controls.Add(tcell3)

        '    Table1.Controls.Add(tablerow)
        'Next

    End Sub
End Class

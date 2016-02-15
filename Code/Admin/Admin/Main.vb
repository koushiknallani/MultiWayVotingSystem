Public Class Main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("http://localhost:53626/Login.aspx")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Process.Start("C:\Users\koushik\Desktop\project\Code\ConsoleIVRS\ConsoleIVRS\bin\Debug\ConsoleIVRS.exe")

    End Sub
End Class
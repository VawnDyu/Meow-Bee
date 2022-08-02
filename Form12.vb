Public Class Form12

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Total Score: " + Form1.Score.ToString
        Label3.Text = "Number of Correct: " + Form1.Correct.ToString + "/10"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class
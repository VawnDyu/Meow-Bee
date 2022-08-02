Public Class Form5

    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromSeconds(10)
    Const Scorepoints As Integer = 10

    Private Sub frmSinglePlayer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        TargetDT = DateTime.Now.Add(CountDownFrom)
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            LabelTimer.Text = ts.ToString("ss")
        Else
            LabelTimer.Text = "00"
            Me.Close()
            Form6.Show()
        End If

        If ts.TotalMilliseconds < 4000 Then
            LabelTimer.ForeColor = Color.LightCoral
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Form1.Score = Form1.Score + Scorepoints
        Form1.Correct = Form1.Correct + 1
    End Sub
End Class
Public Class Form8

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
            Form9.Show()
        End If

        If ts.TotalMilliseconds < 4000 Then
            LabelTimer.ForeColor = Color.LightCoral
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        TextBox1.ReadOnly = True
        If TextBox1.Text = "String" Then
            Form1.Score = Form1.Score + Scorepoints
            Form1.Correct = Form1.Correct + 1
        End If
    End Sub
End Class
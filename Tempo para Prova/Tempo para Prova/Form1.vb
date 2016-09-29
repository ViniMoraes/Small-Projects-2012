Public Class Form1
    Dim pergunta As Integer = 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        My.Computer.Audio.Play("C:\Users\Xpeed\Downloads\Music\beep-1.wav", AudioPlayMode.Background)
        pergunta = pergunta + 1
        Clock.Text = Str(pergunta)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Enabled = False
        pergunta = 1
        Clock.Text = "1"
        Button1.Enabled = True
    End Sub
End Class

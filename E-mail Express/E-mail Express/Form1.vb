Imports System
Imports System.Net
Imports System.Net.Mail
Public Class Form1
    Dim destino As String
    Private Sub Btn_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_enviar.Click
        Try
            destino = TxtB_destino.Text
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
            SmtpServer.Host = "smtp.live.com"
            SmtpServer.Port = 587 'server para Hotmail
            SmtpServer.EnableSsl = True
            mail.From = New MailAddress("E-mailExpress@Vinicius.com.br") 'mail from ou seja de quem manda o e-mail
            mail.To.Add(destino) ' mail.to para quem vai

            mail.Body = TextBox2.Text

            SmtpServer.Send(mail)
            MessageBox.Show("E-mail enviado com sucesso !", "Aviso", MessageBoxButtons.OK)
        Catch
            MsgBox("Falha ao Enviar")
        End Try


    End Sub


    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

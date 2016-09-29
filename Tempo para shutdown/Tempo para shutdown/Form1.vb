Public Class Form1
    Dim tempo_restante As Date
    Dim desligar As Integer
    Dim reiniciar As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Hora_atual.Text = TimeOfDay
    End Sub

    Private Sub Botao_desligar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Botao_desligar.Click
        If TxtB_hora.Text = "  :" Then
            MessageBox.Show("Defina um tempo para o computador desligar !", "Falta de dados", MessageBoxButtons.OK)
        Else
            If reiniciar = 1 Then
                MessageBox.Show("Operação já existente !", "...", MessageBoxButtons.OK)
            Else
                tempo_restante = TxtB_hora.Text
                desligar = 1
                bolinha_desligar.Enabled = True
                bolinha_desligar.Checked = True
            End If
        End If

    End Sub

    Private Sub TxtB_hora_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles TxtB_hora.MaskInputRejected

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Hora_atual.Text = TimeOfDay
        If desligar = 1 And tempo_restante = Hora_atual.Text Then
            Timer1.Enabled = False
            System.Diagnostics.Process.Start("shutdown", "-s -t 00")
        End If

        If reiniciar = 1 And tempo_restante = Hora_atual.Text Then
            Timer1.Enabled = False
            System.Diagnostics.Process.Start("shutdown", "-r -t 00")
        End If
    End Sub

    Private Sub Botao_reiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Botao_reiniciar.Click
        If TxtB_hora.Text = "  :" Then
            MessageBox.Show("Defina um tempo para o computador desligar !", "Falta de dados", MessageBoxButtons.OK)
        Else
            If desligar = 1 Then
                MessageBox.Show("Operação já existente !", "...", MessageBoxButtons.OK)
            Else
                reiniciar = 1
                bolinha_reiniciar.Enabled = True
                bolinha_reiniciar.Checked = True
            End If
        End If

    End Sub

    Private Sub Botao_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Botao_cancelar.Click
        desligar = 0
        reiniciar = 0
        bolinha_reiniciar.Enabled = False
        bolinha_reiniciar.Checked = False
        bolinha_desligar.Enabled = False
        bolinha_desligar.Checked = False
    End Sub

    Private Sub Botao_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Botao_sair.Click
        Close()
    End Sub

End Class

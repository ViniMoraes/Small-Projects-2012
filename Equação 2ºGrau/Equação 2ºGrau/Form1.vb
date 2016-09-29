Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtB_A.TextChanged
        If Not IsNumeric(txtB_A.Text) And Not txtB_A.Text = "" And Not txtB_A.Text = "-" Then
            txtB_A.Text = ""
            MsgBox("Inválido", MsgBoxStyle.Exclamation, "Erro")
        End If
    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        If txtB_A.Text = "" Or txtB_B.Text = "" Or txtB_C.Text = "" Then
            MsgBox("Falta de Dados !", MsgBoxStyle.Information, "Dados Insuficientes")
        Else
            txtB_x1.Text = ""
            txtB_x2.Text = ""
            Dim a, b, c, delta, x1, x2 As Integer
            a = txtB_A.Text
            b = txtB_B.Text
            c = txtB_C.Text
            delta = (b * b) - (4 * a * c)
            If delta < 0 Then
                MsgBox("Não existem Raízes", MsgBoxStyle.Information, "Sem Raíz")
            Else
                x1 = (-b + Math.Sqrt(delta)) / 2 * a
                x2 = (-b - Math.Sqrt(delta)) / 2 * a
                txtB_x1.Text = x1
                txtB_x2.Text = x2
            End If


        End If
    End Sub

    Private Sub Btn_Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpar.Click
        txtB_A.Text = ""
        txtB_B.Text = ""
        txtB_C.Text = ""
        txtB_x1.Text = ""
        txtB_x2.Text = ""
    End Sub

    Private Sub txtB_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtB_B.TextChanged
        If Not IsNumeric(txtB_B.Text) And Not txtB_B.Text = "" And Not txtB_B.Text = "-" Then
            txtB_B.Text = ""
            MsgBox("Inválido", MsgBoxStyle.Exclamation, "Erro")
        End If
    End Sub

    Private Sub txtB_C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtB_C.TextChanged
        If Not IsNumeric(txtB_C.Text) And Not txtB_C.Text = "" And Not txtB_C.Text = "-" Then
            txtB_C.Text = ""
            MsgBox("Inválido", MsgBoxStyle.Exclamation, "Erro")
        End If
    End Sub
End Class

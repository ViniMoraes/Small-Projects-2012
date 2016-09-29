Public Class Form1
    Dim R, S, H, P, localatual As String

    Private Sub CB_R_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_R.CheckedChanged
        If (R = "") Then
            R = "R"
        ElseIf (R = "R") Then
            R = ""
        End If
    End Sub

    Private Sub CB_H_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_H.CheckedChanged
        If (H = "") Then
            H = "H"
        ElseIf (H = "H") Then
            H = ""
        End If
    End Sub

    Private Sub CB_S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_S.CheckedChanged
        If (S = "") Then
            S = "S"
        ElseIf (S = "S") Then
            S = ""
        End If
    End Sub

    Private Sub CB_Pastas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Pastas.CheckedChanged
        If (P = "") Then
            P = "/d"
        ElseIf (P = "/d") Then
            P = ""
        End If
    End Sub

    Private Sub btn_MAIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MAIS.Click
        localatual = Environment.CurrentDirectory
        Shell("attrib +" + R + " +" + S + " +" + H + " " + localatual + "\ * " + P)
    End Sub

    Private Sub btn_MENOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MENOS.Click
        localatual = Environment.CurrentDirectory
        Shell("attrib -" + R + " -" + S + " -" + H + " " + localatual + "\ * " + P)
    End Sub

    Private Sub btn_PADRAO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PADRAO.Click
        localatual = Environment.CurrentDirectory
        Shell("attrib - R - S -H " + localatual + "\ * /d")
        CB_H.Checked = False
        CB_R.Checked = False
        CB_S.Checked = False
        CB_Pastas.Checked = False
    End Sub

    Private Sub btn_SAIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SAIR.Click
        End
    End Sub
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        localatual = Environment.CurrentDirectory
        Shell(localatual + "\" + TB_CONSOLE.Text)
    End Sub

    Private Sub btn_LIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LIMPAR.Click
        TB_CONSOLE.Clear()
    End Sub
End Class

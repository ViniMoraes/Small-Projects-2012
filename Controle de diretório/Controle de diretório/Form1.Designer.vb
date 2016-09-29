<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TB_CONSOLE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_Pastas = New System.Windows.Forms.CheckBox()
        Me.CB_S = New System.Windows.Forms.CheckBox()
        Me.CB_H = New System.Windows.Forms.CheckBox()
        Me.CB_R = New System.Windows.Forms.CheckBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_MAIS = New System.Windows.Forms.Button()
        Me.btn_MENOS = New System.Windows.Forms.Button()
        Me.btn_PADRAO = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_LIMPAR = New System.Windows.Forms.Button()
        Me.btn_SAIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_CONSOLE
        '
        Me.TB_CONSOLE.Location = New System.Drawing.Point(6, 19)
        Me.TB_CONSOLE.Name = "TB_CONSOLE"
        Me.TB_CONSOLE.Size = New System.Drawing.Size(186, 20)
        Me.TB_CONSOLE.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_Pastas)
        Me.GroupBox1.Controls.Add(Me.CB_S)
        Me.GroupBox1.Controls.Add(Me.CB_H)
        Me.GroupBox1.Controls.Add(Me.CB_R)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 116)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atributos (Todos)"
        '
        'CB_Pastas
        '
        Me.CB_Pastas.AutoSize = True
        Me.CB_Pastas.Location = New System.Drawing.Point(6, 91)
        Me.CB_Pastas.Name = "CB_Pastas"
        Me.CB_Pastas.Size = New System.Drawing.Size(58, 17)
        Me.CB_Pastas.TabIndex = 3
        Me.CB_Pastas.Text = "Pastas"
        Me.CB_Pastas.UseVisualStyleBackColor = True
        '
        'CB_S
        '
        Me.CB_S.AutoSize = True
        Me.CB_S.Location = New System.Drawing.Point(7, 68)
        Me.CB_S.Name = "CB_S"
        Me.CB_S.Size = New System.Drawing.Size(133, 17)
        Me.CB_S.TabIndex = 2
        Me.CB_S.Text = "Arquivo do Sistema (S)"
        Me.CB_S.UseVisualStyleBackColor = True
        '
        'CB_H
        '
        Me.CB_H.AutoSize = True
        Me.CB_H.Location = New System.Drawing.Point(7, 44)
        Me.CB_H.Name = "CB_H"
        Me.CB_H.Size = New System.Drawing.Size(113, 17)
        Me.CB_H.TabIndex = 1
        Me.CB_H.Text = "Arquivo Oculto (H)"
        Me.CB_H.UseVisualStyleBackColor = True
        '
        'CB_R
        '
        Me.CB_R.AutoSize = True
        Me.CB_R.Location = New System.Drawing.Point(7, 20)
        Me.CB_R.Name = "CB_R"
        Me.CB_R.Size = New System.Drawing.Size(120, 17)
        Me.CB_R.TabIndex = 0
        Me.CB_R.Text = "Somente Leitura (R)"
        Me.CB_R.UseVisualStyleBackColor = True
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(6, 50)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "&OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'btn_MAIS
        '
        Me.btn_MAIS.Location = New System.Drawing.Point(162, 20)
        Me.btn_MAIS.Name = "btn_MAIS"
        Me.btn_MAIS.Size = New System.Drawing.Size(49, 23)
        Me.btn_MAIS.TabIndex = 3
        Me.btn_MAIS.Text = "+"
        Me.btn_MAIS.UseVisualStyleBackColor = True
        '
        'btn_MENOS
        '
        Me.btn_MENOS.Location = New System.Drawing.Point(162, 44)
        Me.btn_MENOS.Name = "btn_MENOS"
        Me.btn_MENOS.Size = New System.Drawing.Size(49, 23)
        Me.btn_MENOS.TabIndex = 4
        Me.btn_MENOS.Text = "-"
        Me.btn_MENOS.UseVisualStyleBackColor = True
        '
        'btn_PADRAO
        '
        Me.btn_PADRAO.Location = New System.Drawing.Point(162, 68)
        Me.btn_PADRAO.Name = "btn_PADRAO"
        Me.btn_PADRAO.Size = New System.Drawing.Size(49, 38)
        Me.btn_PADRAO.TabIndex = 5
        Me.btn_PADRAO.Text = "&Padrão"
        Me.btn_PADRAO.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_LIMPAR)
        Me.GroupBox2.Controls.Add(Me.btn_OK)
        Me.GroupBox2.Controls.Add(Me.TB_CONSOLE)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 79)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Console (Pasta)"
        '
        'btn_LIMPAR
        '
        Me.btn_LIMPAR.Location = New System.Drawing.Point(118, 50)
        Me.btn_LIMPAR.Name = "btn_LIMPAR"
        Me.btn_LIMPAR.Size = New System.Drawing.Size(75, 23)
        Me.btn_LIMPAR.TabIndex = 3
        Me.btn_LIMPAR.Text = "&Limpar"
        Me.btn_LIMPAR.UseVisualStyleBackColor = True
        '
        'btn_SAIR
        '
        Me.btn_SAIR.Location = New System.Drawing.Point(162, 105)
        Me.btn_SAIR.Name = "btn_SAIR"
        Me.btn_SAIR.Size = New System.Drawing.Size(49, 23)
        Me.btn_SAIR.TabIndex = 7
        Me.btn_SAIR.Text = "&Sair"
        Me.btn_SAIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 220)
        Me.Controls.Add(Me.btn_SAIR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_PADRAO)
        Me.Controls.Add(Me.btn_MENOS)
        Me.Controls.Add(Me.btn_MAIS)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Controle de Pasta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TB_CONSOLE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_S As System.Windows.Forms.CheckBox
    Friend WithEvents CB_H As System.Windows.Forms.CheckBox
    Friend WithEvents CB_R As System.Windows.Forms.CheckBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btn_MAIS As System.Windows.Forms.Button
    Friend WithEvents btn_MENOS As System.Windows.Forms.Button
    Friend WithEvents btn_PADRAO As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_LIMPAR As System.Windows.Forms.Button
    Friend WithEvents btn_SAIR As System.Windows.Forms.Button
    Friend WithEvents CB_Pastas As System.Windows.Forms.CheckBox

End Class

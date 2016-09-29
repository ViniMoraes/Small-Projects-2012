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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtB_hora = New System.Windows.Forms.MaskedTextBox
        Me.Botao_desligar = New System.Windows.Forms.Button
        Me.Botao_reiniciar = New System.Windows.Forms.Button
        Me.Botao_cancelar = New System.Windows.Forms.Button
        Me.Botao_sair = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Hora_atual = New System.Windows.Forms.Label
        Me.bolinha_desligar = New System.Windows.Forms.RadioButton
        Me.bolinha_reiniciar = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TxtB_hora
        '
        Me.TxtB_hora.Location = New System.Drawing.Point(38, 37)
        Me.TxtB_hora.Mask = "00:00"
        Me.TxtB_hora.Name = "TxtB_hora"
        Me.TxtB_hora.Size = New System.Drawing.Size(38, 20)
        Me.TxtB_hora.TabIndex = 0
        Me.TxtB_hora.Text = "0000"
        Me.TxtB_hora.ValidatingType = GetType(Date)
        '
        'Botao_desligar
        '
        Me.Botao_desligar.Location = New System.Drawing.Point(29, 75)
        Me.Botao_desligar.Name = "Botao_desligar"
        Me.Botao_desligar.Size = New System.Drawing.Size(75, 23)
        Me.Botao_desligar.TabIndex = 1
        Me.Botao_desligar.Text = "&Desligar"
        Me.Botao_desligar.UseVisualStyleBackColor = True
        '
        'Botao_reiniciar
        '
        Me.Botao_reiniciar.Location = New System.Drawing.Point(29, 104)
        Me.Botao_reiniciar.Name = "Botao_reiniciar"
        Me.Botao_reiniciar.Size = New System.Drawing.Size(75, 23)
        Me.Botao_reiniciar.TabIndex = 2
        Me.Botao_reiniciar.Text = "&Reiniciar"
        Me.Botao_reiniciar.UseVisualStyleBackColor = True
        '
        'Botao_cancelar
        '
        Me.Botao_cancelar.Location = New System.Drawing.Point(131, 75)
        Me.Botao_cancelar.Name = "Botao_cancelar"
        Me.Botao_cancelar.Size = New System.Drawing.Size(90, 52)
        Me.Botao_cancelar.TabIndex = 3
        Me.Botao_cancelar.Text = "&Cancelar"
        Me.Botao_cancelar.UseVisualStyleBackColor = True
        '
        'Botao_sair
        '
        Me.Botao_sair.Location = New System.Drawing.Point(54, 156)
        Me.Botao_sair.Name = "Botao_sair"
        Me.Botao_sair.Size = New System.Drawing.Size(124, 23)
        Me.Botao_sair.TabIndex = 4
        Me.Botao_sair.Text = "&Sair"
        Me.Botao_sair.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Hora_atual
        '
        Me.Hora_atual.AutoSize = True
        Me.Hora_atual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora_atual.Location = New System.Drawing.Point(141, 25)
        Me.Hora_atual.Name = "Hora_atual"
        Me.Hora_atual.Size = New System.Drawing.Size(37, 18)
        Me.Hora_atual.TabIndex = 5
        Me.Hora_atual.Text = "--:--"
        '
        'bolinha_desligar
        '
        Me.bolinha_desligar.AutoSize = True
        Me.bolinha_desligar.Enabled = False
        Me.bolinha_desligar.Location = New System.Drawing.Point(12, 80)
        Me.bolinha_desligar.Name = "bolinha_desligar"
        Me.bolinha_desligar.Size = New System.Drawing.Size(14, 13)
        Me.bolinha_desligar.TabIndex = 6
        Me.bolinha_desligar.UseVisualStyleBackColor = True
        '
        'bolinha_reiniciar
        '
        Me.bolinha_reiniciar.AutoSize = True
        Me.bolinha_reiniciar.Enabled = False
        Me.bolinha_reiniciar.Location = New System.Drawing.Point(12, 109)
        Me.bolinha_reiniciar.Name = "bolinha_reiniciar"
        Me.bolinha_reiniciar.Size = New System.Drawing.Size(14, 13)
        Me.bolinha_reiniciar.TabIndex = 7
        Me.bolinha_reiniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Agendamento :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 191)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bolinha_reiniciar)
        Me.Controls.Add(Me.bolinha_desligar)
        Me.Controls.Add(Me.Hora_atual)
        Me.Controls.Add(Me.Botao_sair)
        Me.Controls.Add(Me.Botao_cancelar)
        Me.Controls.Add(Me.Botao_reiniciar)
        Me.Controls.Add(Me.Botao_desligar)
        Me.Controls.Add(Me.TxtB_hora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown By Vini"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtB_hora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Botao_desligar As System.Windows.Forms.Button
    Friend WithEvents Botao_reiniciar As System.Windows.Forms.Button
    Friend WithEvents Botao_cancelar As System.Windows.Forms.Button
    Friend WithEvents Botao_sair As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Hora_atual As System.Windows.Forms.Label
    Friend WithEvents bolinha_desligar As System.Windows.Forms.RadioButton
    Friend WithEvents bolinha_reiniciar As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

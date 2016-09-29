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
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Btn_Limpar = New System.Windows.Forms.Button()
        Me.txtB_A = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtB_B = New System.Windows.Forms.TextBox()
        Me.txtB_C = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtB_x2 = New System.Windows.Forms.TextBox()
        Me.txtB_x1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(25, 117)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 0
        Me.btn_calcular.Text = "&Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.Location = New System.Drawing.Point(106, 117)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Limpar.TabIndex = 1
        Me.Btn_Limpar.Text = "&Limpar"
        Me.Btn_Limpar.UseVisualStyleBackColor = True
        '
        'txtB_A
        '
        Me.txtB_A.Location = New System.Drawing.Point(12, 82)
        Me.txtB_A.Name = "txtB_A"
        Me.txtB_A.Size = New System.Drawing.Size(40, 20)
        Me.txtB_A.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ax² + Bx + C"
        '
        'txtB_B
        '
        Me.txtB_B.Location = New System.Drawing.Point(85, 82)
        Me.txtB_B.Name = "txtB_B"
        Me.txtB_B.Size = New System.Drawing.Size(40, 20)
        Me.txtB_B.TabIndex = 4
        '
        'txtB_C
        '
        Me.txtB_C.Location = New System.Drawing.Point(156, 82)
        Me.txtB_C.Name = "txtB_C"
        Me.txtB_C.Size = New System.Drawing.Size(40, 20)
        Me.txtB_C.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "A :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "B :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "C :"
        '
        'txtB_x2
        '
        Me.txtB_x2.Location = New System.Drawing.Point(118, 175)
        Me.txtB_x2.Name = "txtB_x2"
        Me.txtB_x2.Size = New System.Drawing.Size(36, 20)
        Me.txtB_x2.TabIndex = 9
        '
        'txtB_x1
        '
        Me.txtB_x1.Location = New System.Drawing.Point(49, 175)
        Me.txtB_x1.Name = "txtB_x1"
        Me.txtB_x1.Size = New System.Drawing.Size(36, 20)
        Me.txtB_x1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "X'' :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "X' :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 205)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtB_x1)
        Me.Controls.Add(Me.txtB_x2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtB_C)
        Me.Controls.Add(Me.txtB_B)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtB_A)
        Me.Controls.Add(Me.Btn_Limpar)
        Me.Controls.Add(Me.btn_calcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eq. 2ºGrau"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpar As System.Windows.Forms.Button
    Friend WithEvents txtB_A As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtB_B As System.Windows.Forms.TextBox
    Friend WithEvents txtB_C As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtB_x2 As System.Windows.Forms.TextBox
    Friend WithEvents txtB_x1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class

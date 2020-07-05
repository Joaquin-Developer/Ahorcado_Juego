<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.lblModo = New System.Windows.Forms.Label()
        Me.cBoxModo = New System.Windows.Forms.ComboBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(311, 53)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(12, 41)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(84, 13)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Palabra secreta:"
        '
        'txtPalabra
        '
        Me.txtPalabra.Location = New System.Drawing.Point(102, 38)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPalabra.Size = New System.Drawing.Size(162, 20)
        Me.txtPalabra.TabIndex = 2
        '
        'lblModo
        '
        Me.lblModo.AutoSize = True
        Me.lblModo.Location = New System.Drawing.Point(57, 75)
        Me.lblModo.Name = "lblModo"
        Me.lblModo.Size = New System.Drawing.Size(37, 13)
        Me.lblModo.TabIndex = 3
        Me.lblModo.Text = "Modo:"
        '
        'cBoxModo
        '
        Me.cBoxModo.FormattingEnabled = True
        Me.cBoxModo.Items.AddRange(New Object() {"Texto", "Teclado"})
        Me.cBoxModo.Location = New System.Drawing.Point(102, 72)
        Me.cBoxModo.Name = "cBoxModo"
        Me.cBoxModo.Size = New System.Drawing.Size(132, 21)
        Me.cBoxModo.TabIndex = 4
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(240, 72)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(24, 21)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.Text = "?"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 133)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.cBoxModo)
        Me.Controls.Add(Me.lblModo)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "FormInicio"
        Me.Text = "Ahorcado: The Game - Ingreso de Palabra Secreta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents lblModo As Label
    Friend WithEvents cBoxModo As ComboBox
    Friend WithEvents btnInfo As Button
End Class

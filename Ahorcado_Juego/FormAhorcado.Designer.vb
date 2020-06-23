<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAhorcado
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
        Me.lblLetrasUsadas = New System.Windows.Forms.Label()
        Me.lblPalabra = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtLetra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnJugada = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLetrasUsadas
        '
        Me.lblLetrasUsadas.AutoSize = True
        Me.lblLetrasUsadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.lblLetrasUsadas.Location = New System.Drawing.Point(151, 9)
        Me.lblLetrasUsadas.Name = "lblLetrasUsadas"
        Me.lblLetrasUsadas.Size = New System.Drawing.Size(111, 26)
        Me.lblLetrasUsadas.TabIndex = 0
        Me.lblLetrasUsadas.Text = "Aca arriba"
        Me.lblLetrasUsadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalabra
        '
        Me.lblPalabra.AutoSize = True
        Me.lblPalabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.lblPalabra.Location = New System.Drawing.Point(143, 399)
        Me.lblPalabra.Name = "lblPalabra"
        Me.lblPalabra.Size = New System.Drawing.Size(109, 26)
        Me.lblPalabra.TabIndex = 1
        Me.lblPalabra.Text = "Aca abajo"
        Me.lblPalabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(69, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(69, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 277)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.25!, System.Drawing.FontStyle.Bold)
        Me.lbl1.Location = New System.Drawing.Point(218, 74)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(78, 70)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "O"
        Me.lbl1.Visible = False
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Black
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.25!, System.Drawing.FontStyle.Bold)
        Me.lbl2.Location = New System.Drawing.Point(252, 134)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(10, 106)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Visible = False
        '
        'lbl6
        '
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.25!, System.Drawing.FontStyle.Bold)
        Me.lbl6.Location = New System.Drawing.Point(264, 225)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(32, 70)
        Me.lbl6.TabIndex = 8
        Me.lbl6.Text = "\"
        Me.lbl6.Visible = False
        '
        'lbl4
        '
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.25!, System.Drawing.FontStyle.Bold)
        Me.lbl4.Location = New System.Drawing.Point(268, 134)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(31, 70)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "\"
        Me.lbl4.Visible = False
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.25!, System.Drawing.FontStyle.Bold)
        Me.lbl3.Location = New System.Drawing.Point(210, 134)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(42, 70)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "/"
        Me.lbl3.Visible = False
        '
        'lbl5
        '
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.25!, System.Drawing.FontStyle.Bold)
        Me.lbl5.Location = New System.Drawing.Point(210, 225)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(42, 70)
        Me.lbl5.TabIndex = 11
        Me.lbl5.Text = "/"
        Me.lbl5.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSalir.Location = New System.Drawing.Point(375, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 22)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtLetra
        '
        Me.txtLetra.Location = New System.Drawing.Point(346, 464)
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(35, 20)
        Me.txtLetra.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "LETRA:"
        '
        'btnJugada
        '
        Me.btnJugada.Location = New System.Drawing.Point(387, 462)
        Me.btnJugada.Name = "btnJugada"
        Me.btnJugada.Size = New System.Drawing.Size(37, 23)
        Me.btnJugada.TabIndex = 15
        Me.btnJugada.Text = "Ok"
        Me.btnJugada.UseVisualStyleBackColor = True
        '
        'FormAhorcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 509)
        Me.Controls.Add(Me.btnJugada)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLetra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPalabra)
        Me.Controls.Add(Me.lblLetrasUsadas)
        Me.Name = "FormAhorcado"
        Me.Text = "Ahorcado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLetrasUsadas As Label
    Friend WithEvents lblPalabra As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtLetra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnJugada As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEmpleado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BModEmpleado = New System.Windows.Forms.Button()
        Me.TBCorreoEmpleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBDireccionEmpleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTelEmpleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDniEmpleado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(214, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Modificar Empleado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.BModEmpleado)
        Me.Panel1.Controls.Add(Me.TBCorreoEmpleado)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TBDireccionEmpleado)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TBTelEmpleado)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TBDniEmpleado)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TBApellidoEmpleado)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TBNombreEmpleado)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(238, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 340)
        Me.Panel1.TabIndex = 3
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.Sienna
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(37, 268)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(106, 38)
        Me.BCancelar.TabIndex = 18
        Me.BCancelar.Text = "Volver"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BModEmpleado
        '
        Me.BModEmpleado.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BModEmpleado.FlatAppearance.BorderSize = 2
        Me.BModEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModEmpleado.Font = New System.Drawing.Font("Cooper Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModEmpleado.ForeColor = System.Drawing.Color.White
        Me.BModEmpleado.Location = New System.Drawing.Point(166, 268)
        Me.BModEmpleado.Name = "BModEmpleado"
        Me.BModEmpleado.Size = New System.Drawing.Size(133, 38)
        Me.BModEmpleado.TabIndex = 17
        Me.BModEmpleado.Text = "Modificar"
        Me.BModEmpleado.UseVisualStyleBackColor = False
        '
        'TBCorreoEmpleado
        '
        Me.TBCorreoEmpleado.Location = New System.Drawing.Point(160, 209)
        Me.TBCorreoEmpleado.Name = "TBCorreoEmpleado"
        Me.TBCorreoEmpleado.Size = New System.Drawing.Size(128, 20)
        Me.TBCorreoEmpleado.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(35, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "E-mail :"
        '
        'TBDireccionEmpleado
        '
        Me.TBDireccionEmpleado.Location = New System.Drawing.Point(160, 173)
        Me.TBDireccionEmpleado.Name = "TBDireccionEmpleado"
        Me.TBDireccionEmpleado.Size = New System.Drawing.Size(128, 20)
        Me.TBDireccionEmpleado.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dirección :"
        '
        'TBTelEmpleado
        '
        Me.TBTelEmpleado.Location = New System.Drawing.Point(160, 136)
        Me.TBTelEmpleado.Name = "TBTelEmpleado"
        Me.TBTelEmpleado.Size = New System.Drawing.Size(128, 20)
        Me.TBTelEmpleado.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(35, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono :"
        '
        'TBDniEmpleado
        '
        Me.TBDniEmpleado.Location = New System.Drawing.Point(160, 98)
        Me.TBDniEmpleado.Name = "TBDniEmpleado"
        Me.TBDniEmpleado.Size = New System.Drawing.Size(128, 20)
        Me.TBDniEmpleado.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DNI :"
        '
        'TBApellidoEmpleado
        '
        Me.TBApellidoEmpleado.Location = New System.Drawing.Point(160, 59)
        Me.TBApellidoEmpleado.Name = "TBApellidoEmpleado"
        Me.TBApellidoEmpleado.Size = New System.Drawing.Size(128, 20)
        Me.TBApellidoEmpleado.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido :"
        '
        'TBNombreEmpleado
        '
        Me.TBNombreEmpleado.Location = New System.Drawing.Point(160, 20)
        Me.TBNombreEmpleado.Name = "TBNombreEmpleado"
        Me.TBNombreEmpleado.Size = New System.Drawing.Size(128, 20)
        Me.TBNombreEmpleado.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre :"
        '
        'ModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarEmpleado"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BCancelar As Button
    Friend WithEvents BModEmpleado As Button
    Friend WithEvents TBCorreoEmpleado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBDireccionEmpleado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTelEmpleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBDniEmpleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBApellidoEmpleado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNombreEmpleado As TextBox
    Friend WithEvents Label2 As Label
End Class

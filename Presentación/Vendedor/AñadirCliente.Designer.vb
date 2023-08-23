<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.TBCorreoCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTelCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControlRegClientes = New System.Windows.Forms.TabControl()
        Me.TabPageListaClientes = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroClientes = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.TabControlRegClientes.SuspendLayout()
        Me.TabPageListaClientes.SuspendLayout()
        CType(Me.DataGridViewRegistroClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.BVolver)
        Me.Panel1.Controls.Add(Me.BRegistrarCliente)
        Me.Panel1.Controls.Add(Me.TBCorreoCliente)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TBDireccion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TBTelCliente)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TBDniCliente)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TBApellidoCliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TBNombreCliente)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(45, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 340)
        Me.Panel1.TabIndex = 0
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(37, 268)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 18
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BRegistrarCliente.FlatAppearance.BorderSize = 2
        Me.BRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCliente.Font = New System.Drawing.Font("Cooper Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.Cornsilk
        Me.BRegistrarCliente.Location = New System.Drawing.Point(166, 268)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(122, 38)
        Me.BRegistrarCliente.TabIndex = 17
        Me.BRegistrarCliente.Text = "Añadir"
        Me.BRegistrarCliente.UseVisualStyleBackColor = False
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Location = New System.Drawing.Point(160, 209)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(128, 20)
        Me.TBCorreoCliente.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(35, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "E-mail :"
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(160, 173)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(128, 20)
        Me.TBDireccion.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(35, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dirección :"
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Location = New System.Drawing.Point(160, 136)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(128, 20)
        Me.TBTelCliente.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(35, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono :"
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Location = New System.Drawing.Point(160, 98)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(128, 20)
        Me.TBDniCliente.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(35, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DNI :"
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Location = New System.Drawing.Point(160, 59)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(128, 20)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(35, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido :"
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Location = New System.Drawing.Point(160, 20)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(128, 20)
        Me.TBNombreCliente.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(35, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cornsilk
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registrar Cliente"
        '
        'TabControlRegClientes
        '
        Me.TabControlRegClientes.Controls.Add(Me.TabPageListaClientes)
        Me.TabControlRegClientes.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegClientes.Location = New System.Drawing.Point(454, 58)
        Me.TabControlRegClientes.Name = "TabControlRegClientes"
        Me.TabControlRegClientes.SelectedIndex = 0
        Me.TabControlRegClientes.Size = New System.Drawing.Size(317, 361)
        Me.TabControlRegClientes.TabIndex = 2
        '
        'TabPageListaClientes
        '
        Me.TabPageListaClientes.Controls.Add(Me.DataGridViewRegistroClientes)
        Me.TabPageListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPageListaClientes.Location = New System.Drawing.Point(4, 26)
        Me.TabPageListaClientes.Name = "TabPageListaClientes"
        Me.TabPageListaClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaClientes.Size = New System.Drawing.Size(309, 331)
        Me.TabPageListaClientes.TabIndex = 0
        Me.TabPageListaClientes.Text = "Lista de Clientes"
        Me.TabPageListaClientes.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroClientes
        '
        Me.DataGridViewRegistroClientes.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.DataGridViewRegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRegistroClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroClientes.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroClientes.Name = "DataGridViewRegistroClientes"
        Me.DataGridViewRegistroClientes.Size = New System.Drawing.Size(303, 325)
        Me.DataGridViewRegistroClientes.TabIndex = 0
        '
        'AñadirCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControlRegClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirCliente"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControlRegClientes.ResumeLayout(False)
        Me.TabPageListaClientes.ResumeLayout(False)
        CType(Me.DataGridViewRegistroClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCorreoCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTelCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBDniCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BRegistrarCliente As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TabControlRegClientes As TabControl
    Friend WithEvents TabPageListaClientes As TabPage
    Friend WithEvents DataGridViewRegistroClientes As DataGridView
End Class

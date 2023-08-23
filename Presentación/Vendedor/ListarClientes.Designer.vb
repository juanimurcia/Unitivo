<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarClientes
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
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.ComboBoxBuscarDni = New System.Windows.Forms.ComboBox()
        Me.TabControlListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPageListaClientes = New System.Windows.Forms.TabPage()
        Me.dgvListarClientes = New System.Windows.Forms.DataGridView()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BEditarCliente = New System.Windows.Forms.Button()
        Me.BImprimirClientes = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GroupBoxClientes.SuspendLayout()
        Me.TabControlListaClientes.SuspendLayout()
        Me.TabPageListaClientes.SuspendLayout()
        CType(Me.dgvListarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBoxClientes.Controls.Add(Me.BBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.TBBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.ComboBoxBuscarDni)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxClientes.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBoxClientes.Location = New System.Drawing.Point(156, 33)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(463, 100)
        Me.GroupBoxClientes.TabIndex = 0
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(195, 45)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(166, 32)
        Me.TBBuscar.TabIndex = 1
        '
        'ComboBoxBuscarDni
        '
        Me.ComboBoxBuscarDni.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBuscarDni.ForeColor = System.Drawing.Color.SaddleBrown
        Me.ComboBoxBuscarDni.FormattingEnabled = True
        Me.ComboBoxBuscarDni.Location = New System.Drawing.Point(44, 47)
        Me.ComboBoxBuscarDni.Name = "ComboBoxBuscarDni"
        Me.ComboBoxBuscarDni.Size = New System.Drawing.Size(121, 27)
        Me.ComboBoxBuscarDni.TabIndex = 0
        Me.ComboBoxBuscarDni.Text = "DNI"
        '
        'TabControlListaClientes
        '
        Me.TabControlListaClientes.Controls.Add(Me.TabPageListaClientes)
        Me.TabControlListaClientes.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaClientes.Location = New System.Drawing.Point(96, 165)
        Me.TabControlListaClientes.Name = "TabControlListaClientes"
        Me.TabControlListaClientes.SelectedIndex = 0
        Me.TabControlListaClientes.Size = New System.Drawing.Size(585, 215)
        Me.TabControlListaClientes.TabIndex = 1
        '
        'TabPageListaClientes
        '
        Me.TabPageListaClientes.Controls.Add(Me.dgvListarClientes)
        Me.TabPageListaClientes.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaClientes.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaClientes.Name = "TabPageListaClientes"
        Me.TabPageListaClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaClientes.Size = New System.Drawing.Size(577, 186)
        Me.TabPageListaClientes.TabIndex = 0
        Me.TabPageListaClientes.Text = "Lista de Clientes"
        Me.TabPageListaClientes.UseVisualStyleBackColor = True
        '
        'dgvListarClientes
        '
        Me.dgvListarClientes.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarClientes.Location = New System.Drawing.Point(3, 3)
        Me.dgvListarClientes.Name = "dgvListarClientes"
        Me.dgvListarClientes.Size = New System.Drawing.Size(571, 180)
        Me.dgvListarClientes.TabIndex = 0
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(575, 396)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 19
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BEditarCliente
        '
        Me.BEditarCliente.BackColor = System.Drawing.Color.Goldenrod
        Me.BEditarCliente.ForeColor = System.Drawing.Color.White
        Me.BEditarCliente.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BEditarCliente.Location = New System.Drawing.Point(697, 311)
        Me.BEditarCliente.Name = "BEditarCliente"
        Me.BEditarCliente.Size = New System.Drawing.Size(50, 45)
        Me.BEditarCliente.TabIndex = 4
        Me.BEditarCliente.UseVisualStyleBackColor = False
        '
        'BImprimirClientes
        '
        Me.BImprimirClientes.BackColor = System.Drawing.Color.SteelBlue
        Me.BImprimirClientes.ForeColor = System.Drawing.Color.White
        Me.BImprimirClientes.Image = Global.Unitivo.My.Resources.Resources.icons8_imprimir_26
        Me.BImprimirClientes.Location = New System.Drawing.Point(697, 244)
        Me.BImprimirClientes.Name = "BImprimirClientes"
        Me.BImprimirClientes.Size = New System.Drawing.Size(50, 45)
        Me.BImprimirClientes.TabIndex = 3
        Me.BImprimirClientes.UseVisualStyleBackColor = False
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscar.Location = New System.Drawing.Point(388, 41)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(45, 40)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'ListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BEditarCliente)
        Me.Controls.Add(Me.BImprimirClientes)
        Me.Controls.Add(Me.TabControlListaClientes)
        Me.Controls.Add(Me.GroupBoxClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarClientes"
        Me.Text = "Form1"
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        Me.TabControlListaClientes.ResumeLayout(False)
        Me.TabPageListaClientes.ResumeLayout(False)
        CType(Me.dgvListarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents ComboBoxBuscarDni As ComboBox
    Friend WithEvents TabControlListaClientes As TabControl
    Friend WithEvents TabPageListaClientes As TabPage
    Friend WithEvents dgvListarClientes As DataGridView
    Friend WithEvents BImprimirClientes As Button
    Friend WithEvents BEditarCliente As Button
    Friend WithEvents BVolver As Button
End Class

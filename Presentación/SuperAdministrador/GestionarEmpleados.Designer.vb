<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarEmpleados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxGestionUsuarios = New System.Windows.Forms.GroupBox()
        Me.BBuscarUsuario = New System.Windows.Forms.Button()
        Me.TBGestionUsuario = New System.Windows.Forms.TextBox()
        Me.TabListaEmpleados = New System.Windows.Forms.TabControl()
        Me.TabPageEmpleados = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.BModificarEmpleado = New System.Windows.Forms.Button()
        Me.BEliminarUsuario = New System.Windows.Forms.Button()
        Me.BAltaEmpleado = New System.Windows.Forms.Button()
        Me.GroupBoxGestionUsuarios.SuspendLayout()
        Me.TabListaEmpleados.SuspendLayout()
        Me.TabPageEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(590, 394)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 79
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GroupBoxGestionUsuarios
        '
        Me.GroupBoxGestionUsuarios.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BBuscarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.TBGestionUsuario)
        Me.GroupBoxGestionUsuarios.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionUsuarios.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBoxGestionUsuarios.Location = New System.Drawing.Point(248, 18)
        Me.GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios"
        Me.GroupBoxGestionUsuarios.Size = New System.Drawing.Size(323, 87)
        Me.GroupBoxGestionUsuarios.TabIndex = 78
        Me.GroupBoxGestionUsuarios.TabStop = False
        Me.GroupBoxGestionUsuarios.Text = "Gestión de Empleados"
        '
        'BBuscarUsuario
        '
        Me.BBuscarUsuario.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarUsuario.FlatAppearance.BorderSize = 2
        Me.BBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarUsuario.ForeColor = System.Drawing.Color.White
        Me.BBuscarUsuario.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarUsuario.Location = New System.Drawing.Point(210, 34)
        Me.BBuscarUsuario.Name = "BBuscarUsuario"
        Me.BBuscarUsuario.Size = New System.Drawing.Size(45, 41)
        Me.BBuscarUsuario.TabIndex = 14
        Me.BBuscarUsuario.UseVisualStyleBackColor = False
        '
        'TBGestionUsuario
        '
        Me.TBGestionUsuario.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionUsuario.Location = New System.Drawing.Point(55, 43)
        Me.TBGestionUsuario.Name = "TBGestionUsuario"
        Me.TBGestionUsuario.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionUsuario.TabIndex = 6
        '
        'TabListaEmpleados
        '
        Me.TabListaEmpleados.Controls.Add(Me.TabPageEmpleados)
        Me.TabListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaEmpleados.Location = New System.Drawing.Point(27, 110)
        Me.TabListaEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaEmpleados.Name = "TabListaEmpleados"
        Me.TabListaEmpleados.SelectedIndex = 0
        Me.TabListaEmpleados.Size = New System.Drawing.Size(669, 269)
        Me.TabListaEmpleados.TabIndex = 77
        '
        'TabPageEmpleados
        '
        Me.TabPageEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.TabPageEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageEmpleados.ForeColor = System.Drawing.Color.White
        Me.TabPageEmpleados.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageEmpleados.Name = "TabPageEmpleados"
        Me.TabPageEmpleados.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageEmpleados.Size = New System.Drawing.Size(661, 240)
        Me.TabPageEmpleados.TabIndex = 0
        Me.TabPageEmpleados.Text = "Lista de Empleados"
        Me.TabPageEmpleados.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpleados.ColumnHeadersHeight = 20
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.Location = New System.Drawing.Point(2, 2)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEmpleados.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpleados.Size = New System.Drawing.Size(657, 236)
        Me.dgvEmpleados.TabIndex = 2
        '
        'BModificarEmpleado
        '
        Me.BModificarEmpleado.BackColor = System.Drawing.Color.SteelBlue
        Me.BModificarEmpleado.ForeColor = System.Drawing.Color.White
        Me.BModificarEmpleado.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BModificarEmpleado.Location = New System.Drawing.Point(724, 204)
        Me.BModificarEmpleado.Name = "BModificarEmpleado"
        Me.BModificarEmpleado.Size = New System.Drawing.Size(50, 45)
        Me.BModificarEmpleado.TabIndex = 76
        Me.BModificarEmpleado.UseVisualStyleBackColor = False
        '
        'BEliminarUsuario
        '
        Me.BEliminarUsuario.BackColor = System.Drawing.Color.Brown
        Me.BEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.BEliminarUsuario.Image = Global.Unitivo.My.Resources.Resources.icons8_basura_26
        Me.BEliminarUsuario.Location = New System.Drawing.Point(724, 265)
        Me.BEliminarUsuario.Name = "BEliminarUsuario"
        Me.BEliminarUsuario.Size = New System.Drawing.Size(50, 45)
        Me.BEliminarUsuario.TabIndex = 75
        Me.BEliminarUsuario.UseVisualStyleBackColor = False
        '
        'BAltaEmpleado
        '
        Me.BAltaEmpleado.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BAltaEmpleado.ForeColor = System.Drawing.Color.White
        Me.BAltaEmpleado.Image = Global.Unitivo.My.Resources.Resources.icons8_más_2_matemáticas_30
        Me.BAltaEmpleado.Location = New System.Drawing.Point(724, 265)
        Me.BAltaEmpleado.Name = "BAltaEmpleado"
        Me.BAltaEmpleado.Size = New System.Drawing.Size(50, 45)
        Me.BAltaEmpleado.TabIndex = 80
        Me.BAltaEmpleado.UseVisualStyleBackColor = False
        '
        'GestionarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionUsuarios)
        Me.Controls.Add(Me.TabListaEmpleados)
        Me.Controls.Add(Me.BModificarEmpleado)
        Me.Controls.Add(Me.BEliminarUsuario)
        Me.Controls.Add(Me.BAltaEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarEmpleados"
        Me.Text = "Form1"
        Me.GroupBoxGestionUsuarios.ResumeLayout(False)
        Me.GroupBoxGestionUsuarios.PerformLayout()
        Me.TabListaEmpleados.ResumeLayout(False)
        Me.TabPageEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents GroupBoxGestionUsuarios As GroupBox
    Friend WithEvents BBuscarUsuario As Button
    Friend WithEvents TBGestionUsuario As TextBox
    Friend WithEvents TabListaEmpleados As TabControl
    Friend WithEvents TabPageEmpleados As TabPage
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents BModificarEmpleado As Button
    Friend WithEvents BEliminarUsuario As Button
    Friend WithEvents BAltaEmpleado As Button
End Class

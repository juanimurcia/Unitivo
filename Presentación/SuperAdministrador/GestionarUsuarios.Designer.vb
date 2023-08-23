<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarUsuarios
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BModificarUsuario = New System.Windows.Forms.Button()
        Me.BEliminarUsuario = New System.Windows.Forms.Button()
        Me.GroupBoxGestionUsuarios = New System.Windows.Forms.GroupBox()
        Me.BBuscarUsuario = New System.Windows.Forms.Button()
        Me.TBGestionUsuario = New System.Windows.Forms.TextBox()
        Me.TabListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPageUsuarios = New System.Windows.Forms.TabPage()
        Me.dgvListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxGestionUsuarios.SuspendLayout()
        Me.TabListaClientes.SuspendLayout()
        Me.TabPageUsuarios.SuspendLayout()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BModificarUsuario
        '
        Me.BModificarUsuario.BackColor = System.Drawing.Color.SteelBlue
        Me.BModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.BModificarUsuario.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BModificarUsuario.Location = New System.Drawing.Point(724, 223)
        Me.BModificarUsuario.Name = "BModificarUsuario"
        Me.BModificarUsuario.Size = New System.Drawing.Size(50, 45)
        Me.BModificarUsuario.TabIndex = 71
        Me.BModificarUsuario.UseVisualStyleBackColor = False
        '
        'BEliminarUsuario
        '
        Me.BEliminarUsuario.BackColor = System.Drawing.Color.Brown
        Me.BEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.BEliminarUsuario.Image = Global.Unitivo.My.Resources.Resources.icons8_basura_26
        Me.BEliminarUsuario.Location = New System.Drawing.Point(724, 284)
        Me.BEliminarUsuario.Name = "BEliminarUsuario"
        Me.BEliminarUsuario.Size = New System.Drawing.Size(50, 45)
        Me.BEliminarUsuario.TabIndex = 70
        Me.BEliminarUsuario.UseVisualStyleBackColor = False
        '
        'GroupBoxGestionUsuarios
        '
        Me.GroupBoxGestionUsuarios.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BBuscarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.TBGestionUsuario)
        Me.GroupBoxGestionUsuarios.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionUsuarios.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBoxGestionUsuarios.Location = New System.Drawing.Point(248, 37)
        Me.GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios"
        Me.GroupBoxGestionUsuarios.Size = New System.Drawing.Size(261, 76)
        Me.GroupBoxGestionUsuarios.TabIndex = 73
        Me.GroupBoxGestionUsuarios.TabStop = False
        Me.GroupBoxGestionUsuarios.Text = "Gestión de Usuarios"
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
        Me.BBuscarUsuario.Location = New System.Drawing.Point(186, 26)
        Me.BBuscarUsuario.Name = "BBuscarUsuario"
        Me.BBuscarUsuario.Size = New System.Drawing.Size(45, 41)
        Me.BBuscarUsuario.TabIndex = 14
        Me.BBuscarUsuario.UseVisualStyleBackColor = False
        '
        'TBGestionUsuario
        '
        Me.TBGestionUsuario.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionUsuario.Location = New System.Drawing.Point(31, 35)
        Me.TBGestionUsuario.Name = "TBGestionUsuario"
        Me.TBGestionUsuario.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionUsuario.TabIndex = 6
        '
        'TabListaClientes
        '
        Me.TabListaClientes.Controls.Add(Me.TabPageUsuarios)
        Me.TabListaClientes.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaClientes.Location = New System.Drawing.Point(27, 129)
        Me.TabListaClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaClientes.Name = "TabListaClientes"
        Me.TabListaClientes.SelectedIndex = 0
        Me.TabListaClientes.Size = New System.Drawing.Size(669, 269)
        Me.TabListaClientes.TabIndex = 72
        '
        'TabPageUsuarios
        '
        Me.TabPageUsuarios.Controls.Add(Me.dgvListaUsuarios)
        Me.TabPageUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageUsuarios.ForeColor = System.Drawing.Color.White
        Me.TabPageUsuarios.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageUsuarios.Name = "TabPageUsuarios"
        Me.TabPageUsuarios.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageUsuarios.Size = New System.Drawing.Size(661, 240)
        Me.TabPageUsuarios.TabIndex = 0
        Me.TabPageUsuarios.Text = "Lista de Usuarios"
        Me.TabPageUsuarios.UseVisualStyleBackColor = True
        '
        'dgvListaUsuarios
        '
        Me.dgvListaUsuarios.AllowUserToAddRows = False
        Me.dgvListaUsuarios.AllowUserToDeleteRows = False
        Me.dgvListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvListaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaUsuarios.ColumnHeadersHeight = 20
        Me.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaUsuarios.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaUsuarios.EnableHeadersVisualStyles = False
        Me.dgvListaUsuarios.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaUsuarios.Name = "dgvListaUsuarios"
        Me.dgvListaUsuarios.ReadOnly = True
        Me.dgvListaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListaUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgvListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListaUsuarios.Size = New System.Drawing.Size(657, 236)
        Me.dgvListaUsuarios.TabIndex = 2
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(590, 413)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 74
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GestionarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionUsuarios)
        Me.Controls.Add(Me.TabListaClientes)
        Me.Controls.Add(Me.BModificarUsuario)
        Me.Controls.Add(Me.BEliminarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarUsuarios"
        Me.Text = "Form1"
        Me.GroupBoxGestionUsuarios.ResumeLayout(False)
        Me.GroupBoxGestionUsuarios.PerformLayout()
        Me.TabListaClientes.ResumeLayout(False)
        Me.TabPageUsuarios.ResumeLayout(False)
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BModificarUsuario As Button
    Friend WithEvents BEliminarUsuario As Button
    Friend WithEvents GroupBoxGestionUsuarios As GroupBox
    Friend WithEvents BBuscarUsuario As Button
    Friend WithEvents TBGestionUsuario As TextBox
    Friend WithEvents TabListaClientes As TabControl
    Friend WithEvents TabPageUsuarios As TabPage
    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents BVolver As Button
End Class

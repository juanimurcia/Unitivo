<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarPerfiles
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxGestionPerfil = New System.Windows.Forms.GroupBox()
        Me.BBuscarPerfil = New System.Windows.Forms.Button()
        Me.TBGestionPerfil = New System.Windows.Forms.TextBox()
        Me.TabListaPerfiles = New System.Windows.Forms.TabControl()
        Me.TabPagePerfiles = New System.Windows.Forms.TabPage()
        Me.dgvPerfiles = New System.Windows.Forms.DataGridView()
        Me.BModificarPerfiles = New System.Windows.Forms.Button()
        Me.BEliminarPerfiles = New System.Windows.Forms.Button()
        Me.BAltaPerfil = New System.Windows.Forms.Button()
        Me.GroupBoxGestionPerfil.SuspendLayout()
        Me.TabListaPerfiles.SuspendLayout()
        Me.TabPagePerfiles.SuspendLayout()
        CType(Me.dgvPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BVolver.TabIndex = 85
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GroupBoxGestionPerfil
        '
        Me.GroupBoxGestionPerfil.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxGestionPerfil.Controls.Add(Me.BBuscarPerfil)
        Me.GroupBoxGestionPerfil.Controls.Add(Me.TBGestionPerfil)
        Me.GroupBoxGestionPerfil.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionPerfil.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBoxGestionPerfil.Location = New System.Drawing.Point(248, 12)
        Me.GroupBoxGestionPerfil.Name = "GroupBoxGestionPerfil"
        Me.GroupBoxGestionPerfil.Size = New System.Drawing.Size(305, 93)
        Me.GroupBoxGestionPerfil.TabIndex = 84
        Me.GroupBoxGestionPerfil.TabStop = False
        Me.GroupBoxGestionPerfil.Text = "Gestión de Perfiles"
        '
        'BBuscarPerfil
        '
        Me.BBuscarPerfil.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarPerfil.FlatAppearance.BorderSize = 2
        Me.BBuscarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarPerfil.ForeColor = System.Drawing.Color.White
        Me.BBuscarPerfil.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarPerfil.Location = New System.Drawing.Point(212, 37)
        Me.BBuscarPerfil.Name = "BBuscarPerfil"
        Me.BBuscarPerfil.Size = New System.Drawing.Size(45, 41)
        Me.BBuscarPerfil.TabIndex = 14
        Me.BBuscarPerfil.UseVisualStyleBackColor = False
        '
        'TBGestionPerfil
        '
        Me.TBGestionPerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionPerfil.Location = New System.Drawing.Point(57, 46)
        Me.TBGestionPerfil.Name = "TBGestionPerfil"
        Me.TBGestionPerfil.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionPerfil.TabIndex = 6
        '
        'TabListaPerfiles
        '
        Me.TabListaPerfiles.Controls.Add(Me.TabPagePerfiles)
        Me.TabListaPerfiles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaPerfiles.Location = New System.Drawing.Point(27, 110)
        Me.TabListaPerfiles.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaPerfiles.Name = "TabListaPerfiles"
        Me.TabListaPerfiles.SelectedIndex = 0
        Me.TabListaPerfiles.Size = New System.Drawing.Size(669, 269)
        Me.TabListaPerfiles.TabIndex = 83
        '
        'TabPagePerfiles
        '
        Me.TabPagePerfiles.Controls.Add(Me.dgvPerfiles)
        Me.TabPagePerfiles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPagePerfiles.ForeColor = System.Drawing.Color.White
        Me.TabPagePerfiles.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePerfiles.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPagePerfiles.Name = "TabPagePerfiles"
        Me.TabPagePerfiles.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPagePerfiles.Size = New System.Drawing.Size(661, 240)
        Me.TabPagePerfiles.TabIndex = 0
        Me.TabPagePerfiles.Text = "Lista de Perfiles"
        Me.TabPagePerfiles.UseVisualStyleBackColor = True
        '
        'dgvPerfiles
        '
        Me.dgvPerfiles.AllowUserToAddRows = False
        Me.dgvPerfiles.AllowUserToDeleteRows = False
        Me.dgvPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPerfiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPerfiles.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvPerfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPerfiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPerfiles.ColumnHeadersHeight = 20
        Me.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPerfiles.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPerfiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPerfiles.EnableHeadersVisualStyles = False
        Me.dgvPerfiles.Location = New System.Drawing.Point(2, 2)
        Me.dgvPerfiles.Name = "dgvPerfiles"
        Me.dgvPerfiles.ReadOnly = True
        Me.dgvPerfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPerfiles.RowHeadersWidth = 51
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvPerfiles.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPerfiles.Size = New System.Drawing.Size(657, 236)
        Me.dgvPerfiles.TabIndex = 2
        '
        'BModificarPerfiles
        '
        Me.BModificarPerfiles.BackColor = System.Drawing.Color.SteelBlue
        Me.BModificarPerfiles.ForeColor = System.Drawing.Color.White
        Me.BModificarPerfiles.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BModificarPerfiles.Location = New System.Drawing.Point(724, 204)
        Me.BModificarPerfiles.Name = "BModificarPerfiles"
        Me.BModificarPerfiles.Size = New System.Drawing.Size(50, 45)
        Me.BModificarPerfiles.TabIndex = 82
        Me.BModificarPerfiles.UseVisualStyleBackColor = False
        '
        'BEliminarPerfiles
        '
        Me.BEliminarPerfiles.BackColor = System.Drawing.Color.Brown
        Me.BEliminarPerfiles.ForeColor = System.Drawing.Color.White
        Me.BEliminarPerfiles.Image = Global.Unitivo.My.Resources.Resources.icons8_basura_26
        Me.BEliminarPerfiles.Location = New System.Drawing.Point(724, 265)
        Me.BEliminarPerfiles.Name = "BEliminarPerfiles"
        Me.BEliminarPerfiles.Size = New System.Drawing.Size(50, 45)
        Me.BEliminarPerfiles.TabIndex = 81
        Me.BEliminarPerfiles.UseVisualStyleBackColor = False
        '
        'BAltaPerfil
        '
        Me.BAltaPerfil.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BAltaPerfil.ForeColor = System.Drawing.Color.White
        Me.BAltaPerfil.Image = Global.Unitivo.My.Resources.Resources.icons8_más_2_matemáticas_30
        Me.BAltaPerfil.Location = New System.Drawing.Point(724, 265)
        Me.BAltaPerfil.Name = "BAltaPerfil"
        Me.BAltaPerfil.Size = New System.Drawing.Size(50, 45)
        Me.BAltaPerfil.TabIndex = 86
        Me.BAltaPerfil.UseVisualStyleBackColor = False
        '
        'GestionarPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionPerfil)
        Me.Controls.Add(Me.TabListaPerfiles)
        Me.Controls.Add(Me.BModificarPerfiles)
        Me.Controls.Add(Me.BEliminarPerfiles)
        Me.Controls.Add(Me.BAltaPerfil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarPerfiles"
        Me.Text = "Form1"
        Me.GroupBoxGestionPerfil.ResumeLayout(False)
        Me.GroupBoxGestionPerfil.PerformLayout()
        Me.TabListaPerfiles.ResumeLayout(False)
        Me.TabPagePerfiles.ResumeLayout(False)
        CType(Me.dgvPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents GroupBoxGestionPerfil As GroupBox
    Friend WithEvents BBuscarPerfil As Button
    Friend WithEvents TBGestionPerfil As TextBox
    Friend WithEvents TabListaPerfiles As TabControl
    Friend WithEvents TabPagePerfiles As TabPage
    Friend WithEvents dgvPerfiles As DataGridView
    Friend WithEvents BModificarPerfiles As Button
    Friend WithEvents BEliminarPerfiles As Button
    Friend WithEvents BAltaPerfil As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarCategorias
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxGestionCategorias = New System.Windows.Forms.GroupBox()
        Me.BBuscarCategoria = New System.Windows.Forms.Button()
        Me.TBGestionCategoria = New System.Windows.Forms.TextBox()
        Me.TabListaCategorias = New System.Windows.Forms.TabControl()
        Me.TabPageListaCategorias = New System.Windows.Forms.TabPage()
        Me.dgvListarCategorias = New System.Windows.Forms.DataGridView()
        Me.BEditarCategoria = New System.Windows.Forms.Button()
        Me.BEliminarCategoria = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BAltaCategoria = New System.Windows.Forms.Button()
        Me.GroupBoxGestionCategorias.SuspendLayout()
        Me.TabListaCategorias.SuspendLayout()
        Me.TabPageListaCategorias.SuspendLayout()
        CType(Me.dgvListarCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxGestionCategorias
        '
        Me.GroupBoxGestionCategorias.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxGestionCategorias.Controls.Add(Me.BBuscarCategoria)
        Me.GroupBoxGestionCategorias.Controls.Add(Me.TBGestionCategoria)
        Me.GroupBoxGestionCategorias.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionCategorias.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBoxGestionCategorias.Location = New System.Drawing.Point(255, 30)
        Me.GroupBoxGestionCategorias.Name = "GroupBoxGestionCategorias"
        Me.GroupBoxGestionCategorias.Size = New System.Drawing.Size(319, 99)
        Me.GroupBoxGestionCategorias.TabIndex = 27
        Me.GroupBoxGestionCategorias.TabStop = False
        Me.GroupBoxGestionCategorias.Text = "Gestión de Categorias"
        '
        'BBuscarCategoria
        '
        Me.BBuscarCategoria.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarCategoria.FlatAppearance.BorderSize = 2
        Me.BBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCategoria.ForeColor = System.Drawing.Color.White
        Me.BBuscarCategoria.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarCategoria.Location = New System.Drawing.Point(214, 39)
        Me.BBuscarCategoria.Name = "BBuscarCategoria"
        Me.BBuscarCategoria.Size = New System.Drawing.Size(49, 41)
        Me.BBuscarCategoria.TabIndex = 14
        Me.BBuscarCategoria.UseVisualStyleBackColor = False
        '
        'TBGestionCategoria
        '
        Me.TBGestionCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionCategoria.Location = New System.Drawing.Point(49, 49)
        Me.TBGestionCategoria.Name = "TBGestionCategoria"
        Me.TBGestionCategoria.Size = New System.Drawing.Size(148, 25)
        Me.TBGestionCategoria.TabIndex = 6
        '
        'TabListaCategorias
        '
        Me.TabListaCategorias.Controls.Add(Me.TabPageListaCategorias)
        Me.TabListaCategorias.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaCategorias.Location = New System.Drawing.Point(21, 144)
        Me.TabListaCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaCategorias.Name = "TabListaCategorias"
        Me.TabListaCategorias.SelectedIndex = 0
        Me.TabListaCategorias.Size = New System.Drawing.Size(688, 301)
        Me.TabListaCategorias.TabIndex = 26
        '
        'TabPageListaCategorias
        '
        Me.TabPageListaCategorias.Controls.Add(Me.dgvListarCategorias)
        Me.TabPageListaCategorias.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaCategorias.ForeColor = System.Drawing.Color.White
        Me.TabPageListaCategorias.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaCategorias.Name = "TabPageListaCategorias"
        Me.TabPageListaCategorias.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaCategorias.Size = New System.Drawing.Size(680, 272)
        Me.TabPageListaCategorias.TabIndex = 0
        Me.TabPageListaCategorias.Text = "Lista de Categorias"
        Me.TabPageListaCategorias.UseVisualStyleBackColor = True
        '
        'dgvListarCategorias
        '
        Me.dgvListarCategorias.AllowUserToAddRows = False
        Me.dgvListarCategorias.AllowUserToDeleteRows = False
        Me.dgvListarCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarCategorias.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvListarCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarCategorias.ColumnHeadersHeight = 20
        Me.dgvListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarCategorias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListarCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarCategorias.EnableHeadersVisualStyles = False
        Me.dgvListarCategorias.Location = New System.Drawing.Point(2, 2)
        Me.dgvListarCategorias.Name = "dgvListarCategorias"
        Me.dgvListarCategorias.ReadOnly = True
        Me.dgvListarCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarCategorias.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvListarCategorias.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarCategorias.Size = New System.Drawing.Size(676, 268)
        Me.dgvListarCategorias.TabIndex = 3
        '
        'BEditarCategoria
        '
        Me.BEditarCategoria.BackColor = System.Drawing.Color.SteelBlue
        Me.BEditarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BEditarCategoria.FlatAppearance.BorderSize = 2
        Me.BEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEditarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditarCategoria.ForeColor = System.Drawing.Color.White
        Me.BEditarCategoria.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BEditarCategoria.Location = New System.Drawing.Point(730, 263)
        Me.BEditarCategoria.Name = "BEditarCategoria"
        Me.BEditarCategoria.Size = New System.Drawing.Size(50, 45)
        Me.BEditarCategoria.TabIndex = 25
        Me.BEditarCategoria.UseVisualStyleBackColor = False
        '
        'BEliminarCategoria
        '
        Me.BEliminarCategoria.BackColor = System.Drawing.Color.Brown
        Me.BEliminarCategoria.FlatAppearance.BorderSize = 2
        Me.BEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarCategoria.ForeColor = System.Drawing.Color.White
        Me.BEliminarCategoria.Image = Global.Unitivo.My.Resources.Resources.icons8_basura_26
        Me.BEliminarCategoria.Location = New System.Drawing.Point(730, 339)
        Me.BEliminarCategoria.Name = "BEliminarCategoria"
        Me.BEliminarCategoria.Size = New System.Drawing.Size(50, 45)
        Me.BEliminarCategoria.TabIndex = 24
        Me.BEliminarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarCategoria.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(603, 472)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 81
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BAltaCategoria
        '
        Me.BAltaCategoria.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BAltaCategoria.ForeColor = System.Drawing.Color.White
        Me.BAltaCategoria.Image = Global.Unitivo.My.Resources.Resources.icons8_más_2_matemáticas_30
        Me.BAltaCategoria.Location = New System.Drawing.Point(730, 339)
        Me.BAltaCategoria.Name = "BAltaCategoria"
        Me.BAltaCategoria.Size = New System.Drawing.Size(50, 45)
        Me.BAltaCategoria.TabIndex = 87
        Me.BAltaCategoria.UseVisualStyleBackColor = False
        '
        'GestionarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(810, 550)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionCategorias)
        Me.Controls.Add(Me.BEditarCategoria)
        Me.Controls.Add(Me.BEliminarCategoria)
        Me.Controls.Add(Me.TabListaCategorias)
        Me.Controls.Add(Me.BAltaCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarCategorias"
        Me.Text = "Form1"
        Me.GroupBoxGestionCategorias.ResumeLayout(False)
        Me.GroupBoxGestionCategorias.PerformLayout()
        Me.TabListaCategorias.ResumeLayout(False)
        Me.TabPageListaCategorias.ResumeLayout(False)
        CType(Me.dgvListarCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxGestionCategorias As GroupBox
    Friend WithEvents BBuscarCategoria As Button
    Friend WithEvents TBGestionCategoria As TextBox
    Friend WithEvents BEditarCategoria As Button
    Friend WithEvents BEliminarCategoria As Button
    Friend WithEvents TabListaCategorias As TabControl
    Friend WithEvents TabPageListaCategorias As TabPage
    Friend WithEvents dgvListarCategorias As DataGridView
    Friend WithEvents BVolver As Button
    Friend WithEvents BAltaCategoria As Button
End Class

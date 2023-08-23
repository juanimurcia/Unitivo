<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarTalles
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
        Me.GroupBoxGestionTalles = New System.Windows.Forms.GroupBox()
        Me.BBuscarTalle = New System.Windows.Forms.Button()
        Me.TBBuscarTalle = New System.Windows.Forms.TextBox()
        Me.BEditarTalle = New System.Windows.Forms.Button()
        Me.BEliminarTalle = New System.Windows.Forms.Button()
        Me.TabListaTalles = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalles = New System.Windows.Forms.TabPage()
        Me.dgvListarTalles = New System.Windows.Forms.DataGridView()
        Me.BAltaTalle = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxGestionTalles.SuspendLayout()
        Me.TabListaTalles.SuspendLayout()
        Me.TabPageListaTalles.SuspendLayout()
        CType(Me.dgvListarTalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxGestionTalles
        '
        Me.GroupBoxGestionTalles.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxGestionTalles.Controls.Add(Me.BBuscarTalle)
        Me.GroupBoxGestionTalles.Controls.Add(Me.TBBuscarTalle)
        Me.GroupBoxGestionTalles.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionTalles.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBoxGestionTalles.Location = New System.Drawing.Point(255, 27)
        Me.GroupBoxGestionTalles.Name = "GroupBoxGestionTalles"
        Me.GroupBoxGestionTalles.Size = New System.Drawing.Size(319, 99)
        Me.GroupBoxGestionTalles.TabIndex = 91
        Me.GroupBoxGestionTalles.TabStop = False
        Me.GroupBoxGestionTalles.Text = "Gestión de Talles"
        '
        'BBuscarTalle
        '
        Me.BBuscarTalle.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarTalle.FlatAppearance.BorderSize = 2
        Me.BBuscarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarTalle.ForeColor = System.Drawing.Color.White
        Me.BBuscarTalle.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarTalle.Location = New System.Drawing.Point(214, 39)
        Me.BBuscarTalle.Name = "BBuscarTalle"
        Me.BBuscarTalle.Size = New System.Drawing.Size(49, 41)
        Me.BBuscarTalle.TabIndex = 14
        Me.BBuscarTalle.UseVisualStyleBackColor = False
        '
        'TBBuscarTalle
        '
        Me.TBBuscarTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscarTalle.Location = New System.Drawing.Point(49, 49)
        Me.TBBuscarTalle.Name = "TBBuscarTalle"
        Me.TBBuscarTalle.Size = New System.Drawing.Size(148, 25)
        Me.TBBuscarTalle.TabIndex = 6
        '
        'BEditarTalle
        '
        Me.BEditarTalle.BackColor = System.Drawing.Color.SteelBlue
        Me.BEditarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BEditarTalle.FlatAppearance.BorderSize = 2
        Me.BEditarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEditarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditarTalle.ForeColor = System.Drawing.Color.White
        Me.BEditarTalle.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BEditarTalle.Location = New System.Drawing.Point(730, 260)
        Me.BEditarTalle.Name = "BEditarTalle"
        Me.BEditarTalle.Size = New System.Drawing.Size(50, 45)
        Me.BEditarTalle.TabIndex = 89
        Me.BEditarTalle.UseVisualStyleBackColor = False
        '
        'BEliminarTalle
        '
        Me.BEliminarTalle.BackColor = System.Drawing.Color.Brown
        Me.BEliminarTalle.FlatAppearance.BorderSize = 2
        Me.BEliminarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarTalle.ForeColor = System.Drawing.Color.White
        Me.BEliminarTalle.Image = Global.Unitivo.My.Resources.Resources.icons8_basura_26
        Me.BEliminarTalle.Location = New System.Drawing.Point(730, 336)
        Me.BEliminarTalle.Name = "BEliminarTalle"
        Me.BEliminarTalle.Size = New System.Drawing.Size(50, 45)
        Me.BEliminarTalle.TabIndex = 88
        Me.BEliminarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarTalle.UseVisualStyleBackColor = False
        '
        'TabListaTalles
        '
        Me.TabListaTalles.Controls.Add(Me.TabPageListaTalles)
        Me.TabListaTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaTalles.Location = New System.Drawing.Point(21, 141)
        Me.TabListaTalles.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaTalles.Name = "TabListaTalles"
        Me.TabListaTalles.SelectedIndex = 0
        Me.TabListaTalles.Size = New System.Drawing.Size(688, 301)
        Me.TabListaTalles.TabIndex = 90
        '
        'TabPageListaTalles
        '
        Me.TabPageListaTalles.Controls.Add(Me.dgvListarTalles)
        Me.TabPageListaTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalles.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalles.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaTalles.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalles.Name = "TabPageListaTalles"
        Me.TabPageListaTalles.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalles.Size = New System.Drawing.Size(680, 272)
        Me.TabPageListaTalles.TabIndex = 0
        Me.TabPageListaTalles.Text = "Lista de Talles"
        Me.TabPageListaTalles.UseVisualStyleBackColor = True
        '
        'dgvListarTalles
        '
        Me.dgvListarTalles.AllowUserToAddRows = False
        Me.dgvListarTalles.AllowUserToDeleteRows = False
        Me.dgvListarTalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarTalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarTalles.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvListarTalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarTalles.ColumnHeadersHeight = 20
        Me.dgvListarTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarTalles.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListarTalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarTalles.EnableHeadersVisualStyles = False
        Me.dgvListarTalles.Location = New System.Drawing.Point(2, 2)
        Me.dgvListarTalles.Name = "dgvListarTalles"
        Me.dgvListarTalles.ReadOnly = True
        Me.dgvListarTalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarTalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarTalles.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvListarTalles.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarTalles.Size = New System.Drawing.Size(676, 268)
        Me.dgvListarTalles.TabIndex = 3
        '
        'BAltaTalle
        '
        Me.BAltaTalle.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BAltaTalle.ForeColor = System.Drawing.Color.White
        Me.BAltaTalle.Image = Global.Unitivo.My.Resources.Resources.icons8_más_2_matemáticas_30
        Me.BAltaTalle.Location = New System.Drawing.Point(730, 336)
        Me.BAltaTalle.Name = "BAltaTalle"
        Me.BAltaTalle.Size = New System.Drawing.Size(50, 45)
        Me.BAltaTalle.TabIndex = 92
        Me.BAltaTalle.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(603, 468)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 93
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GestionarTalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(810, 550)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionTalles)
        Me.Controls.Add(Me.BEditarTalle)
        Me.Controls.Add(Me.BEliminarTalle)
        Me.Controls.Add(Me.TabListaTalles)
        Me.Controls.Add(Me.BAltaTalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarTalles"
        Me.Text = "Form1"
        Me.GroupBoxGestionTalles.ResumeLayout(False)
        Me.GroupBoxGestionTalles.PerformLayout()
        Me.TabListaTalles.ResumeLayout(False)
        Me.TabPageListaTalles.ResumeLayout(False)
        CType(Me.dgvListarTalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxGestionTalles As GroupBox
    Friend WithEvents BBuscarTalle As Button
    Friend WithEvents TBBuscarTalle As TextBox
    Friend WithEvents BEditarTalle As Button
    Friend WithEvents BEliminarTalle As Button
    Friend WithEvents TabListaTalles As TabControl
    Friend WithEvents TabPageListaTalles As TabPage
    Friend WithEvents dgvListarTalles As DataGridView
    Friend WithEvents BAltaTalle As Button
    Friend WithEvents BVolver As Button
End Class

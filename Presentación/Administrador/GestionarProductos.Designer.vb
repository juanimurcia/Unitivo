<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarProductos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxGestionProductos = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.TBGestionProductos = New System.Windows.Forms.TextBox()
        Me.TabListaCategorias = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.dgvListaProductos = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxGestionProductos.SuspendLayout()
        Me.TabListaCategorias.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxGestionProductos
        '
        Me.GroupBoxGestionProductos.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxGestionProductos.Controls.Add(Me.ComboBox1)
        Me.GroupBoxGestionProductos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxGestionProductos.Controls.Add(Me.TBGestionProductos)
        Me.GroupBoxGestionProductos.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionProductos.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBoxGestionProductos.Location = New System.Drawing.Point(193, 24)
        Me.GroupBoxGestionProductos.Name = "GroupBoxGestionProductos"
        Me.GroupBoxGestionProductos.Size = New System.Drawing.Size(425, 99)
        Me.GroupBoxGestionProductos.TabIndex = 23
        Me.GroupBoxGestionProductos.TabStop = False
        Me.GroupBoxGestionProductos.Text = "Gestión de Productos"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(267, 49)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.Text = "Categorias"
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.Color.Brown
        Me.BEliminarProducto.FlatAppearance.BorderSize = 2
        Me.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BEliminarProducto.Image = Global.Unitivo.My.Resources.Resources.icons8_basura_26
        Me.BEliminarProducto.Location = New System.Drawing.Point(733, 345)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(50, 45)
        Me.BEliminarProducto.TabIndex = 12
        Me.BEliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarProducto.UseVisualStyleBackColor = False
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.SteelBlue
        Me.BModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarProducto.FlatAppearance.BorderSize = 2
        Me.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BModificarProducto.Location = New System.Drawing.Point(733, 269)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(50, 45)
        Me.BModificarProducto.TabIndex = 13
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'BBuscarProducto
        '
        Me.BBuscarProducto.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarProducto.FlatAppearance.BorderSize = 2
        Me.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.BBuscarProducto.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarProducto.Location = New System.Drawing.Point(198, 39)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(49, 41)
        Me.BBuscarProducto.TabIndex = 14
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'TBGestionProductos
        '
        Me.TBGestionProductos.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionProductos.Location = New System.Drawing.Point(49, 49)
        Me.TBGestionProductos.Name = "TBGestionProductos"
        Me.TBGestionProductos.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionProductos.TabIndex = 6
        '
        'TabListaCategorias
        '
        Me.TabListaCategorias.Controls.Add(Me.TabPageListaTalle)
        Me.TabListaCategorias.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaCategorias.Location = New System.Drawing.Point(24, 150)
        Me.TabListaCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaCategorias.Name = "TabListaCategorias"
        Me.TabListaCategorias.SelectedIndex = 0
        Me.TabListaCategorias.Size = New System.Drawing.Size(688, 301)
        Me.TabListaCategorias.TabIndex = 22
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.dgvListaProductos)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(680, 272)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Productos"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'dgvListaProductos
        '
        Me.dgvListaProductos.AllowUserToDeleteRows = False
        Me.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaProductos.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaProductos.ColumnHeadersHeight = 20
        Me.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Categoria, Me.Stock, Me.Column1, Me.Column4, Me.Talle})
        Me.dgvListaProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaProductos.EnableHeadersVisualStyles = False
        Me.dgvListaProductos.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaProductos.Name = "dgvListaProductos"
        Me.dgvListaProductos.ReadOnly = True
        Me.dgvListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaProductos.RowHeadersWidth = 51
        Me.dgvListaProductos.Size = New System.Drawing.Size(676, 268)
        Me.dgvListaProductos.TabIndex = 8
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Producto"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.MinimumWidth = 6
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.MinimumWidth = 6
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Marca"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Talle
        '
        Me.Talle.HeaderText = "Talle"
        Me.Talle.MinimumWidth = 6
        Me.Talle.Name = "Talle"
        Me.Talle.ReadOnly = True
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(606, 475)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 80
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GestionarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(810, 550)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionProductos)
        Me.Controls.Add(Me.BModificarProducto)
        Me.Controls.Add(Me.BEliminarProducto)
        Me.Controls.Add(Me.TabListaCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarProductos"
        Me.Text = "Form1"
        Me.GroupBoxGestionProductos.ResumeLayout(False)
        Me.GroupBoxGestionProductos.PerformLayout()
        Me.TabListaCategorias.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxGestionProductos As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TBGestionProductos As TextBox
    Friend WithEvents TabListaCategorias As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents dgvListaProductos As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Talle As DataGridViewTextBoxColumn
    Friend WithEvents BVolver As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarVentasAdmin
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
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BVerDetalle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBuscarVenta = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.DataGridViewListaVentas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxBuscarProducto.SuspendLayout()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(668, 444)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 71
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GroupBoxBuscarProducto
        '
        Me.GroupBoxBuscarProducto.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DateTimePicker2)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label2)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BVerDetalle)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BBuscarVenta)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.TBBuscar)
        Me.GroupBoxBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBuscarProducto.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBoxBuscarProducto.Location = New System.Drawing.Point(36, 18)
        Me.GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto"
        Me.GroupBoxBuscarProducto.Size = New System.Drawing.Size(738, 89)
        Me.GroupBoxBuscarProducto.TabIndex = 70
        Me.GroupBoxBuscarProducto.TabStop = False
        Me.GroupBoxBuscarProducto.Text = "Ventas"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(205, 44)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(106, 24)
        Me.DateTimePicker2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Fecha Fin:"
        '
        'BVerDetalle
        '
        Me.BVerDetalle.BackColor = System.Drawing.Color.Sienna
        Me.BVerDetalle.FlatAppearance.BorderSize = 2
        Me.BVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerDetalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVerDetalle.ForeColor = System.Drawing.Color.White
        Me.BVerDetalle.Location = New System.Drawing.Point(587, 32)
        Me.BVerDetalle.Name = "BVerDetalle"
        Me.BVerDetalle.Size = New System.Drawing.Size(111, 42)
        Me.BVerDetalle.TabIndex = 27
        Me.BVerDetalle.Text = "Ver Detalle"
        Me.BVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BVerDetalle.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Fecha Inicio:"
        '
        'BBuscarVenta
        '
        Me.BBuscarVenta.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarVenta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarVenta.FlatAppearance.BorderSize = 2
        Me.BBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarVenta.ForeColor = System.Drawing.Color.White
        Me.BBuscarVenta.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarVenta.Location = New System.Drawing.Point(499, 35)
        Me.BBuscarVenta.Name = "BBuscarVenta"
        Me.BBuscarVenta.Size = New System.Drawing.Size(50, 38)
        Me.BBuscarVenta.TabIndex = 14
        Me.BBuscarVenta.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(77, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 24)
        Me.DateTimePicker1.TabIndex = 30
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBBuscar.Location = New System.Drawing.Point(350, 41)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(131, 27)
        Me.TBBuscar.TabIndex = 6
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(36, 127)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(738, 292)
        Me.TabControlListaProductos.TabIndex = 69
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewListaVentas)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(730, 263)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Ventas"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'DataGridViewListaVentas
        '
        Me.DataGridViewListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewListaVentas.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.DataGridViewListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewListaVentas.ColumnHeadersHeight = 20
        Me.DataGridViewListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column6})
        Me.DataGridViewListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaVentas.EnableHeadersVisualStyles = False
        Me.DataGridViewListaVentas.Location = New System.Drawing.Point(2, 2)
        Me.DataGridViewListaVentas.Name = "DataGridViewListaVentas"
        Me.DataGridViewListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewListaVentas.RowHeadersWidth = 51
        Me.DataGridViewListaVentas.Size = New System.Drawing.Size(726, 259)
        Me.DataGridViewListaVentas.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° Factura"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cliente"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'ListarVentasAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(810, 500)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxBuscarProducto)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarVentasAdmin"
        Me.Text = "Form1"
        Me.GroupBoxBuscarProducto.ResumeLayout(False)
        Me.GroupBoxBuscarProducto.PerformLayout()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents GroupBoxBuscarProducto As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents BVerDetalle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BBuscarVenta As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents DataGridViewListaVentas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class

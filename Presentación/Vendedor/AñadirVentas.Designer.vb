<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBVendedor = New System.Windows.Forms.TextBox()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LNumeroFactura = New System.Windows.Forms.Label()
        Me.TBNroFactura = New System.Windows.Forms.TextBox()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBTelCliVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBApellidoCliVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNombreCliVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BBuscarCliente = New System.Windows.Forms.Button()
        Me.TBDniCliVenta = New System.Windows.Forms.TextBox()
        Me.GroupBoxArticulos = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.TBProductoVenta = New System.Windows.Forms.TextBox()
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LTotalVenta = New System.Windows.Forms.Label()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.GroupBoxClientes.SuspendLayout()
        Me.GroupBoxArticulos.SuspendLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaShell
        Me.Label1.Location = New System.Drawing.Point(273, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nueva Venta"
        '
        'TBVendedor
        '
        Me.TBVendedor.Enabled = False
        Me.TBVendedor.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBVendedor.Location = New System.Drawing.Point(600, 72)
        Me.TBVendedor.Margin = New System.Windows.Forms.Padding(5)
        Me.TBVendedor.Name = "TBVendedor"
        Me.TBVendedor.Size = New System.Drawing.Size(131, 22)
        Me.TBVendedor.TabIndex = 57
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.BackColor = System.Drawing.Color.SaddleBrown
        Me.LVendedor.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.ForeColor = System.Drawing.Color.White
        Me.LVendedor.Location = New System.Drawing.Point(511, 74)
        Me.LVendedor.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(81, 17)
        Me.LVendedor.TabIndex = 60
        Me.LVendedor.Text = "Vendedor:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(362, 71)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 22)
        Me.DateTimePicker1.TabIndex = 59
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.SaddleBrown
        Me.LFecha.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.White
        Me.LFecha.Location = New System.Drawing.Point(298, 74)
        Me.LFecha.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(54, 17)
        Me.LFecha.TabIndex = 58
        Me.LFecha.Text = "Fecha:"
        '
        'LNumeroFactura
        '
        Me.LNumeroFactura.AutoSize = True
        Me.LNumeroFactura.BackColor = System.Drawing.Color.SaddleBrown
        Me.LNumeroFactura.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumeroFactura.ForeColor = System.Drawing.Color.White
        Me.LNumeroFactura.Location = New System.Drawing.Point(60, 73)
        Me.LNumeroFactura.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LNumeroFactura.Name = "LNumeroFactura"
        Me.LNumeroFactura.Size = New System.Drawing.Size(88, 17)
        Me.LNumeroFactura.TabIndex = 55
        Me.LNumeroFactura.Text = "N° Factura:"
        '
        'TBNroFactura
        '
        Me.TBNroFactura.CausesValidation = False
        Me.TBNroFactura.Enabled = False
        Me.TBNroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBNroFactura.Location = New System.Drawing.Point(156, 71)
        Me.TBNroFactura.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNroFactura.Name = "TBNroFactura"
        Me.TBNroFactura.Size = New System.Drawing.Size(123, 22)
        Me.TBNroFactura.TabIndex = 56
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxClientes.Controls.Add(Me.Label5)
        Me.GroupBoxClientes.Controls.Add(Me.TBTelCliVenta)
        Me.GroupBoxClientes.Controls.Add(Me.Label4)
        Me.GroupBoxClientes.Controls.Add(Me.TBApellidoCliVenta)
        Me.GroupBoxClientes.Controls.Add(Me.Label3)
        Me.GroupBoxClientes.Controls.Add(Me.TBNombreCliVenta)
        Me.GroupBoxClientes.Controls.Add(Me.Label2)
        Me.GroupBoxClientes.Controls.Add(Me.BBuscarCliente)
        Me.GroupBoxClientes.Controls.Add(Me.TBDniCliVenta)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxClientes.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBoxClientes.Location = New System.Drawing.Point(20, 121)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(766, 106)
        Me.GroupBoxClientes.TabIndex = 61
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(582, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefono :"
        '
        'TBTelCliVenta
        '
        Me.TBTelCliVenta.Location = New System.Drawing.Point(586, 57)
        Me.TBTelCliVenta.Name = "TBTelCliVenta"
        Me.TBTelCliVenta.Size = New System.Drawing.Size(118, 32)
        Me.TBTelCliVenta.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(437, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido :"
        '
        'TBApellidoCliVenta
        '
        Me.TBApellidoCliVenta.Location = New System.Drawing.Point(441, 57)
        Me.TBApellidoCliVenta.Name = "TBApellidoCliVenta"
        Me.TBApellidoCliVenta.Size = New System.Drawing.Size(118, 32)
        Me.TBApellidoCliVenta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(292, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre :"
        '
        'TBNombreCliVenta
        '
        Me.TBNombreCliVenta.Location = New System.Drawing.Point(296, 57)
        Me.TBNombreCliVenta.Name = "TBNombreCliVenta"
        Me.TBNombreCliVenta.Size = New System.Drawing.Size(118, 32)
        Me.TBNombreCliVenta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(67, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DNI :"
        '
        'BBuscarCliente
        '
        Me.BBuscarCliente.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BBuscarCliente.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarCliente.Location = New System.Drawing.Point(218, 50)
        Me.BBuscarCliente.Name = "BBuscarCliente"
        Me.BBuscarCliente.Size = New System.Drawing.Size(45, 40)
        Me.BBuscarCliente.TabIndex = 2
        Me.BBuscarCliente.UseVisualStyleBackColor = False
        '
        'TBDniCliVenta
        '
        Me.TBDniCliVenta.Location = New System.Drawing.Point(71, 57)
        Me.TBDniCliVenta.Name = "TBDniCliVenta"
        Me.TBDniCliVenta.Size = New System.Drawing.Size(118, 32)
        Me.TBDniCliVenta.TabIndex = 1
        '
        'GroupBoxArticulos
        '
        Me.GroupBoxArticulos.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxArticulos.Controls.Add(Me.Label10)
        Me.GroupBoxArticulos.Controls.Add(Me.TBCantidad)
        Me.GroupBoxArticulos.Controls.Add(Me.Label6)
        Me.GroupBoxArticulos.Controls.Add(Me.TBTalle)
        Me.GroupBoxArticulos.Controls.Add(Me.Label7)
        Me.GroupBoxArticulos.Controls.Add(Me.TBStock)
        Me.GroupBoxArticulos.Controls.Add(Me.Label8)
        Me.GroupBoxArticulos.Controls.Add(Me.TBPrecio)
        Me.GroupBoxArticulos.Controls.Add(Me.Label9)
        Me.GroupBoxArticulos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxArticulos.Controls.Add(Me.TBProductoVenta)
        Me.GroupBoxArticulos.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxArticulos.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBoxArticulos.Location = New System.Drawing.Point(20, 245)
        Me.GroupBoxArticulos.Name = "GroupBoxArticulos"
        Me.GroupBoxArticulos.Size = New System.Drawing.Size(766, 106)
        Me.GroupBoxArticulos.TabIndex = 62
        Me.GroupBoxArticulos.TabStop = False
        Me.GroupBoxArticulos.Text = "Articulos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(645, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Cantidad :"
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(649, 58)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(105, 32)
        Me.TBCantidad.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(509, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Talle :"
        '
        'TBTalle
        '
        Me.TBTalle.Location = New System.Drawing.Point(513, 58)
        Me.TBTalle.Name = "TBTalle"
        Me.TBTalle.Size = New System.Drawing.Size(105, 32)
        Me.TBTalle.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(370, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stock :"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(374, 58)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(105, 32)
        Me.TBStock.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(231, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Precio :"
        '
        'TBPrecio
        '
        Me.TBPrecio.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrecio.Location = New System.Drawing.Point(235, 58)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(105, 25)
        Me.TBPrecio.TabIndex = 4
        Me.TBPrecio.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(11, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Codigo :"
        '
        'BBuscarProducto
        '
        Me.BBuscarProducto.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.BBuscarProducto.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarProducto.Location = New System.Drawing.Point(160, 51)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(45, 40)
        Me.BBuscarProducto.TabIndex = 2
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'TBProductoVenta
        '
        Me.TBProductoVenta.Location = New System.Drawing.Point(15, 58)
        Me.TBProductoVenta.Name = "TBProductoVenta"
        Me.TBProductoVenta.Size = New System.Drawing.Size(118, 32)
        Me.TBProductoVenta.TabIndex = 1
        '
        'dgvListaVentas
        '
        Me.dgvListaVentas.AllowUserToDeleteRows = False
        Me.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaVentas.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaVentas.ColumnHeadersHeight = 20
        Me.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Precio, Me.Cantidad, Me.Talle})
        Me.dgvListaVentas.EnableHeadersVisualStyles = False
        Me.dgvListaVentas.Location = New System.Drawing.Point(20, 371)
        Me.dgvListaVentas.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.ReadOnly = True
        Me.dgvListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaVentas.RowHeadersWidth = 51
        Me.dgvListaVentas.RowTemplate.Height = 24
        Me.dgvListaVentas.Size = New System.Drawing.Size(661, 140)
        Me.dgvListaVentas.TabIndex = 63
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Talle
        '
        Me.Talle.HeaderText = "Talle"
        Me.Talle.MinimumWidth = 6
        Me.Talle.Name = "Talle"
        Me.Talle.ReadOnly = True
        '
        'LTotalVenta
        '
        Me.LTotalVenta.AutoSize = True
        Me.LTotalVenta.BackColor = System.Drawing.Color.Cornsilk
        Me.LTotalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalVenta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LTotalVenta.Location = New System.Drawing.Point(50, 532)
        Me.LTotalVenta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LTotalVenta.Name = "LTotalVenta"
        Me.LTotalVenta.Size = New System.Drawing.Size(62, 23)
        Me.LTotalVenta.TabIndex = 64
        Me.LTotalVenta.Text = "Total:"
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.BackColor = System.Drawing.Color.Cornsilk
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(125, 531)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(123, 25)
        Me.TBApellidoCliente.TabIndex = 65
        Me.TBApellidoCliente.Text = "$"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(429, 526)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 67
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BGuardar.FlatAppearance.BorderSize = 2
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGuardar.Font = New System.Drawing.Font("Cooper Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.Color.Cornsilk
        Me.BGuardar.Location = New System.Drawing.Point(562, 526)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(122, 38)
        Me.BGuardar.TabIndex = 66
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.SteelBlue
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Image = Global.Unitivo.My.Resources.Resources.icons8_editar_archivo_26
        Me.BModificarProducto.Location = New System.Drawing.Point(711, 393)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(50, 45)
        Me.BModificarProducto.TabIndex = 69
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.Color.Brown
        Me.BEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BEliminarProducto.Image = Global.Unitivo.My.Resources.Resources.icons8_basura_26
        Me.BEliminarProducto.Location = New System.Drawing.Point(711, 454)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(50, 45)
        Me.BEliminarProducto.TabIndex = 68
        Me.BEliminarProducto.UseVisualStyleBackColor = False
        '
        'AñadirVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(810, 590)
        Me.Controls.Add(Me.BModificarProducto)
        Me.Controls.Add(Me.BEliminarProducto)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.LTotalVenta)
        Me.Controls.Add(Me.TBApellidoCliente)
        Me.Controls.Add(Me.dgvListaVentas)
        Me.Controls.Add(Me.GroupBoxArticulos)
        Me.Controls.Add(Me.GroupBoxClientes)
        Me.Controls.Add(Me.TBVendedor)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LNumeroFactura)
        Me.Controls.Add(Me.TBNroFactura)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirVentas"
        Me.Text = "Form1"
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        Me.GroupBoxArticulos.ResumeLayout(False)
        Me.GroupBoxArticulos.PerformLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBVendedor As TextBox
    Friend WithEvents LVendedor As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LFecha As Label
    Friend WithEvents LNumeroFactura As Label
    Friend WithEvents TBNroFactura As TextBox
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents BBuscarCliente As Button
    Friend WithEvents TBDniCliVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBTelCliVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBApellidoCliVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNombreCliVenta As TextBox
    Friend WithEvents GroupBoxArticulos As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TBProductoVenta As TextBox
    Friend WithEvents dgvListaVentas As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Talle As DataGridViewTextBoxColumn
    Friend WithEvents LTotalVenta As Label
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents BVolver As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents BEliminarProducto As Button
End Class

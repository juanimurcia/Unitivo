<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProducto
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
        Me.PanelModClientes = New System.Windows.Forms.Panel()
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.TBStockProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBTalleProducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBPrecioProducto = New System.Windows.Forms.TextBox()
        Me.TBNombreProducto = New System.Windows.Forms.TextBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.CBMarcaProducto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBCategoriaProducto = New System.Windows.Forms.ComboBox()
        Me.PanelModClientes.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModClientes
        '
        Me.PanelModClientes.BackColor = System.Drawing.Color.RosyBrown
        Me.PanelModClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModClientes.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModClientes.Controls.Add(Me.BModificarProducto)
        Me.PanelModClientes.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModClientes.Location = New System.Drawing.Point(146, 42)
        Me.PanelModClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelModClientes.Name = "PanelModClientes"
        Me.PanelModClientes.Size = New System.Drawing.Size(508, 366)
        Me.PanelModClientes.TabIndex = 3
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.Sienna
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(267, 310)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(98, 42)
        Me.BCancelarModifCliente.TabIndex = 14
        Me.BCancelarModifCliente.Text = "Volver"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarProducto.FlatAppearance.BorderSize = 2
        Me.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarProducto.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Location = New System.Drawing.Point(386, 310)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(98, 42)
        Me.BModificarProducto.TabIndex = 15
        Me.BModificarProducto.Text = "Modificar"
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBStockProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label4)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CBTalleProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label5)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label6)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBPrecioProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBNombreProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LMarca)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CBMarcaProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label3)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label2)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CBCategoriaProducto)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(34, 23)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(450, 271)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Modificar Producto"
        '
        'TBStockProducto
        '
        Me.TBStockProducto.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStockProducto.Location = New System.Drawing.Point(243, 207)
        Me.TBStockProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TBStockProducto.Name = "TBStockProducto"
        Me.TBStockProducto.Size = New System.Drawing.Size(161, 29)
        Me.TBStockProducto.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(239, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Stock:"
        '
        'CBTalleProducto
        '
        Me.CBTalleProducto.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTalleProducto.FormattingEnabled = True
        Me.CBTalleProducto.Items.AddRange(New Object() {"DNI", "OTRO"})
        Me.CBTalleProducto.Location = New System.Drawing.Point(243, 81)
        Me.CBTalleProducto.Name = "CBTalleProducto"
        Me.CBTalleProducto.Size = New System.Drawing.Size(161, 29)
        Me.CBTalleProducto.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(239, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Precio: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(239, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Talle: "
        '
        'TBPrecioProducto
        '
        Me.TBPrecioProducto.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrecioProducto.Location = New System.Drawing.Point(243, 141)
        Me.TBPrecioProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPrecioProducto.Name = "TBPrecioProducto"
        Me.TBPrecioProducto.Size = New System.Drawing.Size(161, 29)
        Me.TBPrecioProducto.TabIndex = 15
        '
        'TBNombreProducto
        '
        Me.TBNombreProducto.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombreProducto.Location = New System.Drawing.Point(47, 207)
        Me.TBNombreProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreProducto.Name = "TBNombreProducto"
        Me.TBNombreProducto.Size = New System.Drawing.Size(161, 29)
        Me.TBNombreProducto.TabIndex = 8
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.White
        Me.LMarca.Location = New System.Drawing.Point(46, 118)
        Me.LMarca.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(72, 21)
        Me.LMarca.TabIndex = 20
        Me.LMarca.Text = "Marca: "
        '
        'CBMarcaProducto
        '
        Me.CBMarcaProducto.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMarcaProducto.FormattingEnabled = True
        Me.CBMarcaProducto.Items.AddRange(New Object() {"DNI", "OTRO"})
        Me.CBMarcaProducto.Location = New System.Drawing.Point(47, 141)
        Me.CBMarcaProducto.Name = "CBMarcaProducto"
        Me.CBMarcaProducto.Size = New System.Drawing.Size(161, 29)
        Me.CBMarcaProducto.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(44, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Categoría: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 180)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre:"
        '
        'CBCategoriaProducto
        '
        Me.CBCategoriaProducto.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCategoriaProducto.FormattingEnabled = True
        Me.CBCategoriaProducto.Items.AddRange(New Object() {"DNI", "OTRO"})
        Me.CBCategoriaProducto.Location = New System.Drawing.Point(47, 81)
        Me.CBCategoriaProducto.Name = "CBCategoriaProducto"
        Me.CBCategoriaProducto.Size = New System.Drawing.Size(161, 29)
        Me.CBCategoriaProducto.TabIndex = 18
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelModClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarProducto"
        Me.Text = "Form1"
        Me.PanelModClientes.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModClientes As Panel
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents TBStockProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBTalleProducto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBPrecioProducto As TextBox
    Friend WithEvents TBNombreProducto As TextBox
    Friend WithEvents LMarca As Label
    Friend WithEvents CBMarcaProducto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBCategoriaProducto As ComboBox
End Class

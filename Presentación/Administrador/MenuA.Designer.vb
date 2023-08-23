<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.PanelSubMenuClientes = New System.Windows.Forms.Panel()
        Me.BGestionarClientes = New System.Windows.Forms.Button()
        Me.PanelSubMenuTalles = New System.Windows.Forms.Panel()
        Me.BGestionarTalles = New System.Windows.Forms.Button()
        Me.BAñadirTalle = New System.Windows.Forms.Button()
        Me.PanelSubMenuCategorias = New System.Windows.Forms.Panel()
        Me.BGestionarCategorias = New System.Windows.Forms.Button()
        Me.BAñadirCategoria = New System.Windows.Forms.Button()
        Me.PanelSubMenuVentas = New System.Windows.Forms.Panel()
        Me.BListarVendedoresAdmin = New System.Windows.Forms.Button()
        Me.BListarVentasAdmin = New System.Windows.Forms.Button()
        Me.PanelSubMenuProductos = New System.Windows.Forms.Panel()
        Me.BGestionarProductosAdmin = New System.Windows.Forms.Button()
        Me.BAñadirProductoAdmin = New System.Windows.Forms.Button()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.PanelFormAdmin = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.BTalles = New System.Windows.Forms.Button()
        Me.BCategoriasAdmin = New System.Windows.Forms.Button()
        Me.BVentasAdmin = New System.Windows.Forms.Button()
        Me.BProductosAdmin = New System.Windows.Forms.Button()
        Me.BMaximizarMenuAdmin = New System.Windows.Forms.Button()
        Me.BCerrarMenuAdmin = New System.Windows.Forms.Button()
        Me.BRestaurarMenuAdmin = New System.Windows.Forms.Button()
        Me.BMinimizarMenuAdmin = New System.Windows.Forms.Button()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelSubMenuClientes.SuspendLayout()
        Me.PanelSubMenuTalles.SuspendLayout()
        Me.PanelSubMenuCategorias.SuspendLayout()
        Me.PanelSubMenuVentas.SuspendLayout()
        Me.PanelSubMenuProductos.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        Me.PanelFormAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.Sienna
        Me.BSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSalir.FlatAppearance.BorderSize = 2
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.Cornsilk
        Me.BSalir.Location = New System.Drawing.Point(0, 707)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(213, 39)
        Me.BSalir.TabIndex = 8
        Me.BSalir.Text = "Cerrar Sesión"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.Tan
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuClientes)
        Me.PanelMenuLateral.Controls.Add(Me.BClientes)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuTalles)
        Me.PanelMenuLateral.Controls.Add(Me.BTalles)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuCategorias)
        Me.PanelMenuLateral.Controls.Add(Me.BCategoriasAdmin)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuVentas)
        Me.PanelMenuLateral.Controls.Add(Me.BSalir)
        Me.PanelMenuLateral.Controls.Add(Me.BVentasAdmin)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuProductos)
        Me.PanelMenuLateral.Controls.Add(Me.BProductosAdmin)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 60)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(230, 590)
        Me.PanelMenuLateral.TabIndex = 8
        '
        'PanelSubMenuClientes
        '
        Me.PanelSubMenuClientes.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuClientes.Controls.Add(Me.BGestionarClientes)
        Me.PanelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuClientes.Location = New System.Drawing.Point(0, 658)
        Me.PanelSubMenuClientes.Name = "PanelSubMenuClientes"
        Me.PanelSubMenuClientes.Size = New System.Drawing.Size(213, 49)
        Me.PanelSubMenuClientes.TabIndex = 18
        '
        'BGestionarClientes
        '
        Me.BGestionarClientes.BackColor = System.Drawing.Color.FloralWhite
        Me.BGestionarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarClientes.FlatAppearance.BorderSize = 0
        Me.BGestionarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarClientes.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGestionarClientes.ForeColor = System.Drawing.Color.Sienna
        Me.BGestionarClientes.Location = New System.Drawing.Point(0, 0)
        Me.BGestionarClientes.Name = "BGestionarClientes"
        Me.BGestionarClientes.Size = New System.Drawing.Size(213, 40)
        Me.BGestionarClientes.TabIndex = 1
        Me.BGestionarClientes.Text = "Gestionar Clientes"
        Me.BGestionarClientes.UseVisualStyleBackColor = False
        '
        'PanelSubMenuTalles
        '
        Me.PanelSubMenuTalles.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuTalles.Controls.Add(Me.BGestionarTalles)
        Me.PanelSubMenuTalles.Controls.Add(Me.BAñadirTalle)
        Me.PanelSubMenuTalles.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuTalles.Location = New System.Drawing.Point(0, 521)
        Me.PanelSubMenuTalles.Name = "PanelSubMenuTalles"
        Me.PanelSubMenuTalles.Size = New System.Drawing.Size(213, 85)
        Me.PanelSubMenuTalles.TabIndex = 15
        '
        'BGestionarTalles
        '
        Me.BGestionarTalles.BackColor = System.Drawing.Color.FloralWhite
        Me.BGestionarTalles.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarTalles.FlatAppearance.BorderSize = 0
        Me.BGestionarTalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarTalles.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGestionarTalles.ForeColor = System.Drawing.Color.Sienna
        Me.BGestionarTalles.Location = New System.Drawing.Point(0, 40)
        Me.BGestionarTalles.Name = "BGestionarTalles"
        Me.BGestionarTalles.Size = New System.Drawing.Size(213, 40)
        Me.BGestionarTalles.TabIndex = 2
        Me.BGestionarTalles.Text = "Gestionar Talles"
        Me.BGestionarTalles.UseVisualStyleBackColor = False
        '
        'BAñadirTalle
        '
        Me.BAñadirTalle.BackColor = System.Drawing.Color.FloralWhite
        Me.BAñadirTalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirTalle.FlatAppearance.BorderSize = 0
        Me.BAñadirTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirTalle.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirTalle.ForeColor = System.Drawing.Color.Sienna
        Me.BAñadirTalle.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirTalle.Name = "BAñadirTalle"
        Me.BAñadirTalle.Size = New System.Drawing.Size(213, 40)
        Me.BAñadirTalle.TabIndex = 1
        Me.BAñadirTalle.Text = "Añadir Talle"
        Me.BAñadirTalle.UseVisualStyleBackColor = False
        '
        'PanelSubMenuCategorias
        '
        Me.PanelSubMenuCategorias.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuCategorias.Controls.Add(Me.BGestionarCategorias)
        Me.PanelSubMenuCategorias.Controls.Add(Me.BAñadirCategoria)
        Me.PanelSubMenuCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuCategorias.Location = New System.Drawing.Point(0, 362)
        Me.PanelSubMenuCategorias.Name = "PanelSubMenuCategorias"
        Me.PanelSubMenuCategorias.Size = New System.Drawing.Size(213, 100)
        Me.PanelSubMenuCategorias.TabIndex = 13
        '
        'BGestionarCategorias
        '
        Me.BGestionarCategorias.BackColor = System.Drawing.Color.FloralWhite
        Me.BGestionarCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarCategorias.FlatAppearance.BorderSize = 0
        Me.BGestionarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarCategorias.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGestionarCategorias.ForeColor = System.Drawing.Color.Sienna
        Me.BGestionarCategorias.Location = New System.Drawing.Point(0, 40)
        Me.BGestionarCategorias.Name = "BGestionarCategorias"
        Me.BGestionarCategorias.Size = New System.Drawing.Size(213, 54)
        Me.BGestionarCategorias.TabIndex = 2
        Me.BGestionarCategorias.Text = "Gestionar Categorias"
        Me.BGestionarCategorias.UseVisualStyleBackColor = False
        '
        'BAñadirCategoria
        '
        Me.BAñadirCategoria.BackColor = System.Drawing.Color.FloralWhite
        Me.BAñadirCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirCategoria.FlatAppearance.BorderSize = 0
        Me.BAñadirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirCategoria.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirCategoria.ForeColor = System.Drawing.Color.Sienna
        Me.BAñadirCategoria.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirCategoria.Name = "BAñadirCategoria"
        Me.BAñadirCategoria.Size = New System.Drawing.Size(213, 40)
        Me.BAñadirCategoria.TabIndex = 1
        Me.BAñadirCategoria.Text = "Añadir Categoria"
        Me.BAñadirCategoria.UseVisualStyleBackColor = False
        '
        'PanelSubMenuVentas
        '
        Me.PanelSubMenuVentas.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuVentas.Controls.Add(Me.BListarVendedoresAdmin)
        Me.PanelSubMenuVentas.Controls.Add(Me.BListarVentasAdmin)
        Me.PanelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuVentas.Location = New System.Drawing.Point(0, 218)
        Me.PanelSubMenuVentas.Name = "PanelSubMenuVentas"
        Me.PanelSubMenuVentas.Size = New System.Drawing.Size(213, 85)
        Me.PanelSubMenuVentas.TabIndex = 11
        '
        'BListarVendedoresAdmin
        '
        Me.BListarVendedoresAdmin.BackColor = System.Drawing.Color.FloralWhite
        Me.BListarVendedoresAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BListarVendedoresAdmin.FlatAppearance.BorderSize = 0
        Me.BListarVendedoresAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BListarVendedoresAdmin.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BListarVendedoresAdmin.ForeColor = System.Drawing.Color.Sienna
        Me.BListarVendedoresAdmin.Location = New System.Drawing.Point(0, 40)
        Me.BListarVendedoresAdmin.Name = "BListarVendedoresAdmin"
        Me.BListarVendedoresAdmin.Size = New System.Drawing.Size(213, 40)
        Me.BListarVendedoresAdmin.TabIndex = 2
        Me.BListarVendedoresAdmin.Text = "Listar Vendedores"
        Me.BListarVendedoresAdmin.UseVisualStyleBackColor = False
        '
        'BListarVentasAdmin
        '
        Me.BListarVentasAdmin.BackColor = System.Drawing.Color.FloralWhite
        Me.BListarVentasAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BListarVentasAdmin.FlatAppearance.BorderSize = 0
        Me.BListarVentasAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BListarVentasAdmin.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BListarVentasAdmin.ForeColor = System.Drawing.Color.Sienna
        Me.BListarVentasAdmin.Location = New System.Drawing.Point(0, 0)
        Me.BListarVentasAdmin.Name = "BListarVentasAdmin"
        Me.BListarVentasAdmin.Size = New System.Drawing.Size(213, 40)
        Me.BListarVentasAdmin.TabIndex = 1
        Me.BListarVentasAdmin.Text = "Listar Ventas"
        Me.BListarVentasAdmin.UseVisualStyleBackColor = False
        '
        'PanelSubMenuProductos
        '
        Me.PanelSubMenuProductos.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuProductos.Controls.Add(Me.BGestionarProductosAdmin)
        Me.PanelSubMenuProductos.Controls.Add(Me.BAñadirProductoAdmin)
        Me.PanelSubMenuProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuProductos.Location = New System.Drawing.Point(0, 59)
        Me.PanelSubMenuProductos.Name = "PanelSubMenuProductos"
        Me.PanelSubMenuProductos.Size = New System.Drawing.Size(213, 100)
        Me.PanelSubMenuProductos.TabIndex = 9
        '
        'BGestionarProductosAdmin
        '
        Me.BGestionarProductosAdmin.BackColor = System.Drawing.Color.FloralWhite
        Me.BGestionarProductosAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarProductosAdmin.FlatAppearance.BorderSize = 0
        Me.BGestionarProductosAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarProductosAdmin.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGestionarProductosAdmin.ForeColor = System.Drawing.Color.Sienna
        Me.BGestionarProductosAdmin.Location = New System.Drawing.Point(0, 40)
        Me.BGestionarProductosAdmin.Name = "BGestionarProductosAdmin"
        Me.BGestionarProductosAdmin.Size = New System.Drawing.Size(213, 54)
        Me.BGestionarProductosAdmin.TabIndex = 2
        Me.BGestionarProductosAdmin.Text = "Gestionar Productos"
        Me.BGestionarProductosAdmin.UseVisualStyleBackColor = False
        '
        'BAñadirProductoAdmin
        '
        Me.BAñadirProductoAdmin.BackColor = System.Drawing.Color.FloralWhite
        Me.BAñadirProductoAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirProductoAdmin.FlatAppearance.BorderSize = 0
        Me.BAñadirProductoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirProductoAdmin.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirProductoAdmin.ForeColor = System.Drawing.Color.Sienna
        Me.BAñadirProductoAdmin.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirProductoAdmin.Name = "BAñadirProductoAdmin"
        Me.BAñadirProductoAdmin.Size = New System.Drawing.Size(213, 40)
        Me.BAñadirProductoAdmin.TabIndex = 1
        Me.BAñadirProductoAdmin.Text = "Añadir Producto"
        Me.BAñadirProductoAdmin.UseVisualStyleBackColor = False
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.Tan
        Me.PanelBarraMenu.Controls.Add(Me.BMaximizarMenuAdmin)
        Me.PanelBarraMenu.Controls.Add(Me.BCerrarMenuAdmin)
        Me.PanelBarraMenu.Controls.Add(Me.BRestaurarMenuAdmin)
        Me.PanelBarraMenu.Controls.Add(Me.BMinimizarMenuAdmin)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1040, 60)
        Me.PanelBarraMenu.TabIndex = 7
        '
        'PanelFormAdmin
        '
        Me.PanelFormAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFormAdmin.BackgroundImage = Global.Unitivo.My.Resources.Resources.imggrande5
        Me.PanelFormAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelFormAdmin.Controls.Add(Me.Label1)
        Me.PanelFormAdmin.Location = New System.Drawing.Point(230, 60)
        Me.PanelFormAdmin.Name = "PanelFormAdmin"
        Me.PanelFormAdmin.Size = New System.Drawing.Size(810, 590)
        Me.PanelFormAdmin.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(255, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 55)
        Me.Label1.TabIndex = 4
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.RosyBrown
        Me.BClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BClientes.FlatAppearance.BorderSize = 0
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClientes.ForeColor = System.Drawing.Color.Cornsilk
        Me.BClientes.Image = Global.Unitivo.My.Resources.Resources.icons8_contactos_50__2_
        Me.BClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.Location = New System.Drawing.Point(0, 606)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(213, 52)
        Me.BClientes.TabIndex = 17
        Me.BClientes.Text = "Clientes"
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'BTalles
        '
        Me.BTalles.BackColor = System.Drawing.Color.RosyBrown
        Me.BTalles.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTalles.FlatAppearance.BorderSize = 0
        Me.BTalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTalles.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTalles.ForeColor = System.Drawing.Color.Cornsilk
        Me.BTalles.Image = Global.Unitivo.My.Resources.Resources.icons8_patrón_de_la_camisa_a_medida_48
        Me.BTalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTalles.Location = New System.Drawing.Point(0, 462)
        Me.BTalles.Name = "BTalles"
        Me.BTalles.Size = New System.Drawing.Size(213, 59)
        Me.BTalles.TabIndex = 14
        Me.BTalles.Text = "Talles"
        Me.BTalles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTalles.UseVisualStyleBackColor = False
        '
        'BCategoriasAdmin
        '
        Me.BCategoriasAdmin.BackColor = System.Drawing.Color.RosyBrown
        Me.BCategoriasAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BCategoriasAdmin.FlatAppearance.BorderSize = 0
        Me.BCategoriasAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCategoriasAdmin.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCategoriasAdmin.ForeColor = System.Drawing.Color.Cornsilk
        Me.BCategoriasAdmin.Image = Global.Unitivo.My.Resources.Resources.icons8_categorizar_48
        Me.BCategoriasAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCategoriasAdmin.Location = New System.Drawing.Point(0, 303)
        Me.BCategoriasAdmin.Name = "BCategoriasAdmin"
        Me.BCategoriasAdmin.Size = New System.Drawing.Size(213, 59)
        Me.BCategoriasAdmin.TabIndex = 12
        Me.BCategoriasAdmin.Text = "Categorias"
        Me.BCategoriasAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCategoriasAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCategoriasAdmin.UseVisualStyleBackColor = False
        '
        'BVentasAdmin
        '
        Me.BVentasAdmin.BackColor = System.Drawing.Color.RosyBrown
        Me.BVentasAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentasAdmin.FlatAppearance.BorderSize = 0
        Me.BVentasAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentasAdmin.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVentasAdmin.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVentasAdmin.Image = Global.Unitivo.My.Resources.Resources.icons8_ventas_totales_48
        Me.BVentasAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentasAdmin.Location = New System.Drawing.Point(0, 159)
        Me.BVentasAdmin.Name = "BVentasAdmin"
        Me.BVentasAdmin.Size = New System.Drawing.Size(213, 59)
        Me.BVentasAdmin.TabIndex = 10
        Me.BVentasAdmin.Text = "Ventas"
        Me.BVentasAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentasAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVentasAdmin.UseVisualStyleBackColor = False
        '
        'BProductosAdmin
        '
        Me.BProductosAdmin.BackColor = System.Drawing.Color.RosyBrown
        Me.BProductosAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BProductosAdmin.FlatAppearance.BorderSize = 0
        Me.BProductosAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BProductosAdmin.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BProductosAdmin.ForeColor = System.Drawing.Color.Cornsilk
        Me.BProductosAdmin.Image = Global.Unitivo.My.Resources.Resources.icons8_camiseta_48
        Me.BProductosAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BProductosAdmin.Location = New System.Drawing.Point(0, 0)
        Me.BProductosAdmin.Name = "BProductosAdmin"
        Me.BProductosAdmin.Size = New System.Drawing.Size(213, 59)
        Me.BProductosAdmin.TabIndex = 0
        Me.BProductosAdmin.Text = "Productos"
        Me.BProductosAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BProductosAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BProductosAdmin.UseVisualStyleBackColor = False
        '
        'BMaximizarMenuAdmin
        '
        Me.BMaximizarMenuAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenuAdmin.BackgroundImage = Global.Unitivo.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenuAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenuAdmin.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenuAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenuAdmin.Location = New System.Drawing.Point(948, 17)
        Me.BMaximizarMenuAdmin.Name = "BMaximizarMenuAdmin"
        Me.BMaximizarMenuAdmin.Size = New System.Drawing.Size(30, 30)
        Me.BMaximizarMenuAdmin.TabIndex = 3
        Me.BMaximizarMenuAdmin.UseVisualStyleBackColor = True
        '
        'BCerrarMenuAdmin
        '
        Me.BCerrarMenuAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarMenuAdmin.BackgroundImage = Global.Unitivo.My.Resources.Resources.cerrarventana
        Me.BCerrarMenuAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenuAdmin.FlatAppearance.BorderSize = 0
        Me.BCerrarMenuAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenuAdmin.Location = New System.Drawing.Point(990, 17)
        Me.BCerrarMenuAdmin.Name = "BCerrarMenuAdmin"
        Me.BCerrarMenuAdmin.Size = New System.Drawing.Size(30, 30)
        Me.BCerrarMenuAdmin.TabIndex = 2
        Me.BCerrarMenuAdmin.UseVisualStyleBackColor = True
        '
        'BRestaurarMenuAdmin
        '
        Me.BRestaurarMenuAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRestaurarMenuAdmin.BackgroundImage = Global.Unitivo.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenuAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenuAdmin.FlatAppearance.BorderSize = 0
        Me.BRestaurarMenuAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenuAdmin.Location = New System.Drawing.Point(950, 17)
        Me.BRestaurarMenuAdmin.Name = "BRestaurarMenuAdmin"
        Me.BRestaurarMenuAdmin.Size = New System.Drawing.Size(30, 30)
        Me.BRestaurarMenuAdmin.TabIndex = 1
        Me.BRestaurarMenuAdmin.UseVisualStyleBackColor = True
        '
        'BMinimizarMenuAdmin
        '
        Me.BMinimizarMenuAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMinimizarMenuAdmin.BackgroundImage = Global.Unitivo.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenuAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenuAdmin.FlatAppearance.BorderSize = 0
        Me.BMinimizarMenuAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenuAdmin.Location = New System.Drawing.Point(910, 17)
        Me.BMinimizarMenuAdmin.Name = "BMinimizarMenuAdmin"
        Me.BMinimizarMenuAdmin.Size = New System.Drawing.Size(30, 30)
        Me.BMinimizarMenuAdmin.TabIndex = 0
        Me.BMinimizarMenuAdmin.UseVisualStyleBackColor = True
        '
        'MenuA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 650)
        Me.Controls.Add(Me.PanelFormAdmin)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuA"
        Me.Text = "Form1"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelSubMenuClientes.ResumeLayout(False)
        Me.PanelSubMenuTalles.ResumeLayout(False)
        Me.PanelSubMenuCategorias.ResumeLayout(False)
        Me.PanelSubMenuVentas.ResumeLayout(False)
        Me.PanelSubMenuProductos.ResumeLayout(False)
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.PanelFormAdmin.ResumeLayout(False)
        Me.PanelFormAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFormAdmin As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BSalir As Button
    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelSubMenuCategorias As Panel
    Friend WithEvents BGestionarCategorias As Button
    Friend WithEvents BAñadirCategoria As Button
    Friend WithEvents BCategoriasAdmin As Button
    Friend WithEvents PanelSubMenuVentas As Panel
    Friend WithEvents BListarVendedoresAdmin As Button
    Friend WithEvents BListarVentasAdmin As Button
    Friend WithEvents BVentasAdmin As Button
    Friend WithEvents PanelSubMenuProductos As Panel
    Friend WithEvents BGestionarProductosAdmin As Button
    Friend WithEvents BAñadirProductoAdmin As Button
    Friend WithEvents BProductosAdmin As Button
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents BMaximizarMenuAdmin As Button
    Friend WithEvents BCerrarMenuAdmin As Button
    Friend WithEvents BRestaurarMenuAdmin As Button
    Friend WithEvents BMinimizarMenuAdmin As Button
    Friend WithEvents PanelSubMenuTalles As Panel
    Friend WithEvents BGestionarTalles As Button
    Friend WithEvents BAñadirTalle As Button
    Friend WithEvents BTalles As Button
    Friend WithEvents PanelSubMenuClientes As Panel
    Friend WithEvents BGestionarClientes As Button
    Friend WithEvents BClientes As Button
End Class

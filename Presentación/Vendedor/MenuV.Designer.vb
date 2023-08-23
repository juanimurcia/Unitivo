<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuV
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
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.BMaximizarMenu = New System.Windows.Forms.Button()
        Me.BCerrarMenu = New System.Windows.Forms.Button()
        Me.BRestaurarMenu = New System.Windows.Forms.Button()
        Me.BMinimizarMenu = New System.Windows.Forms.Button()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.PanelSubMenuProductos = New System.Windows.Forms.Panel()
        Me.BListarProductos = New System.Windows.Forms.Button()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.PanelSubMenuFacturación = New System.Windows.Forms.Panel()
        Me.BListarVentas = New System.Windows.Forms.Button()
        Me.BNuevaVenta = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BFacturación = New System.Windows.Forms.Button()
        Me.PanelSubMenuClientes = New System.Windows.Forms.Panel()
        Me.BListaClientes = New System.Windows.Forms.Button()
        Me.BAñadirClientes = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.PanelFormVendedor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBarraMenu.SuspendLayout()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelSubMenuProductos.SuspendLayout()
        Me.PanelSubMenuFacturación.SuspendLayout()
        Me.PanelSubMenuClientes.SuspendLayout()
        Me.PanelFormVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.Tan
        Me.PanelBarraMenu.Controls.Add(Me.BMaximizarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BCerrarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BRestaurarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BMinimizarMenu)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1040, 60)
        Me.PanelBarraMenu.TabIndex = 1
        '
        'BMaximizarMenu
        '
        Me.BMaximizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenu.BackgroundImage = Global.Unitivo.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenu.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenu.Location = New System.Drawing.Point(950, 17)
        Me.BMaximizarMenu.Name = "BMaximizarMenu"
        Me.BMaximizarMenu.Size = New System.Drawing.Size(30, 30)
        Me.BMaximizarMenu.TabIndex = 3
        Me.BMaximizarMenu.UseVisualStyleBackColor = True
        '
        'BCerrarMenu
        '
        Me.BCerrarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarMenu.BackgroundImage = Global.Unitivo.My.Resources.Resources.cerrarventana
        Me.BCerrarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenu.FlatAppearance.BorderSize = 0
        Me.BCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenu.Location = New System.Drawing.Point(990, 17)
        Me.BCerrarMenu.Name = "BCerrarMenu"
        Me.BCerrarMenu.Size = New System.Drawing.Size(30, 30)
        Me.BCerrarMenu.TabIndex = 2
        Me.BCerrarMenu.UseVisualStyleBackColor = True
        '
        'BRestaurarMenu
        '
        Me.BRestaurarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRestaurarMenu.BackgroundImage = Global.Unitivo.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenu.FlatAppearance.BorderSize = 0
        Me.BRestaurarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenu.Location = New System.Drawing.Point(950, 17)
        Me.BRestaurarMenu.Name = "BRestaurarMenu"
        Me.BRestaurarMenu.Size = New System.Drawing.Size(30, 30)
        Me.BRestaurarMenu.TabIndex = 1
        Me.BRestaurarMenu.UseVisualStyleBackColor = True
        '
        'BMinimizarMenu
        '
        Me.BMinimizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMinimizarMenu.BackgroundImage = Global.Unitivo.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenu.FlatAppearance.BorderSize = 0
        Me.BMinimizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenu.Location = New System.Drawing.Point(910, 17)
        Me.BMinimizarMenu.Name = "BMinimizarMenu"
        Me.BMinimizarMenu.Size = New System.Drawing.Size(30, 30)
        Me.BMinimizarMenu.TabIndex = 0
        Me.BMinimizarMenu.UseVisualStyleBackColor = True
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.Tan
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuProductos)
        Me.PanelMenuLateral.Controls.Add(Me.BProductos)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuFacturación)
        Me.PanelMenuLateral.Controls.Add(Me.BSalir)
        Me.PanelMenuLateral.Controls.Add(Me.BFacturación)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuClientes)
        Me.PanelMenuLateral.Controls.Add(Me.BClientes)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 60)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(230, 590)
        Me.PanelMenuLateral.TabIndex = 2
        '
        'PanelSubMenuProductos
        '
        Me.PanelSubMenuProductos.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuProductos.Controls.Add(Me.BListarProductos)
        Me.PanelSubMenuProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuProductos.Location = New System.Drawing.Point(0, 326)
        Me.PanelSubMenuProductos.Name = "PanelSubMenuProductos"
        Me.PanelSubMenuProductos.Size = New System.Drawing.Size(230, 45)
        Me.PanelSubMenuProductos.TabIndex = 13
        '
        'BListarProductos
        '
        Me.BListarProductos.BackColor = System.Drawing.Color.FloralWhite
        Me.BListarProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BListarProductos.FlatAppearance.BorderSize = 0
        Me.BListarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BListarProductos.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BListarProductos.ForeColor = System.Drawing.Color.Sienna
        Me.BListarProductos.Location = New System.Drawing.Point(0, 0)
        Me.BListarProductos.Name = "BListarProductos"
        Me.BListarProductos.Size = New System.Drawing.Size(230, 40)
        Me.BListarProductos.TabIndex = 1
        Me.BListarProductos.Text = "Listar Productos"
        Me.BListarProductos.UseVisualStyleBackColor = False
        '
        'BProductos
        '
        Me.BProductos.BackColor = System.Drawing.Color.RosyBrown
        Me.BProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BProductos.FlatAppearance.BorderSize = 0
        Me.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BProductos.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BProductos.ForeColor = System.Drawing.Color.Cornsilk
        Me.BProductos.Image = Global.Unitivo.My.Resources.Resources.icons8_camiseta_48
        Me.BProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BProductos.Location = New System.Drawing.Point(0, 274)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Size = New System.Drawing.Size(230, 52)
        Me.BProductos.TabIndex = 12
        Me.BProductos.Text = "Productos"
        Me.BProductos.UseVisualStyleBackColor = False
        '
        'PanelSubMenuFacturación
        '
        Me.PanelSubMenuFacturación.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuFacturación.Controls.Add(Me.BListarVentas)
        Me.PanelSubMenuFacturación.Controls.Add(Me.BNuevaVenta)
        Me.PanelSubMenuFacturación.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuFacturación.Location = New System.Drawing.Point(0, 189)
        Me.PanelSubMenuFacturación.Name = "PanelSubMenuFacturación"
        Me.PanelSubMenuFacturación.Size = New System.Drawing.Size(230, 85)
        Me.PanelSubMenuFacturación.TabIndex = 11
        '
        'BListarVentas
        '
        Me.BListarVentas.BackColor = System.Drawing.Color.FloralWhite
        Me.BListarVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BListarVentas.FlatAppearance.BorderSize = 0
        Me.BListarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BListarVentas.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BListarVentas.ForeColor = System.Drawing.Color.Sienna
        Me.BListarVentas.Location = New System.Drawing.Point(0, 40)
        Me.BListarVentas.Name = "BListarVentas"
        Me.BListarVentas.Size = New System.Drawing.Size(230, 40)
        Me.BListarVentas.TabIndex = 2
        Me.BListarVentas.Text = "Listar Ventas"
        Me.BListarVentas.UseVisualStyleBackColor = False
        '
        'BNuevaVenta
        '
        Me.BNuevaVenta.BackColor = System.Drawing.Color.FloralWhite
        Me.BNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BNuevaVenta.FlatAppearance.BorderSize = 0
        Me.BNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNuevaVenta.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNuevaVenta.ForeColor = System.Drawing.Color.Sienna
        Me.BNuevaVenta.Location = New System.Drawing.Point(0, 0)
        Me.BNuevaVenta.Name = "BNuevaVenta"
        Me.BNuevaVenta.Size = New System.Drawing.Size(230, 40)
        Me.BNuevaVenta.TabIndex = 1
        Me.BNuevaVenta.Text = "Nueva Venta"
        Me.BNuevaVenta.UseVisualStyleBackColor = False
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.Sienna
        Me.BSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSalir.FlatAppearance.BorderSize = 2
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.Cornsilk
        Me.BSalir.Location = New System.Drawing.Point(0, 557)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(230, 33)
        Me.BSalir.TabIndex = 8
        Me.BSalir.Text = "Cerrar Sesión"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BFacturación
        '
        Me.BFacturación.BackColor = System.Drawing.Color.RosyBrown
        Me.BFacturación.Dock = System.Windows.Forms.DockStyle.Top
        Me.BFacturación.FlatAppearance.BorderSize = 0
        Me.BFacturación.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BFacturación.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFacturación.ForeColor = System.Drawing.Color.Cornsilk
        Me.BFacturación.Image = Global.Unitivo.My.Resources.Resources.icons8_cuenta_50
        Me.BFacturación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BFacturación.Location = New System.Drawing.Point(0, 137)
        Me.BFacturación.Name = "BFacturación"
        Me.BFacturación.Size = New System.Drawing.Size(230, 52)
        Me.BFacturación.TabIndex = 10
        Me.BFacturación.Text = "    Facturación"
        Me.BFacturación.UseVisualStyleBackColor = False
        '
        'PanelSubMenuClientes
        '
        Me.PanelSubMenuClientes.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuClientes.Controls.Add(Me.BListaClientes)
        Me.PanelSubMenuClientes.Controls.Add(Me.BAñadirClientes)
        Me.PanelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuClientes.Location = New System.Drawing.Point(0, 52)
        Me.PanelSubMenuClientes.Name = "PanelSubMenuClientes"
        Me.PanelSubMenuClientes.Size = New System.Drawing.Size(230, 85)
        Me.PanelSubMenuClientes.TabIndex = 9
        '
        'BListaClientes
        '
        Me.BListaClientes.BackColor = System.Drawing.Color.FloralWhite
        Me.BListaClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BListaClientes.FlatAppearance.BorderSize = 0
        Me.BListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BListaClientes.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BListaClientes.ForeColor = System.Drawing.Color.Sienna
        Me.BListaClientes.Location = New System.Drawing.Point(0, 40)
        Me.BListaClientes.Name = "BListaClientes"
        Me.BListaClientes.Size = New System.Drawing.Size(230, 40)
        Me.BListaClientes.TabIndex = 2
        Me.BListaClientes.Text = "Listar Clientes"
        Me.BListaClientes.UseVisualStyleBackColor = False
        '
        'BAñadirClientes
        '
        Me.BAñadirClientes.BackColor = System.Drawing.Color.FloralWhite
        Me.BAñadirClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirClientes.FlatAppearance.BorderSize = 0
        Me.BAñadirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirClientes.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirClientes.ForeColor = System.Drawing.Color.Sienna
        Me.BAñadirClientes.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirClientes.Name = "BAñadirClientes"
        Me.BAñadirClientes.Size = New System.Drawing.Size(230, 40)
        Me.BAñadirClientes.TabIndex = 1
        Me.BAñadirClientes.Text = "Añadir Clientes"
        Me.BAñadirClientes.UseVisualStyleBackColor = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.RosyBrown
        Me.BClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BClientes.FlatAppearance.BorderSize = 0
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClientes.ForeColor = System.Drawing.Color.Cornsilk
        Me.BClientes.Image = Global.Unitivo.My.Resources.Resources.icons8_contactos_50__1_
        Me.BClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.Location = New System.Drawing.Point(0, 0)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(230, 52)
        Me.BClientes.TabIndex = 0
        Me.BClientes.Text = "Clientes"
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'PanelFormVendedor
        '
        Me.PanelFormVendedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFormVendedor.BackgroundImage = Global.Unitivo.My.Resources.Resources.ImagenGrandeVendedor
        Me.PanelFormVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelFormVendedor.Controls.Add(Me.Label1)
        Me.PanelFormVendedor.Location = New System.Drawing.Point(230, 60)
        Me.PanelFormVendedor.Name = "PanelFormVendedor"
        Me.PanelFormVendedor.Size = New System.Drawing.Size(810, 590)
        Me.PanelFormVendedor.TabIndex = 3
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
        'MenuV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 650)
        Me.Controls.Add(Me.PanelFormVendedor)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuV"
        Me.Text = "Form1"
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelSubMenuProductos.ResumeLayout(False)
        Me.PanelSubMenuFacturación.ResumeLayout(False)
        Me.PanelSubMenuClientes.ResumeLayout(False)
        Me.PanelFormVendedor.ResumeLayout(False)
        Me.PanelFormVendedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents BMaximizarMenu As Button
    Friend WithEvents BCerrarMenu As Button
    Friend WithEvents BRestaurarMenu As Button
    Friend WithEvents BMinimizarMenu As Button
    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents BClientes As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents BAñadirClientes As Button
    Friend WithEvents PanelSubMenuProductos As Panel
    Friend WithEvents BListarProductos As Button
    Friend WithEvents BProductos As Button
    Friend WithEvents PanelSubMenuFacturación As Panel
    Friend WithEvents BListarVentas As Button
    Friend WithEvents BNuevaVenta As Button
    Friend WithEvents BFacturación As Button
    Friend WithEvents PanelSubMenuClientes As Panel
    Friend WithEvents BListaClientes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFormVendedor As Panel
End Class

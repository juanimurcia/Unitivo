<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSA
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
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.PanelSubMenuPerfiles = New System.Windows.Forms.Panel()
        Me.BGestionarPerfiles = New System.Windows.Forms.Button()
        Me.BAñadirPerfil = New System.Windows.Forms.Button()
        Me.PanelSubMenuEmpleados = New System.Windows.Forms.Panel()
        Me.BGestionarEmpleados = New System.Windows.Forms.Button()
        Me.BAñadirEmpleado = New System.Windows.Forms.Button()
        Me.PanelSubMenuUsuarios = New System.Windows.Forms.Panel()
        Me.BGestionarUsuarios = New System.Windows.Forms.Button()
        Me.BAñadirUsuario = New System.Windows.Forms.Button()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.PanelFormSuperAdministrador = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BPerfiles = New System.Windows.Forms.Button()
        Me.BEmpleados = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.BMaximizarMenuGerente = New System.Windows.Forms.Button()
        Me.BCerrarMenuGerente = New System.Windows.Forms.Button()
        Me.BRestaurarMenuGerente = New System.Windows.Forms.Button()
        Me.BMinimizarMenuGerente = New System.Windows.Forms.Button()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelSubMenuPerfiles.SuspendLayout()
        Me.PanelSubMenuEmpleados.SuspendLayout()
        Me.PanelSubMenuUsuarios.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        Me.PanelFormSuperAdministrador.SuspendLayout()
        Me.SuspendLayout()
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
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.Tan
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuPerfiles)
        Me.PanelMenuLateral.Controls.Add(Me.BPerfiles)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuEmpleados)
        Me.PanelMenuLateral.Controls.Add(Me.BSalir)
        Me.PanelMenuLateral.Controls.Add(Me.BEmpleados)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuUsuarios)
        Me.PanelMenuLateral.Controls.Add(Me.BUsuarios)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 60)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(230, 590)
        Me.PanelMenuLateral.TabIndex = 5
        '
        'PanelSubMenuPerfiles
        '
        Me.PanelSubMenuPerfiles.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuPerfiles.Controls.Add(Me.BGestionarPerfiles)
        Me.PanelSubMenuPerfiles.Controls.Add(Me.BAñadirPerfil)
        Me.PanelSubMenuPerfiles.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuPerfiles.Location = New System.Drawing.Point(0, 326)
        Me.PanelSubMenuPerfiles.Name = "PanelSubMenuPerfiles"
        Me.PanelSubMenuPerfiles.Size = New System.Drawing.Size(230, 91)
        Me.PanelSubMenuPerfiles.TabIndex = 13
        '
        'BGestionarPerfiles
        '
        Me.BGestionarPerfiles.BackColor = System.Drawing.Color.FloralWhite
        Me.BGestionarPerfiles.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarPerfiles.FlatAppearance.BorderSize = 0
        Me.BGestionarPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarPerfiles.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGestionarPerfiles.ForeColor = System.Drawing.Color.Sienna
        Me.BGestionarPerfiles.Location = New System.Drawing.Point(0, 40)
        Me.BGestionarPerfiles.Name = "BGestionarPerfiles"
        Me.BGestionarPerfiles.Size = New System.Drawing.Size(230, 40)
        Me.BGestionarPerfiles.TabIndex = 2
        Me.BGestionarPerfiles.Text = "Gestionar Perfiles"
        Me.BGestionarPerfiles.UseVisualStyleBackColor = False
        '
        'BAñadirPerfil
        '
        Me.BAñadirPerfil.BackColor = System.Drawing.Color.FloralWhite
        Me.BAñadirPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirPerfil.FlatAppearance.BorderSize = 0
        Me.BAñadirPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirPerfil.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirPerfil.ForeColor = System.Drawing.Color.Sienna
        Me.BAñadirPerfil.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirPerfil.Name = "BAñadirPerfil"
        Me.BAñadirPerfil.Size = New System.Drawing.Size(230, 40)
        Me.BAñadirPerfil.TabIndex = 1
        Me.BAñadirPerfil.Text = "Añadir Perfil"
        Me.BAñadirPerfil.UseVisualStyleBackColor = False
        '
        'PanelSubMenuEmpleados
        '
        Me.PanelSubMenuEmpleados.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuEmpleados.Controls.Add(Me.BGestionarEmpleados)
        Me.PanelSubMenuEmpleados.Controls.Add(Me.BAñadirEmpleado)
        Me.PanelSubMenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuEmpleados.Location = New System.Drawing.Point(0, 189)
        Me.PanelSubMenuEmpleados.Name = "PanelSubMenuEmpleados"
        Me.PanelSubMenuEmpleados.Size = New System.Drawing.Size(230, 85)
        Me.PanelSubMenuEmpleados.TabIndex = 11
        '
        'BGestionarEmpleados
        '
        Me.BGestionarEmpleados.BackColor = System.Drawing.Color.FloralWhite
        Me.BGestionarEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarEmpleados.FlatAppearance.BorderSize = 0
        Me.BGestionarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarEmpleados.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGestionarEmpleados.ForeColor = System.Drawing.Color.Sienna
        Me.BGestionarEmpleados.Location = New System.Drawing.Point(0, 40)
        Me.BGestionarEmpleados.Name = "BGestionarEmpleados"
        Me.BGestionarEmpleados.Size = New System.Drawing.Size(230, 40)
        Me.BGestionarEmpleados.TabIndex = 2
        Me.BGestionarEmpleados.Text = "Gestionar Empleados"
        Me.BGestionarEmpleados.UseVisualStyleBackColor = False
        '
        'BAñadirEmpleado
        '
        Me.BAñadirEmpleado.BackColor = System.Drawing.Color.FloralWhite
        Me.BAñadirEmpleado.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirEmpleado.FlatAppearance.BorderSize = 0
        Me.BAñadirEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirEmpleado.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirEmpleado.ForeColor = System.Drawing.Color.Sienna
        Me.BAñadirEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirEmpleado.Name = "BAñadirEmpleado"
        Me.BAñadirEmpleado.Size = New System.Drawing.Size(230, 40)
        Me.BAñadirEmpleado.TabIndex = 1
        Me.BAñadirEmpleado.Text = "Añadir Empleado"
        Me.BAñadirEmpleado.UseVisualStyleBackColor = False
        '
        'PanelSubMenuUsuarios
        '
        Me.PanelSubMenuUsuarios.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelSubMenuUsuarios.Controls.Add(Me.BGestionarUsuarios)
        Me.PanelSubMenuUsuarios.Controls.Add(Me.BAñadirUsuario)
        Me.PanelSubMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuUsuarios.Location = New System.Drawing.Point(0, 52)
        Me.PanelSubMenuUsuarios.Name = "PanelSubMenuUsuarios"
        Me.PanelSubMenuUsuarios.Size = New System.Drawing.Size(230, 85)
        Me.PanelSubMenuUsuarios.TabIndex = 9
        '
        'BGestionarUsuarios
        '
        Me.BGestionarUsuarios.BackColor = System.Drawing.Color.FloralWhite
        Me.BGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarUsuarios.FlatAppearance.BorderSize = 0
        Me.BGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarUsuarios.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGestionarUsuarios.ForeColor = System.Drawing.Color.Sienna
        Me.BGestionarUsuarios.Location = New System.Drawing.Point(0, 40)
        Me.BGestionarUsuarios.Name = "BGestionarUsuarios"
        Me.BGestionarUsuarios.Size = New System.Drawing.Size(230, 40)
        Me.BGestionarUsuarios.TabIndex = 2
        Me.BGestionarUsuarios.Text = "Gestionar Usuarios"
        Me.BGestionarUsuarios.UseVisualStyleBackColor = False
        '
        'BAñadirUsuario
        '
        Me.BAñadirUsuario.BackColor = System.Drawing.Color.FloralWhite
        Me.BAñadirUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirUsuario.FlatAppearance.BorderSize = 0
        Me.BAñadirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirUsuario.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirUsuario.ForeColor = System.Drawing.Color.Sienna
        Me.BAñadirUsuario.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirUsuario.Name = "BAñadirUsuario"
        Me.BAñadirUsuario.Size = New System.Drawing.Size(230, 40)
        Me.BAñadirUsuario.TabIndex = 1
        Me.BAñadirUsuario.Text = "Añadir Usuario"
        Me.BAñadirUsuario.UseVisualStyleBackColor = False
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.Tan
        Me.PanelBarraMenu.Controls.Add(Me.BMaximizarMenuGerente)
        Me.PanelBarraMenu.Controls.Add(Me.BCerrarMenuGerente)
        Me.PanelBarraMenu.Controls.Add(Me.BRestaurarMenuGerente)
        Me.PanelBarraMenu.Controls.Add(Me.BMinimizarMenuGerente)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1040, 60)
        Me.PanelBarraMenu.TabIndex = 4
        '
        'PanelFormSuperAdministrador
        '
        Me.PanelFormSuperAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFormSuperAdministrador.BackgroundImage = Global.Unitivo.My.Resources.Resources.duenos1
        Me.PanelFormSuperAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelFormSuperAdministrador.Controls.Add(Me.Label1)
        Me.PanelFormSuperAdministrador.Location = New System.Drawing.Point(230, 60)
        Me.PanelFormSuperAdministrador.Name = "PanelFormSuperAdministrador"
        Me.PanelFormSuperAdministrador.Size = New System.Drawing.Size(810, 590)
        Me.PanelFormSuperAdministrador.TabIndex = 6
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
        'BPerfiles
        '
        Me.BPerfiles.BackColor = System.Drawing.Color.RosyBrown
        Me.BPerfiles.Dock = System.Windows.Forms.DockStyle.Top
        Me.BPerfiles.FlatAppearance.BorderSize = 0
        Me.BPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPerfiles.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPerfiles.ForeColor = System.Drawing.Color.Cornsilk
        Me.BPerfiles.Image = Global.Unitivo.My.Resources.Resources.icons8_contactos_60
        Me.BPerfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BPerfiles.Location = New System.Drawing.Point(0, 274)
        Me.BPerfiles.Name = "BPerfiles"
        Me.BPerfiles.Size = New System.Drawing.Size(230, 52)
        Me.BPerfiles.TabIndex = 12
        Me.BPerfiles.Text = "Perfiles"
        Me.BPerfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BPerfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BPerfiles.UseVisualStyleBackColor = False
        '
        'BEmpleados
        '
        Me.BEmpleados.BackColor = System.Drawing.Color.RosyBrown
        Me.BEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BEmpleados.FlatAppearance.BorderSize = 0
        Me.BEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEmpleados.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEmpleados.ForeColor = System.Drawing.Color.Cornsilk
        Me.BEmpleados.Image = Global.Unitivo.My.Resources.Resources.icons8_contactos_50__2_
        Me.BEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEmpleados.Location = New System.Drawing.Point(0, 137)
        Me.BEmpleados.Name = "BEmpleados"
        Me.BEmpleados.Size = New System.Drawing.Size(230, 52)
        Me.BEmpleados.TabIndex = 10
        Me.BEmpleados.Text = "Empleados"
        Me.BEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEmpleados.UseVisualStyleBackColor = False
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.RosyBrown
        Me.BUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BUsuarios.FlatAppearance.BorderSize = 0
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarios.Font = New System.Drawing.Font("Cooper Black", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUsuarios.ForeColor = System.Drawing.Color.Cornsilk
        Me.BUsuarios.Image = Global.Unitivo.My.Resources.Resources.icons8_contactos_50__1_
        Me.BUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Size = New System.Drawing.Size(230, 52)
        Me.BUsuarios.TabIndex = 0
        Me.BUsuarios.Text = "Usuarios"
        Me.BUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'BMaximizarMenuGerente
        '
        Me.BMaximizarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenuGerente.BackgroundImage = Global.Unitivo.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenuGerente.Location = New System.Drawing.Point(948, 17)
        Me.BMaximizarMenuGerente.Name = "BMaximizarMenuGerente"
        Me.BMaximizarMenuGerente.Size = New System.Drawing.Size(30, 30)
        Me.BMaximizarMenuGerente.TabIndex = 3
        Me.BMaximizarMenuGerente.UseVisualStyleBackColor = True
        '
        'BCerrarMenuGerente
        '
        Me.BCerrarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarMenuGerente.BackgroundImage = Global.Unitivo.My.Resources.Resources.cerrarventana
        Me.BCerrarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BCerrarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenuGerente.Location = New System.Drawing.Point(990, 17)
        Me.BCerrarMenuGerente.Name = "BCerrarMenuGerente"
        Me.BCerrarMenuGerente.Size = New System.Drawing.Size(30, 30)
        Me.BCerrarMenuGerente.TabIndex = 2
        Me.BCerrarMenuGerente.UseVisualStyleBackColor = True
        '
        'BRestaurarMenuGerente
        '
        Me.BRestaurarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRestaurarMenuGerente.BackgroundImage = Global.Unitivo.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BRestaurarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenuGerente.Location = New System.Drawing.Point(950, 17)
        Me.BRestaurarMenuGerente.Name = "BRestaurarMenuGerente"
        Me.BRestaurarMenuGerente.Size = New System.Drawing.Size(30, 30)
        Me.BRestaurarMenuGerente.TabIndex = 1
        Me.BRestaurarMenuGerente.UseVisualStyleBackColor = True
        '
        'BMinimizarMenuGerente
        '
        Me.BMinimizarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMinimizarMenuGerente.BackgroundImage = Global.Unitivo.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BMinimizarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenuGerente.Location = New System.Drawing.Point(910, 17)
        Me.BMinimizarMenuGerente.Name = "BMinimizarMenuGerente"
        Me.BMinimizarMenuGerente.Size = New System.Drawing.Size(30, 30)
        Me.BMinimizarMenuGerente.TabIndex = 0
        Me.BMinimizarMenuGerente.UseVisualStyleBackColor = True
        '
        'MenuSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 650)
        Me.Controls.Add(Me.PanelFormSuperAdministrador)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuSA"
        Me.Text = "Form1"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelSubMenuPerfiles.ResumeLayout(False)
        Me.PanelSubMenuEmpleados.ResumeLayout(False)
        Me.PanelSubMenuUsuarios.ResumeLayout(False)
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.PanelFormSuperAdministrador.ResumeLayout(False)
        Me.PanelFormSuperAdministrador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BSalir As Button
    Friend WithEvents PanelFormSuperAdministrador As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelSubMenuPerfiles As Panel
    Friend WithEvents BAñadirPerfil As Button
    Friend WithEvents BPerfiles As Button
    Friend WithEvents PanelSubMenuEmpleados As Panel
    Friend WithEvents BGestionarEmpleados As Button
    Friend WithEvents BAñadirEmpleado As Button
    Friend WithEvents BEmpleados As Button
    Friend WithEvents PanelSubMenuUsuarios As Panel
    Friend WithEvents BGestionarUsuarios As Button
    Friend WithEvents BAñadirUsuario As Button
    Friend WithEvents BUsuarios As Button
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents BMaximizarMenuGerente As Button
    Friend WithEvents BCerrarMenuGerente As Button
    Friend WithEvents BRestaurarMenuGerente As Button
    Friend WithEvents BMinimizarMenuGerente As Button
    Friend WithEvents BGestionarPerfiles As Button
End Class

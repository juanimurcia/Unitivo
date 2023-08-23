<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PanelBarraMenuLogin = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxContraseña = New System.Windows.Forms.PictureBox()
        Me.BMaximizarMenu = New System.Windows.Forms.Button()
        Me.BCerrarMenu = New System.Windows.Forms.Button()
        Me.BRestaurarMenu = New System.Windows.Forms.Button()
        Me.BMinimizarMenu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBarraMenuLogin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraMenuLogin
        '
        Me.PanelBarraMenuLogin.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PanelBarraMenuLogin.Controls.Add(Me.BMaximizarMenu)
        Me.PanelBarraMenuLogin.Controls.Add(Me.BCerrarMenu)
        Me.PanelBarraMenuLogin.Controls.Add(Me.BRestaurarMenu)
        Me.PanelBarraMenuLogin.Controls.Add(Me.BMinimizarMenu)
        Me.PanelBarraMenuLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenuLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenuLogin.Name = "PanelBarraMenuLogin"
        Me.PanelBarraMenuLogin.Size = New System.Drawing.Size(760, 50)
        Me.PanelBarraMenuLogin.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel2.Controls.Add(Me.PictureBoxContraseña)
        Me.Panel2.Controls.Add(Me.TBContraseña)
        Me.Panel2.Controls.Add(Me.TBUsuario)
        Me.Panel2.Controls.Add(Me.BLogin)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(241, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 340)
        Me.Panel2.TabIndex = 1
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(66, 221)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(150, 20)
        Me.TBContraseña.TabIndex = 5
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(66, 146)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(150, 20)
        Me.TBUsuario.TabIndex = 4
        '
        'BLogin
        '
        Me.BLogin.FlatAppearance.BorderSize = 2
        Me.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLogin.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.ForeColor = System.Drawing.Color.HotPink
        Me.BLogin.Location = New System.Drawing.Point(71, 269)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(141, 39)
        Me.BLogin.TabIndex = 3
        Me.BLogin.Text = "Ingresar"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label3.Location = New System.Drawing.Point(67, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(86, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Iniciar Sesión"
        '
        'PictureBoxContraseña
        '
        Me.PictureBoxContraseña.BackColor = System.Drawing.Color.White
        Me.PictureBoxContraseña.BackgroundImage = Global.Unitivo.My.Resources.Resources.ojo_cerrado
        Me.PictureBoxContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxContraseña.Location = New System.Drawing.Point(189, 223)
        Me.PictureBoxContraseña.Name = "PictureBoxContraseña"
        Me.PictureBoxContraseña.Size = New System.Drawing.Size(25, 16)
        Me.PictureBoxContraseña.TabIndex = 6
        Me.PictureBoxContraseña.TabStop = False
        '
        'BMaximizarMenu
        '
        Me.BMaximizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenu.BackgroundImage = Global.Unitivo.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenu.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenu.Location = New System.Drawing.Point(670, 12)
        Me.BMaximizarMenu.Name = "BMaximizarMenu"
        Me.BMaximizarMenu.Size = New System.Drawing.Size(25, 25)
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
        Me.BCerrarMenu.Location = New System.Drawing.Point(710, 12)
        Me.BCerrarMenu.Name = "BCerrarMenu"
        Me.BCerrarMenu.Size = New System.Drawing.Size(25, 25)
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
        Me.BRestaurarMenu.Location = New System.Drawing.Point(670, 12)
        Me.BRestaurarMenu.Name = "BRestaurarMenu"
        Me.BRestaurarMenu.Size = New System.Drawing.Size(25, 25)
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
        Me.BMinimizarMenu.Location = New System.Drawing.Point(629, 12)
        Me.BMinimizarMenu.Name = "BMinimizarMenu"
        Me.BMinimizarMenu.Size = New System.Drawing.Size(25, 25)
        Me.BMinimizarMenu.TabIndex = 0
        Me.BMinimizarMenu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackgroundImage = Global.Unitivo.My.Resources.Resources.imggrande4
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 410)
        Me.Panel1.TabIndex = 2
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 460)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelBarraMenuLogin)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.PanelBarraMenuLogin.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraMenuLogin As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxContraseña As PictureBox
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents BLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BMinimizarMenu As Button
    Friend WithEvents BRestaurarMenu As Button
    Friend WithEvents BCerrarMenu As Button
    Friend WithEvents BMaximizarMenu As Button
    Friend WithEvents Panel1 As Panel
End Class

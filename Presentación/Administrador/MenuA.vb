Public Class MenuA

    Private state As Integer
    Private px, py As Integer
    Private mover As Boolean

    Private Sub G_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(900, 500)
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        PanelSubMenuProductos.Visible = False
        PanelSubMenuCategorias.Visible = False
        PanelSubMenuVentas.Visible = False
        PanelSubMenuTalles.Visible = False
        PanelSubMenuClientes.Visible = False

    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub BProductosAdmin_Click(sender As Object, e As EventArgs) Handles BProductosAdmin.Click
        showSubMenu(PanelSubMenuProductos)
    End Sub

    Private Sub BAñadirProductosAdmin_Click(sender As Object, e As EventArgs) Handles BAñadirProductoAdmin.Click
        AbrirFormulariosAdmin(New AñadirProducto)
    End Sub

    Private Sub BGestionarProductosAdmin_Click(sender As Object, e As EventArgs) Handles BGestionarProductosAdmin.Click
        AbrirFormulariosAdmin(New GestionarProductos)
    End Sub

    Private Sub BVentasAdmin_Click(sender As Object, e As EventArgs) Handles BVentasAdmin.Click
        showSubMenu(PanelSubMenuVentas)
    End Sub

    Private Sub BListarVentasAdmin_Click(sender As Object, e As EventArgs) Handles BListarVentasAdmin.Click
        AbrirFormulariosAdmin(New ListarVentasAdmin)
    End Sub

    Private Sub BListarVendedoresAdmin_Click(sender As Object, e As EventArgs) Handles BListarVendedoresAdmin.Click
        AbrirFormulariosAdmin(New ListarVendedores)
    End Sub

    Private Sub BCategoriasAdmin_Click(sender As Object, e As EventArgs) Handles BCategoriasAdmin.Click
        showSubMenu(PanelSubMenuCategorias)
    End Sub

    Private Sub BAñadirCategoria_Click(sender As Object, e As EventArgs) Handles BAñadirCategoria.Click
        AbrirFormulariosAdmin(New AñadirCategoria)
    End Sub

    Private Sub BGestionarCategorias_Click(sender As Object, e As EventArgs) Handles BGestionarCategorias.Click
        AbrirFormulariosAdmin(New GestionarCategorias)
    End Sub

    Private Sub BTalles_Click(sender As Object, e As EventArgs) Handles BTalles.Click
        showSubMenu(PanelSubMenuTalles)
    End Sub

    Private Sub BAñadirTalle_Click(sender As Object, e As EventArgs) Handles BAñadirTalle.Click
        AbrirFormulariosAdmin(New AñadirTalle)
    End Sub

    Private Sub BGestionarTalles_Click(sender As Object, e As EventArgs) Handles BGestionarTalles.Click
        AbrirFormulariosAdmin(New GestionarTalles)
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        showSubMenu(PanelSubMenuClientes)
    End Sub

    Private Sub BGestionarClientes_Click(sender As Object, e As EventArgs) Handles BGestionarClientes.Click
        AbrirFormulariosAdmin(New GestionarClientes)
    End Sub




    Private formActivoAdmin As Form = Nothing
    Private Sub AbrirFormulariosAdmin(formHijo As Form)
        If Not formActivoAdmin IsNot Nothing Then
            PanelFormAdmin.Controls.Clear()
            formHijo.TopLevel = False
            formHijo.FormBorderStyle = FormBorderStyle.None
            formHijo.Dock = DockStyle.Fill
            formHijo.Visible = True
            formHijo.AutoScroll = True
            formHijo.VerticalScroll.Value = 0
            formHijo.VerticalScroll.Minimum = 0
            formHijo.VerticalScroll.Maximum = formHijo.Size.Height - 100
            formHijo.HorizontalScroll.Value = 0
            formHijo.HorizontalScroll.Minimum = 0
            formHijo.HorizontalScroll.Maximum = formHijo.Size.Width - 100
            PanelFormAdmin.Controls.Add(formHijo)
            PanelFormAdmin.Tag = formHijo
            PanelFormAdmin.BringToFront()
            PanelFormAdmin.AutoScroll = True
            formHijo.Show()
            hideSubMenu()

        End If
    End Sub


    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta seguro de que quiere cerrar sesión?", vbExclamation + vbYesNo, "Cerrar Aplicación")
        If ask = vbYes Then
            Me.Close()
            Login.Show()
            Login.TBUsuario.Clear()
            Login.TBContraseña.Clear()
        End If

    End Sub

    Private Sub BCerrarMenuAdmin_Click(sender As Object, e As EventArgs) Handles BCerrarMenuAdmin.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta seguro de que quiere cerrar la aplicación?", vbExclamation + vbYesNo, "Cerrar Aplicación")
        If ask = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BMaximizarMenuAdmin_Click(sender As Object, e As EventArgs) Handles BMaximizarMenuAdmin.Click
        BMaximizarMenuAdmin.Visible = False
        BRestaurarMenuAdmin.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BRestaurarMenuAdmin_Click(sender As Object, e As EventArgs) Handles BRestaurarMenuAdmin.Click
        BRestaurarMenuAdmin.Visible = False
        BMaximizarMenuAdmin.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BMinimizarMenuAdmin_Click(sender As Object, e As EventArgs) Handles BMinimizarMenuAdmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelBarraMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PanelBarraMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseUp
        mover = False
    End Sub



    Private Sub PanelBarraMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

End Class
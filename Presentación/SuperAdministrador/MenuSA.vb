﻿Public Class MenuSA
    Private state As Integer
    Private px, py As Integer
    Private mover As Boolean

    Private Sub MenuA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(900, 500)
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        PanelSubMenuUsuarios.Visible = False
        PanelSubMenuEmpleados.Visible = False
        PanelSubMenuPerfiles.Visible = False
    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
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

    Private Sub BCerrarMenuGerente_Click(sender As Object, e As EventArgs) Handles BCerrarMenuGerente.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta seguro de que quiere cerrar sesión?", vbExclamation + vbYesNo, "Cerrar Sesión")
        If ask = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BMaximizarMenuGerente_Click(sender As Object, e As EventArgs) Handles BMaximizarMenuGerente.Click
        BMaximizarMenuGerente.Visible = False
        BRestaurarMenuGerente.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BRestaurarMenuGerente_Click(sender As Object, e As EventArgs) Handles BRestaurarMenuGerente.Click
        BRestaurarMenuGerente.Visible = False
        BMaximizarMenuGerente.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BMinimizarMenuGerente_Click(sender As Object, e As EventArgs) Handles BMinimizarMenuGerente.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelBarraMenuAdmin_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PanelBarraMenuAdmin_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseUp
        mover = False
    End Sub
    Private Sub PanelBarraMenuAdmin_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub


    Private Sub BUsuarios_Click(sender As Object, e As EventArgs) Handles BUsuarios.Click
        showSubMenu(PanelSubMenuUsuarios)
    End Sub

    Private Sub BAñadirUsuario_Click(sender As Object, e As EventArgs) Handles BAñadirUsuario.Click
        AbrirFormulariosAdministrador(New AñadirUsuario)
    End Sub

    Private Sub BGestionarUsuarios_Click(sender As Object, e As EventArgs) Handles BGestionarUsuarios.Click
        AbrirFormulariosAdministrador(New GestionarUsuarios)
    End Sub


    Private Sub BEmpleados_Click(sender As Object, e As EventArgs) Handles BEmpleados.Click
        showSubMenu(PanelSubMenuEmpleados)
    End Sub

    Private Sub BAñadirEmpleado_Click(sender As Object, e As EventArgs) Handles BAñadirEmpleado.Click
        AbrirFormulariosAdministrador(New AñadirEmpleado)
    End Sub


    Private Sub BGestionarEmpleados_Click(sender As Object, e As EventArgs) Handles BGestionarEmpleados.Click
        AbrirFormulariosAdministrador(New GestionarEmpleados)
    End Sub

    Private Sub BPerfiles_Click(sender As Object, e As EventArgs) Handles BPerfiles.Click
        showSubMenu(PanelSubMenuPerfiles)
    End Sub

    Private Sub BAñadirPerfil_Click(sender As Object, e As EventArgs) Handles BAñadirPerfil.Click
        AbrirFormulariosAdministrador(New AñadirPerfil)
    End Sub

    Private Sub BGestionarPerfiles_Click(sender As Object, e As EventArgs) Handles BGestionarPerfiles.Click
        AbrirFormulariosAdministrador(New GestionarPerfiles)
    End Sub



    Private formActivoAdministrador As Form = Nothing


    Private Sub AbrirFormulariosAdministrador(formHijo As Form)
        If Not formActivoAdministrador IsNot Nothing Then
            PanelFormSuperAdministrador.Controls.Clear()
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
            PanelFormSuperAdministrador.AutoScroll = True
            PanelFormSuperAdministrador.Controls.Add(formHijo)
            PanelFormSuperAdministrador.Tag = formHijo
            PanelFormSuperAdministrador.BringToFront()
            formHijo.Show()
            hideSubMenu()
        End If
    End Sub

End Class
﻿Public Class GestionarTalles

    'Private objNTalle As NTalle = New NTalle
    'Private objDtalle As DTalle = New DTalle
    'Private Sub BModificarTalle_Click(sender As Object, e As EventArgs) Handles BModificarTalle.Click
    '    If (dgvRegTalles.SelectedRows.Count > 0) Or (dgvRegTalles.SelectedCells.Count > 0) Then
    '        Dim frm As New ModificarTalle
    '        frm.fila = dgvRegTalles.CurrentRow.Cells(0).Value.ToString
    '        frm.TBModTalle.Text = dgvRegTalles.CurrentRow.Cells(1).Value.ToString
    '        frm.ShowInTaskbar = False
    '        frm.ShowDialog()
    '        objNTalle.cargarGrid(dgvRegTalles)

    '    Else
    '        MsgBox("Por favor seleccione una fila", vbExclamation)
    '    End If

    'End Sub
    Private Sub TBBuscarTalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuscarTalle.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub dgvListarTalles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarTalles.CellContentClick

    End Sub

    'Private Sub GestionarTalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    objNTalle.cargarGrid(dgvRegTalles)
    'End Sub

    'Private Sub BEliminarTalle_Click(sender As Object, e As EventArgs) Handles BEliminarTalle.Click
    '    If (dgvRegTalles.SelectedRows.Count > 0) Or (dgvRegTalles.SelectedCells.Count > 0) Then
    '        Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
    '        If ask = vbYes Then
    '            objDtalle.EliminarTalle(CInt(dgvRegTalles.CurrentRow.Cells(0).Value.ToString))
    '            objNTalle.cargarGrid(dgvRegTalles)
    '        End If
    '    Else
    '        MsgBox("Por favor seleccione una fila", vbExclamation)
    '    End If

    'End Sub

    'Private Sub BAltaTalle_Click(sender As Object, e As EventArgs) Handles BAltaTalle.Click
    '    If (dgvRegTalles.SelectedRows.Count > 0) Or (dgvRegTalles.SelectedCells.Count > 0) Then
    '        Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
    '        If ask = vbYes Then
    '            objDtalle.Altatalle(CInt(dgvRegTalles.CurrentRow.Cells(0).Value.ToString))
    '            objNTalle.cargarGrid(dgvRegTalles)
    '        End If
    '    Else
    '        MsgBox("Por favor seleccione una fila", vbExclamation)
    '    End If
    'End Sub

End Class
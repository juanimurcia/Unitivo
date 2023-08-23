<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarTalle
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
        Me.PanelModTalle = New System.Windows.Forms.Panel()
        Me.BCancelarModifTalle = New System.Windows.Forms.Button()
        Me.GroupBoxDatosTalles = New System.Windows.Forms.GroupBox()
        Me.TBModTalle = New System.Windows.Forms.TextBox()
        Me.LModTalle = New System.Windows.Forms.Label()
        Me.BModificarTalle = New System.Windows.Forms.Button()
        Me.PanelModTalle.SuspendLayout()
        Me.GroupBoxDatosTalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModTalle
        '
        Me.PanelModTalle.BackColor = System.Drawing.Color.RosyBrown
        Me.PanelModTalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModTalle.Controls.Add(Me.BCancelarModifTalle)
        Me.PanelModTalle.Controls.Add(Me.GroupBoxDatosTalles)
        Me.PanelModTalle.Controls.Add(Me.BModificarTalle)
        Me.PanelModTalle.Location = New System.Drawing.Point(171, 74)
        Me.PanelModTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelModTalle.Name = "PanelModTalle"
        Me.PanelModTalle.Size = New System.Drawing.Size(459, 302)
        Me.PanelModTalle.TabIndex = 9
        '
        'BCancelarModifTalle
        '
        Me.BCancelarModifTalle.BackColor = System.Drawing.Color.Sienna
        Me.BCancelarModifTalle.FlatAppearance.BorderSize = 2
        Me.BCancelarModifTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelarModifTalle.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifTalle.Location = New System.Drawing.Point(183, 240)
        Me.BCancelarModifTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarModifTalle.Name = "BCancelarModifTalle"
        Me.BCancelarModifTalle.Size = New System.Drawing.Size(98, 42)
        Me.BCancelarModifTalle.TabIndex = 12
        Me.BCancelarModifTalle.Text = "Volver"
        Me.BCancelarModifTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifTalle.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosTalles
        '
        Me.GroupBoxDatosTalles.Controls.Add(Me.TBModTalle)
        Me.GroupBoxDatosTalles.Controls.Add(Me.LModTalle)
        Me.GroupBoxDatosTalles.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosTalles.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosTalles.Location = New System.Drawing.Point(38, 18)
        Me.GroupBoxDatosTalles.Name = "GroupBoxDatosTalles"
        Me.GroupBoxDatosTalles.Size = New System.Drawing.Size(355, 200)
        Me.GroupBoxDatosTalles.TabIndex = 19
        Me.GroupBoxDatosTalles.TabStop = False
        Me.GroupBoxDatosTalles.Text = "Modificar Talle"
        '
        'TBModTalle
        '
        Me.TBModTalle.Location = New System.Drawing.Point(95, 98)
        Me.TBModTalle.Name = "TBModTalle"
        Me.TBModTalle.Size = New System.Drawing.Size(167, 35)
        Me.TBModTalle.TabIndex = 16
        '
        'LModTalle
        '
        Me.LModTalle.AutoSize = True
        Me.LModTalle.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModTalle.ForeColor = System.Drawing.Color.White
        Me.LModTalle.Location = New System.Drawing.Point(92, 69)
        Me.LModTalle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LModTalle.Name = "LModTalle"
        Me.LModTalle.Size = New System.Drawing.Size(66, 21)
        Me.LModTalle.TabIndex = 15
        Me.LModTalle.Text = "Talle : "
        '
        'BModificarTalle
        '
        Me.BModificarTalle.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BModificarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarTalle.FlatAppearance.BorderSize = 2
        Me.BModificarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarTalle.ForeColor = System.Drawing.Color.White
        Me.BModificarTalle.Location = New System.Drawing.Point(295, 240)
        Me.BModificarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarTalle.Name = "BModificarTalle"
        Me.BModificarTalle.Size = New System.Drawing.Size(98, 42)
        Me.BModificarTalle.TabIndex = 13
        Me.BModificarTalle.Text = "Modificar"
        Me.BModificarTalle.UseVisualStyleBackColor = False
        '
        'ModificarTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelModTalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarTalle"
        Me.Text = "Form1"
        Me.PanelModTalle.ResumeLayout(False)
        Me.GroupBoxDatosTalles.ResumeLayout(False)
        Me.GroupBoxDatosTalles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModTalle As Panel
    Friend WithEvents BCancelarModifTalle As Button
    Friend WithEvents GroupBoxDatosTalles As GroupBox
    Friend WithEvents TBModTalle As TextBox
    Friend WithEvents LModTalle As Label
    Friend WithEvents BModificarTalle As Button
End Class

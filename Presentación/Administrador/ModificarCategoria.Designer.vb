<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCategoria
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
        Me.PanelModCategoria = New System.Windows.Forms.Panel()
        Me.BCancelarModifCategoria = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.TBNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LModCategoria = New System.Windows.Forms.Label()
        Me.BModificarCategoria = New System.Windows.Forms.Button()
        Me.PanelModCategoria.SuspendLayout()
        Me.GroupBoxDatosCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModCategoria
        '
        Me.PanelModCategoria.BackColor = System.Drawing.Color.RosyBrown
        Me.PanelModCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModCategoria.Controls.Add(Me.BCancelarModifCategoria)
        Me.PanelModCategoria.Controls.Add(Me.GroupBoxDatosCategoria)
        Me.PanelModCategoria.Controls.Add(Me.BModificarCategoria)
        Me.PanelModCategoria.Location = New System.Drawing.Point(171, 74)
        Me.PanelModCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelModCategoria.Name = "PanelModCategoria"
        Me.PanelModCategoria.Size = New System.Drawing.Size(459, 302)
        Me.PanelModCategoria.TabIndex = 8
        '
        'BCancelarModifCategoria
        '
        Me.BCancelarModifCategoria.BackColor = System.Drawing.Color.Sienna
        Me.BCancelarModifCategoria.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCategoria.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelarModifCategoria.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCategoria.Location = New System.Drawing.Point(183, 240)
        Me.BCancelarModifCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarModifCategoria.Name = "BCancelarModifCategoria"
        Me.BCancelarModifCategoria.Size = New System.Drawing.Size(98, 42)
        Me.BCancelarModifCategoria.TabIndex = 12
        Me.BCancelarModifCategoria.Text = "Volver"
        Me.BCancelarModifCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCategoria.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCategoria
        '
        Me.GroupBoxDatosCategoria.Controls.Add(Me.TBNombreCategoria)
        Me.GroupBoxDatosCategoria.Controls.Add(Me.LModCategoria)
        Me.GroupBoxDatosCategoria.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosCategoria.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCategoria.Location = New System.Drawing.Point(38, 18)
        Me.GroupBoxDatosCategoria.Name = "GroupBoxDatosCategoria"
        Me.GroupBoxDatosCategoria.Size = New System.Drawing.Size(355, 200)
        Me.GroupBoxDatosCategoria.TabIndex = 19
        Me.GroupBoxDatosCategoria.TabStop = False
        Me.GroupBoxDatosCategoria.Text = "Modificar Categoria"
        '
        'TBNombreCategoria
        '
        Me.TBNombreCategoria.Location = New System.Drawing.Point(95, 98)
        Me.TBNombreCategoria.Name = "TBNombreCategoria"
        Me.TBNombreCategoria.Size = New System.Drawing.Size(167, 35)
        Me.TBNombreCategoria.TabIndex = 16
        '
        'LModCategoria
        '
        Me.LModCategoria.AutoSize = True
        Me.LModCategoria.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModCategoria.ForeColor = System.Drawing.Color.White
        Me.LModCategoria.Location = New System.Drawing.Point(92, 69)
        Me.LModCategoria.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LModCategoria.Name = "LModCategoria"
        Me.LModCategoria.Size = New System.Drawing.Size(106, 21)
        Me.LModCategoria.TabIndex = 15
        Me.LModCategoria.Text = "Categoria : "
        '
        'BModificarCategoria
        '
        Me.BModificarCategoria.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BModificarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCategoria.FlatAppearance.BorderSize = 2
        Me.BModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCategoria.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarCategoria.ForeColor = System.Drawing.Color.White
        Me.BModificarCategoria.Location = New System.Drawing.Point(295, 240)
        Me.BModificarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarCategoria.Name = "BModificarCategoria"
        Me.BModificarCategoria.Size = New System.Drawing.Size(98, 42)
        Me.BModificarCategoria.TabIndex = 13
        Me.BModificarCategoria.Text = "Modificar"
        Me.BModificarCategoria.UseVisualStyleBackColor = False
        '
        'ModificarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelModCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarCategoria"
        Me.Text = "Form1"
        Me.PanelModCategoria.ResumeLayout(False)
        Me.GroupBoxDatosCategoria.ResumeLayout(False)
        Me.GroupBoxDatosCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModCategoria As Panel
    Friend WithEvents BCancelarModifCategoria As Button
    Friend WithEvents GroupBoxDatosCategoria As GroupBox
    Friend WithEvents TBNombreCategoria As TextBox
    Friend WithEvents LModCategoria As Label
    Friend WithEvents BModificarCategoria As Button
End Class

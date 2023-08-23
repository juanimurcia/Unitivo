<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarVendedores
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
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BImprimirVendedor = New System.Windows.Forms.Button()
        Me.TabControlListaVendedores = New System.Windows.Forms.TabControl()
        Me.TabPageListaVendedores = New System.Windows.Forms.TabPage()
        Me.dgvListarVendedores = New System.Windows.Forms.DataGridView()
        Me.GroupBoxVendedor = New System.Windows.Forms.GroupBox()
        Me.BBuscarVendedor = New System.Windows.Forms.Button()
        Me.TBBuscarVendedor = New System.Windows.Forms.TextBox()
        Me.TabControlListaVendedores.SuspendLayout()
        Me.TabPageListaVendedores.SuspendLayout()
        CType(Me.dgvListarVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(554, 388)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 38)
        Me.BVolver.TabIndex = 24
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BImprimirVendedor
        '
        Me.BImprimirVendedor.BackColor = System.Drawing.Color.SteelBlue
        Me.BImprimirVendedor.ForeColor = System.Drawing.Color.White
        Me.BImprimirVendedor.Image = Global.Unitivo.My.Resources.Resources.icons8_imprimir_26
        Me.BImprimirVendedor.Location = New System.Drawing.Point(701, 251)
        Me.BImprimirVendedor.Name = "BImprimirVendedor"
        Me.BImprimirVendedor.Size = New System.Drawing.Size(50, 45)
        Me.BImprimirVendedor.TabIndex = 22
        Me.BImprimirVendedor.UseVisualStyleBackColor = False
        '
        'TabControlListaVendedores
        '
        Me.TabControlListaVendedores.Controls.Add(Me.TabPageListaVendedores)
        Me.TabControlListaVendedores.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaVendedores.Location = New System.Drawing.Point(75, 157)
        Me.TabControlListaVendedores.Name = "TabControlListaVendedores"
        Me.TabControlListaVendedores.SelectedIndex = 0
        Me.TabControlListaVendedores.Size = New System.Drawing.Size(585, 215)
        Me.TabControlListaVendedores.TabIndex = 21
        '
        'TabPageListaVendedores
        '
        Me.TabPageListaVendedores.Controls.Add(Me.dgvListarVendedores)
        Me.TabPageListaVendedores.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaVendedores.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaVendedores.Name = "TabPageListaVendedores"
        Me.TabPageListaVendedores.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaVendedores.Size = New System.Drawing.Size(577, 186)
        Me.TabPageListaVendedores.TabIndex = 0
        Me.TabPageListaVendedores.Text = "Lista de Vendedores"
        Me.TabPageListaVendedores.UseVisualStyleBackColor = True
        '
        'dgvListarVendedores
        '
        Me.dgvListarVendedores.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvListarVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarVendedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarVendedores.Location = New System.Drawing.Point(3, 3)
        Me.dgvListarVendedores.Name = "dgvListarVendedores"
        Me.dgvListarVendedores.Size = New System.Drawing.Size(571, 180)
        Me.dgvListarVendedores.TabIndex = 0
        '
        'GroupBoxVendedor
        '
        Me.GroupBoxVendedor.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBoxVendedor.Controls.Add(Me.BBuscarVendedor)
        Me.GroupBoxVendedor.Controls.Add(Me.TBBuscarVendedor)
        Me.GroupBoxVendedor.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxVendedor.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBoxVendedor.Location = New System.Drawing.Point(176, 29)
        Me.GroupBoxVendedor.Name = "GroupBoxVendedor"
        Me.GroupBoxVendedor.Size = New System.Drawing.Size(400, 100)
        Me.GroupBoxVendedor.TabIndex = 20
        Me.GroupBoxVendedor.TabStop = False
        Me.GroupBoxVendedor.Text = "Vendedores"
        '
        'BBuscarVendedor
        '
        Me.BBuscarVendedor.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BBuscarVendedor.ForeColor = System.Drawing.Color.White
        Me.BBuscarVendedor.Image = Global.Unitivo.My.Resources.Resources.icons8_búsqueda_26
        Me.BBuscarVendedor.Location = New System.Drawing.Point(274, 43)
        Me.BBuscarVendedor.Name = "BBuscarVendedor"
        Me.BBuscarVendedor.Size = New System.Drawing.Size(45, 40)
        Me.BBuscarVendedor.TabIndex = 2
        Me.BBuscarVendedor.UseVisualStyleBackColor = False
        '
        'TBBuscarVendedor
        '
        Me.TBBuscarVendedor.Location = New System.Drawing.Point(81, 47)
        Me.TBBuscarVendedor.Name = "TBBuscarVendedor"
        Me.TBBuscarVendedor.Size = New System.Drawing.Size(166, 32)
        Me.TBBuscarVendedor.TabIndex = 1
        '
        'ListarVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BImprimirVendedor)
        Me.Controls.Add(Me.TabControlListaVendedores)
        Me.Controls.Add(Me.GroupBoxVendedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarVendedores"
        Me.Text = "Form1"
        Me.TabControlListaVendedores.ResumeLayout(False)
        Me.TabPageListaVendedores.ResumeLayout(False)
        CType(Me.dgvListarVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVendedor.ResumeLayout(False)
        Me.GroupBoxVendedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents BImprimirVendedor As Button
    Friend WithEvents TabControlListaVendedores As TabControl
    Friend WithEvents TabPageListaVendedores As TabPage
    Friend WithEvents dgvListarVendedores As DataGridView
    Friend WithEvents GroupBoxVendedor As GroupBox
    Friend WithEvents BBuscarVendedor As Button
    Friend WithEvents TBBuscarVendedor As TextBox
End Class

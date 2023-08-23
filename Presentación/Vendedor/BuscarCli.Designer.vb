<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCli
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.TabControlListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPafeListaClientes = New System.Windows.Forms.TabPage()
        Me.dgvListarCliente = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControlListaClientes.SuspendLayout()
        Me.TabPafeListaClientes.SuspendLayout()
        CType(Me.dgvListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.Cornsilk
        Me.BVolver.Location = New System.Drawing.Point(274, 402)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(106, 36)
        Me.BVolver.TabIndex = 21
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BSeleccionar
        '
        Me.BSeleccionar.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BSeleccionar.FlatAppearance.BorderSize = 2
        Me.BSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSeleccionar.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSeleccionar.ForeColor = System.Drawing.Color.Cornsilk
        Me.BSeleccionar.Location = New System.Drawing.Point(424, 402)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(144, 36)
        Me.BSeleccionar.TabIndex = 22
        Me.BSeleccionar.Text = "Seleccionar"
        Me.BSeleccionar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BSeleccionar.UseVisualStyleBackColor = False
        '
        'TabControlListaClientes
        '
        Me.TabControlListaClientes.Controls.Add(Me.TabPafeListaClientes)
        Me.TabControlListaClientes.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaClientes.Location = New System.Drawing.Point(66, 30)
        Me.TabControlListaClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlListaClientes.Name = "TabControlListaClientes"
        Me.TabControlListaClientes.SelectedIndex = 0
        Me.TabControlListaClientes.Size = New System.Drawing.Size(671, 340)
        Me.TabControlListaClientes.TabIndex = 23
        '
        'TabPafeListaClientes
        '
        Me.TabPafeListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TabPafeListaClientes.Controls.Add(Me.dgvListarCliente)
        Me.TabPafeListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabPafeListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPafeListaClientes.Location = New System.Drawing.Point(4, 25)
        Me.TabPafeListaClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPafeListaClientes.Name = "TabPafeListaClientes"
        Me.TabPafeListaClientes.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPafeListaClientes.Size = New System.Drawing.Size(663, 311)
        Me.TabPafeListaClientes.TabIndex = 0
        Me.TabPafeListaClientes.Text = "Lista de Clientes"
        '
        'dgvListarCliente
        '
        Me.dgvListarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarCliente.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvListarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListarCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarCliente.ColumnHeadersHeight = 20
        Me.dgvListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvListarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarCliente.EnableHeadersVisualStyles = False
        Me.dgvListarCliente.Location = New System.Drawing.Point(2, 2)
        Me.dgvListarCliente.Name = "dgvListarCliente"
        Me.dgvListarCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarCliente.RowHeadersWidth = 51
        Me.dgvListarCliente.Size = New System.Drawing.Size(659, 307)
        Me.dgvListarCliente.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DNI"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Telefono"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Dirección"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'BuscarCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControlListaClientes)
        Me.Controls.Add(Me.BSeleccionar)
        Me.Controls.Add(Me.BVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarCli"
        Me.Text = "Form1"
        Me.TabControlListaClientes.ResumeLayout(False)
        Me.TabPafeListaClientes.ResumeLayout(False)
        CType(Me.dgvListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents BSeleccionar As Button
    Friend WithEvents TabControlListaClientes As TabControl
    Friend WithEvents TabPafeListaClientes As TabPage
    Friend WithEvents dgvListarCliente As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class

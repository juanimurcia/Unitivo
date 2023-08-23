<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirCategoria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TabControlRegCategoria = New System.Windows.Forms.TabControl()
        Me.TabPageListaCategoria = New System.Windows.Forms.TabPage()
        Me.dgvRegistroCategoria = New System.Windows.Forms.DataGridView()
        Me.PanelRegCategoria = New System.Windows.Forms.Panel()
        Me.BRegistrarCategoria = New System.Windows.Forms.Button()
        Me.TBNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LNombreCategoria = New System.Windows.Forms.Label()
        Me.TabControlRegCategoria.SuspendLayout()
        Me.TabPageListaCategoria.SuspendLayout()
        CType(Me.dgvRegistroCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(568, 430)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(100, 42)
        Me.BVolver.TabIndex = 38
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TabControlRegCategoria
        '
        Me.TabControlRegCategoria.Controls.Add(Me.TabPageListaCategoria)
        Me.TabControlRegCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegCategoria.Location = New System.Drawing.Point(133, 173)
        Me.TabControlRegCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlRegCategoria.Name = "TabControlRegCategoria"
        Me.TabControlRegCategoria.SelectedIndex = 0
        Me.TabControlRegCategoria.Size = New System.Drawing.Size(535, 242)
        Me.TabControlRegCategoria.TabIndex = 37
        '
        'TabPageListaCategoria
        '
        Me.TabPageListaCategoria.Controls.Add(Me.dgvRegistroCategoria)
        Me.TabPageListaCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaCategoria.ForeColor = System.Drawing.Color.White
        Me.TabPageListaCategoria.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaCategoria.Name = "TabPageListaCategoria"
        Me.TabPageListaCategoria.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaCategoria.Size = New System.Drawing.Size(527, 213)
        Me.TabPageListaCategoria.TabIndex = 0
        Me.TabPageListaCategoria.Text = "Lista de Categorias"
        Me.TabPageListaCategoria.UseVisualStyleBackColor = True
        '
        'dgvRegistroCategoria
        '
        Me.dgvRegistroCategoria.AllowUserToAddRows = False
        Me.dgvRegistroCategoria.AllowUserToDeleteRows = False
        Me.dgvRegistroCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroCategoria.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvRegistroCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistroCategoria.ColumnHeadersHeight = 20
        Me.dgvRegistroCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroCategoria.EnableHeadersVisualStyles = False
        Me.dgvRegistroCategoria.Location = New System.Drawing.Point(2, 2)
        Me.dgvRegistroCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRegistroCategoria.Name = "dgvRegistroCategoria"
        Me.dgvRegistroCategoria.ReadOnly = True
        Me.dgvRegistroCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistroCategoria.RowHeadersWidth = 51
        Me.dgvRegistroCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRegistroCategoria.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroCategoria.RowTemplate.Height = 24
        Me.dgvRegistroCategoria.Size = New System.Drawing.Size(523, 209)
        Me.dgvRegistroCategoria.TabIndex = 0
        '
        'PanelRegCategoria
        '
        Me.PanelRegCategoria.BackColor = System.Drawing.Color.Cornsilk
        Me.PanelRegCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegCategoria.Controls.Add(Me.BRegistrarCategoria)
        Me.PanelRegCategoria.Controls.Add(Me.TBNombreCategoria)
        Me.PanelRegCategoria.Controls.Add(Me.LNombreCategoria)
        Me.PanelRegCategoria.Location = New System.Drawing.Point(192, 32)
        Me.PanelRegCategoria.Name = "PanelRegCategoria"
        Me.PanelRegCategoria.Size = New System.Drawing.Size(433, 112)
        Me.PanelRegCategoria.TabIndex = 36
        '
        'BRegistrarCategoria
        '
        Me.BRegistrarCategoria.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BRegistrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.FlatAppearance.BorderSize = 2
        Me.BRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCategoria.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarCategoria.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.Location = New System.Drawing.Point(318, 48)
        Me.BRegistrarCategoria.Name = "BRegistrarCategoria"
        Me.BRegistrarCategoria.Size = New System.Drawing.Size(98, 42)
        Me.BRegistrarCategoria.TabIndex = 13
        Me.BRegistrarCategoria.Text = "Añadir"
        Me.BRegistrarCategoria.UseVisualStyleBackColor = False
        '
        'TBNombreCategoria
        '
        Me.TBNombreCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreCategoria.Location = New System.Drawing.Point(20, 58)
        Me.TBNombreCategoria.Name = "TBNombreCategoria"
        Me.TBNombreCategoria.Size = New System.Drawing.Size(279, 25)
        Me.TBNombreCategoria.TabIndex = 6
        '
        'LNombreCategoria
        '
        Me.LNombreCategoria.AutoSize = True
        Me.LNombreCategoria.BackColor = System.Drawing.Color.Cornsilk
        Me.LNombreCategoria.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreCategoria.ForeColor = System.Drawing.Color.DarkOrange
        Me.LNombreCategoria.Location = New System.Drawing.Point(17, 10)
        Me.LNombreCategoria.Name = "LNombreCategoria"
        Me.LNombreCategoria.Size = New System.Drawing.Size(283, 27)
        Me.LNombreCategoria.TabIndex = 0
        Me.LNombreCategoria.Text = "Nombre de Categoria :"
        '
        'AñadirCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.TabControlRegCategoria)
        Me.Controls.Add(Me.PanelRegCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirCategoria"
        Me.Text = "Form1"
        Me.TabControlRegCategoria.ResumeLayout(False)
        Me.TabPageListaCategoria.ResumeLayout(False)
        CType(Me.dgvRegistroCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegCategoria.ResumeLayout(False)
        Me.PanelRegCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents TabControlRegCategoria As TabControl
    Friend WithEvents TabPageListaCategoria As TabPage
    Friend WithEvents dgvRegistroCategoria As DataGridView
    Friend WithEvents PanelRegCategoria As Panel
    Friend WithEvents BRegistrarCategoria As Button
    Friend WithEvents TBNombreCategoria As TextBox
    Friend WithEvents LNombreCategoria As Label
End Class

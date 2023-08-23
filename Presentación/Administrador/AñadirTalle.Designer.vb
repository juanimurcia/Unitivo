<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirTalle
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
        Me.TabControlRegTalles = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalles = New System.Windows.Forms.TabPage()
        Me.dgvRegistroTalles = New System.Windows.Forms.DataGridView()
        Me.PanelRegTalles = New System.Windows.Forms.Panel()
        Me.BRegistrarTalle = New System.Windows.Forms.Button()
        Me.TBNombreTalle = New System.Windows.Forms.TextBox()
        Me.LNombreTalle = New System.Windows.Forms.Label()
        Me.TabControlRegTalles.SuspendLayout()
        Me.TabPageListaTalles.SuspendLayout()
        CType(Me.dgvRegistroTalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegTalles.SuspendLayout()
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
        Me.BVolver.Location = New System.Drawing.Point(568, 422)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(100, 42)
        Me.BVolver.TabIndex = 41
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TabControlRegTalles
        '
        Me.TabControlRegTalles.Controls.Add(Me.TabPageListaTalles)
        Me.TabControlRegTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegTalles.Location = New System.Drawing.Point(133, 165)
        Me.TabControlRegTalles.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlRegTalles.Name = "TabControlRegTalles"
        Me.TabControlRegTalles.SelectedIndex = 0
        Me.TabControlRegTalles.Size = New System.Drawing.Size(535, 242)
        Me.TabControlRegTalles.TabIndex = 40
        '
        'TabPageListaTalles
        '
        Me.TabPageListaTalles.Controls.Add(Me.dgvRegistroTalles)
        Me.TabPageListaTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalles.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalles.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaTalles.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalles.Name = "TabPageListaTalles"
        Me.TabPageListaTalles.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalles.Size = New System.Drawing.Size(527, 213)
        Me.TabPageListaTalles.TabIndex = 0
        Me.TabPageListaTalles.Text = "Lista de Talles"
        Me.TabPageListaTalles.UseVisualStyleBackColor = True
        '
        'dgvRegistroTalles
        '
        Me.dgvRegistroTalles.AllowUserToAddRows = False
        Me.dgvRegistroTalles.AllowUserToDeleteRows = False
        Me.dgvRegistroTalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroTalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroTalles.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvRegistroTalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistroTalles.ColumnHeadersHeight = 20
        Me.dgvRegistroTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroTalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroTalles.EnableHeadersVisualStyles = False
        Me.dgvRegistroTalles.Location = New System.Drawing.Point(2, 2)
        Me.dgvRegistroTalles.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRegistroTalles.Name = "dgvRegistroTalles"
        Me.dgvRegistroTalles.ReadOnly = True
        Me.dgvRegistroTalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroTalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistroTalles.RowHeadersWidth = 51
        Me.dgvRegistroTalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRegistroTalles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroTalles.RowTemplate.Height = 24
        Me.dgvRegistroTalles.Size = New System.Drawing.Size(523, 209)
        Me.dgvRegistroTalles.TabIndex = 0
        '
        'PanelRegTalles
        '
        Me.PanelRegTalles.BackColor = System.Drawing.Color.Cornsilk
        Me.PanelRegTalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegTalles.Controls.Add(Me.BRegistrarTalle)
        Me.PanelRegTalles.Controls.Add(Me.TBNombreTalle)
        Me.PanelRegTalles.Controls.Add(Me.LNombreTalle)
        Me.PanelRegTalles.Location = New System.Drawing.Point(192, 24)
        Me.PanelRegTalles.Name = "PanelRegTalles"
        Me.PanelRegTalles.Size = New System.Drawing.Size(433, 112)
        Me.PanelRegTalles.TabIndex = 39
        '
        'BRegistrarTalle
        '
        Me.BRegistrarTalle.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BRegistrarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarTalle.FlatAppearance.BorderSize = 2
        Me.BRegistrarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarTalle.ForeColor = System.Drawing.Color.White
        Me.BRegistrarTalle.Location = New System.Drawing.Point(318, 48)
        Me.BRegistrarTalle.Name = "BRegistrarTalle"
        Me.BRegistrarTalle.Size = New System.Drawing.Size(98, 42)
        Me.BRegistrarTalle.TabIndex = 13
        Me.BRegistrarTalle.Text = "Añadir"
        Me.BRegistrarTalle.UseVisualStyleBackColor = False
        '
        'TBNombreTalle
        '
        Me.TBNombreTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreTalle.Location = New System.Drawing.Point(20, 58)
        Me.TBNombreTalle.Name = "TBNombreTalle"
        Me.TBNombreTalle.Size = New System.Drawing.Size(279, 25)
        Me.TBNombreTalle.TabIndex = 6
        '
        'LNombreTalle
        '
        Me.LNombreTalle.AutoSize = True
        Me.LNombreTalle.BackColor = System.Drawing.Color.Cornsilk
        Me.LNombreTalle.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreTalle.ForeColor = System.Drawing.Color.DarkOrange
        Me.LNombreTalle.Location = New System.Drawing.Point(17, 10)
        Me.LNombreTalle.Name = "LNombreTalle"
        Me.LNombreTalle.Size = New System.Drawing.Size(226, 27)
        Me.LNombreTalle.TabIndex = 0
        Me.LNombreTalle.Text = "Nombre de Talle :"
        '
        'AñadirTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.TabControlRegTalles)
        Me.Controls.Add(Me.PanelRegTalles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirTalle"
        Me.Text = "Form1"
        Me.TabControlRegTalles.ResumeLayout(False)
        Me.TabPageListaTalles.ResumeLayout(False)
        CType(Me.dgvRegistroTalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegTalles.ResumeLayout(False)
        Me.PanelRegTalles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents TabControlRegTalles As TabControl
    Friend WithEvents TabPageListaTalles As TabPage
    Friend WithEvents dgvRegistroTalles As DataGridView
    Friend WithEvents PanelRegTalles As Panel
    Friend WithEvents BRegistrarTalle As Button
    Friend WithEvents TBNombreTalle As TextBox
    Friend WithEvents LNombreTalle As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirPerfil
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlRegPerfil = New System.Windows.Forms.TabControl()
        Me.TabPageListaPerfil = New System.Windows.Forms.TabPage()
        Me.dgvRegistroPerfil = New System.Windows.Forms.DataGridView()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.BRegistrarPerfil = New System.Windows.Forms.Button()
        Me.TBNombrePerfil = New System.Windows.Forms.TextBox()
        Me.LNombrePerfil = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TabControlRegPerfil.SuspendLayout()
        Me.TabPageListaPerfil.SuspendLayout()
        CType(Me.dgvRegistroPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlRegPerfil
        '
        Me.TabControlRegPerfil.Controls.Add(Me.TabPageListaPerfil)
        Me.TabControlRegPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegPerfil.Location = New System.Drawing.Point(156, 181)
        Me.TabControlRegPerfil.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlRegPerfil.Name = "TabControlRegPerfil"
        Me.TabControlRegPerfil.SelectedIndex = 0
        Me.TabControlRegPerfil.Size = New System.Drawing.Size(535, 242)
        Me.TabControlRegPerfil.TabIndex = 13
        '
        'TabPageListaPerfil
        '
        Me.TabPageListaPerfil.Controls.Add(Me.dgvRegistroPerfil)
        Me.TabPageListaPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaPerfil.ForeColor = System.Drawing.Color.White
        Me.TabPageListaPerfil.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaPerfil.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaPerfil.Name = "TabPageListaPerfil"
        Me.TabPageListaPerfil.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaPerfil.Size = New System.Drawing.Size(527, 213)
        Me.TabPageListaPerfil.TabIndex = 0
        Me.TabPageListaPerfil.Text = "Lista de Perfil"
        Me.TabPageListaPerfil.UseVisualStyleBackColor = True
        '
        'dgvRegistroPerfil
        '
        Me.dgvRegistroPerfil.AllowUserToAddRows = False
        Me.dgvRegistroPerfil.AllowUserToDeleteRows = False
        Me.dgvRegistroPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroPerfil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroPerfil.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvRegistroPerfil.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroPerfil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvRegistroPerfil.ColumnHeadersHeight = 20
        Me.dgvRegistroPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroPerfil.EnableHeadersVisualStyles = False
        Me.dgvRegistroPerfil.Location = New System.Drawing.Point(2, 2)
        Me.dgvRegistroPerfil.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRegistroPerfil.Name = "dgvRegistroPerfil"
        Me.dgvRegistroPerfil.ReadOnly = True
        Me.dgvRegistroPerfil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroPerfil.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRegistroPerfil.RowHeadersWidth = 51
        Me.dgvRegistroPerfil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRegistroPerfil.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroPerfil.RowTemplate.Height = 24
        Me.dgvRegistroPerfil.Size = New System.Drawing.Size(523, 209)
        Me.dgvRegistroPerfil.TabIndex = 0
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.Cornsilk
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarPerfil)
        Me.PanelRegClientes.Controls.Add(Me.TBNombrePerfil)
        Me.PanelRegClientes.Controls.Add(Me.LNombrePerfil)
        Me.PanelRegClientes.Location = New System.Drawing.Point(215, 49)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(433, 112)
        Me.PanelRegClientes.TabIndex = 12
        '
        'BRegistrarPerfil
        '
        Me.BRegistrarPerfil.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BRegistrarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarPerfil.FlatAppearance.BorderSize = 2
        Me.BRegistrarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarPerfil.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarPerfil.ForeColor = System.Drawing.Color.White
        Me.BRegistrarPerfil.Location = New System.Drawing.Point(318, 48)
        Me.BRegistrarPerfil.Name = "BRegistrarPerfil"
        Me.BRegistrarPerfil.Size = New System.Drawing.Size(98, 42)
        Me.BRegistrarPerfil.TabIndex = 13
        Me.BRegistrarPerfil.Text = "Añadir"
        Me.BRegistrarPerfil.UseVisualStyleBackColor = False
        '
        'TBNombrePerfil
        '
        Me.TBNombrePerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombrePerfil.Location = New System.Drawing.Point(20, 58)
        Me.TBNombrePerfil.Name = "TBNombrePerfil"
        Me.TBNombrePerfil.Size = New System.Drawing.Size(279, 25)
        Me.TBNombrePerfil.TabIndex = 6
        '
        'LNombrePerfil
        '
        Me.LNombrePerfil.AutoSize = True
        Me.LNombrePerfil.BackColor = System.Drawing.Color.Cornsilk
        Me.LNombrePerfil.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombrePerfil.ForeColor = System.Drawing.Color.DarkOrange
        Me.LNombrePerfil.Location = New System.Drawing.Point(20, 8)
        Me.LNombrePerfil.Name = "LNombrePerfil"
        Me.LNombrePerfil.Size = New System.Drawing.Size(280, 34)
        Me.LNombrePerfil.TabIndex = 0
        Me.LNombrePerfil.Text = "Nombre de Perfil :"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.Sienna
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(591, 436)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(100, 42)
        Me.BVolver.TabIndex = 35
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'AñadirPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.TabControlRegPerfil)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirPerfil"
        Me.Text = "Form1"
        Me.TabControlRegPerfil.ResumeLayout(False)
        Me.TabPageListaPerfil.ResumeLayout(False)
        CType(Me.dgvRegistroPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlRegPerfil As TabControl
    Friend WithEvents TabPageListaPerfil As TabPage
    Friend WithEvents dgvRegistroPerfil As DataGridView
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents BRegistrarPerfil As Button
    Friend WithEvents TBNombrePerfil As TextBox
    Friend WithEvents LNombrePerfil As Label
    Friend WithEvents BVolver As Button
End Class

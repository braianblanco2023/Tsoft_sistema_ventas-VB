<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoForm
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
        Me.dataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.buttonAgregar = New System.Windows.Forms.Button()
        Me.buttonModificar = New System.Windows.Forms.Button()
        Me.buttonEliminar = New System.Windows.Forms.Button()
        Me.buttonBuscar = New System.Windows.Forms.Button()
        Me.textBoxBuscar = New System.Windows.Forms.TextBox()
        Me.labelBuscar = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.radioMenorA = New System.Windows.Forms.RadioButton()
        Me.radioMayorA = New System.Windows.Forms.RadioButton()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        CType(Me.dataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridViewProductos
        '
        Me.dataGridViewProductos.AllowUserToAddRows = False
        Me.dataGridViewProductos.AllowUserToDeleteRows = False
        Me.dataGridViewProductos.AllowUserToResizeColumns = False
        Me.dataGridViewProductos.AllowUserToResizeRows = False
        Me.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewProductos.Location = New System.Drawing.Point(24, 98)
        Me.dataGridViewProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.dataGridViewProductos.Name = "dataGridViewProductos"
        Me.dataGridViewProductos.ReadOnly = True
        Me.dataGridViewProductos.RowHeadersVisible = False
        Me.dataGridViewProductos.RowHeadersWidth = 51
        Me.dataGridViewProductos.RowTemplate.Height = 24
        Me.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewProductos.Size = New System.Drawing.Size(331, 244)
        Me.dataGridViewProductos.TabIndex = 0
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Location = New System.Drawing.Point(22, 366)
        Me.buttonAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(75, 24)
        Me.buttonAgregar.TabIndex = 1
        Me.buttonAgregar.Text = "Agregar"
        Me.buttonAgregar.UseVisualStyleBackColor = True
        '
        'buttonModificar
        '
        Me.buttonModificar.Location = New System.Drawing.Point(112, 366)
        Me.buttonModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonModificar.Name = "buttonModificar"
        Me.buttonModificar.Size = New System.Drawing.Size(75, 24)
        Me.buttonModificar.TabIndex = 2
        Me.buttonModificar.Text = "Modificar"
        Me.buttonModificar.UseVisualStyleBackColor = True
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Location = New System.Drawing.Point(202, 366)
        Me.buttonEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(75, 24)
        Me.buttonEliminar.TabIndex = 3
        Me.buttonEliminar.Text = "Eliminar"
        Me.buttonEliminar.UseVisualStyleBackColor = True
        '
        'buttonBuscar
        '
        Me.buttonBuscar.Location = New System.Drawing.Point(278, 21)
        Me.buttonBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonBuscar.Name = "buttonBuscar"
        Me.buttonBuscar.Size = New System.Drawing.Size(75, 24)
        Me.buttonBuscar.TabIndex = 4
        Me.buttonBuscar.Text = "Buscar"
        Me.buttonBuscar.UseVisualStyleBackColor = True
        '
        'textBoxBuscar
        '
        Me.textBoxBuscar.Location = New System.Drawing.Point(75, 24)
        Me.textBoxBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxBuscar.Name = "textBoxBuscar"
        Me.textBoxBuscar.Size = New System.Drawing.Size(183, 20)
        Me.textBoxBuscar.TabIndex = 5
        '
        'labelBuscar
        '
        Me.labelBuscar.AutoSize = True
        Me.labelBuscar.Location = New System.Drawing.Point(20, 24)
        Me.labelBuscar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(43, 13)
        Me.labelBuscar.TabIndex = 6
        Me.labelBuscar.Text = "Buscar:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(24, 61)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Filtrar Precio"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'radioMenorA
        '
        Me.radioMenorA.AutoSize = True
        Me.radioMenorA.Location = New System.Drawing.Point(114, 60)
        Me.radioMenorA.Name = "radioMenorA"
        Me.radioMenorA.Size = New System.Drawing.Size(67, 17)
        Me.radioMenorA.TabIndex = 8
        Me.radioMenorA.TabStop = True
        Me.radioMenorA.Text = "Menor a:"
        Me.radioMenorA.UseVisualStyleBackColor = True
        '
        'radioMayorA
        '
        Me.radioMayorA.AutoSize = True
        Me.radioMayorA.Location = New System.Drawing.Point(114, 76)
        Me.radioMayorA.Name = "radioMayorA"
        Me.radioMayorA.Size = New System.Drawing.Size(66, 17)
        Me.radioMayorA.TabIndex = 9
        Me.radioMayorA.TabStop = True
        Me.radioMayorA.Text = "Mayor a:"
        Me.radioMayorA.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(180, 60)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(76, 20)
        Me.txtMonto.TabIndex = 10
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(278, 60)
        Me.btnFiltrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 21)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'ProductoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 403)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.radioMayorA)
        Me.Controls.Add(Me.radioMenorA)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.labelBuscar)
        Me.Controls.Add(Me.textBoxBuscar)
        Me.Controls.Add(Me.buttonBuscar)
        Me.Controls.Add(Me.buttonEliminar)
        Me.Controls.Add(Me.buttonModificar)
        Me.Controls.Add(Me.buttonAgregar)
        Me.Controls.Add(Me.dataGridViewProductos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductoForm"
        Me.Text = "Gestión de Productos"
        CType(Me.dataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents radioMenorA As RadioButton
    Friend WithEvents radioMayorA As RadioButton
    Friend WithEvents txtMonto As TextBox
    Private WithEvents btnFiltrar As Button
End Class

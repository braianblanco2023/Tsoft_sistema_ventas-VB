<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.buttonAgregar = New System.Windows.Forms.Button()
        Me.buttonModificar = New System.Windows.Forms.Button()
        Me.buttonEliminar = New System.Windows.Forms.Button()
        Me.buttonBuscar = New System.Windows.Forms.Button()
        Me.textBoxBuscar = New System.Windows.Forms.TextBox()
        Me.labelBuscar = New System.Windows.Forms.Label()
        CType(Me.dataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridViewClientes
        '
        Me.dataGridViewClientes.AllowUserToAddRows = False
        Me.dataGridViewClientes.AllowUserToDeleteRows = False
        Me.dataGridViewClientes.AllowUserToResizeColumns = False
        Me.dataGridViewClientes.AllowUserToResizeRows = False
        Me.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewClientes.Location = New System.Drawing.Point(22, 57)
        Me.dataGridViewClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dataGridViewClientes.MultiSelect = False
        Me.dataGridViewClientes.Name = "dataGridViewClientes"
        Me.dataGridViewClientes.ReadOnly = True
        Me.dataGridViewClientes.RowHeadersVisible = False
        Me.dataGridViewClientes.RowHeadersWidth = 51
        Me.dataGridViewClientes.RowTemplate.Height = 24
        Me.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewClientes.Size = New System.Drawing.Size(382, 244)
        Me.dataGridViewClientes.TabIndex = 0
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Location = New System.Drawing.Point(22, 317)
        Me.buttonAgregar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(75, 24)
        Me.buttonAgregar.TabIndex = 1
        Me.buttonAgregar.Text = "Agregar"
        Me.buttonAgregar.UseVisualStyleBackColor = True
        '
        'buttonModificar
        '
        Me.buttonModificar.Location = New System.Drawing.Point(112, 317)
        Me.buttonModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buttonModificar.Name = "buttonModificar"
        Me.buttonModificar.Size = New System.Drawing.Size(75, 24)
        Me.buttonModificar.TabIndex = 2
        Me.buttonModificar.Text = "Modificar"
        Me.buttonModificar.UseVisualStyleBackColor = True
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Location = New System.Drawing.Point(202, 317)
        Me.buttonEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(75, 24)
        Me.buttonEliminar.TabIndex = 3
        Me.buttonEliminar.Text = "Eliminar"
        Me.buttonEliminar.UseVisualStyleBackColor = True
        '
        'buttonBuscar
        '
        Me.buttonBuscar.Location = New System.Drawing.Point(317, 15)
        Me.buttonBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buttonBuscar.Name = "buttonBuscar"
        Me.buttonBuscar.Size = New System.Drawing.Size(88, 24)
        Me.buttonBuscar.TabIndex = 4
        Me.buttonBuscar.Text = "Buscar"
        Me.buttonBuscar.UseVisualStyleBackColor = True
        '
        'textBoxBuscar
        '
        Me.textBoxBuscar.Location = New System.Drawing.Point(112, 18)
        Me.textBoxBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.textBoxBuscar.Name = "textBoxBuscar"
        Me.textBoxBuscar.Size = New System.Drawing.Size(190, 20)
        Me.textBoxBuscar.TabIndex = 5
        '
        'labelBuscar
        '
        Me.labelBuscar.AutoSize = True
        Me.labelBuscar.Location = New System.Drawing.Point(22, 24)
        Me.labelBuscar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(78, 13)
        Me.labelBuscar.TabIndex = 6
        Me.labelBuscar.Text = "Buscar Cliente:"
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 358)
        Me.Controls.Add(Me.labelBuscar)
        Me.Controls.Add(Me.textBoxBuscar)
        Me.Controls.Add(Me.buttonBuscar)
        Me.Controls.Add(Me.buttonEliminar)
        Me.Controls.Add(Me.buttonModificar)
        Me.Controls.Add(Me.buttonAgregar)
        Me.Controls.Add(Me.dataGridViewClientes)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClienteForm"
        Me.Text = "Gestión de Clientes"
        CType(Me.dataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class

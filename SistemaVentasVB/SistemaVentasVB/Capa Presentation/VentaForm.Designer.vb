
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentaForm
    Inherits System.Windows.Forms.Form

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    Public Sub New()
        InitializeComponent()
    End Sub
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.buttonAgregar = New System.Windows.Forms.Button()
        Me.buttonModificar = New System.Windows.Forms.Button()
        Me.buttonEliminar = New System.Windows.Forms.Button()
        Me.buttonBuscar = New System.Windows.Forms.Button()
        Me.labelBuscar = New System.Windows.Forms.Label()
        Me.dateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.dataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridViewVentas
        '
        Me.dataGridViewVentas.AllowUserToAddRows = False
        Me.dataGridViewVentas.AllowUserToDeleteRows = False
        Me.dataGridViewVentas.AllowUserToResizeColumns = False
        Me.dataGridViewVentas.AllowUserToResizeRows = False
        Me.dataGridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewVentas.Location = New System.Drawing.Point(22, 57)
        Me.dataGridViewVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.dataGridViewVentas.Name = "dataGridViewVentas"
        Me.dataGridViewVentas.ReadOnly = True
        Me.dataGridViewVentas.RowHeadersVisible = False
        Me.dataGridViewVentas.RowHeadersWidth = 51
        Me.dataGridViewVentas.RowTemplate.Height = 24
        Me.dataGridViewVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewVentas.Size = New System.Drawing.Size(306, 244)
        Me.dataGridViewVentas.TabIndex = 0
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Location = New System.Drawing.Point(22, 317)
        Me.buttonAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(93, 24)
        Me.buttonAgregar.TabIndex = 1
        Me.buttonAgregar.Text = "Nueva Venta"
        Me.buttonAgregar.UseVisualStyleBackColor = True
        '
        'buttonModificar
        '
        Me.buttonModificar.Location = New System.Drawing.Point(119, 317)
        Me.buttonModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonModificar.Name = "buttonModificar"
        Me.buttonModificar.Size = New System.Drawing.Size(95, 24)
        Me.buttonModificar.TabIndex = 2
        Me.buttonModificar.Text = "Detalle Venta"
        Me.buttonModificar.UseVisualStyleBackColor = True
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Location = New System.Drawing.Point(240, 317)
        Me.buttonEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(88, 24)
        Me.buttonEliminar.TabIndex = 3
        Me.buttonEliminar.Text = "Eliminar"
        Me.buttonEliminar.UseVisualStyleBackColor = True
        '
        'buttonBuscar
        '
        Me.buttonBuscar.Location = New System.Drawing.Point(255, 19)
        Me.buttonBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonBuscar.Name = "buttonBuscar"
        Me.buttonBuscar.Size = New System.Drawing.Size(73, 24)
        Me.buttonBuscar.TabIndex = 4
        Me.buttonBuscar.Text = "Buscar"
        Me.buttonBuscar.UseVisualStyleBackColor = True
        '
        'labelBuscar
        '
        Me.labelBuscar.AutoSize = True
        Me.labelBuscar.Location = New System.Drawing.Point(21, 24)
        Me.labelBuscar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(40, 13)
        Me.labelBuscar.TabIndex = 5
        Me.labelBuscar.Text = "Fecha:"
        '
        'dateTimePickerFecha
        '
        Me.dateTimePickerFecha.Location = New System.Drawing.Point(62, 21)
        Me.dateTimePickerFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dateTimePickerFecha.Name = "dateTimePickerFecha"
        Me.dateTimePickerFecha.Size = New System.Drawing.Size(188, 20)
        Me.dateTimePickerFecha.TabIndex = 6
        '
        'VentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 358)
        Me.Controls.Add(Me.dateTimePickerFecha)
        Me.Controls.Add(Me.labelBuscar)
        Me.Controls.Add(Me.buttonBuscar)
        Me.Controls.Add(Me.buttonEliminar)
        Me.Controls.Add(Me.buttonModificar)
        Me.Controls.Add(Me.buttonAgregar)
        Me.Controls.Add(Me.dataGridViewVentas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentaForm"
        Me.Text = "Gestión de Ventas"
        CType(Me.dataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class

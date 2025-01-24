<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaAddForm
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.comboBoxProducto = New System.Windows.Forms.ComboBox()
        Me.labelCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCantidad_dw = New System.Windows.Forms.Button()
        Me.btnCantidad_up = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dataGridViewDetails = New System.Windows.Forms.DataGridView()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.comboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.btnNewCliente = New System.Windows.Forms.Button()
        CType(Me.dataGridViewDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(440, 343)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(359, 343)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        '
        'labelProducto
        '
        Me.labelProducto.Location = New System.Drawing.Point(18, 51)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(60, 17)
        Me.labelProducto.TabIndex = 4
        Me.labelProducto.Text = "Producto:"
        '
        'comboBoxProducto
        '
        Me.comboBoxProducto.Location = New System.Drawing.Point(79, 47)
        Me.comboBoxProducto.Name = "comboBoxProducto"
        Me.comboBoxProducto.Size = New System.Drawing.Size(195, 21)
        Me.comboBoxProducto.TabIndex = 5
        '
        'labelCantidad
        '
        Me.labelCantidad.Location = New System.Drawing.Point(280, 50)
        Me.labelCantidad.Name = "labelCantidad"
        Me.labelCantidad.Size = New System.Drawing.Size(61, 17)
        Me.labelCantidad.TabIndex = 6
        Me.labelCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(364, 47)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(43, 20)
        Me.txtCantidad.TabIndex = 7
        Me.txtCantidad.Text = " 1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Factura Cliente:"
        '
        'btnCantidad_dw
        '
        Me.btnCantidad_dw.Location = New System.Drawing.Point(413, 47)
        Me.btnCantidad_dw.Name = "btnCantidad_dw"
        Me.btnCantidad_dw.Size = New System.Drawing.Size(21, 20)
        Me.btnCantidad_dw.TabIndex = 15
        Me.btnCantidad_dw.Text = "-"
        '
        'btnCantidad_up
        '
        Me.btnCantidad_up.Location = New System.Drawing.Point(337, 46)
        Me.btnCantidad_up.Name = "btnCantidad_up"
        Me.btnCantidad_up.Size = New System.Drawing.Size(21, 21)
        Me.btnCantidad_up.TabIndex = 16
        Me.btnCantidad_up.Text = "+"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(441, 45)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        '
        'dataGridViewDetails
        '
        Me.dataGridViewDetails.AllowUserToAddRows = False
        Me.dataGridViewDetails.AllowUserToDeleteRows = False
        Me.dataGridViewDetails.AllowUserToResizeColumns = False
        Me.dataGridViewDetails.AllowUserToResizeRows = False
        Me.dataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewDetails.Location = New System.Drawing.Point(21, 77)
        Me.dataGridViewDetails.Name = "dataGridViewDetails"
        Me.dataGridViewDetails.ReadOnly = True
        Me.dataGridViewDetails.RowHeadersVisible = False
        Me.dataGridViewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewDetails.Size = New System.Drawing.Size(494, 216)
        Me.dataGridViewDetails.TabIndex = 18
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(415, 301)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 20
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total $:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(21, 343)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 23)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar Item(s)"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'comboBoxCliente
        '
        Me.comboBoxCliente.Location = New System.Drawing.Point(105, 12)
        Me.comboBoxCliente.Name = "comboBoxCliente"
        Me.comboBoxCliente.Size = New System.Drawing.Size(169, 21)
        Me.comboBoxCliente.TabIndex = 23
        '
        'btnNewCliente
        '
        Me.btnNewCliente.Location = New System.Drawing.Point(283, 10)
        Me.btnNewCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewCliente.Name = "btnNewCliente"
        Me.btnNewCliente.Size = New System.Drawing.Size(99, 24)
        Me.btnNewCliente.TabIndex = 24
        Me.btnNewCliente.Text = "Nuevo Cliente"
        Me.btnNewCliente.UseVisualStyleBackColor = True
        '
        'VentaAddForm
        '
        Me.ClientSize = New System.Drawing.Size(538, 378)
        Me.Controls.Add(Me.btnNewCliente)
        Me.Controls.Add(Me.comboBoxCliente)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dataGridViewDetails)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCantidad_up)
        Me.Controls.Add(Me.btnCantidad_dw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.labelProducto)
        Me.Controls.Add(Me.comboBoxProducto)
        Me.Controls.Add(Me.labelCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentaAddForm"
        Me.Text = "Agregar Venta"
        CType(Me.dataGridViewDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Private WithEvents btnCantidad_dw As Button
    Private WithEvents btnCantidad_up As Button
    Private WithEvents btnAgregar As Button
    Friend WithEvents dataGridViewDetails As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEliminar As Button
    Private WithEvents comboBoxCliente As ComboBox
    Private WithEvents btnNewCliente As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentaDetailForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataGridViewDetails = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCantidad_up = New System.Windows.Forms.Button()
        Me.btnCantidad_dw = New System.Windows.Forms.Button()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.comboBoxProducto = New System.Windows.Forms.ComboBox()
        Me.labelCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dataGridViewDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de Venta:"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(415, 13)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Factura Cliente:"
        '
        'dataGridViewDetails
        '
        Me.dataGridViewDetails.AllowUserToAddRows = False
        Me.dataGridViewDetails.AllowUserToDeleteRows = False
        Me.dataGridViewDetails.AllowUserToResizeColumns = False
        Me.dataGridViewDetails.AllowUserToResizeRows = False
        Me.dataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewDetails.Location = New System.Drawing.Point(21, 119)
        Me.dataGridViewDetails.Name = "dataGridViewDetails"
        Me.dataGridViewDetails.ReadOnly = True
        Me.dataGridViewDetails.RowHeadersVisible = False
        Me.dataGridViewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewDetails.Size = New System.Drawing.Size(494, 223)
        Me.dataGridViewDetails.TabIndex = 4
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(21, 353)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar Item(s)"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nro de Venta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total $:"
        '
        'txtVenta
        '
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(415, 38)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.ReadOnly = True
        Me.txtVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtVenta.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(415, 351)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(425, 393)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 23)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(105, 15)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(169, 20)
        Me.txtCliente.TabIndex = 12
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(441, 86)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 24
        Me.btnAgregar.Text = "Agregar"
        '
        'btnCantidad_up
        '
        Me.btnCantidad_up.Location = New System.Drawing.Point(337, 87)
        Me.btnCantidad_up.Name = "btnCantidad_up"
        Me.btnCantidad_up.Size = New System.Drawing.Size(21, 21)
        Me.btnCantidad_up.TabIndex = 23
        Me.btnCantidad_up.Text = "+"
        '
        'btnCantidad_dw
        '
        Me.btnCantidad_dw.Location = New System.Drawing.Point(413, 88)
        Me.btnCantidad_dw.Name = "btnCantidad_dw"
        Me.btnCantidad_dw.Size = New System.Drawing.Size(21, 20)
        Me.btnCantidad_dw.TabIndex = 22
        Me.btnCantidad_dw.Text = "-"
        '
        'labelProducto
        '
        Me.labelProducto.Location = New System.Drawing.Point(18, 92)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(60, 17)
        Me.labelProducto.TabIndex = 18
        Me.labelProducto.Text = "Producto:"
        '
        'comboBoxProducto
        '
        Me.comboBoxProducto.Location = New System.Drawing.Point(79, 88)
        Me.comboBoxProducto.Name = "comboBoxProducto"
        Me.comboBoxProducto.Size = New System.Drawing.Size(195, 21)
        Me.comboBoxProducto.TabIndex = 19
        '
        'labelCantidad
        '
        Me.labelCantidad.Location = New System.Drawing.Point(280, 91)
        Me.labelCantidad.Name = "labelCantidad"
        Me.labelCantidad.Size = New System.Drawing.Size(61, 17)
        Me.labelCantidad.TabIndex = 20
        Me.labelCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(364, 88)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(43, 20)
        Me.txtCantidad.TabIndex = 21
        Me.txtCantidad.Text = " 1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(344, 393)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        '
        'VentaDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 426)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCantidad_up)
        Me.Controls.Add(Me.btnCantidad_dw)
        Me.Controls.Add(Me.labelProducto)
        Me.Controls.Add(Me.comboBoxProducto)
        Me.Controls.Add(Me.labelCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dataGridViewDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentaDetailForm"
        Me.Text = "Detalle de Venta"
        CType(Me.dataGridViewDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dataGridViewDetails As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtCliente As TextBox
    Private WithEvents btnAgregar As Button
    Private WithEvents btnCantidad_up As Button
    Private WithEvents btnCantidad_dw As Button
    Private WithEvents labelProducto As Label
    Private WithEvents comboBoxProducto As ComboBox
    Private WithEvents labelCantidad As Label
    Private WithEvents txtCantidad As TextBox
    Private WithEvents btnCancelar As Button
End Class

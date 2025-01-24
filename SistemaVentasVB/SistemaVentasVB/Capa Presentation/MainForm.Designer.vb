<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(40, 50)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(150, 40)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Gestionar Clientes"
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(40, 100)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(150, 40)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Gestionar Productos"
        '
        'btnReportes
        '
        Me.btnReportes.Location = New System.Drawing.Point(40, 200)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(150, 40)
        Me.btnReportes.TabIndex = 3
        Me.btnReportes.Text = "Generar Reportes"
        '
        'btnVentas
        '
        Me.btnVentas.Location = New System.Drawing.Point(40, 150)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(150, 40)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Gestionar Ventas"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 261)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnReportes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Sistema de Gestión de Ventas"
        Me.ResumeLayout(False)

    End Sub
End Class

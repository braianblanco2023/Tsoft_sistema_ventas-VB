<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoAddForm
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
        Me.buttonGuardar = New System.Windows.Forms.Button()
        Me.buttonCancelar = New System.Windows.Forms.Button()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.textBoxNombre = New System.Windows.Forms.TextBox()
        Me.labelPrecio = New System.Windows.Forms.Label()
        Me.textBoxPrecio = New System.Windows.Forms.TextBox()
        Me.labelCategoria = New System.Windows.Forms.Label()
        Me.textBoxCategoria = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Location = New System.Drawing.Point(100, 159)
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.buttonGuardar.TabIndex = 0
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(200, 159)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 1
        Me.buttonCancelar.Text = "Cancelar"
        '
        'labelNombre
        '
        Me.labelNombre.Location = New System.Drawing.Point(50, 30)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(100, 20)
        Me.labelNombre.TabIndex = 2
        Me.labelNombre.Text = "Nombre:"
        '
        'textBoxNombre
        '
        Me.textBoxNombre.Location = New System.Drawing.Point(150, 30)
        Me.textBoxNombre.Name = "textBoxNombre"
        Me.textBoxNombre.Size = New System.Drawing.Size(200, 20)
        Me.textBoxNombre.TabIndex = 3
        '
        'labelPrecio
        '
        Me.labelPrecio.Location = New System.Drawing.Point(50, 70)
        Me.labelPrecio.Name = "labelPrecio"
        Me.labelPrecio.Size = New System.Drawing.Size(100, 20)
        Me.labelPrecio.TabIndex = 4
        Me.labelPrecio.Text = "Precio:"
        '
        'textBoxPrecio
        '
        Me.textBoxPrecio.Location = New System.Drawing.Point(150, 70)
        Me.textBoxPrecio.Name = "textBoxPrecio"
        Me.textBoxPrecio.Size = New System.Drawing.Size(200, 20)
        Me.textBoxPrecio.TabIndex = 5
        '
        'labelCategoria
        '
        Me.labelCategoria.Location = New System.Drawing.Point(50, 110)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(100, 20)
        Me.labelCategoria.TabIndex = 6
        Me.labelCategoria.Text = "Categoría:"
        '
        'textBoxCategoria
        '
        Me.textBoxCategoria.Location = New System.Drawing.Point(150, 110)
        Me.textBoxCategoria.Name = "textBoxCategoria"
        Me.textBoxCategoria.Size = New System.Drawing.Size(200, 20)
        Me.textBoxCategoria.TabIndex = 7
        '
        'ProductoAddForm
        '
        Me.ClientSize = New System.Drawing.Size(400, 201)
        Me.Controls.Add(Me.buttonGuardar)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.labelPrecio)
        Me.Controls.Add(Me.textBoxPrecio)
        Me.Controls.Add(Me.labelCategoria)
        Me.Controls.Add(Me.textBoxCategoria)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductoAddForm"
        Me.Text = "Agregar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class

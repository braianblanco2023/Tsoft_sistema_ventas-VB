<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteAddForm
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
        Me.labelTelefono = New System.Windows.Forms.Label()
        Me.textBoxTelefono = New System.Windows.Forms.TextBox()
        Me.labelCorreo = New System.Windows.Forms.Label()
        Me.textBoxCorreo = New System.Windows.Forms.TextBox()
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
        'labelTelefono
        '
        Me.labelTelefono.Location = New System.Drawing.Point(50, 70)
        Me.labelTelefono.Name = "labelTelefono"
        Me.labelTelefono.Size = New System.Drawing.Size(100, 20)
        Me.labelTelefono.TabIndex = 4
        Me.labelTelefono.Text = "Teléfono:"
        '
        'textBoxTelefono
        '
        Me.textBoxTelefono.Location = New System.Drawing.Point(150, 70)
        Me.textBoxTelefono.Name = "textBoxTelefono"
        Me.textBoxTelefono.Size = New System.Drawing.Size(200, 20)
        Me.textBoxTelefono.TabIndex = 5
        '
        'labelCorreo
        '
        Me.labelCorreo.Location = New System.Drawing.Point(50, 110)
        Me.labelCorreo.Name = "labelCorreo"
        Me.labelCorreo.Size = New System.Drawing.Size(100, 20)
        Me.labelCorreo.TabIndex = 6
        Me.labelCorreo.Text = "Correo:"
        '
        'textBoxCorreo
        '
        Me.textBoxCorreo.Location = New System.Drawing.Point(150, 110)
        Me.textBoxCorreo.Name = "textBoxCorreo"
        Me.textBoxCorreo.Size = New System.Drawing.Size(200, 20)
        Me.textBoxCorreo.TabIndex = 7
        '
        'ClienteAddForm
        '
        Me.ClientSize = New System.Drawing.Size(400, 201)
        Me.Controls.Add(Me.buttonGuardar)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.labelTelefono)
        Me.Controls.Add(Me.textBoxTelefono)
        Me.Controls.Add(Me.labelCorreo)
        Me.Controls.Add(Me.textBoxCorreo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClienteAddForm"
        Me.Text = "Agregar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class

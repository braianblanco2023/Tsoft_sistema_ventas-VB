Imports System.Configuration
Imports System.Data.SqlClient

Public Class ProductoAddForm
    Inherits System.Windows.Forms.Form

    ' Controles del formulario
    Private WithEvents buttonGuardar As Button
    Private WithEvents buttonCancelar As Button
    Private labelNombre As Label
    Private textBoxNombre As TextBox
    Private labelPrecio As Label
    Private textBoxPrecio As TextBox
    Private labelCategoria As Label
    Private textBoxCategoria As TextBox

    Private almacen As New BusinessLogic
    Dim producto As New Producto

    ' Constructor del formulario
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Evento para el botón Guardar
    Private Sub buttonGuardar_Click(sender As Object, e As EventArgs) Handles buttonGuardar.Click
        producto.Nombre = textBoxNombre.Text
        producto.Precio = textBoxPrecio.Text
        producto.Categoria = textBoxCategoria.Text

        Dim mensajeError As String = almacen.ValidarProducto(producto)
        If Not String.IsNullOrEmpty(mensajeError) Then
            MessageBox.Show(mensajeError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        almacen.GuardarProductoNew(producto)

        MessageBox.Show("Producto agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Evento para el botón Cancelar
    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

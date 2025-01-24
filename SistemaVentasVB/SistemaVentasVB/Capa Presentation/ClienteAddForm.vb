Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClienteAddForm
    Inherits System.Windows.Forms.Form

    ' Controles del formulario
    Private WithEvents buttonGuardar As Button
    Private WithEvents buttonCancelar As Button
    Private labelNombre As Label
    Private textBoxNombre As TextBox
    Private labelTelefono As Label
    Private textBoxTelefono As TextBox
    Private labelCorreo As Label
    Private textBoxCorreo As TextBox

    Private almacen As New BusinessLogic
    Dim cliente As New Cliente

    ' Constructor del formulario
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Evento para el botón Guardar
    Private Sub buttonGuardar_Click(sender As Object, e As EventArgs) Handles buttonGuardar.Click
        cliente.Nombre = textBoxNombre.Text
        cliente.Telefono = textBoxTelefono.Text
        cliente.Correo = textBoxCorreo.Text

        Dim mensajeError As String = almacen.ValidarCliente(cliente)
        If Not String.IsNullOrEmpty(mensajeError) Then
            MessageBox.Show(mensajeError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        almacen.GuardarClienteNew(cliente)

        MessageBox.Show("Cliente agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Evento para el botón Cancelar
    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

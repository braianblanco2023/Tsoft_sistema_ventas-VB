Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClienteModifyForm
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

    Private clienteID As Integer
    Private almacen As New BusinessLogic
    Dim cliente As New Cliente

    ' Constructor del formulario
    Public Sub New(cID As Integer)
        Me.clienteID = cID
        InitializeComponent()
        ClienteSelect(clienteID)
    End Sub
    Private Sub ClienteSelect(clienteID As Integer)
        cliente = almacen.ObtenerCliente(clienteID)
        textBoxNombre.Text = cliente.Nombre
        textBoxTelefono.Text = cliente.Telefono
        textBoxCorreo.Text = cliente.Correo
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
        almacen.GuardarClienteModif(cliente)

        MessageBox.Show("Cliente modificado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Evento para el botón Cancelar
    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

Imports System.Configuration
Imports System.Data.SqlClient

Partial Public Class VentaAddForm
    Inherits System.Windows.Forms.Form

    ' Controles del formulario
    Private WithEvents btnGuardar As Button
    Private WithEvents btnCancelar As Button
    Private labelProducto As Label
    Private comboBoxProducto As ComboBox
    Private labelCantidad As Label
    Private txtCantidad As TextBox

    Private almacen As New BusinessLogic
    Dim venta As New Venta
    Dim articulosGrilla As New List(Of VentaItem)

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub VentaAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxProducto.DataSource = almacen.ListarProductos()
        comboBoxCliente.DataSource = almacen.ListarClientes()
    End Sub
    ' Evento para el botón Guardar
    Private Sub buttonGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim clienteSeleccion As String = comboBoxCliente.SelectedItem.ToString
        Dim cliente As Integer = almacen.BuscarIdCliente(clienteSeleccion)
        Dim totalVenta As Decimal = Decimal.Parse(txtTotal.Text)
        almacen.GuardarNuevaVenta(cliente, totalVenta, articulosGrilla)

        MessageBox.Show("Venta agregada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Evento para el botón Cancelar
    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim producto As String = comboBoxProducto.SelectedItem.ToString
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)

        dataGridViewDetails.DataSource = Nothing
        articulosGrilla = almacen.itemRepetido(producto, cantidad, articulosGrilla)
        dataGridViewDetails.DataSource = articulosGrilla
        txtTotal.Text = almacen.totalSum("Subtotal", dataGridViewDetails)
    End Sub


    Private Sub btnCantidad_up_Click(sender As Object, e As EventArgs) Handles btnCantidad_up.Click
        txtCantidad.Text = (Convert.ToInt32(txtCantidad.Text)) + 1
    End Sub

    Private Sub btnCantidad_dw_Click(sender As Object, e As EventArgs) Handles btnCantidad_dw.Click
        If Convert.ToInt32(txtCantidad.Text) > 1 Then
            txtCantidad.Text = (Convert.ToInt32(txtCantidad.Text)) - 1
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim filasSeleccionadas = dataGridViewDetails.SelectedRows
        Dim productosAEliminar As New List(Of String)()

        For Each fila As DataGridViewRow In filasSeleccionadas
            productosAEliminar.Add(fila.Cells("Producto").Value.ToString())
        Next

        For Each producto In productosAEliminar
            Dim articuloAEliminar = articulosGrilla.FirstOrDefault(Function(a) a.Producto = producto)
            If articuloAEliminar IsNot Nothing Then
                articulosGrilla.Remove(articuloAEliminar)
            End If
        Next

        dataGridViewDetails.DataSource = Nothing
        dataGridViewDetails.DataSource = articulosGrilla
    End Sub

    Private Sub btnNewCliente_Click(sender As Object, e As EventArgs) Handles btnNewCliente.Click
        Dim addForm As New ClienteAddForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            comboBoxProducto.DataSource = almacen.ListarProductos()
            comboBoxCliente.DataSource = almacen.ListarClientes()
        End If
    End Sub
End Class

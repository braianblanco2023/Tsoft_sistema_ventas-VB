Imports System.Configuration
Imports System.Data.SqlClient

Partial Public Class VentaDetailForm
    Inherits System.Windows.Forms.Form

    Private ventaID As Integer
    Private cliente As String
    Private fecha As Date

    Private almacen As New BusinessLogic
    Dim ventaItems As New List(Of VentaItem)
    Dim articulosGrilla As New List(Of VentaItem)

    Public Sub New(venta As Integer, cliente As String, fecha As Date)
        Me.ventaID = venta
        Me.cliente = cliente
        Me.fecha = fecha

        InitializeComponent()
        CargaVentaDetail()
    End Sub

    Private Sub CargaVentaDetail()
        'llenar textbox
        txtCliente.Text = cliente
        txtFecha.Text = fecha
        txtVenta.Text = ventaID
        comboBoxProducto.DataSource = almacen.ListarProductos()
        'llenar dataGrid
        ventaItems = almacen.ObtenerVentaItems(ventaID)
        dataGridViewDetails.DataSource = ventaItems
        'llenar campo Total
        Dim total As Decimal = subtotalSum("Subtotal")
        txtTotal.Text = total.ToString()
    End Sub

    Private Function subtotalSum(columna As String) As Decimal
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dataGridViewDetails.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(columna).Value)
            End If
        Next
        Return total
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim filasSeleccionadas = dataGridViewDetails.SelectedRows
        Dim productosAEliminar As New List(Of String)()

        For Each fila As DataGridViewRow In filasSeleccionadas
            productosAEliminar.Add(fila.Cells("Producto").Value.ToString())
        Next

        For Each producto In productosAEliminar
            Dim articuloAEliminar = ventaItems.FirstOrDefault(Function(a) a.Producto = producto)
            If articuloAEliminar IsNot Nothing Then
                ventaItems.Remove(articuloAEliminar)
            End If
        Next

        dataGridViewDetails.DataSource = Nothing
        dataGridViewDetails.DataSource = ventaItems
    End Sub

    Private Sub btnCantidad_up_Click(sender As Object, e As EventArgs) Handles btnCantidad_up.Click
        txtCantidad.Text = (Convert.ToInt32(txtCantidad.Text)) + 1
    End Sub

    Private Sub btnCantidad_dw_Click(sender As Object, e As EventArgs) Handles btnCantidad_dw.Click
        If Convert.ToInt32(txtCantidad.Text) > 1 Then
            txtCantidad.Text = (Convert.ToInt32(txtCantidad.Text)) - 1
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim producto As String = comboBoxProducto.SelectedItem.ToString
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)
        ventaItems = almacen.itemRepetido(producto, cantidad, ventaItems)
        dataGridViewDetails.DataSource = Nothing
        dataGridViewDetails.DataSource = ventaItems
        txtTotal.Text = almacen.totalSum("Subtotal", dataGridViewDetails)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nroVenta As Integer = Integer.Parse(txtVenta.Text)
        Dim totalVenta As Decimal = Decimal.Parse(txtTotal.Text)
        almacen.GuardaCambiosVenta(nroVenta, totalVenta, ventaItems)

        MessageBox.Show("Venta actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class

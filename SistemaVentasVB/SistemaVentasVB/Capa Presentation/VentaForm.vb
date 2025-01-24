Imports System.Configuration
Imports System.Data.SqlClient

Partial Public Class VentaForm
    Inherits System.Windows.Forms.Form

    ' Controles del formulario
    Private WithEvents dataGridViewVentas As DataGridView
    Private WithEvents buttonAgregar As Button
    Private WithEvents buttonModificar As Button
    Private WithEvents buttonEliminar As Button
    Private WithEvents buttonBuscar As Button
    Private WithEvents labelBuscar As Label
    Private WithEvents dateTimePickerFecha As DateTimePicker

    Private almacen As New BusinessLogic

    Private Sub VentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVentas(dataGridViewVentas)
    End Sub

    Private Sub CargarVentas(grilla As DataGridView)
        Dim ventasResume As List(Of Venta) = almacen.ObtenerVentas()
        grilla.DataSource = ventasResume
    End Sub

    Private Sub buttonAgregar_Click(sender As Object, e As EventArgs) Handles buttonAgregar.Click
        Dim addForm As New VentaAddForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            CargarVentas(dataGridViewVentas)
        End If
    End Sub

    Private Sub buttonModificar_Click(sender As Object, e As EventArgs) Handles buttonModificar.Click
        If dataGridViewVentas.SelectedRows.Count > 0 Then
            Dim venta As Integer = Convert.ToInt32(dataGridViewVentas.SelectedRows(0).Cells("Nro").Value)
            Dim cliente As String = Convert.ToString(dataGridViewVentas.SelectedRows(0).Cells("Cliente").Value)
            Dim fecha As Date = Convert.ToDateTime(dataGridViewVentas.SelectedRows(0).Cells("Fecha").Value)
            Dim detailForm As New VentaDetailForm(venta, cliente, fecha)
            If detailForm.ShowDialog() = DialogResult.OK Then
                CargarVentas(dataGridViewVentas)
            End If
        Else
            MessageBox.Show("Seleccione una venta para detallar.")
        End If
    End Sub

    Private Sub buttonEliminar_Click(sender As Object, e As EventArgs) Handles buttonEliminar.Click
        If dataGridViewVentas.SelectedRows.Count > 0 Then
            Dim idVenta As Integer = Convert.ToInt32(dataGridViewVentas.SelectedRows(0).Cells("Nro").Value)
            almacen.EliminarVenta(idVenta)
            CargarVentas(dataGridViewVentas)
        Else
            MessageBox.Show("Seleccione una venta para eliminar.")
        End If
    End Sub

    Private Sub buttonBuscar_Click(sender As Object, e As EventArgs) Handles buttonBuscar.Click
        Dim fecha As Date = dateTimePickerFecha.Value.Date
        dataGridViewVentas.DataSource = almacen.BuscarVentaFecha(fecha)
    End Sub

    Private Sub labelBuscar_Click(sender As Object, e As EventArgs) Handles labelBuscar.Click

    End Sub
End Class

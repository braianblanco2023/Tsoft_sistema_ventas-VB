Imports System.Configuration
Imports System.Data.SqlClient

Partial Public Class ClienteForm
    Inherits System.Windows.Forms.Form

    ' Controles del formulario
    Private WithEvents dataGridViewClientes As DataGridView
    Private WithEvents buttonAgregar As Button
    Private WithEvents buttonModificar As Button
    Private WithEvents buttonEliminar As Button
    Private WithEvents buttonBuscar As Button
    Private WithEvents textBoxBuscar As TextBox
    Private WithEvents labelBuscar As Label

    Private almacen As New BusinessLogic

    Private Sub ClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes(dataGridViewClientes)
    End Sub

    Private Sub CargarClientes(grilla As DataGridView)
        Dim clientes As List(Of Cliente) = almacen.ObtenerClientes()
        grilla.DataSource = clientes
    End Sub

    Private Sub buttonAgregar_Click(sender As Object, e As EventArgs) Handles buttonAgregar.Click
        Dim addForm As New ClienteAddForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            CargarClientes(dataGridViewClientes)
        End If
    End Sub

    Private Sub buttonModificar_Click(sender As Object, e As EventArgs) Handles buttonModificar.Click
        If dataGridViewClientes.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dataGridViewClientes.SelectedRows(0).Cells("ID").Value)
            Dim modifyForm As New ClienteModifyForm(id)
            If modifyForm.ShowDialog() = DialogResult.OK Then
                CargarClientes(dataGridViewClientes)
            End If
        Else
            MessageBox.Show("Seleccione un cliente para modificar.")
        End If
    End Sub

    Private Sub buttonEliminar_Click(sender As Object, e As EventArgs) Handles buttonEliminar.Click
        If dataGridViewClientes.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dataGridViewClientes.SelectedRows(0).Cells("ID").Value)
            almacen.EliminarCliente(id)
            CargarClientes(dataGridViewClientes)
        Else
            MessageBox.Show("Seleccione un cliente para eliminar.")
        End If
    End Sub

    Private Sub buttonBuscar_Click(sender As Object, e As EventArgs) Handles buttonBuscar.Click
        Dim cliBuscado As New List(Of Cliente)
        cliBuscado = almacen.BuscarDatosCliente(textBoxBuscar.Text)
        dataGridViewClientes.DataSource = cliBuscado
    End Sub
End Class

Imports System.Configuration
Imports System.Data.SqlClient

Partial Public Class ProductoForm
    Inherits System.Windows.Forms.Form

    ' Controles del formulario
    Private WithEvents dataGridViewProductos As DataGridView
    Private WithEvents buttonAgregar As Button
    Private WithEvents buttonModificar As Button
    Private WithEvents buttonEliminar As Button
    Private WithEvents buttonBuscar As Button
    Private WithEvents textBoxBuscar As TextBox
    Private WithEvents labelBuscar As Label

    Private almacen As New BusinessLogic
    Private productosAfiltrar As List(Of Producto)

    Private Sub ProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioMenorA.Visible = False
        radioMayorA.Visible = False
        txtMonto.Visible = False
        btnFiltrar.Visible = False
        CargarProductos(dataGridViewProductos)
    End Sub

    Private Sub CargarProductos(grilla As DataGridView)
        Dim productos As List(Of Producto) = almacen.ObtenerProductos()
        grilla.DataSource = productos
        productosAfiltrar = productos.ToList()
    End Sub

    Private Sub buttonAgregar_Click(sender As Object, e As EventArgs) Handles buttonAgregar.Click
        Dim addForm As New ProductoAddForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            CargarProductos(dataGridViewProductos)
        End If
    End Sub

    Private Sub buttonModificar_Click(sender As Object, e As EventArgs) Handles buttonModificar.Click
        If dataGridViewProductos.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dataGridViewProductos.SelectedRows(0).Cells("ID").Value)
            Dim modifyForm As New ProductoModifyForm(id)
            If modifyForm.ShowDialog() = DialogResult.OK Then
                CargarProductos(dataGridViewProductos)
            End If
        Else
            MessageBox.Show("Seleccione un producto para modificar.")
        End If
    End Sub

    Private Sub buttonEliminar_Click(sender As Object, e As EventArgs) Handles buttonEliminar.Click
        If dataGridViewProductos.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dataGridViewProductos.SelectedRows(0).Cells("ID").Value)
            almacen.EliminarProducto(id)
            CargarProductos(dataGridViewProductos)
        Else
            MessageBox.Show("Seleccione un producto para eliminar.")
        End If
    End Sub

    Private Sub buttonBuscar_Click(sender As Object, e As EventArgs) Handles buttonBuscar.Click
        Dim prodBuscado As New List(Of Producto)
        prodBuscado = almacen.BuscarDatosProducto(textBoxBuscar.Text)
        dataGridViewProductos.DataSource = prodBuscado
        productosAfiltrar = prodBuscado.ToList()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ActualizaElementosForm()
    End Sub

    Private Sub ActualizaElementosForm()
        If CheckBox1.Checked Then
            ' Mostrar los elementos si el CheckBox está seleccionado
            radioMenorA.Visible = True
            radioMayorA.Visible = True
            txtMonto.Visible = True
            btnFiltrar.Visible = True
            buttonBuscar.Enabled = False
            textBoxBuscar.Enabled = False
        Else
            ' Ocultar los elementos si el CheckBox no está seleccionado
            radioMenorA.Visible = False
            radioMayorA.Visible = False
            txtMonto.Visible = False
            btnFiltrar.Visible = False
            buttonBuscar.Enabled = True
            textBoxBuscar.Enabled = True
            ' Quitamos el filtrado volviendo la lista a su estado anterior
            dataGridViewProductos.DataSource = Nothing
            dataGridViewProductos.DataSource = productosAfiltrar
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim productosFiltrados As List(Of Producto)
        Dim monto As Double
        If Double.TryParse(txtMonto.Text, monto) Then
            If radioMayorA.Checked Then
                productosFiltrados = productosAfiltrar.Where(Function(p) p.Precio > monto).ToList()
            ElseIf radioMenorA.Checked Then
                productosFiltrados = productosAfiltrar.Where(Function(p) p.Precio < monto).ToList()
            Else
                ' Si no hay opción seleccionada, mostrar todos los productos
                productosFiltrados = productosAfiltrar
            End If
            ' Actualizar el DataSource del DataGridView con los productos filtrados
            dataGridViewProductos.DataSource = Nothing
            dataGridViewProductos.DataSource = productosFiltrados
        Else
            MessageBox.Show("Ingrese un monto válido para el filtro de precio")
        End If
    End Sub
End Class

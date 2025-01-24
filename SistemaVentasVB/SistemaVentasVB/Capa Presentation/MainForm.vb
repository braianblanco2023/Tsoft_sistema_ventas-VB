Public Class MainForm
    ' Botones para navegar a otras secciones
    Private WithEvents btnClientes As New Button()
    Private WithEvents btnProductos As New Button()
    Private WithEvents btnVentas As New Button()
    Private WithEvents btnReportes As New Button()

    Public Sub New()
        ' Este llamado es requerido por el diseñador.
        InitializeComponent()

    End Sub

    ' Métodos de evento para los botones
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim clienteForm As New ClienteForm()
        clienteForm.ShowDialog()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim productoForm As New ProductoForm()
        productoForm.ShowDialog()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim ventaForm As New VentaForm()
        ventaForm.ShowDialog()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim reportForm As New ReportForm()
        reportForm.ShowDialog()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

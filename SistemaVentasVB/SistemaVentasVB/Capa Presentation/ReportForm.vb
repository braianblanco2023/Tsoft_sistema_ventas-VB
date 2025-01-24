Imports System.Configuration
Imports System.Data.SqlClient

Public Class ReportForm
    ' Controles del formulario
    Private WithEvents comboBoxReportType As ComboBox
    Private WithEvents dateTimePickerStart As DateTimePicker
    Private WithEvents dateTimePickerEnd As DateTimePicker
    Private WithEvents dataGridViewReport As DataGridView
    Private WithEvents buttonGenerateReport As Button

    Dim dataTable As DataTable
    Private almacen As New BusinessLogic
    ' Lógica del formulario
    Private Sub buttonGenerateReport_Click(sender As Object, e As EventArgs) Handles buttonGenerateReport.Click
        Dim reportType As String = comboBoxReportType.SelectedItem.ToString()
        Dim startDate As DateTime = dateTimePickerStart.Value
        Dim endDate As DateTime = dateTimePickerEnd.Value

        If reportType = "Ventas" Then
            dataTable = almacen.GeneraReporteVentas(startDate, endDate)
        ElseIf reportType = "Productos" Then
            dataTable = almacen.GeneraReporteProductos(startDate, endDate)
        End If
        dataGridViewReport.DataSource = dataTable
    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxReportType.SelectedItem = "Ventas"
    End Sub
End Class

Imports System.Data.SqlClient
Public Class ReportesData
    Inherits DataAccess

    Public Function GenerateSalesReport(startDate As DateTime, endDate As DateTime) As DataTable

        Dim table As New DataTable()
        Dim query As String = "SELECT v.ID, v.Fecha, c.Cliente, v.Total FROM ventas v JOIN clientes c ON v.IDCliente = c.ID WHERE v.Fecha BETWEEN @startDate AND @endDate"
        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@startDate", startDate)
                command.Parameters.AddWithValue("@endDate", endDate)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
            End Using
        End Using
        Return table
    End Function

    Public Function GenerateProductReport(startDate As DateTime, endDate As DateTime) As DataTable

        Dim table As New DataTable()
        Dim query As String = "SELECT p.Nombre, SUM(vi.Cantidad) AS CantidadVendida FROM ventasitems vi JOIN productos p ON vi.IDProducto = p.ID JOIN ventas v ON vi.IDVenta = v.ID WHERE v.Fecha BETWEEN @startDate AND @endDate GROUP BY p.Nombre"
        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@startDate", startDate)
                command.Parameters.AddWithValue("@endDate", endDate)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
            End Using
        End Using
        Return table
    End Function

End Class

Imports System.Data.SqlClient
Public Class VentaData
    Inherits DataAccess

    Public Function ObtenerResumen() As List(Of Venta)
        Dim ventasResume As New List(Of Venta)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT v.ID As Venta, c.Cliente, v.Fecha, v.Total " &
                              "FROM ventas v INNER JOIN clientes c ON v.IDCliente = c.ID"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim ventaResume As New Venta()
                        ventaResume.Nro = reader.GetInt32(0)
                        ventaResume.Cliente = reader.GetString(1)
                        ventaResume.Fecha = reader.GetDateTime(2)
                        ventaResume.Total = reader.GetDouble(3)
                        ventasResume.Add(ventaResume)
                    End While
                End Using
            End Using
        End Using
        Return ventasResume
    End Function

    Public Sub EliminarRegistroVenta(idVenta As Integer)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "DELETE FROM ventas WHERE ID = @ID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", idVenta)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ActualizarMontoVenta(nroVenta As Integer, totalVenta As Decimal)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "UPDATE ventas SET Total = @totalVenta WHERE ID = @nroVenta"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@totalVenta", totalVenta)
                command.Parameters.AddWithValue("@nroVenta", nroVenta)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function InsertarNuevaVenta(cliente As Integer, totalVenta As Decimal) As Integer
        Dim idVenta As Integer
        Dim fechaActual As Date = Date.Now
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total); SELECT SCOPE_IDENTITY();"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDCliente", cliente)
                command.Parameters.AddWithValue("@Fecha", fechaActual)
                command.Parameters.AddWithValue("@Total", totalVenta)
                ' Ejecutar la consulta de inserción y obtener el último ID insertado
                ' Utilizo ExecuteScalar() para obtener el valor devuelto por SELECT SCOPE_IDENTITY()
                idVenta = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
        Return idVenta
    End Function

    Public Function BuscarVentaByFecha(fecha As Date) As List(Of Venta)
        Dim ventas As New List(Of Venta)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT v.ID As Venta, c.Cliente, v.Fecha, v.Total " &
                              "FROM ventas v INNER JOIN clientes c ON v.IDCliente = c.ID " &
                              "WHERE CONVERT(date, v.Fecha) = @Fecha"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Fecha", fecha)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim ventaResume As New Venta()
                        ventaResume.Nro = reader.GetInt32(0)
                        ventaResume.Cliente = reader.GetString(1)
                        ventaResume.Fecha = reader.GetDateTime(2)
                        ventaResume.Total = reader.GetDouble(3)
                        ventas.Add(ventaResume)
                    End While
                End Using
            End Using
        End Using
        Return ventas
    End Function
End Class

Imports System.Data.SqlClient
Public Class VentaItemData
    Inherits DataAccess

    Public Function ObtenerItemsByVal(value As Object) As List(Of VentaItem)
        Dim query As String = "SELECT i.IDProducto, p.Nombre as Articulo, i.PrecioUnitario as [Precio Unitario], i.Cantidad, i.PrecioTotal as Subtotal FROM productos p INNER JOIN ventasitems i ON i.IDProducto = p.ID WHERE i.IDVenta = @value"
        Dim ventaItems As New List(Of VentaItem)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@value", value)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim ventaItem As New VentaItem()
                        ventaItem.IDProducto = reader.GetInt32(0)
                        ventaItem.Producto = reader.GetString(1)
                        ventaItem.Precio_Unitario = reader.GetDouble(2)
                        ventaItem.Cantidad = reader.GetDouble(3)
                        ventaItem.Subtotal = reader.GetDouble(4)
                        ventaItems.Add(ventaItem)
                    End While
                End Using
            End Using
        End Using
        Return ventaItems
    End Function

    Public Sub EliminarItemsVenta(nroVenta As Integer)
        Dim query As String = "DELETE FROM ventasitems WHERE IDVenta = @NroVenta"
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NroVenta", nroVenta)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertarItemsVenta(nroVenta As Integer, items As List(Of VentaItem))
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"
            For Each item As VentaItem In items
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@IDVenta", nroVenta)
                    command.Parameters.AddWithValue("@IDProducto", item.IDProducto)
                    command.Parameters.AddWithValue("@PrecioUnitario", item.Precio_Unitario)
                    command.Parameters.AddWithValue("@Cantidad", item.Cantidad)
                    command.Parameters.AddWithValue("@PrecioTotal", item.Subtotal)
                    command.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub
End Class

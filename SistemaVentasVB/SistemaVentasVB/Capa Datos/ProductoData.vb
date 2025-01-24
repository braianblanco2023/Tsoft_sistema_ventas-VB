Imports System.Data.SqlClient
Public Class ProductoData
    Inherits DataAccess

    Public Function ObtenerProductos() As List(Of Producto)
        Dim productos As New List(Of Producto)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM productos"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto()
                        producto.ID = reader.GetInt32(0)
                        producto.Nombre = reader.GetString(1)
                        producto.Precio = reader.GetDouble(2)
                        producto.Categoria = reader.GetString(3)
                        productos.Add(producto)
                    End While
                End Using
            End Using
        End Using
        Return productos
    End Function

    Public Function ProductosDisponibles() As List(Of String)
        Dim productos As New List(Of String)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT Nombre FROM productos"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As String
                        producto = reader.GetString(0)
                        productos.Add(producto)
                    End While
                End Using
            End Using
        End Using
        Return productos
    End Function

    Public Function BuscarProducto(busqueda As String) As List(Of Producto)
        Dim productos As New List(Of Producto)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM productos WHERE Nombre LIKE '%' + @busqueda + '%' OR Categoria LIKE '%' + @busqueda + '%'"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@busqueda", busqueda)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto()
                        producto.ID = reader.GetInt32(0)
                        producto.Nombre = reader.GetString(1)
                        producto.Precio = reader.GetDouble(2)
                        producto.Categoria = reader.GetString(3)
                        productos.Add(producto)
                    End While
                End Using
            End Using
        End Using
        Return productos
    End Function

    Public Function FiltrarPorPrecio(precio As Double, filtro As String) As List(Of Producto)
        Dim productosXprecio As New List(Of Producto)
        Dim query As String = ""

        If filtro = "PrecioMinimo" Then
            query = "SELECT * FROM productos WHERE Precio > @Precio"
        ElseIf filtro = "PrecioMaximo" Then
            query = "SELECT * FROM productos WHERE Precio < @Precio"
        Else
            Throw New ArgumentException("Filtro inválido. Debe ser 'PrecioMinimo' o 'PrecioMaximo'.")
        End If
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Precio", precio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto()
                        producto.ID = reader.GetInt32(0)
                        producto.Nombre = reader.GetString(1)
                        producto.Precio = reader.GetDouble(2)
                        producto.Categoria = reader.GetString(3)
                        productosXprecio.Add(producto)
                    End While
                End Using
            End Using
        End Using
        Return productosXprecio
    End Function

    Public Function ObtenerProductoSeleccionado(productoID As Integer) As Producto
        Dim producto As New Producto()
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM productos WHERE ID = @productoID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@productoID", productoID)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        producto.ID = reader.GetInt32(0)
                        producto.Nombre = reader.GetString(1)
                        producto.Precio = reader.GetDouble(2)
                        producto.Categoria = reader.GetString(3)
                    End While
                End Using
            End Using
        End Using
        Return producto
    End Function

    Public Sub ActualizarProducto(producto As Producto)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", producto.Nombre)
                command.Parameters.AddWithValue("@Precio", producto.Precio)
                command.Parameters.AddWithValue("@Categoria", producto.Categoria)
                command.Parameters.AddWithValue("@ID", producto.ID)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AgregarProducto(producto As Producto)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", producto.Nombre)
                command.Parameters.AddWithValue("@Precio", producto.Precio)
                command.Parameters.AddWithValue("@Categoria", producto.Categoria)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub EliminarProducto(id As Integer)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "DELETE FROM productos WHERE ID = @ID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ItemProducto(prod As String) As Producto
        Dim producto As New Producto()
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM productos WHERE Nombre = @producto"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@producto", prod)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        producto.ID = reader.GetInt32(0)
                        producto.Nombre = reader.GetString(1)
                        producto.Precio = reader.GetDouble(2)
                        producto.Categoria = reader.GetString(3)
                    End While
                End Using
            End Using
        End Using
        Return producto
    End Function
End Class

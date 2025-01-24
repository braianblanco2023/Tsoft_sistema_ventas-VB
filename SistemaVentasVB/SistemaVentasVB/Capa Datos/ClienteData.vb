Imports System.Data.SqlClient
Public Class ClienteData
    Inherits DataAccess

    Public Function ObtenerIdCliente(nombre As String) As Integer
        Dim idCliente As Integer
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT ID FROM clientes WHERE Cliente = @nombre"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", nombre)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        idCliente = reader.GetInt32(0)
                    End While
                End Using
            End Using
        End Using
        Return idCliente
    End Function

    Public Function ObtenerClientes() As List(Of Cliente)
        Dim clientes As New List(Of Cliente)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM clientes"
            Using Command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = Command.ExecuteReader()
                    While reader.Read()
                        Dim cliente As New Cliente()
                        cliente.ID = reader.GetInt32(0)
                        cliente.Nombre = reader.GetString(1)
                        cliente.Telefono = reader.GetString(2)
                        cliente.Correo = reader.GetString(3)
                        clientes.Add(cliente)
                    End While
                End Using
            End Using
        End Using
        Return clientes
    End Function

    Public Function ClientesDisponibles() As List(Of String)
        Dim clientes As New List(Of String)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT Cliente FROM clientes"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim cliente As String
                        cliente = reader.GetString(0)
                        clientes.Add(cliente)
                    End While
                End Using
            End Using
        End Using
        Return clientes
    End Function

    Public Function BuscarCliente(nombre As String) As List(Of Cliente)
        Dim clientes As New List(Of Cliente)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM clientes WHERE Cliente LIKE '%' + @nombre + '%'"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", nombre)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim cliente As New Cliente()
                        cliente.ID = reader.GetInt32(0)
                        cliente.Nombre = reader.GetString(1)
                        cliente.Telefono = reader.GetString(2)
                        cliente.Correo = reader.GetString(3)
                        clientes.Add(cliente)
                    End While
                End Using
            End Using
        End Using
        Return clientes
    End Function

    Public Function ObtenerClienteSeleccionado(clienteID As Integer) As Cliente
        Dim cliente As New Cliente()
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM clientes WHERE ID = @clienteID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@clienteID", clienteID)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cliente.ID = reader.GetInt32(0)
                        cliente.Nombre = reader.GetString(1)
                        cliente.Telefono = reader.GetString(2)
                        cliente.Correo = reader.GetString(3)
                    End While
                End Using
            End Using
        End Using
        Return cliente
    End Function

    Public Sub ActualizarCliente(cliente As Cliente)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "UPDATE clientes SET Cliente = @Nombre, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                command.Parameters.AddWithValue("@Correo", cliente.Correo)
                command.Parameters.AddWithValue("@ID", cliente.ID)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AgregarCliente(cliente As Cliente)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Nombre, @Telefono, @Correo)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                command.Parameters.AddWithValue("@Correo", cliente.Correo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub EliminarCliente(id As Integer)
        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim query As String = "DELETE FROM clientes WHERE ID = @ID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class

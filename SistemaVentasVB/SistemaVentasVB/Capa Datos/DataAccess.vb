Imports System.Data.SqlClient
Imports System.Configuration

Public Class DataAccess
    Private connectionString As String = ConfigurationManager.ConnectionStrings("DatabaseConnection").ConnectionString

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class

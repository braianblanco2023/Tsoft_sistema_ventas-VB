Public Class Venta
    Public Property Nro As Integer
    Public Property Cliente As String
    Public Property Fecha As DateTime
    Public Property Total As Decimal

    Public Property VentaItems As List(Of VentaItem)
End Class

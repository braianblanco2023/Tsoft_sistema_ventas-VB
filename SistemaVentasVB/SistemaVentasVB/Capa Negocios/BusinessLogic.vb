Public Class BusinessLogic
    Private clienteData As New ClienteData()
    Private productoData As New ProductoData()
    Private ventaData As New VentaData()
    Private ventaItemData As New VentaItemData()
    Private reporteData As New ReportesData()

    'Logica para los Clientes

    Public Function BuscarIdCliente(nombre As String) As Integer
        Dim idCliente As Integer = clienteData.ObtenerIdCliente(nombre)
        Return idCliente
    End Function
    Public Function ObtenerClientes() As List(Of Cliente)
        Return clienteData.ObtenerClientes()
    End Function

    Public Function ObtenerCliente(clienteID As Integer) As Cliente
        Return clienteData.ObtenerClienteSeleccionado(clienteID)
    End Function
    Public Function BuscarDatosCliente(nombre As String) As List(Of Cliente)
        Return clienteData.BuscarCliente(nombre)
    End Function

    Public Sub GuardarClienteModif(cliente As Cliente)
        clienteData.ActualizarCliente(cliente)
    End Sub

    Public Sub GuardarClienteNew(cliente As Cliente)
        clienteData.AgregarCliente(cliente)
    End Sub

    'Validar Campos Cliente
    Public Function ValidarCliente(cliente As Cliente) As String
        If String.IsNullOrEmpty(cliente.Nombre) Or String.IsNullOrEmpty(cliente.Telefono) Or String.IsNullOrEmpty(cliente.Correo) Then
            Return "Todos los campos son obligatorios."
        End If
        Return String.Empty
    End Function

    Public Sub EliminarCliente(id As Integer)
        clienteData.EliminarCliente(id)
    End Sub

    'Logica para Productos
    Public Function ObtenerProductos() As List(Of Producto)
        Return productoData.ObtenerProductos()
    End Function

    Public Function ObtenerProducto(productoID As Integer) As Producto
        Return productoData.ObtenerProductoSeleccionado(productoID)
    End Function
    Public Function BuscarDatosProducto(nombre As String) As List(Of Producto)
        Return productoData.BuscarProducto(nombre)
    End Function

    Public Function FiltraProductosPorPrecio(precio As Double, filtro As String) As List(Of Producto)
        Return productoData.FiltrarPorPrecio(precio, filtro)
    End Function
    Public Sub GuardarProductoModif(producto As Producto)
        productoData.ActualizarProducto(producto)
    End Sub

    Public Sub GuardarProductoNew(producto As Producto)
        productoData.AgregarProducto(producto)
    End Sub

    'Validar Campos Producto
    Public Function ValidarProducto(producto As Producto) As String
        If String.IsNullOrEmpty(producto.Nombre) OrElse String.IsNullOrEmpty(producto.Categoria) Then
            Return "Todos los campos son obligatorios."
        End If
        Return String.Empty
    End Function

    Public Sub EliminarProducto(id As Integer)
        productoData.EliminarProducto(id)
    End Sub

    'Logica para Ventas y Resumen Ventas
    Public Function ObtenerVentas() As List(Of Venta)
        Return ventaData.ObtenerResumen()
    End Function

    Public Function ObtenerVentaItems(value As Object) As List(Of VentaItem)
        Return ventaItemData.ObtenerItemsByVal(value)
    End Function

    Public Sub EliminarVenta(idVenta As Integer)
        ventaData.EliminarRegistroVenta(idVenta)
    End Sub

    Public Function BuscarVentaFecha(fecha As Date) As List(Of Venta)
        Return ventaData.BuscarVentaByFecha(fecha)
    End Function

    Public Function ListarProductos() As List(Of String)
        Return productoData.ProductosDisponibles()
    End Function

    Public Function ListarClientes() As List(Of String)
        Return clienteData.ClientesDisponibles()
    End Function

    Public Function ObtenerItem(producto As String, cantidad As Integer) As VentaItem
        Dim datosProducto As New Producto()
        Dim ventaItem As New VentaItem()
        datosProducto = productoData.ItemProducto(producto)
        ventaItem.IDProducto = datosProducto.ID
        ventaItem.Producto = datosProducto.Nombre
        ventaItem.Precio_Unitario = datosProducto.Precio
        ventaItem.Cantidad = cantidad
        ventaItem.Subtotal = ventaItem.Precio_Unitario * ventaItem.Cantidad
        Return ventaItem
    End Function
    Public Function totalSum(columna As String, dataGrid As DataGridView) As String
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dataGrid.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(columna).Value)
            End If
        Next
        total.ToString()
        Return total
    End Function

    Public Function itemRepetido(producto As String, cantidad As Integer, grilla As List(Of VentaItem)) As List(Of VentaItem)
        Dim articuloExistente = grilla.FirstOrDefault(Function(a) a.Producto = producto)
        If articuloExistente IsNot Nothing Then
            ' Si el producto ya existe, incrementar la cantidad
            articuloExistente.Cantidad += cantidad
            articuloExistente.Subtotal = articuloExistente.Cantidad * articuloExistente.Precio_Unitario
        Else
            ' Si el producto no existe, agregar un nuevo articulo
            grilla.Add(ObtenerItem(producto, cantidad))
        End If
        Return grilla
    End Function

    Public Sub GuardaCambiosVenta(nroVenta As Integer, totalVenta As Decimal, items As List(Of VentaItem))
        ventaItemData.EliminarItemsVenta(nroVenta)
        ventaItemData.InsertarItemsVenta(nroVenta, items)
        ventaData.ActualizarMontoVenta(nroVenta, totalVenta)
    End Sub

    Public Sub GuardarNuevaVenta(cliente As Integer, totalVenta As Decimal, items As List(Of VentaItem))
        Dim nroVenta As Integer = ventaData.InsertarNuevaVenta(cliente, totalVenta)
        ventaItemData.InsertarItemsVenta(nroVenta, items)
    End Sub

    'Para Reportes
    Public Function GeneraReporteVentas(startDate As DateTime, endDate As DateTime) As DataTable
        Return reporteData.GenerateSalesReport(startDate, endDate)
    End Function

    Public Function GeneraReporteProductos(startDate As DateTime, endDate As DateTime) As DataTable
        Return reporteData.GenerateProductReport(startDate, endDate)
    End Function
End Class


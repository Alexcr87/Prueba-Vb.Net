Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClassVentas
    Private Shared ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString
        End Get
    End Property

    Public Function ObtenerClientes() As DataTable
        Dim query As String = "SELECT Id, Cliente FROM clientes"
        Dim dt As New DataTable()

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using

        Return dt
    End Function

    Public Sub AgregarVenta(venta As Venta)
        Using connection As New SqlConnection(ConnectionString)
            connection.Open()

            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Try
                Dim queryVenta As String = "INSERT INTO ventas (IdCliente, Fecha, Total) OUTPUT INSERTED.Id VALUES (@IdCliente, @Fecha, @Total)"
                Dim commandVenta As New SqlCommand(queryVenta, connection, transaction)
                commandVenta.Parameters.AddWithValue("@IdCliente", venta.IdCliente)
                commandVenta.Parameters.AddWithValue("@Fecha", venta.Fecha)
                commandVenta.Parameters.AddWithValue("@Total", venta.Detalles.Sum(Function(d) d.PrecioTotal))
                Dim idVenta As Integer = Convert.ToInt32(commandVenta.ExecuteScalar())
                Dim queryItem As String = "INSERT INTO ventasitems (IdVenta, IdProducto, Cantidad, PrecioUnitario, PrecioTotal) VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario, @PrecioTotal)"
                For Each detalle As VentaDetalle In venta.Detalles
                    Dim commandItem As New SqlCommand(queryItem, connection, transaction)
                    commandItem.Parameters.AddWithValue("@IdVenta", idVenta)
                    commandItem.Parameters.AddWithValue("@IdProducto", detalle.IdProducto)
                    commandItem.Parameters.AddWithValue("@Cantidad", detalle.Cantidad)
                    commandItem.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario)
                    commandItem.Parameters.AddWithValue("@PrecioTotal", detalle.PrecioTotal)
                    commandItem.ExecuteNonQuery()
                Next

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                Throw New Exception("Error al registrar la venta: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ObtenerProductos() As DataTable
        Dim query As String = "SELECT Id, Nombre, Precio FROM productos"
        Dim dt As New DataTable()

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using

        Return dt
    End Function

    Public Function BuscarVentas(idCliente As Integer, fechaDesde As DateTime, fechaHasta As DateTime, fechaExacta As Boolean) As List(Of Venta)
        Dim query As String = "SELECT * FROM ventas WHERE IdCliente = @IdCliente"
        If fechaExacta Then
            query &= " AND Fecha = @FechaExacta"
        Else
            query &= " AND Fecha >= @FechaDesde AND Fecha <= @FechaHasta"
        End If

        Dim ventas As New List(Of Venta)()

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdCliente", idCliente)
                command.Parameters.AddWithValue("@FechaDesde", fechaDesde)
                command.Parameters.AddWithValue("@FechaHasta", fechaHasta)

                If fechaExacta Then
                    command.Parameters.AddWithValue("@FechaExacta", fechaDesde)
                End If

                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim venta As New Venta With {
                                .Id = Convert.ToInt32(reader("Id")),
                                .IdCliente = Convert.ToInt32(reader("IdCliente")),
                                .Fecha = Convert.ToDateTime(reader("Fecha")),
                                .Total = Convert.ToDecimal(reader("Total"))
                            }
                            venta.Detalles = CargarDetallesVenta(venta.Id)

                            ventas.Add(venta)
                        End While
                    End Using
                Catch ex As Exception
                    Throw New Exception("Error al buscar ventas: " & ex.Message)
                End Try
            End Using
        End Using

        Return ventas
    End Function

    Private Function CargarDetallesVenta(idVenta As Integer) As List(Of VentaDetalle)
        Dim query As String = "SELECT * FROM ventas_detalle WHERE IdVenta = @IdVenta"
        Dim detalles As New List(Of VentaDetalle)()

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdVenta", idVenta)

                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim detalle As New VentaDetalle With {
                                .Id = Convert.ToInt32(reader("Id")),
                                .IdVenta = Convert.ToInt32(reader("IdVenta")),
                                .IdProducto = Convert.ToInt32(reader("IdProducto")),
                                .Cantidad = Convert.ToInt32(reader("Cantidad")),
                                .PrecioUnitario = Convert.ToDecimal(reader("PrecioUnitario")),
                                .PrecioTotal = Convert.ToDecimal(reader("PrecioTotal"))
                            }
                            detalles.Add(detalle)
                        End While
                    End Using
                Catch ex As Exception
                    Throw New Exception("Error al cargar detalles de la venta: " & ex.Message)
                End Try
            End Using
        End Using

        Return detalles
    End Function
    Public Function BuscarVentasEntreFechas(fechaInicio As DateTime, fechaFin As DateTime) As List(Of Venta)
        Dim query As String = "SELECT * FROM ventas WHERE Fecha BETWEEN @FechaInicio AND @FechaFin"
        Dim lista As New List(Of Venta)()

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@FechaFin", fechaFin)

                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim venta As New Venta() With {
                                .Id = Convert.ToInt32(reader("ID")),
                                .IdCliente = Convert.ToInt32(reader("IdCliente")),
                                .Fecha = Convert.ToDateTime(reader("Fecha")),
                                .Total = Convert.ToDecimal(reader("Total"))
                            }
                            lista.Add(venta)
                        End While
                    End Using
                Catch ex As Exception
                    Throw New Exception("Error al buscar las ventas entre fechas: " & ex.Message)
                End Try
            End Using
        End Using

        Return lista
    End Function

    Public Function BuscarVentasPorClienteYFechas(idCliente As Integer, fechaInicio As DateTime, fechaFin As DateTime) As List(Of Venta)
        Dim query As String = "SELECT * FROM ventas WHERE IdCliente = @IdCliente AND Fecha BETWEEN @FechaInicio AND @FechaFin"
        Dim lista As New List(Of Venta)()

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdCliente", idCliente)
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@FechaFin", fechaFin)

                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim venta As New Venta() With {
                                .Id = Convert.ToInt32(reader("ID")),
                                .IdCliente = Convert.ToInt32(reader("IdCliente")),
                                .Fecha = Convert.ToDateTime(reader("Fecha")),
                                .Total = Convert.ToDecimal(reader("Total"))
                            }
                            lista.Add(venta)
                        End While
                    End Using
                Catch ex As Exception
                    Throw New Exception("Error al buscar las ventas por cliente y fechas: " & ex.Message)
                End Try
            End Using
        End Using

        Return lista
    End Function


    Public Function ObtenerDetallesVenta(idVenta As Integer) As List(Of Dictionary(Of String, Object))

        Dim detalles As New List(Of Dictionary(Of String, Object))()
        Dim query As String = "SELECT * FROM VentasItems WHERE IdVenta = @IdVenta"

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdVenta", idVenta)

                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()

                        While reader.Read()
                            Dim detalle As New Dictionary(Of String, Object) From {
                            {"IDProducto", reader("IDProducto").ToString()},
                            {"Cantidad", Convert.ToInt32(reader("Cantidad"))},
                            {"PrecioUnitario", Convert.ToDecimal(reader("PrecioUnitario"))},
                            {"PrecioTotal", Convert.ToDecimal(reader("PrecioTotal"))}
                        }
                            detalles.Add(detalle)
                        End While
                    End Using
                Catch ex As Exception
                    Throw New Exception("Error al obtener detalles de la venta: " & ex.Message)
                End Try
            End Using
        End Using

        Return detalles
    End Function

    Public Function ObtenerTodasLasVentas() As List(Of Venta)
        Dim listaVentas As New List(Of Venta)()
        Dim query As String = "SELECT * FROM Ventas"

        Using conn As New SqlConnection(ConnectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim venta As New Venta() With {
                            .Id = Convert.ToInt32(reader("Id")),
                            .IdCliente = Convert.ToInt32(reader("IdCliente")),
                            .Fecha = Convert.ToDateTime(reader("Fecha")),
                            .Total = Convert.ToDecimal(reader("Total"))
                        }
                        listaVentas.Add(venta)
                    End While
                End Using
            End Using
        End Using

        Return listaVentas
    End Function
End Class

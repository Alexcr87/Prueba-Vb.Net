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
End Class

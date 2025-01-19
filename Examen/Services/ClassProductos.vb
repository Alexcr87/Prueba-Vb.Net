Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClassProductos
    Private Shared ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString
        End Get
    End Property

    Public Function CargarDatos() As List(Of Producto)
        Dim query As String = "SELECT * FROM productos"
        Dim productos As New List(Of Producto)()

        Using connection As New SqlConnection(ConnectionString)
            Try
                Dim command As New SqlCommand(query, connection)
                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto() With {
                            .Id = Convert.ToInt32(reader("ID")),
                            .Nombre = reader("Nombre").ToString(),
                            .Precio = Convert.ToDecimal(reader("Precio")),
                            .Categoria = reader("Categoria").ToString()
                        }
                        productos.Add(producto)
                    End While
                End Using
            Catch ex As Exception
                Throw New Exception("Error al cargar los datos: " & ex.Message)
            End Try
        End Using
        Return productos
    End Function

    Public Sub CrearProducto(nombre As String, precio As Decimal, categoria As String)
        Dim query As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Precio", precio)
                command.Parameters.AddWithValue("@Categoria", categoria)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al crear el producto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub EliminarProducto(id As Integer)
        Dim query As String = "DELETE FROM productos WHERE ID = @ID"

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al eliminar el producto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function BuscarProductoPorID(id As Integer) As Producto
        Dim query As String = "SELECT * FROM productos WHERE ID = @ID"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                Dim table As New DataTable()

                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        Dim row As DataRow = table.Rows(0)
                        Return New Producto() With {
                            .Id = Convert.ToInt32(row("ID")),
                            .Nombre = row("Nombre").ToString(),
                            .Precio = Convert.ToDecimal(row("Precio")),
                            .Categoria = row("Categoria").ToString()
                        }
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al buscar el producto: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Sub ModificarProducto(id As Integer, nombre As String, precio As Double, categoria As String)
        Dim query As String = "UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID"

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Precio", precio)
                command.Parameters.AddWithValue("@Categoria", categoria)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al modificar el producto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class

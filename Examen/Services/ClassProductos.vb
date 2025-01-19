Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClassProductos
    Private Shared ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString
        End Get
    End Property

    Public Function CargarDatos() As DataTable
        Dim query As String = "SELECT * FROM productos"
        Dim table As New DataTable()
        Using connection As New SqlConnection(ConnectionString)
            Try
                Dim adapter As New SqlDataAdapter(query, connection)
                connection.Open()
                adapter.Fill(table)
            Catch ex As Exception
                Throw New Exception("Error al cargar los datos: " & ex.Message)
            End Try
        End Using
        Return table
    End Function

    Public Sub CrearProducto(nombre As String, precio As Integer, categoria As String)
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

    Public Sub EliminarProducto(ID As Integer)
        Dim query As String = "DELETE FROM productos WHERE ID = @ID"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", ID)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al eliminar el producto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function BuscarProductoPorID(id As Integer) As DataRow
        Dim query As String = "SELECT * FROM productos WHERE ID = @ID"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                Try
                    connection.Open()
                    adapter.Fill(table)
                    If table.Rows.Count > 0 Then
                        Return table.Rows(0)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al buscar el producto: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Sub ModificarProducto(id As Integer, nombre As String, precio As Integer, categoria As String)
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

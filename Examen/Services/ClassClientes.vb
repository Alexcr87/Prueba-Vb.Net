Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClassClientes
    Private Shared ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString
        End Get
    End Property

    Public Function CargarDatos() As DataTable
        Dim query As String = "SELECT * FROM clientes"
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

    Public Sub CrearCliente(cliente As String, telefono As Integer, correo As String)
        Dim query As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cliente", cliente)
                command.Parameters.AddWithValue("@Telefono", telefono)
                command.Parameters.AddWithValue("@Correo", correo)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al crear el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub EliminarCliente(ID As Integer)
        Dim query As String = "DELETE FROM clientes WHERE ID = @ID"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", ID)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al eliminar el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function BuscarClientePorID(id As Integer) As DataRow
        Dim query As String = "SELECT * FROM clientes WHERE ID = @ID"
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
                    Throw New Exception("Error al buscar el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Sub ModificarCliente(id As Integer, cliente As String, telefono As Integer, correo As String)
        Dim query As String = "UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.Parameters.AddWithValue("@Cliente", cliente)
                command.Parameters.AddWithValue("@Telefono", telefono)
                command.Parameters.AddWithValue("@Correo", correo)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al modificar el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class

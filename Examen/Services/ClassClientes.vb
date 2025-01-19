Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClassClientes
    Private Shared ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString
        End Get
    End Property

    Public Function CargarDatos() As List(Of Cliente)
        Dim query As String = "SELECT * FROM clientes"
        Dim clientes As New List(Of Cliente)()

        Using connection As New SqlConnection(ConnectionString)
            Try
                Dim command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim cliente As New Cliente(
                        Convert.ToInt32(reader("ID")),
                        reader("Cliente").ToString(),
                        Convert.ToInt32(reader("Telefono")),
                        reader("Correo").ToString()
                    )
                    clientes.Add(cliente)
                End While
            Catch ex As Exception
                Throw New Exception("Error al cargar los datos: " & ex.Message)
            End Try
        End Using
        Return clientes
    End Function

    Public Sub CrearCliente(cliente As Cliente)
        If cliente Is Nothing Then
            Throw New ArgumentNullException("El cliente no puede ser nulo")
        End If

        Dim query As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cliente", cliente.Cliente)
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                command.Parameters.AddWithValue("@Correo", cliente.Correo)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al crear el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub ModificarCliente(cliente As Cliente)
        If cliente Is Nothing Then
            Throw New ArgumentNullException("El cliente no puede ser nulo")
        End If

        Dim query As String = "UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", cliente.ID)
                command.Parameters.AddWithValue("@Cliente", cliente.Cliente)
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                command.Parameters.AddWithValue("@Correo", cliente.Correo)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al modificar el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub EliminarCliente(id As Integer)
        Dim query As String = "DELETE FROM clientes WHERE ID = @ID"
        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error al eliminar el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function BuscarClientePorID(id As Integer) As Cliente
        Dim query As String = "SELECT * FROM clientes WHERE ID = @ID"
        Dim cliente As Cliente = Nothing

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)

                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        cliente = New Cliente(
                            Convert.ToInt32(reader("ID")),
                            reader("Cliente").ToString(),
                            Convert.ToInt32(reader("Telefono")),
                            reader("Correo").ToString()
                        )
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al buscar el cliente por ID: " & ex.Message)
                End Try
            End Using
        End Using

        Return cliente
    End Function
End Class

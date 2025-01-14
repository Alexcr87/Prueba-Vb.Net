Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClassClientes
    ' Método para cargar datos desde la base de datos
    Public Function CargarDatos() As DataTable
        ' Cadena de conexión (puedes obtenerla del archivo App.config)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString

        ' Consulta SQL
        Dim query As String = "SELECT * FROM clientes"

        ' Tabla para almacenar los datos
        Dim table As New DataTable()

        ' Conexión a la base de datos
        Using connection As New SqlConnection(connectionString)
            Try
                ' Adaptador para ejecutar la consulta
                Dim adapter As New SqlDataAdapter(query, connection)

                ' Abrir conexión y llenar la tabla
                connection.Open()
                adapter.Fill(table)
            Catch ex As Exception
                ' Si hay un error, lo lanzamos para manejarlo en el formulario
                Throw New Exception("Error al cargar los datos: " & ex.Message)
            End Try
        End Using

        ' Retornar los datos
        Return table
    End Function
End Class

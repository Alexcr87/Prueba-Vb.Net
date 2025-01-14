Imports System.Data.SqlClient
Imports System.Configuration

Module Module1
    Sub Main()
        ' Obtener la cadena de conexión desde el archivo app.config
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString

        ' Crear una conexión a la base de datos
        Using conn As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                conn.Open()
                Console.WriteLine("Conexión exitosa a la base de datos.")
            Catch ex As Exception
                ' Manejar errores
                Console.WriteLine("Error al conectar: " & ex.Message)
            End Try
        End Using
    End Sub
End Module

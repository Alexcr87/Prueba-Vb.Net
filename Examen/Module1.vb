Imports System.Data.SqlClient
Imports System.Configuration

Module Module1
    Sub Main()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ExamenBDD").ConnectionString
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Console.WriteLine("Conexión exitosa a la base de datos.")
            Catch ex As Exception
                Console.WriteLine("Error al conectar: " & ex.Message)
            End Try
        End Using
    End Sub
End Module

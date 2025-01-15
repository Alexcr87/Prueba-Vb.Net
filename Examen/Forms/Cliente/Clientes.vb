Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim clientes As New ClassClientes()
            Dim tablaClientes As DataTable = clientes.CargarDatos()
            DataGridView1.DataSource = tablaClientes
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class

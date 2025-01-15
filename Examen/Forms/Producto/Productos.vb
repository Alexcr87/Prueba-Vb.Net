Public Class Productos
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim productos As New ClassProductos()
            Dim tablaProductos As DataTable = productos.CargarDatos()
            DataGridView1.DataSource = tablaProductos
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
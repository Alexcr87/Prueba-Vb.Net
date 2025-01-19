Public Class AgregarProducto
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Dim productos As New ClassProductos()
            Dim nombre As String = TextBoxNombre.Text
            Dim precio As Integer = TextBoxPrecio.Text
            Dim categoria As String = TextBoxCategoria.Text
            productos.CrearProducto(nombre, precio, categoria)
            MessageBox.Show("Producto creado correctamente.")
            TextBoxHelper.LimpiarTextBoxes(Me)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
End Class
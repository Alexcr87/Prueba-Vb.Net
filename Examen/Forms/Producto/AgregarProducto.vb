Public Class AgregarProducto
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxNombre.Text) OrElse
               String.IsNullOrWhiteSpace(TextBoxPrecio.Text) OrElse
               String.IsNullOrWhiteSpace(TextBoxCategoria.Text) Then
                MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim precioTexto As String = TextBoxPrecio.Text.Trim()

            If precioTexto.Contains(".") Then
                precioTexto = precioTexto.Replace(".", ",")
            End If

            Dim precio As Double
            If Not Double.TryParse(precioTexto, precio) Then
                MessageBox.Show("Por favor, ingrese un precio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim nombre As String = TextBoxNombre.Text
            Dim categoria As String = TextBoxCategoria.Text
            Dim productos As New ClassProductos()
            productos.CrearProducto(nombre, precio, categoria)

            MessageBox.Show("Producto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxHelper.LimpiarTextBoxes(Me)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click

        Me.Close()
    End Sub

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

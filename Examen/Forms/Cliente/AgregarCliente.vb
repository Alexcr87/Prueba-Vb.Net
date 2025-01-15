Public Class AgregarCliente
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Dim clientes As New ClassClientes()
            Dim cliente As String = TextBoxCliente.Text
            Dim telefono As Integer = TextBoxTelefono.Text
            Dim correo As String = TextBoxCorreo.Text
            clientes.CrearCliente(cliente, telefono, correo)
            MessageBox.Show("Cliente creado correctamente.")
            TextBoxHelper.LimpiarTextBoxes(Me)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class

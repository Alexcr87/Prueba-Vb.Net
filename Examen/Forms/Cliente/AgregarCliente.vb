Public Class AgregarCliente
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxCliente.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxTelefono.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxCorreo.Text) Then
                MessageBox.Show("Por favor, complete todos los campos antes de crear el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim cliente As String = TextBoxCliente.Text
            Dim telefono As Integer
            Dim correo As String = TextBoxCorreo.Text

            If Not Integer.TryParse(TextBoxTelefono.Text, telefono) Then
                MessageBox.Show("Por favor, ingrese un número de telefono válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim clienteObj As New Cliente(0, cliente, telefono, correo)
            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea crear este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmacion = DialogResult.Yes Then
                Dim clientes As New ClassClientes()
                clientes.CrearCliente(clienteObj)
                MessageBox.Show("Cliente creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxHelper.LimpiarTextBoxes(Me)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

End Class

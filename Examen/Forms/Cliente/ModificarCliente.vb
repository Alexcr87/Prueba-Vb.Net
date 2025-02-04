﻿Public Class ModificarCliente
    Private clienteID As Integer?

    Public Sub New(Optional ByVal id As Integer? = Nothing)
        InitializeComponent()
        clienteID = id
    End Sub
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxBuscar.Text) Then
                MessageBox.Show("Por favor, ingrese un ID para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim id As Integer
            If Not Integer.TryParse(TextBoxBuscar.Text, id) Then
                MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim clientes As New ClassClientes()
            Dim clienteEncontrado As Cliente = clientes.BuscarClientePorID(id)
            If clienteEncontrado IsNot Nothing Then
                TextBoxCliente.Text = clienteEncontrado.Cliente
                TextBoxTelefono.Text = clienteEncontrado.Telefono.ToString()
                TextBoxCorreo.Text = clienteEncontrado.Correo

                ControlVisibilityHelper.HacerVisibleControles(Me)
                TextBoxBuscar.Enabled = False
            Else
                MessageBox.Show("No se encontró un cliente con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxCliente.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxTelefono.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxCorreo.Text) Then
                MessageBox.Show("Por favor, complete todos los campos antes de modificar el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim id As Integer = Convert.ToInt32(TextBoxBuscar.Text)
            Dim cliente As String = TextBoxCliente.Text
            Dim telefono As Integer
            Dim correo As String = TextBoxCorreo.Text

            If Not Integer.TryParse(TextBoxTelefono.Text, telefono) Then
                MessageBox.Show("Por favor, ingrese un número de telefono válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim clienteObj As New Cliente(id, cliente, telefono, correo)
            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea modificar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmacion = DialogResult.Yes Then
                Dim clientes As New ClassClientes()
                clientes.ModificarCliente(clienteObj)
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxHelper.LimpiarTextBoxes(Me)
                ControlVisibilityHelper.HacerInvisibleControles(Me)
                TextBoxBuscar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        TextBoxHelper.LimpiarTextBoxes(Me)
        ControlVisibilityHelper.HacerInvisibleControles(Me)
        TextBoxBuscar.Enabled = True
    End Sub

    Private Sub ModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If clienteID.HasValue Then
                Dim clientes As New ClassClientes()
                Dim clienteEncontrado As Cliente = clientes.BuscarClientePorID(clienteID.Value)

                If clienteEncontrado IsNot Nothing Then
                    TextBoxBuscar.Text = clienteID.Value.ToString()
                    TextBoxCliente.Text = clienteEncontrado.Cliente
                    TextBoxTelefono.Text = clienteEncontrado.Telefono.ToString()
                    TextBoxCorreo.Text = clienteEncontrado.Correo

                    ControlVisibilityHelper.HacerVisibleControles(Me)
                    TextBoxBuscar.Enabled = False
                Else
                    MessageBox.Show("No se encontró un cliente con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ControlVisibilityHelper.HacerInvisibleControles(Me)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

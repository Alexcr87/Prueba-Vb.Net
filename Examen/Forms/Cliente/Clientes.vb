﻿Public Class Clientes
    Private tablaClientes As DataTable

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
            DataGridView1.ReadOnly = True
            DataGridView1.AllowUserToAddRows = False
            Dim clientes As New ClassClientes()
            tablaClientes = clientes.CargarDatos()
            DataGridView1.DataSource = tablaClientes
            LlenarComboBoxCorreo()
            LlenarComboBoxOrdenar()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboBoxCorreo()
        Try
            Dim dominiosCorreo = tablaClientes.AsEnumerable().
                Select(Function(row) row.Field(Of String)("Correo").Split("@"c).Last()).
                Distinct()

            ComboBoxCorreo.Items.Clear()
            ComboBoxCorreo.Items.Add("Todos")
            ComboBoxCorreo.Items.AddRange(dominiosCorreo.ToArray())
            ComboBoxCorreo.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error al llenar dominios de correo: " & ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboBoxOrdenar()
        ComboBoxOrdenar.Items.Clear()
        ComboBoxOrdenar.Items.Add("Nombre (A-Z)")
        ComboBoxOrdenar.Items.Add("Nombre (Z-A)")
        ComboBoxOrdenar.SelectedIndex = 0
    End Sub

    Private Sub AplicarFiltrosYOrdenamiento()
        Try
            Dim textoFiltro As String = TextBoxCliente.Text.ToLower()
            Dim correoFiltro As String = ComboBoxCorreo.SelectedItem?.ToString()
            Dim ordenamiento As String = ComboBoxOrdenar.SelectedItem?.ToString()
            Dim vista As New DataView(tablaClientes)
            Dim filtro As String = ""

            If Not String.IsNullOrEmpty(textoFiltro) Then
                filtro = $"Cliente LIKE '%{textoFiltro}%'"
            End If

            If correoFiltro <> "Todos" Then
                If Not String.IsNullOrEmpty(filtro) Then
                    filtro &= " AND "
                End If
                filtro &= $"Correo LIKE '%@{correoFiltro}'"
            End If

            vista.RowFilter = filtro


            Select Case ordenamiento
                Case "Nombre (A-Z)"
                    vista.Sort = "Cliente ASC"
                Case "Nombre (Z-A)"
                    vista.Sort = "Cliente DESC"
            End Select

            DataGridView1.DataSource = vista
        Catch ex As Exception
            MessageBox.Show("Error al aplicar filtros y ordenamiento: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBoxCliente_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCliente.TextChanged
        AplicarFiltrosYOrdenamiento()
    End Sub

    Private Sub ComboBoxCorreo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCorreo.SelectedIndexChanged
        AplicarFiltrosYOrdenamiento()
    End Sub

    Private Sub ComboBoxOrdenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOrdenar.SelectedIndexChanged
        AplicarFiltrosYOrdenamiento()
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Dim agregarClienteForm As New AgregarCliente()
            agregarClienteForm.ShowDialog()
            Dim clientes As New ClassClientes()
            tablaClientes = clientes.CargarDatos()
            DataGridView1.DataSource = tablaClientes
        Catch ex As Exception
            MessageBox.Show("Error al agregar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim id As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)
                Dim modificarFormulario As New ModificarCliente(id)
                modificarFormulario.ShowDialog()
                Dim clientes As New ClassClientes()
                tablaClientes = Clientes.CargarDatos()
                DataGridView1.DataSource = tablaClientes
            Else
                Dim modificarFormulario As New ModificarCliente()
                Dim clientes As New ClassClientes()
                tablaClientes = Clientes.CargarDatos()
                DataGridView1.DataSource = tablaClientes
                modificarFormulario.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir el formulario de modificación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try

            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmacion = DialogResult.Yes Then
                Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim ID As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)
                Dim clientes As New ClassClientes()
                clientes.EliminarCliente(ID)

                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                tablaClientes = clientes.CargarDatos()
                DataGridView1.DataSource = tablaClientes
            Else
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Public Class Productos
    Private tablaProductos As DataTable
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
            DataGridView1.ReadOnly = True
            DataGridView1.AllowUserToAddRows = False
            Dim productos As New ClassProductos()
            tablaProductos = productos.CargarDatos()
            DataGridView1.DataSource = tablaProductos
            ComboBoxOrdenar.Items.Clear()
            ComboBoxOrdenar.Items.Add("Nombre (A-Z)")
            ComboBoxOrdenar.Items.Add("Nombre (Z-A)")
            ComboBoxOrdenar.Items.Add("Precio (Mayor a Menor)")
            ComboBoxOrdenar.Items.Add("Precio (Menor a Mayor)")
            ComboBoxOrdenar.SelectedIndex = 0
            LlenarCategorias()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBoxCliente_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged
        Try
            Dim textoFiltro As String = TextBoxNombre.Text.ToLower()
            Dim vista As New DataView(tablaProductos)

            vista.RowFilter = $"Nombre LIKE '%{textoFiltro}%'"

            DataGridView1.DataSource = vista
        Catch ex As Exception
            MessageBox.Show("Error al filtrar datos: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Dim agregarProductosForm As New AgregarProducto()
            agregarProductosForm.ShowDialog()
            Dim productos As New ClassProductos()
            tablaProductos = productos.CargarDatos()
            DataGridView1.DataSource = tablaProductos
        Catch ex As Exception
            MessageBox.Show("Error al agregar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LlenarCategorias()
        Try
            Dim categorias = tablaProductos.AsEnumerable().
                Select(Function(row) row.Field(Of String)("Categoria")).Distinct()

            ComboBoxCategorias.Items.Clear()
            ComboBoxCategorias.Items.Add("Categorías")
            ComboBoxCategorias.Items.AddRange(categorias.ToArray())
            ComboBoxCategorias.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error al cargar las categorías: " & ex.Message)
        End Try
    End Sub
    Private Sub AplicarFiltro()
        Try
            Dim textoFiltro As String = TextBoxNombre.Text.ToLower()
            Dim categoriaFiltro As String = If(ComboBoxCategorias.SelectedItem IsNot Nothing, ComboBoxCategorias.SelectedItem.ToString(), "Categorías")
            Dim vista As New DataView(tablaProductos)
            Dim filtro As String = ""

            If categoriaFiltro <> "Categorías" Then
                filtro = $"Categoria = '{categoriaFiltro}'"
            End If

            If Not String.IsNullOrEmpty(textoFiltro) Then
                If Not String.IsNullOrEmpty(filtro) Then
                    filtro &= " AND "
                End If
                filtro &= $"Nombre LIKE '%{textoFiltro}%'"
            End If

            vista.RowFilter = filtro

            Select Case ComboBoxOrdenar.SelectedItem.ToString()
                Case "Nombre (A-Z)"
                    vista.Sort = "Nombre ASC"
                Case "Nombre (Z-A)"
                    vista.Sort = "Nombre DESC"
                Case "Precio (Mayor a Menor)"
                    vista.Sort = "Precio DESC"
                Case "Precio (Menor a Mayor)"
                    vista.Sort = "Precio ASC"
            End Select

            DataGridView1.DataSource = vista
        Catch ex As Exception
            MessageBox.Show("Error al aplicar el filtro: " & ex.Message)
        End Try
    End Sub
    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged
        AplicarFiltro()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorias.SelectedIndexChanged
        AplicarFiltro()
    End Sub

    Private Sub ComboBoxOrdenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOrdenar.SelectedIndexChanged
        AplicarFiltro()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmacion = DialogResult.Yes Then
                Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim ID As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)
                Dim productos As New ClassProductos()
                productos.EliminarProducto(ID)

                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tablaProductos = productos.CargarDatos()
                DataGridView1.DataSource = tablaProductos
            Else
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim id As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)
                Dim modificarFormulario As New ModificarProducto(id)
                modificarFormulario.ShowDialog()
                Dim productos As New ClassProductos()
                tablaProductos = productos.CargarDatos()
                DataGridView1.DataSource = tablaProductos
            Else
                Dim modificarFormulario As New ModificarProducto()
                Dim productos As New ClassProductos()
                tablaProductos = Productos.CargarDatos()
                DataGridView1.DataSource = tablaProductos
                modificarFormulario.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir el formulario de modificación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

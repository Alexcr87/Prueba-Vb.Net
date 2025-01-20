Public Class Productos
    Private tablaProductos As List(Of Producto)
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
            DataGridView1.ReadOnly = True
            DataGridView1.AllowUserToAddRows = False
            Dim productos As New ClassProductos()
            tablaProductos = productos.CargarDatos()
            LlenarCategorias()
            LlenarComboBoxOrdenar()
            Dim table As New DataTable()
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("Nombre", GetType(String))
            table.Columns.Add("Precio", GetType(Decimal))
            table.Columns.Add("Categoria", GetType(String))

            For Each producto In tablaProductos
                table.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Categoria)
            Next

            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged
        Try
            AplicarFiltro()
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
            Dim table As New DataTable()
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("Nombre", GetType(String))
            table.Columns.Add("Precio", GetType(Decimal))
            table.Columns.Add("Categoria", GetType(String))

            For Each producto In tablaProductos
                table.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Categoria)
            Next

            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al agregar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarCategorias()
        Try
            Dim categorias = tablaProductos.Select(Function(p) p.Categoria).Distinct()

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

            Dim productosFiltrados = tablaProductos.Where(Function(p) p.Nombre.ToLower().Contains(textoFiltro) _
                                                      And (categoriaFiltro = "Categorías" Or p.Categoria = categoriaFiltro)).ToList()

            Select Case ComboBoxOrdenar.SelectedItem?.ToString()
                Case "Nombre (A-Z)"
                    productosFiltrados = productosFiltrados.OrderBy(Function(p) p.Nombre).ToList()
                Case "Nombre (Z-A)"
                    productosFiltrados = productosFiltrados.OrderByDescending(Function(p) p.Nombre).ToList()
            End Select
            Dim table As New DataTable()
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("Nombre", GetType(String))
            table.Columns.Add("Precio", GetType(Decimal))
            table.Columns.Add("Categoria", GetType(String))

            For Each producto In productosFiltrados
                table.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Categoria)
            Next

            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al aplicar el filtro: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorias.SelectedIndexChanged
        AplicarFiltro()
    End Sub

    Private Sub ComboBoxOrdenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOrdenar.SelectedIndexChanged
        AplicarFiltro()
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
                Dim table As New DataTable()
                table.Columns.Add("ID", GetType(Integer))
                table.Columns.Add("Nombre", GetType(String))
                table.Columns.Add("Precio", GetType(Decimal))
                table.Columns.Add("Categoria", GetType(String))

                For Each producto In tablaProductos
                    table.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Categoria)
                Next

                DataGridView1.DataSource = table
            Else
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LlenarComboBoxOrdenar()
        ComboBoxOrdenar.Items.Clear()
        ComboBoxOrdenar.Items.Add("Nombre (A-Z)")
        ComboBoxOrdenar.Items.Add("Nombre (Z-A)")
        ComboBoxOrdenar.SelectedIndex = 0
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
                Dim table As New DataTable()
                table.Columns.Add("ID", GetType(Integer))
                table.Columns.Add("Nombre", GetType(String))
                table.Columns.Add("Precio", GetType(Decimal))
                table.Columns.Add("Categoria", GetType(String))

                For Each producto In tablaProductos
                    table.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Categoria)
                Next

                DataGridView1.DataSource = table
            Else
                MessageBox.Show("Por favor, seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir el formulario de modificación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

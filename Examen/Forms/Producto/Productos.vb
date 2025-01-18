Public Class Productos
    Private tablaProductos As DataTable
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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
        AgregarProducto.Show()
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
End Class

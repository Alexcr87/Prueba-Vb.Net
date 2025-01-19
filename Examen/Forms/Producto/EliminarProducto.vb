Public Class EliminarProducto
    Private Sub EliminarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim productos As New ClassProductos()
            Dim listaProductos As List(Of Producto) = productos.CargarDatos()
            Dim tablaProductos As DataTable = ConvertirADataTable(listaProductos)

            DataGridView1.DataSource = tablaProductos
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ConvertirADataTable(productos As List(Of Producto)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))
        dt.Columns.Add("Precio", GetType(Integer))
        dt.Columns.Add("Categoria", GetType(String))
        For Each producto As Producto In productos
            dt.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Categoria)
        Next

        Return dt
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 AndAlso Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(0).Value) Then
                TextBoxBuscar.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
                Label1.Text = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value).ToString()
            Else
                MessageBox.Show("La celda seleccionada no contiene datos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            If String.IsNullOrEmpty(Label1.Text) Then
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmacion = DialogResult.Yes Then
                Dim productos As New ClassProductos()
                Dim ID As Integer = Convert.ToInt32(Label1.Text)
                productos.EliminarProducto(ID)

                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxBuscar.Clear()
                Label1.Text = String.Empty
                Dim listaProductos As List(Of Producto) = productos.CargarDatos()
                Dim tablaProductos As DataTable = ConvertirADataTable(listaProductos)
                DataGridView1.DataSource = tablaProductos
            Else
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

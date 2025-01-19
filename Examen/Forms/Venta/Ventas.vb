Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridViewCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewProductos.MultiSelect = False
            DataGridViewProductos.ReadOnly = True
            DataGridViewProductos.AllowUserToAddRows = False
            DataGridViewCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewCarrito.MultiSelect = False
            DataGridViewCarrito.ReadOnly = True
            DataGridViewCarrito.AllowUserToAddRows = False
            Dim clientes As New ClassClientes()
            ComboBoxClientes.DataSource = clientes.CargarDatos()
            ComboBoxClientes.DisplayMember = "Nombre"
            ComboBoxClientes.ValueMember = "ID"

            Dim productos As New ClassProductos()
            DataGridViewProductos.DataSource = productos.CargarDatos()

            ConfigurarCarrito()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarCarrito()
        Dim carrito As New DataTable()
        carrito.Columns.Add("ID", GetType(Integer))
        carrito.Columns.Add("Nombre", GetType(String))
        carrito.Columns.Add("Cantidad", GetType(Integer))
        carrito.Columns.Add("Precio Unitario", GetType(Decimal))
        carrito.Columns.Add("Precio Total", GetType(Decimal))
        DataGridViewCarrito.DataSource = carrito
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxCantidad.Text) OrElse Convert.ToInt32(TextBoxCantidad.Text) <= 0 Then
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If DataGridViewProductos.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un producto para agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim fila As DataGridViewRow = DataGridViewProductos.SelectedRows(0)
            Dim idProducto As Integer = Convert.ToInt32(fila.Cells("ID").Value)
            Dim nombreProducto As String = fila.Cells("Nombre").Value.ToString()
            Dim precioUnitario As Decimal = Convert.ToDecimal(fila.Cells("Precio").Value)
            Dim cantidad As Integer = Convert.ToInt32(TextBoxCantidad.Text)
            Dim precioTotal As Decimal = precioUnitario * cantidad
            Dim carrito As DataTable = TryCast(DataGridViewCarrito.DataSource, DataTable)
            carrito.Rows.Add(idProducto, nombreProducto, cantidad, precioUnitario, precioTotal)

            TextBoxCantidad.Clear()
            ActualizarTotalCarrito()
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            If DataGridViewCarrito.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim fila As DataGridViewRow = DataGridViewCarrito.SelectedRows(0)
            DataGridViewCarrito.Rows.Remove(fila)
            ActualizarTotalCarrito()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el producto: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonFinalizar_Click(sender As Object, e As EventArgs) Handles ButtonFinalizar.Click
        Try
            If ComboBoxClientes.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim carrito As DataTable = TryCast(DataGridViewCarrito.DataSource, DataTable)
            If carrito Is Nothing OrElse carrito.Rows.Count = 0 Then
                MessageBox.Show("No hay productos en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim venta As New Venta() With {
                .Fecha = DateTime.Now,
                .IdCliente = Convert.ToInt32(ComboBoxClientes.SelectedValue),
                .Detalles = New List(Of VentaDetalle)()
            }

            For Each fila As DataRow In carrito.Rows
                venta.Detalles.Add(New VentaDetalle() With {
                    .IdProducto = Convert.ToInt32(fila("ID")),
                    .Cantidad = Convert.ToInt32(fila("Cantidad")),
                    .PrecioUnitario = Convert.ToDecimal(fila("Precio Unitario")),
                    .PrecioTotal = Convert.ToDecimal(fila("Precio Total"))
                })
            Next

            Dim classVentas As New ClassVentas()
            classVentas.AgregarVenta(venta)

            MessageBox.Show("Venta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ConfigurarCarrito()
        Catch ex As Exception
            MessageBox.Show("Error al finalizar la venta: " & ex.Message)
        End Try
    End Sub
    Private Sub ActualizarTotalCarrito()
        Dim total As Decimal = 0
        For Each fila As DataGridViewRow In DataGridViewCarrito.Rows
            If Not fila.IsNewRow Then
                total += Convert.ToDecimal(fila.Cells("Precio Total").Value)
            End If
        Next
        LabelCarrito.Text = "Total: $" & total.ToString("N2")
    End Sub




End Class

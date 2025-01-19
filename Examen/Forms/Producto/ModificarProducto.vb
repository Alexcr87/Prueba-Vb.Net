Public Class ModificarProducto
    Private productoID As Integer?

    Public Sub New(Optional ByVal id As Integer? = Nothing)
        InitializeComponent()
        productoID = id
    End Sub


    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxNombre.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxPrecio.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxCategoria.Text) Then
                MessageBox.Show("Por favor, complete todos los campos antes de modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim id As Integer = productoID.Value
            Dim nombre As String = TextBoxNombre.Text
            Dim precio As Decimal
            Dim categoria As String = TextBoxCategoria.Text
            Dim precioTexto As String = TextBoxPrecio.Text.Trim()
            If precioTexto.Contains(",") Then
                precioTexto = precioTexto.Replace(",", ".")
            End If

            If Not Decimal.TryParse(precioTexto, Globalization.NumberStyles.AllowDecimalPoint, Globalization.CultureInfo.InvariantCulture, precio) Then
                MessageBox.Show("Por favor, ingrese un precio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea modificar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmacion = DialogResult.Yes Then
                Dim productos As New ClassProductos()
                productos.ModificarProducto(id, nombre, precio, categoria)
                MessageBox.Show("Producto " & nombre & " modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If productoID.HasValue Then
                Dim productos As New ClassProductos()
                Dim productoEncontrado As Producto = productos.BuscarProductoPorID(productoID.Value)

                If productoEncontrado IsNot Nothing Then
                    TextBoxNombre.Text = productoEncontrado.Nombre
                    TextBoxPrecio.Text = productoEncontrado.Precio.ToString()
                    TextBoxCategoria.Text = productoEncontrado.Categoria
                    ControlVisibilityHelper.HacerVisibleControles(Me)
                    TextBoxNombre.Focus()
                Else
                    MessageBox.Show("No se encontró un producto con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ControlVisibilityHelper.HacerInvisibleControles(Me)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

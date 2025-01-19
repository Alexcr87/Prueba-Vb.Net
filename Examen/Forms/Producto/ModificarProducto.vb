Public Class ModificarProducto
    Private productoID As Integer?

    Public Sub New(Optional ByVal id As Integer? = Nothing)
        InitializeComponent()
        productoID = id
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

            Dim productos As New ClassProductos()

            Dim productoEncontrado As DataRow = productos.BuscarProductoPorID(id)

            If productoEncontrado IsNot Nothing Then
                TextBoxNombre.Text = productoEncontrado("Nombre").ToString()
                TextBoxPrecio.Text = productoEncontrado("Precio").ToString()
                TextBoxCategoria.Text = productoEncontrado("Categoria").ToString()

                ControlVisibilityHelper.HacerVisibleControles(Me)
                TextBoxBuscar.Enabled = False
            Else
                MessageBox.Show("No se encontró un producto con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxNombre.Text) OrElse
               String.IsNullOrWhiteSpace(TextBoxPrecio.Text) OrElse
               String.IsNullOrWhiteSpace(TextBoxCategoria.Text) Then
                MessageBox.Show("Por favor, complete todos los campos antes de modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim id As Integer = Convert.ToInt32(TextBoxBuscar.Text)
            Dim nombre As String = TextBoxNombre.Text
            Dim precio As Integer
            Dim categoria As String = TextBoxCategoria.Text

            If Not Integer.TryParse(TextBoxPrecio.Text, precio) Then
                MessageBox.Show("Por favor, ingrese precio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea modificar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmacion = DialogResult.Yes Then
                Dim productos As New ClassProductos()
                productos.ModificarProducto(id, nombre, precio, categoria)
                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Dim productoEncontrado As DataRow = productos.BuscarProductoPorID(productoID.Value)

                If productoEncontrado IsNot Nothing Then
                    TextBoxBuscar.Text = productoID.Value.ToString()
                    TextBoxNombre.Text = productoEncontrado("Nombre").ToString()
                    TextBoxPrecio.Text = productoEncontrado("Precio").ToString()
                    TextBoxCategoria.Text = productoEncontrado("Categoria").ToString()

                    ControlVisibilityHelper.HacerVisibleControles(Me)
                    TextBoxBuscar.Enabled = False
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
Public Class FormPrincipal
    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        Clientes.Show()
    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        Productos.Show()
    End Sub

    Private Sub ButtonVentas_Click(sender As Object, e As EventArgs) Handles ButtonVentas.Click
        Ventas.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        AgregarCliente.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarCliente.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarCliente.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        AgregarProducto.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        ModificarProducto.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        EliminarProducto.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmacion = DialogResult.Yes Then
            Application.Exit()
        Else
            MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
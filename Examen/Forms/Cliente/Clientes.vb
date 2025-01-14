

Imports System.Data


Public Class Clientes

    ' Llamar a CargarDatos al cargar el formulario
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Instancia de la clase ClassClientes
            Dim clientes As New ClassClientes()

            ' Obtener los datos y asignarlos al DataGridView
            Dim tablaClientes As DataTable = clientes.CargarDatos()
            DataGridView1.DataSource = tablaClientes
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class

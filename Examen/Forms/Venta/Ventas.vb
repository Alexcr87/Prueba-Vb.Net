


Public Class Ventas
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim fechaInicio As DateTime = DateTimePickerDesde.Value.Date
        Dim fechaFin As DateTime = DateTimePickerHasta.Value.Date
        Dim clienteSeleccionado As Integer = Convert.ToInt32(ComboBoxCliente.SelectedValue)

        If Not CheckBoxExacta.Checked AndAlso fechaInicio > fechaFin Then
            MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim ventas As New ClassVentas()
            Dim listaVentas As List(Of Venta)

            If CheckBoxExacta.Checked Then
                fechaInicio = fechaInicio.Date
                fechaFin = fechaInicio.AddDays(1).AddSeconds(-1)
                listaVentas = ventas.BuscarVentasPorClienteYFechas(clienteSeleccionado, fechaInicio, fechaFin)
            Else
                If clienteSeleccionado = 0 Then
                    listaVentas = ventas.BuscarVentasEntreFechas(fechaInicio, fechaFin)
                Else
                    listaVentas = ventas.BuscarVentasPorClienteYFechas(clienteSeleccionado, fechaInicio, fechaFin)
                End If
            End If

            Dim tablaVentas As DataTable = ConvertirListaADataTable(listaVentas)
            DataGridView1.DataSource = tablaVentas

        Catch ex As Exception
            MessageBox.Show("Error al buscar las ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
            DataGridView1.ReadOnly = True
            DataGridView1.AllowUserToAddRows = False
            Dim clientes As New ClassClientes()
            Dim listaClientes As List(Of Cliente) = clientes.CargarDatos()
            Dim tablaClientes As DataTable = ConvertirListaADataTable(listaClientes)
            Dim filaTodos As DataRow = tablaClientes.NewRow()
            filaTodos("ID") = 0
            filaTodos("Cliente") = "Todos"
            tablaClientes.Rows.InsertAt(filaTodos, 0)
            ComboBoxCliente.DataSource = tablaClientes
            ComboBoxCliente.DisplayMember = "Cliente"
            ComboBoxCliente.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Function ConvertirListaADataTable(Of T)(lista As List(Of T)) As DataTable
        Dim tabla As New DataTable()
        Dim propiedades = GetType(T).GetProperties()
        For Each prop In propiedades
            tabla.Columns.Add(prop.Name, prop.PropertyType)
        Next

        For Each item In lista
            Dim fila = tabla.NewRow()
            For Each prop In propiedades
                fila(prop.Name) = prop.GetValue(item, Nothing)
            Next
            tabla.Rows.Add(fila)
        Next

        Return tabla
    End Function

    Private Sub CheckBoxExacta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxExacta.CheckedChanged
        If CheckBoxExacta.Checked Then
            DateTimePickerHasta.Enabled = False
        Else
            DateTimePickerHasta.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim idVenta As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("Id").Value)
            MostrarDetallesVenta(idVenta)
        End If
    End Sub

    Private Sub MostrarDetallesVenta(idVenta As Integer)
        Try

            Dim ventas As New ClassVentas()
            Dim detallesVenta As List(Of Dictionary(Of String, Object)) = ventas.ObtenerDetallesVenta(idVenta)
            DataGridViewDetalle.DataSource = ConvertirListaADataTable(detallesVenta)
            LabelFecha.Text = "Fecha de Venta: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            LabelEstadoPago.Text = "Estado de Pago: " & "Pagado"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles de la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonReporte_Click(sender As Object, e As EventArgs) Handles ButtonReporte.Click
        Dim fechaInicio As DateTime = DateTimePickerDesde.Value.Date
        Dim fechaFin As DateTime = DateTimePickerHasta.Value.Date

        Dim ventas As New ClassVentas()
        Dim listaVentas As List(Of Venta)

        If ComboBoxCliente.SelectedValue = 0 Then
            listaVentas = ventas.BuscarVentasEntreFechas(fechaInicio, fechaFin)
        Else
            listaVentas = ventas.BuscarVentasPorClienteYFechas(ComboBoxCliente.SelectedValue, fechaInicio, fechaFin)
        End If

        Dim excelApp As New Microsoft.Office.Interop.Excel.Application
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = workbook.Sheets(1)

        worksheet.Cells(1, 1).Value = "ID Venta"
        worksheet.Cells(1, 2).Value = "Cliente"
        worksheet.Cells(1, 3).Value = "Fecha"
        worksheet.Cells(1, 4).Value = "Total"

        Dim row As Integer = 2
        For Each venta As Venta In listaVentas
            worksheet.Cells(row, 1).Value = venta.Id
            worksheet.Cells(row, 2).Value = venta.IdCliente
            worksheet.Cells(row, 3).Value = venta.Fecha.ToString("dd/MM/yyyy")
            worksheet.Cells(row, 4).Value = venta.Total
            row += 1
        Next

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
        saveFileDialog.Title = "Guardar Reporte de Ventas"
        saveFileDialog.FileName = "Reporte_Ventas_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".xlsx"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            workbook.SaveAs(filePath)
            workbook.Close()
            excelApp.Quit()
            MessageBox.Show("Reporte de ventas generado exitosamente: " & filePath)
        Else
            MessageBox.Show("No se seleccionó una ubicación para guardar el archivo.")
        End If
    End Sub
End Class

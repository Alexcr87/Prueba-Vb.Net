Public Class Venta
    Public Property Id As Integer
    Public Property IdCliente As Integer
    Public Property Fecha As DateTime
    Public Property Total As Decimal
    Public Property Detalles As List(Of VentaDetalle)

    Public Sub New()
        Detalles = New List(Of VentaDetalle)()
    End Sub
End Class

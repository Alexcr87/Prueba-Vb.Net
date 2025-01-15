Public Class Cliente
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Telefono As Integer
    Public Property Correo As String

    ' Constructor para inicializar un cliente
    Public Sub New(id As Integer, nombre As String, telefono As Integer, correo As String)
        Me.ID = id
        Me.Nombre = nombre
        Me.Telefono = telefono
        Me.Correo = correo

        ' Validaciones
        If Not IsValidTelefono(telefono) Then
            Throw New ArgumentException("El teléfono no es válido")
        End If
        If Not IsValidCorreo(correo) Then
            Throw New ArgumentException("El correo no es válido")
        End If
    End Sub

    ' Constructor vacío para crear objetos sin datos iniciales
    Public Sub New()
    End Sub

    ' Método para validar el teléfono
    Private Function IsValidTelefono(telefono As Integer) As Boolean
        ' Validar formato del teléfono (puedes poner una expresión regular o lógica adicional)
        Return telefono.ToString().Length >= 10 ' Ejemplo: teléfono debe tener al menos 10 dígitos
    End Function

    ' Método para validar el correo
    Private Function IsValidCorreo(correo As String) As Boolean
        ' Validar formato del correo
        Return correo.Contains("@") AndAlso correo.Contains(".")
    End Function
End Class

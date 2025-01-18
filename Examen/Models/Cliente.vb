Public Class Cliente
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Telefono As Integer
    Public Property Correo As String

    Public Sub New(id As Integer, nombre As String, telefono As Integer, correo As String)
        Me.ID = id
        Me.Nombre = nombre
        Me.Telefono = telefono
        Me.Correo = correo

        If Not IsValidTelefono(telefono) Then
            Throw New ArgumentException("El teléfono no es válido")
        End If
        If Not IsValidCorreo(correo) Then
            Throw New ArgumentException("El correo no es válido")
        End If
    End Sub

    Public Sub New()
    End Sub


    Private Function IsValidTelefono(telefono As Integer) As Boolean
        Return telefono.ToString().Length >= 10
    End Function

    Private Function IsValidCorreo(correo As String) As Boolean
        Return correo.Contains("@") AndAlso correo.Contains(".")
    End Function
End Class

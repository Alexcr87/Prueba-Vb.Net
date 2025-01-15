Public Class TextBoxHelper
    Public Shared Sub LimpiarTextBoxes(formulario As Form)
        For Each control As Control In formulario.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            ElseIf control.HasChildren Then
                LimpiarTextBoxes(control)
            End If
        Next
    End Sub
End Class
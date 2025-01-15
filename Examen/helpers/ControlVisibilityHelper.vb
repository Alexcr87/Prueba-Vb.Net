Public Class ControlVisibilityHelper

    Public Shared Sub HacerInvisibleControles(formulario As Form)
        For Each control As Control In formulario.Controls
            If TypeOf control Is TextBox AndAlso control.Name <> "TextBoxBuscar" Then
                control.Visible = False
            ElseIf TypeOf control Is Button AndAlso control.Name <> "ButtonBuscar" Then
                control.Visible = False
            ElseIf TypeOf control Is Label Then
                control.Visible = False
            ElseIf control.HasChildren Then
                HacerInvisibleControles(control)
            End If
        Next
    End Sub

    Public Shared Sub HacerVisibleControles(formulario As Form)
        For Each control As Control In formulario.Controls
            If TypeOf control Is TextBox AndAlso control.Name <> "TextBoxBuscar" Then
                control.Visible = True
            ElseIf TypeOf control Is Button AndAlso control.Name <> "ButtonBuscar" Then
                control.Visible = True
            ElseIf TypeOf control Is Label Then
                control.Visible = True
            ElseIf control.HasChildren Then
                HacerVisibleControles(control)
            End If
        Next
    End Sub

End Class

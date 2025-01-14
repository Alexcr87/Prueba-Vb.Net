<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelCategoria = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(220, 86)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(58, 17)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Location = New System.Drawing.Point(220, 142)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(48, 17)
        Me.LabelPrecio.TabIndex = 1
        Me.LabelPrecio.Text = "Precio"
        '
        'LabelCategoria
        '
        Me.LabelCategoria.AutoSize = True
        Me.LabelCategoria.Location = New System.Drawing.Point(220, 199)
        Me.LabelCategoria.Name = "LabelCategoria"
        Me.LabelCategoria.Size = New System.Drawing.Size(69, 17)
        Me.LabelCategoria.TabIndex = 2
        Me.LabelCategoria.Text = "Categoria"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(309, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(239, 253)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregar.TabIndex = 4
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(309, 142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(309, 199)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 6
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(334, 253)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 7
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(444, 253)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 8
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelCategoria)
        Me.Controls.Add(Me.LabelPrecio)
        Me.Controls.Add(Me.LabelNombre)
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents LabelCategoria As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
End Class

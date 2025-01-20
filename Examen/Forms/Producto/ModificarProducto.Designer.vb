<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProducto
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
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(172, 213)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(85, 31)
        Me.ButtonCancelar.TabIndex = 35
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        Me.ButtonCancelar.Visible = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(184, 18)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(85, 31)
        Me.ButtonBuscar.TabIndex = 34
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(29, 22)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(149, 22)
        Me.TextBoxBuscar.TabIndex = 33
        Me.TextBoxBuscar.Text = "Ingrese ID del Producto"
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(30, 213)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(85, 31)
        Me.ButtonModificar.TabIndex = 32
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        Me.ButtonModificar.Visible = False
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(144, 162)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCategoria.TabIndex = 31
        Me.TextBoxCategoria.Visible = False
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(144, 120)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPrecio.TabIndex = 30
        Me.TextBoxPrecio.Visible = False
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(144, 78)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxNombre.TabIndex = 29
        Me.TextBoxNombre.Visible = False
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Location = New System.Drawing.Point(46, 162)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(69, 17)
        Me.LabelCorreo.TabIndex = 28
        Me.LabelCorreo.Text = "Categoria"
        Me.LabelCorreo.Visible = False
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Location = New System.Drawing.Point(46, 120)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(48, 17)
        Me.LabelTelefono.TabIndex = 27
        Me.LabelTelefono.Text = "Precio"
        Me.LabelTelefono.Visible = False
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Location = New System.Drawing.Point(46, 78)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(58, 17)
        Me.LabelCliente.TabIndex = 26
        Me.LabelCliente.Text = "Nombre"
        Me.LabelCliente.Visible = False
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 278)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.TextBoxCategoria)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.LabelCliente)
        Me.Name = "ModificarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents TextBoxCategoria As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelCliente As Label
End Class

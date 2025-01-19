<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.ComboBoxClientes = New System.Windows.Forms.ComboBox()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCarrito = New System.Windows.Forms.DataGridView()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.LabelCarrito = New System.Windows.Forms.Label()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonFinalizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxClientes
        '
        Me.ComboBoxClientes.FormattingEnabled = True
        Me.ComboBoxClientes.Location = New System.Drawing.Point(85, 41)
        Me.ComboBoxClientes.Name = "ComboBoxClientes"
        Me.ComboBoxClientes.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxClientes.TabIndex = 0
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(85, 88)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.RowHeadersWidth = 51
        Me.DataGridViewProductos.RowTemplate.Height = 24
        Me.DataGridViewProductos.Size = New System.Drawing.Size(240, 150)
        Me.DataGridViewProductos.TabIndex = 1
        '
        'DataGridViewCarrito
        '
        Me.DataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCarrito.Location = New System.Drawing.Point(497, 88)
        Me.DataGridViewCarrito.Name = "DataGridViewCarrito"
        Me.DataGridViewCarrito.RowHeadersWidth = 51
        Me.DataGridViewCarrito.RowTemplate.Height = 24
        Me.DataGridViewCarrito.Size = New System.Drawing.Size(240, 150)
        Me.DataGridViewCarrito.TabIndex = 2
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(271, 43)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCantidad.TabIndex = 3
        '
        'LabelCarrito
        '
        Me.LabelCarrito.AutoSize = True
        Me.LabelCarrito.Location = New System.Drawing.Point(378, 252)
        Me.LabelCarrito.Name = "LabelCarrito"
        Me.LabelCarrito.Size = New System.Drawing.Size(96, 17)
        Me.LabelCarrito.TabIndex = 4
        Me.LabelCarrito.Text = "Total: $ 00.00"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(147, 299)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregar.TabIndex = 5
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(296, 299)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 6
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonFinalizar
        '
        Me.ButtonFinalizar.Location = New System.Drawing.Point(441, 299)
        Me.ButtonFinalizar.Name = "ButtonFinalizar"
        Me.ButtonFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFinalizar.TabIndex = 7
        Me.ButtonFinalizar.Text = "Finalizar"
        Me.ButtonFinalizar.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonFinalizar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.LabelCarrito)
        Me.Controls.Add(Me.TextBoxCantidad)
        Me.Controls.Add(Me.DataGridViewCarrito)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Controls.Add(Me.ComboBoxClientes)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxClientes As ComboBox
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents DataGridViewCarrito As DataGridView
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents LabelCarrito As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonFinalizar As Button
End Class

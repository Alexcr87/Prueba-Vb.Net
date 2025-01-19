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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxClientes
        '
        Me.ComboBoxClientes.FormattingEnabled = True
        Me.ComboBoxClientes.Location = New System.Drawing.Point(166, 41)
        Me.ComboBoxClientes.Name = "ComboBoxClientes"
        Me.ComboBoxClientes.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxClientes.TabIndex = 0
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(110, 78)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.RowHeadersVisible = False
        Me.DataGridViewProductos.RowHeadersWidth = 51
        Me.DataGridViewProductos.RowTemplate.Height = 24
        Me.DataGridViewProductos.Size = New System.Drawing.Size(722, 175)
        Me.DataGridViewProductos.TabIndex = 1
        '
        'DataGridViewCarrito
        '
        Me.DataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCarrito.Location = New System.Drawing.Point(110, 289)
        Me.DataGridViewCarrito.Name = "DataGridViewCarrito"
        Me.DataGridViewCarrito.RowHeadersVisible = False
        Me.DataGridViewCarrito.RowHeadersWidth = 51
        Me.DataGridViewCarrito.RowTemplate.Height = 24
        Me.DataGridViewCarrito.Size = New System.Drawing.Size(722, 163)
        Me.DataGridViewCarrito.TabIndex = 2
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(866, 135)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCantidad.TabIndex = 3
        '
        'LabelCarrito
        '
        Me.LabelCarrito.AutoSize = True
        Me.LabelCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCarrito.Location = New System.Drawing.Point(403, 485)
        Me.LabelCarrito.Name = "LabelCarrito"
        Me.LabelCarrito.Size = New System.Drawing.Size(146, 25)
        Me.LabelCarrito.TabIndex = 4
        Me.LabelCarrito.Text = "Total: $ 00.00"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(866, 176)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonAgregar.TabIndex = 5
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(866, 323)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonEliminar.TabIndex = 6
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonFinalizar
        '
        Me.ButtonFinalizar.Location = New System.Drawing.Point(866, 393)
        Me.ButtonFinalizar.Name = "ButtonFinalizar"
        Me.ButtonFinalizar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonFinalizar.TabIndex = 7
        Me.ButtonFinalizar.Text = "Finalizar"
        Me.ButtonFinalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nº de Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(881, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cantidad:"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 573)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

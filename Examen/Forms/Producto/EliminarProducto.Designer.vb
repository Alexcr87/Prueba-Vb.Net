<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarProducto
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
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(319, 323)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 7
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(121, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(559, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(451, 105)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 5
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(207, 105)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(205, 22)
        Me.TextBoxBuscar.TabIndex = 4
        Me.TextBoxBuscar.Text = "Ingrese un Nombre"
        '
        'EliminarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Name = "EliminarProducto"
        Me.Text = "Eliminar Producto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxBuscar As TextBox
End Class

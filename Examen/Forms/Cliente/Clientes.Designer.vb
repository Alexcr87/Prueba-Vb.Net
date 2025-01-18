<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.ComboBoxOrdenar = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCorreo = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(691, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(120, 415)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregar.TabIndex = 2
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(344, 415)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 3
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(580, 415)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 4
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.Location = New System.Drawing.Point(120, 84)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(147, 22)
        Me.TextBoxCliente.TabIndex = 5
        '
        'ComboBoxOrdenar
        '
        Me.ComboBoxOrdenar.FormattingEnabled = True
        Me.ComboBoxOrdenar.Location = New System.Drawing.Point(390, 84)
        Me.ComboBoxOrdenar.Name = "ComboBoxOrdenar"
        Me.ComboBoxOrdenar.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxOrdenar.TabIndex = 11
        '
        'ComboBoxCorreo
        '
        Me.ComboBoxCorreo.FormattingEnabled = True
        Me.ComboBoxCorreo.Location = New System.Drawing.Point(534, 82)
        Me.ComboBoxCorreo.Name = "ComboBoxCorreo"
        Me.ComboBoxCorreo.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxCorreo.TabIndex = 12
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBoxCorreo)
        Me.Controls.Add(Me.ComboBoxOrdenar)
        Me.Controls.Add(Me.TextBoxCliente)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents ComboBoxOrdenar As ComboBox
    Friend WithEvents ComboBoxCorreo As ComboBox
End Class

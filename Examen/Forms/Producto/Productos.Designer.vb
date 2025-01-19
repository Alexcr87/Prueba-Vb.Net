<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ComboBoxCategorias = New System.Windows.Forms.ComboBox()
        Me.ComboBoxOrdenar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Listado de Productos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(55, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(691, 280)
        Me.DataGridView1.TabIndex = 2
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(590, 415)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 7
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(354, 415)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 6
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(130, 415)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregar.TabIndex = 5
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(245, 86)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(147, 22)
        Me.TextBoxNombre.TabIndex = 8
        '
        'ComboBoxCategorias
        '
        Me.ComboBoxCategorias.FormattingEnabled = True
        Me.ComboBoxCategorias.Location = New System.Drawing.Point(625, 87)
        Me.ComboBoxCategorias.Name = "ComboBoxCategorias"
        Me.ComboBoxCategorias.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxCategorias.TabIndex = 9
        '
        'ComboBoxOrdenar
        '
        Me.ComboBoxOrdenar.FormattingEnabled = True
        Me.ComboBoxOrdenar.Location = New System.Drawing.Point(498, 87)
        Me.ComboBoxOrdenar.Name = "ComboBoxOrdenar"
        Me.ComboBoxOrdenar.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxOrdenar.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Busqueda por nombre"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxOrdenar)
        Me.Controls.Add(Me.ComboBoxCategorias)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ComboBoxCategorias As ComboBox
    Friend WithEvents ComboBoxOrdenar As ComboBox
    Friend WithEvents Label2 As Label
End Class

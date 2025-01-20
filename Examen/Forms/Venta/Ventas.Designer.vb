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
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.LabelDesde = New System.Windows.Forms.Label()
        Me.LabelHasta = New System.Windows.Forms.Label()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxExacta = New System.Windows.Forms.CheckBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewDetalle = New System.Windows.Forms.DataGridView()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelEstadoPago = New System.Windows.Forms.Label()
        Me.ButtonReporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(533, 26)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxCliente.TabIndex = 0
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Location = New System.Drawing.Point(400, 29)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(51, 17)
        Me.LabelCliente.TabIndex = 1
        Me.LabelCliente.Text = "Cliente"
        '
        'LabelDesde
        '
        Me.LabelDesde.AutoSize = True
        Me.LabelDesde.Location = New System.Drawing.Point(400, 70)
        Me.LabelDesde.Name = "LabelDesde"
        Me.LabelDesde.Size = New System.Drawing.Size(49, 17)
        Me.LabelDesde.TabIndex = 2
        Me.LabelDesde.Text = "Desde"
        '
        'LabelHasta
        '
        Me.LabelHasta.AutoSize = True
        Me.LabelHasta.Location = New System.Drawing.Point(400, 107)
        Me.LabelHasta.Name = "LabelHasta"
        Me.LabelHasta.Size = New System.Drawing.Size(45, 17)
        Me.LabelHasta.TabIndex = 3
        Me.LabelHasta.Text = "Hasta"
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(488, 70)
        Me.DateTimePickerDesde.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerDesde.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerDesde.TabIndex = 4
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(488, 107)
        Me.DateTimePickerHasta.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerHasta.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerHasta.TabIndex = 5
        '
        'CheckBoxExacta
        '
        Me.CheckBoxExacta.AutoSize = True
        Me.CheckBoxExacta.Location = New System.Drawing.Point(736, 74)
        Me.CheckBoxExacta.Name = "CheckBoxExacta"
        Me.CheckBoxExacta.Size = New System.Drawing.Size(115, 21)
        Me.CheckBoxExacta.TabIndex = 6
        Me.CheckBoxExacta.Text = "Fecha Exacta"
        Me.CheckBoxExacta.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(736, 109)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 7
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(695, 229)
        Me.DataGridView1.TabIndex = 8
        '
        'DataGridViewDetalle
        '
        Me.DataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDetalle.Location = New System.Drawing.Point(781, 163)
        Me.DataGridViewDetalle.Name = "DataGridViewDetalle"
        Me.DataGridViewDetalle.RowHeadersVisible = False
        Me.DataGridViewDetalle.RowHeadersWidth = 51
        Me.DataGridViewDetalle.RowTemplate.Height = 24
        Me.DataGridViewDetalle.Size = New System.Drawing.Size(695, 229)
        Me.DataGridViewDetalle.TabIndex = 9
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(810, 500)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(0, 17)
        Me.LabelFecha.TabIndex = 10
        '
        'LabelEstadoPago
        '
        Me.LabelEstadoPago.AutoSize = True
        Me.LabelEstadoPago.Location = New System.Drawing.Point(810, 564)
        Me.LabelEstadoPago.Name = "LabelEstadoPago"
        Me.LabelEstadoPago.Size = New System.Drawing.Size(0, 17)
        Me.LabelEstadoPago.TabIndex = 11
        '
        'ButtonReporte
        '
        Me.ButtonReporte.Location = New System.Drawing.Point(980, 52)
        Me.ButtonReporte.Name = "ButtonReporte"
        Me.ButtonReporte.Size = New System.Drawing.Size(118, 53)
        Me.ButtonReporte.TabIndex = 12
        Me.ButtonReporte.Text = "Reporte De Ventas"
        Me.ButtonReporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Listado de ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1033, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Detalle de Venta"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1499, 429)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReporte)
        Me.Controls.Add(Me.LabelEstadoPago)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.DataGridViewDetalle)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.CheckBoxExacta)
        Me.Controls.Add(Me.DateTimePickerHasta)
        Me.Controls.Add(Me.DateTimePickerDesde)
        Me.Controls.Add(Me.LabelHasta)
        Me.Controls.Add(Me.LabelDesde)
        Me.Controls.Add(Me.LabelCliente)
        Me.Controls.Add(Me.ComboBoxCliente)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents LabelCliente As Label
    Friend WithEvents LabelDesde As Label
    Friend WithEvents LabelHasta As Label
    Friend WithEvents DateTimePickerDesde As DateTimePicker
    Friend WithEvents DateTimePickerHasta As DateTimePicker
    Friend WithEvents CheckBoxExacta As CheckBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewDetalle As DataGridView
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelEstadoPago As Label
    Friend WithEvents ButtonReporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

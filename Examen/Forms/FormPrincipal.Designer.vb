<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ButtonProductos
        '
        Me.ButtonProductos.BackgroundImage = Global.Examen.My.Resources.Resources.productos
        Me.ButtonProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductos.Location = New System.Drawing.Point(670, 130)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(200, 200)
        Me.ButtonProductos.TabIndex = 3
        Me.ButtonProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonProductos.UseVisualStyleBackColor = True
        '
        'ButtonClientes
        '
        Me.ButtonClientes.BackgroundImage = Global.Examen.My.Resources.Resources.Clientes
        Me.ButtonClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientes.Location = New System.Drawing.Point(409, 130)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(200, 200)
        Me.ButtonClientes.TabIndex = 2
        Me.ButtonClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClientes.UseVisualStyleBackColor = True
        '
        'ButtonVentas
        '
        Me.ButtonVentas.BackgroundImage = CType(resources.GetObject("ButtonVentas.BackgroundImage"), System.Drawing.Image)
        Me.ButtonVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVentas.Location = New System.Drawing.Point(163, 130)
        Me.ButtonVentas.Name = "ButtonVentas"
        Me.ButtonVentas.Size = New System.Drawing.Size(200, 200)
        Me.ButtonVentas.TabIndex = 1
        Me.ButtonVentas.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 542)
        Me.Controls.Add(Me.ButtonProductos)
        Me.Controls.Add(Me.ButtonClientes)
        Me.Controls.Add(Me.ButtonVentas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonProductos As Button
End Class

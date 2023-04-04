<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgAutos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregarAuto = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dgBusqueda = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgAutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAutos
        '
        Me.dgAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAutos.Location = New System.Drawing.Point(299, 60)
        Me.dgAutos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgAutos.Name = "dgAutos"
        Me.dgAutos.RowHeadersWidth = 51
        Me.dgAutos.Size = New System.Drawing.Size(857, 201)
        Me.dgAutos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 378)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 335)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(141, 331)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(132, 22)
        Me.txtMarca.TabIndex = 3
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(141, 374)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(132, 22)
        Me.txtFecha.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(141, 428)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(133, 28)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregarAuto
        '
        Me.btnAgregarAuto.Location = New System.Drawing.Point(141, 91)
        Me.btnAgregarAuto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarAuto.Name = "btnAgregarAuto"
        Me.btnAgregarAuto.Size = New System.Drawing.Size(133, 28)
        Me.btnAgregarAuto.TabIndex = 6
        Me.btnAgregarAuto.Text = "Agregar Auto"
        Me.btnAgregarAuto.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(141, 127)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(133, 28)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'dgBusqueda
        '
        Me.dgBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBusqueda.Location = New System.Drawing.Point(299, 299)
        Me.dgBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.RowHeadersWidth = 51
        Me.dgBusqueda.Size = New System.Drawing.Size(857, 201)
        Me.dgBusqueda.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 299)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Filtro de búsqueda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Carros disponibles"
        '
        'Buscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 570)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgBusqueda)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregarAuto)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgAutos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Buscador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador"
        CType(Me.dgAutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgAutos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregarAuto As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dgBusqueda As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

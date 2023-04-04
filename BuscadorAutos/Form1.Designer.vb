<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.cbEstilo = New System.Windows.Forms.ComboBox()
        Me.cbCombustible = New System.Windows.Forms.ComboBox()
        Me.cbTransmision = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtKilometraje = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbColor = New System.Windows.Forms.ComboBox()
        Me.cbAnio = New System.Windows.Forms.ComboBox()
        Me.txtCilindrada = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cilindrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estilo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 210)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 379)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio ($)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 243)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Color"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(107, 275)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Combustible"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(107, 308)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Transmisión"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(107, 342)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Kilometraje"
        '
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(199, 48)
        Me.cbMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(160, 24)
        Me.cbMarca.TabIndex = 10
        '
        'cbEstilo
        '
        Me.cbEstilo.FormattingEnabled = True
        Me.cbEstilo.Location = New System.Drawing.Point(199, 169)
        Me.cbEstilo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstilo.Name = "cbEstilo"
        Me.cbEstilo.Size = New System.Drawing.Size(160, 24)
        Me.cbEstilo.TabIndex = 11
        '
        'cbCombustible
        '
        Me.cbCombustible.FormattingEnabled = True
        Me.cbCombustible.Location = New System.Drawing.Point(200, 271)
        Me.cbCombustible.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCombustible.Name = "cbCombustible"
        Me.cbCombustible.Size = New System.Drawing.Size(160, 24)
        Me.cbCombustible.TabIndex = 13
        '
        'cbTransmision
        '
        Me.cbTransmision.FormattingEnabled = True
        Me.cbTransmision.Location = New System.Drawing.Point(200, 304)
        Me.cbTransmision.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTransmision.Name = "cbTransmision"
        Me.cbTransmision.Size = New System.Drawing.Size(160, 24)
        Me.cbTransmision.TabIndex = 14
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(200, 375)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(160, 22)
        Me.txtPrecio.TabIndex = 18
        '
        'txtKilometraje
        '
        Me.txtKilometraje.Location = New System.Drawing.Point(199, 342)
        Me.txtKilometraje.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(160, 22)
        Me.txtKilometraje.TabIndex = 20
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(199, 419)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar Auto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cbColor
        '
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Location = New System.Drawing.Point(200, 239)
        Me.cbColor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(160, 24)
        Me.cbColor.TabIndex = 27
        '
        'cbAnio
        '
        Me.cbAnio.FormattingEnabled = True
        Me.cbAnio.Location = New System.Drawing.Point(200, 207)
        Me.cbAnio.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAnio.Name = "cbAnio"
        Me.cbAnio.Size = New System.Drawing.Size(160, 24)
        Me.cbAnio.TabIndex = 28
        '
        'txtCilindrada
        '
        Me.txtCilindrada.Location = New System.Drawing.Point(199, 131)
        Me.txtCilindrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCilindrada.Name = "txtCilindrada"
        Me.txtCilindrada.Size = New System.Drawing.Size(160, 22)
        Me.txtCilindrada.TabIndex = 29
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(200, 89)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(160, 22)
        Me.txtModelo.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 522)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtCilindrada)
        Me.Controls.Add(Me.cbAnio)
        Me.Controls.Add(Me.cbColor)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtKilometraje)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.cbTransmision)
        Me.Controls.Add(Me.cbCombustible)
        Me.Controls.Add(Me.cbEstilo)
        Me.Controls.Add(Me.cbMarca)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents cbEstilo As ComboBox
    Friend WithEvents cbCombustible As ComboBox
    Friend WithEvents cbTransmision As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtKilometraje As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbColor As ComboBox
    Friend WithEvents cbAnio As ComboBox
    Friend WithEvents txtCilindrada As TextBox
    Friend WithEvents txtModelo As TextBox
End Class

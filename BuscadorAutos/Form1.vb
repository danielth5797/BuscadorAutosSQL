Imports Objetos
Imports CapaNegocio

Public Class Form1

    'Inicializamos la clase Buscador para poder cargar el DataGriedView
    Public Buscador As Buscador = New Buscador()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim obtener_info As New CapaNegocio.Informacion

            'Cargarmos los combo

            'Combo Marca
            cbMarca.DataSource = obtener_info.info_marca()
            cbMarca.ValueMember = "id_Marca"
            cbMarca.DisplayMember = "marca"

            ''Combo Modelo
            'cbMarca.DataSource = obtener_info.info_modelo(cbMarca.ValueMember)
            'cbMarca.ValueMember = "id_Modelo"
            'cbMarca.DisplayMember = "modelo"

            ''Combo Cilindrada
            'cbCilindrada.DataSource = obtener_info.info_cilindrada()
            'cbCilindrada.ValueMember = "id_Cilindrada"
            'cbCilindrada.DisplayMember = "cilindrada"

            'Combo Estilo
            cbEstilo.DataSource = obtener_info.info_estilo()
            cbEstilo.ValueMember = "id_Estilo"
            cbEstilo.DisplayMember = "estilo"

            'Combo Combustible
            cbCombustible.DataSource = obtener_info.info_combustible()
            cbCombustible.ValueMember = "id_Combustible"
            cbCombustible.DisplayMember = "combustible"

            'Combo Transmision
            cbTransmision.DataSource = obtener_info.info_transmision()
            cbTransmision.ValueMember = "id_Transmision"
            cbTransmision.DisplayMember = "transmision"

            'Combo Color
            cbColor.DataSource = obtener_info.info_color()
            cbColor.ValueMember = "id_Color"
            cbColor.DisplayMember = "color"

            'Combo anio
            cbAnio.DataSource = obtener_info.info_anio()
            cbAnio.ValueMember = "id_Anio"
            cbAnio.DisplayMember = "anio"


        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        'Try

        'Obtenemos los valores de los Combos
        Dim marca = cbMarca.SelectedValue
            Dim modelo = txtModelo.Text
            Dim cilindrada = txtCilindrada.Text
            Dim estilo = cbEstilo.SelectedValue
            Dim fecha = cbAnio.SelectedValue
            Dim color = cbColor.SelectedValue
            Dim combustible = cbCombustible.SelectedValue
            Dim transmision = cbTransmision.SelectedValue
            Dim kilometraje = txtKilometraje.Text
            Dim precio = txtPrecio.Text



            'Validamos si hay algun campo vacio
            If String.IsNullOrEmpty(precio) Or String.IsNullOrEmpty(modelo) Or String.IsNullOrEmpty(cilindrada) Or String.IsNullOrEmpty(kilometraje) Then
                MessageBox.Show("Debe llenar todos los espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else 'Si no hay ningun campo vacio

                'Una vez llenado los campos, vamos a crear un objeto Auto para el auto agregado y llenar cada atributo
                Dim objAuto As New Objetos.Auto

                objAuto.marca = marca
                objAuto.modelo = modelo
                objAuto.cilindrada = cilindrada
                objAuto.estilo = estilo
                objAuto.fecha = fecha
                objAuto.precio = precio
                objAuto.color = color
                objAuto.combustible = combustible
                objAuto.transmision = transmision
                objAuto.kilometraje = kilometraje

                'Una vez llenado los atributos de Auto, vamos a enviar el objeto a la base de datos
                'listaAuto.Add(objAuto)

                Dim agregar As New CapaNegocio.Insertar
                agregar.insertar_coche(objAuto)

                'Todos los campos vuelven a su estado original
                cbMarca.SelectedIndex = 0
                txtModelo.Clear()
                txtCilindrada.Clear()
                cbEstilo.SelectedIndex = 0
                cbAnio.SelectedIndex = 0
                cbColor.SelectedIndex = 0
                cbCombustible.SelectedIndex = 0
                cbTransmision.SelectedIndex = 0
                txtKilometraje.Clear()
                txtPrecio.Clear()


                MessageBox.Show("Se agregó el auto exitosamente")

                'Llenamos el DataGridView
                'Buscador.cargarData()

            End If

        'Catch ex As Exception
        '    MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

End Class

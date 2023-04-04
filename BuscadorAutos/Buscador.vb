Imports CapaNegocio

Public Class Buscador

    Private Sub btnAgregarAuto_Click(sender As Object, e As EventArgs) Handles btnAgregarAuto.Click
        Form1.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim obtener_info As New CapaNegocio.ConsultaNegocio
        Dim listaAutosEncontrados = obtener_info.autos_existentes()
        cargarDataCompleta(listaAutosEncontrados)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try

            If txtMarca.Text <> Nothing And txtFecha.Text <> Nothing Then
                Buscar(txtMarca.Text, txtFecha.Text, 3)
            ElseIf txtMarca.Text <> Nothing Then
                Buscar(txtMarca.Text, txtFecha.Text, 1) 'Buscamos por marca, el banderin lo indica
            ElseIf txtFecha.Text <> Nothing Then
                Buscar(txtMarca, txtFecha.Text, 2) 'Buscamos por marca, el banderin lo indica
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Creamos la funcion buscar
    Public Sub Buscar(a, b, c)

        Dim obtener_info As New CapaNegocio.ConsultaNegocio

        If c = 1 Then 'Buscamos por marca

            'Obtenemos la lista de los autos encontrados
            Dim listaAutosEncontrados = obtener_info.buscar_marca(a)

            'Cargamos la lista a el DG
            cargarData(listaAutosEncontrados)


        End If

        If c = 2 Then 'Buscamos por año

            Dim listaAutosEncontrados = obtener_info.buscar_fecha(CInt(b))

            cargarData(listaAutosEncontrados)

            End If

        If c = 3 Then 'Buscamos por Marca y Año

            Dim listaAutosEncontrados = obtener_info.buscar_fecha_marca(a, CInt(b))

            cargarData(listaAutosEncontrados)

        End If


    End Sub



    'Vamos a crear la funci'on para cargar el DataGriedView
    Public Sub cargarData(listaAutosEncontrados As List(Of Objetos.AutoEncontrado))

        Try

            Dim tablaAutos As New DataTable

            tablaAutos.Columns.Add("Marca")
            tablaAutos.Columns.Add("Modelo")
            tablaAutos.Columns.Add("Cilindrada")
            tablaAutos.Columns.Add("Estilo")
            tablaAutos.Columns.Add("Año")
            tablaAutos.Columns.Add("Precio")
            tablaAutos.Columns.Add("Color")
            tablaAutos.Columns.Add("Combustible")
            tablaAutos.Columns.Add("Transmisión")
            tablaAutos.Columns.Add("Kilometraje")

            If listaAutosEncontrados.Count > 0 Then

                Dim objAuto As New Objetos.AutoEncontrado

                For Each objAuto In listaAutosEncontrados
                    tablaAutos.Rows.Add(objAuto.marca, objAuto.modelo, objAuto.cilindrada, objAuto.estilo, objAuto.fecha, objAuto.precio, objAuto.color, objAuto.combustible, objAuto.transmision, objAuto.kilometraje)
                Next

                'Limpiamos el DG
                dgBusqueda.Columns.Clear()
                'Le pasamos el datasource
                dgBusqueda.DataSource = tablaAutos


            Else
                MessageBox.Show("No se encontraron autos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub cargarDataCompleta(listaAutosEncontrados As List(Of Objetos.AutoEncontrado))

        Try

            Dim tablaAutos As New DataTable

            tablaAutos.Columns.Add("Marca")
            tablaAutos.Columns.Add("Modelo")
            tablaAutos.Columns.Add("Cilindrada")
            tablaAutos.Columns.Add("Estilo")
            tablaAutos.Columns.Add("Año")
            tablaAutos.Columns.Add("Precio")
            tablaAutos.Columns.Add("Color")
            tablaAutos.Columns.Add("Combustible")
            tablaAutos.Columns.Add("Transmisión")
            tablaAutos.Columns.Add("Kilometraje")

            If listaAutosEncontrados.Count > 0 Then

                Dim objAuto As New Objetos.AutoEncontrado

                For Each objAuto In listaAutosEncontrados
                    tablaAutos.Rows.Add(objAuto.marca, objAuto.modelo, objAuto.cilindrada, objAuto.estilo, objAuto.fecha, objAuto.precio, objAuto.color, objAuto.combustible, objAuto.transmision, objAuto.kilometraje)
                Next

                'Limpiamos el DG
                dgBusqueda.Columns.Clear()
                'Le pasamos el datasource
                dgAutos.DataSource = tablaAutos


            Else
                MessageBox.Show("No se encontraron autos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class
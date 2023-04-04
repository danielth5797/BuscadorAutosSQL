Imports ManejoDatos

Public Class ConsultaNegocio


    Public Function buscar_marca(marca As String)

        Dim classManejoDatos As New ManejoDatos.Consulta
        Dim autos = classManejoDatos.buscar_marca(marca)


        Dim listaAutosEncontrados As New List(Of Objetos.AutoEncontrado)

        Dim tablaAutosEncontrados = autos.Tables("dtAutos")

        If tablaAutosEncontrados.Rows.Count > 0 Then

            For Each row In tablaAutosEncontrados.Rows

                Dim objauto As New Objetos.AutoEncontrado

                objauto.marca = row.Item("marca")
                objauto.modelo = row.Item("modelo")
                objauto.cilindrada = row.Item("cilindrada")
                objauto.estilo = row.Item("estilo")
                objauto.fecha = row.Item("anio")
                objauto.precio = row.Item("precio")
                objauto.color = row.Item("color")
                objauto.combustible = row.Item("combustible")
                objauto.transmision = row.Item("transmision")
                objauto.kilometraje = row.Item("kilometraje")

                listaAutosEncontrados.Add(objauto)

            Next

        End If

        Return listaAutosEncontrados

    End Function


    Public Function buscar_fecha(fecha As Integer)


        Dim classManejoDatos As New ManejoDatos.Consulta
        Dim autos = classManejoDatos.buscar_fecha(fecha)

        Dim listaAutosEncontrados As New List(Of Objetos.AutoEncontrado)

        Dim tablaAutosEncontrados = autos.Tables("dtAutos")

        If tablaAutosEncontrados.Rows.Count > 0 Then

            For Each row In tablaAutosEncontrados.Rows

                Dim objauto As New Objetos.AutoEncontrado

                objauto.marca = row.Item("marca")
                objauto.modelo = row.Item("modelo")
                objauto.cilindrada = row.Item("cilindrada")
                objauto.estilo = row.Item("estilo")
                objauto.fecha = row.Item("anio")
                objauto.precio = row.Item("precio")
                objauto.color = row.Item("color")
                objauto.combustible = row.Item("combustible")
                objauto.transmision = row.Item("transmision")
                objauto.kilometraje = row.Item("kilometraje")

                listaAutosEncontrados.Add(objauto)

            Next

        End If

        Return listaAutosEncontrados
    End Function

    Public Function buscar_fecha_marca(marca As String, fecha As Integer)


        Dim classManejoDatos As New ManejoDatos.Consulta
        Dim autos = classManejoDatos.buscar_marca_fecha(marca, fecha)

        Dim listaAutosEncontrados As New List(Of Objetos.AutoEncontrado)

        Dim tablaAutosEncontrados = autos.Tables("dtAutos")

        If tablaAutosEncontrados.Rows.Count > 0 Then

            For Each row In tablaAutosEncontrados.Rows

                Dim objauto As New Objetos.AutoEncontrado

                objauto.marca = row.Item("marca")
                objauto.modelo = row.Item("modelo")
                objauto.cilindrada = row.Item("cilindrada")
                objauto.estilo = row.Item("estilo")
                objauto.fecha = row.Item("anio")
                objauto.precio = row.Item("precio")
                objauto.color = row.Item("color")
                objauto.combustible = row.Item("combustible")
                objauto.transmision = row.Item("transmision")
                objauto.kilometraje = row.Item("kilometraje")

                listaAutosEncontrados.Add(objauto)

            Next

        End If

        Return listaAutosEncontrados
    End Function

    Public Function autos_existentes()

        Dim classManejoDatos As New ManejoDatos.Consulta
        Dim autos = classManejoDatos.autos_existentes()

        Dim listaAutosEncontrados As New List(Of Objetos.AutoEncontrado)

        Dim tablaAutosEncontrados = autos.Tables("dtAutos")

        If tablaAutosEncontrados.Rows.Count > 0 Then

            For Each row In tablaAutosEncontrados.Rows

                Dim objauto As New Objetos.AutoEncontrado

                objauto.marca = row.Item("marca")
                objauto.modelo = row.Item("modelo")
                objauto.cilindrada = row.Item("cilindrada")
                objauto.estilo = row.Item("estilo")
                objauto.fecha = row.Item("anio")
                objauto.precio = row.Item("precio")
                objauto.color = row.Item("color")
                objauto.combustible = row.Item("combustible")
                objauto.transmision = row.Item("transmision")
                objauto.kilometraje = row.Item("kilometraje")

                listaAutosEncontrados.Add(objauto)

            Next

        End If

        Return listaAutosEncontrados

    End Function



End Class

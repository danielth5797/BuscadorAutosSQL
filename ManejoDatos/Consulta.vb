Imports System.Data.SqlClient

Public Class Consulta

    Public Function buscar_marca(marca As String)


        Try

            Dim ds As New DataSet()


            Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
            cmd.Connection = conn

            'Parametros de error que va a devolver el procedimiento
            Dim codigo_error As SqlParameter = New SqlParameter("@cod_error", SqlDbType.SmallInt, 0)
            Dim mensaje_error As SqlParameter = New SqlParameter("@msg_error", SqlDbType.VarChar, 255)


            'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "consultar_coche_marca"

            'Le pasamos las variables
            cmd.Parameters.AddWithValue("@marca", marca).Direction = ParameterDirection.Input

            'Obtenemos los parametros de salida
            codigo_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(codigo_error)

            mensaje_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(mensaje_error)

            conn.Open()

            'ejecutar
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(ds, "dtAutos")

            conn.Close()

            If cmd.Parameters("@cod_error").Value <> 0 Then
                Throw New Exception("Error: " + cmd.Parameters("@msg_error").Value)
            Else
                Return ds
            End If



        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function buscar_fecha(fecha As Integer)

        Try
            Dim ds As New DataSet()

            Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
            cmd.Connection = conn

            'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "consultar_coche_fecha"

            'Le pasamos las variables
            cmd.Parameters.AddWithValue("@fecha", fecha).Direction = ParameterDirection.Input

            conn.Open()

            'ejecutar
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(ds, "dtAutos")

            conn.Close()

            Return ds

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Function buscar_marca_fecha(marca As String, fecha As Integer)


        Try

            Dim ds As New DataSet()

            Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
            cmd.Connection = conn

            'Parametros de error que va a devolver el procedimiento
            Dim codigo_error As SqlParameter = New SqlParameter("@cod_error", SqlDbType.SmallInt, 0)
            Dim mensaje_error As SqlParameter = New SqlParameter("@msg_error", SqlDbType.VarChar, 255)


            'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "consultar_coche_marca_fecha"

            'Le pasamos las variables
            cmd.Parameters.AddWithValue("@marca", marca).Direction = ParameterDirection.Input
            cmd.Parameters.AddWithValue("@fecha", fecha).Direction = ParameterDirection.Input

            'Obtenemos los parametros de salida
            codigo_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(codigo_error)

            mensaje_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(mensaje_error)

            conn.Open()

            'ejecutar
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(ds, "dtAutos")

            conn.Close()

            If cmd.Parameters("@cod_error").Value <> 0 Then
                Throw New Exception("Error: " + cmd.Parameters("@msg_error").Value)
            Else
                Return ds
            End If



        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Function autos_existentes()


        Try

            Dim ds As New DataSet()

            Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
            cmd.Connection = conn

            'Parametros de error que va a devolver el procedimiento
            Dim codigo_error As SqlParameter = New SqlParameter("@cod_error", SqlDbType.SmallInt, 0)
            Dim mensaje_error As SqlParameter = New SqlParameter("@msg_error", SqlDbType.VarChar, 255)


            'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "autos_existentes"


            'Obtenemos los parametros de salida
            codigo_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(codigo_error)

            mensaje_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(mensaje_error)

            conn.Open()

            'ejecutar
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(ds, "dtAutos")

            conn.Close()

            If cmd.Parameters("@cod_error").Value <> 0 Then
                Throw New Exception("Error: " + cmd.Parameters("@msg_error").Value)
            Else
                Return ds
            End If



        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

End Class

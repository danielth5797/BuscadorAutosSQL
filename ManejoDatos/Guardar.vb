Imports System.Data.SqlClient

Public Class Guardar

    Public Sub guardar_coche(objAuto As Objetos.Auto)

        Try

            Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
            cmd.Connection = conn

            'Parametros de error que va a devolver el procedimiento
            Dim codigo_error As SqlParameter = New SqlParameter("@cod_error", SqlDbType.SmallInt, 0)
            Dim mensaje_error As SqlParameter = New SqlParameter("@msg_error", SqlDbType.VarChar, 255)


            'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "insertar_coche"

            'Le pasamos las variables

            cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = objAuto.marca
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 30).Value = objAuto.modelo
            cmd.Parameters.Add("@id_estilo", SqlDbType.Int).Value = objAuto.estilo
            cmd.Parameters.Add("@id_combustible", SqlDbType.Int).Value = objAuto.combustible
            cmd.Parameters.Add("@id_transmision", SqlDbType.Int).Value = objAuto.transmision
            cmd.Parameters.Add("@id_color", SqlDbType.Int).Value = objAuto.color
            cmd.Parameters.Add("@cilindrada", SqlDbType.VarChar, 30).Value = objAuto.cilindrada
            cmd.Parameters.Add("@id_anio", SqlDbType.Int).Value = objAuto.fecha
            cmd.Parameters.Add("@kilometraje", SqlDbType.VarChar, 30).Value = objAuto.kilometraje
            cmd.Parameters.Add("@precio", SqlDbType.VarChar, 30).Value = objAuto.precio

            'Obtenemos los parametros de salida
            codigo_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(codigo_error)

            mensaje_error.Direction = ParameterDirection.Output
            cmd.Parameters.Add(mensaje_error)

            'Abrimos la conexion
            conn.Open()
            'Ejecutamos todos los comandos como un query a sql
            cmd.ExecuteNonQuery()
            'Cerramos la conexion
            conn.Close()

            If cmd.Parameters("@cod_error").Value <> 0 Then
                Throw New Exception("Error: " + cmd.Parameters("@msg_error").Value)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

End Class

Public Class ManejoDatos
End Class

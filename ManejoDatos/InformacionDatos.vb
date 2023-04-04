
Imports System.Data.SqlClient

Public Class InformacionDatos

    'Funciones que devuelve la informaciond de los combos

    Public Function marcas()

        Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
        cmd.Connection = conn

        'Llamamos al procedimiento almacenado
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "obtener_marcas"

        conn.Open()

        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader

        Dim datos As New DataTable
        datos.Load(lector)

        conn.Close()

        Return datos
    End Function

    Public Function estilos()

        Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
        cmd.Connection = conn

        'Llamamos al procedimiento almacenado
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "obtener_estilos"

        conn.Open()

        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader

        Dim datos As New DataTable
        datos.Load(lector)

        conn.Close()

        Return datos
    End Function

    Public Function combustible()

        Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
        cmd.Connection = conn

        'Llamamos al procedimiento almacenado
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "obtener_combustible"

        conn.Open()

        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader

        Dim datos As New DataTable
        datos.Load(lector)

        conn.Close()

        Return datos
    End Function

    Public Function transmision()

        Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
        cmd.Connection = conn

        'Llamamos al procedimiento almacenado
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "obtener_transmision"

        conn.Open()

        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader

        Dim datos As New DataTable
        datos.Load(lector)

        conn.Close()

        Return datos
    End Function

    Public Function color()

        Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
        cmd.Connection = conn

        'Llamamos al procedimiento almacenado
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "obtener_color"

        conn.Open()

        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader

        Dim datos As New DataTable
        datos.Load(lector)

        conn.Close()

        Return datos
    End Function

    Public Function anio()

        Dim cmd As New SqlCommand 'Comando que va a interactuar con la base
        cmd.Connection = conn

        'Llamamos al procedimiento almacenado
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "obtener_anio"

        conn.Open()

        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader

        Dim datos As New DataTable
        datos.Load(lector)

        conn.Close()

        Return datos
    End Function

End Class

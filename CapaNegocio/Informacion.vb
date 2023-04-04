Imports ManejoDatos

Public Class Informacion

    Public Function info_marca()

        Dim classManejoDatos As New ManejoDatos.InformacionDatos
        Dim marcas = classManejoDatos.marcas()

        Return marcas

    End Function

    Public Function info_estilo()

        Dim classManejoDatos As New ManejoDatos.InformacionDatos
        Dim estilos = classManejoDatos.estilos()

        Return estilos
    End Function

    Public Function info_combustible()
        Dim classManejoDatos As New ManejoDatos.InformacionDatos
        Dim combustible = classManejoDatos.combustible()

        Return combustible
    End Function

    Public Function info_transmision()
        Dim classManejoDatos As New ManejoDatos.InformacionDatos
        Dim transmision = classManejoDatos.transmision()

        Return transmision
    End Function

    Public Function info_color()
        Dim classManejoDatos As New ManejoDatos.InformacionDatos
        Dim color = classManejoDatos.color()

        Return color
    End Function

    Public Function info_anio()

        Dim classManejoDatos As New ManejoDatos.InformacionDatos
        Dim anio = classManejoDatos.anio()

        Return anio
    End Function

End Class

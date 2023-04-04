Imports Objetos
Imports ManejoDatos

Public Class Insertar
    Public Sub insertar_coche(objCoche As Objetos.Auto)

        Try

            Dim agregar As New ManejoDatos.Guardar
            agregar.guardar_coche(objCoche)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

End Class

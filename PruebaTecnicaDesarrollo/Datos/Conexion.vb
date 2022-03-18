Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Conexion

    Protected conexionBD As New SqlConnection("Data Source=PERSONALLAPTOP-;Initial Catalog=PRUEBA_TECNICA;Integrated Security=True")

    Public Function Conectar() As Boolean

        Try
            conexionBD.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Sub desconectar()
        Try
            If conexionBD.State = ConnectionState.Open Then
                conexionBD.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
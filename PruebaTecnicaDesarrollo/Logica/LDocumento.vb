Public Class LDocumento
    Public Function insertarDocumento(v_Stiker As String, v_idCarpeta As Integer, v_Estado As String, v_Ruta As String)
        Dim dca As New DDocumento(v_Stiker, v_idCarpeta, v_Estado, v_Ruta)
        If dca.insertarDocumento(dca) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CargarStikerCarpeta(v_Stiker As String, v_idCarpeta As Integer, v_Estado As String, v_Ruta As String)
        Dim dca As New DCarpeta(v_Stiker, v_idCarpeta, v_Estado, v_Ruta)
        Return True
    End Function
End Class

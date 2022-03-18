Public Class LCaja
    Public Function insertarCaja(v_Stiker As String, v_Ubicacion As String, v_Estado As String, v_Observaciones As String)
        Dim dc As New DCaja(v_Stiker, v_Ubicacion, v_Estado, v_Observaciones)

        If dc.insertarCaja(dc) = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

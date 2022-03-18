Public Class LBolsas
    Public Function insertarBolsas(v_Stiker As String, v_Estado As String, v_IdCaja As Integer)
        Dim db As New DBolsas(v_Stiker, v_Estado, v_IdCaja)
        If db.insertarBolsa(db) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CargarStikerCaja(v_IdCaja As Integer, v_Stiker As String, v_Ubicacion As String, v_Estado As String, v_Observaciones As String)
        Dim db As New DBolsas(v_IdCaja, v_Stiker, v_Estado)
        Return True
    End Function
End Class

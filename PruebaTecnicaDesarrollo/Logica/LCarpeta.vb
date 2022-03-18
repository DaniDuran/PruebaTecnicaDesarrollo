Public Class LCarpeta
    Public Function insertarCarpetas(v_Stiker As String, v_idBolsa As Integer, v_Estado As String, v_Aletas As String)
        Dim dca As New DCarpeta(v_Stiker, v_idBolsa, v_Estado, v_Aletas)
        If dca.insertarCarpeta(dca) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CargarStikerBolsas(v_Stiker As String, v_idBolsa As Integer, v_Estado As String, v_Aletas As String)
        Dim dca As New DCarpeta(v_Stiker, v_idBolsa, v_Estado, v_Aletas)

        Return True
    End Function
End Class

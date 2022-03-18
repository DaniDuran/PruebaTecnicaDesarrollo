Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DCarpeta
    Inherits Conexion

    Private Sticker As String
    Private idBolsa As Integer
    Private Estado As String
    Private Aletas As String
    Private FechaIngreso As DateTime
    Private FechaMovimiento As DateTime

    Public Sub New(v_Stiker As String, v_idBolsa As Integer, v_Estado As String, v_Aletas As String)
        Sticker = v_Stiker
        idBolsa = v_idBolsa
        Estado = v_Estado
        Aletas = v_Aletas
    End Sub
    Public Sub New()
    End Sub
    Public Function insertarCarpeta(dca As DCarpeta)
        Try
            Conectar()
            Dim sql As String = "INSERT INTO [dbo].[CARPETA] ([STICKER],[FK_CARPETA_BOLSA],[ESTADO],[ALETAS],[FECHA_INGRESO],[FECHA_MOVIMIENTO]) VALUES('" & dca.Sticker & "'," & dca.idBolsa & ",'" & dca.Estado & "','" & dca.Aletas & "',GETDATE(),GETDATE())"
            Dim cmd As New SqlCommand(sql, conexionBD)
            If cmd.ExecuteNonQuery() Then
                MsgBox("Registro Insertado correctamente")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
    Public Function consultarStikerBolsas(ByVal cmb As ComboBox)
        Try
            Dim sql As String = "SELECT * FROM [dbo].[BOLSA]"
            Dim cmd As New SqlDataAdapter(sql, conexionBD)
            Dim ds As New DataSet
            cmd.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                cmb.DataSource = ds.Tables(0)
                cmb.DisplayMember = "STICKER"
                cmb.ValueMember = "PK_BOLSA"
                cmb.SelectedIndex = -1
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function datagridCarpeta(ByVal dgv As DataGridView)
        Try
            Conectar()
            Dim sql As String = "SELECT [PK_CARPETA]
                                       ,[STICKER]
                                       ,[FK_CARPETA_BOLSA]
                                       ,[ESTADO]
                                       ,[ALETAS]
                                       ,[FECHA_INGRESO]
                                       ,[FECHA_MOVIMIENTO]
                                FROM [PRUEBA_TECNICA].[dbo].[CARPETA]"
            Dim cmd As New SqlDataAdapter(sql, conexionBD)
            Dim ds As New DataSet
            cmd.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                dgv.DataSource = ds.Tables(0)
                Return True
            Else
                dgv.DataSource = Nothing
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class

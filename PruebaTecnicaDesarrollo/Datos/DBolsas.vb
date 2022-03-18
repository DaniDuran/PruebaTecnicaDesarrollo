Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DBolsas
    Inherits Conexion

    Private IdBolsa As Integer
    Private Stiker As String
    Private Estado As String
    Private IdCaja As Integer
    Private FechaCreacion As DateTime
    Private FechaMovimiento As DateTime
    Public Sub New(v_Stiker As String, v_Estado As String, v_IdCaja As Integer)
        IdCaja = v_IdCaja
        Stiker = v_Stiker
        Estado = v_Estado
    End Sub
    Public Sub New()

    End Sub
    Public Function insertarBolsa(db As DBolsas)
        Try
            Conectar()
            Dim sql As String = "INSERT INTO [dbo].[BOLSA](
                                                           [STICKER]
                                                          ,[ESTADO]
                                                          ,[FK_BOLSA_CAJA]
                                                          ,[FECHA_INGRESO]
                                                          ,[FECHA_MOVIMIENTO]
                                                          ) VALUES(
                                                          '" & db.Stiker & "'
                                                          ,'" & db.Estado & "'
                                                          ," & db.IdCaja & "
                                                          ,GETDATE()
                                                          ,GETDATE()
                                                          )"
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
    Public Function consultarStikerCaja(ByVal cmb As ComboBox)
        Try
            Dim sql As String = "SELECT * FROM [dbo].[CAJA]"
            Dim cmd As New SqlDataAdapter(sql, conexionBD)
            Dim ds As New DataSet
            cmd.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                cmb.DataSource = ds.Tables(0)
                cmb.DisplayMember = "STICKER"
                cmb.ValueMember = "PK_CAJA"
                cmb.SelectedIndex = -1
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function datagridBolsas(ByVal dgv As DataGridView)
        Try
            Conectar()
            Dim sql As String = "SELECT [PK_BOLSA] AS ID
                                       ,[STICKER]
                                       ,[ESTADO]
                                       ,[FK_BOLSA_CAJA]
                                       ,[FECHA_INGRESO]
                                       ,[FECHA_MOVIMIENTO]
                                 FROM [PRUEBA_TECNICA].[dbo].[BOLSA]"
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

Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DDocumento
    Inherits Conexion

    Private Sticker As String
    Private idCarpeta As Integer
    Private Estado As String
    Private FechaIngreso As DateTime
    Private FechaMovimiento As DateTime
    Private Ruta As String

    Public Sub New(sticker As String, idCarpeta As Integer, estado As String, ruta As String)
        Me.Sticker = sticker
        Me.idCarpeta = idCarpeta
        Me.Estado = estado
        Me.Ruta = ruta
    End Sub

    Public Sub New()
    End Sub

    Public Function insertarDocumento(dd As DDocumento)
        Try
            Conectar()
            Dim sql As String = "INSERT INTO [dbo].[DOCUMENTO] ([STICKER]
                                                                ,[FK_DOCUMENTO_CARPETA]
                                                                ,[ESTADO],[FECHA_INGRESO]
                                                                ,[FECHA_MOVIMIENTO]
                                                                ,[RUTA]) 
                                                                VALUES
                                                                ('" & dd.Sticker & "'
                                                                ," & dd.idCarpeta & "
                                                                ,'" & dd.Estado & "'
                                                                ,GETDATE()
                                                                ,GETDATE()
                                                                ,'" & dd.Ruta & "'
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
    Public Function consultarStikerCarpeta(ByVal cmb As ComboBox)
        Try
            Dim sql As String = "SELECT PK_CARPETA,STICKER   FROM [dbo].[CARPETA]"
            Dim cmd As New SqlDataAdapter(sql, conexionBD)
            Dim ds As New DataSet
            cmd.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                cmb.DataSource = ds.Tables(0)
                cmb.DisplayMember = "STICKER"
                cmb.ValueMember = "PK_CARPETA"
                cmb.SelectedIndex = -1
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function datagridDocumento(ByVal dgv As DataGridView)
        Try
            Conectar()
            Dim sql As String = "SELECT [FK_DOCUMENTO_CARPETA]
                                       ,[PK_DOCUMENTO]
                                       ,[STICKER]
                                       ,[RUTA]
                                       ,[ESTADO]
                                       ,[FECHA_INGRESO]
                                       ,[FECHA_MOVIMIENTO]
                                FROM [PRUEBA_TECNICA].[dbo].[DOCUMENTO]"
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

Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DCaja
    Inherits Conexion

    Private IdCaja As Integer
    Private Stiker As String
    Private Ubicacion As String
    Private Estado As String
    Private Observaciones As String
    Private FechaCreacion As DateTime
    Private FechaMovimiento As DateTime

    Public Sub New(v_Stiker As String, v_Ubicacion As String, v_Estado As String, v_Observaciones As String)
        Stiker = v_Stiker
        Ubicacion = v_Ubicacion
        Estado = v_Estado
        Observaciones = v_Observaciones
    End Sub

    Public Sub New()

    End Sub

    Public Function insertarCaja(dc As DCaja)
        Try

            Conectar()
            Dim sql As String = "INSERT INTO [dbo].[CAJA]([STICKER],[UBICACION],[ESTADO],[OBSERVACIONES],[FECHA_CREACION],[FECHA_MOVIMIENTO]) VALUES('" & dc.Stiker & "','" & dc.Ubicacion & "','" & dc.Estado & "','" & dc.Observaciones & "',GETDATE(),GETDATE())"
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
    Public Function datagridCaja(ByVal dgv As DataGridView)
        Try
            Conectar()
            Dim sql As String = "SELECT [PK_CAJA] as ID
                                       ,[STICKER]
                                       ,[UBICACION]
                                       ,[ESTADO]
                                       ,[OBSERVACIONES]
                                       ,[FECHA_CREACION]
                                       ,[FECHA_MOVIMIENTO] 
                                 FROM [dbo].[CAJA]"
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
    Public Function cargaDataDGVCaja(ByVal dgv As DataGridView, STICKER As TextBox, UBICACION As TextBox, ESTADO As TextBox, OBSERVACIONES As TextBox)
        Try
            Conectar()
            STICKER.Text = dgv.CurrentRow.Cells("STICKER").Value
            UBICACION.Text = dgv.CurrentRow.Cells("UBICACION").Value
            ESTADO.Text = dgv.CurrentRow.Cells("ESTADO").Value
            OBSERVACIONES.Text = dgv.CurrentRow.Cells("OBSERVACIONES").Value
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
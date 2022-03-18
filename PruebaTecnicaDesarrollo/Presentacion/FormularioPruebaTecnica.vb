Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormularioPruebaTecnica
    Private Sub btnGuardarCaja_Click(sender As Object, e As EventArgs) Handles btnGuardarCaja.Click
        Try
            Dim lc As New LCaja()
            lc.insertarCaja(txtStickerCaja.Text, txtUbicacionCaja.Text, cmbEstadoCaja.SelectedItem, txtObservacionCaja.Text)
            Dim db As New DBolsas()
            Dim dc As New DCaja()
            db.consultarStikerCaja(cmbCajas)
            dc.datagridCaja(dgvCaja)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormularioPruebaTecnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dc As New DCaja()
            Dim db As New DBolsas()
            Dim dcar As New DCarpeta()
            Dim ddoc As New DDocumento()

            db.consultarStikerCaja(cmbCajas)
            dcar.consultarStikerBolsas(cmbBolsas)
            ddoc.consultarStikerCarpeta(cmbCarpeta)
            dc.datagridCaja(dgvCaja)
            db.datagridBolsas(dgvBolsa)
            dcar.datagridCarpeta(dgvCarpeta)
            ddoc.datagridDocumento(dgvDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarBolsa_Click(sender As Object, e As EventArgs) Handles btnGuardarBolsa.Click
        Try
            Dim dcar As New DCarpeta()
            Dim db As New DBolsas()
            Dim lB As New LBolsas()
            lB.insertarBolsas(txtStickerBolsa.Text, cmbEstadoBolsa.SelectedItem, cmbCajas.SelectedValue)
            dcar.consultarStikerBolsas(cmbBolsas)
            db.datagridBolsas(dgvBolsa)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarCarpeta_Click(sender As Object, e As EventArgs) Handles btnGuardarCarpeta.Click
        Try
            Dim lCa As New LCarpeta()
            Dim dcar As New DCarpeta()
            Dim ddoc As New DDocumento()
            lCa.insertarCarpetas(txtStickerCarpeta.Text, cmbBolsas.SelectedValue, cmbEstadoCarpeta.SelectedItem, txtAletaCarpeta.Text)
            dcar.datagridCarpeta(dgvCarpeta)
            ddoc.consultarStikerCarpeta(cmbCarpeta)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCaja.CellContentClick
        Try
            Dim lC As New LCaja()
            'lC.(txtStickerCarpeta.Text, cmbBolsas.SelectedValue, cmbEstadoCarpeta.SelectedItem, txtAletaCarpeta.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarDocumento_Click(sender As Object, e As EventArgs) Handles btnGuardarDocumento.Click
        Try
            Dim lDoc As New LDocumento()
            Dim dDoc As New DDocumento()
            lDoc.insertarDocumento(txtStickerDocumento.Text, cmbCarpeta.SelectedValue, cmbEstadoDocumento.SelectedItem, txtRutaDocumento.Text)
            dDoc.datagridDocumento(dgvDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Menu.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class
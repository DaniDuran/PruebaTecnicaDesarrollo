<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPruebaTecnica
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Menu = New System.Windows.Forms.TabControl()
        Me.Caja = New System.Windows.Forms.TabPage()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardarCaja = New System.Windows.Forms.Button()
        Me.txtStickerCaja = New System.Windows.Forms.TextBox()
        Me.cmbEstadoCaja = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtObservacionCaja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUbicacionCaja = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bolsa = New System.Windows.Forms.TabPage()
        Me.dgvBolsa = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbEstadoBolsa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.txtStickerBolsa = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardarBolsa = New System.Windows.Forms.Button()
        Me.Carpeta = New System.Windows.Forms.TabPage()
        Me.dgvCarpeta = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAletaCarpeta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbEstadoCarpeta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbBolsas = New System.Windows.Forms.ComboBox()
        Me.txtStickerCarpeta = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnGuardarCarpeta = New System.Windows.Forms.Button()
        Me.Documento = New System.Windows.Forms.TabPage()
        Me.dgvDocumento = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRutaDocumento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbEstadoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCarpeta = New System.Windows.Forms.ComboBox()
        Me.txtStickerDocumento = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardarDocumento = New System.Windows.Forms.Button()
        Me.Reporte = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Menu.SuspendLayout()
        Me.Caja.SuspendLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Bolsa.SuspendLayout()
        CType(Me.dgvBolsa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Carpeta.SuspendLayout()
        CType(Me.dgvCarpeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Documento.SuspendLayout()
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Reporte.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Controls.Add(Me.Caja)
        Me.Menu.Controls.Add(Me.Bolsa)
        Me.Menu.Controls.Add(Me.Carpeta)
        Me.Menu.Controls.Add(Me.Documento)
        Me.Menu.Controls.Add(Me.Reporte)
        Me.Menu.Location = New System.Drawing.Point(12, 12)
        Me.Menu.Name = "Menu"
        Me.Menu.SelectedIndex = 0
        Me.Menu.Size = New System.Drawing.Size(776, 426)
        Me.Menu.TabIndex = 2
        '
        'Caja
        '
        Me.Caja.Controls.Add(Me.dgvCaja)
        Me.Caja.Controls.Add(Me.GroupBox1)
        Me.Caja.Location = New System.Drawing.Point(4, 24)
        Me.Caja.Name = "Caja"
        Me.Caja.Padding = New System.Windows.Forms.Padding(3)
        Me.Caja.Size = New System.Drawing.Size(768, 398)
        Me.Caja.TabIndex = 0
        Me.Caja.Text = "Caja"
        Me.Caja.UseVisualStyleBackColor = True
        '
        'dgvCaja
        '
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Location = New System.Drawing.Point(6, 121)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.RowTemplate.Height = 25
        Me.dgvCaja.Size = New System.Drawing.Size(756, 263)
        Me.dgvCaja.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnGuardarCaja)
        Me.GroupBox1.Controls.Add(Me.txtStickerCaja)
        Me.GroupBox1.Controls.Add(Me.cmbEstadoCaja)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtObservacionCaja)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtUbicacionCaja)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 109)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion de cajas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(581, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "ESTADO"
        '
        'btnGuardarCaja
        '
        Me.btnGuardarCaja.Location = New System.Drawing.Point(199, 70)
        Me.btnGuardarCaja.Name = "btnGuardarCaja"
        Me.btnGuardarCaja.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarCaja.TabIndex = 5
        Me.btnGuardarCaja.Text = "GUARDAR"
        Me.btnGuardarCaja.UseVisualStyleBackColor = True
        '
        'txtStickerCaja
        '
        Me.txtStickerCaja.Location = New System.Drawing.Point(65, 33)
        Me.txtStickerCaja.Name = "txtStickerCaja"
        Me.txtStickerCaja.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerCaja.TabIndex = 10
        '
        'cmbEstadoCaja
        '
        Me.cmbEstadoCaja.DisplayMember = "SELECCIONAR ESTADO"
        Me.cmbEstadoCaja.FormattingEnabled = True
        Me.cmbEstadoCaja.Items.AddRange(New Object() {"ACTIVO", "DESACTIVO"})
        Me.cmbEstadoCaja.Location = New System.Drawing.Point(636, 33)
        Me.cmbEstadoCaja.Name = "cmbEstadoCaja"
        Me.cmbEstadoCaja.Size = New System.Drawing.Size(114, 23)
        Me.cmbEstadoCaja.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(464, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "ELIMINAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(322, 70)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "MODIFICAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtObservacionCaja
        '
        Me.txtObservacionCaja.Location = New System.Drawing.Point(464, 33)
        Me.txtObservacionCaja.Name = "txtObservacionCaja"
        Me.txtObservacionCaja.Size = New System.Drawing.Size(100, 23)
        Me.txtObservacionCaja.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STICKER"
        '
        'txtUbicacionCaja
        '
        Me.txtUbicacionCaja.Location = New System.Drawing.Point(249, 33)
        Me.txtUbicacionCaja.Name = "txtUbicacionCaja"
        Me.txtUbicacionCaja.Size = New System.Drawing.Size(100, 23)
        Me.txtUbicacionCaja.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UBICACION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "OBSERVACIONES"
        '
        'Bolsa
        '
        Me.Bolsa.Controls.Add(Me.dgvBolsa)
        Me.Bolsa.Controls.Add(Me.GroupBox2)
        Me.Bolsa.Location = New System.Drawing.Point(4, 24)
        Me.Bolsa.Name = "Bolsa"
        Me.Bolsa.Padding = New System.Windows.Forms.Padding(3)
        Me.Bolsa.Size = New System.Drawing.Size(768, 398)
        Me.Bolsa.TabIndex = 1
        Me.Bolsa.Text = "Bolsa"
        Me.Bolsa.UseVisualStyleBackColor = True
        '
        'dgvBolsa
        '
        Me.dgvBolsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBolsa.Location = New System.Drawing.Point(6, 116)
        Me.dgvBolsa.Name = "dgvBolsa"
        Me.dgvBolsa.RowTemplate.Height = 25
        Me.dgvBolsa.Size = New System.Drawing.Size(756, 276)
        Me.dgvBolsa.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbEstadoBolsa)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbCajas)
        Me.GroupBox2.Controls.Add(Me.txtStickerBolsa)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnGuardarBolsa)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 104)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestion de bolsas"
        '
        'cmbEstadoBolsa
        '
        Me.cmbEstadoBolsa.DisplayMember = "SELECCIONAR ESTADO"
        Me.cmbEstadoBolsa.FormattingEnabled = True
        Me.cmbEstadoBolsa.Items.AddRange(New Object() {"ACTIVO", "DESACTIVO"})
        Me.cmbEstadoBolsa.Location = New System.Drawing.Point(535, 33)
        Me.cmbEstadoBolsa.Name = "cmbEstadoBolsa"
        Me.cmbEstadoBolsa.Size = New System.Drawing.Size(114, 23)
        Me.cmbEstadoBolsa.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CAJA"
        '
        'cmbCajas
        '
        Me.cmbCajas.FormattingEnabled = True
        Me.cmbCajas.Location = New System.Drawing.Point(321, 33)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(121, 23)
        Me.cmbCajas.TabIndex = 13
        '
        'txtStickerBolsa
        '
        Me.txtStickerBolsa.Location = New System.Drawing.Point(171, 34)
        Me.txtStickerBolsa.Name = "txtStickerBolsa"
        Me.txtStickerBolsa.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerBolsa.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(464, 70)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "ELIMINAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(321, 70)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "MODIFICAR"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "STICKER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(480, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ESTADO"
        '
        'btnGuardarBolsa
        '
        Me.btnGuardarBolsa.Location = New System.Drawing.Point(199, 70)
        Me.btnGuardarBolsa.Name = "btnGuardarBolsa"
        Me.btnGuardarBolsa.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarBolsa.TabIndex = 5
        Me.btnGuardarBolsa.Text = "GUARDAR"
        Me.btnGuardarBolsa.UseVisualStyleBackColor = True
        '
        'Carpeta
        '
        Me.Carpeta.Controls.Add(Me.dgvCarpeta)
        Me.Carpeta.Controls.Add(Me.GroupBox3)
        Me.Carpeta.Location = New System.Drawing.Point(4, 24)
        Me.Carpeta.Name = "Carpeta"
        Me.Carpeta.Padding = New System.Windows.Forms.Padding(3)
        Me.Carpeta.Size = New System.Drawing.Size(768, 398)
        Me.Carpeta.TabIndex = 2
        Me.Carpeta.Text = "Carpeta"
        Me.Carpeta.UseVisualStyleBackColor = True
        '
        'dgvCarpeta
        '
        Me.dgvCarpeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarpeta.Location = New System.Drawing.Point(6, 116)
        Me.dgvCarpeta.Name = "dgvCarpeta"
        Me.dgvCarpeta.RowTemplate.Height = 25
        Me.dgvCarpeta.Size = New System.Drawing.Size(756, 276)
        Me.dgvCarpeta.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAletaCarpeta)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cmbEstadoCarpeta)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmbBolsas)
        Me.GroupBox3.Controls.Add(Me.txtStickerCarpeta)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.Button12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnGuardarCarpeta)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(756, 104)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestion de carpetas"
        '
        'txtAletaCarpeta
        '
        Me.txtAletaCarpeta.Location = New System.Drawing.Point(411, 29)
        Me.txtAletaCarpeta.Name = "txtAletaCarpeta"
        Me.txtAletaCarpeta.Size = New System.Drawing.Size(100, 23)
        Me.txtAletaCarpeta.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(355, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "ALETA"
        '
        'cmbEstadoCarpeta
        '
        Me.cmbEstadoCarpeta.DisplayMember = "SELECCIONAR ESTADO"
        Me.cmbEstadoCarpeta.FormattingEnabled = True
        Me.cmbEstadoCarpeta.Items.AddRange(New Object() {"ACTIVO", "DESACTIVO"})
        Me.cmbEstadoCarpeta.Location = New System.Drawing.Point(610, 29)
        Me.cmbEstadoCarpeta.Name = "cmbEstadoCarpeta"
        Me.cmbEstadoCarpeta.Size = New System.Drawing.Size(114, 23)
        Me.cmbEstadoCarpeta.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "BOLSA"
        '
        'cmbBolsas
        '
        Me.cmbBolsas.FormattingEnabled = True
        Me.cmbBolsas.Location = New System.Drawing.Point(67, 32)
        Me.cmbBolsas.Name = "cmbBolsas"
        Me.cmbBolsas.Size = New System.Drawing.Size(87, 23)
        Me.cmbBolsas.TabIndex = 13
        '
        'txtStickerCarpeta
        '
        Me.txtStickerCarpeta.Location = New System.Drawing.Point(230, 29)
        Me.txtStickerCarpeta.Name = "txtStickerCarpeta"
        Me.txtStickerCarpeta.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerCarpeta.TabIndex = 10
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(464, 70)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 6
        Me.Button11.Text = "ELIMINAR"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(323, 70)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(97, 23)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "MODIFICAR"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(174, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "STICKER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(555, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ESTADO"
        '
        'btnGuardarCarpeta
        '
        Me.btnGuardarCarpeta.Location = New System.Drawing.Point(199, 70)
        Me.btnGuardarCarpeta.Name = "btnGuardarCarpeta"
        Me.btnGuardarCarpeta.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarCarpeta.TabIndex = 5
        Me.btnGuardarCarpeta.Text = "GUARDAR"
        Me.btnGuardarCarpeta.UseVisualStyleBackColor = True
        '
        'Documento
        '
        Me.Documento.Controls.Add(Me.dgvDocumento)
        Me.Documento.Controls.Add(Me.GroupBox4)
        Me.Documento.Location = New System.Drawing.Point(4, 24)
        Me.Documento.Name = "Documento"
        Me.Documento.Padding = New System.Windows.Forms.Padding(3)
        Me.Documento.Size = New System.Drawing.Size(768, 398)
        Me.Documento.TabIndex = 3
        Me.Documento.Text = "Documento"
        Me.Documento.UseVisualStyleBackColor = True
        '
        'dgvDocumento
        '
        Me.dgvDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumento.Location = New System.Drawing.Point(6, 116)
        Me.dgvDocumento.Name = "dgvDocumento"
        Me.dgvDocumento.RowTemplate.Height = 25
        Me.dgvDocumento.Size = New System.Drawing.Size(756, 276)
        Me.dgvDocumento.TabIndex = 20
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRutaDocumento)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cmbEstadoDocumento)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cmbCarpeta)
        Me.GroupBox4.Controls.Add(Me.txtStickerDocumento)
        Me.GroupBox4.Controls.Add(Me.Button16)
        Me.GroupBox4.Controls.Add(Me.Button17)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.btnGuardarDocumento)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(756, 104)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gestion de documentos"
        '
        'txtRutaDocumento
        '
        Me.txtRutaDocumento.Location = New System.Drawing.Point(439, 25)
        Me.txtRutaDocumento.Name = "txtRutaDocumento"
        Me.txtRutaDocumento.Size = New System.Drawing.Size(128, 23)
        Me.txtRutaDocumento.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(383, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "RUTA"
        '
        'cmbEstadoDocumento
        '
        Me.cmbEstadoDocumento.FormattingEnabled = True
        Me.cmbEstadoDocumento.Items.AddRange(New Object() {"ACTIVO", "DESACTIVO"})
        Me.cmbEstadoDocumento.Location = New System.Drawing.Point(637, 22)
        Me.cmbEstadoDocumento.Name = "cmbEstadoDocumento"
        Me.cmbEstadoDocumento.Size = New System.Drawing.Size(113, 23)
        Me.cmbEstadoDocumento.TabIndex = 15
        Me.cmbEstadoDocumento.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "CARPETA"
        '
        'cmbCarpeta
        '
        Me.cmbCarpeta.FormattingEnabled = True
        Me.cmbCarpeta.Location = New System.Drawing.Point(75, 22)
        Me.cmbCarpeta.Name = "cmbCarpeta"
        Me.cmbCarpeta.Size = New System.Drawing.Size(87, 23)
        Me.cmbCarpeta.TabIndex = 13
        '
        'txtStickerDocumento
        '
        Me.txtStickerDocumento.Location = New System.Drawing.Point(255, 22)
        Me.txtStickerDocumento.Name = "txtStickerDocumento"
        Me.txtStickerDocumento.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerDocumento.TabIndex = 10
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(464, 70)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 23)
        Me.Button16.TabIndex = 6
        Me.Button16.Text = "ELIMINAR"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(321, 70)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(97, 23)
        Me.Button17.TabIndex = 9
        Me.Button17.Text = "MODIFICAR"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(199, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "STICKER"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(573, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "ESTADO"
        '
        'btnGuardarDocumento
        '
        Me.btnGuardarDocumento.Location = New System.Drawing.Point(199, 70)
        Me.btnGuardarDocumento.Name = "btnGuardarDocumento"
        Me.btnGuardarDocumento.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarDocumento.TabIndex = 5
        Me.btnGuardarDocumento.Text = "GUARDAR"
        Me.btnGuardarDocumento.UseVisualStyleBackColor = True
        '
        'Reporte
        '
        Me.Reporte.Controls.Add(Me.TabControl1)
        Me.Reporte.Location = New System.Drawing.Point(4, 24)
        Me.Reporte.Name = "Reporte"
        Me.Reporte.Padding = New System.Windows.Forms.Padding(3)
        Me.Reporte.Size = New System.Drawing.Size(768, 398)
        Me.Reporte.TabIndex = 4
        Me.Reporte.Text = "Reporte"
        Me.Reporte.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 398)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reporte 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(756, 333)
        Me.DataGridView1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(315, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(259, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 15)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "STICKER"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(760, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reporte 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(2, 33)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(756, 333)
        Me.DataGridView2.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(315, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 22
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(432, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "BUSCAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(259, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 15)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "STICKER"
        '
        'DCajaBindingSource
        '
        Me.DCajaBindingSource.DataSource = GetType(PruebaTecnicaDesarrollo.DCaja)
        '
        'FormularioPruebaTecnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Menu)
        Me.Name = "FormularioPruebaTecnica"
        Me.Text = "FormularioPruebaTecnica"
        Me.Menu.ResumeLayout(False)
        Me.Caja.ResumeLayout(False)
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Bolsa.ResumeLayout(False)
        CType(Me.dgvBolsa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Carpeta.ResumeLayout(False)
        CType(Me.dgvCarpeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Documento.ResumeLayout(False)
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Reporte.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Menu As TabControl
    Friend WithEvents Caja As TabPage
    Friend WithEvents dgvCaja As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGuardarCaja As Button
    Friend WithEvents txtStickerCaja As TextBox
    Friend WithEvents cmbEstadoCaja As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtObservacionCaja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUbicacionCaja As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Bolsa As TabPage
    Friend WithEvents dgvBolsa As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbEstadoBolsa As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCajas As ComboBox
    Friend WithEvents txtStickerBolsa As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGuardarBolsa As Button
    Friend WithEvents Carpeta As TabPage
    Friend WithEvents dgvCarpeta As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbEstadoCarpeta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbBolsas As ComboBox
    Friend WithEvents txtStickerCarpeta As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnGuardarCarpeta As Button
    Friend WithEvents Documento As TabPage
    Friend WithEvents dgvDocumento As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents txtStickerDocumento As TextBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGuardarDocumento As Button
    Friend WithEvents Reporte As TabPage
    Friend WithEvents DCajaBindingSource As BindingSource
    Friend WithEvents txtAletaCarpeta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRutaDocumento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbEstadoDocumento As ComboBox
    Friend WithEvents cmbCarpeta As ComboBox
End Class

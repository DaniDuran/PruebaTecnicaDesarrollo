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
        Me.dgvDocumento = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbEstadoDocumento = New System.Windows.Forms.ComboBox()
        Me.cmbCarpeta = New System.Windows.Forms.ComboBox()
        Me.txtRutaDocumento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStickerDocumento = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardarDocumento = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.dgvCarpeta = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbBolsas = New System.Windows.Forms.ComboBox()
        Me.txtAletaCarpeta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbEstadoCarpeta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStickerCarpeta = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnGuardarCarpeta = New System.Windows.Forms.Button()
        Me.DCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBolsa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCarpeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDocumento
        '
        Me.dgvDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumento.Location = New System.Drawing.Point(6, 115)
        Me.dgvDocumento.Name = "dgvDocumento"
        Me.dgvDocumento.RowTemplate.Height = 25
        Me.dgvDocumento.Size = New System.Drawing.Size(540, 184)
        Me.dgvDocumento.TabIndex = 20
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbEstadoDocumento)
        Me.GroupBox4.Controls.Add(Me.cmbCarpeta)
        Me.GroupBox4.Controls.Add(Me.dgvDocumento)
        Me.GroupBox4.Controls.Add(Me.txtRutaDocumento)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtStickerDocumento)
        Me.GroupBox4.Controls.Add(Me.Button16)
        Me.GroupBox4.Controls.Add(Me.Button17)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.btnGuardarDocumento)
        Me.GroupBox4.Location = New System.Drawing.Point(546, 346)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 305)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gestion de documentos"
        '
        'cmbEstadoDocumento
        '
        Me.cmbEstadoDocumento.FormattingEnabled = True
        Me.cmbEstadoDocumento.Items.AddRange(New Object() {"ACTIVO", "DESACTIVO"})
        Me.cmbEstadoDocumento.Location = New System.Drawing.Point(415, 44)
        Me.cmbEstadoDocumento.Name = "cmbEstadoDocumento"
        Me.cmbEstadoDocumento.Size = New System.Drawing.Size(113, 23)
        Me.cmbEstadoDocumento.TabIndex = 15
        Me.cmbEstadoDocumento.Tag = ""
        '
        'cmbCarpeta
        '
        Me.cmbCarpeta.FormattingEnabled = True
        Me.cmbCarpeta.Location = New System.Drawing.Point(13, 44)
        Me.cmbCarpeta.Name = "cmbCarpeta"
        Me.cmbCarpeta.Size = New System.Drawing.Size(87, 23)
        Me.cmbCarpeta.TabIndex = 13
        '
        'txtRutaDocumento
        '
        Me.txtRutaDocumento.Location = New System.Drawing.Point(257, 44)
        Me.txtRutaDocumento.Name = "txtRutaDocumento"
        Me.txtRutaDocumento.Size = New System.Drawing.Size(128, 23)
        Me.txtRutaDocumento.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(257, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "RUTA"
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
        'txtStickerDocumento
        '
        Me.txtStickerDocumento.Location = New System.Drawing.Point(127, 44)
        Me.txtStickerDocumento.Name = "txtStickerDocumento"
        Me.txtStickerDocumento.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerDocumento.TabIndex = 10
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(365, 83)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 23)
        Me.Button16.TabIndex = 6
        Me.Button16.Text = "ELIMINAR"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(195, 83)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(97, 23)
        Me.Button17.TabIndex = 9
        Me.Button17.Text = "MODIFICAR"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(127, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "STICKER"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(415, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "ESTADO"
        '
        'btnGuardarDocumento
        '
        Me.btnGuardarDocumento.Location = New System.Drawing.Point(85, 83)
        Me.btnGuardarDocumento.Name = "btnGuardarDocumento"
        Me.btnGuardarDocumento.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarDocumento.TabIndex = 5
        Me.btnGuardarDocumento.Text = "GUARDAR"
        Me.btnGuardarDocumento.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(522, 140)
        Me.DataGridView1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(155, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 15)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "STICKER DOCUMENTO"
        '
        'dgvCaja
        '
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Location = New System.Drawing.Point(9, 107)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.RowTemplate.Height = 25
        Me.dgvCaja.Size = New System.Drawing.Size(484, 151)
        Me.dgvCaja.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCaja)
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
        Me.GroupBox1.Location = New System.Drawing.Point(21, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 268)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion de cajas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(386, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "ESTADO"
        '
        'btnGuardarCaja
        '
        Me.btnGuardarCaja.Location = New System.Drawing.Point(84, 66)
        Me.btnGuardarCaja.Name = "btnGuardarCaja"
        Me.btnGuardarCaja.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarCaja.TabIndex = 5
        Me.btnGuardarCaja.Text = "GUARDAR"
        Me.btnGuardarCaja.UseVisualStyleBackColor = True
        '
        'txtStickerCaja
        '
        Me.txtStickerCaja.Location = New System.Drawing.Point(7, 37)
        Me.txtStickerCaja.Name = "txtStickerCaja"
        Me.txtStickerCaja.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerCaja.TabIndex = 10
        '
        'cmbEstadoCaja
        '
        Me.cmbEstadoCaja.DisplayMember = "SELECCIONAR ESTADO"
        Me.cmbEstadoCaja.FormattingEnabled = True
        Me.cmbEstadoCaja.Items.AddRange(New Object() {"ACTIVO", "DESACTIVO"})
        Me.cmbEstadoCaja.Location = New System.Drawing.Point(377, 37)
        Me.cmbEstadoCaja.Name = "cmbEstadoCaja"
        Me.cmbEstadoCaja.Size = New System.Drawing.Size(114, 23)
        Me.cmbEstadoCaja.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(327, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "ELIMINAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(193, 66)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "MODIFICAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtObservacionCaja
        '
        Me.txtObservacionCaja.Location = New System.Drawing.Point(250, 37)
        Me.txtObservacionCaja.Name = "txtObservacionCaja"
        Me.txtObservacionCaja.Size = New System.Drawing.Size(100, 23)
        Me.txtObservacionCaja.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STICKER"
        '
        'txtUbicacionCaja
        '
        Me.txtUbicacionCaja.Location = New System.Drawing.Point(131, 37)
        Me.txtUbicacionCaja.Name = "txtUbicacionCaja"
        Me.txtUbicacionCaja.Size = New System.Drawing.Size(100, 23)
        Me.txtUbicacionCaja.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UBICACION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "OBSERVACIONES"
        '
        'dgvBolsa
        '
        Me.dgvBolsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBolsa.Location = New System.Drawing.Point(3, 107)
        Me.dgvBolsa.Name = "dgvBolsa"
        Me.dgvBolsa.RowTemplate.Height = 25
        Me.dgvBolsa.Size = New System.Drawing.Size(546, 151)
        Me.dgvBolsa.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvBolsa)
        Me.GroupBox2.Controls.Add(Me.cmbEstadoBolsa)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbCajas)
        Me.GroupBox2.Controls.Add(Me.txtStickerBolsa)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnGuardarBolsa)
        Me.GroupBox2.Location = New System.Drawing.Point(546, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 268)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestion de bolsas"
        '
        'cmbEstadoBolsa
        '
        Me.cmbEstadoBolsa.DisplayMember = "SELECCIONAR ESTADO"
        Me.cmbEstadoBolsa.FormattingEnabled = True
        Me.cmbEstadoBolsa.Items.AddRange(New Object() {"ACTIVO", "DESACTIVO"})
        Me.cmbEstadoBolsa.Location = New System.Drawing.Point(355, 37)
        Me.cmbEstadoBolsa.Name = "cmbEstadoBolsa"
        Me.cmbEstadoBolsa.Size = New System.Drawing.Size(114, 23)
        Me.cmbEstadoBolsa.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CAJA"
        '
        'cmbCajas
        '
        Me.cmbCajas.FormattingEnabled = True
        Me.cmbCajas.Location = New System.Drawing.Point(211, 37)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(121, 23)
        Me.cmbCajas.TabIndex = 13
        '
        'txtStickerBolsa
        '
        Me.txtStickerBolsa.Location = New System.Drawing.Point(80, 37)
        Me.txtStickerBolsa.Name = "txtStickerBolsa"
        Me.txtStickerBolsa.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerBolsa.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(376, 66)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "ELIMINAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(226, 66)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "MODIFICAR"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "STICKER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ESTADO"
        '
        'btnGuardarBolsa
        '
        Me.btnGuardarBolsa.Location = New System.Drawing.Point(105, 66)
        Me.btnGuardarBolsa.Name = "btnGuardarBolsa"
        Me.btnGuardarBolsa.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarBolsa.TabIndex = 5
        Me.btnGuardarBolsa.Text = "GUARDAR"
        Me.btnGuardarBolsa.UseVisualStyleBackColor = True
        '
        'dgvCarpeta
        '
        Me.dgvCarpeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarpeta.Location = New System.Drawing.Point(9, 121)
        Me.dgvCarpeta.Name = "dgvCarpeta"
        Me.dgvCarpeta.RowTemplate.Height = 25
        Me.dgvCarpeta.Size = New System.Drawing.Size(495, 178)
        Me.dgvCarpeta.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbBolsas)
        Me.GroupBox3.Controls.Add(Me.dgvCarpeta)
        Me.GroupBox3.Controls.Add(Me.txtAletaCarpeta)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cmbEstadoCarpeta)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtStickerCarpeta)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.Button12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnGuardarCarpeta)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 305)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestion de carpetas"
        '
        'cmbBolsas
        '
        Me.cmbBolsas.FormattingEnabled = True
        Me.cmbBolsas.Location = New System.Drawing.Point(18, 53)
        Me.cmbBolsas.Name = "cmbBolsas"
        Me.cmbBolsas.Size = New System.Drawing.Size(87, 23)
        Me.cmbBolsas.TabIndex = 13
        '
        'txtAletaCarpeta
        '
        Me.txtAletaCarpeta.Location = New System.Drawing.Point(253, 53)
        Me.txtAletaCarpeta.Name = "txtAletaCarpeta"
        Me.txtAletaCarpeta.Size = New System.Drawing.Size(100, 23)
        Me.txtAletaCarpeta.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(253, 32)
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
        Me.cmbEstadoCarpeta.Location = New System.Drawing.Point(379, 53)
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
        'txtStickerCarpeta
        '
        Me.txtStickerCarpeta.Location = New System.Drawing.Point(124, 53)
        Me.txtStickerCarpeta.Name = "txtStickerCarpeta"
        Me.txtStickerCarpeta.Size = New System.Drawing.Size(100, 23)
        Me.txtStickerCarpeta.TabIndex = 10
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(320, 92)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 6
        Me.Button11.Text = "ELIMINAR"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(190, 92)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(97, 23)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "MODIFICAR"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(124, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "STICKER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(379, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ESTADO"
        '
        'btnGuardarCarpeta
        '
        Me.btnGuardarCarpeta.Location = New System.Drawing.Point(72, 92)
        Me.btnGuardarCarpeta.Name = "btnGuardarCarpeta"
        Me.btnGuardarCarpeta.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarCarpeta.TabIndex = 5
        Me.btnGuardarCarpeta.Text = "GUARDAR"
        Me.btnGuardarCarpeta.UseVisualStyleBackColor = True
        '
        'DCajaBindingSource
        '
        Me.DCajaBindingSource.DataSource = GetType(PruebaTecnicaDesarrollo.DCaja)
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 26)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1122, 699)
        Me.TabControl2.TabIndex = 15
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1114, 671)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Getion Data"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1114, 671)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Reportes"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.DataGridView2)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Location = New System.Drawing.Point(540, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(568, 347)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Documentos x Carpeta"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 18
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 51)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(556, 273)
        Me.DataGridView2.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(300, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "BUSCAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(75, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 15)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "STICKER CARPETA"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(528, 208)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Busqueda de documentos"
        '
        'FormularioPruebaTecnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 729)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "FormularioPruebaTecnica"
        Me.Text = "FormularioPruebaTecnica"
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBolsa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCarpeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents DCajaBindingSource As BindingSource
    Friend WithEvents txtAletaCarpeta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRutaDocumento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbEstadoDocumento As ComboBox
    Friend WithEvents cmbCarpeta As ComboBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox5 As GroupBox
End Class

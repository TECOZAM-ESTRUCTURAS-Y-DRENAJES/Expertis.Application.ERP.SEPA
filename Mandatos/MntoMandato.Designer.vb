<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoMandato
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim cmbIDTipoMandato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbTipoPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoMandato))
        Me.cttNMandato = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.lblNMandato = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbIDTipoMandato = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblIDTipoMandato = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbTipoPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.chbCaducado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chbPredeterminado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDClienteBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDClienteBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSuMandato = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSuMandato = New Solmicro.Expertis.Engine.UI.Label
        Me.txtLocalidadFirma = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblLocalidadFirma = New Solmicro.Expertis.Engine.UI.Label
        Me.FraDatosMandato = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.FraCliente = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulblPais = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblProvincia = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblPoblacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblCodPostal = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblRazonSocial = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraDatosBancariosClte = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblSwiftCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIBANCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.ulblSWIFTClte = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblIBANClte = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblDatosCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraProveedor = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulblPaisProv = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblProvinciaProv = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblPoblacionProv = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblCodPostalProv = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblRazonSocialProv = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraDatosBancarios = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblSWIFTProv = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIBANProv = New Solmicro.Expertis.Engine.UI.Label
        Me.ulblSWIFTProv = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblIBANProv = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraObservaciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtObservaciones = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.cmbIDTipoMandato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDatosMandato.SuspendLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraCliente.SuspendLayout()
        Me.FraDatosBancariosClte.SuspendLayout()
        Me.FraProveedor.SuspendLayout()
        Me.FraDatosBancarios.SuspendLayout()
        Me.FraObservaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.FraObservaciones)
        Me.MainPanel.Controls.Add(Me.FraDatosBancarios)
        Me.MainPanel.Controls.Add(Me.FraProveedor)
        Me.MainPanel.Controls.Add(Me.FraCliente)
        Me.MainPanel.Controls.Add(Me.FraDatosMandato)
        Me.MainPanel.Size = New System.Drawing.Size(802, 573)
        '
        'cttNMandato
        '
        Me.TryDataBinding(cttNMandato, New System.Windows.Forms.Binding("Text", Me, "NMandato", True))
        Me.cttNMandato.DisabledBackColor = System.Drawing.Color.White
        Me.cttNMandato.Enabled = False
        Me.cttNMandato.Location = New System.Drawing.Point(113, 20)
        Me.cttNMandato.Name = "cttNMandato"
        Me.cttNMandato.Size = New System.Drawing.Size(121, 23)
        Me.cttNMandato.TabIndex = 0
        '
        'lblNMandato
        '
        Me.lblNMandato.Location = New System.Drawing.Point(16, 25)
        Me.lblNMandato.Name = "lblNMandato"
        Me.lblNMandato.Size = New System.Drawing.Size(73, 13)
        Me.lblNMandato.TabIndex = 1
        Me.lblNMandato.Text = "Nº Mandato"
        '
        'cmbIDTipoMandato
        '
        Me.TryDataBinding(cmbIDTipoMandato, New System.Windows.Forms.Binding("Value", Me, "IDTipoMandato", True))
        cmbIDTipoMandato_DesignTimeLayout.LayoutString = resources.GetString("cmbIDTipoMandato_DesignTimeLayout.LayoutString")
        Me.cmbIDTipoMandato.DesignTimeLayout = cmbIDTipoMandato_DesignTimeLayout
        Me.cmbIDTipoMandato.DisabledBackColor = System.Drawing.Color.White
        Me.cmbIDTipoMandato.DisplayMember = "Text"
        Me.cmbIDTipoMandato.Location = New System.Drawing.Point(663, 18)
        Me.cmbIDTipoMandato.Name = "cmbIDTipoMandato"
        Me.cmbIDTipoMandato.SelectedIndex = -1
        Me.cmbIDTipoMandato.SelectedItem = Nothing
        Me.cmbIDTipoMandato.Size = New System.Drawing.Size(121, 21)
        Me.cmbIDTipoMandato.TabIndex = 2
        Me.cmbIDTipoMandato.ValueMember = "Value"
        '
        'lblIDTipoMandato
        '
        Me.lblIDTipoMandato.Location = New System.Drawing.Point(598, 24)
        Me.lblIDTipoMandato.Name = "lblIDTipoMandato"
        Me.lblIDTipoMandato.Size = New System.Drawing.Size(31, 13)
        Me.lblIDTipoMandato.TabIndex = 3
        Me.lblIDTipoMandato.Text = "Tipo"
        '
        'cmbTipoPago
        '
        Me.TryDataBinding(cmbTipoPago, New System.Windows.Forms.Binding("Value", Me, "TipoPago", True))
        cmbTipoPago_DesignTimeLayout.LayoutString = resources.GetString("cmbTipoPago_DesignTimeLayout.LayoutString")
        Me.cmbTipoPago.DesignTimeLayout = cmbTipoPago_DesignTimeLayout
        Me.cmbTipoPago.DisabledBackColor = System.Drawing.Color.White
        Me.cmbTipoPago.DisplayMember = "Text"
        Me.cmbTipoPago.Location = New System.Drawing.Point(663, 45)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.SelectedIndex = -1
        Me.cmbTipoPago.SelectedItem = Nothing
        Me.cmbTipoPago.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoPago.TabIndex = 3
        Me.cmbTipoPago.ValueMember = "Value"
        '
        'lblTipoPago
        '
        Me.lblTipoPago.Location = New System.Drawing.Point(598, 49)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(63, 13)
        Me.lblTipoPago.TabIndex = 5
        Me.lblTipoPago.Text = "Tipo Pago"
        '
        'clbFecha
        '
        Me.TryDataBinding(clbFecha, New System.Windows.Forms.Binding("BindableValue", Me, "Fecha", True))
        Me.clbFecha.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha.Location = New System.Drawing.Point(292, 22)
        Me.clbFecha.Name = "clbFecha"
        Me.clbFecha.Size = New System.Drawing.Size(121, 21)
        Me.clbFecha.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(247, 26)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Fecha"
        '
        'chbCaducado
        '
        Me.chbCaducado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(chbCaducado, New System.Windows.Forms.Binding("BindableValue", Me, "Caducado", True))
        Me.chbCaducado.Location = New System.Drawing.Point(663, 71)
        Me.chbCaducado.Name = "chbCaducado"
        Me.chbCaducado.Size = New System.Drawing.Size(120, 15)
        Me.chbCaducado.TabIndex = 4
        Me.chbCaducado.Text = "Caducado"
        '
        'chbPredeterminado
        '
        Me.chbPredeterminado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(chbPredeterminado, New System.Windows.Forms.Binding("BindableValue", Me, "Predeterminado", True))
        Me.chbPredeterminado.Location = New System.Drawing.Point(663, 90)
        Me.chbPredeterminado.Name = "chbPredeterminado"
        Me.chbPredeterminado.Size = New System.Drawing.Size(120, 15)
        Me.chbPredeterminado.TabIndex = 5
        Me.chbPredeterminado.Text = "Predeterminado"
        '
        'advIDCliente
        '
        Me.TryDataBinding(advIDCliente, New System.Windows.Forms.Binding("Text", Me, "IDCliente", True))
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(84, 22)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.PrimaryDataFields = "IDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(121, 23)
        Me.advIDCliente.TabIndex = 0
        '
        'lblIDCliente
        '
        Me.lblIDCliente.Location = New System.Drawing.Point(16, 27)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblIDCliente.TabIndex = 13
        Me.lblIDCliente.Text = "Cliente"
        '
        'advIDProveedor
        '
        Me.TryDataBinding(advIDProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(84, 19)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(121, 23)
        Me.advIDProveedor.TabIndex = 0
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.Location = New System.Drawing.Point(16, 24)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblIDProveedor.TabIndex = 17
        Me.lblIDProveedor.Text = "Proveedor"
        '
        'advIDClienteBanco
        '
        Me.TryDataBinding(advIDClienteBanco, New System.Windows.Forms.Binding("Text", Me, "IDClienteBanco", True))
        Me.advIDClienteBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advIDClienteBanco.Enabled = False
        Me.advIDClienteBanco.EntityName = "ClienteBanco"
        Me.advIDClienteBanco.Location = New System.Drawing.Point(84, 16)
        Me.advIDClienteBanco.Name = "advIDClienteBanco"
        Me.advIDClienteBanco.PrimaryDataFields = "IDClienteBanco"
        Me.advIDClienteBanco.SecondaryDataFields = "IDClienteBanco"
        Me.advIDClienteBanco.Size = New System.Drawing.Size(121, 23)
        Me.advIDClienteBanco.TabIndex = 0
        '
        'lblIDClienteBanco
        '
        Me.lblIDClienteBanco.Location = New System.Drawing.Point(16, 21)
        Me.lblIDClienteBanco.Name = "lblIDClienteBanco"
        Me.lblIDClienteBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblIDClienteBanco.TabIndex = 19
        Me.lblIDClienteBanco.Text = "Banco"
        '
        'advIDBancoPropio
        '
        Me.TryDataBinding(advIDBancoPropio, New System.Windows.Forms.Binding("Text", Me, "IDBancoPropio", True))
        Me.advIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBancoPropio.Enabled = False
        Me.advIDBancoPropio.EntityName = "BancoPropio"
        Me.advIDBancoPropio.Location = New System.Drawing.Point(84, 20)
        Me.advIDBancoPropio.Name = "advIDBancoPropio"
        Me.advIDBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.advIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.advIDBancoPropio.Size = New System.Drawing.Size(121, 23)
        Me.advIDBancoPropio.TabIndex = 0
        '
        'lblIDBancoPropio
        '
        Me.lblIDBancoPropio.Location = New System.Drawing.Point(13, 25)
        Me.lblIDBancoPropio.Name = "lblIDBancoPropio"
        Me.lblIDBancoPropio.Size = New System.Drawing.Size(42, 13)
        Me.lblIDBancoPropio.TabIndex = 21
        Me.lblIDBancoPropio.Text = "Banco"
        '
        'txtSuMandato
        '
        Me.TryDataBinding(txtSuMandato, New System.Windows.Forms.Binding("Text", Me, "SuMandato", True))
        Me.txtSuMandato.DisabledBackColor = System.Drawing.Color.White
        Me.txtSuMandato.Enabled = False
        Me.txtSuMandato.Location = New System.Drawing.Point(668, 20)
        Me.txtSuMandato.Name = "txtSuMandato"
        Me.txtSuMandato.Size = New System.Drawing.Size(121, 21)
        Me.txtSuMandato.TabIndex = 1
        '
        'lblSuMandato
        '
        Me.lblSuMandato.Location = New System.Drawing.Point(592, 24)
        Me.lblSuMandato.Name = "lblSuMandato"
        Me.lblSuMandato.Size = New System.Drawing.Size(74, 13)
        Me.lblSuMandato.TabIndex = 23
        Me.lblSuMandato.Text = "Su Mandato"
        '
        'txtLocalidadFirma
        '
        Me.TryDataBinding(txtLocalidadFirma, New System.Windows.Forms.Binding("Text", Me, "LocalidadFirma", True))
        Me.txtLocalidadFirma.DisabledBackColor = System.Drawing.Color.White
        Me.txtLocalidadFirma.Location = New System.Drawing.Point(113, 82)
        Me.txtLocalidadFirma.Name = "txtLocalidadFirma"
        Me.txtLocalidadFirma.Size = New System.Drawing.Size(412, 21)
        Me.txtLocalidadFirma.TabIndex = 6
        '
        'lblLocalidadFirma
        '
        Me.lblLocalidadFirma.Location = New System.Drawing.Point(16, 86)
        Me.lblLocalidadFirma.Name = "lblLocalidadFirma"
        Me.lblLocalidadFirma.Size = New System.Drawing.Size(96, 13)
        Me.lblLocalidadFirma.TabIndex = 25
        Me.lblLocalidadFirma.Text = "Localidad Firma"
        '
        'FraDatosMandato
        '
        Me.FraDatosMandato.Controls.Add(Me.cmbEstado)
        Me.FraDatosMandato.Controls.Add(Me.lblEstado)
        Me.FraDatosMandato.Controls.Add(Me.cmbIDTipoMandato)
        Me.FraDatosMandato.Controls.Add(Me.txtLocalidadFirma)
        Me.FraDatosMandato.Controls.Add(Me.lblIDTipoMandato)
        Me.FraDatosMandato.Controls.Add(Me.lblLocalidadFirma)
        Me.FraDatosMandato.Controls.Add(Me.lblTipoPago)
        Me.FraDatosMandato.Controls.Add(Me.cmbTipoPago)
        Me.FraDatosMandato.Controls.Add(Me.chbCaducado)
        Me.FraDatosMandato.Controls.Add(Me.chbPredeterminado)
        Me.FraDatosMandato.Controls.Add(Me.cttNMandato)
        Me.FraDatosMandato.Controls.Add(Me.lblNMandato)
        Me.FraDatosMandato.Controls.Add(Me.lblFecha)
        Me.FraDatosMandato.Controls.Add(Me.clbFecha)
        Me.FraDatosMandato.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosMandato.Location = New System.Drawing.Point(0, 0)
        Me.FraDatosMandato.Name = "FraDatosMandato"
        Me.FraDatosMandato.Size = New System.Drawing.Size(802, 113)
        Me.FraDatosMandato.TabIndex = 26
        Me.FraDatosMandato.TabStop = False
        Me.FraDatosMandato.Text = "Datos Mandato"
        '
        'cmbEstado
        '
        Me.TryDataBinding(cmbEstado, New System.Windows.Forms.Binding("Value", Me, "Estado", True))
        cmbEstado_DesignTimeLayout.LayoutString = resources.GetString("cmbEstado_DesignTimeLayout.LayoutString")
        Me.cmbEstado.DesignTimeLayout = cmbEstado_DesignTimeLayout
        Me.cmbEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cmbEstado.DisplayMember = "Text"
        Me.cmbEstado.Location = New System.Drawing.Point(113, 49)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.SelectedIndex = -1
        Me.cmbEstado.SelectedItem = Nothing
        Me.cmbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstado.TabIndex = 26
        Me.cmbEstado.ValueMember = "Value"
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(16, 53)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 27
        Me.lblEstado.Text = "Estado"
        '
        'FraCliente
        '
        Me.FraCliente.Controls.Add(Me.ulblPais)
        Me.FraCliente.Controls.Add(Me.ulblProvincia)
        Me.FraCliente.Controls.Add(Me.ulblPoblacion)
        Me.FraCliente.Controls.Add(Me.ulblCodPostal)
        Me.FraCliente.Controls.Add(Me.ulblRazonSocial)
        Me.FraCliente.Controls.Add(Me.FraDatosBancariosClte)
        Me.FraCliente.Controls.Add(Me.ulblDatosCliente)
        Me.FraCliente.Controls.Add(Me.advIDCliente)
        Me.FraCliente.Controls.Add(Me.lblIDCliente)
        Me.FraCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraCliente.Location = New System.Drawing.Point(0, 113)
        Me.FraCliente.Name = "FraCliente"
        Me.FraCliente.Size = New System.Drawing.Size(802, 204)
        Me.FraCliente.TabIndex = 0
        Me.FraCliente.TabStop = False
        Me.FraCliente.Text = "Datos Cliente"
        '
        'ulblPais
        '
        Me.TryDataBinding(ulblPais, New System.Windows.Forms.Binding("Text", Me.advIDCliente, "DescPais", True))
        Me.ulblPais.Location = New System.Drawing.Point(641, 83)
        Me.ulblPais.Name = "ulblPais"
        Me.ulblPais.Size = New System.Drawing.Size(139, 23)
        Me.ulblPais.TabIndex = 27
        '
        'ulblProvincia
        '
        Me.TryDataBinding(ulblProvincia, New System.Windows.Forms.Binding("Text", Me.advIDCliente, "Provincia", True))
        Me.ulblProvincia.Location = New System.Drawing.Point(375, 83)
        Me.ulblProvincia.Name = "ulblProvincia"
        Me.ulblProvincia.Size = New System.Drawing.Size(253, 23)
        Me.ulblProvincia.TabIndex = 26
        '
        'ulblPoblacion
        '
        Me.TryDataBinding(ulblPoblacion, New System.Windows.Forms.Binding("Text", Me.advIDCliente, "Poblacion", True))
        Me.ulblPoblacion.Location = New System.Drawing.Point(115, 83)
        Me.ulblPoblacion.Name = "ulblPoblacion"
        Me.ulblPoblacion.Size = New System.Drawing.Size(253, 23)
        Me.ulblPoblacion.TabIndex = 25
        '
        'ulblCodPostal
        '
        Me.TryDataBinding(ulblCodPostal, New System.Windows.Forms.Binding("Text", Me.advIDCliente, "CodPostal", True))
        Me.ulblCodPostal.Location = New System.Drawing.Point(16, 83)
        Me.ulblCodPostal.Name = "ulblCodPostal"
        Me.ulblCodPostal.Size = New System.Drawing.Size(90, 23)
        Me.ulblCodPostal.TabIndex = 24
        '
        'ulblRazonSocial
        '
        Me.TryDataBinding(ulblRazonSocial, New System.Windows.Forms.Binding("Text", Me.advIDCliente, "RazonSocial", True))
        Me.ulblRazonSocial.Location = New System.Drawing.Point(16, 50)
        Me.ulblRazonSocial.Name = "ulblRazonSocial"
        Me.ulblRazonSocial.Size = New System.Drawing.Size(765, 23)
        Me.ulblRazonSocial.TabIndex = 23
        '
        'FraDatosBancariosClte
        '
        Me.FraDatosBancariosClte.Controls.Add(Me.lblSwiftCliente)
        Me.FraDatosBancariosClte.Controls.Add(Me.lblIBANCliente)
        Me.FraDatosBancariosClte.Controls.Add(Me.ulblSWIFTClte)
        Me.FraDatosBancariosClte.Controls.Add(Me.ulblIBANClte)
        Me.FraDatosBancariosClte.Controls.Add(Me.lblIDClienteBanco)
        Me.FraDatosBancariosClte.Controls.Add(Me.advIDClienteBanco)
        Me.FraDatosBancariosClte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraDatosBancariosClte.Location = New System.Drawing.Point(3, 118)
        Me.FraDatosBancariosClte.Name = "FraDatosBancariosClte"
        Me.FraDatosBancariosClte.Size = New System.Drawing.Size(796, 83)
        Me.FraDatosBancariosClte.TabIndex = 1
        Me.FraDatosBancariosClte.TabStop = False
        Me.FraDatosBancariosClte.Text = "Datos Bancarios"
        '
        'lblSwiftCliente
        '
        Me.lblSwiftCliente.Location = New System.Drawing.Point(278, 53)
        Me.lblSwiftCliente.Name = "lblSwiftCliente"
        Me.lblSwiftCliente.Size = New System.Drawing.Size(44, 13)
        Me.lblSwiftCliente.TabIndex = 29
        Me.lblSwiftCliente.Text = "SWIFT"
        '
        'lblIBANCliente
        '
        Me.lblIBANCliente.Location = New System.Drawing.Point(278, 22)
        Me.lblIBANCliente.Name = "lblIBANCliente"
        Me.lblIBANCliente.Size = New System.Drawing.Size(36, 13)
        Me.lblIBANCliente.TabIndex = 28
        Me.lblIBANCliente.Text = "IBAN"
        '
        'ulblSWIFTClte
        '
        Me.TryDataBinding(ulblSWIFTClte, New System.Windows.Forms.Binding("Text", Me.advIDClienteBanco, "SWIFT", True))
        Me.ulblSWIFTClte.Location = New System.Drawing.Point(348, 48)
        Me.ulblSWIFTClte.Name = "ulblSWIFTClte"
        Me.ulblSWIFTClte.Size = New System.Drawing.Size(429, 23)
        Me.ulblSWIFTClte.TabIndex = 27
        '
        'ulblIBANClte
        '
        Me.TryDataBinding(ulblIBANClte, New System.Windows.Forms.Binding("Text", Me.advIDClienteBanco, "CodigoIBAN", True))
        Me.ulblIBANClte.Location = New System.Drawing.Point(348, 17)
        Me.ulblIBANClte.Name = "ulblIBANClte"
        Me.ulblIBANClte.Size = New System.Drawing.Size(429, 23)
        Me.ulblIBANClte.TabIndex = 26
        '
        'ulblDatosCliente
        '
        Me.TryDataBinding(ulblDatosCliente, New System.Windows.Forms.Binding("Text", Me.advIDCliente, "DescCliente", True))
        Me.ulblDatosCliente.Location = New System.Drawing.Point(211, 22)
        Me.ulblDatosCliente.Name = "ulblDatosCliente"
        Me.ulblDatosCliente.Size = New System.Drawing.Size(572, 23)
        Me.ulblDatosCliente.TabIndex = 20
        '
        'FraProveedor
        '
        Me.FraProveedor.Controls.Add(Me.ulblPaisProv)
        Me.FraProveedor.Controls.Add(Me.ulblProvinciaProv)
        Me.FraProveedor.Controls.Add(Me.ulblPoblacionProv)
        Me.FraProveedor.Controls.Add(Me.ulblCodPostalProv)
        Me.FraProveedor.Controls.Add(Me.ulblRazonSocialProv)
        Me.FraProveedor.Controls.Add(Me.ulblDescProveedor)
        Me.FraProveedor.Controls.Add(Me.lblIDProveedor)
        Me.FraProveedor.Controls.Add(Me.advIDProveedor)
        Me.FraProveedor.Controls.Add(Me.txtSuMandato)
        Me.FraProveedor.Controls.Add(Me.lblSuMandato)
        Me.FraProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraProveedor.Location = New System.Drawing.Point(0, 317)
        Me.FraProveedor.Name = "FraProveedor"
        Me.FraProveedor.Size = New System.Drawing.Size(802, 122)
        Me.FraProveedor.TabIndex = 1
        Me.FraProveedor.TabStop = False
        Me.FraProveedor.Text = "Datos Proveedor"
        '
        'ulblPaisProv
        '
        Me.TryDataBinding(ulblPaisProv, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "DescPais", True))
        Me.ulblPaisProv.Location = New System.Drawing.Point(634, 85)
        Me.ulblPaisProv.Name = "ulblPaisProv"
        Me.ulblPaisProv.Size = New System.Drawing.Size(155, 23)
        Me.ulblPaisProv.TabIndex = 32
        '
        'ulblProvinciaProv
        '
        Me.TryDataBinding(ulblProvinciaProv, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "Provincia", True))
        Me.ulblProvinciaProv.Location = New System.Drawing.Point(375, 85)
        Me.ulblProvinciaProv.Name = "ulblProvinciaProv"
        Me.ulblProvinciaProv.Size = New System.Drawing.Size(253, 23)
        Me.ulblProvinciaProv.TabIndex = 31
        '
        'ulblPoblacionProv
        '
        Me.TryDataBinding(ulblPoblacionProv, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "Poblacion", True))
        Me.ulblPoblacionProv.Location = New System.Drawing.Point(115, 85)
        Me.ulblPoblacionProv.Name = "ulblPoblacionProv"
        Me.ulblPoblacionProv.Size = New System.Drawing.Size(253, 23)
        Me.ulblPoblacionProv.TabIndex = 30
        '
        'ulblCodPostalProv
        '
        Me.TryDataBinding(ulblCodPostalProv, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "CodPostal", True))
        Me.ulblCodPostalProv.Location = New System.Drawing.Point(16, 85)
        Me.ulblCodPostalProv.Name = "ulblCodPostalProv"
        Me.ulblCodPostalProv.Size = New System.Drawing.Size(90, 23)
        Me.ulblCodPostalProv.TabIndex = 2
        '
        'ulblRazonSocialProv
        '
        Me.TryDataBinding(ulblRazonSocialProv, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "RazonSocial", True))
        Me.ulblRazonSocialProv.Location = New System.Drawing.Point(16, 51)
        Me.ulblRazonSocialProv.Name = "ulblRazonSocialProv"
        Me.ulblRazonSocialProv.Size = New System.Drawing.Size(768, 23)
        Me.ulblRazonSocialProv.TabIndex = 28
        '
        'ulblDescProveedor
        '
        Me.TryDataBinding(ulblDescProveedor, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "DescProveedor", True))
        Me.ulblDescProveedor.Location = New System.Drawing.Point(211, 19)
        Me.ulblDescProveedor.Name = "ulblDescProveedor"
        Me.ulblDescProveedor.Size = New System.Drawing.Size(369, 23)
        Me.ulblDescProveedor.TabIndex = 25
        '
        'FraDatosBancarios
        '
        Me.FraDatosBancarios.Controls.Add(Me.lblSWIFTProv)
        Me.FraDatosBancarios.Controls.Add(Me.lblIBANProv)
        Me.FraDatosBancarios.Controls.Add(Me.ulblSWIFTProv)
        Me.FraDatosBancarios.Controls.Add(Me.ulblIBANProv)
        Me.FraDatosBancarios.Controls.Add(Me.ulblDescBancoPropio)
        Me.FraDatosBancarios.Controls.Add(Me.advIDBancoPropio)
        Me.FraDatosBancarios.Controls.Add(Me.lblIDBancoPropio)
        Me.FraDatosBancarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosBancarios.Location = New System.Drawing.Point(0, 439)
        Me.FraDatosBancarios.Name = "FraDatosBancarios"
        Me.FraDatosBancarios.Size = New System.Drawing.Size(802, 86)
        Me.FraDatosBancarios.TabIndex = 1
        Me.FraDatosBancarios.TabStop = False
        Me.FraDatosBancarios.Text = "Datos Bancarios"
        '
        'lblSWIFTProv
        '
        Me.lblSWIFTProv.Location = New System.Drawing.Point(417, 52)
        Me.lblSWIFTProv.Name = "lblSWIFTProv"
        Me.lblSWIFTProv.Size = New System.Drawing.Size(44, 13)
        Me.lblSWIFTProv.TabIndex = 33
        Me.lblSWIFTProv.Text = "SWIFT"
        '
        'lblIBANProv
        '
        Me.lblIBANProv.Location = New System.Drawing.Point(13, 52)
        Me.lblIBANProv.Name = "lblIBANProv"
        Me.lblIBANProv.Size = New System.Drawing.Size(36, 13)
        Me.lblIBANProv.TabIndex = 32
        Me.lblIBANProv.Text = "IBAN"
        '
        'ulblSWIFTProv
        '
        Me.TryDataBinding(ulblSWIFTProv, New System.Windows.Forms.Binding("Text", Me.advIDBancoPropio, "SWIFT", True))
        Me.ulblSWIFTProv.Location = New System.Drawing.Point(467, 47)
        Me.ulblSWIFTProv.Name = "ulblSWIFTProv"
        Me.ulblSWIFTProv.Size = New System.Drawing.Size(313, 23)
        Me.ulblSWIFTProv.TabIndex = 31
        '
        'ulblIBANProv
        '
        Me.TryDataBinding(ulblIBANProv, New System.Windows.Forms.Binding("Text", Me.advIDBancoPropio, "CodigoIBAN", True))
        Me.ulblIBANProv.Location = New System.Drawing.Point(86, 47)
        Me.ulblIBANProv.Name = "ulblIBANProv"
        Me.ulblIBANProv.Size = New System.Drawing.Size(310, 23)
        Me.ulblIBANProv.TabIndex = 30
        '
        'ulblDescBancoPropio
        '
        Me.TryDataBinding(ulblDescBancoPropio, New System.Windows.Forms.Binding("Text", Me.advIDBancoPropio, "DescBancoPropio", True))
        Me.ulblDescBancoPropio.Location = New System.Drawing.Point(211, 21)
        Me.ulblDescBancoPropio.Name = "ulblDescBancoPropio"
        Me.ulblDescBancoPropio.Size = New System.Drawing.Size(569, 23)
        Me.ulblDescBancoPropio.TabIndex = 22
        '
        'FraObservaciones
        '
        Me.FraObservaciones.Controls.Add(Me.txtObservaciones)
        Me.FraObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraObservaciones.Location = New System.Drawing.Point(0, 525)
        Me.FraObservaciones.Name = "FraObservaciones"
        Me.FraObservaciones.Size = New System.Drawing.Size(802, 48)
        Me.FraObservaciones.TabIndex = 27
        Me.FraObservaciones.TabStop = False
        Me.FraObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.TryDataBinding(txtObservaciones, New System.Windows.Forms.Binding("Text", Me, "Observaciones", True))
        Me.txtObservaciones.DisabledBackColor = System.Drawing.Color.White
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Location = New System.Drawing.Point(3, 17)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(796, 28)
        Me.txtObservaciones.TabIndex = 0
        '
        'MntoMandato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 646)
        Me.EntityName = "Mandato"
        Me.FindTextField = "NMandato"
        Me.Name = "MntoMandato"
        Me.NavigationFields = "NMandato"
        Me.Text = "Mantenimiento de Mandatos"
        Me.ViewName = "tbMaestroMandato"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.cmbIDTipoMandato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDatosMandato.ResumeLayout(False)
        Me.FraDatosMandato.PerformLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraCliente.ResumeLayout(False)
        Me.FraCliente.PerformLayout()
        Me.FraDatosBancariosClte.ResumeLayout(False)
        Me.FraDatosBancariosClte.PerformLayout()
        Me.FraProveedor.ResumeLayout(False)
        Me.FraProveedor.PerformLayout()
        Me.FraDatosBancarios.ResumeLayout(False)
        Me.FraDatosBancarios.PerformLayout()
        Me.FraObservaciones.ResumeLayout(False)
        Me.FraObservaciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clbFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbTipoPago As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbIDTipoMandato As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblIDTipoMandato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cttNMandato As Solmicro.Expertis.Engine.UI.CounterTextBox
    Friend WithEvents lblNMandato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtLocalidadFirma As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblLocalidadFirma As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtSuMandato As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblSuMandato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDClienteBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDClienteBanco As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbPredeterminado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chbCaducado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents FraProveedor As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraCliente As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraDatosMandato As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ulblDatosCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FraDatosBancariosClte As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraDatosBancarios As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ulblDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblPais As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblProvincia As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblPoblacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblCodPostal As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblRazonSocial As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblIBANCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulblSWIFTClte As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblIBANClte As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblPaisProv As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblProvinciaProv As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblPoblacionProv As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblCodPostalProv As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblRazonSocialProv As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblSWIFTProv As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIBANProv As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulblSWIFTProv As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulblIBANProv As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblSwiftCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraObservaciones As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtObservaciones As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cmbEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
End Class

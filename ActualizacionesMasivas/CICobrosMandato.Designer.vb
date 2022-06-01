<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CICobrosMandato
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICobrosMandato))
        Dim cbxIDFormaPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFacturaD = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFacturaH = New Solmicro.Expertis.Engine.UI.Label
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.nbxImpHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.nbxImpDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxFechaFacturaD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaFacturaH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxIDFormaPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxIDBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblMandato = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDMandato = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvRemesa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblRemesa)
        Me.FilterPanel.Controls.Add(Me.AdvRemesa)
        Me.FilterPanel.Controls.Add(Me.lblMandato)
        Me.FilterPanel.Controls.Add(Me.AdvIDMandato)
        Me.FilterPanel.Controls.Add(Me.lblTitulo)
        Me.FilterPanel.Controls.Add(Me.lblFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.lblFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblFormaPago)
        Me.FilterPanel.Controls.Add(Me.lblImporteDesde)
        Me.FilterPanel.Controls.Add(Me.lblImporteHasta)
        Me.FilterPanel.Controls.Add(Me.lblBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblSituacion)
        Me.FilterPanel.Controls.Add(Me.txtTitulo)
        Me.FilterPanel.Controls.Add(Me.nbxImpHasta)
        Me.FilterPanel.Controls.Add(Me.nbxImpDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.cbxContabilizado)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvIDCliente)
        Me.FilterPanel.Controls.Add(Me.cbxIDFormaPago)
        Me.FilterPanel.Controls.Add(Me.cbxIDBancoPropio)
        Me.FilterPanel.Controls.Add(Me.cbxSituacion)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 304)
        Me.FilterPanel.Size = New System.Drawing.Size(836, 114)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(836, 304)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NMandato", "Mandato", "NMandato", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDMandato", "IDMandato")}))})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Cobro"
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDCobro"
        Me.Grid.PrimaryDataFields = "IDCobro"
        Me.Grid.SecondaryDataFields = "IDCobro"
        Me.Grid.Size = New System.Drawing.Size(836, 304)
        Me.Grid.ViewName = "vSEPA_frmCobrosMandato"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(316, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(836, 418)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(836, 418)
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(3, 91)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(38, 13)
        Me.lblTitulo.TabIndex = 95
        Me.lblTitulo.Text = "Título"
        '
        'lblFechaFacturaD
        '
        Me.lblFechaFacturaD.Location = New System.Drawing.Point(290, 69)
        Me.lblFechaFacturaD.Name = "lblFechaFacturaD"
        Me.lblFechaFacturaD.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaFacturaD.TabIndex = 83
        Me.lblFechaFacturaD.Text = "F. Factura >="
        '
        'lblFechaFacturaH
        '
        Me.lblFechaFacturaH.Location = New System.Drawing.Point(290, 92)
        Me.lblFechaFacturaH.Name = "lblFechaFacturaH"
        Me.lblFechaFacturaH.Size = New System.Drawing.Size(81, 13)
        Me.lblFechaFacturaH.TabIndex = 84
        Me.lblFechaFacturaH.Text = "F.Factura <="
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(651, 69)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.lblContabilizado.TabIndex = 85
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Contabilizado"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(290, 47)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(99, 13)
        Me.lblFechaHasta.TabIndex = 86
        Me.lblFechaHasta.Tag = "IdRec=4779;"
        Me.lblFechaHasta.Text = "Vencimiento <="
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(290, 25)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(99, 13)
        Me.lblFechaDesde.TabIndex = 87
        Me.lblFechaDesde.Tag = "IdRec=4777;"
        Me.lblFechaDesde.Text = "Vencimiento >="
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(3, 34)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 88
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(651, 47)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFormaPago.TabIndex = 89
        Me.lblFormaPago.Tag = "IdRec=4758;"
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'lblImporteDesde
        '
        Me.lblImporteDesde.Location = New System.Drawing.Point(467, 25)
        Me.lblImporteDesde.Name = "lblImporteDesde"
        Me.lblImporteDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImporteDesde.TabIndex = 90
        Me.lblImporteDesde.Tag = "IdRec=4778;"
        Me.lblImporteDesde.Text = "Importe >="
        '
        'lblImporteHasta
        '
        Me.lblImporteHasta.Location = New System.Drawing.Point(467, 47)
        Me.lblImporteHasta.Name = "lblImporteHasta"
        Me.lblImporteHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblImporteHasta.TabIndex = 91
        Me.lblImporteHasta.Tag = "IdRec=4780;"
        Me.lblImporteHasta.Text = "Importe <="
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(651, 25)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 92
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'lblSituacion
        '
        Me.lblSituacion.Location = New System.Drawing.Point(651, 92)
        Me.lblSituacion.Name = "lblSituacion"
        Me.lblSituacion.Size = New System.Drawing.Size(59, 13)
        Me.lblSituacion.TabIndex = 93
        Me.lblSituacion.Tag = "IdRec=4781;"
        Me.lblSituacion.Text = "Situación"
        '
        'txtTitulo
        '
        Me.txtTitulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(59, 87)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(225, 21)
        Me.txtTitulo.TabIndex = 2
        '
        'nbxImpHasta
        '
        Me.nbxImpHasta.DisabledBackColor = System.Drawing.Color.White
        Me.nbxImpHasta.Location = New System.Drawing.Point(543, 43)
        Me.nbxImpHasta.Name = "nbxImpHasta"
        Me.nbxImpHasta.Size = New System.Drawing.Size(91, 21)
        Me.nbxImpHasta.TabIndex = 8
        '
        'nbxImpDesde
        '
        Me.nbxImpDesde.DisabledBackColor = System.Drawing.Color.White
        Me.nbxImpDesde.Location = New System.Drawing.Point(543, 21)
        Me.nbxImpDesde.Name = "nbxImpDesde"
        Me.nbxImpDesde.Size = New System.Drawing.Size(91, 21)
        Me.nbxImpDesde.TabIndex = 7
        '
        'cbxFechaFacturaD
        '
        Me.cbxFechaFacturaD.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFacturaD.Location = New System.Drawing.Point(389, 65)
        Me.cbxFechaFacturaD.Name = "cbxFechaFacturaD"
        Me.cbxFechaFacturaD.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaFacturaD.TabIndex = 5
        '
        'cbxFechaFacturaH
        '
        Me.cbxFechaFacturaH.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFacturaH.Location = New System.Drawing.Point(389, 88)
        Me.cbxFechaFacturaH.Name = "cbxFechaFacturaH"
        Me.cbxFechaFacturaH.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaFacturaH.TabIndex = 6
        '
        'cbxContabilizado
        '
        cbxContabilizado_DesignTimeLayout.LayoutString = resources.GetString("cbxContabilizado_DesignTimeLayout.LayoutString")
        Me.cbxContabilizado.DesignTimeLayout = cbxContabilizado_DesignTimeLayout
        Me.cbxContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxContabilizado.Location = New System.Drawing.Point(739, 65)
        Me.cbxContabilizado.Name = "cbxContabilizado"
        Me.cbxContabilizado.SelectedIndex = -1
        Me.cbxContabilizado.SelectedItem = Nothing
        Me.cbxContabilizado.Size = New System.Drawing.Size(88, 21)
        Me.cbxContabilizado.TabIndex = 12
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(389, 43)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaHasta.TabIndex = 4
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(389, 21)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaDesde.TabIndex = 3
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(59, 29)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDCliente.TabIndex = 0
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'cbxIDFormaPago
        '
        cbxIDFormaPago_DesignTimeLayout.LayoutString = resources.GetString("cbxIDFormaPago_DesignTimeLayout.LayoutString")
        Me.cbxIDFormaPago.DesignTimeLayout = cbxIDFormaPago_DesignTimeLayout
        Me.cbxIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDFormaPago.DisplayMember = "IDFormaPago"
        Me.cbxIDFormaPago.EntityName = "FormaPago"
        Me.cbxIDFormaPago.Location = New System.Drawing.Point(739, 43)
        Me.cbxIDFormaPago.Name = "cbxIDFormaPago"
        Me.cbxIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.cbxIDFormaPago.SelectedIndex = -1
        Me.cbxIDFormaPago.SelectedItem = Nothing
        Me.cbxIDFormaPago.Size = New System.Drawing.Size(88, 21)
        Me.cbxIDFormaPago.TabIndex = 11
        Me.cbxIDFormaPago.ValueMember = "IDFormaPago"
        Me.cbxIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'cbxIDBancoPropio
        '
        cbxIDBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxIDBancoPropio.DesignTimeLayout = cbxIDBancoPropio_DesignTimeLayout
        Me.cbxIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDBancoPropio.DisplayMember = "DescBancoPropio"
        Me.cbxIDBancoPropio.EntityName = "BancoPropio"
        Me.cbxIDBancoPropio.Location = New System.Drawing.Point(739, 21)
        Me.cbxIDBancoPropio.Name = "cbxIDBancoPropio"
        Me.cbxIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxIDBancoPropio.SelectedIndex = -1
        Me.cbxIDBancoPropio.SelectedItem = Nothing
        Me.cbxIDBancoPropio.Size = New System.Drawing.Size(88, 21)
        Me.cbxIDBancoPropio.TabIndex = 10
        Me.cbxIDBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxIDBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'cbxSituacion
        '
        cbxSituacion_DesignTimeLayout.LayoutString = resources.GetString("cbxSituacion_DesignTimeLayout.LayoutString")
        Me.cbxSituacion.DesignTimeLayout = cbxSituacion_DesignTimeLayout
        Me.cbxSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSituacion.DisplayMember = "DescEstado"
        Me.cbxSituacion.EntityName = "EstadoCobro"
        Me.cbxSituacion.Location = New System.Drawing.Point(739, 88)
        Me.cbxSituacion.Name = "cbxSituacion"
        Me.cbxSituacion.SecondaryDataFields = "IDEstado"
        Me.cbxSituacion.SelectedIndex = -1
        Me.cbxSituacion.SelectedItem = Nothing
        Me.cbxSituacion.Size = New System.Drawing.Size(88, 21)
        Me.cbxSituacion.TabIndex = 13
        Me.cbxSituacion.ValueMember = "IDEstado"
        Me.cbxSituacion.ViewName = "tbMaestroEstadoCobro"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add2.ico")
        Me.ImageList1.Images.SetKeyName(1, "delete2.ico")
        '
        'lblMandato
        '
        Me.lblMandato.Location = New System.Drawing.Point(3, 63)
        Me.lblMandato.Name = "lblMandato"
        Me.lblMandato.Size = New System.Drawing.Size(55, 13)
        Me.lblMandato.TabIndex = 97
        Me.lblMandato.Tag = ""
        Me.lblMandato.Text = "Mandato"
        '
        'AdvIDMandato
        '
        Me.AdvIDMandato.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDMandato.DisplayField = "NMandato"
        Me.AdvIDMandato.EntityName = "Mandato"
        Me.AdvIDMandato.Location = New System.Drawing.Point(59, 58)
        Me.AdvIDMandato.Name = "AdvIDMandato"
        Me.AdvIDMandato.SecondaryDataFields = "IDMandato"
        Me.AdvIDMandato.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDMandato.TabIndex = 1
        Me.AdvIDMandato.ViewName = "tbMaestroMandato"
        '
        'lblRemesa
        '
        Me.lblRemesa.Location = New System.Drawing.Point(467, 69)
        Me.lblRemesa.Name = "lblRemesa"
        Me.lblRemesa.Size = New System.Drawing.Size(53, 13)
        Me.lblRemesa.TabIndex = 99
        Me.lblRemesa.Tag = ""
        Me.lblRemesa.Text = "Remesa"
        '
        'AdvRemesa
        '
        Me.AdvRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.AdvRemesa.EntityName = "Remesa"
        Me.AdvRemesa.Location = New System.Drawing.Point(543, 65)
        Me.AdvRemesa.Name = "AdvRemesa"
        Me.AdvRemesa.SecondaryDataFields = "IDRemesa"
        Me.AdvRemesa.Size = New System.Drawing.Size(91, 23)
        Me.AdvRemesa.TabIndex = 9
        '
        'CICobrosMandato
        '
        Me.AllowUpdate = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 506)
        Me.EntityName = "Cobro"
        Me.KeyField = "IDCobro"
        Me.Name = "CICobrosMandato"
        Me.Text = "Asignación de Mandatos"
        Me.ViewName = "vSEPA_frmCobrosMandato"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblTitulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaFacturaD As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaFacturaH As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImporteDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImporteHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblSituacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTitulo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents nbxImpHasta As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents nbxImpDesde As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cbxFechaFacturaD As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxFechaFacturaH As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents cbxIDFormaPago As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents lblMandato As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDMandato As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblRemesa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvRemesa As Solmicro.Expertis.Engine.UI.AdvSearch
End Class

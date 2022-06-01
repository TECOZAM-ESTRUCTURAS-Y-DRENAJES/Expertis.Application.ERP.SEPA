<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIMandatos
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
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbIDTipoMandato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIMandatos))
        Dim cmbTipoPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbIDTipoMandato = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblIDTipoMandato = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbTipoPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSep = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cmbIDTipoMandato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cbxFechaH)
        Me.FilterPanel.Controls.Add(Me.cbxFechaD)
        Me.FilterPanel.Controls.Add(Me.lblSep)
        Me.FilterPanel.Controls.Add(Me.lblFecha)
        Me.FilterPanel.Controls.Add(Me.cmbIDTipoMandato)
        Me.FilterPanel.Controls.Add(Me.lblIDTipoMandato)
        Me.FilterPanel.Controls.Add(Me.lblTipoPago)
        Me.FilterPanel.Controls.Add(Me.cmbTipoPago)
        Me.FilterPanel.Controls.Add(Me.advIDBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblIDBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblIDProveedor)
        Me.FilterPanel.Controls.Add(Me.advIDProveedor)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblIDCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 327)
        Me.FilterPanel.Size = New System.Drawing.Size(805, 96)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(805, 327)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Mandato"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Hierarchical = True
        Me.Grid.KeyField = "IDMandato"
        Me.Grid.PrimaryDataFields = "IDMandato"
        Me.Grid.SecondaryDataFields = "IDMandato"
        Me.Grid.Size = New System.Drawing.Size(805, 327)
        Me.Grid.ViewName = "vSEPA_CTLCIMandatos"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(805, 423)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(805, 423)
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(86, 31)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.PrimaryDataFields = "IDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(121, 23)
        Me.advIDCliente.TabIndex = 0
        '
        'lblIDCliente
        '
        Me.lblIDCliente.Location = New System.Drawing.Point(18, 36)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblIDCliente.TabIndex = 15
        Me.lblIDCliente.Text = "Cliente"
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.Location = New System.Drawing.Point(18, 65)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblIDProveedor.TabIndex = 19
        Me.lblIDProveedor.Text = "Proveedor"
        '
        'advIDProveedor
        '
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(86, 60)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(121, 23)
        Me.advIDProveedor.TabIndex = 1
        '
        'advIDBancoPropio
        '
        Me.advIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBancoPropio.EntityName = "BancoPropio"
        Me.advIDBancoPropio.Location = New System.Drawing.Point(308, 31)
        Me.advIDBancoPropio.Name = "advIDBancoPropio"
        Me.advIDBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.advIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.advIDBancoPropio.Size = New System.Drawing.Size(121, 23)
        Me.advIDBancoPropio.TabIndex = 2
        '
        'lblIDBancoPropio
        '
        Me.lblIDBancoPropio.Location = New System.Drawing.Point(258, 36)
        Me.lblIDBancoPropio.Name = "lblIDBancoPropio"
        Me.lblIDBancoPropio.Size = New System.Drawing.Size(42, 13)
        Me.lblIDBancoPropio.TabIndex = 23
        Me.lblIDBancoPropio.Text = "Banco"
        '
        'cmbIDTipoMandato
        '
        cmbIDTipoMandato_DesignTimeLayout.LayoutString = resources.GetString("cmbIDTipoMandato_DesignTimeLayout.LayoutString")
        Me.cmbIDTipoMandato.DesignTimeLayout = cmbIDTipoMandato_DesignTimeLayout
        Me.cmbIDTipoMandato.DisabledBackColor = System.Drawing.Color.White
        Me.cmbIDTipoMandato.DisplayMember = "Text"
        Me.cmbIDTipoMandato.Location = New System.Drawing.Point(676, 31)
        Me.cmbIDTipoMandato.Name = "cmbIDTipoMandato"
        Me.cmbIDTipoMandato.SelectedIndex = -1
        Me.cmbIDTipoMandato.SelectedItem = Nothing
        Me.cmbIDTipoMandato.Size = New System.Drawing.Size(121, 21)
        Me.cmbIDTipoMandato.TabIndex = 5
        Me.cmbIDTipoMandato.ValueMember = "Value"
        '
        'lblIDTipoMandato
        '
        Me.lblIDTipoMandato.Location = New System.Drawing.Point(611, 35)
        Me.lblIDTipoMandato.Name = "lblIDTipoMandato"
        Me.lblIDTipoMandato.Size = New System.Drawing.Size(31, 13)
        Me.lblIDTipoMandato.TabIndex = 26
        Me.lblIDTipoMandato.Text = "Tipo"
        '
        'lblTipoPago
        '
        Me.lblTipoPago.Location = New System.Drawing.Point(611, 64)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(63, 13)
        Me.lblTipoPago.TabIndex = 27
        Me.lblTipoPago.Text = "Tipo Pago"
        '
        'cmbTipoPago
        '
        cmbTipoPago_DesignTimeLayout.LayoutString = resources.GetString("cmbTipoPago_DesignTimeLayout.LayoutString")
        Me.cmbTipoPago.DesignTimeLayout = cmbTipoPago_DesignTimeLayout
        Me.cmbTipoPago.DisabledBackColor = System.Drawing.Color.White
        Me.cmbTipoPago.DisplayMember = "Text"
        Me.cmbTipoPago.Location = New System.Drawing.Point(676, 60)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.SelectedIndex = -1
        Me.cmbTipoPago.SelectedItem = Nothing
        Me.cmbTipoPago.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoPago.TabIndex = 6
        Me.cmbTipoPago.ValueMember = "Value"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(258, 64)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 28
        Me.lblFecha.Text = "Fecha"
        '
        'lblSep
        '
        Me.lblSep.Location = New System.Drawing.Point(411, 64)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(12, 13)
        Me.lblSep.TabIndex = 29
        Me.lblSep.Text = "-"
        '
        'cbxFechaD
        '
        Me.cbxFechaD.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaD.Location = New System.Drawing.Point(308, 60)
        Me.cbxFechaD.Name = "cbxFechaD"
        Me.cbxFechaD.Size = New System.Drawing.Size(93, 21)
        Me.cbxFechaD.TabIndex = 3
        '
        'cbxFechaH
        '
        Me.cbxFechaH.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaH.Location = New System.Drawing.Point(431, 60)
        Me.cbxFechaH.Name = "cbxFechaH"
        Me.cbxFechaH.Size = New System.Drawing.Size(93, 21)
        Me.cbxFechaH.TabIndex = 4
        '
        'CIMandatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 511)
        Me.EntityName = "Mandato"
        Me.KeyField = "IDMandato"
        Me.Name = "CIMandatos"
        Me.Text = "Consulta de Mandatos"
        Me.ViewName = "vSEPA_CTLCIMandatos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cmbIDTipoMandato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbIDTipoMandato As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblIDTipoMandato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbTipoPago As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaH As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaD As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblSep As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
End Class

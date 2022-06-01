<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIRemesasCobros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIRemesasCobros))
        Me.lbltxtRemesaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRemesaHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblcbxFNegHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lbltxtRemesaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcbxFNegDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFNegHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtRemesaDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxFNegDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lbltxtRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.txtRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.lblcbxFNegHasta)
        Me.FilterPanel.Controls.Add(Me.lbltxtRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lblcbxFNegDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFNegHasta)
        Me.FilterPanel.Controls.Add(Me.txtRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFNegDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 334)
        Me.FilterPanel.Size = New System.Drawing.Size(702, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(702, 334)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Hierarchical = True
        Me.Grid.Size = New System.Drawing.Size(702, 334)
        Me.Grid.ViewName = "vSEPA_FrmMntoRemesa"
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
        Me.MainPanel.Size = New System.Drawing.Size(702, 414)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(702, 414)
        '
        'lbltxtRemesaHasta
        '
        Me.lbltxtRemesaHasta.Location = New System.Drawing.Point(18, 53)
        Me.lbltxtRemesaHasta.Name = "lbltxtRemesaHasta"
        Me.lbltxtRemesaHasta.Size = New System.Drawing.Size(75, 13)
        Me.lbltxtRemesaHasta.TabIndex = 16
        Me.lbltxtRemesaHasta.Tag = "IdRec=5594;"
        Me.lbltxtRemesaHasta.Text = "Remesa <="
        '
        'txtRemesaHasta
        '
        Me.txtRemesaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtRemesaHasta.Location = New System.Drawing.Point(106, 49)
        Me.txtRemesaHasta.Name = "txtRemesaHasta"
        Me.txtRemesaHasta.Size = New System.Drawing.Size(87, 21)
        Me.txtRemesaHasta.TabIndex = 1
        '
        'lblcbxFNegHasta
        '
        Me.lblcbxFNegHasta.Location = New System.Drawing.Point(477, 53)
        Me.lblcbxFNegHasta.Name = "lblcbxFNegHasta"
        Me.lblcbxFNegHasta.Size = New System.Drawing.Size(125, 13)
        Me.lblcbxFNegHasta.TabIndex = 10
        Me.lblcbxFNegHasta.Tag = "IdRec=4747;"
        Me.lblcbxFNegHasta.Text = "Fecha Negociación <"
        '
        'lbltxtRemesaDesde
        '
        Me.lbltxtRemesaDesde.Location = New System.Drawing.Point(18, 29)
        Me.lbltxtRemesaDesde.Name = "lbltxtRemesaDesde"
        Me.lbltxtRemesaDesde.Size = New System.Drawing.Size(75, 13)
        Me.lbltxtRemesaDesde.TabIndex = 13
        Me.lbltxtRemesaDesde.Tag = "IdRec=4746;"
        Me.lbltxtRemesaDesde.Text = "Remesa >="
        '
        'lblcbxFNegDesde
        '
        Me.lblcbxFNegDesde.Location = New System.Drawing.Point(477, 29)
        Me.lblcbxFNegDesde.Name = "lblcbxFNegDesde"
        Me.lblcbxFNegDesde.Size = New System.Drawing.Size(125, 13)
        Me.lblcbxFNegDesde.TabIndex = 14
        Me.lblcbxFNegDesde.Tag = "IdRec=4745;"
        Me.lblcbxFNegDesde.Text = "Fecha Negociación >"
        '
        'cbxFNegHasta
        '
        Me.cbxFNegHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFNegHasta.Location = New System.Drawing.Point(605, 49)
        Me.cbxFNegHasta.Name = "cbxFNegHasta"
        Me.cbxFNegHasta.Size = New System.Drawing.Size(85, 21)
        Me.cbxFNegHasta.TabIndex = 3
        '
        'txtRemesaDesde
        '
        Me.txtRemesaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtRemesaDesde.Location = New System.Drawing.Point(106, 25)
        Me.txtRemesaDesde.Name = "txtRemesaDesde"
        Me.txtRemesaDesde.Size = New System.Drawing.Size(87, 21)
        Me.txtRemesaDesde.TabIndex = 0
        '
        'cbxFNegDesde
        '
        Me.cbxFNegDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFNegDesde.Location = New System.Drawing.Point(605, 25)
        Me.cbxFNegDesde.Name = "cbxFNegDesde"
        Me.cbxFNegDesde.Size = New System.Drawing.Size(85, 21)
        Me.cbxFNegDesde.TabIndex = 2
        '
        'CIRemesasCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 502)
        Me.EntityName = "Cobro"
        Me.Name = "CIRemesasCobros"
        Me.Text = "Generación de Ficheros SEPA Cobros"
        Me.ViewName = "vSEPA_FrmMntoRemesa"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbltxtRemesaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRemesaHasta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblcbxFNegHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbltxtRemesaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcbxFNegDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFNegHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents txtRemesaDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbxFNegDesde As Solmicro.Expertis.Engine.UI.CalendarBox
End Class

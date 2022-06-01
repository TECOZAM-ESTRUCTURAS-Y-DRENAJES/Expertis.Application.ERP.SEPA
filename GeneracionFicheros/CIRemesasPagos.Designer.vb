<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIRemesasPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIRemesasPagos))
        Me.txtRemesaDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblcbxFRemesaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lbltxtRemesaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcbxFRemesaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lbltxtRemesaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFRemesaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFRemesaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtRemesaHasta = New Solmicro.Expertis.Engine.UI.TextBox
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
        Me.FilterPanel.Controls.Add(Me.txtRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lblcbxFRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lbltxtRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lblcbxFRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.lbltxtRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.txtRemesaHasta)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 333)
        Me.FilterPanel.Size = New System.Drawing.Size(729, 75)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(729, 333)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Pago"
        Me.Grid.Hierarchical = True
        Me.Grid.KeyField = "IDRemesa"
        Me.Grid.Size = New System.Drawing.Size(729, 333)
        Me.Grid.ViewName = "vSEPA_CIRemesaPago"
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
        Me.MainPanel.Size = New System.Drawing.Size(729, 408)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(729, 408)
        '
        'txtRemesaDesde
        '
        Me.txtRemesaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtRemesaDesde.Location = New System.Drawing.Point(91, 20)
        Me.txtRemesaDesde.Name = "txtRemesaDesde"
        Me.txtRemesaDesde.Size = New System.Drawing.Size(87, 21)
        Me.txtRemesaDesde.TabIndex = 0
        '
        'lblcbxFRemesaDesde
        '
        Me.lblcbxFRemesaDesde.Location = New System.Drawing.Point(529, 24)
        Me.lblcbxFRemesaDesde.Name = "lblcbxFRemesaDesde"
        Me.lblcbxFRemesaDesde.Size = New System.Drawing.Size(103, 13)
        Me.lblcbxFRemesaDesde.TabIndex = 7
        Me.lblcbxFRemesaDesde.Tag = "IdRec=8153;"
        Me.lblcbxFRemesaDesde.Text = "Fecha Remesa >"
        '
        'lbltxtRemesaDesde
        '
        Me.lbltxtRemesaDesde.Location = New System.Drawing.Point(14, 24)
        Me.lbltxtRemesaDesde.Name = "lbltxtRemesaDesde"
        Me.lbltxtRemesaDesde.Size = New System.Drawing.Size(75, 13)
        Me.lbltxtRemesaDesde.TabIndex = 10
        Me.lbltxtRemesaDesde.Tag = "IdRec=4746;"
        Me.lbltxtRemesaDesde.Text = "Remesa >="
        '
        'lblcbxFRemesaHasta
        '
        Me.lblcbxFRemesaHasta.Location = New System.Drawing.Point(529, 49)
        Me.lblcbxFRemesaHasta.Name = "lblcbxFRemesaHasta"
        Me.lblcbxFRemesaHasta.Size = New System.Drawing.Size(103, 13)
        Me.lblcbxFRemesaHasta.TabIndex = 12
        Me.lblcbxFRemesaHasta.Tag = "IdRec=4747;"
        Me.lblcbxFRemesaHasta.Text = "Fecha Remesa <"
        '
        'lbltxtRemesaHasta
        '
        Me.lbltxtRemesaHasta.Location = New System.Drawing.Point(14, 49)
        Me.lbltxtRemesaHasta.Name = "lbltxtRemesaHasta"
        Me.lbltxtRemesaHasta.Size = New System.Drawing.Size(75, 13)
        Me.lbltxtRemesaHasta.TabIndex = 13
        Me.lbltxtRemesaHasta.Tag = "IdRec=5594;"
        Me.lbltxtRemesaHasta.Text = "Remesa <="
        '
        'cbxFRemesaDesde
        '
        Me.cbxFRemesaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFRemesaDesde.Location = New System.Drawing.Point(636, 20)
        Me.cbxFRemesaDesde.Name = "cbxFRemesaDesde"
        Me.cbxFRemesaDesde.Size = New System.Drawing.Size(85, 21)
        Me.cbxFRemesaDesde.TabIndex = 2
        '
        'cbxFRemesaHasta
        '
        Me.cbxFRemesaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFRemesaHasta.Location = New System.Drawing.Point(636, 45)
        Me.cbxFRemesaHasta.Name = "cbxFRemesaHasta"
        Me.cbxFRemesaHasta.Size = New System.Drawing.Size(85, 21)
        Me.cbxFRemesaHasta.TabIndex = 3
        '
        'txtRemesaHasta
        '
        Me.txtRemesaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtRemesaHasta.Location = New System.Drawing.Point(91, 45)
        Me.txtRemesaHasta.Name = "txtRemesaHasta"
        Me.txtRemesaHasta.Size = New System.Drawing.Size(87, 21)
        Me.txtRemesaHasta.TabIndex = 1
        '
        'CIRemesasPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 496)
        Me.EntityName = "Pago"
        Me.KeyField = "IDRemesa"
        Me.Name = "CIRemesasPagos"
        Me.Text = "Generación de Ficheros SEPA Pagos"
        Me.ViewName = "vSEPA_CIRemesaPago"
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
    Friend WithEvents txtRemesaDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblcbxFRemesaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbltxtRemesaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcbxFRemesaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbltxtRemesaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFRemesaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFRemesaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents txtRemesaHasta As Solmicro.Expertis.Engine.UI.TextBox
End Class

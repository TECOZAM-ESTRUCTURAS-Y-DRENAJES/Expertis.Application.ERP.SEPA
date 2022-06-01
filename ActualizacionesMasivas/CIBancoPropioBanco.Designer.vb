<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIBancoPropioBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIBancoPropioBanco))
        Me.advIDBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblBanco = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.advIDBanco)
        Me.FilterPanel.Controls.Add(Me.lblBanco)
        Me.FilterPanel.Controls.Add(Me.advIDBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblIDBancoPropio)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 330)
        Me.FilterPanel.Size = New System.Drawing.Size(703, 55)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(703, 330)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBanco", "Banco", "IDBanco", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescBanco", "DescBanco")}))})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "BancoPropio"
        Me.Grid.KeyField = "IDBancoPropio"
        Me.Grid.PrimaryDataFields = "IDBancoPropio"
        Me.Grid.SecondaryDataFields = "IDBancoPropio"
        Me.Grid.Size = New System.Drawing.Size(703, 330)
        Me.Grid.ViewName = "vSEPA_MntoBancoPropioBanco"
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
        Me.MainPanel.Size = New System.Drawing.Size(703, 385)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(703, 385)
        '
        'advIDBancoPropio
        '
        Me.TryDataBinding(advIDBancoPropio, New System.Windows.Forms.Binding("Text", Me, "IDBancoPropio", True))
        Me.advIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBancoPropio.EntityName = "BancoPropio"
        Me.advIDBancoPropio.Location = New System.Drawing.Point(107, 20)
        Me.advIDBancoPropio.Name = "advIDBancoPropio"
        Me.advIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.advIDBancoPropio.Size = New System.Drawing.Size(121, 23)
        Me.advIDBancoPropio.TabIndex = 0
        '
        'lblIDBancoPropio
        '
        Me.lblIDBancoPropio.Location = New System.Drawing.Point(23, 25)
        Me.lblIDBancoPropio.Name = "lblIDBancoPropio"
        Me.lblIDBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblIDBancoPropio.TabIndex = 1
        Me.lblIDBancoPropio.Text = "Banco Propio"
        '
        'advIDBanco
        '
        Me.advIDBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBanco.EntityName = "Banco"
        Me.advIDBanco.Location = New System.Drawing.Point(323, 20)
        Me.advIDBanco.Name = "advIDBanco"
        Me.advIDBanco.SecondaryDataFields = "IDBanco"
        Me.advIDBanco.Size = New System.Drawing.Size(121, 23)
        Me.advIDBanco.TabIndex = 10
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(278, 25)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblBanco.TabIndex = 11
        Me.lblBanco.Text = "Banco"
        '
        'CIBancoPropioBanco
        '
        Me.AllowUpdate = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 473)
        Me.EntityName = "BancoPropio"
        Me.KeyField = "IDBancoPropio"
        Me.Name = "CIBancoPropioBanco"
        Me.Text = "Código IBAN y Swift en Bancos Propios"
        Me.ViewName = "vSEPA_MntoBancoPropioBanco"
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
    Friend WithEvents advIDBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblBanco As Solmicro.Expertis.Engine.UI.Label
End Class

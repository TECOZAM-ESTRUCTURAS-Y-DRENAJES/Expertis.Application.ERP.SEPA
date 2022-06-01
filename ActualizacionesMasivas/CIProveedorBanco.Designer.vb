<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIProveedorBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIProveedorBanco))
        Me.advIDBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDProveedor = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.advIDProveedor)
        Me.FilterPanel.Controls.Add(Me.lblIDProveedor)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 316)
        Me.FilterPanel.Size = New System.Drawing.Size(708, 68)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(708, 316)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBanco", "Banco", "IDBanco", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescBanco", "DescBanco")}))})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ProveedorBanco"
        Me.Grid.KeyField = "IDProveedorBanco"
        Me.Grid.PrimaryDataFields = "IDProveedorBanco"
        Me.Grid.SecondaryDataFields = "IDProveedorBanco"
        Me.Grid.Size = New System.Drawing.Size(708, 316)
        Me.Grid.ViewName = "vSEPA_MntoProveedorBanco"
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
        Me.MainPanel.Size = New System.Drawing.Size(708, 384)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(708, 384)
        '
        'advIDBanco
        '
        Me.advIDBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBanco.EntityName = "Banco"
        Me.advIDBanco.Location = New System.Drawing.Point(314, 25)
        Me.advIDBanco.Name = "advIDBanco"
        Me.advIDBanco.SecondaryDataFields = "IDBanco"
        Me.advIDBanco.Size = New System.Drawing.Size(121, 23)
        Me.advIDBanco.TabIndex = 10
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(269, 30)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblBanco.TabIndex = 11
        Me.lblBanco.Text = "Banco"
        '
        'advIDProveedor
        '
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(84, 25)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(121, 23)
        Me.advIDProveedor.TabIndex = 8
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.Location = New System.Drawing.Point(19, 30)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblIDProveedor.TabIndex = 9
        Me.lblIDProveedor.Text = "Proveedor"
        '
        'CIProveedorBanco
        '
        Me.AllowUpdate = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 472)
        Me.EntityName = "ProveedorBanco"
        Me.KeyField = "IDProveedorBanco"
        Me.Name = "CIProveedorBanco"
        Me.Text = "Código IBAN y Swift en Bancos de Proveedores"
        Me.ViewName = "vSEPA_MntoProveedorBanco"
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
    Friend WithEvents advIDBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblBanco As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDProveedor As Solmicro.Expertis.Engine.UI.Label
End Class

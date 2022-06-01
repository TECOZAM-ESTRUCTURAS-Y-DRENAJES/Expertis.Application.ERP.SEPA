<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIPersonalBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPersonalBanco))
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.advIDOperario)
        Me.FilterPanel.Controls.Add(Me.lblIDOperario)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 319)
        Me.FilterPanel.Size = New System.Drawing.Size(677, 61)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(677, 319)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBanco", "Banco", "IDBanco", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescBanco", "DescBanco")}))})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Operario"
        Me.Grid.KeyField = "IDOperario"
        Me.Grid.PrimaryDataFields = "IDOperario"
        Me.Grid.SecondaryDataFields = "IDOperario"
        Me.Grid.Size = New System.Drawing.Size(677, 319)
        Me.Grid.ViewName = "vSEPA_MntoPersonalBanco"
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
        Me.MainPanel.Size = New System.Drawing.Size(677, 380)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(677, 380)
        '
        'advIDOperario
        '
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(76, 24)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(121, 23)
        Me.advIDOperario.TabIndex = 2
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(13, 29)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblIDOperario.TabIndex = 3
        Me.lblIDOperario.Text = "Operario"
        '
        'advIDBanco
        '
        Me.advIDBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBanco.EntityName = "Banco"
        Me.advIDBanco.Location = New System.Drawing.Point(287, 24)
        Me.advIDBanco.Name = "advIDBanco"
        Me.advIDBanco.SecondaryDataFields = "IDBanco"
        Me.advIDBanco.Size = New System.Drawing.Size(121, 23)
        Me.advIDBanco.TabIndex = 8
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(242, 29)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblBanco.TabIndex = 9
        Me.lblBanco.Text = "Banco"
        '
        'CIPersonalBanco
        '
        Me.AllowUpdate = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 468)
        Me.EntityName = "Operario"
        Me.FindTextField = ""
        Me.KeyField = "IDOperario"
        Me.Name = "CIPersonalBanco"
        Me.Text = "Código IBAN y Swift en Bancos de Personal"
        Me.ViewName = "vSEPA_MntoPersonalBanco"
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
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblBanco As Solmicro.Expertis.Engine.UI.Label
End Class

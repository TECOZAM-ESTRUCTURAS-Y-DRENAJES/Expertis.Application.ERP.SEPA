<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIClienteBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIClienteBanco))
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDCliente = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblIDCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 411)
        Me.FilterPanel.Size = New System.Drawing.Size(863, 58)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(863, 411)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBanco", "Banco", "IDBanco", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescBanco", "DescBanco")}))})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ClienteBanco"
        Me.Grid.PrimaryDataFields = "IDClienteBanco"
        Me.Grid.SecondaryDataFields = "IDClienteBanco"
        Me.Grid.Size = New System.Drawing.Size(863, 411)
        Me.Grid.ViewName = "vSEPA_MntoClienteBanco"
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
        Me.MainPanel.Size = New System.Drawing.Size(863, 469)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(863, 469)
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(95, 20)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(121, 23)
        Me.advIDCliente.TabIndex = 4
        '
        'lblIDCliente
        '
        Me.lblIDCliente.Location = New System.Drawing.Point(32, 25)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblIDCliente.TabIndex = 5
        Me.lblIDCliente.Text = "Cliente"
        '
        'advIDBanco
        '
        Me.advIDBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBanco.EntityName = "Banco"
        Me.advIDBanco.Location = New System.Drawing.Point(343, 20)
        Me.advIDBanco.Name = "advIDBanco"
        Me.advIDBanco.SecondaryDataFields = "IDBanco"
        Me.advIDBanco.Size = New System.Drawing.Size(121, 23)
        Me.advIDBanco.TabIndex = 6
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(280, 25)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblBanco.TabIndex = 7
        Me.lblBanco.Text = "Banco"
        '
        'CIClienteBanco
        '
        Me.AllowUpdate = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 557)
        Me.EntityName = "ClienteBanco"
        Me.Name = "CIClienteBanco"
        Me.Text = "Código IBAN y Swift en Bancos de Cliente"
        Me.ViewName = "vSEPA_MntoClienteBanco"
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
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDCliente As Solmicro.Expertis.Engine.UI.Label
End Class

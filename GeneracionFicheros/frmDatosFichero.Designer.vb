<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosFichero
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosFichero))
        Dim cboBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblFechaEmision = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaCargo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaEmision = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaCargo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblRuta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRutaFichero = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cmdRutaFichero = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.cboBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblccboBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtSufijoRemesa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlBottom.suspendlayout()
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(20, 17)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 0
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmdCancelar)
        Me.pnlBottom.Controls.Add(Me.cmdAceptar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 104)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(550, 55)
        Me.pnlBottom.TabIndex = 2
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(296, 14)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(92, 29)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(171, 14)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(92, 29)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.Location = New System.Drawing.Point(20, 76)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaEmision.TabIndex = 3
        Me.lblFechaEmision.Text = "Fecha Emisión"
        '
        'lblFechaCargo
        '
        Me.lblFechaCargo.Location = New System.Drawing.Point(283, 76)
        Me.lblFechaCargo.Name = "lblFechaCargo"
        Me.lblFechaCargo.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaCargo.TabIndex = 4
        Me.lblFechaCargo.Text = "Fecha Cargo"
        '
        'cbxFechaEmision
        '
        Me.cbxFechaEmision.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaEmision.Location = New System.Drawing.Point(115, 72)
        Me.cbxFechaEmision.Name = "cbxFechaEmision"
        Me.cbxFechaEmision.Size = New System.Drawing.Size(116, 21)
        Me.cbxFechaEmision.TabIndex = 5
        '
        'cbxFechaCargo
        '
        Me.cbxFechaCargo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCargo.Location = New System.Drawing.Point(378, 72)
        Me.cbxFechaCargo.Name = "cbxFechaCargo"
        Me.cbxFechaCargo.Size = New System.Drawing.Size(116, 21)
        Me.cbxFechaCargo.TabIndex = 6
        '
        'lblRuta
        '
        Me.lblRuta.Location = New System.Drawing.Point(20, 47)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(78, 13)
        Me.lblRuta.TabIndex = 7
        Me.lblRuta.Text = "Ruta Fichero"
        '
        'txtRutaFichero
        '
        Me.txtRutaFichero.DisabledBackColor = System.Drawing.Color.White
        Me.txtRutaFichero.Location = New System.Drawing.Point(115, 42)
        Me.txtRutaFichero.Name = "txtRutaFichero"
        Me.txtRutaFichero.Size = New System.Drawing.Size(354, 21)
        Me.txtRutaFichero.TabIndex = 8
        '
        'cmdRutaFichero
        '
        Me.cmdRutaFichero.ImageIndex = 0
        Me.cmdRutaFichero.ImageList = Me.ImageList1
        Me.cmdRutaFichero.Location = New System.Drawing.Point(469, 42)
        Me.cmdRutaFichero.Name = "cmdRutaFichero"
        Me.cmdRutaFichero.Size = New System.Drawing.Size(25, 21)
        Me.cmdRutaFichero.TabIndex = 9
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_view.ico")
        '
        'cboBancoPropio
        '
        cboBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cboBancoPropio_DesignTimeLayout.LayoutString")
        Me.cboBancoPropio.DesignTimeLayout = cboBancoPropio_DesignTimeLayout
        Me.cboBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cboBancoPropio.EntityName = "BancoPropio"
        Me.cboBancoPropio.Location = New System.Drawing.Point(115, 15)
        Me.cboBancoPropio.Name = "cboBancoPropio"
        Me.cboBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SelectedIndex = -1
        Me.cboBancoPropio.SelectedItem = Nothing
        Me.cboBancoPropio.Size = New System.Drawing.Size(53, 21)
        Me.cboBancoPropio.TabIndex = 25
        Me.cboBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblccboBancoPropio
        '
        Me.lblccboBancoPropio.Location = New System.Drawing.Point(172, 16)
        Me.lblccboBancoPropio.Name = "lblccboBancoPropio"
        Me.lblccboBancoPropio.Size = New System.Drawing.Size(322, 21)
        Me.lblccboBancoPropio.TabIndex = 26
        '
        'txtSufijoRemesa
        '
        Me.txtSufijoRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.txtSufijoRemesa.Location = New System.Drawing.Point(498, 17)
        Me.txtSufijoRemesa.MaxLength = 3
        Me.txtSufijoRemesa.Name = "txtSufijoRemesa"
        Me.txtSufijoRemesa.Size = New System.Drawing.Size(37, 21)
        Me.txtSufijoRemesa.TabIndex = 27
        '
        'frmDatosFichero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 159)
        Me.Controls.Add(Me.txtSufijoRemesa)
        Me.Controls.Add(Me.cboBancoPropio)
        Me.Controls.Add(Me.lblccboBancoPropio)
        Me.Controls.Add(Me.cmdRutaFichero)
        Me.Controls.Add(Me.txtRutaFichero)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.cbxFechaCargo)
        Me.Controls.Add(Me.cbxFechaEmision)
        Me.Controls.Add(Me.lblFechaCargo)
        Me.Controls.Add(Me.lblFechaEmision)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.lblBancoPropio)
        Me.Name = "frmDatosFichero"
        Me.Text = "Datos Generación Fichero"
        Me.pnlBottom.ResumeLayout(False)
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblFechaEmision As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaCargo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaEmision As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaCargo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblRuta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRutaFichero As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cmdRutaFichero As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cboBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblccboBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents txtSufijoRemesa As Solmicro.Expertis.Engine.UI.TextBox
End Class

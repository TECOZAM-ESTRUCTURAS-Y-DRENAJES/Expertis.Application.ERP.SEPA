<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroducirCodigoISO
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtCodigoISO = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlBottom.suspendlayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(31, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOTA: Solmicro no se hace responsable del Código IBAN generado. Recuerde que debe" & _
            " revisar dicho código."
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmdCancelar)
        Me.pnlBottom.Controls.Add(Me.cmdAceptar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 81)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(774, 47)
        Me.pnlBottom.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(411, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(92, 29)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(286, 9)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(92, 29)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'txtCodigoISO
        '
        Me.txtCodigoISO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoISO.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodigoISO.Location = New System.Drawing.Point(541, 44)
        Me.txtCodigoISO.MaxLength = 2
        Me.txtCodigoISO.Name = "txtCodigoISO"
        Me.txtCodigoISO.Size = New System.Drawing.Size(74, 21)
        Me.txtCodigoISO.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(122, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(413, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Introduzca el Código ISO del País al que pertenece la Cuenta Bancaria"
        '
        'frmIntroducirCodigoISO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 128)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoISO)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmIntroducirCodigoISO"
        Me.Text = "Introducir Código ISO"
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtCodigoISO As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
End Class

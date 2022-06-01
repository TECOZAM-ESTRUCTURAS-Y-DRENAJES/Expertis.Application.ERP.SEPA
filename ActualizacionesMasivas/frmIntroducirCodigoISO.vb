Public Class frmIntroducirCodigoISO

    Public Property CodigoISO() As String
        Get
            Return UCase(txtCodigoISO.Text)
        End Get
        Set(ByVal value As String)
            txtCodigoISO.Text = UCase(Nz(value, cnCodigoISO_Espania))
        End Set
    End Property
    
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Length(txtCodigoISO.Text) > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            ExpertisApp.GenerateMessage("Debe introducir un Código ISO.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
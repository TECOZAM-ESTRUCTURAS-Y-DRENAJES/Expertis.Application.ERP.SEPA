Public Class MntoMandato

#Region " Carga del formulario "

    Private Sub MntoMandato_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadEnums()
        End If
    End Sub

    Private Sub LoadEnums()
        Me.cmbIDTipoMandato.DataSource = EnumData.EnumView("TipoMandato")
        Me.cmbTipoPago.DataSource = EnumData.EnumView("MandatoTipoPago")
        Me.cmbEstado.DataSource = EnumData.EnumView("MandatoEstado")
    End Sub


    Private Sub MntoMandato_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles Me.Navigated
        HabilitarDeshabilitarControles()
        HabilitarDeshabilitarCliente()
        HabilitarDeshabilitarProveedor()
    End Sub

#End Region

#Region " Cliente "

    Private Sub advIDClienteBanco_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDClienteBanco.SetPredefinedFilter
        If Length(Me.advIDCliente.Value) > 0 Then e.Filter.Add(New StringFilterItem("IDCliente", advIDCliente.Value))
    End Sub

    Private Sub advIDCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles advIDCliente.Validated
        If Length(advIDCliente.Value) = 0 Then
            HabilitarDeshabilitarCliente()
            Me.advIDClienteBanco.Value = System.DBNull.Value
        End If
    End Sub

    Private Sub advIDCliente_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDCliente.SelectionChanged
        HabilitarDeshabilitarCliente()
        If Length(advIDCliente.Value) > 0 AndAlso Length(Me.txtLocalidadFirma.Text) = 0 AndAlso Not advIDCliente.SelectedRow Is Nothing Then
            Me.txtLocalidadFirma.Text = advIDCliente.SelectedRow("Poblacion") & String.Empty
        End If
    End Sub

    Private Sub HabilitarDeshabilitarCliente()
        If cmbEstado.Value = CInt(BusinessEnum.MandatoEstado.Aceptado) Then Exit Sub

        Dim blnEnabled As Boolean = Length(advIDCliente.Value) > 0

        Me.advIDClienteBanco.Enabled = blnEnabled
        If blnEnabled Then Me.advIDProveedor.Value = System.DBNull.Value
        Me.advIDProveedor.Enabled = Not blnEnabled
    End Sub

#End Region

#Region " Proveedor "

    Private Sub advIDProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles advIDProveedor.Validated
        If Length(advIDProveedor.Value) = 0 Then
            HabilitarDeshabilitarProveedor()
            Me.advIDBancoPropio.Value = System.DBNull.Value
            Me.txtSuMandato.Text = String.Empty
        End If
    End Sub

    Private Sub advIDProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDProveedor.SelectionChanged
        HabilitarDeshabilitarProveedor()

        If Length(advIDProveedor.Value) > 0 AndAlso Length(Me.txtLocalidadFirma.Text) = 0 Then
            Dim dtDatosEmpresa As DataTable = New BE.DataEngine().Filter("tbDatosEmpresa", Nothing)
            If dtDatosEmpresa.Rows.Count > 0 Then
                Me.txtLocalidadFirma.Text = dtDatosEmpresa.Rows(0)("Poblacion") & String.Empty
            End If
        End If
    End Sub

    Private Sub HabilitarDeshabilitarProveedor()
        If cmbEstado.Value = CInt(BusinessEnum.MandatoEstado.Aceptado) Then Exit Sub

        Dim blnEnabled As Boolean = Length(advIDProveedor.Value) > 0

        Me.advIDBancoPropio.Enabled = blnEnabled
        Me.txtSuMandato.Enabled = blnEnabled

        If blnEnabled Then Me.advIDCliente.Value = System.DBNull.Value
        Me.advIDCliente.Enabled = Not blnEnabled
    End Sub


    Private Sub HabilitarDeshabilitarControles()
        BloquearInformacion(Me.MainPanel, cmbEstado.Value = CInt(BusinessEnum.MandatoEstado.Aceptado), cttNMandato, Me.cmbEstado)
    End Sub

#End Region

    Private Sub MntoMandato_RecordAdding(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.RecordAdding
        Me.cttNMandato.Enabled = True
    End Sub

    Private Sub MntoMandato_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RecordUpdated
        Me.cttNMandato.Enabled = False
    End Sub

#Region " Informes "

    Private Sub MntoMandato_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles Me.SetReportSelectionCriteria
        Select Case e.Alias
            Case cnALIAS_RPT_MANDATO, cnALIAS_RPT_MANDATO_FRANCES
                If Not Me.CurrentRow Is Nothing AndAlso Nz(Me.CurrentRow("IDMandato"), 0) <> 0 Then
                    e.Filter.Add(New NumberFilterItem("IDMandato", Me.CurrentRow("IDMandato")))
                End If
        End Select
    End Sub

#End Region

    Private Sub cmbEstado_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.ValueChanged
        MntoMandato_Navigated(Me, Nothing)
    End Sub

End Class
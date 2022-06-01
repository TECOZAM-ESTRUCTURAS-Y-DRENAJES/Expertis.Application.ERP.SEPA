Public Class CIMandatos

    Private cnVER_MANDATO As String = "Ver Mandato"
    Private cnVER_CLIENTE As String = "Ver Cliente"
    Private cnVER_PROVEEDOR As String = "Ver Proveedor"
    Private cnVER_BANCO_PROPIO As String = "Ver Banco Propio"

    Private mblnEjecutarConsulta As Boolean

#Region " Carga del formulario "

    Private Sub CIMandatos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadGridActions()
            If mblnEjecutarConsulta Then Me.Execute()
        End If
    End Sub

    Private Sub LoadERPData()
        If Not Me.Params Is Nothing AndAlso TypeOf Me.Params Is Hashtable Then
            Dim ht As Hashtable = Me.Params
            If ht.ContainsKey("IDCliente") AndAlso Length(ht("IDCliente")) > 0 Then
                Me.advIDCliente.Value = ht("IDCliente")
                mblnEjecutarConsulta = True
            End If

            If ht.ContainsKey("IDProveedor") AndAlso Length(ht("IDProveedor")) > 0 Then
                Me.advIDProveedor.Value = ht("IDProveedor")
                mblnEjecutarConsulta = True
            End If

            If ht.ContainsKey("IDBancoPropio") AndAlso Length(ht("IDBancoPropio")) > 0 Then
                Me.advIDBancoPropio.Value = ht("IDBancoPropio")
                mblnEjecutarConsulta = True
            End If
        End If
    End Sub

    Private Sub LoadEnums()
        Me.cmbIDTipoMandato.DataSource = EnumData.EnumView("TipoMandato")
        Me.cmbTipoPago.DataSource = EnumData.EnumView("MandatoTipoPago")

        EnumData.PopulateValueList("TipoMandato", Grid.Columns("IDTipoMandato"))
        EnumData.PopulateValueList("MandatoTipoPago", Grid.Columns("TipoPago"))
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.AddSeparator()
        Me.Grid.Actions.Add(cnVER_MANDATO, AddressOf AbrirMandato)
        Me.Grid.Actions.Add(cnVER_CLIENTE, AddressOf AbrirCliente)
        Me.Grid.Actions.Add(cnVER_PROVEEDOR, AddressOf AbrirProveedor)
        Me.Grid.Actions.Add(cnVER_BANCO_PROPIO, AddressOf AbrirBancoPropio)
    End Sub

#End Region

#Region " Acciones del Grid "


    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not Grid Is Nothing AndAlso Grid.RowCount > 0 Then
                Try

                    If Length(Grid.Value("IDCliente")) > 0 Then
                        Grid.UiCommandManager1.Commands(cnVER_CLIENTE).Visible = InheritableBoolean.True
                    Else
                        Grid.UiCommandManager1.Commands(cnVER_CLIENTE).Visible = InheritableBoolean.False
                    End If

                    If Length(Grid.Value("IDProveedor")) > 0 Then
                        Grid.UiCommandManager1.Commands(cnVER_PROVEEDOR).Visible = InheritableBoolean.True
                    Else
                        Grid.UiCommandManager1.Commands(cnVER_PROVEEDOR).Visible = InheritableBoolean.False
                    End If


                    If Length(Grid.Value("IDBancoPropio")) > 0 Then
                        Grid.UiCommandManager1.Commands(cnVER_BANCO_PROPIO).Visible = InheritableBoolean.True
                    Else
                        Grid.UiCommandManager1.Commands(cnVER_BANCO_PROPIO).Visible = InheritableBoolean.False
                    End If
                Catch ex As Exception
                    Grid.UiCommandManager1.Commands(cnVER_CLIENTE).Visible = InheritableBoolean.False
                    Grid.UiCommandManager1.Commands(cnVER_PROVEEDOR).Visible = InheritableBoolean.False
                    Grid.UiCommandManager1.Commands(cnVER_BANCO_PROPIO).Visible = InheritableBoolean.False
                End Try

            End If
        End If
    End Sub

    Private Sub AbrirMandato()
        Dim strAlias As String = "MNTOMDTO"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, New NumberFilterItem("IDMandato", Grid.Value("IDMandato")))
    End Sub

    Private Sub AbrirCliente()
        Dim strAlias As String = "MCLIENTE"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, New StringFilterItem("IDCliente", Grid.Value("IDCliente")))
    End Sub

    Private Sub AbrirProveedor()
        Dim strAlias As String = "MPROV"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, New StringFilterItem("IDProveedor", Grid.Value("IDProveedor")))
    End Sub

    Private Sub AbrirBancoPropio()
        Dim strAlias As String = "MNTOBANCP"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, New StringFilterItem("IDBancoPropio", Grid.Value("IDBancoPropio")))
    End Sub

#End Region

#Region " Consulta "

    Private Sub CIMandatos_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Value, FilterType.String)
        e.Filter.Add("IDProveedor", FilterOperator.Equal, advIDProveedor.Value, FilterType.String)
        e.Filter.Add("IDBancoPropio", FilterOperator.Equal, advIDBancoPropio.Value, FilterType.String)

        e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaD.Value, FilterType.DateTime)
        e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaH.Value, FilterType.DateTime)

        e.Filter.Add("IDTipoMandato", FilterOperator.Equal, cmbIDTipoMandato.Value, FilterType.Numeric)
        e.Filter.Add("TipoPago", FilterOperator.Equal, cmbTipoPago.Value, FilterType.Numeric)
    End Sub

#End Region

#Region " Grid "


    Private Sub Grid_GetChildList(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetChildListEventArgs) Handles Grid.GetChildList
        If Length(e.ParentRow.Cells("IDMandato").Value) > 0 Then
            Dim f As New Filter
            'If e.ParentRow.Cells("IDTipoNegociacion").Value = enumTipoRemesa.RemesaAnticipo Then
            ' e.ChildTable.Columns("EstadoAnticipo").Visible = True
            f.Add(New NumberFilterItem("IDMandato", e.ParentRow.Cells("IDMandato").Value))
            'Else
            '    e.ChildTable.Columns("EstadoAnticipo").Visible = False
            '    Dim fTrazabilidadRemesas As New Filter(FilterUnionOperator.Or)
            '    Dim fRemesa As New Filter
            '    fRemesa.Add(New NumberFilterItem("IDRemesa", e.ParentRow.Cells("IDRemesa").Value))
            '    fRemesa.Add(New IsNullFilterItem("IDRemesaAnterior"))
            '    fTrazabilidadRemesas.Add(fRemesa)
            '    Dim fRemesaDevol As New Filter
            '    'fRemesaDevol.Add(New IsNullFilterItem("IDRemesa"))
            '    '  fRemesaDevol.Add(New NumberFilterItem("IDRemesaAnterior", e.ParentRow.Cells("IDRemesa").Value))
            '    fRemesaDevol.Add(New NumberFilterItem("IDRemesaAnterior", e.ParentRow.Cells("IDRemesa").Value))
            '    fTrazabilidadRemesas.Add(fRemesaDevol)

            '    f.Add(fTrazabilidadRemesas)
            'End If

            e.ChildList = New BE.DataEngine().Filter("vSEPA_frmCobros", f)
        Else
            e.ChildList = Nothing
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            If Not e.Row.Parent Is Nothing AndAlso e.Row.Parent.GridEX.Name = "Grid" Then
                If e.Row.Cells("Situacion").Value = enumCobroSituacion.Devuelto Then
                    e.Row.RowStyle = Grid.FormatStyles("DevueltoFormatStyle")
                ElseIf e.Row.Cells("Contabilizado").Value <> enumCobroContabilizado.CobroNoContabilizado Then
                    e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                    'e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
                Else
                    'e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
                End If
            End If
        End If
    End Sub

#End Region


    'Private Sub CIMandatos_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles Me.SetReportSelectionCriteria
    '    Select Case e.Alias
    '        Case cnALIAS_RPT_MANDATO
    '            If Grid.CheckedRecordsCount > 0 Then
    '                Dim fMandato As New Filter(FilterUnionOperator.Or)
    '                For Each dr As DataRow In Grid.CheckedRecords.Rows
    '                    fMandato.Add(New NumberFilterItem("IDMandato", dr("IDMandato")))
    '                Next
    '                e.Filter.Add(fMandato)
    '            End If
    '    End Select
    'End Sub

End Class
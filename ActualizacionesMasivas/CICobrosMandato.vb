Public Class CICobrosMandato

    Public Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
    End Enum

    Protected mblnContabilidadMultiple As Boolean


    Protected Const cnABRIR_FACTURA_VENTA As String = "Ver Factura Venta"
    Protected Const cnABRIR_MANDATO As String = "Ver Mandato"
    Protected Const cnABRIR_CLTE As String = "Ver Cliente"

    Protected Const cnASIGNAR_MDTO_PREDETERMINADO As String = "Asignar Mandato Predeterminado del Cliente"

#Region " Carga del formulario "

    Private Sub CICobrosMandato_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadToolbarActions()
            LoadGridActions()
            LoadEnums()
            'InitFilterCriteria()
        End If
    End Sub

    Protected Overridable Sub LoadERPData()
       
    End Sub

    Protected Overridable Sub LoadToolbarActions()
        Me.FormActions.Add(cnASIGNAR_MDTO_PREDETERMINADO, AddressOf AsignarMandatoPredeterminadoCliente, ExpertisApp.GetIcon("book_blue_next.ico"))
    End Sub

    Protected Overridable Sub LoadGridActions()
        Grid.AddSeparator()
        Grid.Actions.Add(cnABRIR_CLTE, AddressOf AbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
        Grid.Actions.Add(cnABRIR_FACTURA_VENTA, AddressOf AbrirFacturaVenta, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        Grid.Actions.Add(cnABRIR_MANDATO, AddressOf AbrirMandato, ExpertisApp.GetIcon("books_preferences.ico"))
    End Sub

    Protected Overridable Sub LoadEnums()
        cbxContabilizado.DataSource = New EnumData("enumCobroContabilizado")
        'If Not mblnContabilidadMultiple Then
        '    CType(cbxContabilizado.DataSource, DataView).RowFilter = "Name = 'enumContabilizadoTodos' AND Value <> " & enumContabilizado.ContabilizadoNIIF & " AND Value <> " & enumContabilizado.ContabilizadoTributario
        'End If
    End Sub

    Protected Overridable Sub InitFilterCriteria()
        cbxContabilizado.Value = enumCobroContabilizado.CobroNoContabilizado
        cbxSituacion.Value = enumCobroSituacion.NoNegociado
    End Sub

#End Region

#Region " Accíones del formulario "

    Protected Overridable Sub AsignarMandatoPredeterminadoCliente()
        If Grid.RowCount > 0 Then
            If ExpertisApp.GenerateMessage("Se va a proceder a asignar automáticamente el Mandato Predeterminado de cada Cliente. {0}IMPORTANTE: Solmicro no se hace responsable de la asignación realizada. Asegúrese que los datos introducidos en el sistema están correctamente configurados. {1}¿Desea continuar?", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question, vbNewLine, vbNewLine) = Windows.Forms.DialogResult.Yes Then
                Dim IDCobros(-1) As Object

                Dim Cobros As List(Of DataRow) = (From c In CType(Me.Grid.DataSource, DataTable) _
                                                  Where c.IsNull("IDMandato") AndAlso _
                                                        Not c.IsNull("IDCliente") AndAlso _
                                                        Not c.IsNull("IDClienteBanco") AndAlso _
                                                        Not c.IsNull("IDFormaPago") AndAlso _
                                                        Not c.IsNull("CobroRemesable") AndAlso _
                                                        c("CobroRemesable")).ToList()

                If Not Cobros Is Nothing AndAlso Cobros.Count > 0 Then
                    For Each dr As DataRow In Cobros
                        ReDim Preserve IDCobros(IDCobros.Length)
                        IDCobros(IDCobros.Length - 1) = dr("IDCobro")
                    Next

                    ExpertisApp.ExecuteTask(Of Object())(AddressOf Mandato.AsignarMandatoPredeterminadoCliente, IDCobros)
                    Me.Execute()
                Else
                    ExpertisApp.GenerateMessage("No hay registros a los que realizar la asignación. Revise sus datos.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("No hay registros a los que realizar la asignación.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region " Acciones del Grid "

    Protected Overridable Sub AbrirCliente()
        Dim strAlias As String = "MCLIENTE"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, New StringFilterItem("IDCliente", Grid.Value("IDCliente")))
    End Sub

    Protected Overridable Sub AbrirFacturaVenta()
        Dim strAlias As String = "MFACTV"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, New NumberFilterItem("IDFactura", Grid.Value("IDFactura")))
    End Sub

    Protected Overridable Sub AbrirMandato()
        Dim strAlias As String = "MNTOMDTO"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, New NumberFilterItem("IDMandato", Grid.Value("IDMandato")))
    End Sub

#End Region

#Region " Consulta "

    Private Sub CICobrosMandato_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)
        e.Filter.Add("IDMandato", FilterOperator.Equal, AdvIDMandato.Value, FilterType.String)
        If Engine.Length(nbxImpDesde.Text) > 0 AndAlso IsNumeric(nbxImpDesde.Text) Then
            e.Filter.Add(New NumberFilterItem("ImpVencimientoA", FilterOperator.GreaterThanOrEqual, nbxImpDesde.Text))
        End If
        If Engine.Length(nbxImpHasta.Text) > 0 AndAlso IsNumeric(nbxImpHasta.Text) Then
            e.Filter.Add(New NumberFilterItem("ImpVencimientoA", FilterOperator.LessThanOrEqual, nbxImpHasta.Text))
        End If
        e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDFormaPago", FilterOperator.Equal, cbxIDFormaPago.Text, FilterType.String)
        e.Filter.Add("IDBancoPropio", FilterOperator.Equal, cbxIDBancoPropio.Value, FilterType.String)
        e.Filter.Add("IDRemesa", FilterOperator.Equal, AdvRemesa.Value, FilterType.Numeric)
        e.Filter.Add("Situacion", FilterOperator.Equal, cbxSituacion.Value, FilterType.Numeric)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFacturaD.Text, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFacturaH.Text, FilterType.DateTime)
        If Engine.Length(txtTitulo.Text) > 0 Then
            e.Filter.Add(New LikeFilterItem("Titulo", txtTitulo.Text))
        End If

        If Nz(cbxContabilizado.Value, -1) <> -1 Then
            e.Filter.Add("Contabilizado", FilterOperator.Equal, cbxContabilizado.Value, FilterType.Numeric)
        End If
        e.Filter.Add(New IsNullFilterItem("IDClienteBanco", False))
    End Sub

#End Region

#Region " Grid "

    Protected Overridable Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "NMandato"
                If Length(Grid.Value("IDCliente")) > 0 Then
                    e.Filter.Add(New StringFilterItem("IDCliente", Grid.Value("IDCliente")))
                End If
                If Nz(Grid.Value("IDClienteBanco"), 0) <> 0 Then
                    e.Filter.Add(New NumberFilterItem("IDClienteBanco", Grid.Value("IDClienteBanco")))
                End If
                
                e.Filter.Add(New BooleanFilterItem("Caducado", False))
                e.Filter.Add(New NumberFilterItem("Estado", CInt(BusinessEnum.MandatoEstado.Aceptado)))

                If Length(Grid.Value("IDFormaPago")) = 0 OrElse Not Nz(Grid.Value("CobroRemesable"), False) Then
                    e.Filter.Add(New NoRowsFilterItem)
                End If
        End Select
    End Sub

    Protected Overridable Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            If e.Row.Cells("Contabilizado").Value <> enumCobroContabilizado.CobroNoContabilizado Then
                e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub

    Protected Overridable Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If e.Column.Key <> "NMandato" Then
            e.Cancel = True
        End If
    End Sub

    Protected Overridable Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not Grid Is Nothing AndAlso Grid.RowCount > 0 Then
                If Length(Grid.Value("IDMandato")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIR_MANDATO).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIR_MANDATO).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "NMandato"
                If Length(Me.Grid.GetValue("IDClienteBanco")) = 0 Then
                    ExpertisApp.GenerateMessage("No se puede asignar mandato a la línea, no tiene un Cliente-Banco asociado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
        End Select
    End Sub

#End Region

End Class
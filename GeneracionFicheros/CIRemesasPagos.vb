Public Class CIRemesasPagos

    Public Const cnGENERAR_FICHERO_SEPA_34_14 As String = "Generar Fichero SEPA CSB34.14"
    Public Const cnGENERAR_FICHERO_SEPA_001_001_03 As String = "Generar Fichero SEPA XML"


#Region " Carga del formulario "

    Private Sub CIRemesasCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadGridActions()
            LoadEnums()
        End If
    End Sub

    Protected Overridable Sub LoadEnums()
        EnumData.PopulateValueList("enumFichRemesaPago", Grid.Columns("TipoFichero"))
    End Sub

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_34_14, AddressOf AccionGenerarCSB_34_14)
        Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_001_001_03, AddressOf AccionGenerar_PAIN_001_001_03)
    End Sub

    Protected Overridable Sub AccionGenerarCSB_34_14()
        If Length(Grid.Value("IDRemesa")) > 0 Then
            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_34_14
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Windows.Forms.Cursors.WaitCursor
                Dim dtPagos As DataTable = New BE.DataEngine().Filter("vSEPA_frmPagos", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtPagos.Rows.Count = 0 Then Exit Sub

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each drPago As DataRow In dtPagos.Rows
                    htEnlace("IDEnlace" & i) = drPago("IDPago")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim dtFichero As New DataTable
                dtFichero.Columns.Add("Linea", GetType(String))

                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                If Nz(frm.FechaEmision, cnMinDate) = cnMinDate Then
                    datFich.FechaEmision = Today.Date
                Else
                    datFich.FechaEmision = frm.FechaEmision
                End If
                Dim lstRegsFich As List(Of String) = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB34_14.GenerarFichero, datFich)
                For Each Registro As String In lstRegsFich
                    Dim drNew As DataRow = dtFichero.NewRow
                    drNew("Linea") = Registro
                    dtFichero.Rows.Add(drNew)
                Next
                DesmarcarRegistro(IDProcess, FilterType.Numeric)

                If dtFichero.Rows.Count > 0 AndAlso GuardarFichero(dtFichero, frm.RutaFichero, Grid.Value("IDRemesa")) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If

    End Sub

    Protected Overridable Sub AccionGenerar_PAIN_001_001_03()
        If Length(Grid.Value("IDRemesa")) > 0 Then
            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_34_14
            frm.FormatoXML = True
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim dtPagos As DataTable = New BE.DataEngine().Filter("vSEPA_frmPagos", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtPagos.Rows.Count = 0 Then Exit Sub

                Me.Cursor = Windows.Forms.Cursors.WaitCursor

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each dr As DataRow In dtPagos.Rows
                    htEnlace("IDEnlace" & i) = dr("IDPago")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                If Nz(frm.FechaEmision, cnMinDate) = cnMinDate Then
                    datFich.FechaEmision = Today.Date
                Else
                    datFich.FechaEmision = frm.FechaEmision
                End If
                If Nz(frm.FechaCargo, cnMinDate) = cnMinDate Then
                    datFich.FechaCargo = Today.Date
                Else
                    datFich.FechaCargo = frm.FechaCargo
                End If
                datFich.IDRemesa = Grid.Value("IDRemesa")

                Dim lstRegsFich As Byte()
                lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_001_001_03.GenerarFichero, datFich)

                DesmarcarRegistro(IDProcess, FilterType.Numeric)

                If Not lstRegsFich Is Nothing AndAlso lstRegsFich.Length > 0 AndAlso GuardarFicheroXML(lstRegsFich, frm.RutaFichero, Grid.Value("IDRemesa"), datFich.FechaCargo, True) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If


    End Sub

    Protected Overridable Function GuardarFichero(ByVal dtFichero As DataTable, ByVal RutaFichero As String, ByVal IDRemesa As Integer) As Boolean
        Try
            GuardarFichero = False

            If Length(RutaFichero) Then
                'Si existe el archivo en la ruta lo elimina
                Dim strNombreFichero As String = Dir$(RutaFichero)
                If Length(strNombreFichero) Then
                    Kill(RutaFichero)
                End If
                'Abrimos el fichero
                Dim intFile As Integer = FreeFile()

                FileOpen(intFile, RutaFichero, OpenMode.Output, OpenAccess.Write, OpenShare.LockReadWrite)

                With dtFichero
                    For Each row As DataRow In dtFichero.Rows
                        Print(intFile, row("Linea"))
                        Print(intFile, vbNewLine)
                    Next row
                End With

                FileClose(intFile)

                Dim rp As New RemesaPago
                Dim dtRemesa As DataTable = rp.SelOnPrimaryKey(IDRemesa)
                If dtRemesa.Rows.Count > 0 Then
                    dtRemesa.Rows(0)("Ruta") = RutaFichero
                    rp.Update(dtRemesa)
                End If


                GuardarFichero = True
            Else
                GuardarFichero = False
                ExpertisApp.GenerateMessage("La Ruta no existe.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            GuardarFichero = False
            ExpertisApp.GenerateMessage(ex.Message, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Warning)
        End Try

    End Function

#End Region

#Region " ChildList "

    Private Sub Grid_GetChildList(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetChildListEventArgs) Handles Grid.GetChildList
        If Length(e.ParentRow.Cells("IDRemesa").Value) > 0 Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDRemesa", e.ParentRow.Cells("IDRemesa").Value))
            e.ChildList = New BE.DataEngine().Filter("vSEPA_frmPagos", f)
        Else
            e.ChildList = Nothing
        End If
    End Sub


    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record AndAlso Not e.Row.Parent Is Nothing Then
            If e.Row.Parent.GridEX.Name = "Grid" Then
                If e.Row.Cells("Contabilizado").Value <> enumCobroContabilizado.CobroNoContabilizado Then
                    e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                End If
            End If

        End If
    End Sub

#End Region

#Region " Consulta Interactiva "

    Private Sub CIRemesasPagos_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDRemesa", FilterOperator.GreaterThanOrEqual, txtRemesaDesde.Text, FilterType.Numeric)
        e.Filter.Add("IDRemesa", FilterOperator.LessThanOrEqual, txtRemesaHasta.Text, FilterType.Numeric)
        e.Filter.Add("FechaRemesa", FilterOperator.GreaterThanOrEqual, cbxFRemesaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaRemesa", FilterOperator.LessThanOrEqual, cbxFRemesaHasta.Value, FilterType.DateTime)
    End Sub

#End Region



    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        Try
            Dim IDRemesa As Integer = Nz(Grid.Value("IDRemesa"), 0)  '//ESta llamada es para que si estamos en el hijo de error y oculte las acciones


            If e.Button = MouseButtons.Right AndAlso sender.name = "Grid" Then
                Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_34_14).Visible = InheritableBoolean.True

            End If
        Catch ex As Exception
            '//Para evitar un error, cuando estamos en el grid hijo (NO QUITAR EL try Catch)
            Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_34_14).Visible = InheritableBoolean.False
        End Try
    End Sub

End Class
Public Class CIRemesasCobros

    Public Const cnGENERAR_FICHERO_SEPA_19_14 As String = "Generar Fichero SEPA CSB19.14 CORE"
    Public Const cnGENERAR_FICHERO_SEPA_19_44 As String = "Generar Fichero SEPA CSB19.44 B2B"
    ' Public Const cnGENERAR_FICHERO_SEPA_19_15 As String = "Generar Fichero SEPA CSB19.15 COR1"

    Public Const cnGENERAR_FICHERO_SEPA_008_001_02_CORE As String = "Generar Fichero SEPA CORE XML"
    'Public Const cnGENERAR_FICHERO_SEPA_008_001_02_COR1 As String = "Generar Fichero SEPA COR1 XML"
    Public Const cnGENERAR_FICHERO_SEPA_008_001_02_B2B As String = "Generar Fichero SEPA B2B XML"

#Region " Carga del formulario "

    Private Sub CIRemesasCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadGridActions()
            LoadEnums()
        End If
    End Sub

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_19_14, AddressOf AccionGenerarCSB_19_14)
        'Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_19_15, AddressOf AccionGenerarCSB_19_15)
        Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_19_44, AddressOf AccionGenerarCSB_19_44)
        Me.Grid.AddSeparator()
        Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_008_001_02_CORE, AddressOf AccionGenerarSEPA_008_001_02_CORE)
        'Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_008_001_02_COR1, AddressOf AccionGenerarSEPA_008_001_02_COR1)
        Me.Grid.Actions.Add(cnGENERAR_FICHERO_SEPA_008_001_02_B2B, AddressOf AccionGenerarSEPA_008_001_02_B2B)
    End Sub

    Protected Overridable Sub LoadEnums()
        EnumData.PopulateValueList("enumTipoRemesa", Grid.Columns("IDTipoNegociacion"))
        Me.Grid.RootTable.ChildTables(0).Columns("IDTipoMandato").DropDown.SetDataBinding(EnumData.EnumView("TipoMandato"), Nothing)
    End Sub

    Protected Overridable Sub AccionGenerarCSB_19_14()
        If Length(Grid.Value("IDRemesa")) > 0 Then

            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_19_14
            frm.IDBancoPropio = Grid.Value("IDBancoPropio")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim dtCobros As DataTable = New BE.DataEngine().Filter("vSEPA_frmCobros", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtCobros.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay datos para generar el Fichero", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim CobrosSinMdto As List(Of DataRow) = (From c In dtCobros Where c.IsNull("IDMandato")).ToList
                    If CobrosSinMdto.Count > 0 Then
                        ExpertisApp.GenerateMessage("El Mandato es un dato obligatorio, alguno de los Cobros no lo tiene especificado. Revise sus datos.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                Me.Cursor = Windows.Forms.Cursors.WaitCursor

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each drCobro As DataRow In dtCobros.Rows
                    htEnlace("IDEnlace" & i) = drCobro("IDCobro")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim dtFichero As New DataTable
                dtFichero.Columns.Add("Linea", GetType(String))
                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                datFich.FechaEmision = Nz(frm.FechaEmision, Today)
                datFich.FechaCargo = Nz(frm.FechaCargo, Today)
                datFich.IDRemesa = Grid.Value("IDRemesa")
                If Length(frm.SufijoRemesa) > 0 Then datFich.SufijoRemesa = frm.SufijoRemesa
                Dim lstRegsFich As List(Of String)

                lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB19_14_CORE.GenerarFichero, datFich)

                DesmarcarRegistro(IDProcess, FilterType.Numeric)

                If Not lstRegsFich Is Nothing Then
                    For Each Registro As String In lstRegsFich
                        Dim drNew As DataRow = dtFichero.NewRow
                        drNew("Linea") = Registro
                        dtFichero.Rows.Add(drNew)
                    Next
                End If

                If dtFichero.Rows.Count > 0 AndAlso GuardarFichero(dtFichero, frm.RutaFichero, Grid.Value("IDRemesa"), datFich.FechaCargo) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If

    End Sub

    Protected Overridable Sub AccionGenerarCSB_19_44()
        If Length(Grid.Value("IDRemesa")) > 0 Then

            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_19_44
            frm.IDBancoPropio = Grid.Value("IDBancoPropio")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim dtCobros As DataTable = New BE.DataEngine().Filter("vSEPA_frmCobros", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtCobros.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay datos para generar el Fichero", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim CobrosSinMdto As List(Of DataRow) = (From c In dtCobros Where c.IsNull("IDMandato")).ToList
                    If CobrosSinMdto.Count > 0 Then
                        ExpertisApp.GenerateMessage("El Mandato es un dato obligatorio, alguno de los Cobros no lo tiene especificado. Revise sus datos.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                Me.Cursor = Windows.Forms.Cursors.WaitCursor

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each drCobro As DataRow In dtCobros.Rows
                    htEnlace("IDEnlace" & i) = drCobro("IDCobro")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim dtFichero As New DataTable
                dtFichero.Columns.Add("Linea", GetType(String))
                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                datFich.FechaEmision = Nz(frm.FechaEmision, Today)
                datFich.FechaCargo = Nz(frm.FechaCargo, Today)
                datFich.IDRemesa = Grid.Value("IDRemesa")
                If Length(frm.SufijoRemesa) > 0 Then datFich.SufijoRemesa = frm.SufijoRemesa
                Dim lstRegsFich As List(Of String)

                lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB19_44_B2B.GenerarFichero, datFich)

                DesmarcarRegistro(IDProcess, FilterType.Numeric)

                If Not lstRegsFich Is Nothing Then
                    For Each Registro As String In lstRegsFich
                        Dim drNew As DataRow = dtFichero.NewRow
                        drNew("Linea") = Registro
                        dtFichero.Rows.Add(drNew)
                    Next
                End If

                If dtFichero.Rows.Count > 0 AndAlso GuardarFichero(dtFichero, frm.RutaFichero, Grid.Value("IDRemesa"), datFich.FechaCargo) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If
    End Sub

    Protected Overridable Sub AccionGenerarCSB_19_15()
        If Length(Grid.Value("IDRemesa")) > 0 Then
            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_19_15
            frm.IDBancoPropio = Grid.Value("IDBancoPropio")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim dtCobros As DataTable = New BE.DataEngine().Filter("vSEPA_frmCobros", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtCobros.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay datos para generar el Fichero", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim CobrosSinMdto As List(Of DataRow) = (From c In dtCobros Where c.IsNull("IDMandato")).ToList
                    If CobrosSinMdto.Count > 0 Then
                        ExpertisApp.GenerateMessage("El Mandato es un dato obligatorio, alguno de los Cobros no lo tiene especificado. Revise sus datos.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                Me.Cursor = Windows.Forms.Cursors.WaitCursor

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each drCobro As DataRow In dtCobros.Rows
                    htEnlace("IDEnlace" & i) = drCobro("IDCobro")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim dtFichero As New DataTable
                dtFichero.Columns.Add("Linea", GetType(String))

                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                datFich.FechaEmision = Nz(frm.FechaEmision, Today)
                datFich.FechaCargo = Nz(frm.FechaCargo, Today)
                datFich.IDRemesa = Grid.Value("IDRemesa")
                If Length(frm.SufijoRemesa) > 0 Then datFich.SufijoRemesa = frm.SufijoRemesa
                Dim lstRegsFich As List(Of String)

                lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB19_15_COR1.GenerarFichero, datFich)

                DesmarcarRegistro(IDProcess, FilterType.Numeric)


                If Not lstRegsFich Is Nothing Then
                    For Each Registro As String In lstRegsFich
                        Dim drNew As DataRow = dtFichero.NewRow
                        drNew("Linea") = Registro
                        dtFichero.Rows.Add(drNew)
                    Next
                End If

                If dtFichero.Rows.Count > 0 AndAlso GuardarFichero(dtFichero, frm.RutaFichero, Grid.Value("IDRemesa"), datFich.FechaCargo) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If

    End Sub

    Protected Overridable Sub AccionGenerarSEPA_008_001_02_CORE()
        If Length(Grid.Value("IDRemesa")) > 0 Then

            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_19_14
            frm.IDBancoPropio = Grid.Value("IDBancoPropio")
            frm.FormatoXML = True
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Windows.Forms.Cursors.WaitCursor
                Dim dtCobros As DataTable = New BE.DataEngine().Filter("vSEPA_frmCobros", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtCobros.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay información para generar el fichero.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)

                    Me.Cursor = Windows.Forms.Cursors.Default
                    Exit Sub
                End If

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each drCobro As DataRow In dtCobros.Rows
                    htEnlace("IDEnlace" & i) = drCobro("IDCobro")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim dtFichero As New DataTable
                dtFichero.Columns.Add("Linea", GetType(String))
                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                datFich.FechaEmision = Nz(frm.FechaEmision, Today)
                datFich.FechaCargo = Nz(frm.FechaCargo, Today)
                datFich.IDRemesa = Grid.Value("IDRemesa")
                Dim lstRegsFich As Byte()

                lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_008_001_02.GenerarFicheroCORE, datFich)

                DesmarcarRegistro(IDProcess, FilterType.Numeric)

                If Not lstRegsFich Is Nothing AndAlso lstRegsFich.Length > 0 AndAlso GuardarFicheroXML(lstRegsFich, frm.RutaFichero, Grid.Value("IDRemesa"), datFich.FechaCargo) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If

    End Sub

    Protected Overridable Sub AccionGenerarSEPA_008_001_02_COR1()
        If Length(Grid.Value("IDRemesa")) > 0 Then

            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_19_14
            frm.IDBancoPropio = Grid.Value("IDBancoPropio")
            frm.FormatoXML = True
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Windows.Forms.Cursors.WaitCursor

                Dim dtCobros As DataTable = New BE.DataEngine().Filter("vSEPA_frmCobros", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtCobros.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay datos para generar el Fichero", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim CobrosSinMdto As List(Of DataRow) = (From c In dtCobros Where c.IsNull("IDMandato")).ToList
                    If CobrosSinMdto.Count > 0 Then
                        ExpertisApp.GenerateMessage("El Mandato es un dato obligatorio, alguno de los Cobros no lo tiene especificado. Revise sus datos.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each drCobro As DataRow In dtCobros.Rows
                    htEnlace("IDEnlace" & i) = drCobro("IDCobro")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim dtFichero As New DataTable
                dtFichero.Columns.Add("Linea", GetType(String))
                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                datFich.FechaEmision = Nz(frm.FechaEmision, Today)
                datFich.FechaCargo = Nz(frm.FechaCargo, Today)
                datFich.IDRemesa = Grid.Value("IDRemesa")
                Dim lstRegsFich As Byte()

                lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_008_001_02.GenerarFicheroCOR1, datFich)

                DesmarcarRegistro(IDProcess, FilterType.Numeric)

                If Not lstRegsFich Is Nothing AndAlso lstRegsFich.Length > 0 AndAlso GuardarFicheroXML(lstRegsFich, frm.RutaFichero, Grid.Value("IDRemesa"), datFich.FechaCargo) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If

    End Sub

    Protected Overridable Sub AccionGenerarSEPA_008_001_02_B2B()
        If Length(Grid.Value("IDRemesa")) > 0 Then
            Dim frm As New frmDatosFichero
            frm.TipoFichero = frmDatosFichero.TipoFicheroSEPA.CSB_19_14
            frm.IDBancoPropio = Grid.Value("IDBancoPropio")
            frm.FormatoXML = True
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Windows.Forms.Cursors.WaitCursor
                Dim dtCobros As DataTable = New BE.DataEngine().Filter("vSEPA_frmCobros", New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))
                If dtCobros.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay datos para generar el Fichero", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim CobrosSinMdto As List(Of DataRow) = (From c In dtCobros Where c.IsNull("IDMandato")).ToList
                    If CobrosSinMdto.Count > 0 Then
                        ExpertisApp.GenerateMessage("El Mandato es un dato obligatorio, alguno de los Cobros no lo tiene especificado. Revise sus datos.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                Dim i As Integer = 0
                Dim htEnlace As New Hashtable
                For Each drCobro As DataRow In dtCobros.Rows
                    htEnlace("IDEnlace" & i) = drCobro("IDCobro")
                    i += 1
                Next
                Dim IDProcess As Guid = MarcarRegistro(htEnlace, FilterType.Numeric)

                Dim dtFichero As New DataTable
                dtFichero.Columns.Add("Linea", GetType(String))
                Dim datFich As New DataGenerarFichero
                datFich.IDProcess = IDProcess
                datFich.IDBancoPropio = frm.IDBancoPropio
                datFich.FechaEmision = Nz(frm.FechaEmision, Today)
                datFich.FechaCargo = Nz(frm.FechaCargo, Today)
                datFich.IDRemesa = Grid.Value("IDRemesa")
                Dim lstRegsFich As Byte()

                lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_008_001_02.GenerarFicheroB2B, datFich)

                DesmarcarRegistro(IDProcess, FilterType.Numeric)

                If Not lstRegsFich Is Nothing AndAlso lstRegsFich.Length > 0 AndAlso GuardarFicheroXML(lstRegsFich, frm.RutaFichero, Grid.Value("IDRemesa"), datFich.FechaCargo) Then
                    ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                    Me.Execute()
                End If
                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If
    End Sub

    Protected Overridable Function GuardarFichero(ByVal dtFichero As DataTable, ByVal RutaFichero As String, ByVal IDRemesa As Integer, ByVal FechaCargo As Date) As Boolean
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

                Dim rc As New Remesa
                Dim dtRemesa As DataTable = rc.SelOnPrimaryKey(IDRemesa)
                If dtRemesa.Rows.Count > 0 Then
                    dtRemesa.Rows(0)("Ruta") = RutaFichero
                    dtRemesa.Rows(0)("FechaCargo") = FechaCargo
                    rc.Update(dtRemesa)
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

    Protected Overridable Function GuardarFicheroXML(ByVal ContenidoFichero As Byte(), ByVal RutaFichero As String, ByVal IDRemesa As Integer, ByVal FechaCargo As Date) As Boolean
        Try
            GuardarFicheroXML = False

            If Length(RutaFichero) Then
                'Si existe el archivo en la ruta lo elimina
                Dim strNombreFichero As String = Dir$(RutaFichero)
                If Length(strNombreFichero) Then
                    Kill(RutaFichero)
                End If

                General.CrearFicheroXML(RutaFichero, ContenidoFichero, "UTF-8")

                Dim rc As New Remesa
                Dim dtRemesa As DataTable = rc.SelOnPrimaryKey(IDRemesa)
                If dtRemesa.Rows.Count > 0 Then
                    dtRemesa.Rows(0)("Ruta") = RutaFichero
                    dtRemesa.Rows(0)("FechaCargo") = FechaCargo
                    rc.Update(dtRemesa)
                End If

                GuardarFicheroXML = True
            Else
                GuardarFicheroXML = False
                ExpertisApp.GenerateMessage("La Ruta no existe.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            GuardarFicheroXML = False
            ExpertisApp.GenerateMessage(ex.Message, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Warning)
        End Try

    End Function

#End Region

#Region " ChildList "

    Private Sub Grid_GetChildList(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetChildListEventArgs) Handles Grid.GetChildList
        If Length(e.ParentRow.Cells("IDRemesa").Value) > 0 AndAlso Length(e.ParentRow.Cells("IDTipoNegociacion").Value) > 0 Then
            Dim f As New Filter

            Dim fTrazabilidadRemesas As New Filter(FilterUnionOperator.Or)
            Dim fRemesa As New Filter
            fRemesa.Add(New NumberFilterItem("IDRemesa", e.ParentRow.Cells("IDRemesa").Value))
            'fRemesa.Add(New IsNullFilterItem("IDRemesaAnterior"))
            fTrazabilidadRemesas.Add(fRemesa)
            'Dim fRemesaDevol As New Filter
            'fRemesaDevol.Add(New NumberFilterItem("IDRemesaAnterior", e.ParentRow.Cells("IDRemesa").Value))
            'fTrazabilidadRemesas.Add(fRemesaDevol)

            f.Add(fTrazabilidadRemesas)

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
                End If
            End If
        End If
    End Sub

#End Region

#Region " Consulta Interactiva "

    Private Sub CIRemesasCobros_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDRemesa", FilterOperator.GreaterThanOrEqual, txtRemesaDesde.Text, FilterType.Numeric)
        e.Filter.Add("IDRemesa", FilterOperator.LessThanOrEqual, txtRemesaHasta.Text, FilterType.Numeric)
        e.Filter.Add("FechaNegociacion", FilterOperator.GreaterThanOrEqual, cbxFNegDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaNegociacion", FilterOperator.LessThanOrEqual, cbxFNegHasta.Value, FilterType.DateTime)
        'e.Filter.Add("IdTipoNegociacion", FilterOperator.Equal, enumTipoRemesaConsulta.RemesaAlCobro, FilterType.Numeric)
    End Sub

#End Region



    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        Try
            Dim IDRemesa As Integer = Nz(Grid.Value("IDRemesa"), 0)  '//ESta llamada es para que si estamos en el hijo de error y oculte las acciones

            If e.Button = MouseButtons.Right AndAlso sender.name = "Grid" Then
                Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_19_14).Visible = InheritableBoolean.True
                Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_19_44).Visible = InheritableBoolean.True
                ' Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_19_15).Visible = InheritableBoolean.True

                Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_008_001_02_CORE).Visible = InheritableBoolean.True
                ' Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_008_001_02_COR1).Visible = InheritableBoolean.True
                Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_008_001_02_B2B).Visible = InheritableBoolean.True
            End If
        Catch ex As Exception
            '//Para evitar un error, cuando estamos en el grid hijo (NO QUITAR EL try Catch)
            Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_19_14).Visible = InheritableBoolean.False
            Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_19_44).Visible = InheritableBoolean.False
            ' Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_19_15).Visible = InheritableBoolean.False

            Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_008_001_02_CORE).Visible = InheritableBoolean.False
            ' Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_008_001_02_COR1).Visible = InheritableBoolean.False
            Grid.UiCommandManager1.Commands(cnGENERAR_FICHERO_SEPA_008_001_02_B2B).Visible = InheritableBoolean.False
        End Try
    End Sub


End Class
Public Class CIClienteBanco

#Region " Carga del formulario "

    Private Sub CIClienteBanco_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadGridActions()
            LoadToolBarActions()
        End If
    End Sub
    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Generar IBAN", AddressOf AccionGenerarIBANMasivo, ExpertisApp.GetIcon("calculator.ico"))
    End Sub
    Private Sub AccionGenerarIBANMasivo()
        Dim frm As New frmIntroducirCodigoISO
        frm.CodigoISO = cnCodigoISO_Espania
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If ExpertisApp.GenerateMessage("Se procesarán todos los Código IBAN, recalculando los existentes también.|¿Desea continuar?", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Windows.Forms.Cursors.WaitCursor
                Dim blnError As Boolean = False
                For Each Dr As DataRow In CType(Me.Grid.DataSource, DataTable).Rows
                    Try
                        'If Length(Dr("CodigoIBAN")) = 0 Then
                        Dim CodIBAN As String = General.GenerarCodigoIBAN(Dr("IDBanco") & String.Empty, Dr("Sucursal") & String.Empty, Dr("DigitoControl") & String.Empty, Dr("NCuenta") & String.Empty, frm.CodigoISO)
                        If Length(CodIBAN) > 0 Then
                            Dr("CodigoIBAN") = CodIBAN
                        End If
                        'End If
                    Catch ex As Exception
                        blnError = True
                    End Try
                Next

                Me.Cursor = Windows.Forms.Cursors.Default

                If blnError Then
                    ExpertisApp.GenerateMessage("Algunos Códigos de IBAN no se han generado correctamente. Revise sus datos.")
                End If
            End If
        End If
    End Sub


    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Ver Cliente", AddressOf AccionVerCliente)
        Me.Grid.Actions.Add("Generar IBAN", AddressOf AccionGenerarIBAN)
    End Sub

#End Region

#Region " Acciones del Grid "

    Private Sub AccionVerCliente()
        If Length(Grid.Value("IDCliente")) > 0 Then
            Dim strAlias As String = "MCLIENTE"
            If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
            ExpertisApp.OpenForm(strAlias, New StringFilterItem("IDCliente", Grid.Value("IDCliente")))
        End If
    End Sub


    Private Sub AccionGenerarIBAN()
        Dim frm As New frmIntroducirCodigoISO
        frm.CodigoISO = Grid.Value("CodigoISO") & String.Empty
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim CodIBAN As String = General.GenerarCodigoIBAN(Grid.Value("IDBanco") & String.Empty, Grid.Value("Sucursal") & String.Empty, Grid.Value("DigitoControl") & String.Empty, Grid.Value("NCuenta") & String.Empty, frm.CodigoISO)
            If Length(CodIBAN) > 0 Then
                Grid.SetValue("CodigoIBAN", CodIBAN)
            End If
        End If
    End Sub


#End Region

#Region " Consulta "

    Private Sub CIClienteBanco_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Value, FilterType.String)
        e.Filter.Add("IDBanco", FilterOperator.Equal, advIDBanco.Value, FilterType.String)
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "CodigoIBAN"
                If Length(e.Value) > 0 Then
                    If Not ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf FicherosGeneral.ValidarIBAN, e.Value) Then
                        e.Cancel = True
                    End If
                End If
        End Select
    End Sub

#End Region


    Public Overrides Sub UpdateData(Optional ByVal endCurrentEdit As Boolean = True)
        ' MyBase.UpdateData(endCurrentEdit)
        Dim dt As DataTable = Grid.DataSource
        dt.TableName = Grid.EntityName
        'BusinessHelper.UpdateTable(dt)
        ExpertisApp.ExecuteTask(Of DataTable)(AddressOf FicherosGeneral.ClienteBancoUpdate, dt)
        Me.RecordsState = UI.RecordsState.Saved
        Me.Execute()
    End Sub

End Class
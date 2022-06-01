Public Module General

    Public cnALIAS_RPT_MANDATO As String = "RPTMDTO"
    Public cnALIAS_RPT_MANDATO_FRANCES As String = "RPTMDTOF"
    Public cnCodigoISO_Espania As String = "ES"

    Public Sub AbrirConsultaMandato(ByVal IDCliente As String, ByVal IDProveedor As String, ByVal IDBancoPropio As String)
        Dim htParams As New Hashtable
        If Length(IDCliente) > 0 Then htParams("IDCliente") = IDCliente
        If Length(IDProveedor) > 0 Then htParams("IDProveedor") = IDProveedor
        If Length(IDBancoPropio) > 0 Then htParams("IDBancoPropio") = IDBancoPropio
        Dim strAlias As String = "CIMDTO"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias, Nothing, htParams)
    End Sub

    Public Function GenerarCodigoIBAN(ByVal IDBanco As String, ByVal Sucursal As String, ByVal DigitoControl As String, ByVal NCuenta As String, ByVal CodigoISO As String) As String
        Dim datIBAN As New FicherosGeneral.DataGenerarIBAN(IDBanco, Sucursal, DigitoControl, NCuenta, CodigoISO)
        Dim CodIBAN As String = ExpertisApp.ExecuteTask(Of FicherosGeneral.DataGenerarIBAN, String)(AddressOf FicherosGeneral.GenerarIBANEspania, datIBAN)
        Return CodIBAN
    End Function


    Public Function GuardarFicheroXML(ByVal ContenidoFichero As Byte(), ByVal RutaFichero As String, ByVal IDRemesa As Integer, ByVal FechaCargo As Date, ByVal blnPagos As Boolean) As Boolean
        Try
            GuardarFicheroXML = False

            If Length(RutaFichero) Then
                'Si existe el archivo en la ruta lo elimina
                Dim strNombreFichero As String = Dir$(RutaFichero)
                If Length(strNombreFichero) Then
                    Kill(RutaFichero)
                End If

                General.CrearFicheroXML(RutaFichero, ContenidoFichero, "UTF-8")

                If blnPagos Then
                    If IDRemesa > 0 Then
                        Dim rc As New RemesaPago
                        Dim dtRemesa As DataTable = rc.SelOnPrimaryKey(IDRemesa)
                        If dtRemesa.Rows.Count > 0 Then
                            dtRemesa.Rows(0)("Ruta") = RutaFichero
                            rc.Update(dtRemesa)
                        End If
                    End If
                Else
                    If IDRemesa > 0 Then
                        Dim rc As New Remesa
                        Dim dtRemesa As DataTable = rc.SelOnPrimaryKey(IDRemesa)
                        If dtRemesa.Rows.Count > 0 Then
                            dtRemesa.Rows(0)("Ruta") = RutaFichero
                            dtRemesa.Rows(0)("FechaCargo") = FechaCargo
                            rc.Update(dtRemesa)
                        End If
                    End If
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


    Public Function CrearFicheroXML(ByVal PathCompletoFichero As String, ByVal ContenidoFichero As Byte(), ByVal EncodingXML As String) As Boolean
        '//Nombre del fichero completo (ruta con el nombre del fichero)
        Dim FilEx As New IO.FileInfo(PathCompletoFichero)
        If Not IO.Directory.Exists(FilEx.DirectoryName) Then
            IO.Directory.CreateDirectory(FilEx.DirectoryName)
        End If

        '//Codificación. Convertimos el array de bytes en String
        Dim enc As System.Text.Encoding
        Select Case UCase(EncodingXML)
            Case "UTF-8"
                enc = System.Text.Encoding.UTF8
            Case "UTF-7"
                enc = System.Text.Encoding.UTF7
            Case "UTF-32"
                enc = System.Text.Encoding.UTF32
            Case "ASCII"
                enc = System.Text.Encoding.ASCII
            Case Else
                enc = System.Text.Encoding.Unicode
        End Select
        Dim encChars(enc.GetCharCount(ContenidoFichero, 0, ContenidoFichero.Length) - 1) As Char
        enc.GetChars(ContenidoFichero, 0, ContenidoFichero.Length, encChars, 0)
        Dim encString As New String(encChars)

        Dim writer As New System.IO.StreamWriter(PathCompletoFichero)
        writer.Write(encString)
        writer.Close()

        'Dim writer As Xml.XmlWriter = Xml.XmlWriter.Create(PathCompletoFichero) 'BOM
        'Dim xmlDoc As New Xml.XmlDocument
        'xmlDoc.LoadXml(encString)
        'xmlDoc.WriteTo(writer) 'BOM


        CrearFicheroXML = True
    End Function

    Public Function GuardarFichero(ByVal dtFichero As DataTable, ByVal RutaFichero As String, ByVal IDRemesa As Integer, ByVal FechaCargo As Date) As Boolean
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

End Module

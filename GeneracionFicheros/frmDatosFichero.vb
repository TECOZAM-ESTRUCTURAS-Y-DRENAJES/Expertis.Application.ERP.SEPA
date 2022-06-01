Public Class frmDatosFichero

    Public Enum TipoFicheroSEPA
        CSB_34_14 = 0
        CSB_19_14 = 1
        CSB_19_44 = 2
        CSB_19_15 = 3
    End Enum

#Region " Propiedades "

    Private mTipoFichero As TipoFicheroSEPA
    Public Property TipoFichero() As TipoFicheroSEPA
        Get
            Return mTipoFichero
        End Get
        Set(ByVal value As TipoFicheroSEPA)
            mTipoFichero = value
            Select Case mTipoFichero
                Case TipoFicheroSEPA.CSB_34_14
                    Me.txtSufijoRemesa.Visible = False
                Case Else
                    Me.txtSufijoRemesa.Visible = True
            End Select
        End Set
    End Property

    Private mIDBancoPropio As String
    Public Property IDBancoPropio() As String
        Get
            Return mIDBancoPropio
        End Get
        Set(ByVal value As String)
            mIDBancoPropio = value
            Me.cboBancoPropio.Value = mIDBancoPropio
        End Set
    End Property

    Private mRutaFichero As String
    Public Property RutaFichero() As String
        Get
            Return mRutaFichero
        End Get
        Set(ByVal value As String)
            mRutaFichero = value
        End Set
    End Property

    Private mFechaEmision As Date
    Public Property FechaEmision() As Date
        Get
            Return mFechaEmision
        End Get
        Set(ByVal value As Date)
            mFechaEmision = value
        End Set
    End Property

    Private mFechaCargo As Date
    Public Property FechaCargo() As Date
        Get
            Return mFechaCargo
        End Get
        Set(ByVal value As Date)
            mFechaCargo = value
        End Set
    End Property

    Private mSufijoRemesa As String
    Public Property SufijoRemesa() As String
        Get
            Return mSufijoRemesa
        End Get
        Set(ByVal value As String)
            mSufijoRemesa = value
        End Set
    End Property

    Private mFormatoXML As Boolean
    Public Property FormatoXML() As Boolean
        Get
            Return mFormatoXML
        End Get
        Set(ByVal value As Boolean)
            mFormatoXML = value
        End Set
    End Property

#End Region

#Region " Carga del formulario "

    Private Sub frmDatosFichero_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            SettingForm()
            cboBancoPropio_ValueChanged(cboBancoPropio, Nothing)
        End If
    End Sub

    Private Sub SettingForm()
        Me.cboBancoPropio.Enabled = (Length(Me.cboBancoPropio.Value) = 0)

        If Not Me.FormatoXML Then
            Select Case mTipoFichero
                Case TipoFicheroSEPA.CSB_34_14
                    lblFechaEmision.Visible = True : cbxFechaEmision.Visible = True
                    lblFechaCargo.Visible = False : cbxFechaCargo.Visible = False
                Case TipoFicheroSEPA.CSB_19_14
                    lblFechaEmision.Visible = True : cbxFechaEmision.Visible = True
                    lblFechaCargo.Visible = True : cbxFechaCargo.Visible = True
                Case TipoFicheroSEPA.CSB_19_44
                    lblFechaEmision.Visible = True : cbxFechaEmision.Visible = True
                    lblFechaCargo.Visible = True : cbxFechaCargo.Visible = True
            End Select
        Else
            Select Case mTipoFichero
                Case TipoFicheroSEPA.CSB_34_14
                    lblFechaEmision.Visible = True : cbxFechaEmision.Visible = True
                    lblFechaCargo.Visible = False : cbxFechaCargo.Visible = False
                Case TipoFicheroSEPA.CSB_19_14, TipoFicheroSEPA.CSB_19_44
                    Me.lblFechaCargo.Visible = False : Me.cbxFechaCargo.Visible = False
                    Me.lblFechaEmision.Visible = False : Me.cbxFechaEmision.Visible = False
            End Select
        End If
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If ValidarCamposObligatorios() Then
            mIDBancoPropio = cboBancoPropio.Value
            mRutaFichero = Me.txtRutaFichero.Text
            If cbxFechaEmision.Visible Then mFechaEmision = cbxFechaEmision.Value Else mFechaEmision = Today
            If cbxFechaCargo.Visible Then mFechaCargo = cbxFechaCargo.Value Else mFechaCargo = Today
            If txtSufijoRemesa.Visible AndAlso Length(txtSufijoRemesa.Text) > 0 Then mSufijoRemesa = txtSufijoRemesa.Text

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function ValidarCamposObligatorios() As Boolean
        ValidarCamposObligatorios = True
        If Length(Me.cboBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar el Banco Propio.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
            ValidarCamposObligatorios = False
        ElseIf Length(Me.txtRutaFichero.Text) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar la Ruta del Fichero.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
            ValidarCamposObligatorios = False
        ElseIf cbxFechaEmision.Visible AndAlso Nz(cbxFechaEmision.Value, cnMinDate) = cnMinDate Then
            ExpertisApp.GenerateMessage("Debe indicar la Fecha de Emisión.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
            ValidarCamposObligatorios = False
        ElseIf cbxFechaCargo.Visible AndAlso Nz(cbxFechaCargo.Value, cnMinDate) = cnMinDate Then
            ExpertisApp.GenerateMessage("Debe indicar la Fecha de Cargo.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
            ValidarCamposObligatorios = False
        End If
    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#End Region

    Private Sub cmdRutaFichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRutaFichero.Click
        Dim cnEXT_FICHERO As String
        If mFormatoXML Then
            cnEXT_FICHERO = ".xml"
            SaveFileDialog1.Filter = "Fichero XML |*" & cnEXT_FICHERO & ""
        Else
            cnEXT_FICHERO = ".txt"
            SaveFileDialog1.Filter = "Fichero Texto |*" & cnEXT_FICHERO & ""
        End If

        SaveFileDialog1.FileName = String.Empty
        If mFormatoXML Then SaveFileDialog1.FileName = "*" & cnEXT_FICHERO
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If mFormatoXML Then
                Dim intpos As Integer = InStr(1, SaveFileDialog1.FileName, cnEXT_FICHERO)
                If intpos = 0 Then
                    '//Si no ha encontrado la extensión cnEXT_FICHERO, se le pone dicha extensión
                    SaveFileDialog1.FileName = SaveFileDialog1.FileName & cnEXT_FICHERO
                End If
            End If
            Me.txtRutaFichero.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub cboBancoPropio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBancoPropio.ValueChanged
        If Not cboBancoPropio.SelectedItem Is Nothing Then
            lblccboBancoPropio.Text = cboBancoPropio.SelectedItem("DescBancoPropio") & String.Empty
            txtSufijoRemesa.Text = cboBancoPropio.SelectedItem("SufijoRemesas") & String.Empty
        Else
            lblccboBancoPropio.Text = String.Empty
            txtSufijoRemesa.Text = String.Empty
        End If
    End Sub

End Class
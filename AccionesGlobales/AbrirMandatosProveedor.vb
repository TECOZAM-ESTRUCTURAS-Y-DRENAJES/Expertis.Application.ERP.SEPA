Public Class AbrirMandatosProveedor
    Implements Engine.IAction

    Public Sub Execute(ByVal entityName As String, ByVal programID As System.Guid, ByVal record As System.Data.DataTable) Implements Engine.IAction.Execute
        If Not record Is Nothing AndAlso record.Rows.Count > 0 AndAlso Length(record.Rows(0)("IDProveedor")) > 0 Then
            General.AbrirConsultaMandato(Nothing, record.Rows(0)("IDProveedor"), Nothing)
        End If
    End Sub
End Class

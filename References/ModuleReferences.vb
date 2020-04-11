Module ModuleReferences
    Public Db As New ClsDataAccessLayer
    Public Tools As New ClsTools
    Public Convert As New ClsConvert
    Public Dialog As New UserControls.ClsDialog
    Public ActiveUser As ClsUser
    Public Formsp As New FrmSplashScreenLoading
    Public Inf As New ClsInformation
    Public SalMali As Integer
    Public Param As New ClsParametrs
    Public DtJobs As New DataTable
    Public Function IsNull(Expressesion As Object, Replacement_Value As Object) As Object
        If IsDBNull(Expressesion) Then
            Return Replacement_Value
        Else
            Return Expressesion
        End If
    End Function
    Public Function IsNothing(Expressesion As Object, Replacement_Value As Object) As Object
        If Expressesion Is Nothing Then
            Return Replacement_Value
        Else
            Return Expressesion
        End If
    End Function
End Module

Imports Common
Imports Permission
Module ModuleMain
    Public Db As New DAL.ClsDataAccessLayer
    Public Tools As New ClsTools
    Public Convert As New ClsConvert
    Public Dialog As New UserControls.ClsDialog
    Public ActiveUser As ClsUser
    Public Formsp As New FrmSplashScreenLoading
    Public Inf As New ClsInformation
End Module

Imports Microsoft.Win32
Public Class ClsRegistery
    Public Sub SetValue(KeyName As String, Value As String)
        Try
            Dim RK As RegistryKey
            RK = Registry.CurrentUser.OpenSubKey("Software", True)
            RK.CreateSubKey("Personel")
            RK = Registry.CurrentUser.OpenSubKey("Software\Personel", True)
            RK.SetValue(KeyName, Value)
            RK.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function GetValue(KeyName As String) As String
        Try
            Dim RK As RegistryKey
            RK = Registry.CurrentUser.OpenSubKey("Software\Personel", True)
            Return RK.GetValue(KeyName)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

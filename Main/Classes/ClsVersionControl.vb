
Public Class ClsVersionControl
    Dim FileByte As Byte()
    Dim cmd As New SqlClient.SqlCommand
    Public Sub AddLibrary(LibraryName As String, Path As String, Version As String)
        Try
            FileByte = System.IO.File.ReadAllBytes(Path & "\" & LibraryName & ".Dll")
            With cmd
                .CommandText = "Usp_RegLibrary"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@VERSION", Version)
                .Parameters.AddWithValue("@LIBRARYNAME", LibraryName)
                .Parameters.AddWithValue("@DATA", FileByte)
            End With
            If Db.ExecuteNonQuery(cmd, True) > 0 Then
                Dialog.ShowOK(LibraryName & " Inserted")
            Else
                Dialog.ShowInfo(LibraryName & " Not Inserted")
            End If
        Catch ex As Exception
            Dialog.ShowErorr(String.Format("Add Library Error '{0}'", LibraryName), ex.Message)
        End Try
    End Sub
    Public Sub AddApp(Path As String)
        ' Dim ExeName As String = "Login.exe"
        Dim ExeName As String = "Personel.exe"

        Try
            FileByte = System.IO.File.ReadAllBytes(Path & "\" & ExeName)
            With cmd
                .CommandText = "Usp_RegApp"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@DATA", FileByte)
            End With
            If Db.ExecuteNonQuery(cmd, True) > 0 Then
                Dialog.ShowOK(ExeName & " Inserted")
            Else
                Dialog.ShowInfo(ExeName & " Not Inserted")
            End If
        Catch ex As Exception
            Dialog.ShowErorr(String.Format("Add Exe Error '{0}'", ExeName), ex.Message)
        End Try
    End Sub
    Public Sub GetApp(Path As String)
        'Dim ExeName As String = "Login_New.exe"
        Dim ExeName As String = "Personel_New.exe"
        Try
            With cmd
                .CommandText = "Usp_GetLatestExe"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
            End With
            Dim Dt_Exe As New DataTable
            Dt_Exe = Db.FillDataTable(cmd, True)
            Dim Exe As Byte() = DirectCast(Dt_Exe.Rows(0).Item("Value"), Byte())
            System.IO.File.WriteAllBytes(Application.StartupPath & "\" & ExeName, Exe)
            Application.DoEvents()
            Dialog.ShowOK(String.Format("'{0}' Received", ExeName))
        Catch ex As Exception
            Dialog.ShowErorr(String.Format("Retrive The Exe File:'{0}' Error ", ExeName), ex.Message)
        End Try
    End Sub
    Public Sub AddFile()
        Dim File As New OpenFileDialog
        File.ShowDialog()


        Try
            FileByte = System.IO.File.ReadAllBytes(File.FileName)
            With cmd
                .CommandText = "[Usp_RegFile]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@DATA", FileByte)
                .Parameters.AddWithValue("@Name", File.SafeFileName)
            End With
            If Db.ExecuteNonQuery(cmd, True) > 0 Then
                dialog.ShowOK("File Inserted")
            Else
                dialog.ShowInfo("File Not Inserted")
            End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Public Function GetFiles() As DataTable
        Try
            With cmd
                .CommandText = "[Usp_GetFileNames]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
            End With
            Dim Dt As New DataTable
            Dt = Db.FillDataTable(cmd, True)
            Return Dt
        Catch ex As Exception
            Return Nothing
            Dialog.ShowErorr(ex.Message)
        End Try
    End Function
    Public Sub DeleteFile(Counter As String)
        Try
            With cmd
                .CommandText = "[Usp_DeleteFile]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@Counter", Counter)
            End With
            If Db.ExecuteNonQuery(cmd, True) > 0 Then
                Dialog.ShowOK("File Deleted")
            Else
                Dialog.ShowInfo("File Not Deleted")
            End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
    Public Sub SaveFile(Counter As String)
        Try
            With cmd
                .CommandText = "[Usp_GetFile]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@Counter", Counter)
            End With
            Dim Dt_File As New DataTable
            Dt_File = Db.FillDataTable(cmd, True)
            Dim Exe As Byte() = DirectCast(Dt_File.Rows(0).Item("Data"), Byte())
            Dim D As New SaveFileDialog
            D.ShowDialog()
            D.DefaultExt = Dt_File.Rows(0).Item("Name")
            System.IO.File.WriteAllBytes(D.FileName, Exe)
            Application.DoEvents()
            Dialog.ShowOK("File Saved")
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
End Class

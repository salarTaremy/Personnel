
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
        Dim ExeName As String = "personnel.exe"
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
        Dim ExeName As String = "personnel_New.exe"
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

End Class

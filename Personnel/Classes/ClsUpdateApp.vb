Imports System.Data.SqlClient
Imports System.Reflection

Public Class ClsUpdateApp
    Dim DtLibraryList As New DataTable
    Public Sub UpdateApp()
        Try
            DtLibraryList = GetListOfLibrary()
            For i As Integer = 0 To DtLibraryList.Rows.Count - 1
                Dim LbName As String = DtLibraryList.Rows(i).Item("LibraryName").ToString.Trim
                If System.IO.File.Exists(Application.StartupPath & "\" & LbName & ".Dll") = False Then
                    CopyLibrary(LbName)
                End If
            Next
            For i As Integer = 0 To DtLibraryList.Rows.Count - 1
                Dim LbName As String = DtLibraryList.Rows(i).Item("LibraryName").ToString.Trim
                ChengeFile(LbName)
            Next
            Update()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ChengeFile(LibraryName As String)
        Try
            If System.IO.File.Exists(Application.StartupPath & "\" & LibraryName & ".Tmp") Then
                Application.DoEvents()
                System.IO.File.Copy(Application.StartupPath & "\" & LibraryName & ".Tmp", Application.StartupPath & "\" & LibraryName & ".dll", True)
                Application.DoEvents()
                System.IO.File.Delete(Application.StartupPath & "\" & LibraryName & ".Tmp")
                Application.DoEvents()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Update()
        Try
         
            Dim DtVersion As New DataTable
            Dim DrVersion As DataRow
            DtVersion.Columns.Add("LibraryName")
            DtVersion.Columns.Add("Version")
            '--------------------------------
            For i As Integer = 0 To DtLibraryList.Rows.Count - 1
                Dim LbName As String = DtLibraryList.Rows(i).Item("LibraryName").ToString.Trim
                Dim asm = Assembly.LoadFrom(Application.StartupPath & "\" & LbName & ".dll")
                Dim obj As Object = asm.CreateInstance(LbName & ".ClsInformation")
                DrVersion = DtVersion.NewRow
                DrVersion.Item("LibraryName") = LbName
                DrVersion.Item("Version") = obj.Version
                DtVersion.Rows.Add(DrVersion)
            Next
            '--------------------------------
            Application.DoEvents()
            Dim cmd As New SqlClient.SqlCommand
            Dim Da As SqlDataAdapter
            Dim DtNewVersion As New DataTable
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Usp_GetLatestVersion"
            cmd.Parameters.AddWithValue("@ClientVersion", DtVersion)
            cmd.Connection = Conn2
            Da = New SqlDataAdapter(cmd)
            Da.Fill(DtNewVersion)
            '---------------------------
            If DtNewVersion.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim FrmUpdate As New FrmUpdating
            FrmUpdate.Show()
            Application.DoEvents()
            For i As Integer = 0 To DtNewVersion.Rows.Count - 1
                Dim Dll As Byte() = DirectCast(DtNewVersion.Rows(i).Item("Data"), Byte())
                Dim LibraryName As String = DtNewVersion.Rows(i).Item("LibraryName")
                System.IO.File.WriteAllBytes(Application.StartupPath & "\" & LibraryName & ".Tmp", Dll)
                Application.DoEvents()
            Next
            Application.DoEvents()
            Dim Dialog As New UserControls.ClsDialog
            Dialog.ShowOK(vbCrLf & "عملیات به روز رسانی با موفقیت انجام شد" & vbCrLf & "برای اعمال تغییرات برنامه باید مجددا را ه اندازی شود")
            FrmUpdate.Close()
            End
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CopyLibrary(LibraryName As String)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim Da As SqlDataAdapter
            Dim DtLibrary As New DataTable
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[dbo].[Usp_GetLatestLibrary]"
            cmd.Parameters.AddWithValue("@LibraryName", LibraryName)
            cmd.Connection = Conn2
            Da = New SqlDataAdapter(cmd)
            Da.Fill(DtLibrary)
            Dim Dll As Byte() = DirectCast(DtLibrary.Rows(0).Item("Data"), Byte())
            System.IO.File.WriteAllBytes(Application.StartupPath & "\" & LibraryName & ".Dll", Dll)
            Application.DoEvents()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function GetListOfLibrary() As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim Da As SqlDataAdapter
            Dim DtLibrary As New DataTable
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[dbo].[Usp_GetListOfLibrary]"
            cmd.Connection = Conn2
            Da = New SqlDataAdapter(cmd)
            Da.Fill(DtLibrary)
            Return DtLibrary
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

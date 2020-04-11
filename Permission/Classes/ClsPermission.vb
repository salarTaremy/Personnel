Public Class ClsPermission
    Public Function GetAllPermission(ID_User As Integer, FrmName As String) As DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Gn.UspGetPermission"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_User", ID_User)
        cmd.Parameters.AddWithValue("@FrmName", FrmName)
        Return Db.FillDataTable(cmd)
    End Function
    Public Sub Update(ID_User As Integer, FrmName As String, Dt_Permission As DataTable)
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Gn.UpdateObjectPermission"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_User", ID_User)
        cmd.Parameters.AddWithValue("@FrmName", FrmName)
        cmd.Parameters.AddWithValue("@lNK", Dt_Permission)
        If Db.ExecuteNonQuery(cmd) <> 0 Then
            Dialog.ShowOK("دسترسی کاربر جاری بروز رسانی شد")
        End If
    End Sub
    Public Sub SetPermissionForForms(Frm As ClsMyForms)
        Dim DT_permission As New DataTable
        Dim ObjName, ParentObject As String
        Dim IsVisible As Boolean
        DT_permission = GetAllPermission(ActiveUser.ID, Frm.Name.ToString.Trim)
        For i As Integer = 0 To DT_permission.Rows.Count - 1
            ObjName = DT_permission.Rows(i).Item("ObjectName").ToString.Trim
            IsVisible = DT_permission.Rows(i).Item("is_Visible")
            ParentObject = DT_permission.Rows(i).Item("ParentObject").ToString.Trim
            If ParentObject = "Form" Then
                If Frm.Controls(ObjName.ToString) IsNot Nothing Then
                    Frm.Controls(ObjName.ToString).Enabled = IsVisible
                End If
            Else
                If Frm.Controls(ParentObject).Controls(ObjName.ToString) IsNot Nothing Then
                    Frm.Controls(ParentObject).Controls(ObjName.ToString).Enabled = IsVisible
                End If
            End If
        Next

    End Sub

End Class

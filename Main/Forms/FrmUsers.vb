Imports Permission
Imports TarafHesab

Public Class FrmUsers
    Dim th As ClsTarafHesab
    Dim Users As ClsUser
    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub FillGrd()
        Users = New ClsUser
        Me.Grd.DataSource = Users.GetList
        Me.TxtUser.Text = Nothing
        Me.TxtPass.Text = Nothing
        Me.TxtPass2.Text = Nothing
        Me.ChkAdmin.Checked = False
        Me.TxtThID.Value = 0
        Grd.Columns("pass").IsVisible = False
        Grd.Columns("User_Name").HeaderText = "نام کاربری"
        Grd.Columns("isAdmin").HeaderText = "کاربر Admin"
        Grd.Columns("ID_Th").HeaderText = "کد طرف حساب"
        Grd.Columns("posName").HeaderText = "پست سازمانی"
        Grd.Columns("Name").HeaderText = "نام"
        Grd.Columns("famil").HeaderText = "نام خانوادگی"
    End Sub
    Private Sub BtnBrows_Click(sender As Object, e As EventArgs) Handles BtnBrows.Click
        th = New ClsTarafHesab
        th = th.Select_TarafHesab()
        If th Is Nothing Then
            Exit Sub
        End If
        TxtThID.Value = th.ID
    End Sub
    Private Sub TxtThID_ValueChanged(sender As Object, e As EventArgs) Handles TxtThID.ValueChanged
        th = New ClsTarafHesab(Me.TxtThID.Value)
        Me.TxtName.Text = th.LName
        Me.TxtFamil.Text = th.FName
    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If Me.TxtUser.Text = Nothing Then
            Dialog.ShowInfo("نام کاربری وارد نشده")
            Exit Sub
        End If
        If Me.TxtPass.Text = Nothing Then
            Dialog.ShowInfo("رمز عبور وارد نشده")
            Exit Sub
        End If
        If Me.TxtPass.Text.Trim <> Me.TxtPass2.Text.Trim Then
            Dialog.ShowInfo("رمز عبور مغایرت دارد")
            Exit Sub
        End If
        SaveUser()
        FillGrd()
    End Sub
    Private Sub SaveUser()
        Dim NewUser As New ClsUser(Me.TxtUser.Text.Trim)
        th = New ClsTarafHesab(Me.TxtThID.Value)
        If th.Exists Then
            NewUser.ID_Th = Me.TxtThID.Value
        End If
        NewUser.Pass = Me.TxtPass.Text.Trim
        NewUser.ISAdmin = Me.ChkAdmin.Checked
        NewUser.AddNew()
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        FillGrd()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.Grd.Rows.Count = 0 Then
            Dialog.ShowInfo("شما هیچ کاربری را انتخاب نکرده اید")
            Exit Sub
        End If
        Dim Frm As New FrmModifyUser
        Frm.UserName = Me.Grd.CurrentRow.Cells("User_Name").Value.ToString.Trim
        Frm.ShowDialog()

    End Sub
End Class
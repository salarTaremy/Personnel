Public Class FrmPermission
    Dim Permission As New ClsPermission
    Dim FrmName As String = Nothing
    Private Sub FrmPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrdUser()

    End Sub
    Private Sub FillGrdUser()
        Dim Users As New ClsUser
        Me.GrdUser.DataSource = Users.GetList
        GrdUser.Columns("pass").IsVisible = False
        GrdUser.Columns("User_Name").HeaderText = "نام کاربری"
        GrdUser.Columns("isAdmin").HeaderText = "کاربر Admin"
        GrdUser.Columns("ID_Th").IsVisible = False
        GrdUser.Columns("posName").IsVisible = False
        GrdUser.Columns("Name").HeaderText = "نام"
        GrdUser.Columns("famil").HeaderText = "نام خانوادگی"

    End Sub

    Private Sub GrdUser_RowsChanged() Handles GrdUser.CurrentRowChanged
        If Me.GrdUser.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim ID As Integer = GrdUser.CurrentRow.Cells("ID").Value
        Me.GrdPermission.DataSource = Me.Permission.GetAllPermission(ID, Me.FrmName)
        Me.GrdPermission.Columns("PersianName").HeaderText = "نام شئ"
        Me.GrdPermission.Columns("ObjectName").HeaderText = "نام لاتین"
        Me.GrdPermission.Columns("ObjectText").HeaderText = "شرح(متن)"
        Me.GrdPermission.Columns("ObjectType").IsVisible = False
        Me.GrdPermission.Columns("IS_Visible").HeaderText = "دسترسی"
        Me.GrdPermission.Columns("ID").IsVisible = False
    End Sub

    Public Sub New(FrmName As String)
        Me.FrmName = FrmName
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Dt_Permission As New DataTable
        Dim Dr_Permission As DataRow
        Dt_Permission.Columns.Add("Object_ID")
        Dt_Permission.Columns.Add("IS_Visible")
        For i As Integer = 0 To GrdPermission.Rows.Count - 1
            Dr_Permission = Dt_Permission.NewRow
            Dr_Permission.Item("Object_ID") = Me.GrdPermission.Rows(i).Cells("ID").Value
            Dr_Permission.Item("IS_Visible") = Me.GrdPermission.Rows(i).Cells("IS_Visible").Value
            Dt_Permission.Rows.Add(Dr_Permission)
        Next
        Dim UserID As Integer = Me.GrdUser.CurrentRow.Cells("ID").Value
        Me.Permission.Update(UserID, Me.FrmName, Dt_Permission)
        Me.Close()
    End Sub

    Private Sub ChkSelectAll_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles ChkSelectAll.ToggleStateChanged
        For i As Integer = 0 To Me.GrdPermission.Rows.Count - 1
            Me.GrdPermission.Rows(i).Cells("IS_Visible").Value = Me.ChkSelectAll.Checked
        Next
    End Sub
End Class
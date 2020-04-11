Imports System.Drawing
Imports System.Windows.Forms
Public Class ClsMyForms
    Inherits Windows.Forms.Form
    Dim _ShowSettingButton As Boolean = True
    Dim _DefaultTextBox As Telerik.WinControls.UI.RadTextBox = Nothing
    Dim _DefaultButton As Telerik.WinControls.UI.RadButton = Nothing
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ClsMyForms
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(712, 444)
        Me.Name = "ClsMyForms"
        Me.ResumeLayout(False)

    End Sub
    Public Property ShowSettingButton As Boolean
        Get
            Return _ShowSettingButton
        End Get
        Set(value As Boolean)
            _ShowSettingButton = value
        End Set
    End Property
    Private Sub Forms_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ActiveUser IsNot Nothing AndAlso ActiveUser.ISAdmin Then
            AddBtnSetting()
        ElseIf ActiveUser IsNot Nothing AndAlso ActiveUser.ISAdmin = False Then
            Dim permission As New ClsPermission
            permission.SetPermissionForForms(Me)
        End If
    End Sub
    Private Sub AddBtnSetting()
        Dim BtnSettings As New Telerik.WinControls.UI.RadButton
        With BtnSettings
            .Name = "BtnSettings"
            .Size = New Size(16, 16)
            .Location = New Point(0, 0)
            .ImageAlignment = ContentAlignment.MiddleCenter
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left
            .Visible = _ShowSettingButton
            .Image = My.Resources.Setting16
            .BringToFront()
        End With
        MyBase.Controls.Add(BtnSettings)
        MyBase.Controls("BtnSettings").BringToFront()
        AddHandler BtnSettings.Click, AddressOf BtnSettings_Click
    End Sub
    Private Sub BtnSettings_Click()
        Dim Dt_Object As New DataTable
        Dim Dr_Object As DataRow
        Dim j, i As Integer
        Dim Cmd As New SqlClient.SqlCommand
        With Dt_Object
            .Columns.Add("FrmName")
            .Columns.Add("FrmText")
            .Columns.Add("ObjectName")
            .Columns.Add("ObjectText")
            .Columns.Add("ObjectType")
            .Columns.Add("ParentObject")
        End With
        For i = 0 To MyBase.Controls.Count - 1
            If MyBase.Controls(i).GetType.ToString = "Telerik.WinControls.UI.RadGroupBox" Then
                For j = 0 To MyBase.Controls(i).Controls.Count - 1
                    Dr_Object = Dt_Object.NewRow
                    With Dr_Object
                        .Item("FrmName") = MyBase.Name
                        .Item("FrmText") = MyBase.Text
                        .Item("ObjectName") = MyBase.Controls(i).Controls(j).Name.Trim
                        .Item("ObjectText") = MyBase.Controls(i).Controls(j).Text.Trim
                        .Item("ObjectType") = MyBase.Controls(i).Controls(j).GetType.ToString.Trim
                        .Item("ParentObject") = MyBase.Controls(i).Name.Trim
                    End With
                    Dt_Object.Rows.Add(Dr_Object)
                Next
            End If
            Dr_Object = Dt_Object.NewRow
            With Dr_Object
                .Item("FrmName") = MyBase.Name
                .Item("FrmText") = MyBase.Text
                .Item("ObjectName") = MyBase.Controls(i).Name.Trim
                .Item("ObjectText") = MyBase.Controls(i).Text.Trim
                .Item("ObjectType") = MyBase.Controls(i).GetType.ToString.Trim
                .Item("ParentObject") = "Form"
            End With
            Dt_Object.Rows.Add(Dr_Object)
        Next
        Cmd.CommandText = "Gn.UspSyncObjectPermission"
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@FrmName", MyBase.Name.ToString.Trim)
        Cmd.Parameters.AddWithValue("@Obj", Dt_Object)
        Db.ExecuteNonQuery(Cmd)
        '======================================
        Dim frm As New FrmPermission(MyBase.Name.Trim)
        frm.ShowDialog()
    End Sub

    Public Sub New()
        Try
        MyBase.Font = New System.Drawing.Font("tahoma", 8.25)
        Me.Size = New System.Drawing.Size(1024, 600)
        MyBase.RightToLeft = Windows.Forms.RightToLeft.Yes
        Me.StartPosition = FormStartPosition.CenterParent
        Me.BackColor = Color.FromArgb(233, 240, 249)
        Dim Reg As New Common.ClsRegistery
            ActiveUser = New ClsUser(Reg.GetValue("User_Name").Trim)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub ClsMyForms_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Application.DoEvents()
        Formsp = New FrmSplashScreenLoading(MyBase.Text)
        Application.DoEvents()
        Formsp.Show()
        Application.DoEvents()
    End Sub
    Private Sub ClsMyForms_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If My.Computer.Keyboard.ShiftKeyDown AndAlso ActiveUser.ISAdmin Then
                Me.Text &= " " & Me.Name.ToString
                If My.Computer.Keyboard.CtrlKeyDown Then
                    My.Computer.Clipboard.SetText(Me.Name)
                End If
            End If
            Application.DoEvents()
            Formsp.Close()
            Application.DoEvents()
            If DefaultTextBox IsNot Nothing Then
                Me.DefaultTextBox.Focus()
            ElseIf DefaultButton IsNot Nothing Then
                Me.DefaultButton.Focus()
            End If
        Catch ex As Exception
            Formsp.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Property DefaultTextBox As Telerik.WinControls.UI.RadTextBox
        Get
            Return _DefaultTextBox
        End Get
        Set(value As Telerik.WinControls.UI.RadTextBox)
            _DefaultTextBox = value
        End Set
    End Property
    Public Property DefaultButton As Telerik.WinControls.UI.RadButton
        Get
            Return _DefaultButton
        End Get
        Set(value As Telerik.WinControls.UI.RadButton)
            _DefaultButton = value
        End Set
    End Property

End Class

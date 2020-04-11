Public Class ClsUser
    Dim Dt_User As New DataTable
    Dim cmd As New SqlClient.SqlCommand
    Dim _UserName As String = Nothing
    Dim _Exists As Boolean = False
    Dim _ISAdmin As Boolean = False
    Private Event UserNameChanged()
    Public Property ID As Integer
        Get
            Return Dt_User.Rows(0).Item("ID")
        End Get
        Set(value As Integer)
            Dt_User.Rows(0).Item("ID") = value
        End Set
    End Property
    Public Property User_Name As String
        Get
            Return _UserName
        End Get
        Set(value As String)
            _UserName = value
            RaiseEvent UserNameChanged()
        End Set
    End Property
    Public Property Exists As Boolean
        Get
            Return _Exists
        End Get
        Set(value As Boolean)
            _Exists = value
        End Set
    End Property
    Public Property Pass As String
        Get
            Return Dt_User.Rows(0).Item("pass").ToString()
        End Get
        Set(value As String)
            Dt_User.Rows(0).Item("pass") = value.Trim
        End Set
    End Property
    Public Property ISAdmin As Boolean
        Get
            _ISAdmin = Dt_User.Rows(0).Item("ISAdmin")
            Return _ISAdmin
        End Get
        Set(value As Boolean)
            _ISAdmin = value
            Dt_User.Rows(0).Item("ISAdmin") = _ISAdmin
        End Set
    End Property
    Public Property Name As String
        Get
            Return Dt_User.Rows(0).Item("Name").ToString()
        End Get
        Set(value As String)
            Dt_User.Rows(0).Item("Name") = value.Trim
        End Set
    End Property
    Public Property Famil As String
        Get
            Return Dt_User.Rows(0).Item("Famil").ToString()
        End Get
        Set(value As String)
            Dt_User.Rows(0).Item("Famil") = value.Trim
        End Set
    End Property
    Public Property ID_Th As String
        Get
            Return Dt_User.Rows(0).Item("ID_Th").ToString()
        End Get
        Set(value As String)
            Dt_User.Rows(0).Item("ID_Th") = value.Trim
        End Set
    End Property

    Public Sub New(Optional User_Name As String = Nothing)
        Me.User_Name = User_Name
    End Sub
    Private Sub UserNameChanging() Handles MyClass.UserNameChanged
        cmd = New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Gn.UspGetUsers"
            .Parameters.AddWithValue("@UserName", Me.User_Name)
        End With
        Dt_User = Db.FillDataTable(cmd)
        If Dt_User IsNot Nothing AndAlso Dt_User.Rows.Count > 0 Then
            Me.Exists = True
        Else
            Me.Exists = False
            Dim Dr_User As DataRow
            Dr_User = Dt_User.NewRow
            Dt_User.Rows.Add(Dr_User)
        End If
        If Me.User_Name IsNot Nothing Then
            Dt_User.Rows(0).Item("User_Name") = Me.User_Name
        End If
    End Sub
    Public Function GetList(Optional ID As Integer = Nothing) As DataTable
        'Dim cmd As New SqlClient.SqlCommand
        'cmd.CommandText = "[Gn].[UspGetUsers]"
        'cmd.CommandType = CommandType.StoredProcedure
        'Return Db.FillDataTable(cmd)
        Return Dt_User
    End Function
    Public Sub AddNew()
        If Exists Then
            Dialog.ShowInfo("این کاربر وجود دارد")
            Exit Sub
        End If
        Dt_User.Columns.Remove("Name")
        Dt_User.Columns.Remove("Famil")
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "GN.UspAddUser"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@users", Dt_User)
        If Db.ExecuteNonQuery(cmd) <> 0 Then
            Dialog.ShowOK("کاربر مورد نظر ثبت شد")
        End If
    End Sub
    Public Sub Modify()
        cmd = New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Gn.UspChangeUser"
            .Parameters.AddWithValue("@ID", Me.ID)
            .Parameters.AddWithValue("@NewPass", Me.Pass.Trim)
            .Parameters.AddWithValue("@IsAdmin", Me.ISAdmin)
        End With
        If Db.ExecuteNonQuery(cmd) <> 0 Then
            Dialog.ShowOK("عملیات با موفقیت انجام شد")
        End If
    End Sub


End Class

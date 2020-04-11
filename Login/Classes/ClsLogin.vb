Public Class ClsLogin
    Dim DB As New DAL.ClsDataAccessLayer()
    Dim Dt_user As New DataTable

    Public Sub New(Optional User_Name As String = Nothing)
        If User_Name IsNot Nothing Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ID,[USER_NAME],Pass,IsAdmin FROM Gn.Users  WHERE [User_Name] =  @User_Name"
            cmd.Parameters.AddWithValue("@User_Name", User_Name)
            Dt_user = DB.FillDataTable(cmd)
        End If
    End Sub
    Public ReadOnly Property User_Name As String
        Get
            If Exsists Then
                Return Dt_user.Rows(0).Item("User_Name")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property ID As Long
        Get
            If Exsists Then
                Return Dt_user.Rows(0).Item("ID")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Pass As String
        Get
            If Exsists Then
                Return Dt_user.Rows(0).Item("Pass")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property IsAdmin As Boolean
        Get
            If Exsists Then
                Return Dt_user.Rows(0).Item("IsAdmin")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Exsists As Boolean
        Get
            If Dt_user.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End Get
    End Property


End Class

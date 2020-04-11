Public Class SalMali
    Dim cmd As New SqlClient.SqlCommand
    Private _ID As Short
    Public Property ID() As Short
        Get
            Return _ID
        End Get
        Set(ByVal value As Short)
            _ID = value
        End Set
    End Property
    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Private _From As Integer
    Public Property From As Integer
        Get
            Return _From
        End Get
        Set(ByVal value As Integer)
            _From = value
        End Set
    End Property
    Private _Too As Integer
    Public Property Too As Integer
        Get
            Return _Too
        End Get
        Set(ByVal value As Integer)
            _Too = value
        End Set
    End Property
    Private _Exists As Boolean
    Public Property Exists As Boolean
        Get
            Return _Exists
        End Get
        Set(ByVal value As Boolean)
            _Exists = value
        End Set
    End Property
    Public Shared ReadOnly Property Value() As String
        Get
            Dim Reg As New ClsRegistery
            Return Reg.GetValue("SalMali")
        End Get
    End Property

    Public Sub New()
        Exists = False
    End Sub

    Public Sub New(ID As Short)
        Try
            Exists = False
            If ID > 0 Then
                Dim Dt_SalMali As New DataTable
                Dt_SalMali = GetSalMali(ID)
                If Dt_SalMali.Rows.Count = 0 Then
                    Exit Sub
                End If
                Me.ID = ID
                Me.Name = Dt_SalMali.Rows(0).Item("Name").ToString
                Me.From = Dt_SalMali.Rows(0).Item("From")
                Me.Too = Dt_SalMali.Rows(0).Item("To")
                ' Me.Too = ID
                Me.Exists = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetSalMali(Optional ID As Short = 0) As DataTable
        Try
            With cmd
                .CommandText = "[Cl].[UspGetFiscalYear]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                If ID > 0 Then
                    .Parameters.AddWithValue("@ID", ID)
                End If
            End With
            Return DB.FillDataTable(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Delete(ID As Short) As Integer
        Try
            With cmd
                .CommandText = "[Cl].[UspDeleteFiscalYear]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                If ID > 0 Then
                    .Parameters.AddWithValue("@ID", ID)
                End If
            End With
            Return DB.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Add(SalMali As SalMali) As Integer
        Try
            With cmd
                .CommandText = "[Cl].[UspAddFiscalYear]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", SalMali.ID)
                .Parameters.AddWithValue("@Name", SalMali.Name)
                .Parameters.AddWithValue("@From", SalMali.From)
                .Parameters.AddWithValue("@To", SalMali.Too)
            End With
            Return DB.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class

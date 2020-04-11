Public Class ClsDateTime
    Dim DtDateTime As New DataTable
    Public Sub New()
        FillDt()
    End Sub

    Private Sub FillDt()
        Try
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandText = "[Cl].[UspGetDate]"
                .CommandType = CommandType.StoredProcedure
                DtDateTime = DB.FillDataTable(cmd)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public ReadOnly Property Persian_Date() As Integer
        Get

            Return DtDateTime.Rows(0).Item("Persian_Date")
        End Get
    End Property
    Public ReadOnly Property Gregorian_Date() As Integer
        Get
            Return DtDateTime.Rows(0).Item("Gregorian_Date")
        End Get
    End Property
    Public ReadOnly Property DayOfWeek() As Byte
        Get
            Return DtDateTime.Rows(0).Item("DayOfWeek")
        End Get
    End Property
    Public ReadOnly Property Pr_DateDisplay() As String
        Get
            Return DtDateTime.Rows(0).Item("Pr_DateDisplay")
        End Get
    End Property
    Public ReadOnly Property Gr_DateDisplay() As String
        Get
            Return DtDateTime.Rows(0).Item("Gr_DateDisplay")
        End Get
    End Property
    Public ReadOnly Property Pr_Year() As Short
        Get
            Return DtDateTime.Rows(0).Item("Pr_Year")
        End Get
    End Property
    Public ReadOnly Property Gr_Year() As Short
        Get
            Return DtDateTime.Rows(0).Item("Gr_Year")
        End Get
    End Property
    Public ReadOnly Property Pr_Month() As Byte
        Get
            Return DtDateTime.Rows(0).Item("Pr_Month")
        End Get
    End Property
    Public ReadOnly Property Gr_Month() As Byte
        Get
            Return DtDateTime.Rows(0).Item("Gr_Month")
        End Get
    End Property

    Public ReadOnly Property Pr_Day() As Byte
        Get
            Return DtDateTime.Rows(0).Item("Pr_Day")
        End Get
    End Property
    Public ReadOnly Property Gr_Day() As Byte
        Get
            Return DtDateTime.Rows(0).Item("Gr_Day")
        End Get
    End Property
    Public ReadOnly Property Time() As String
        Get
            Return DtDateTime.Rows(0).Item("time")
        End Get
    End Property
End Class

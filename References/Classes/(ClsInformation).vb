Public Class ClsInformation
    'Refrence
    Public ReadOnly Property PersianToday
        Get
            Dim Uc As New UserControls.UcDatePicker
            Return Uc.GetPersianDate().Trim()
        End Get
    End Property
    Public ReadOnly Property PersianYear
        Get
            Dim Uc As New UserControls.UcDatePicker
            Return Mid(Uc.GetPersianDate().Trim(), 1, 4)
        End Get
    End Property
    Public ReadOnly Property Version As String
        Get
            Dim YY As String = "96"
            Dim MM As String = "04"
            Dim DD As String = "11"
            Dim HH As String = "15"
            Dim mmm As String = "20"
            Return YY & MM & DD & HH & mmm
        End Get
    End Property
End Class

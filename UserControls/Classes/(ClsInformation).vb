Public Class ClsInformation
    'UserControl
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
    'Public ReadOnly Property Version As String
    '    Get
    '        Dim YY As String = "96"
    '        Dim MM As String = "06"
    '        Dim DD As String = "26"
    '        Dim HH As String = "10"
    '        Dim mmm As String = "30"
    '        Return YY & MM & DD & HH & mmm
    '    End Get
    'End Property
    Public Function Version() As String
        Dim Ver As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString
        Ver = Ver.Replace(".", Nothing)
        Return Ver
    End Function
End Class

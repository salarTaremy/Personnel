Public Class ClsCodeMelli
    Dim _Code As String
    Public ReadOnly Property Code
        Get
            Return _Code
        End Get
    End Property
    Public Sub New(Code)
        _Code = Code
    End Sub
    Public ReadOnly Property ExistInTh As Boolean
        Get
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "SELECT TH.Code_melli  FROM [Th].[Taraf_Hesab] TH WHERE Th.Code_melli = @Code "
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@Code", _Code)
            If Db.FillDataTable(cmd).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property


    Public ReadOnly Property IsValid As Boolean
        Get
            If _Code.Trim.Length <> 10 Then
                Return False
            End If
            Dim Sum As Integer = 0
            Dim index As Integer = 1
            Dim ControlKey As Integer = Val(Mid(_Code, 10, 1))
            For i As Integer = 10 To 2 Step -1
                Sum += i * Val(Mid(Code, index, 1))
                index += 1
            Next
            Dim Baghimandeh As Integer = Sum Mod 11
            If Baghimandeh < 2 Then
                If ControlKey <> Baghimandeh Then
                    Return False
                End If
            Else
                If (11 - Baghimandeh) <> ControlKey Then
                    Return False
                End If
            End If
            Return True
        End Get
    End Property
End Class

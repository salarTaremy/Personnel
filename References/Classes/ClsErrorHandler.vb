Public Class ClsErrorHandler
    Dim ex As New Exception
    Dim ErrorMessagr As String = "انجام این عملیات در پایگاه داده معتبر نمیباشد"
    Public Sub New(ex_Exception As Exception)
        ex = ex_Exception
    End Sub
    Public Sub ToPersian()
        Dim Str As String = ex.Message
        Dim ColumnName As String = Nothing
        If Str.IndexOf("statement conflicted with the CHECK constraint") >= 0 Then
            Dim ConstraintName As String = Nothing
            ConstraintName = Mid(Str, Str.IndexOf(Chr(34)) + 2, Str.Length)
            ConstraintName = Mid(ConstraintName, 1, ConstraintName.IndexOf(Chr(34)))
            ColumnName = Mid(Str, Str.IndexOf("'") + 1, Str.LastIndexOf("'") - Str.IndexOf("'"))
            Dim CNN As New Constraints(ConstraintName)
            Str = Nothing
            Str &= "نام جدول: " & CNN.TblName & vbCrLf
            Str &= "نام ستون(فیلد): " & ColumnName & vbCrLf
            Str &= " محدودیت(شرط): " & vbCrLf & CNN.Definition & vbCrLf
            Dialog.ShowErorr(CNN.Detail, Str)
        ElseIf Str.IndexOf("Violation of UNIQUE KEY constraint") >= 0 Then
            Str = Mid(Str, Str.IndexOf(".") + 2, Str.LastIndexOf(".") - 1)
            Str = Replace(Str, ").", "")
            Str = Replace(Str, "(", "")
            Str = Replace(Str, "'.", vbCrLf)
            Str = Replace(Str, "'", Nothing)
            Str = Replace(Str, "Cannot insert duplicate key in object", "نام جدول:" & vbCrLf)
            Str = Replace(Str, "The duplicate key value is", "دیتای نا معتبر : " & vbCrLf)
            Dialog.ShowErorr("برخی از داده های وارد شده  یونیک میباشد و قبلا این مقدار در پایگاه داده ثبت شده است", Str)
        ElseIf Str.IndexOf("statement conflicted with the REFERENCE constraint") >= 0 Then
            Dim FkName As String = Nothing
            FkName = Mid(Str, Str.IndexOf(Chr(34)) + 2, Str.Length)
            FkName = Mid(FkName, 1, FkName.IndexOf(Chr(34)))
            ColumnName = Mid(Str, Str.IndexOf("'") + 1, Str.LastIndexOf("'") - Str.IndexOf("'"))
            Dim Rl As New Relation(FkName)
            Str = "این ستون از جدول با جدول دیگری در ارتباط است" & vbCrLf
            Str &= "نام جدول: " & Rl.TblName & vbCrLf
            Str &= "نام ستون(فیلد): " & ColumnName & vbCrLf
            Str &= "نام جدولی که با آن در ارتباط است : " & vbCrLf & Rl.TblParent & vbCrLf
            Dialog.ShowErorr("اطلاعات مورد نظر شما توسط سایر قسمت های سیستم مورد استفاده میباشد." & vbCrLf & "شما مجاز به حذف و یا تغییر این دیتا نمیباشید", Str)
        ElseIf Str.IndexOf("Cannot insert the value NULL into column") >= 0 Then
            ColumnName = Mid(Str, Str.IndexOf("'") + 2, Str.Length)
            ColumnName = Mid(ColumnName, 1, ColumnName.IndexOf("'"))
            ColumnName = ColumnName
            Dialog.ShowErorr("یکی از مقادیر وارد شده خالی میباشد و  شما بایستی برای این فیلد حتما یک مقدار معتبر وارد کنید", "نام لاتین ستون فوق:" & vbCrLf & ColumnName)
        ElseIf Str.IndexOf("Invalid object name") >= 0 Then
            Str = Mid(Str, 20, Str.Length - 20)
            Str = "هیچ شیئی با نام " & Str & " در پایگاه داده وجود ندارد"
            Dialog.ShowErorr(Str, ex.Message)
        Else
            Dialog.ShowErorr(ErrorMessagr, ex.Message)
        End If
    End Sub
    Private Class Constraints
        Dim Dt_Constraints As New DataTable
        Public Sub New(ConstraintName)
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "[Gn].[UspGetConstraintsDescription]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Name", ConstraintName)
            Dt_Constraints = Db.FillDataTable(cmd)
        End Sub
        Public ReadOnly Property Detail As String
            Get
                Return Dt_Constraints.Rows(0).Item("Detail")
            End Get
        End Property
        Public ReadOnly Property TblName As String
            Get
                Return Dt_Constraints.Rows(0).Item("TblName")
            End Get
        End Property
        Public ReadOnly Property Definition As String
            Get
                Return Dt_Constraints.Rows(0).Item("Definition")
            End Get
        End Property
    End Class
    Private Class Relation
        Dim Dt_Relation As New DataTable
        Public Sub New(FkName)
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "[Gn].[UspGetRelationConstraint]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@FkName", FkName)
            Dt_Relation = Db.FillDataTable(cmd)
        End Sub
        Public ReadOnly Property TblName As String
            Get
                Return Dt_Relation.Rows(0).Item("TblName")
            End Get
        End Property
        Public ReadOnly Property TblParent As String
            Get
                Return Dt_Relation.Rows(0).Item("TblParent")
            End Get
        End Property
    End Class
End Class

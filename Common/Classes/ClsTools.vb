Imports System.IO
Imports System.Data.OleDb
Imports System.Drawing

Public Class ClsTools
    Dim Db As New DAL.ClsDataAccessLayer
    Dim Dialog As New UserControls.ClsDialog
    ''' <summary>
    ''' این فانکشن برای ست کردن نام ستون مربوط به دیتا ست هایی است که باپیووت ساخته شده اند و نام  سر ستون های انها بصورت عددی است
    ''' </summary>
    ''' <param name="Grd">گریدی که قرار است نام سر ستون هایش عوض شود</param>
    ''' <param name="TblName">نام جدولی که ستون ها از آن  باید خوانده شود</param>
    ''' <param name="FieldName">نام فیلد که اختیاری است</param>
    ''' <remarks></remarks>
    Public Sub Grd_SetPivotHeaderText(Grd As Telerik.WinControls.UI.RadGridView, TblName As String, Optional FieldName As String = "PropertyName", Optional FormatString As String = Nothing, Optional TextAlignment As System.Drawing.ContentAlignment = ContentAlignment.MiddleCenter, Optional ColumnsWith As Integer = 0)
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[Th].[UspPivotHeader]"
            .Parameters.AddWithValue("@Table_Name", TblName)
            .Parameters.AddWithValue("@Field_Name", FieldName)
        End With
        '----------------------------------------------------------------------------------------
        Dim DT As New DataTable
        DT = Db.FillDataTable(cmd)
        If DT.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To DT.Rows.Count - 1
            Grd.Columns(DT.Rows(i).Item("ID").ToString).HeaderText = DT.Rows(i).Item(FieldName).ToString
            Grd.Columns(DT.Rows(i).Item("ID").ToString).TextAlignment = TextAlignment
            If FormatString IsNot Nothing Then
                Grd.Columns(DT.Rows(i).Item("ID").ToString).FormatString = FormatString
            End If
            If ColumnsWith > 0 Then
                Grd.Columns(DT.Rows(i).Item("ID").ToString).Width = ColumnsWith
            End If
        Next
    End Sub
    Public Function NumberToString(x As String) As String
        If x = "" Or x = Nothing Or x.Length > 19 Or Val(x.Trim) < 0 Then
            Return ""
        End If
        Dim one(10) As String
        Dim two(10) As String
        Dim Three(10) As String
        Dim Hundred(10) As String
        Dim Thousand As String
        Dim lakh As String
        Dim Crore As String
        Dim Billion As String
        Dim Million As String
        Dim Trillion As String
        one(0) = "صفر" : one(1) = "يک" : one(2) = "دو" : one(3) = "سه" : one(4) = "چهار"
        one(5) = "پنج" : one(6) = "شش" : one(7) = "هفت" : one(8) = "هشت" : one(9) = "نه"
        two(0) = "ده" : two(1) = "يازده" : two(2) = "دوازده" : two(3) = "سيزده" : two(4) = "چهارده"
        two(5) = "پانزده" : two(6) = "شانزده" : two(7) = "هفده" : two(8) = "هيجده" : two(9) = "نوزده"
        Three(2) = "بيست" : Three(3) = "سي" : Three(4) = "چهل" : Three(5) = "پنجاه"
        Three(6) = "شصت" : Three(7) = "هفتاد" : Three(8) = "هشتاد" : Three(9) = "نود"
        Hundred(1) = "يکصد" : Hundred(2) = "دويست" : Hundred(3) = "سيصد"
        Hundred(4) = "چهارصد" : Hundred(5) = "پانصد" : Hundred(6) = "ششصد"
        Hundred(7) = "هفتصد" : Hundred(8) = "هشتصد" : Hundred(9) = "نه صد"
        Thousand = "هزار" : lakh = " هزار" : Crore = " ميليون" : Billion = "ميليارد"
        Million = "بيليون" : Trillion = "تريليون"
        Dim inp As String = Nothing
        Dim RetVal As String = Nothing
        inp = CStr(CType(x, Int64))
        Select Case Len(inp)
            Case 1
                If x <> "" Then RetVal = one(CLng(x))
            Case 2
                If Int(CDbl(Strings.Right(inp, 1))) > 0 And CDbl(Strings.Left(inp, 1)) > 1 Then RetVal = " و " & NumberToString(CStr(Int(CDbl(Strings.Right(inp, 1)))))
                If CDbl(Strings.Left(inp, 1)) > 1 Then RetVal = Three(CLng(Strings.Left(inp, 1))) & RetVal
                If CDbl(Strings.Left(inp, 1)) = 1 Then RetVal = two(CLng(Strings.Right(inp, 1)))
            Case 3
                If Int(CDbl(Strings.Right(inp, 2))) > 0 Then RetVal = " و " & NumberToString(CStr(Int(CDbl(Strings.Right(inp, 2)))))
                RetVal = Hundred(Int(CDbl(Strings.Left(inp, 1)))) & RetVal
            Case 4
                If Int(CDbl(Strings.Right(inp, 3))) > 0 Then RetVal = " و " &
              NumberToString(CStr(Int(CDbl(Strings.Right(inp, 3)))))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 1)))) & Thousand & RetVal
            Case 5
                If Int(CDbl(Strings.Right(inp, 3))) > 0 Then RetVal = " و " & NumberToString(CStr(Int(CDbl(Strings.Right(inp, 3)))))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 2)))) & Thousand & RetVal
            Case 6
                If CLng(Strings.Right(inp, 5)) = 0 Then
                    RetVal = Hundred(Int(CDbl(Strings.Left(inp, 1)))) & lakh
                Else
                    If CLng(Strings.Right(inp, 3)) > 0 Then RetVal = " و " & NumberToString(CStr(CLng(Strings.Right(inp, 3))))
                    RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 3)))) & lakh & RetVal
                End If
            Case 7
                If CLng(Strings.Right(inp, 6)) > 0 Then RetVal = " و " & NumberToString(CStr(CLng(Strings.Right(inp, 6))))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 1)))) & Crore & RetVal
            Case 8
                If CLng(Strings.Right(inp, 6)) > 0 Then RetVal = " و " & NumberToString(CStr(CLng(Strings.Right(inp, 6))))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 2)))) & Crore & RetVal
            Case 9
                If CLng(Strings.Right(inp, 6)) > 0 Then RetVal = " و " & NumberToString(CStr(CLng(Strings.Right(inp, 6))))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 3)))) & Crore & RetVal
            Case 10
                If CLng(Strings.Right(inp, 9)) > 0 Then RetVal = " و " & NumberToString(CStr(CLng(Strings.Right(inp, 9))))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 1)))) & Billion & RetVal
            Case 11
                If CLng(Strings.Right(inp, 9)) > 0 Then RetVal = " و " & NumberToString(CStr(CLng(Strings.Right(inp, 9))))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 2)))) & Billion & RetVal
            Case 12
                If Val(Strings.Right(inp, 9)) > 0 Then RetVal = " و " & NumberToString(Strings.Right(inp, 9))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 3)))) & Million & RetVal
            Case 13
                If Val(Strings.Right(inp, 12)) > 0 Then RetVal = " و " & NumberToString(Strings.Right(inp, 12))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 1)))) & Million & RetVal
            Case 14
                If Val(Strings.Right(inp, 12)) > 0 Then RetVal = " و " & NumberToString(Strings.Right(inp, 12))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 2)))) & Trillion & RetVal
            Case 15
                If Val(Strings.Right(inp, 12)) > 0 Then RetVal = " و " & NumberToString(Strings.Right(inp, 12))
                RetVal = NumberToString(Int(CDbl(Strings.Left(inp, 3)))) & Trillion & RetVal
        End Select
        NumberToString = " " & RetVal & " "
        NumberToString = Replace(NumberToString, "  ", " ")
    End Function
    Public Sub ShowHelp(ID As Long)
        Try
            Dim DtHelp As New DataTable
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "[dbo].[Usp_GetHelpMessage]"
            cmd.Parameters.AddWithValue("@ID", ID)
            cmd.CommandType = CommandType.StoredProcedure
            DtHelp = Db.FillDataTable(cmd, True)
            Dialog.ShowHelp(DtHelp.Rows(0).Item(1).ToString, DtHelp.Rows(0).Item(0).ToString)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function IsNull(Expressesion As Object, Replacement_Value As Object) As Object
        If IsDBNull(Expressesion) Then
            Return Replacement_Value
        Else
            Return Expressesion
        End If
    End Function
    Public Function IsNothing(Expressesion As Object, Replacement_Value As Object) As Object
        If Expressesion Is Nothing Then
            Return Replacement_Value
        Else
            Return Expressesion
        End If
    End Function
End Class

Imports System.Windows.Forms

Public Class FrmPersonnelImportWork
    Dim pr1 As New ClsPersonel()
    Dim pr2 As New ClsPersonel()
    Dim Pw As New ClsPersonnelWork
    Dim code1 As String = Nothing
    Dim code2 As String = Nothing
    Private Sub BtnOpenFile_Click(sender As Object, e As EventArgs) Handles BtnOpenFile.Click
        Try
            Dim File As New OpenFileDialog
            With File
                .Filter = "Pwkaraفایل متنی با فرمت دستگاه|*.Txt|Csv فایل|*.Csv"
                .ShowDialog()
                If .FileName = Nothing Then
                    Exit Sub
                End If
            End With
            Dim dt As New DataTable
            dt = Convert.CsvToDatatableManual(File.FileName)
            Me.Grd.DataSource = dt
        Catch ex As Exception
            Dialog.ShowErorr("خطا در خواندن فایل", ex.Message)
        End Try

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If pr1.Exists Then
                code1 = pr1.CodePersoneli.Trim
            Else
                code1 = Nothing
            End If
            If pr2.Exists Then
                code2 = pr1.CodePersoneli.Trim
            Else
                code2 = Nothing
            End If
            Dim RowAffect As Integer = Pw.AddPersonnelWork(Me.Grd.DataSource, UcDatePicker1.TxtInt.ToString, UcDatePicker2.TxtInt.ToString, code1, code2)
            If RowAffect > 0 Then
                Dim Msg As String = String.Format("تعداد '{0}' ردیف با موفقیت ثبت شد", RowAffect)
                Dialog.ShowOK(Msg)
            Else
                Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی ثبت نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه سیستم قادر به ارسال اطلاعات به پایگاه داده نمیباشد", ex.Message)
        End Try
    End Sub
    Private Sub TxtPrID1_ValueChanged(sender As Object, e As EventArgs) Handles TxtPrID1.ValueChanged
        pr1 = New ClsPersonel(Me.TxtPrID1.Value)
        TxtName1.Text = pr1.Name & " " & pr1.Famil
    End Sub
    Private Sub BtnBrows1_Click(sender As Object, e As EventArgs) Handles BtnBrows1.Click
        pr1 = New ClsPersonel()
        Me.TxtPrID1.Value = pr1.SelectPersonID()
    End Sub
    Private Sub TxtPrID2_ValueChanged(sender As Object, e As EventArgs) Handles TxtPrID2.ValueChanged
        pr2 = New ClsPersonel(Me.TxtPrID2.Value)
        TxtName2.Text = pr2.Name & " " & pr2.Famil
    End Sub
    Private Sub BtnBrows2_Click(sender As Object, e As EventArgs) Handles BtnBrows2.Click
        pr2 = New ClsPersonel()
        Me.TxtPrID2.Value = pr2.SelectPersonID()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If pr1.Exists Then
                code1 = pr1.CodePersoneli.Trim
            Else
                code1 = Nothing
            End If
            If pr2.Exists Then
                code2 = pr2.CodePersoneli.Trim
            Else
                code2 = Nothing
            End If
            Dim Msg As String = String.Format("آیا برای حذف کارکرد  از تاریخ '{0}' تا تاریخ '{1}' اطمینان دارید ؟؟" & vbCrLf & "از کد پرسنلی : '{2}'" & vbCrLf & "تا کد پرسنلی : '{3}'", UcDatePicker1.txt, UcDatePicker2.txt, code1, code2)
            If Dialog.ShowQuestion(Msg) = False Then
                Exit Sub
            End If
            Dim RowAffect As Integer = Pw.DeletePersonnelWork(UcDatePicker1.TxtInt.ToString, UcDatePicker2.TxtInt.ToString, code1, code2)
            If RowAffect > 0 Then
                Msg = String.Format("تعداد '{0}' ردیف با موفقیت حذف شد", RowAffect)
                Dialog.ShowOK(Msg)
            Else
                Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی حذف نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه سیستم قادر به حذف اطلاعات از پایگاه داده نمیباشد", ex.Message)
        End Try
    End Sub

    Private Sub FrmPersonnelImportWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth)
        Me.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth)
    End Sub
End Class
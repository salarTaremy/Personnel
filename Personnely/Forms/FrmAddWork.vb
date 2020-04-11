Public Class FrmAddWork
    Dim Person As New ClsPersonel
    Dim Pw As New ClsPersonnelWork
    Private Sub BtnBrows_Click(sender As Object, e As EventArgs) Handles BtnBrows.Click
        Me.TxtPrID.Value = Person.SelectPersonID()
    End Sub
    Private Sub TxtPrID_ValueChanged(sender As Object, e As EventArgs) Handles TxtPrID.ValueChanged
        Person = New ClsPersonel(Me.TxtPrID.Value.ToString)
        Me.TxtName.Text = Person.Name & " " & Person.Famil
    End Sub

    Private Sub FrmAddWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCmb()
        If Me.UcDatePicker1.TxtInt = 0 Then
            Me.UcDatePicker1.txt = Inf.PersianToday
        End If
    End Sub
    Private Sub FillCmb()
        Try
            With Me.CmbActions
                .DisplayMember = "Name"
                .ValueMember = "ID"
                .DataSource = Pw.GetAllActions()
            End With
        Catch ex As Exception
            Dialog.ShowErorr("مشکلی در بارگذاری فرم جاری بوجود آمد", ex.Message)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If Not Person.Exists Then
                Dialog.ShowInfo("لطفا کد پرسنلی معتبری وارد کنید")
                Exit Sub
            End If
            Dim Action As Integer
            If RadIn.IsChecked Then
                Action = 0
            ElseIf RadOut.IsChecked Then
                Action = Me.CmbActions.SelectedValue
            End If
            If Pw.AddPersonnelWorkManual(Person.CodePersoneli, Me.UcDatePicker1.TxtInt, UcTimePicker1.Txt, Me.CmbActions.SelectedValue) > 0 Then
                Dialog.ShowOK("اطلاعات کرکرد با موفقیت ذخیره شد")
                Me.Close()
            Else
                Dialog.ShowInfo("متاسفانه کارکرد مورد نظر شما ثبت نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("مشکلی در ذخیره اطلاعات جاری بوجود آمد", ex.Message)
        End Try

    End Sub
End Class
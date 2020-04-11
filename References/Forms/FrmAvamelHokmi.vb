Public Class FrmAvamelHokmi
    Dim AvameleHokmi As New ClsHokm.Avamel
    Private Sub FrmAvamelHokmi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAllCmb()
        FillGrid()
    End Sub
    Private Sub FillAllCmb()
        Try
            Dim Ds_AvameleHokmi As New DataSet
            Ds_AvameleHokmi = AvameleHokmi.GetAllInfo()
            Me.CmbType.DisplayMember = "Value"
            Me.CmbType.ValueMember = "ID"
            Me.CmbType.DataSource = Ds_AvameleHokmi.Tables(0)
            Me.CmbMethod.DisplayMember = "Value"
            Me.CmbMethod.ValueMember = "ID"
            Me.CmbMethod.DataSource = Ds_AvameleHokmi.Tables(1)
            Me.CmbBase.DisplayMember = "Value"
            Me.CmbBase.ValueMember = "ID"
            Me.CmbBase.DataSource = Ds_AvameleHokmi.Tables(2)
        Catch ex As Exception
            Dialog.ShowErorr("خطایی در بارگذاری اطلاعات اولیه فرم رخ داد", ex.Message)
        End Try
    End Sub
    Private Function IsValidData() As Boolean
        If Me.TxtName.Text.Trim = "" Or Me.TxtName.Text = Nothing Then
            Dialog.ShowInfo("لطفا نام عامل را وارد کنید")
            Return False
        End If
        If Me.CmbType.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا نوع عامل را مشخص کنید")
            Return False
        End If
        If Me.CmbMethod.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا روش محاسبه را مشخص کنید")
            Return False
        End If
        If Me.CmbBase.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا مبنای محاسبه را مشخص کنید")
            Return False
        End If
        If Not ChkDefault.Checked Then
            If Me.CmbMethod.SelectedValue = 1 Then 'sabet
                If Val(Me.TxtDefult.Text.Trim) <= 0 Then
                    Dialog.ShowInfo("لطفامبلغ پیش فرض را وارد کنید  یا تیک  تغیر مقدار پیش فرض را بزنید")
                    Return False
                End If
            Else ' darsadi
                If Me.TxtDarsad.Value <= 0 Then
                    Dialog.ShowInfo("لطفادرصد پیش فرض را وارد کنید  یا تیک  تغیر مقدار پیش فرض را بزنید")
                    Return False
                End If
            End If
        End If
        Return True
    End Function
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Amel As New ClsHokm.Avamel.Amel
        Try
            If Not IsValidData() Then
                Exit Sub
            End If
            Amel.ID_AmelBaseCalculate = Me.CmbBase.SelectedValue
            Amel.ID_AmelCalculateMethod = Me.CmbMethod.SelectedValue
            Amel.ID_AmelType = Me.CmbType.SelectedValue
            Amel.Name = Me.TxtName.Text
            Amel.Priority = Me.TxtOlaviat.Value
            Amel.Insurance = Me.ChkBime.Checked
            Amel.Taxable = Me.ChkTax.Checked
            Amel.Detail = Me.TxtDetail.Text
            If Me.CmbMethod.SelectedValue = 1 Then 'sabet
                Amel.DefaultValue = Me.TxtDefult.Text
            ElseIf Me.CmbMethod.SelectedValue = 2 Then 'darsad
                Amel.DefaultValue = Me.TxtDarsad.Value
            End If
            Amel.AlowChengeDefaultValue = Me.ChkDefault.Checked
            If AvameleHokmi.AddNew(Amel) > 0 Then
                Dialog.ShowOK("اطلاعات با موفقیت ثبت شد")
                FillGrid()
                Me.CmbBase.SelectedValue = 0
                Me.CmbMethod.SelectedValue = 0
                Me.CmbType.SelectedValue = 0
                Me.TxtDarsad.Value = 0
                Me.TxtDefult.Text = Nothing
                Me.TxtName.Text = Nothing
                Me.TxtOlaviat.Value = TxtOlaviat.Value + 1
                Me.ChkDefault.Checked = True
            End If
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه اطلاعات ذخیره نشد")
        End Try
    End Sub
    Private Sub FillGrid()
        Me.Grd.DataSource = AvameleHokmi.GetListOfAvamel
        With Me.Grd
            '.Columns("ID").HeaderText = ""
            .Columns("Name").HeaderText = "شرح"
            .Columns("TypeValue").HeaderText = "نوع عامل"
            .Columns("DefaultValue").HeaderText = "مقدار پیش فرض"
            .Columns("CalcValue").HeaderText = "روش محاسبه"
            .Columns("BaseValue").HeaderText = "مبنای محاسبه"
            .Columns("Priority").HeaderText = "اولویت"
            .Columns("AlowChengeDefaultValue").HeaderText = "امکان تغییر" & vbCrLf & "مقدار پیش فرض"
            .Columns("Insurance").HeaderText = "مشمول بیمه"
            .Columns("Taxable").HeaderText = "مشمول مالیات"
            .Columns("Detail").HeaderText = "توضیحات"
        End With
    End Sub

    Private Sub CmbMethod_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbMethod.SelectedValueChanged
        If Me.CmbMethod.SelectedValue = 1 Then 'Sabet
            Me.LblDarsad.Visible = False
            Me.TxtDarsad.Visible = False
            Me.LblRls.Visible = True
            Me.TxtDefult.Visible = True
            Me.LblDefault.Visible = True
            Me.CmbBase.SelectedValue = 1
            Me.CmbBase.Enabled = False
        ElseIf Me.CmbMethod.SelectedValue = 2 Then ' darsadi
            Me.LblDarsad.Visible = True
            Me.TxtDarsad.Visible = True
            Me.LblRls.Visible = False
            Me.TxtDefult.Visible = False
            Me.LblDefault.Visible = True
            Me.CmbBase.SelectedValue = 0
            Me.CmbBase.Enabled = True
        Else
            Me.LblDarsad.Visible = False
            Me.TxtDarsad.Visible = False
            Me.LblRls.Visible = False
            Me.TxtDefult.Visible = False
            Me.LblDefault.Visible = False
            Me.CmbBase.SelectedValue = 0
            Me.CmbBase.Enabled = True
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If Me.Grd.CurrentRow Is Nothing Then
                Exit Sub
            End If
        If Me.Grd.Rows.Count = 0 Then
            Dialog.ShowInfo("هیچ موردی برای حذف موجود نیست")
            Exit Sub
        End If
            Dim Msg As String = String.Format("آیا برای حذف '{0}' مطمئن هستید ؟؟", Me.Grd.CurrentRow.Cells("Name").Value)
            If Dialog.ShowQuestion(Msg) Then
                If AvameleHokmi.Delete(Me.Grd.CurrentRow.Cells("ID").Value) > 0 Then
                    Dialog.ShowOK("گزینه مورد نظر با موفقیت حذف شد")
                    FillGrid()
                End If
            End If
        Catch ex As Exception
            Dialog.ShowErorr(ex.Message)
        End Try
    End Sub
End Class
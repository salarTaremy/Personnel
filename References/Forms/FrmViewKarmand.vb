Public Class FrmViewKarmand
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim CMD As New SqlClient.SqlCommand
            With CMD
                .CommandText = "[Pr].[UspGetPersonel]"
                .CommandType = CommandType.StoredProcedure
                If Me.TxtAzID_PR.Value > 0 Then
                    .Parameters.AddWithValue("@START_ID", Me.TxtAzID_PR.Value)
                End If
                If Me.TxtTaID_PR.Value > 0 Then
                    .Parameters.AddWithValue("@END_ID", Me.TxtTaID_PR.Value)
                End If
                If Me.TxtAzCodePr.Text <> Nothing And Me.TxtAzCodePr.Text <> "" Then
                    .Parameters.AddWithValue("@START_Code", Me.TxtAzCodePr.Text.Trim)
                End If
                If Me.TxtTaCodePr.Text <> Nothing And Me.TxtTaCodePr.Text <> "" Then
                    .Parameters.AddWithValue("@END_Code", Me.TxtTaCodePr.Text.Trim)
                End If
                If Me.TxtAzID_TH.Value > 0 Then
                    .Parameters.AddWithValue("@START_ID_TH", Me.TxtAzID_TH.Value)
                End If
                If Me.TxtTaID_TH.Value > 0 Then
                    .Parameters.AddWithValue("@END_ID_TH", Me.TxtTaID_TH.Value)
                End If
                If Me.TxtName.Text <> Nothing Then
                    .Parameters.AddWithValue("@NAME_FAMIL", Me.TxtName.Text)
                End If
                If Me.TxtCode_melli.Text <> Nothing Then
                    .Parameters.AddWithValue("@CODE_MELLI", Me.TxtCode_melli.Text)
                End If
            End With
            Me.Grd.DataSource = Db.FillDataTable(CMD)
            Tools.Grd_SetPivotHeaderText(Me.Grd, "pr.Property")
            With Me.Grd
                If .Columns.Count > 0 Then
                    'If .Columns.Contains("ID") Then .Columns("ID").HeaderText = ""
                    If .Columns.Contains("ID_TarafHesab") Then .Columns("ID_TarafHesab").HeaderText = "کد طرف حساب"
                    If .Columns.Contains("CodePersoneli") Then .Columns("CodePersoneli").HeaderText = "کد پرسنلی"
                    If .Columns.Contains("ShomarehBime") Then .Columns("ShomarehBime").HeaderText = "شماره بیمه"
                    If .Columns.Contains("ChildCount") Then .Columns("ChildCount").HeaderText = "تعداد فرزند"
                    If .Columns.Contains("NAME") Then .Columns("NAME").HeaderText = "نام"
                    If .Columns.Contains("Famil") Then .Columns("Famil").HeaderText = "نام خانوادگی"
                    If .Columns.Contains("Code_melli") Then .Columns("Code_melli").HeaderText = "کد ملی"
                    If .Columns.Contains("Code_Eghtesadi") Then .Columns("Code_Eghtesadi").HeaderText = "کد اقتصادی"
                    If .Columns.Contains("BirthDay") Then .Columns("BirthDay").HeaderText = "تاربخ تولد"
                    If .Columns.Contains("Din") Then .Columns("Din").HeaderText = "دین"
                    If .Columns.Contains("Jensiat") Then .Columns("Jensiat").HeaderText = "جنسیت"
                    If .Columns.Contains("MadrakTahsili") Then .Columns("MadrakTahsili").HeaderText = "تحصیلات"
                    If .Columns.Contains("Mazhab") Then .Columns("Mazhab").HeaderText = "مذهب"
                    If .Columns.Contains("Melliat") Then .Columns("Melliat").HeaderText = "ملیت"
                    If .Columns.Contains("NezamVazifeh") Then .Columns("NezamVazifeh").HeaderText = "نظام وظیفه"
                    If .Columns.Contains("Taahol") Then .Columns("Taahol").HeaderText = "وضعیت تاهل"
                    If .Columns.Contains("Tabeiyat") Then .Columns("Tabeiyat").HeaderText = "تابعیت"
                    If .Columns.Contains("Photo") Then .Columns("Photo").HeaderText = "تصویر پرسنلی"
                    If .Columns.Contains("VaziatKhedmat") Then .Columns("VaziatKhedmat").HeaderText = "وضعیت خدمت"
                    If .Columns.Contains("HokmCount") Then .Columns("HokmCount").HeaderText = "تعداد احکام صادره"
                    If .Columns.Contains("ID_Din") Then .Columns("ID_Din").IsVisible = False
                    If .Columns.Contains("ID_Jensiat") Then .Columns("ID_Jensiat").IsVisible = False
                    If .Columns.Contains("ID_MadrakTahsili") Then .Columns("ID_MadrakTahsili").IsVisible = False
                    If .Columns.Contains("ID_Mazhab") Then .Columns("ID_Mazhab").IsVisible = False
                    If .Columns.Contains("ID_Melliat") Then .Columns("ID_Melliat").IsVisible = False
                    If .Columns.Contains("ID_NezamVazifeh") Then .Columns("ID_NezamVazifeh").IsVisible = False
                    If .Columns.Contains("ID_Taahol") Then .Columns("ID_Taahol").IsVisible = False
                    If .Columns.Contains("ID_Tabeiyat") Then .Columns("ID_Tabeiyat").IsVisible = False
                    If .Columns.Contains("ID_VaziatKhedmat") Then .Columns("ID_VaziatKhedmat").IsVisible = False
                End If
            End With
            SetPhotoVisible(Me.ChkPhoto.Checked)
        Catch ex As Exception
            Dialog.ShowErorr("سیستم قادر به خواند اطلاعات پرسنل نمیباشد", ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.Grd.Rows.Count = 0 Then
            Dialog.ShowInfo("شما هیچ ایتمی را انتخاب نکرده اید")
            Exit Sub
        End If
        If Me.Grd.CurrentRow.Cells("HokmCount").Value > 0 Then
            Dim Msg As String = "برای'{0}'  تاکنون  '{1}'  فقره حکم صادر شده است." & vbCrLf & "لطفا ابتدا احکام این کارمند را حذف کنید سپس نسبت به حذف این کامند اقدام کنید"
            Dialog.ShowInfo(String.Format(Msg, Me.Grd.CurrentRow.Cells("NAME").Value + " " + Me.Grd.CurrentRow.Cells("Famil").Value, Me.Grd.CurrentRow.Cells("HokmCount").Value))
            Exit Sub
        End If
        Dim pr As New ClsPersonel
        pr.ID = Me.Grd.CurrentRow.Cells("ID").Value
        If Not pr.Delete() Then
            'Dialog.ShowInfo("کارمند حذف نشد")
        Else
            BtnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Frm As New FrmKarmand
        Frm.ShowDialog()
        BtnSearch_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim Frm As New FrmKarmand
        Frm.Mode = FrmKarmand.My_Mode.Edit
        Frm.Pr = New ClsPersonel(Me.Grd.CurrentRow.Cells("ID").Value)
        'Frm.DefaultThID = Me.Grd.CurrentRow.Cells("ID_TarafHesab").Value
        Frm.ShowDialog()
        Me.BtnSearch_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Me.Grd.ChildRows.Count <= 0 Then
            Dialog.ShowInfo("شما هیچ کارمندی انتخاب نکرده اید")
            Exit Sub
        End If
        If Me.Grd.SelectedRows.Count = 0 Then
            Dialog.ShowInfo("شما هیچ کارمندی انتخاب نکرده اید")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Public ReadOnly Property SelectedPersonID As Integer
        Get
            If Me.Grd.ChildRows.Count <= 0 Then
                Return 0
            End If
            If Me.Grd.CurrentRow Is Nothing Then
                Return 0
            End If
            Return Me.Grd.CurrentRow.Cells("ID").Value
        End Get
    End Property
    Public ReadOnly Property SelectedPr As ClsPersonel.SelectedPersonnel
        Get
            If Me.Grd.ChildRows.Count <= 0 Then
                Return Nothing
            End If
            If Me.Grd.CurrentRow Is Nothing Then
                Return Nothing
            End If
            Dim ReturmPr As ClsPersonel.SelectedPersonnel
            With ReturmPr
                .FullName = Me.Grd.CurrentRow.Cells("Name").Value & " " & Me.Grd.CurrentRow.Cells("Famil").Value
                .ID = Me.Grd.CurrentRow.Cells("ID").Value
                .ThID = Me.Grd.CurrentRow.Cells("ID_TarafHesab").Value
                .CodePersonneli = Me.Grd.CurrentRow.Cells("CodePersoneli").Value
            End With
            Return ReturmPr
        End Get
    End Property

    Private Sub ChkPhoto_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles ChkPhoto.ToggleStateChanged
        SetPhotoVisible(args.ToggleState)
    End Sub
    Public Sub SetPhotoVisible(Valye As Boolean)
        Me.Grd.AutoSizeRows = Valye
        If Grd.Columns.Contains("Photo") Then
            Me.Grd.Columns("Photo").IsVisible = Valye
        End If
    End Sub

End Class
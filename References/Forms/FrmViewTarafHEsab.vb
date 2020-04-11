Public Class FrmViewTarafHEsab
    Private Sub RadSpinEditor1_ValueChanged(sender As Object, e As EventArgs) Handles TxtAzID.ValueChanged
    End Sub
    Public tarafhesab As New ClsTarafHesab
    Dim IsDeclaredToPersonel As PersonelStatus = PersonelStatus.AllTarafhesab
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "th.UspGetFullTarafHesab"
            .Parameters.AddWithValue("@IsDeclaredToPersonel", IsDeclaredToPersonel)
            If Me.TxtAzID.Value > 0 Then
                .Parameters.AddWithValue("@Start_ID", Me.TxtAzID.Value)
            End If
            If Me.TxtTaID.Value > 0 Then
                .Parameters.AddWithValue("@end_ID", Me.TxtTaID.Value)
            End If
            If Me.TxtCode_melli.Text <> "" Then
                .Parameters.AddWithValue("@CODE_MELLI", Me.TxtCode_melli.Text.Trim)
            End If
            If Me.TxtName.Text <> "" Then
                .Parameters.AddWithValue("@TH_Name", Me.TxtName.Text.Trim)
            End If
        End With
        Me.Grd.DataSource = Db.FillDataTable(cmd)
        Tools.Grd_SetPivotHeaderText(Me.Grd, "th.properties")

        Grd.Columns("Name").HeaderText = "نام"
        Grd.Columns("Famil").HeaderText = "نام خانوادگی"
        Grd.Columns("code_melli").HeaderText = "کد ملی"
        Grd.Columns("code_eghtesadi").HeaderText = "کد اقتصادی"
        Grd.Columns("birthday").HeaderText = "تاریخ تولد"
        Grd.Columns("MahalTavalod").HeaderText = "محل تولد"
        Grd.Columns("MahalSodoor").HeaderText = "محل صدور"
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.Grd.Rows.Count = 0 Then
            Dialog.ShowInfo("شما هیچ ایتمی را انتخاب نکرده اید")
            Exit Sub
        End If
        Dim f As New FrmAddAndEditTarafHesab(Me.Grd.CurrentRow.Cells("ID").Value)
        f.ShowDialog()
        BtnSearch_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.Grd.Rows.Count = 0 Then
            Dialog.ShowInfo("شما هیچ ایتمی را انتخاب نکرده اید")
            Exit Sub
        End If
        Dim pr As New ClsPersonel
        pr.ID_TarafHesab = Me.Grd.CurrentRow.Cells("ID").Value
        If pr.Exists Then
            Dialog.ShowInfo("این طرف حساب در سیستم پرسنلی تعیف شده و شما مجاز به حذف آن نمیباشید")
            Exit Sub
        End If
        Dim th As New ClsTarafHesab(Me.Grd.CurrentRow.Cells("ID").Value)
        If th.Delete() Then
            BtnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Frm As New FrmAddAndEditTarafHesab
        Frm.ShowDialog()
    End Sub

    Private Sub FrmViewTarafHEsab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Me.Grd.Rows.Count = 0 Then
            Dialog.ShowInfo("هیچ طرف حسابی انتخاب نشده است")
            Exit Sub
        End If
        tarafhesab = New ClsTarafHesab(Me.Grd.CurrentRow.Cells("ID").Value)
        Me.Close()
    End Sub
    Public Property ExistInPersoneli As PersonelStatus
        Get
            Return IsDeclaredToPersonel
        End Get
        Set(value As PersonelStatus)
            IsDeclaredToPersonel = value
        End Set
    End Property
    Enum PersonelStatus As Byte
        AllTarafhesab = 0
        ExistsToPersoneliSystem = 1
        NotExistsToPersoneliSystem = 2
    End Enum
End Class
Public Class FrmKargah
    Dim kargah As New ClsPersonBase.Kargah
    Dim Comp As New Common.ClsGeneral.Company
    Private Sub FrmKargah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCmb()
        FillGrd()
    End Sub
    Private Sub FillCmb()
        With Me.CmbCompany
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = Comp.GetAll()
        End With
    End Sub
    Private Sub FillGrd()
        kargah = New ClsPersonBase.Kargah
        Me.Grd.DataSource = Nothing
        Me.Grd.DataSource = kargah.GetAll
        AddCmbToGrd()

        Grd.Columns("CodeKargah").HeaderText = "کد کارگاه"
        Grd.Columns("Name").HeaderText = "نام"
        Grd.Columns("Detail").HeaderText = "آدرس"
        Grd.Columns("RadifPeyman").HeaderText = "ردیف پیمان"
        Grd.Columns("Id_Company").HeaderText = "کد شرکت"
        Grd.Columns("CompanyName").HeaderText = "نام کارفرما"
        Grd.Columns("ID").ReadOnly = True
        Grd.Columns("CompanyName").ReadOnly = True
        Grd.Columns("Id_Company").ReadOnly = True
        Grd.Columns("CompanyName").IsVisible = False
        Grd.Columns("Id_Company").IsVisible = False
        Grd.Columns("CodeKargah").Width = 150
        Grd.Columns("Name").Width = 200
        Grd.Columns("Detail").Width = 300
        Grd.Columns("RadifPeyman").Width = 150
        Grd.Columns("Id_Company").Width = 150
        Grd.Columns("CompanyName").Width = 150
    End Sub
    Private Sub AddCmbToGrd()
        Dim Cmb As New Telerik.WinControls.UI.GridViewComboBoxColumn
        With Cmb
            .Name = "CmbCompany"
            .HeaderText = "NameSherkat"
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .HeaderText = "کارفرما"
            .DataSource = Comp.GetAll()
            .Width = 150
        End With
        If Me.Grd.Columns.Contains("CmbCompany") Then
            Me.Grd.Columns.Remove("CmbCompany")
        End If
        Me.Grd.Columns.Insert(5, Cmb)
        For i As Integer = 0 To Me.Grd.Rows.Count - 1
            Me.Grd.Rows(i).Cells("CmbCompany").Value = Me.Grd.Rows(i).Cells("Id_Company").Value
        Next

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtCode.Text = Nothing Or TxtCode.Text = "" Then
            Dialog.ShowInfo("کد کارگاه نمیتواند خالی باشد")
            Exit Sub
        End If
        If TxtName.Text = Nothing Or TxtCode.Text = "" Then
            Dialog.ShowInfo("وارد کردن نام کارگاه الزامی است")
            Exit Sub
        End If
        If Me.TxtCode.Text.Trim.Length <> 10 Then
            Dialog.ShowInfo("طول کد کارگاه باید 10 رقم باشد")
            Exit Sub

        End If
        kargah.AddNew(Me.TxtCode.Text.Trim, TxtName.Text.Trim, TxtDetail.Text.Trim, Me.TxtRadifPeyman.Text.Trim, Me.CmbCompany.SelectedValue)
        FillGrd()
        Me.TxtDetail.Text = Nothing
        Me.TxtCode.Text = Nothing
        Me.TxtName.Text = Nothing
        Me.TxtRadifPeyman.Text = Nothing
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.Grd.CurrentRow Is Nothing Then
            Exit Sub
        End If
        If kargah.Delete(Me.Grd.CurrentRow.Cells("ID").Value) Then
            FillGrd()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim DtUpdate As New DataTable
        With DtUpdate
            .Columns.Add("ID")
            .Columns.Add("CodeKargah")
            .Columns.Add("Name")
            .Columns.Add("Detail")
            .Columns.Add("ID_Company")
            .Columns.Add("RadifPeyman")
        End With
        Dim Dr As DataRow
        For i As Integer = 0 To Me.Grd.Rows.Count - 1
            Dr = DtUpdate.NewRow()
            Dr("ID") = Grd.Rows(i).Cells("ID").Value.ToString.Trim
            Dr("CodeKargah") = Grd.Rows(i).Cells("CodeKargah").Value.ToString.Trim
            Dr("Name") = Grd.Rows(i).Cells("Name").Value.ToString.Trim
            Dr("Detail") = Grd.Rows(i).Cells("Detail").Value.ToString.Trim
            Dr("ID_Company") = Grd.Rows(i).Cells("CmbCompany").Value.ToString.Trim
            Dr("RadifPeyman") = Grd.Rows(i).Cells("RadifPeyman").Value.ToString.Trim
            DtUpdate.Rows.Add(Dr)
        Next
        kargah.Update(DtUpdate)
    End Sub
End Class
Imports Common
Public Class FrmPrParametrs
    Dim Param As New ClsParametrs
    Private Sub FrmPrParametrs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
    Private Sub FillGrid()
        With Me.Grd
            .DataSource = Me.Param.GetAll
            .Columns("ID").ReadOnly = True
            .Columns("Name").ReadOnly = True
            .Columns("Name").HeaderText = "شرح"
            .Columns("Value").HeaderText = "مقدار"
            .Columns("Detail").HeaderText = "توضیحات"
        End With
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Param.Update(Me.Grd.DataSource) > 0 Then
            Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")
        Else
            Dialog.ShowInfo("متاسفانه اطلاعاتی ذخیره نشد")
        End If
    End Sub
End Class
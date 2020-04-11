Public Class FrmEditThProperty
    Public Mode As PropertyType = PropertyType.Th_Hesab
    Dim th_property As New ClsTarafHesab.Propertes
    Dim Pr_property As New ClsPersonel.Propertes
    Private Sub FrmEditThProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = PropertyType.Personely Then
            Me.Text = "ویرایش فیلد های پرسنل"
        ElseIf Mode = PropertyType.Th_Hesab Then
            Me.Text = "ویرایش فیلد های طرف حسابها"
        End If
        FillGrid()
    End Sub
    Private Sub FillGrid()
        If Mode = PropertyType.Th_Hesab Then
            Me.Grd.DataSource = th_property.ShowAll()
        Else
            Me.Grd.DataSource = Pr_property.ShowAll()
        End If
        Me.Grd.Columns("PropertyName").HeaderText = "شرح"
        Me.Grd.Columns("olaviat").HeaderText = "اولویت"
        Me.Grd.Columns("ID").ReadOnly = True

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Mode = PropertyType.Th_Hesab AndAlso th_property.DELETE(Me.Grd.CurrentRow.Cells("ID").Value) Then
            FillGrid()
        End If
        If Mode = PropertyType.Personely AndAlso Pr_property.DELETE(Me.Grd.CurrentRow.Cells("ID").Value) Then
            FillGrid()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Mode = PropertyType.Th_Hesab Then
            th_property.Update()
        Else
            Pr_property.Update()
        End If
    End Sub
    Enum PropertyType As Byte
        Personely = 0
        Th_Hesab = 1
    End Enum
End Class
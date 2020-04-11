Imports TarafHesab.ClsTarafHesab

Public Class FrmAddThProperty
    Public Mode As PropertyType = PropertyType.Th_Hesab
    Dim th_property As New TarafHesab.ClsTarafHesab.Propertes
    Dim Pr_property As New Personnely.ClsPersonel.Propertes
    Private Sub FrmAddThProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = PropertyType.Personely Then
            Me.Text = "افزودن فیلد جدید برای پرسنل"
        ElseIf Mode = PropertyType.Th_Hesab Then
            Me.Text = "افزودن فیلد جدید برای طرف حسابها"
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

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Mode = PropertyType.Th_Hesab Then
            th_property.AddNew(Me.TxtName.Text.Trim, Me.TxtOlaviat.Value)
        Else
            Pr_property.AddNew(Me.TxtName.Text.Trim, Me.TxtOlaviat.Value)
        End If
        Me.TxtName.Text = Nothing
        FillGrid()
    End Sub
    Enum PropertyType As Byte
        Personely = 0
        Th_Hesab = 1
    End Enum
End Class
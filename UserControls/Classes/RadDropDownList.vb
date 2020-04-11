Imports Telerik.WinControls.UI

Public Class RadDropDownList
    Inherits Telerik.WinControls.UI.RadDropDownList
    Public Sub New()
        MyBase.Text = Nothing
        MyBase.DropDownListElement.Font = New System.Drawing.Font("Tahoma", 8.25)
        MyBase.ListElement.Font = New System.Drawing.Font("Tahoma", 8.25)
        MyBase.DefaultItemsCountInDropDown = 15
    End Sub
    Public Sub Find()
        Dim Frm As New FrmSelectCmb(Me)
        Frm.Show()
    End Sub
End Class

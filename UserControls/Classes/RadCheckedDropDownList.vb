Imports System.IO
Imports OfficeOpenXml
Public Class RadCheckedDropDownList
    Inherits Telerik.WinControls.UI.RadCheckedDropDownList
    Public Sub New()
        MyBase.Text = Nothing
        MyBase.DropDownListElement.Font = New System.Drawing.Font("Tahoma", 8.25)
        MyBase.ListElement.Font = New System.Drawing.Font("Tahoma", 8.25)
        MyBase.DefaultItemsCountInDropDown = 15
    End Sub
    Public Sub Find()
        Dim Frm As New FrmSelectCmbCheck(Me)
        Frm.Show()
    End Sub
    Public Sub SetCheck(Value As Boolean)
        For i As Integer = 0 To Me.Items.Count - 1
            Me.Items(i).Checked = Value
        Next
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private _DefaultCheck As Boolean = False
    Public Property DefaultCheck() As Boolean
        Get
            Return _DefaultCheck
        End Get
        Set(ByVal value As Boolean)
            _DefaultCheck = value
        End Set
    End Property
End Class

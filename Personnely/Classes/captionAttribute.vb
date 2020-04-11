
NotInheritable Class captionAttribute
    Inherits Attribute
    Private _Name As String
    Public Property CName() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property


    'Public Sub New(n)
    '    Me.CName = n
    'End Sub
End Class

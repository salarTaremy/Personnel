Imports System.IO
Public Class ClsPersonel
    Dim Dt_Personel As New DataTable
    Dim _Exists As Boolean = False
    Public Event ID_Chenge(ID As Integer)
    Public Event ID_Th_Chenge(ID_TH As Integer)
    Public Property ID As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            RaiseEvent ID_Chenge(value)
        End Set
    End Property
    Public ReadOnly Property Exists As Boolean
        Get
            Return _Exists
        End Get
    End Property
    Public ReadOnly Property Name As String
        Get
            If Exists Then
                Return Dt_Personel.Rows(0).Item("Name")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Famil As String
        Get
            If Exists Then
                Return Dt_Personel.Rows(0).Item("Famil")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property CodeMelli As String
        Get
            If Exists Then
                Return Dt_Personel.Rows(0).Item("Code_melli")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property CodeEghtesadi As String
        Get
            If Exists Then
                Return Dt_Personel.Rows(0).Item("Code_Eghtesadi")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property BirthDay As String
        Get
            If Exists Then
                Return Dt_Personel.Rows(0).Item("BirthDay")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public Property ID_TarafHesab As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_TarafHesab")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            RaiseEvent ID_Th_Chenge(value)
        End Set
    End Property
    Public Property CodePersoneli As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                If Dt_Personel.Rows(0).Item("CodePersoneli") Is DBNull.Value Then
                    Return Nothing
                Else
                    Return Dt_Personel.Rows(0).Item("CodePersoneli")
                End If
            Else
                Return Nothing
            End If
        End Get
        Set(value As String)
            Dt_Personel.Rows(0).Item("CodePersoneli") = value
        End Set
    End Property
    Public Property ShomarehBime As String
        Get

            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ShomarehBime")
            Else
                Return Nothing
            End If
        End Get
        Set(value As String)
            Dt_Personel.Rows(0).Item("ShomarehBime") = value
        End Set
    End Property
    Public Property ChilCount As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ChildCount")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ChildCount") = value
        End Set
    End Property
    Public Property Photo As Byte()
        Get
            If Dt_Personel.Rows.Count > 0 Then
                If Not Dt_Personel.Rows(0).Item("Photo") Is DBNull.Value Then
                    Return Dt_Personel.Rows(0).Item("Photo")
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
        Set(value As Byte())
            If value IsNot Nothing Then
                Dt_Personel.Rows(0).Item("Photo") = value
            Else
                Dt_Personel.Rows(0).Item("Photo") = Nothing
            End If
        End Set
    End Property
    Public Property ID_Din As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_Din")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_Din") = value
        End Set
    End Property
    Public Property ID_MadrakTahsili As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_MadrakTahsili")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_MadrakTahsili") = value
        End Set
    End Property
    Public Property ID_Mazhab As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_Mazhab")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_Mazhab") = value
        End Set
    End Property
    Public Property ID_Melliat As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_Melliat")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_Melliat") = value
        End Set
    End Property
    Public Property ID_NezamVazifeh As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_NezamVazifeh")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_NezamVazifeh") = value
        End Set
    End Property
    Public Property ID_Taahol As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_Taahol")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_Taahol") = value
        End Set
    End Property
    Public Property ID_Tabeiyat As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_Tabeiyat")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_Tabeiyat") = value
        End Set
    End Property
    Public Property ID_Jensiat As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_Jensiat")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_Jensiat") = value
        End Set
    End Property
    Public Property ID_VaziatKhedmat As Integer
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("ID_VaziatKhedmat")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Integer)
            Dt_Personel.Rows(0).Item("ID_VaziatKhedmat") = value
        End Set
    End Property
    Public ReadOnly Property Din As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("Din")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property MadrakTahsili As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("MadrakTahsili")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Mazhab As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("Mazhab")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Melliat As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("Melliat")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property NezamVazifeh As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("NezamVazifeh")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Taahol As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("Taahol")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Tabeiyat As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("Tabeiyat")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Jensiat As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("Jensiat")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property VaziatKhedmat As String
        Get
            If Dt_Personel.Rows.Count > 0 Then
                Return Dt_Personel.Rows(0).Item("VaziatKhedmat")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public Sub New(Optional ID As String = Nothing)
        If ID IsNot Nothing Then
            RaiseEvent ID_Chenge(ID)
        End If
    End Sub
    Private Sub ID_Chengeed(ID As Integer) Handles MyClass.ID_Chenge
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Pr.UspGetPersonel"
        cmd.Parameters.AddWithValue("@ID", ID)
        cmd.CommandType = CommandType.StoredProcedure
        Me.Dt_Personel = Db.FillDataTable(cmd)
        If Dt_Personel.Rows.Count > 0 Then
            Me._Exists = True
        Else
            Me._Exists = False
            Dim DR As DataRow
            DR = Dt_Personel.NewRow
            DR.Item("ID") = ID
            Dt_Personel.Rows.Add(DR)
        End If
    End Sub
    Private Sub ID_tH_Chengeed(ID_Th As Integer) Handles MyClass.ID_Th_Chenge
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Pr.UspGetPersonel"
        cmd.Parameters.AddWithValue("@ID_TH", ID_Th)
        cmd.CommandType = CommandType.StoredProcedure
        Me.Dt_Personel = Db.FillDataTable(cmd)
        If Dt_Personel.Rows.Count > 0 Then
            Me._Exists = True
        Else
            Me._Exists = False
            Dim DR As DataRow
            DR = Dt_Personel.NewRow
            DR.Item("ID_TarafHesab") = ID_Th
            Dt_Personel.Rows.Add(DR)
        End If
    End Sub
    Public Function GetAllProperties() As DataTable
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[Pr].[UspGetPersonelProperties]"
            If Me.Exists Then
                .Parameters.AddWithValue("@ID", Me.ID)
            End If
        End With
        Return Db.FillDataTable(cmd)
    End Function
    Public Function SaveNew(Dt_Properties As DataTable) As Integer
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandText = "Pr.UspAddPersonel"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@CodePersoneli", Me.CodePersoneli)
            .Parameters.AddWithValue("@ShomarehBime", Me.ShomarehBime)
            .Parameters.AddWithValue("@ID_TH", Me.ID_TarafHesab)
            .Parameters.AddWithValue("@ID_Din", Me.ID_Din)
            .Parameters.AddWithValue("@ID_Jensiat", Me.ID_Jensiat)
            .Parameters.AddWithValue("@ID_MadrakTahsili", Me.ID_MadrakTahsili)
            .Parameters.AddWithValue("@ID_Mazhab", Me.ID_Mazhab)
            .Parameters.AddWithValue("@ID_Melliat", Me.ID_Melliat)
            .Parameters.AddWithValue("@ID_NezamVazifeh", Me.ID_NezamVazifeh)
            .Parameters.AddWithValue("@ID_Taahol", Me.ID_Taahol)
            .Parameters.AddWithValue("@ID_Tabeiyat", Me.ID_Tabeiyat)
            .Parameters.AddWithValue("@ID_VaziatKhedmat", Me.ID_VaziatKhedmat)
            .Parameters.AddWithValue("@ChildCount", Me.ChilCount)
            .Parameters.AddWithValue("@Properties", Dt_Properties)
            .Parameters.AddWithValue("@Photo", Me.Photo)
        End With
        Return Db.ExecuteNonQuery(cmd)
    End Function
    Public Function Delete() As Boolean
        If Me.Exists = False Then
            Dialog.ShowErorr("این  کارمند وجود ندارد")
            Return False
        End If
        If Not Dialog.ShowQuestion("آیا برای حذف این طرف حساب مطمئن هستید :؟ " & vbCrLf & Me.Famil & " " & Me.Name & vbCrLf & "ID:" & Me.ID) Then
            Return False
        End If
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Pr.UspDeletePersonel"
            .Parameters.AddWithValue("@ID", Me.ID)
            Dim val As String = Db.ExecuteScalar(cmd)
            If val IsNot Nothing Then
                Dialog.ShowOK("این کارمند با موفقیت حذف شد")
                Me._Exists = False
                Return True
            End If
        End With
        Return False
    End Function
    Public Class Propertes
        Dim Dt_Pr_Items As DataTable
        Public Function ShowAll() As DataTable
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "SELECT PR.ID ,PR.PropertyName,PR.olaviat  FROM pr.Property  PR ORDER BY PR.olaviat "
            Dt_Pr_Items = New DataTable
            Dt_Pr_Items = Db.FillDataTable(cmd)
            Return Dt_Pr_Items
        End Function
        Public Sub AddNew(Name As String, Olaviat As Integer)
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspAddProperty]"
                .Parameters.AddWithValue("@PropertyName", Name.Trim)
                .Parameters.AddWithValue("@OLAVIAT", Olaviat)
            End With
            Db.ExecuteScalar(cmd)
        End Sub
        Public Function DELETE(ID As Integer) As Boolean
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "DELETE Pr.Property WHERE ID = @ID"
                .Parameters.AddWithValue("@ID", ID)
            End With
            If Db.ExecuteNonQuery(cmd) > 0 Then
                Dialog.ShowOK("خصوصیت مورد نظرحذف شد")
                Return True
            Else
                Dialog.ShowInfo("متاسفانه حذف انجام نشد")
                Return False
            End If
        End Function
        Public Function Update() As Boolean
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Pr].[UspUpdateProperty]"
                .Parameters.AddWithValue("@PropertyList", Dt_Pr_Items)
            End With
            If Db.ExecuteNonQuery(cmd) > 0 Then
                Dialog.ShowOK("تغییرات با موفقیت اعمال شد")
                Return True
            Else
                Dialog.ShowInfo("متاسفانه عملیات انجام نشد")
                Return False
            End If
        End Function
    End Class
    Public Function SelectPersonID() As Integer
        Dim frm As New FrmViewKarmand
        frm.BtnSelect.Visible = True
        frm.ShowDialog()
        If frm.SelectedPersonID > 0 Then
            Return frm.SelectedPersonID
        Else
            Return 0
        End If
    End Function
    Public Function SelectPerson() As SelectedPersonnel
        Dim frm As New FrmViewKarmand
        frm.BtnSelect.Visible = True
        frm.ShowDialog()
        Return frm.SelectedPr
    End Function
    Public Structure SelectedPersonnel
        Public FullName As String
        Public ID As Integer
        Public ThID As Integer
        Public CodePersonneli As String
    End Structure
End Class

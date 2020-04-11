
Public Class ClsTarafHesab
    Dim _Dt_TrafHesab As New DataTable
    Dim _Dt_Detail As New DataTable
    Dim _ID As Integer = Nothing
    Dim _Exists As Boolean = False
    Dim Tools As New Common.ClsTools
    Dim DB As New DAL.ClsDataAccessLayer
    Dim Dialog As New UserControls.ClsDialog

    Public ReadOnly Property ID As Integer
        Get
            If _Exists Then
                Return _ID
            Else
                Return Nothing
            End If
        End Get
    End Property
    ''' <summary>
    ''' نام کوچک
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FName As String
        Get
            'If _Exists Then
            Return _Dt_TrafHesab.Rows(0).Item("Name").ToString.Trim
            'Else
            '    Return Nothing
            'End If
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("Name") = value
        End Set
    End Property
    ''' <summary>
    ''' نام خانوادگی
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LName As String
        Get
            ' If _Exists Then
            Return _Dt_TrafHesab.Rows(0).Item("Famil").ToString.Trim
            'Else
            '    Return Nothing
            'End If
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("Famil") = value
        End Set
    End Property
    ''' <summary>
    ''' کد اقتصادی مربوط به اشخاص حقوقی 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodeEghtesadi As String
        Get
            Return _Dt_TrafHesab.Rows(0).Item("Code_Eghtesadi").ToString.Trim
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("Code_Eghtesadi") = value
        End Set
    End Property
    ''' <summary>
    ''' کد ملی 10 رقمی مربووط به اشخاص حقیقی
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodeMelli As String
        Get
            Return _Dt_TrafHesab.Rows(0).Item("Code_melli").ToString.Trim
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("Code_melli") = value
        End Set
    End Property
    Public Property NamePedar As String
        Get
            Return _Dt_TrafHesab.Rows(0).Item("NamePedar").ToString.Trim
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("NamePedar") = value
        End Set
    End Property
    Public Property SH_SH As String
        Get
            Return _Dt_TrafHesab.Rows(0).Item("SH_SH").ToString.Trim
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("SH_SH") = value
        End Set
    End Property
    ''' <summary>
    ''' ناریخ تولد با فرمت شمسی
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property BirthDay As Integer
        Get
            Return Tools.IsNull(_Dt_TrafHesab.Rows(0).Item("BirthDay"), 0)
        End Get
        Set(value As Integer)
            _Dt_TrafHesab.Rows(0).Item("BirthDay") = value
        End Set
    End Property
    Public Property Shahr_Tavallod As String
        Get
            Return _Dt_TrafHesab.Rows(0).Item("Shahr_Tavallod").ToString.Trim
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("Shahr_Tavallod") = value
        End Set
    End Property
    Public Property Shahr_Sodoor As String
        Get
            Return _Dt_TrafHesab.Rows(0).Item("Shahr_Sodoor").ToString.Trim
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("Shahr_Sodoor") = value
        End Set
    End Property
    Public Property SodoorDate As Integer
        Get
            Return Tools.IsNull(_Dt_TrafHesab.Rows(0).Item("SodoorDate"), 0)
        End Get
        Set(value As Integer)
            _Dt_TrafHesab.Rows(0).Item("SodoorDate") = value
        End Set
    End Property
    Public Property ID_MahalTavalod As Int64
        Get
            If Not IsDBNull(_Dt_TrafHesab.Rows(0).Item("ID_MahalTavalod")) Then

                Return _Dt_TrafHesab.Rows(0).Item("ID_MahalTavalod")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Int64)
            _Dt_TrafHesab.Rows(0).Item("ID_MahalTavalod") = value
        End Set
    End Property
    Public Property OldAccountingCode As String
        Get
            If Not IsDBNull(_Dt_TrafHesab.Rows(0).Item("OldAccountingCode")) Then

                Return _Dt_TrafHesab.Rows(0).Item("OldAccountingCode")
            Else
                Return Nothing
            End If
        End Get
        Set(value As String)
            _Dt_TrafHesab.Rows(0).Item("OldAccountingCode") = value
        End Set
    End Property
    Public Property ID_MahalSodoor As Int64
        Get
            If Not IsDBNull(_Dt_TrafHesab.Rows(0).Item("ID_MahalSodoor")) Then

                Return _Dt_TrafHesab.Rows(0).Item("ID_MahalSodoor")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Int64)
            _Dt_TrafHesab.Rows(0).Item("ID_MahalSodoor") = value
        End Set
    End Property
    Public Property Serial As Int64
        Get
            If Not IsDBNull(_Dt_TrafHesab.Rows(0).Item("Serial")) Then

                Return _Dt_TrafHesab.Rows(0).Item("Serial")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Int64)
            _Dt_TrafHesab.Rows(0).Item("Serial") = value
        End Set
    End Property
    Public Property Credit As Int64
        Get
            If Not IsDBNull(_Dt_TrafHesab.Rows(0).Item("Credit")) Then

                Return _Dt_TrafHesab.Rows(0).Item("Credit")
            Else
                Return Nothing
            End If
        End Get
        Set(value As Int64)
            _Dt_TrafHesab.Rows(0).Item("Credit") = value
        End Set
    End Property

    ''' <summary>
    ''' تعیین میکند طرف حساب با این شناسه وجود دارد یا نه
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Exists As Boolean
        Get
            Return _Exists
        End Get
    End Property
    ''' <summary>
    ''' در صورتی که کد شناسه ست  نشود طرف حساب جدید در نظر گرفته میشود
    ''' </summary>
    ''' <param name="ID">شناسه از نوع عددی</param>
    ''' <remarks></remarks>
    Public Sub New(Optional ID As Integer = Nothing)
        _ID = ID
        FillDtDetail(ID)
        FillDtTarafHesab(ID)
        If _Dt_TrafHesab.Rows.Count = 0 Then
            _Exists = False
            _Dt_TrafHesab.Rows.Add()
        Else
            _Exists = True
        End If
    End Sub
    ''' <summary>
    ''' مشخصات اصلی طرف حساب را برمیگرداند
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <remarks></remarks>
    Private Sub FillDtTarafHesab(Optional ID As Integer = Nothing)
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Th.UspGetTarafhesab"
            .Parameters.AddWithValue("@ID", ID)
        End With
        _Dt_TrafHesab = Db.FillDataTable(cmd)
    End Sub
    ''' <summary>
    ''' مشخصات تکمیلی طرف حساب را باز میگرداند
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <remarks></remarks>
    Private Sub FillDtDetail(Optional ID As Integer = Nothing)
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Th.UspGetTarafHesabProperties"
            .Parameters.AddWithValue("@ID", ID)
        End With
        _Dt_Detail = Db.FillDataTable(cmd)
    End Sub
    ''' <summary>
    ''' همه خصوصیت های مربوط به طرف حساب مورد نظر را در قالب یک جدول برمیگراند
    ''' اگر طرف حساب وجود نداشته باشد فقط نام خصوصیت را با مقدار خالی باز میگرداند
    ''' </summary>
    ''' <returns>جدول</returns>
    ''' <remarks></remarks>
    Public Function GetAllProperties() As DataTable
        Return _Dt_Detail
    End Function
    ''' <summary>
    ''' یک مقدار جدید برای یک خصوصیت از طرف حساب ست میکند
    ''' </summary>
    ''' <param name="ID">ای دی مربوط به خصوصیت</param>
    ''' <param name="Value">مقدار وارده برای خصوصیت مورد نظر</param>
    ''' <remarks></remarks>
    Public Sub SetProperty(ID As Integer, Value As String)
        Dim Row() As Data.DataRow
        Row = _Dt_Detail.Select("ID_Pr = " & ID)
        Row(0)("Value") = Value
    End Sub
    ''' <summary>
    ''' مقدار یک خصوصیت را باز میگرداند
    ''' </summary>
    ''' <param name="ID">ای دی خصوصیت مورد نظر</param>
    ''' <returns> مقدار خصوصیت مورد نظر</returns>
    ''' <remarks></remarks>
    Public Function GetProperty(ID As Integer) As String
        Dim Row() As Data.DataRow
        Row = _Dt_Detail.Select("ID_Pr = " & ID)
        Return Row(0)("Value").ToString
    End Function
    ''' <summary>
    ''' این متد برای ویرایش طف حساب است
    ''' بااین متد طرف حساب جاری ویرایش میشود
    ''' </summary>
    Public Sub Update()
        If _ID = Nothing Then
            Dialog.ShowErorr("ای دی خالی است آپدیت طرف حساب امکان پذیر نیست")
            Exit Sub
        End If
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Th.UspUpdateTarafHesab"
            .Parameters.AddWithValue("@ID", _ID)
            .Parameters.AddWithValue("@Name", Me.FName.Trim)
            .Parameters.AddWithValue("@Famil", Me.LName.Trim)
            .Parameters.AddWithValue("@Code_melli", Me.CodeMelli.Trim)
            .Parameters.AddWithValue("@SH_SH", Me.SH_SH.Trim)
            .Parameters.AddWithValue("@NamePedar", Me.NamePedar.Trim)
            .Parameters.AddWithValue("@Code_Eghtesadi", Me.CodeEghtesadi.Trim)
            .Parameters.AddWithValue("@BirthDay", Me.BirthDay)
            .Parameters.AddWithValue("@SodoorDate", Me.SodoorDate)
            .Parameters.AddWithValue("@Serial", Me.Serial)
            .Parameters.AddWithValue("@ID_MahalTavalod", Me.ID_MahalTavalod)
            .Parameters.AddWithValue("@ID_MahalSodoor", Me.ID_MahalSodoor)
            .Parameters.AddWithValue("@Credit", Me.Credit)
            .Parameters.AddWithValue("@OldAccountingCode", Me.OldAccountingCode)
            .Parameters.AddWithValue("@Detail", Me._Dt_Detail)
        End With
        If Db.ExecuteNonQuery(cmd) > 0 Then
            Dialog.ShowOK("ویرایش با موفقیت انجام شد")
        End If
    End Sub
    ''' <summary>
    ''' با این متد طرف حساب جدیدی با پراپرتی های ست شد اضافه میشود
    ''' در نهایت ای دی مربوط به طرف حساب جدید بازگردانده میشود
    ''' </summary>
    Public Sub SaveAsNew()
        If Me.Exists Then
            Dialog.ShowErorr("این طرف حساب وجود دارد" & vbCrLf & "عملیات انجام نشد")
            Exit Sub
        End If
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Th.UspAddTarafHesab"
            .Parameters.AddWithValue("@Name", Me.FName.Trim)
            .Parameters.AddWithValue("@Famil", Me.LName.Trim)
            .Parameters.AddWithValue("@Code_melli", Me.CodeMelli.Trim)
            .Parameters.AddWithValue("@SH_SH", Me.SH_SH.Trim)
            .Parameters.AddWithValue("@NamePedar", Me.NamePedar.Trim)
            .Parameters.AddWithValue("@Code_Eghtesadi", Me.CodeEghtesadi.Trim)
            .Parameters.AddWithValue("@BirthDay", Me.BirthDay)
            .Parameters.AddWithValue("@SodoorDate", Me.SodoorDate)
            .Parameters.AddWithValue("@Serial", Me.Serial)
            .Parameters.AddWithValue("@ID_MahalTavalod", Me.ID_MahalTavalod)
            .Parameters.AddWithValue("@ID_MahalSodoor", Me.ID_MahalSodoor)
            .Parameters.AddWithValue("@Credit", Me.Credit)
            .Parameters.AddWithValue("@OldAccountingCode", Me.OldAccountingCode)
            .Parameters.AddWithValue("@Detail", Me._Dt_Detail)
            Dim val As String = Db.ExecuteScalar(cmd)
            If val IsNot Nothing Then
                Dialog.ShowOK("طرف حساب با موفقیت ثبت شد" & vbCrLf & "کد طرف حساب : " & val)
                Me._ID = val
                Me._Exists = True
            End If
        End With
    End Sub
    ''' <summary>
    ''' برای حذف طرف حساب استفاده میشود
    ''' در صورتی که طرف حساب وجود نداشته باشد به کار بر پیغام داده میشود
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Delete() As Boolean
        If Me.Exists = False Then
            Dialog.ShowErorr("این طرف حساب وجود ندارد")
            Return False
        End If
        If Not Dialog.ShowQuestion("آیا برای حذف این طرف حساب مطمئن هستید :؟ " & vbCrLf & Me.LName & " " & Me.FName & vbCrLf & "ID:" & Me.ID) Then
            Return False
        End If
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Th.UspDeleteTarafHesab"
            .Parameters.AddWithValue("@ID", Me.ID)
            Dim val As String = Db.ExecuteScalar(cmd)
            If val IsNot Nothing Then
                Dialog.ShowOK("طرف حساب با موفقیت حذف شد")
                Me._ID = val
                Me._Exists = False
                Return True
            End If
        End With
        Return False
    End Function
    ''' <summary>
    ''' یک طرف حساب انتخاب میکند و ای دی ان را باز میگرداند
    ''' </summary>
    ''' <returns>ای دی طرف حساب انتخاب شده</returns>
    ''' <remarks></remarks>
    Public Function Select_TarafHesab(Optional ExistInPersoneli As FrmViewTarafHEsab.PersonelStatus = FrmViewTarafHEsab.PersonelStatus.AllTarafhesab) As ClsTarafHesab
        Dim frm As New FrmViewTarafHEsab
        frm.ExistInPersoneli = ExistInPersoneli
        frm.BtnSelect.Visible = True
        frm.ShowDialog()
        Return frm.tarafhesab
    End Function
    Public ReadOnly Property ExistsInPersonnely
        Get
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandText = "SELECT ID FROM  pr.Personel WHERE ID_TarafHesab = @ID_Th"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@ID_Th", Me.ID)
            End With
            If DB.FillDataTable(cmd).Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End Get

    End Property

    Public Class Propertes
        Dim DB As New DAL.ClsDataAccessLayer
        Dim Dialog As New UserControls.ClsDialog
        Dim Dt_Th_Items As DataTable
        Public Function ShowAll() As DataTable
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "SELECT PR.ID ,PR.PropertyName,PR.olaviat  FROM th.Properties PR ORDER BY PR.olaviat "
            Dt_Th_Items = New DataTable
            Dt_Th_Items = DB.FillDataTable(cmd)
            Return Dt_Th_Items
        End Function
        Public Sub AddNew(Name As String, Olaviat As Integer)
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[Th].[UspAddProperty]"
                .Parameters.AddWithValue("@PropertyName", Name.Trim)
                .Parameters.AddWithValue("@OLAVIAT", Olaviat)
            End With
            DB.ExecuteScalar(cmd)
        End Sub
        Public Function DELETE(ID As Integer) As Boolean
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "DELETE TH.Properties WHERE ID = @ID"
                .Parameters.AddWithValue("@ID", ID)
            End With
            If DB.ExecuteNonQuery(cmd) > 0 Then
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
                .CommandText = "[Th].[UspUpdateProperty]"
                .Parameters.AddWithValue("@PropertyList", Dt_Th_Items)
            End With
            If DB.ExecuteNonQuery(cmd) > 0 Then
                Dialog.ShowOK("تغییرات با موفقیت اعمال شد")
                Return True
            Else
                Dialog.ShowInfo("متاسفانه عملیات انجام نشد")
                Return False
            End If
        End Function
    End Class
End Class


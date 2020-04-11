Imports System.Data.SqlClient
Imports System.IO
Public Class FrmKarmand
    Public DefaultThID As Integer = Nothing
    Dim th As New ClsTarafHesab
    Public Pr As New ClsPersonel
    Dim MyMode As My_Mode = My_Mode.AddNew
    Private Sub BtnBrows_Click(sender As Object, e As EventArgs) Handles BtnBrows.Click
        th = New ClsTarafHesab
        th = th.Select_TarafHesab(FrmViewTarafHEsab.PersonelStatus.NotExistsToPersoneliSystem)
        TxtThID.Value = th.ID
        Me.TxtName.Text = th.FName & " " & th.LName
    End Sub
    Private Sub FrmKarmand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAllCmb()
        If Me.Mode = My_Mode.Edit Then
            Me.TxtThID.Enabled = False
            Me.BtnBrows.Enabled = False
            Me.TxtCodePr.Enabled = False
            Me.TxtThID.Value = Pr.ID_TarafHesab
            Me.CmbMelliat.SelectedValue = Pr.ID_Melliat
            Me.CmbTabeiyat.SelectedValue = Pr.ID_Tabeiyat
            Me.CmbNezamVazifeh.SelectedValue = Pr.ID_NezamVazifeh
            Me.CmbDin.SelectedValue = Pr.ID_Din
            Me.CmbMazhab.SelectedValue = Pr.ID_Mazhab
            Me.CmbMadrakTahsili.SelectedValue = Pr.ID_MadrakTahsili
            Me.CmbJensiat.SelectedValue = Pr.ID_Jensiat
            Me.CmbTaahol.SelectedValue = Pr.ID_Taahol
            Me.CmbVaziatKhedmat.SelectedValue = Pr.ID_VaziatKhedmat
            Me.TxtCodePr.Text = Pr.CodePersoneli
            Me.TxtBimehNo.Text = Pr.ShomarehBime
            Me.TxtChildCount.Value = Pr.ChilCount
            Me.PicPersoneli.Image = Convert.ByteToImage(Pr.Photo)
        End If
    End Sub
    Private Sub FillAllCmb()
        Dim cmd As New SqlCommand
        With cmd
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetDin]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetJensiatt]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetMadrakTahsili]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetMazhab]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetMelliat]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetNezamVazifeh]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetTaahol]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspGetTabeiyat]"
            .CommandText &= vbCrLf & "Exec [Inf].[UspVaziatKhedmat]"
        End With
        With Me.CmbDin
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(0)
        End With
        With Me.CmbJensiat
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(1)
        End With
        With Me.CmbMadrakTahsili
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(2)
        End With
        With Me.CmbMazhab
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(3)
        End With
        With Me.CmbMelliat
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(4)
        End With
        With Me.CmbNezamVazifeh
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(5)
        End With
        With Me.CmbTaahol
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(6)
        End With
        With Me.CmbTabeiyat
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(7)
        End With
        With Me.CmbVaziatKhedmat
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = Db.FillDataSet(cmd).Tables(8)
        End With
    End Sub
    Private Sub TxtThID_ValueChanged(sender As Object, e As EventArgs) Handles TxtThID.ValueChanged
        th = New ClsTarafHesab(TxtThID.Value)
        Me.TxtName.Text = th.FName & " " & th.LName
        With Me.Grd_Th
            .DataSource = th.GetAllProperties
            .Columns("ID_PR").IsVisible = False
            .Columns("PropertyName").ReadOnly = True
            .Columns("PropertyName").HeaderText = "عنوان"
            .Columns("Value").HeaderText = "شرح"
            .Columns("PropertyName").Width = 150
            .Columns("Value").Width = 300
        End With
        Pr.ID_TarafHesab = TxtThID.Value
        With Me.Grd_Pr
            .DataSource = Pr.GetAllProperties
            .Columns("ID_PR").IsVisible = False
            .Columns("PropertyName").ReadOnly = True
            .Columns("PropertyName").HeaderText = "عنوان"
            .Columns("Value").HeaderText = "شرح"
            .Columns("PropertyName").Width = 150
            .Columns("Value").Width = 300

        End With
        If th.Exists Then
            If Pr.Exists Then
                PictureBox.Image = My.Resources.alarm
                SetCmbSelectedValues()
            Else
                PictureBox.Image = My.Resources._OK
                ResetControls(False)
            End If
        Else
            PictureBox.Image = My.Resources._Error
        End If
    End Sub
    Private Sub SetCmbSelectedValues()
        Me.CmbMelliat.SelectedIndex = CmbMelliat.FindString(Pr.Melliat).ToString.Trim
        Me.CmbTabeiyat.SelectedIndex = CmbTabeiyat.FindString(Pr.Tabeiyat).ToString.Trim
        Me.CmbNezamVazifeh.SelectedIndex = CmbNezamVazifeh.FindString(Pr.NezamVazifeh).ToString.Trim
        Me.CmbDin.SelectedIndex = CmbDin.FindString(Pr.Din).ToString.Trim
        Me.CmbMazhab.SelectedIndex = CmbMazhab.FindString(Pr.Mazhab).ToString.Trim
        Me.CmbMadrakTahsili.SelectedIndex = CmbMadrakTahsili.FindString(Pr.MadrakTahsili).ToString.Trim
        Me.CmbJensiat.SelectedIndex = CmbJensiat.FindString(Pr.Jensiat).ToString.Trim
        Me.CmbTaahol.SelectedIndex = CmbTaahol.FindString(Pr.Taahol).ToString.Trim
        Me.CmbVaziatKhedmat.SelectedIndex = CmbVaziatKhedmat.FindString(Pr.VaziatKhedmat).ToString.Trim
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not validData() Then
            Exit Sub
        End If
        If Me.Mode = My_Mode.AddNew Then
            If SaveNew() > 0 Then
                Dialog.ShowOK("کارمند مورد نظر با موفقیت اضافه شد")
                ResetControls()
            Else
                Dialog.ShowInfo("متاسفا نه عملیات انجام نشد")
            End If

            ElseIf Me.Mode = My_Mode.Edit Then
                Edit()
            End If
    End Sub
    Private Function validData() As Boolean
        If Not th.Exists Then
            Dialog.ShowInfo("لطفا طرف حساب  معتبری وارد کنید")
            Return False
        End If
        If Me.TxtCodePr.Text = Nothing Or Me.TxtCodePr.Text = "" Then
            Dialog.ShowInfo("ورود کد پرسنلی الزامی است")
            Return False
        End If
        If Me.TxtBimehNo.Text = Nothing Or Me.TxtBimehNo.Text = "" Then
            Dialog.ShowInfo("ورود شماره بیمه الزامی است")
            Return False
        End If
        If Me.CmbMadrakTahsili.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا مدرک تحصیلی را انتخاب کنید")
            Return False
        End If
        If Me.CmbVaziatKhedmat.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا وضعیت خدمت را انتخاب کنید")
            Return False
        End If
        If Me.CmbJensiat.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا جنسیت کارمند را انتخاب کنید")
            Return False
        End If
        If Me.CmbTaahol.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفاوضعیت تاهل کارمند را انتخاب کنید")
            Return False
        End If
        If Me.CmbJensiat.SelectedValue <> 1 AndAlso Me.CmbNezamVazifeh.SelectedValue = 0 Then
            Dialog.ShowInfo("لطفا وضعیت نظام وظیفه را انتخاب کنید")
            Return False
        End If
        Return True
    End Function
    Enum My_Mode
        Edit = 0
        AddNew = 1
    End Enum
    Public Property Mode As My_Mode
        Get
            Return MyMode
        End Get
        Set(value As My_Mode)
            Me.MyMode = value
        End Set
    End Property

    Private Function SaveNew() As Integer
        If Pr.Exists = True Then
            Dialog.ShowInfo("این طرف حساب قبلا  در سیستم پرسنلی تعریف شده است")
            Return 0
        End If
        Pr.ID_TarafHesab = th.ID
        Pr.CodePersoneli = Me.TxtCodePr.Text.Trim
        Pr.ShomarehBime = Me.TxtBimehNo.Text.Trim
        Pr.ID_Melliat = Me.CmbMelliat.SelectedValue
        Pr.ID_Tabeiyat = Me.CmbTabeiyat.SelectedValue
        Pr.ID_NezamVazifeh = Me.CmbNezamVazifeh.SelectedValue
        Pr.ID_Din = Me.CmbDin.SelectedValue
        Pr.ID_Mazhab = Me.CmbMazhab.SelectedValue
        Pr.ID_MadrakTahsili = Me.CmbMadrakTahsili.SelectedValue
        Pr.ID_Jensiat = Me.CmbJensiat.SelectedValue
        Pr.ID_Taahol = Me.CmbTaahol.SelectedValue
        Pr.ID_VaziatKhedmat = Me.CmbVaziatKhedmat.SelectedValue
        Pr.ChilCount = Me.TxtChildCount.Value
        If Me.PicPersoneli.Image IsNot Nothing Then
            Pr.Photo = Convert.ImageToByte(Me.PicPersoneli.Image)
        End If
        Dim dt_pr As New DataTable
        dt_pr.Columns.Add("ID_Property")
        dt_pr.Columns.Add("Value")
        Dim DR As DataRow
        For i As Integer = 0 To Me.Grd_Pr.Rows.Count - 1
            DR = dt_pr.NewRow
            DR.Item("ID_Property") = Me.Grd_Pr.Rows(i).Cells("ID_Pr").Value
            DR.Item("Value") = Me.Grd_Pr.Rows(i).Cells("Value").Value
            dt_pr.Rows.Add(DR)
        Next
        Return Pr.SaveNew(dt_pr)
    End Function
    Private Sub ResetControls(Optional ResetThId As Boolean = True)
        If ResetThId Then
            Me.TxtThID.Value = 0
        End If
        Me.TxtBimehNo.Text = Nothing
        Me.TxtCodePr.Text = Nothing
        Me.TxtChildCount.Value = 0
        Me.CmbMelliat.SelectedIndex = 0
        Me.CmbTabeiyat.SelectedIndex = 0
        Me.CmbDin.SelectedIndex = 0
        Me.CmbMazhab.SelectedIndex = 0
        Me.CmbMadrakTahsili.SelectedIndex = 0
        Me.CmbJensiat.SelectedIndex = 0
        Me.CmbTaahol.SelectedIndex = 0
        Me.CmbNezamVazifeh.SelectedIndex = 0
        Me.CmbVaziatKhedmat.SelectedIndex = 0
        Me.PicPersoneli.Image = Nothing
    End Sub
    Private Sub Edit()
        Try
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "[Pr].[UspUpdatePersonel]"
                cmd.Parameters.AddWithValue("@ID_Personel", Pr.ID)
                cmd.Parameters.AddWithValue("@ShomarehBime", Me.TxtBimehNo.Text.Trim)
                cmd.Parameters.AddWithValue("@ID_Din", Me.CmbDin.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_Jensiat", Me.CmbJensiat.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_MadrakTahsili", Me.CmbMadrakTahsili.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_Mazhab", Me.CmbMazhab.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_Melliat", Me.CmbMelliat.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_NezamVazifeh", Me.CmbNezamVazifeh.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_Taahol", Me.CmbTaahol.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_Tabeiyat", Me.CmbTabeiyat.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_VaziatKhedmat", Me.CmbVaziatKhedmat.SelectedValue)
                cmd.Parameters.AddWithValue("@ChildCount", Me.TxtChildCount.Value)
                cmd.Parameters.AddWithValue("@Properties", Me.Grd_Pr.DataSource)
                If Me.PicPersoneli.Image IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@Photo", Convert.ImageToByte(PicPersoneli.Image))
                End If

            End With
            If Db.ExecuteNonQuery(cmd) > 0 Then
                Dialog.ShowOK("اطلاعات با موفقیت ویرایش شد")
                Me.Close()
            Else
                Dialog.ShowInfo("متاسفانه اطلاعات ویرایش نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("مشکلی در ویرایش کارمند جاری به وجود آمده است", ex.Message)
        End Try
    End Sub

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        Try
            Dim fl As New OpenFileDialog
            fl.Filter = "jpg فایل عکس با فرمت |*.Jpg"
            fl.ShowDialog()
            If fl.FileName = Nothing Then
                Exit Sub
            End If
            Dim FileSize = New FileInfo(fl.FileName).Length / 1024
            Dim MaxFileSize As String = Param.GetValue(1)
            If FileSize > Val(MaxFileSize) Then
                Dialog.ShowInfo(String.Format("حجم فایل انتخابی نباید از {0} کیلوبایت تجاوز کند ", MaxFileSize))
                Exit Sub
            End If
            Dim Img As System.Drawing.Image
            Img = Image.FromFile(fl.FileName)
            Dim SizeWidth As Integer
            Dim SizeHeight As Integer
            Dim MaxSizeWidth As Integer = Param.GetValue(3)
            Dim MaxSizeHeight As Integer = Param.GetValue(2)
            With Img
                SizeWidth = .Size.Width
                SizeHeight = .Size.Height
            End With
            If SizeWidth > MaxSizeWidth Or SizeHeight > MaxSizeHeight Then
                Dialog.ShowInfo(String.Format("ابعاد فایل انتخابی نباید از {1}*{0} پیکسل تجاوز کند ", MaxSizeWidth, MaxSizeHeight))
                Exit Sub
            End If
            PicPersoneli.Image = Image.FromFile(fl.FileName)
        Catch ex As Exception
            Dialog.ShowErorr("مشکلی در بار گذاری تصویر بوجود آمده است", ex.Message)
        End Try
    End Sub

    Private Sub FrmKarmand_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Me.Mode = My_Mode.AddNew Then
            ResetControls()
        End If
    End Sub

    Private Sub BtnRemovePicture_Click(sender As Object, e As EventArgs) Handles BtnRemovePicture.Click
        Me.PicPersoneli.Image = Nothing
    End Sub

    Private Sub CmbJensiat_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbJensiat.SelectedValueChanged
        If CmbJensiat.SelectedValue = 1 Then
            Me.CmbNezamVazifeh.SelectedValue = 0
            Me.CmbNezamVazifeh.Enabled = False
        Else
            Me.CmbNezamVazifeh.Enabled = True
        End If
    End Sub
End Class
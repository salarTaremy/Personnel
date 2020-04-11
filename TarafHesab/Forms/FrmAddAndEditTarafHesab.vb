Public Class FrmAddAndEditTarafHesab
    Private _mode As MyMode = MyMode.Add
    Public TarafHesab As New ClsTarafHesab

    Public Sub New(Optional ID As Integer = Nothing)
        If ID <> Nothing Then
            Me.Mode = MyMode.Edit
            Me.TarafHesab = New ClsTarafHesab(ID)
        End If
        InitializeComponent()
    End Sub
    Public Property Mode As MyMode
        Get
            Return _mode
        End Get
        Set(value As MyMode)
            _mode = value
        End Set
    End Property
    Enum MyMode
        Edit = 0
        Add = 1
    End Enum

    Private Sub FrmAddAndEditTarafHesab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAllCmb()
        With Me.TarafHesab
            Me.TxtName.Text = .FName
            Me.TxtFamil.Text = .LName
            Me.TxtCode_melli.Text = .CodeMelli
            Me.TxtCode_Eghtesadi.Text = .CodeEghtesadi
            Me.TxtSh_Sh.Text = .SH_SH
            Me.TxtNamePedar.Text = .NamePedar
            Me.UcBirthDay.TxtInt = .BirthDay
            Me.UCSodoor.TxtInt = .SodoorDate
            Me.TxtCredit.Text = .Credit
            Me.TxtOldAccountingCode.Text = .OldAccountingCode
            Me.CmbAlphabet.SelectedValue = CInt(Mid(Me.TarafHesab.Serial.ToString, 1, 2))
            Me.TxtSerialA.Text = Mid(Me.TarafHesab.Serial.ToString, 3, 2)
            Me.TxtSerialB.Text = Mid(Me.TarafHesab.Serial.ToString, 5, 6)
            Me.CmbBirth.SelectedValue = .ID_MahalTavalod
            Me.CmbSodor.SelectedValue = .ID_MahalSodoor
            Me.Grd.DataSource = TarafHesab.GetAllProperties()
        End With
        Me.Grd.Columns("ID_Pr").IsVisible = False
        Me.Grd.Columns("PropertyName").HeaderText = "عنوان"
        Me.Grd.Columns("Value").HeaderText = "شرح"
        Me.Grd.Columns("PropertyName").ReadOnly = True
        Me.Grd.Columns("PropertyName").Width = 150
        Me.Grd.Columns("Value").Width = 600
        Me.TxtSerialA.NullText = Nothing
        Me.TxtSerialB.NullText = Nothing
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not IsValidData Then
            Exit Sub
        End If
        With Me.TarafHesab
            .FName = Me.TxtName.Text.Trim
            .LName = Me.TxtFamil.Text.Trim
            .CodeMelli = Me.TxtCode_melli.Text.Trim
            .CodeEghtesadi = Me.TxtCode_Eghtesadi.Text.Trim
            .BirthDay = Me.UcBirthDay.TxtInt
            .SodoorDate = Me.UCSodoor.TxtInt
            .ID_MahalSodoor = Me.CmbSodor.SelectedValue
            .ID_MahalTavalod = Me.CmbBirth.SelectedValue
            .Serial = CmbAlphabet.SelectedValue & TxtSerialA.Text & TxtSerialB.Text
            .NamePedar = Me.TxtNamePedar.Text.Trim
            .SH_SH = Me.TxtSh_Sh.Text.Trim
            .Credit = Me.TxtCredit.Rls
            .OldAccountingCode = Me.TxtOldAccountingCode.Text
        End With
        If Me.Mode = MyMode.Edit Then
            TarafHesab.Update()
        ElseIf Me.Mode = MyMode.Add Then
            TarafHesab.SaveAsNew()
            If TarafHesab.Exists Then
                Me.TarafHesab = New ClsTarafHesab()
                FrmAddAndEditTarafHesab_Load(Nothing, Nothing)
            End If
        End If
        Me.Grd.DataSource = TarafHesab.GetAllProperties
    End Sub
    Private ReadOnly Property IsValidData As Boolean
        Get
            Dim Code_Melli As New Common.ClsCodeMelli(Me.TxtCode_melli.Text.Trim)
            If Not Code_Melli.IsValid Then
                Dialog.ShowInfo("کد ملی نا معتبر است")
                TxtCode_melli.Focus()
                Return False
            End If
            If Me.Mode = MyMode.Add AndAlso Code_Melli.ExistInTh Then
                Dialog.ShowInfo("کد ملی تکراری است")
                TxtCode_melli.Focus()
                Return False
            End If
            If Me.TxtName.Text = Nothing Or Me.TxtName.Text = "" Then
                Dialog.ShowInfo("نام نا معتبر است")
                TxtName.Focus()
                Return False
            End If
            If Me.TxtFamil.Text = Nothing Or Me.TxtFamil.Text = "" Then
                Dialog.ShowInfo("نام خانوادگی نا معتبر است")
                TxtFamil.Focus()
                Return False
            End If
            If Me.TxtCredit.Rls < 0 Then
                Dialog.ShowInfo("اعتبار ریالی صحیح نمیباشد")
                TxtCredit.Focus()
                Return False
            End If
            If Me.CmbAlphabet.SelectedValue <> 0 Then
                If Me.TxtSerialA.Text.Length <> 2 Then
                    Dialog.ShowInfo("قسمت اول سریال شناسنامه باید عددی دو رقمی باشد")
                    TxtSerialA.Focus()
                    Return False
                End If
                If Me.TxtSerialB.Text.Length <> 6 Then
                    Dialog.ShowInfo("قسمت دوم سریال شناسنامه باید عددی شش  رقمی باشد")
                    TxtSerialB.Focus()
                    Return False
                End If
            End If
            Return True
        End Get
    End Property
    Private Sub FillAllCmb()
        Dim cmd As New SqlClient.SqlCommand
        With cmd
            .CommandText &= vbCrLf & "EXEC [Inf].[UspGetPersianAlphabet]"
            .CommandText &= vbCrLf & "EXEC [Inf].[UspGetShahr]"
        End With
        With Me.CmbAlphabet
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = DB.FillDataSet(cmd).Tables(0)
        End With
        With Me.CmbBirth
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = DB.FillDataSet(cmd).Tables(1)
        End With
        With Me.CmbSodor
            .DisplayMember = "Value"
            .ValueMember = "ID"
            .DataSource = DB.FillDataSet(cmd).Tables(1)
        End With
    End Sub

    Private Sub CmbAlphabet_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbAlphabet.SelectedValueChanged
        If Me.CmbAlphabet.SelectedValue = 0 Then
            Me.TxtSerialA.Text = Nothing
            Me.TxtSerialB.Text = Nothing
            Me.TxtSerialA.Enabled = False
            Me.TxtSerialB.Enabled = False
        ElseIf Me.CmbAlphabet.SelectedValue > 50 Then
            Me.TxtSerialA.Text = "00"
            Me.TxtSerialA.Enabled = False
            Me.TxtSerialB.Enabled = True
        Else
            Me.TxtSerialA.Enabled = True
            Me.TxtSerialB.Enabled = True
        End If
    End Sub
    Private Sub BtnSelectBirth_Click(sender As Object, e As EventArgs) Handles BtnSelectBirth.Click
        'Tools.SelectCmb(Me.CmbBirth)
        Me.CmbBirth.Find()
    End Sub

    Private Sub BtnSelectSodoor_Click(sender As Object, e As EventArgs) Handles BtnSelectSodoor.Click
        'Tools.SelectCmb(Me.CmbSodor)
        Me.CmbSodor.Find()
    End Sub
End Class
Public Class FrmPersonnelImportWorkFromDevice
    Dim pr1 As New ClsPersonel()
    Dim pr2 As New ClsPersonel()
    Dim Gr_Date1, Gr_date2 As Integer
    Dim code1 As String = Nothing
    Dim code2 As String = Nothing
    Dim Pw As New ClsPersonnelWork
    Dim IsConnect As Boolean = False
    Dim myConnection As New SqlClient.SqlConnection
    Private Sub BtnReaFromDevice_Click(sender As Object, e As EventArgs) Handles BtnReadFromDevice.Click
        Try
            If Not IsConnect Then
                Dialog.ShowInfo("لطفا ابتدا به سرور متصل شوید")
                Exit Sub
            End If
            Dim cls As ClsClander.PersianDate
            cls = New ClsClander.PersianDate(Me.UcDatePicker1.TxtInt)
            Gr_Date1 = cls.GetProperty("Gregorian_Date")
            cls = New ClsClander.PersianDate(Me.UcDatePicker2.TxtInt)
            Gr_date2 = cls.GetProperty("Gregorian_Date")
            If pr1.Exists Then
                code1 = pr1.CodePersoneli.Trim
            Else
                code1 = Nothing
            End If
            If pr2.Exists Then
                code2 = pr1.CodePersoneli.Trim
            Else
                code2 = Nothing
            End If
            FillGrid(Gr_Date1, Gr_date2, code1, code2)
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه سیستم قادر به خواندن اطلاعات از دستکاه نمیباشد", ex.Message)
        End Try
    End Sub
    Private Sub FillGrid(Gr_Date1, Gr_Date2, code1, code2)
        Try
            Pw = New ClsPersonnelWork(myConnection)
            Me.Grd.DataSource = Pw.ViewPersonnelWorkFromDevice(Gr_Date1, Gr_Date2, code1, code2, True)
            With Me.Grd
                .Columns("EMP_NO").HeaderText = "کد پرسنلی"
                .Columns("Date").HeaderText = "تاریخ"
                .Columns("Time").HeaderText = "ساعت"
                '.Columns("EMP_Name").HeaderText = "نام و نام خانوادگی"
                .Columns("Action").HeaderText = "کد عملکرد "
                .Columns("EMP_NO").Width = 74
                .Columns("Date").Width = 78
                .Columns("Time").Width = 70
                .Columns("Action").Width = 67
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
           
            Dim RowAffect As Integer = Pw.ViewAddPersonnelWorkFromDevice(Me.Grd.DataSource)
            If RowAffect > 0 Then
                Dim Msg As String = String.Format("تعداد '{0}' ردیف با موفقیت ثبت شد", RowAffect)
                Dialog.ShowOK(Msg)
            Else
                Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی ثبت نشد")
            End If
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه سیستم قادر به ارسال اطلاعات به پایگاه داده نمیباشد", ex.Message)
        End Try
    End Sub
    Private Sub TxtPrID1_ValueChanged(sender As Object, e As EventArgs) Handles TxtPrID1.ValueChanged
        pr1 = New ClsPersonel(Me.TxtPrID1.Value)
        TxtName1.Text = pr1.Name & " " & pr1.Famil
    End Sub
    Private Sub BtnBrows1_Click(sender As Object, e As EventArgs) Handles BtnBrows1.Click
        pr1 = New ClsPersonel()
        Me.TxtPrID1.Value = pr1.SelectPersonID()
    End Sub
    Private Sub TxtPrID2_ValueChanged(sender As Object, e As EventArgs) Handles TxtPrID2.ValueChanged
        pr2 = New ClsPersonel(Me.TxtPrID2.Value)
        TxtName2.Text = pr2.Name & " " & pr2.Famil
    End Sub
    Private Sub BtnBrows2_Click(sender As Object, e As EventArgs) Handles BtnBrows2.Click
        pr2 = New ClsPersonel()
        Me.TxtPrID2.Value = pr2.SelectPersonID()
    End Sub

    Private Sub FrmPersonnelImportWorkFromDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth)
        Me.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth)
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Try
            If IsConnect Then
                IsConnect = False
                Me.BtnConnect.Image = My.Resources._0069
                Me.BtnConnect.Text = "برقراری ارتباط  "
                Me.TxtServer.Text = Nothing
                Me.CmbDbName.DataSource = Nothing
            Else
                Dim Frm As New FrmConnectToSql
                Frm.ShowDialog()
                If Frm.Connection IsNot Nothing Then
                    myConnection = Frm.Connection
                    IsConnect = True
                    Me.BtnConnect.Image = My.Resources._0036
                    Me.BtnConnect.Text = "قطع ارتباط  "
                    Me.TxtServer.Text = myConnection.DataSource
                    Me.Pw = New ClsPersonnelWork(myConnection)
                    Me.CmbDbName.DisplayMember = "Name"
                    Me.CmbDbName.ValueMember = "ID"
                    Me.CmbDbName.DataSource = Pw.GetAllDbName
                End If
            End If
        Catch ex As Exception
            Dialog.ShowErorr("متاسفانه بر قراری ارتباط با سرور با مشکل مواجه شد", ex.Message)
        End Try
    End Sub
End Class
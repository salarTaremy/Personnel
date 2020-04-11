
Imports Telerik.Data
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.Export
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports OfficeOpenXml

Public Class UcRadGridViewTools
    Dim WithEvents Grd As Telerik.WinControls.UI.RadGridView
    Dim Dialog As New ClsDialog
    'Dim Exporter As ExportToExcelML
    'Dim ss As New Telerik.WinControls.UI.Export
    'Dim Exporter As New Telerik.WinControls.Export.GridViewPdfExport(Grd)
    Public Property GridView As Telerik.WinControls.UI.RadGridView
        Get
            Return Me.Grd
        End Get
        Set(value As Telerik.WinControls.UI.RadGridView)
            Me.Grd = value
        End Set
    End Property
    Private Sub GetRowCount() Handles Grd.RowsChanged, Grd.FilterChanged
        Me.LblCount.Text = Me.Grd.Rows.Count
        Me.LblChildCount.Text = Me.Grd.ChildRows.Count
    End Sub
    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        'Try
        '    Dim dialog As SaveFileDialog = New SaveFileDialog()
        '    dialog.FileName = "exportedFile"
        '    dialog.Filter = "Excel files (*.Xlsx)|*.Xlsx|All files (*.*)|*.*"
        '    If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        Dim se As New GridViewSpreadExport(Me.Grd)
        '        se.RunExport(dialog.FileName)
        '    End If

        'Catch ex As Exception
        '    Dialog.ShowErorr("مشکلی در تبدیل اطلاعات پیش آمده است.این مشکل میتواند به دلیل قدیمی بودن سیستم عامل شما باشد", ex.Message)
        'End Try
        Try
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.FileName = "exportedFile"
            dialog.Filter = "Excel files (*.Xlsx)|*.Xlsx|All files (*.*)|*.*"
            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim NewFile As New IO.FileInfo(dialog.FileName)
                Dim pck As New ExcelPackage(NewFile)
                Dim ws As ExcelWorksheet = pck.Workbook.Worksheets.Add("Accounts")
                ws.Cells("A1").LoadFromDataTable(Me.Grd.DataSource, True)
                pck.Save()
            End If

        Catch ex As Exception
            Dialog.ShowErorr("مشکلی در تبدیل اطلاعات پیش آمده است.این مشکل میتواند به دلیل قدیمی بودن سیستم عامل شما باشد", ex.Message)
        End Try
    End Sub
    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click
        'Try
        '    Dim dialog As SaveFileDialog = New SaveFileDialog()
        '    dialog.FileName = "exportedFile"
        '    dialog.Filter = "PDF files (*.pdf)|*.Pdf|All files (*.*)|*.*"
        '    If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        Dim pdfExporter As New Telerik.WinControls.Export.GridViewPdfExport(Me.Grd)
        '        Dim exp As New Telerik.WinControls.UI.Export.ExportToPDF(Me.Grd)
        '        pdfExporter.RunExport(dialog.FileName)
        '    End If
        'Catch ex As Exception
        '    Dialog.ShowErorr("مشکلی در تبدیل اطلاعات  پیش آمده است.این مشکل میتواند به دلیل قدیمی بودن سیستم عامل شما باشد", ex.Message)
        'End Try
    End Sub
    Private Sub BtnCsv_Click(sender As Object, e As EventArgs) Handles BtnCsv.Click


    End Sub

    Private Sub BtnHtml_Click(sender As Object, e As EventArgs) Handles BtnHtml.Click

    End Sub
    Private Sub exporter_CSVCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Export.CSV.CSVCellFormattingEventArgs)
        If (e.GridColumnIndex = 1 AndAlso e.GridRowInfoType.Equals(GetType(GridViewDataRowInfo))) Then
            e.CSVCellElement.Value = "test value"
        End If
    End Sub
    Private Sub exporter_CSVTableCreated(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Export.CSV.CSVTableCreatedEventArgs)
        DirectCast(sender, ExportToCSV).AddCustomCSVRow(e.CSVTableElement, "MY TABLE CAPTION")
    End Sub
    Private Sub BtnSum_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles BtnSum.ToggleStateChanged
        Try
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Dim sumItem As New Telerik.WinControls.UI.GridViewSummaryItem()
                Dim sumRowItem As New Telerik.WinControls.UI.GridViewSummaryRowItem()
                For i As Integer = 0 To _Grd.Columns.Count - 1
                    If _Grd.Columns(i).GetType.ToString().Trim <> "Telerik.WinControls.UI.GridViewDecimalColumn" And _Grd.Columns(i).GetType.ToString().Trim <> "Telerik.WinControls.UI.GridViewTextBoxColumn" Then
                        Continue For
                    End If
                    sumItem = New Telerik.WinControls.UI.GridViewSummaryItem()
                    sumItem.Name = _Grd.Columns(i).Name.Trim
                    sumItem.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
                    sumItem.FormatString = "{0:#,###0.}"
                    sumRowItem.Add(sumItem)
                Next
                _Grd.SummaryRowsBottom.Add(sumRowItem)
            Else
                _Grd.SummaryRowsBottom.Clear()
            End If
        Catch ex As Exception
            Dialog.ShowErorr("مشکلی در جمع بندی ستون ها پیش آمده است", ex.Message)
        End Try
    End Sub
    Private Sub BrnFilter_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles BtnFilter.ToggleStateChanged
        Grd.EnableFiltering = args.ToggleState
    End Sub
    Private Sub BtnSearch_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles BtnSearch.ToggleStateChanged
        Me.Grd.AllowSearchRow = args.ToggleState
    End Sub
    Private Sub BtnGroup_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles BtnGroup.ToggleStateChanged
        Me.Grd.EnableGrouping = args.ToggleState
    End Sub
    Private Sub BtnResize_Click(sender As Object, e As EventArgs) Handles BtnResize.Click
        Grd.BestFitColumns(Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells)
    End Sub
    Private Sub GrdRowsChanged() Handles Grd.RowsChanged
        Dim VAL As Boolean
        If _Grd.Rows.Count > 0 Then
            VAL = True
        Else
            VAL = False
        End If
        Me.BtnSum.Enabled = VAL
        Me.BtnFilter.Enabled = VAL
        Me.BtnSearch.Enabled = VAL
        Me.BtnGroup.Enabled = VAL
        Me.BtnResize.Enabled = VAL
        Me.BtnExcel.Enabled = VAL
        Me.BtnCsv.Enabled = VAL
        Me.BtnPdf.Enabled = VAL
        Me.BtnHtml.Enabled = VAL
        SetGrdBtn()
    End Sub
    Private Sub SetGrdBtn()
        BtnSearch.ToggleState = CBool(Grd.AllowSearchRow)
        BtnFilter.ToggleState = CBool(Grd.EnableFiltering)
        BtnGroup.ToggleState = CBool(Grd.EnableGrouping)
    End Sub

    Private Sub BtnColumnSize_Click(sender As Object, e As EventArgs) Handles BtnColumnSize.Click
        Dim s As String = Nothing
        Dim c As String = Chr(34)
        For i As Integer = 0 To _Grd.Columns.Count - 1
            s &= ".Columns(" & c & _Grd.Columns(i).Name & c & ").Width = " & _Grd.Columns(i).Width.ToString & vbCrLf
        Next
        My.Computer.Clipboard.SetText(s)
    End Sub

    Private Sub BtnHeaderText_Click(sender As Object, e As EventArgs) Handles BtnHeaderText.Click
        Dim s As String = Nothing
        Dim c As String = Chr(34)
        For i As Integer = 0 To _Grd.Columns.Count - 1
            s &= ".Columns(" & c & _Grd.Columns(i).Name & c & ").HeaderText = " & c & _Grd.Columns(i).HeaderText & c & vbCrLf
        Next
        My.Computer.Clipboard.SetText(s)
    End Sub

    Private Sub BtnColumnSizeC_Click(sender As Object, e As EventArgs) Handles BtnColumnSizeC.Click
        Dim s As String = Nothing
        Dim c As String = Chr(34)
        Dim Sm As String = Chr(59)
        For i As Integer = 0 To _Grd.Columns.Count - 1
            s &= "this.Grd.Columns[" & c & _Grd.Columns(i).Name & c & "].Width = " & _Grd.Columns(i).Width.ToString & " ;" & vbCrLf
        Next
        My.Computer.Clipboard.SetText(s)
    End Sub

    Private Sub BtnHeaderTextC_Click(sender As Object, e As EventArgs) Handles BtnHeaderTextC.Click
        Dim s As String = Nothing
        Dim c As String = Chr(34)
        Dim Sm As String = Chr(59)
        For i As Integer = 0 To _Grd.Columns.Count - 1
            s &= "this.Grd.Columns[" & c & _Grd.Columns(i).Name & c & "].HeaderText = " & c & _Grd.Columns(i).HeaderText & c & " ;" & vbCrLf
        Next
        My.Computer.Clipboard.SetText(s)
    End Sub

    Private Sub BtnVisible_Click(sender As Object, e As EventArgs) Handles BtnVisible.Click
        Dim s As String = Nothing
        Dim c As String = Chr(34)
        For i As Integer = 0 To _Grd.Columns.Count - 1
            s &= ".Columns(" & c & _Grd.Columns(i).Name & c & ").IsVisible = False" & vbCrLf
        Next
        My.Computer.Clipboard.SetText(s)
    End Sub

    Private Sub BtnVisibleC_Click(sender As Object, e As EventArgs) Handles BtnVisibleC.Click
        Dim s As String = Nothing
        Dim c As String = Chr(34)
        For i As Integer = 0 To _Grd.Columns.Count - 1
            s &= "this.Grd.Columns[" & c & _Grd.Columns(i).Name & c & "].IsVisible = false ;" & vbCrLf
        Next
        My.Computer.Clipboard.SetText(s)
    End Sub

    Private Sub UcRadGridViewTools_Load(sender As Object, e As EventArgs) Handles Me.Load
        If System.Diagnostics.Debugger.IsAttached Then
            Me.BtnColumnSize.Visible = True
            Me.BtnColumnSizeC.Visible = True
            Me.BtnHeaderText.Visible = True
            Me.BtnHeaderTextC.Visible = True
            Me.BtnVisible.Visible = True
            Me.BtnVisibleC.Visible = True
        End If
    End Sub
End Class


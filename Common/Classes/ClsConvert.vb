Imports System.IO
Imports System.Data.OleDb
Imports System.Drawing
Public Class ClsConvert
    Public Function ImageToByte(Value As System.Drawing.Image) As Byte()
        Try
            If Value Is Nothing Then
                Return Nothing
            End If
            Dim ms As New MemoryStream()
            Value.Save(ms, Value.RawFormat)
            Return ms.GetBuffer()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ByteToImage(Value As Byte()) As System.Drawing.Image
        Try
            If Value Is Nothing Then
                Return Nothing
            End If
            Dim imageData As Byte() = DirectCast(Value, Byte())
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                Return Image.FromStream(ms, True)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CsvToDatatableWithOLEDB(Path As String) As DataTable
        Try
            Dim folder = Mid(Path, 1, Path.LastIndexOf("\") + 1)
            Dim file = Mid(Path, Path.LastIndexOf("\") + 2, Path.Length - Path.LastIndexOf("\") + 2)
            Dim CnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";Extended Properties=""text;HDR=No;FMT=Delimited"";"
            Dim dt As New DataTable
            Using Adp As New OleDbDataAdapter("select * from [" & file & "]", CnStr)
                Adp.Fill(dt)
            End Using
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CsvToDatatableManual(ByVal filename As String, Optional ByVal separator As String = ",") As DataTable
        Dim dt As System.Data.DataTable
        Try
            dt = New System.Data.DataTable
            Dim lines = IO.File.ReadAllLines(filename)
            Dim colCount = lines.First.Split(separator).Length
            For i As Int32 = 1 To colCount
                dt.Columns.Add(New DataColumn("Col_" & i, GetType(String)))
            Next
            For Each line In lines
                Dim objFields = From field In line.Split(separator)
                Dim newRow = dt.Rows.Add()
                newRow.ItemArray = objFields.ToArray()
            Next
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

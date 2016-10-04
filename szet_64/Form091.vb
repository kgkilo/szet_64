Imports System.IO
Imports System.Data

Public Class Form091
    Private Sub Form091_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeComponent()
        Me.BindDataGridView()
    End Sub

    Private Sub BindDataGridView()
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Id", GetType(Integer)), _
                                               New DataColumn("Name", GetType(String)), _
                                               New DataColumn("Country", GetType(String))})
        dt.Rows.Add(1, "John Hammond", "United States")
        dt.Rows.Add(2, "Mudassar Khan", "India")
        dt.Rows.Add(3, "Suzanne Mathews", "France")
        dt.Rows.Add(4, "Robert Schidner", "Russia")
        Me.grdPreview.DataSource = dt
    End Sub


    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        'Build the CSV file data as a Comma separated string.
        Dim csv As String = String.Empty

        'Add the Header row for CSV file.
        For Each column As DataGridViewColumn In grdPreview.Columns
            csv += column.HeaderText & ","c
        Next
        MsgBox(csv)

        'Add new line.
        csv += vbCr & vbLf
        MsgBox(csv)

        'Adding the Rows
        For Each row As DataGridViewRow In grdPreview.Rows
            For Each cell As DataGridViewCell In row.Cells
                'Add the Data rows.
                csv += cell.Value.ToString().Replace(",", ";") & ","c
            Next

            'Add new line.
            csv += vbCr & vbLf
        Next

        'Exporting to Excel
        Dim folderPath As String = "C:\CSV\"
        File.WriteAllText(folderPath & "DataGridViewExport.csv", csv)

    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

End Class
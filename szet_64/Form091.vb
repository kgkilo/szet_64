Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class Form091
    Private Sub Form091_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q334TableAdapter.Fill(Me.SZETAVDataSet.sp_Q334)
        cmbDOLGID.SelectedIndex = -1
        Me.BindDataGridView()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BindDataGridView()
        Cursor.Current = Cursors.WaitCursor
        'Grid feltoltese tarolt eljarasbol
        Dim dbadp As New SqlDataAdapter("sp_LekerdNexon", GlobalVars.sConnStr)
        With dbadp.SelectCommand
            .CommandType = CommandType.StoredProcedure
            If cmbDOLGID.SelectedIndex > -1 Then
                .Parameters.Add("@pDOLGID", SqlDbType.Int).Value = cmbDOLGID.SelectedValue
            End If

            Dim dt As New DataTable
            dbadp.Fill(dt)
            dbadp.Dispose()
            grdPreview.DataSource = dt
        End With
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        'Build the CSV file data as a Comma separated string.
        Dim csv As String = String.Empty

        'Add the Header row for CSV file.
        For Each column As DataGridViewColumn In grdPreview.Columns
            csv += column.HeaderText & ","c
        Next

        'Add new line.
        csv += vbCr & vbLf

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

    Private Sub cmbDOLGID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDOLGID.SelectedIndexChanged
        BindDataGridView()
    End Sub
End Class
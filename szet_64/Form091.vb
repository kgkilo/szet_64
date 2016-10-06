Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class Form091
    Private Sub Form091_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q334TableAdapter.Fill(Me.SZETAVDataSet.sp_Q334)

        cmbDOLGID.SelectedIndex = -1    'Nincs dolgozo kivalasztva
        Dim lastDay = DateSerial(Year(Today), Month(Today), 0)  'Elozo honap utolso napja = aktualis honap 0. napja
        Dim firstDay = DateSerial(Year(Today), Month(lastDay), 1)   'Elozo honap elso napja
        datDATUMTOL.Value = firstDay
        datDATUMIG.Value = lastDay

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
            If datDATUMTOL.Checked Then
                .Parameters.Add("@pDATUMTOL", SqlDbType.DateTime).Value = datDATUMTOL.Value
            End If
            If datDATUMIG.Checked Then
                .Parameters.Add("@pDATUMIG", SqlDbType.DateTime).Value = datDATUMIG.Value
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
        'Dim folderPath As String = "C:\CSV\"
        'Dim fileName As String = Now().Year & Now().Month.ToString("00") & Now().Day.ToString("00") _
        '                         & Now.Hour.ToString("00") & Now().Minute.ToString("00") _
        '                         & Now().Second.ToString("00")
        'File.WriteAllText(folderPath & fileName & ".csv", csv)
        'MsgBox("Az exportált állomány: " & folderPath & fileName & ".csv", , "Sikeres export")

        With SaveFileDialog1
            .Filter = "CSV fájlok (*.csv*)|*.csv"
            .AddExtension = True
            .OverwritePrompt = True
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                File.WriteAllText(.FileName, csv)
            End If
        End With
    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

    Private Sub cmbDOLGID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDOLGID.SelectedIndexChanged, cmdFRISSIT.Click
        BindDataGridView()
    End Sub

End Class
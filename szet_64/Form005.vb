Imports System.Data.SqlClient

Public Class Form005
    Private Sub LoadGrid()
        'Grid feltoltese tarolt eljarasbol
        Dim dbadp As New SqlDataAdapter("sp_LekerdDolgozo", GlobalVars.sConnStr)
        With dbadp.SelectCommand
            .CommandType = CommandType.StoredProcedure

            Dim dt As New DataTable
            dbadp.Fill(dt)
            dbadp.Dispose()
            grd005.DataSource = dt
        End With

        'Grid formazasa
        With grd005
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.DarkGray
                .ForeColor = Color.Gray
                .Font = New Font(grd005.Font, FontStyle.Bold)
            End With

            .Columns(0).Visible = False
            .Columns(1).Width = 400
            .Columns(2).Width = 400
            .Columns(3).Width = 400
        End With

        'Talalatok szama
        txtTALALAT.Text = grd005.RowCount

    End Sub

    Private Sub Form005_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Form005_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
        grd005.Width = Me.Width - 119
        grd005.Height = Me.Height - 130
        cmdEXIT.Top = Me.Height - 69
    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

    Private Sub cmdTOROL_Click(sender As Object, e As EventArgs) Handles cmdTOROL.Click
        If MsgBox("Biztos törölni szeretné a kijelölt dolgozót?", MsgBoxStyle.YesNo, "Dolgozó törlése") = MsgBoxResult.Yes Then
            Dim sqlConn As SqlConnection = New SqlConnection(GlobalVars.sConnStr)
            Using (sqlConn)
                Dim sqlComm As SqlCommand = New SqlCommand("sp_DelDolgozo", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = grd005.SelectedRows(0).Cells(0).Value
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End Using

            'Ujra kell tolteni a gridet, mert valtozott az adattartalom
            LoadGrid()
        End If
    End Sub

    Private Sub cmdUJ_Click(sender As Object, e As EventArgs) Handles cmdUJ.Click
        Form005a.Tag = -1   'Insert
        Form005a.ShowDialog(Me)
        LoadGrid()
    End Sub

    Private Sub cmdMODOSIT_Click(sender As Object, e As EventArgs) Handles cmdMODOSIT.Click
        Form005a.Tag = grd005.SelectedRows(0).Cells(0).Value
        Form005a.ShowDialog(Me)
        LoadGrid()
    End Sub
End Class
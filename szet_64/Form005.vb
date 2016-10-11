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
            .AllowUserToAddRows = False 'Nem kell a grid aljan ures sor
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.DarkGray
                .ForeColor = Color.Gray
                .Font = New Font(grd005.Font, FontStyle.Bold)
            End With

            .Columns(0).Visible = False
            .AutoSize = True
        End With

        'Talalatok szama
        txtTALALAT.Text = grd005.RowCount

    End Sub

    Private Sub Form005_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Form005_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        'A cimet kozepre helyezi, a gridet atmeretezi, a legalso gombot is elhelyezi
        ' a form meretenek megfeleloen
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
        grd005.Width = Me.Width - 180
        grd005.Height = Me.Height - 130
        cmdEXIT.Top = Me.Height - 69
    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

    Private Sub cmdTOROL_Click(sender As Object, e As EventArgs) Handles cmdTOROL.Click
        If MsgBox("Biztos törölni szeretné a kijelölt dolgozót?", MsgBoxStyle.YesNo, "Dolgozó törlése") = MsgBoxResult.Yes Then
            Try
                Dim sqlConn As SqlConnection = New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As SqlCommand = New SqlCommand("sp_DelDolgozo", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = grd005.SelectedRows(0).Cells(0).Value
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()

                'Ujra kell tolteni a gridet, mert valtozott az adattartalom
                LoadGrid()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
            End Try
        End If
    End Sub

    Private Sub cmdUJ_Click(sender As Object, e As EventArgs) Handles cmdUJ.Click
        Form005a.Tag = -1   'Insert
        Form005a.ShowDialog(Me)
        Form005a.Dispose()
        LoadGrid()
    End Sub

    Private Sub cmdMODOSIT_Click(sender As Object, e As EventArgs) Handles cmdMODOSIT.Click
        Form005a.Tag = grd005.SelectedRows(0).Cells(0).Value    'A 0. oszlop az ID
        Form005a.ShowDialog(Me)
        Form005a.Dispose()
        LoadGrid()
    End Sub
End Class
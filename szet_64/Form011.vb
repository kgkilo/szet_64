Imports System.Data.SqlClient

Public Class Form011
    Private Sub LoadGrid()
        'Grid feltoltese tarolt eljarasbol
        Dim dbadp As New SqlDataAdapter("sp_LekerdAlt", GlobalVars.sConnStr)
        With dbadp.SelectCommand
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = "03"

            Dim dt As New DataTable
            dbadp.Fill(dt)
            dbadp.Dispose()
            grd011.DataSource = dt
        End With

        'Grid formazasa
        With grd011
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.DarkGray
                .ForeColor = Color.Gray
                .Font = New Font(grd011.Font, FontStyle.Bold)
            End With

            .Columns(0).Visible = False
            .Columns(1).Width = 400
            .Columns(2).Width = 400
            .Columns(3).Width = 400
        End With
    End Sub

    Private Sub Form011_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Form011_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

    Private Sub cmdTOROL_Click(sender As Object, e As EventArgs) Handles cmdTOROL.Click
        If MsgBox("Biztos törölni szeretné a kijelölt objektumot?", MsgBoxStyle.YesNo, "Objektum törlése") = MsgBoxResult.Yes Then
            Dim sqlConn As SqlConnection = New SqlConnection(GlobalVars.sConnStr)
            Using (sqlConn)
                Dim sqlComm As SqlCommand = New SqlCommand("sp_DelObj", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = grd011.SelectedRows(0).Cells(0).Value
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End Using

            'Ujra kell tolteni a gridet, mert valtozott az adattartalom
            LoadGrid()
        End If
    End Sub

    Private Sub cmdUJ_Click(sender As Object, e As EventArgs) Handles cmdUJ.Click
        'Form011a.Tag = -1   'Insert
        'Form011a.ShowDialog(Me)
        'LoadGrid()
    End Sub

    Private Sub cmdMODOSIT_Click(sender As Object, e As EventArgs) Handles cmdMODOSIT.Click
        'Form011a.Tag = grd011.SelectedRows(0).Cells(0).Value
        'Form011a.ShowDialog(Me)
        'LoadGrid()
    End Sub
End Class
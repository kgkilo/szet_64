Imports System.Data.SqlClient

Public Class Form092
    Private Sub LoadGrid()
        Cursor.Current = Cursors.WaitCursor

        If cmbKODTIP.SelectedIndex <> -1 Then
            'Grid feltoltese tarolt eljarasbol
            Dim dbadp As New SqlDataAdapter("sp_LekerdAlt", GlobalVars.sConnStr)
            With dbadp.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbKODTIP.SelectedValue

                Dim dt As New DataTable
                dbadp.Fill(dt)
                dbadp.Dispose()
                grd092.DataSource = dt
            End With

            'Grid formazasa
            Try
                With grd092
                    .AllowUserToAddRows = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .ReadOnly = True

                    With .ColumnHeadersDefaultCellStyle
                        .BackColor = Color.DarkGray
                        .ForeColor = Color.Gray
                        .Font = New Font(grd092.Font, FontStyle.Bold)
                    End With

                    .Columns(0).Visible = False
                    .Columns(1).HeaderText = "Kódérték"
                    .Columns(2).HeaderText = "Megnevezés"
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , ex.ToString)
            End Try

            'Talalatok szama
            txtTALALAT.Text = grd092.RowCount

        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Form011_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)

        cmbKODTIP.SelectedIndex = -1
    End Sub

    Private Sub Form011_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
        grd092.Width = Me.Width - 130
        grd092.Height = Me.Height - 130
        cmdEXIT.Top = Me.Height - 69
    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

    Private Sub cmdTOROL_Click(sender As Object, e As EventArgs) Handles cmdTOROL.Click
        If MsgBox("Biztos törölni szeretné a kijelölt berendezést?", MsgBoxStyle.YesNo, "Berendezés törlése") = MsgBoxResult.Yes Then
            Try
                Dim sqlConn As New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As New SqlCommand("sp_DelObj", sqlConn)
                With sqlComm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@pID", SqlDbType.Int).Value = grd092.SelectedRows(0).Cells(0).Value
                    sqlConn.Open()
                    .ExecuteNonQuery()
                End With

                'Ujra kell tolteni a gridet, mert valtozott az adattartalom
                LoadGrid()
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical, ex.Message)
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub cmdUJ_Click(sender As Object, e As EventArgs) Handles cmdUJ.Click
        If cmbKODTIP.SelectedIndex <> -1 Then
            Form092a.Tag = CInt(cmbKODTIP.SelectedValue) * -1   'Insert
            Form092a.Show(Me)
            LoadGrid()
        End If
    End Sub

    Private Sub cmdMODOSIT_Click(sender As Object, e As EventArgs) Handles cmdMODOSIT.Click
        Try
            Form092a.Tag = grd092.SelectedRows(0).Cells(0).Value
            Form092a.Show(Me)
            LoadGrid()
        Catch ex As Exception
            MsgBox("Nincs kiválasztott berendezés!")
        End Try
    End Sub

    Private Sub cmbkodTIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKODTIP.SelectedIndexChanged, cmbKODTIP.SelectedIndexChanged
        Me.LoadGrid()
    End Sub

End Class
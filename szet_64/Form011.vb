Imports System.Data.SqlClient

Public Class Form011
    Private Sub LoadGrid()
        Cursor.Current = Cursors.WaitCursor

        If cmbOBJTIP.SelectedIndex <> -1 Then
            'Grid feltoltese tarolt eljarasbol
            Dim dbadp As New SqlDataAdapter("sp_LekerdAlt", GlobalVars.sConnStr)
            With dbadp.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
                If Not String.IsNullOrEmpty(txtSEARCH.Text) AndAlso txtSEARCH.TextLength > 3 Then
                    '.Parameters.Add("@pMEGNEV", SqlDbType.VarChar, 50).Value = txtSEARCH.Text
                End If

                Dim dt As New DataTable
                dbadp.Fill(dt)
                dbadp.Dispose()
                grd011.DataSource = dt
            End With

            'Grid formazasa
            Try
                With grd011
                    .AllowUserToAddRows = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .ReadOnly = True

                    With .ColumnHeadersDefaultCellStyle
                        .BackColor = Color.DarkGray
                        .ForeColor = Color.Gray
                        .Font = New Font(grd011.Font, FontStyle.Bold)
                    End With

                    .Columns(0).Visible = False
                    .Columns(1).HeaderText = "Megnevezés"
                    .Columns(2).HeaderText = "Típus"
                    .Columns(3).HeaderText = "Telep. helyszám"
                    .Columns(4).HeaderText = "Gyári szám"
                    .Columns(5).HeaderText = "Üzemidő"
                    For i As Integer = 6 To .ColumnCount - 1
                        .Columns(i).Visible = False
                    Next i
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , ex.ToString)
            End Try

            'Talalatok szama
            txtTALALAT.Text = grd011.RowCount

        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Form011_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)

        cmbOBJTIP.SelectedIndex = -1
    End Sub

    Private Sub Form011_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
        grd011.Width = Me.Width - 130
        grd011.Height = Me.Height - 130
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
                    .Parameters.Add("@pID", SqlDbType.Int).Value = grd011.SelectedRows(0).Cells(0).Value
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
        If cmbOBJTIP.SelectedIndex <> -1 Then
            If cmbOBJTIP.SelectedValue = "01" Then    'Epulet
                Form011b.Tag = -1
                Form011b.Show(Me)
                'Form011b.Dispose()
            Else
                Form011a.Tag = CInt(cmbOBJTIP.SelectedValue) * -1   'Insert
                Form011a.Show(Me)
                'Form011a.Dispose()
            End If
            LoadGrid()
        End If
    End Sub

    Private Sub cmdMODOSIT_Click(sender As Object, e As EventArgs) Handles cmdMODOSIT.Click, grd011.DoubleClick
        Try
            If cmbOBJTIP.SelectedValue.Equals("01") Then    'Epulet
                Form011b.Tag = grd011.SelectedRows(0).Cells(0).Value
                Form011b.Show(Me)
            Else
                Form011a.Tag = grd011.SelectedRows(0).Cells(0).Value
                Form011a.Show(Me)
            End If
            LoadGrid()
        Catch ex As Exception
            MsgBox("Nincs kiválasztott berendezés!")
        End Try
    End Sub

    Private Sub cmbOBJTIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOBJTIP.SelectedIndexChanged
        Me.LoadGrid()
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        If Not String.IsNullOrEmpty(txtSEARCH.Text) AndAlso txtSEARCH.TextLength > 3 Then
            Me.LoadGrid()
        End If
    End Sub
End Class
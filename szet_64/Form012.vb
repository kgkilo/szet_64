'TODO move all 3 grids' formatting to one function

Imports System.Data.SqlClient

Public Class Form012
    Private sqlConn As SqlConnection
    Private iMegnev As Integer

    Private Sub Form012_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)
        Me.cmbOBJTIP.SelectedIndex = -1
        Me.cmbOBJTIP2.SelectedIndex = -1
        Me.cmbOBJTIP2.Enabled = False
        Me.grdNEMKAPCSOLT.Enabled = False
        Me.grdKAPCSOLT.Enabled = False
        Me.cmdODA.Enabled = False
        Me.cmdVISSZA.Enabled = False
        iMegnev = 0
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub cmbOBJTIP_Enter(sender As Object, e As EventArgs) Handles cmbOBJTIP.Enter
        cmbOBJTIP2.Enabled = False
        cmbOBJTIP2.SelectedIndex = -1
        grdMEGNEV.DataSource = Nothing
        grdNEMKAPCSOLT.DataSource = Nothing
        grdKAPCSOLT.DataSource = Nothing
        cmdODA.Enabled = False
        cmdVISSZA.Enabled = False
    End Sub

    Private Sub cmbOBJTIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOBJTIP.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor

        If cmbOBJTIP.SelectedIndex <> -1 Then
            'Grid feltoltese tarolt eljarasbol
            Dim dbadp As New SqlDataAdapter("sp_FillObjMegnev2", GlobalVars.sConnStr)
            With dbadp.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
                .Parameters.Add("@pAKTIV", SqlDbType.Int).Value = 1
                Dim dt As New DataTable
                dbadp.Fill(dt)
                dbadp.Dispose()
                grdMEGNEV.DataSource = dt
            End With

            'Grid formazasa
            Try
                With grdMEGNEV
                    .AllowUserToAddRows = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .ReadOnly = True
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    With .ColumnHeadersDefaultCellStyle
                        .BackColor = Color.DarkGray
                        .ForeColor = Color.Gray
                        .Font = New Font(grdMEGNEV.Font, FontStyle.Bold)
                    End With

                    .Columns(0).Visible = False
                    If cmbOBJTIP.SelectedValue.Equals("01") Then    'Epulet
                        .Columns(1).HeaderText = "Utca"
                        .Columns(2).HeaderText = "Házszám"
                        .Columns(3).HeaderText = "Épületszám"
                        .Columns(4).HeaderText = " "
                    Else
                        .Columns(1).HeaderText = "Megnevezés"
                        .Columns(2).HeaderText = "Típus"
                        .Columns(3).HeaderText = "Telepítési helyszám"
                        .Columns(4).HeaderText = "Gyári szám"
                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , ex.ToString)
            End Try

            'Talalatok szama
            txtTALALAT.Text = grdMEGNEV.RowCount
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdCLOSE_Click(sender As Object, e As EventArgs) Handles cmdCLOSE.Click
        Me.Close()
    End Sub

    Private Sub cmdODA_Click(sender As Object, e As EventArgs) Handles cmdODA.Click
        Cursor.Current = Cursors.WaitCursor
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As SqlCommand = New SqlCommand("sp_Kapcsol", sqlConn)
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.Add("@pID1", SqlDbType.Int).Value = grdMEGNEV.SelectedRows(0).Cells(0).Value
            sqlComm.Parameters.Add("@pID2", SqlDbType.Int).Value = grdNEMKAPCSOLT.SelectedRows(0).Cells(0).Value
            sqlConn.Open()
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try

        'Ujra kell tolteni a gridet, mert valtozott az adattartalom
        LoadGrids()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdVISSZA_Click(sender As Object, e As EventArgs) Handles cmdVISSZA.Click
        Cursor.Current = Cursors.WaitCursor
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As SqlCommand = New SqlCommand("sp_SzetKapcsol", sqlConn)
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.Add("@pID1", SqlDbType.Int).Value = grdMEGNEV.SelectedRows(0).Cells(0).Value
            sqlComm.Parameters.Add("@pID2", SqlDbType.Int).Value = grdKAPCSOLT.SelectedRows(0).Cells(0).Value
            sqlConn.Open()
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try

        'Ujra kell tolteni a gridet, mert valtozott az adattartalom
        LoadGrids()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmbOBJTIP2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOBJTIP2.SelectedIndexChanged
        If cmbOBJTIP2.SelectedIndex <> -1 Then
            cmdODA.Enabled = True
            cmdVISSZA.Enabled = True
            Try
                iMegnev = grdMEGNEV.SelectedRows(0).Cells(0).Value
            Catch
                iMegnev = grdMEGNEV.Rows(0).Cells(0).Value
            End Try

            LoadGrids()
        End If
    End Sub

    Private Sub grdMEGNEV_SelectionChanged(sender As Object, e As EventArgs) Handles grdMEGNEV.SelectionChanged
        cmbOBJTIP2.Enabled = True
        Try
            iMegnev = grdMEGNEV.SelectedRows(0).Cells(0).Value
        Catch
            iMegnev = grdMEGNEV.Rows(0).Cells(0).Value
        End Try
    End Sub

    Private Sub grdMEGNEV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdMEGNEV.CellContentClick
        cmbOBJTIP2.Enabled = True
        iMegnev = grdMEGNEV.SelectedRows(0).Cells(0).Value
    End Sub

    Private Sub LoadGrids()
        Cursor.Current = Cursors.WaitCursor
        Try
            'Nem kapcsolt grid feltoltese
            Using dbadp As New SqlDataAdapter("sp_FillNotConnected", GlobalVars.sConnStr)
                With dbadp.SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP2.SelectedValue
                    .Parameters.Add("@pID", SqlDbType.Int).Value = iMegnev

                    Dim dtNemKapcsolt As New DataTable
                    dbadp.Fill(dtNemKapcsolt)
                    dbadp.Dispose()

                    With grdNEMKAPCSOLT
                        .DataSource = dtNemKapcsolt
                        .AllowUserToAddRows = False
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .ReadOnly = True
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        With .ColumnHeadersDefaultCellStyle
                            .BackColor = Color.DarkGray
                            .ForeColor = Color.Gray
                            .Font = New Font(.Font, FontStyle.Bold)
                        End With

                        .Columns(0).Visible = False
                        If cmbOBJTIP2.SelectedValue.Equals("01") Then   'Epulet
                            .Columns(1).HeaderText = "Utca"
                            .Columns(2).HeaderText = "Házszám"
                            .Columns(3).HeaderText = "Épületszám"
                            .Columns(4).HeaderText = "Helyrajzi szám"
                        Else
                            .Columns(1).HeaderText = "Megnevezés"
                            .Columns(2).HeaderText = "Típus"
                            .Columns(3).HeaderText = "Telepítési helyszám"
                            .Columns(4).HeaderText = "Gyári szám"
                        End If
                    End With
                End With
            End Using

            'Kapcsolt grid feltoltese
            Using dbadp As New SqlDataAdapter("sp_FillConnected", GlobalVars.sConnStr)
                With dbadp.SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP2.SelectedValue
                    .Parameters.Add("@pID", SqlDbType.Int).Value = iMegnev

                    Dim dtKapcsolt As New DataTable
                    dbadp.Fill(dtKapcsolt)
                    dbadp.Dispose()

                    With grdKAPCSOLT
                        .DataSource = dtKapcsolt
                        .AllowUserToAddRows = False
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .ReadOnly = True
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        With .ColumnHeadersDefaultCellStyle
                            .BackColor = Color.DarkGray
                            .ForeColor = Color.Gray
                            .Font = New Font(.Font, FontStyle.Bold)
                        End With

                        .Columns(0).Visible = False
                        If cmbOBJTIP2.SelectedValue.Equals("01") Then   'Epulet
                            .Columns(1).HeaderText = "Utca"
                            .Columns(2).HeaderText = "Házszám"
                            .Columns(3).HeaderText = "Épületszám"
                            .Columns(4).HeaderText = "Helyrajzi szám"
                        Else
                            .Columns(1).HeaderText = "Megnevezés"
                            .Columns(2).HeaderText = "Típus"
                            .Columns(3).HeaderText = "Telepítési helyszám"
                            .Columns(4).HeaderText = "Gyári szám"
                        End If
                    End With
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, ex.Message)
        End Try

        grdNEMKAPCSOLT.Enabled = True
        grdKAPCSOLT.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub
End Class
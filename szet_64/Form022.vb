Imports System.Data.SqlClient

Public Class Form022
    Private sqlConn As SqlConnection

    Private Sub Form022_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q299TableAdapter.Fill(Me.SZETAVDataSet.sp_Q299)
        Me.Sp_Q298TableAdapter.Fill(Me.SZETAVDataSet.sp_Q298)
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)
        Me.cmbMUVEL.SelectedIndex = -1
        Me.cmbOBJTIP.SelectedIndex = -1
        Me.cmbIDOE.SelectedIndex = -1
        Me.cmbIDOE.Enabled = False
        Me.grdNEMKAPCSOLT.Enabled = False
        Me.grdKAPCSOLT.Enabled = False
        Me.cmdODA.Enabled = False
        Me.cmdVISSZA.Enabled = False
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmbOBJTIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOBJTIP.SelectedIndexChanged, cmbMUVEL.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor

        If optCSOPORTOS1.Checked AndAlso cmbMUVEL.SelectedIndex <> -1 Then
            LoadGrids()
            cmdODA.Enabled = True
            cmdVISSZA.Enabled = True
            txtIDO.Enabled = True
            cmbIDOE.Enabled = True
        ElseIf optCSOPORTOS2.Checked AndAlso cmbMUVEL.SelectedIndex <> -1 AndAlso cmbOBJTIP.SelectedIndex <> -1 Then
            LoadGrids()
            cmdODA.Enabled = True
            cmdVISSZA.Enabled = True
            txtIDO.Enabled = True
            cmbIDOE.Enabled = True
        Else
            grdKAPCSOLT.DataSource = Nothing
            grdNEMKAPCSOLT.DataSource = Nothing
            cmdODA.Enabled = False
            cmdVISSZA.Enabled = False
            txtIDO.Enabled = False
            cmbIDOE.Enabled = False
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdCLOSE_Click(sender As Object, e As EventArgs) Handles cmdCLOSE.Click
        Me.Close()
    End Sub

    Private Sub cmdODA_Click(sender As Object, e As EventArgs) Handles cmdODA.Click, grdNEMKAPCSOLT.DoubleClick
        Cursor.Current = Cursors.WaitCursor
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As SqlCommand = New SqlCommand("sp_InsKarbterv", sqlConn)
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.Add("@IDOE", SqlDbType.VarChar, 2).Value = cmbIDOE.SelectedValue
            sqlComm.Parameters.Add("@IDO", SqlDbType.Int).Value = Integer.Parse(txtIDO.Text)
            sqlComm.Parameters.Add("@MUVEL", SqlDbType.VarChar, 3).Value = cmbMUVEL.SelectedValue
            If cmbOBJTIP.SelectedIndex.Equals(-1) Then
                sqlComm.Parameters.Add("@OBJTIP", SqlDbType.VarChar, 2).Value = grdNEMKAPCSOLT.SelectedRows(0).Cells(0).Value
            Else
                sqlComm.Parameters.Add("@OBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
                sqlComm.Parameters.Add("@OBJID", SqlDbType.Int).Value = grdNEMKAPCSOLT.SelectedRows(0).Cells(0).Value
            End If

            sqlConn.Open()
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try

        'Ujra kell tolteni a gridet, mert valtozott az adattartalom
        LoadGrids()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdVISSZA_Click(sender As Object, e As EventArgs) Handles cmdVISSZA.Click, grdKAPCSOLT.DoubleClick
        Cursor.Current = Cursors.WaitCursor
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As SqlCommand = New SqlCommand("sp_DelKarbterv", sqlConn)
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = grdKAPCSOLT.SelectedRows(0).Cells(0).Value
            sqlConn.Open()
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try

        'Ujra kell tolteni a gridet, mert valtozott az adattartalom
        LoadGrids()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub LoadGrids()
        Cursor.Current = Cursors.WaitCursor
        Try
            'Nem kapcsolt grid feltoltese
            Using dbadp As New SqlDataAdapter("sp_FillNincsKarbterv", GlobalVars.sConnStr)
                With dbadp.SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    If cmbOBJTIP.SelectedIndex <> -1 Then
                        .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
                    End If

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
                        If cmbOBJTIP.Enabled Then
                            If cmbOBJTIP.SelectedValue.Equals("01") Then   'Epulet
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
                        Else
                            .Columns(1).HeaderText = "Berendezés típus"
                        End If
                    End With
                End With
            End Using

            'Kapcsolt grid feltoltese
            Using dbadp As New SqlDataAdapter("sp_FillVanKarbterv", GlobalVars.sConnStr)
                With dbadp.SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@pMUVEL", SqlDbType.VarChar, 3).Value = cmbMUVEL.SelectedValue
                    If cmbOBJTIP.SelectedIndex <> -1 Then
                        .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
                    End If

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
                        If cmbOBJTIP.Enabled Then
                            If cmbOBJTIP.SelectedValue.Equals("01") Then   'Epulet
                                .Columns(1).HeaderText = "Utca"
                                .Columns(2).HeaderText = "Házszám"
                                .Columns(3).HeaderText = "Épületszám"
                                .Columns(4).HeaderText = "Helyrajzi szám"
                                .Columns(5).HeaderText = "Idő"
                                .Columns(6).HeaderText = "Időegység"
                            Else
                                .Columns(1).HeaderText = "Megnevezés"
                                .Columns(2).HeaderText = "Típus"
                                .Columns(3).HeaderText = "Telepítési helyszám"
                                .Columns(4).HeaderText = "Gyári szám"
                                .Columns(5).HeaderText = "Idő"
                                .Columns(6).HeaderText = "Időegység"
                            End If
                        Else
                            .Columns(1).HeaderText = "Megnevezés"
                            .Columns(2).HeaderText = "Típus"
                            .Columns(3).HeaderText = "Telepítési helyszám"
                            .Columns(4).HeaderText = "Gyári szám"
                            .Columns(5).HeaderText = "Idő"
                            .Columns(6).HeaderText = "Időegység"
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

    Private Sub txtIDO_TextChanged(sender As Object, e As EventArgs) Handles txtIDO.TextChanged
        If Not String.IsNullOrEmpty(txtIDO.Text) AndAlso cmbIDOE.SelectedIndex <> -1 Then
            cmdODA.Enabled = True
            cmdVISSZA.Enabled = True
        Else
            cmdODA.Enabled = False
            cmdVISSZA.Enabled = False
        End If
    End Sub

    Private Sub cmbIDOE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDOE.SelectedIndexChanged
        If Not String.IsNullOrEmpty(txtIDO.Text) AndAlso cmbIDOE.SelectedIndex <> -1 Then
            cmdODA.Enabled = True
            cmdVISSZA.Enabled = True
        Else
            cmdODA.Enabled = False
            cmdVISSZA.Enabled = False
        End If
    End Sub

    Private Sub RadioChanged()
        If optCSOPORTOS1.Checked Then
            cmbMUVEL.SelectedIndex = -1
            cmbOBJTIP.Enabled = False
            cmbOBJTIP.SelectedIndex = -1
            lblOBJ.Text = "B E R E N D E Z É S  F É L E S É G E K"
            txtIDO.Enabled = True
            txtIDO.Text = String.Empty
            cmbIDOE.Enabled = True
            cmbIDOE.SelectedIndex = -1
            cmdODA.Enabled = False
            cmdVISSZA.Enabled = False
            grdKAPCSOLT.DataSource = Nothing
            grdNEMKAPCSOLT.DataSource = Nothing
        ElseIf optCSOPORTOS2.Checked Then
            cmbOBJTIP.Enabled = True
            lblOBJ.Text = "B E R E N D E Z É S E K"
            txtIDO.Enabled = False
            cmbIDOE.Enabled = False
            cmdODA.Enabled = False
            cmdVISSZA.Enabled = False
            grdKAPCSOLT.DataSource = Nothing
            grdNEMKAPCSOLT.DataSource = Nothing
        End If
    End Sub

    Private Sub optCSOPORTOS1_CheckedChanged(sender As Object, e As EventArgs) Handles optCSOPORTOS1.CheckedChanged
        RadioChanged()
    End Sub

    Private Sub optCSOPORTOS2_CheckedChanged(sender As Object, e As EventArgs) Handles optCSOPORTOS2.CheckedChanged
        RadioChanged()
    End Sub
End Class
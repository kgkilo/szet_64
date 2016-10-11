﻿Imports System.Data.SqlClient

Public Class Form012

    Private Sub Form012_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)
        Me.cmbOBJTIP.SelectedIndex = -1
        Me.cmbOBJTIP2.SelectedIndex = -1
        Me.cmbOBJTIP2.Enabled = False
        Me.grdNEMKAPCSOLT.Enabled = False
        Me.grdKAPCSOLT.Enabled = False
        Me.cmdODA.Enabled = False
        Me.cmdVISSZA.Enabled = False
    End Sub

    Private Sub cmbOBJTIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOBJTIP.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor

        If cmbOBJTIP.SelectedIndex <> -1 Then
            'cmbOBJTIP2.Enabled = False

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

    Private Sub cmdCLOSE_Click(sender As Object, e As EventArgs) Handles cmdCLOSE.Click, cmdVISSZA.Click, cmdODA.Click
        Me.Close()
    End Sub

    Private Sub cmbOBJTIP2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOBJTIP2.SelectedIndexChanged
        If cmbOBJTIP2.SelectedIndex <> -1 Then
            grdNEMKAPCSOLT.Enabled = True
            grdKAPCSOLT.Enabled = True
            cmdODA.Enabled = True
            cmdVISSZA.Enabled = True

            'Nem kapcsolt grid feltoltese
            Using dbadp As New SqlDataAdapter("sp_FillNotConnected", GlobalVars.sConnStr)
                With dbadp.SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP2.SelectedValue
                    .Parameters.Add("@pID", SqlDbType.Int).Value = grdMEGNEV.SelectedRows(0).Cells(0).Value
                    Dim dtNemKapcsolt As New DataTable
                    dbadp.Fill(dtNemKapcsolt)
                    dbadp.Dispose()
                    grdNEMKAPCSOLT.DataSource = dtNemKapcsolt
                End With
            End Using

            'Kapcsolt grid feltoltese
            Using dbadp As New SqlDataAdapter("sp_FillConnected", GlobalVars.sConnStr)
                With dbadp.SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP2.SelectedValue
                    .Parameters.Add("@pID", SqlDbType.Int).Value = grdMEGNEV.SelectedRows(0).Cells(0).Value
                    Dim dtKapcsolt As New DataTable
                    dbadp.Fill(dtKapcsolt)
                    dbadp.Dispose()
                    grdKAPCSOLT.DataSource = dtKapcsolt
                End With
            End Using
        End If
    End Sub

    Private Sub grdMEGNEV_SelectionChanged(sender As Object, e As EventArgs) Handles grdMEGNEV.SelectionChanged
        cmbOBJTIP2.Enabled = True
    End Sub

    Private Sub grdMEGNEV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdMEGNEV.CellContentClick
        cmbOBJTIP2.Enabled = True
    End Sub
End Class
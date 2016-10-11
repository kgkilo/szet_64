Imports System.Data.SqlClient

Public Class Form012

    Private Sub Form012_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)
        Me.cmbOBJTIP.SelectedIndex = -1
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
End Class
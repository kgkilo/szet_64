Imports System.Data.SqlClient

Public Class Form023

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

    Private Sub cmdFRISSIT_Click(sender As Object, e As EventArgs) Handles cmdFRISSIT.Click
        Cursor.Current = Cursors.WaitCursor

        'Grid feltoltese tarolt eljarasbol
        Dim dbadp As New SqlDataAdapter("sp_LekerdKarban", GlobalVars.sConnStr)
        With dbadp.SelectCommand
            .CommandType = CommandType.StoredProcedure
            'Tartolt eljaras parametereinek feltoltese
            If cmbMUVEL.SelectedIndex <> -1 Then
                .Parameters.Add("@pMUVEL", SqlDbType.VarChar, 3).Value = cmbMUVEL.SelectedValue
            End If

            If cmbOBJTIP.SelectedIndex <> -1 Then
                .Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
            End If

            If cmbOBJID.SelectedIndex <> -1 Then
                .Parameters.Add("@pOBJID", SqlDbType.Int).Value = cmbOBJID.SelectedValue
            End If

            If datDATUMTOL.Checked Then
                .Parameters.Add("@pDATUMTOL", SqlDbType.DateTime).Value = datDATUMTOL.Value
            End If

            If datDATUMIG.Checked Then
                .Parameters.Add("@pDATUMIG", SqlDbType.DateTime).Value = datDATUMIG.Value
            End If

        End With

        Dim dt As New DataTable
        dbadp.Fill(dt)
        dbadp.Dispose()
        grdKARBTERV.DataSource = dt

        'Grid formazasa
        With grdKARBTERV
            .AllowUserToAddRows = False 'Nem kell a grid aljan ures sor
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.DarkGray
                .ForeColor = Color.Gray
                .Font = New Font(grdKARBTERV.Font, FontStyle.Bold)
            End With

            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Fűtőmű"
            .Columns(2).HeaderText = "Lépcsőház"
            .Columns(3).HeaderText = "Ber. típus"
            .Columns(4).HeaderText = "Berendezés"
            .Columns(5).HeaderText = "Típus"
            .Columns(6).HeaderText = "Telep. hsz"
            .Columns(7).HeaderText = "Gy.szám"
            .Columns(8).HeaderText = "Cím"
            .Columns(9).HeaderText = "Művelet"
            .Columns(10).HeaderText = "Terv. dátum"
            .Columns(11).HeaderText = "Karb. dátum"
            .Columns(12).HeaderText = "Átmérő"
            .Columns(13).HeaderText = "Impulzus"
            .Columns(14).HeaderText = "Vez. hossz"
            .Columns(15).HeaderText = "Beny. hossz"
            .Columns(16).HeaderText = "Megj."

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With

        'Talalatok szama
        txtTALALAT.Text = grdKARBTERV.RowCount

        'Villogas vege
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Form023_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q298TableAdapter.Fill(Me.SZETAVDataSet.sp_Q298)
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)

        datDATUMTOL.Value = DateAdd("m", -1, Now)
        datDATUMTOL.Checked = True
        datDATUMIG.Value = Now
        datDATUMIG.Checked = True

        cmbMUVEL.SelectedValue = 1    'Uzemfenntartas
        cmbOBJTIP.SelectedIndex = -1

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmbOBJTIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOBJTIP.SelectedIndexChanged
        If cmbOBJTIP.SelectedIndex <> -1 Then
            Cursor.Current = Cursors.WaitCursor

            'Objektum tipus alapjan objektum combobox feltoltese
            Dim dbadpObjid As New SqlDataAdapter("sp_FillObjMegnev", GlobalVars.sConnStr)
            With dbadpObjid
                With .SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@pObjTip", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
                End With

                Dim dtObjid As New DataTable
                .Fill(dtObjid)
                .Dispose()
                cmbOBJID.DataSource = dtObjid
                cmbOBJID.DisplayMember = "MEGNEV"
                cmbOBJID.ValueMember = "ID"
                cmbOBJID.SelectedIndex = -1
            End With

            Cursor.Current = Cursors.Default
        End If
    End Sub

End Class
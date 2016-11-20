Imports System.Data.SqlClient

Public Class Form021

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

            If cmbSZOLGJELL.SelectedIndex <> -1 Then
                .Parameters.Add("@pSZOLGJ", SqlDbType.VarChar, 2).Value = cmbSZOLGJELL.SelectedValue
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
        grdKARBAN.DataSource = dt

        'Grid formazasa
        With grdKARBAN
            .AllowUserToAddRows = False 'Nem kell a grid aljan ures sor
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.DarkGray
                .ForeColor = Color.Gray
                .Font = New Font(grdKARBAN.Font, FontStyle.Bold)
            End With

            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Berendezés típus"
            .Columns(2).HeaderText = "Berendezés"
            .Columns(3).HeaderText = "Típus"
            .Columns(4).HeaderText = "Telep. hsz."
            .Columns(5).HeaderText = "Gy. szám"
            .Columns(6).HeaderText = "Szolgáltatás"
            .Columns(7).HeaderText = "Művelet"
            .Columns(8).HeaderText = "Dátum"
            .Columns(9).HeaderText = "Munkalap"
            .Columns(10).HeaderText = "Művelet leírása"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With

        'Talalatok szama
        txtTALALAT.Text = grdKARBAN.RowCount

        'Villogas vege
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Form021_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q298TableAdapter.Fill(Me.SZETAVDataSet.sp_Q298)
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)
        Me.Sp_Q291TableAdapter.Fill(Me.SZETAVDataSet.sp_Q291)

        datDATUMTOL.Value = DateAdd("m", -1, Now)
        datDATUMTOL.Checked = True
        datDATUMIG.Value = Now
        datDATUMIG.Checked = True

        cmbSZOLGJELL.SelectedIndex = -1
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

    Private Sub cmdTERVEK_Click(sender As Object, e As EventArgs) Handles cmdTERVEK.Click
        Form022.ShowDialog(Me)
        Form022.Dispose()
    End Sub

End Class
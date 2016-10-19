Imports System.Data.SqlClient

Public Class Form001

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click, cmdMASOL.Click, cmdLIST.Click, cmdCSOPLIST.Click
        Me.Close()
    End Sub

    Private Sub cmdVISSZAIR_Click(sender As Object, e As EventArgs) Handles cmdVISSZAIR.Click
        Try
            Form002.Tag = grdMUNKALAP.SelectedRows(0).Cells(0).Value
            Form002.ShowDialog(Me)
            Form002.Dispose()
            cmdFRISSIT_Click(sender, e)
        Catch
        End Try
    End Sub

    Private Sub cmdUJ_Click(sender As Object, e As EventArgs) Handles cmdUJ.Click
        Form001a.Tag = -1   'Insert
        Form001a.ShowDialog(Me)
        Form001a.Dispose()
    End Sub

    Private Sub cmdFRISSIT_Click(sender As Object, e As EventArgs) Handles cmdFRISSIT.Click
        Cursor.Current = Cursors.WaitCursor

        'Grid feltoltese tarolt eljarasbol
        Dim dbadp As New SqlDataAdapter("sp_LekerdMlap", GlobalVars.sConnStr)
        With dbadp.SelectCommand
            .CommandType = CommandType.StoredProcedure
            'Tartolt eljaras parametereinek feltoltese
            If cmbMLAPTIP.SelectedIndex <> -1 Then
                .Parameters.Add("@MLAPTIP", SqlDbType.VarChar, 1).Value = cmbMLAPTIP.SelectedValue
            End If

            If cmbSZOLGJELL.SelectedIndex <> -1 Then
                .Parameters.Add("@SZOLGJELL", SqlDbType.VarChar, 2).Value = cmbSZOLGJELL.SelectedValue
            End If

            If cmbTIPUSH.SelectedIndex <> -1 Then
                .Parameters.Add("@TIPUSH", SqlDbType.VarChar, 3).Value = cmbTIPUSH.SelectedValue
            End If

            If cmbFSZAM.SelectedIndex <> -1 Then
                .Parameters.Add("@FSZAM", SqlDbType.VarChar, 12).Value = cmbFSZAM.SelectedValue
            End If

            If cmbOBJTIP.SelectedIndex <> -1 Then
                .Parameters.Add("@OBJTIP", SqlDbType.VarChar, 2).Value = cmbOBJTIP.SelectedValue
            End If

            If cmbOBJID.SelectedIndex <> -1 Then
                .Parameters.Add("@OBJID", SqlDbType.Int).Value = cmbOBJID.SelectedValue
            End If

            If cmbDOLGID.SelectedIndex <> -1 Then
                .Parameters.Add("@DOLGID", SqlDbType.Int).Value = cmbDOLGID.SelectedValue
            End If

            If datDATUMTOL.Checked Then
                .Parameters.Add("@DATUMTOL", SqlDbType.DateTime).Value = datDATUMTOL.Value
            End If

            If datDATUMIG.Checked Then
                .Parameters.Add("@DATUMIG", SqlDbType.DateTime).Value = datDATUMIG.Value
            End If

            If datMUNDATTOL.Checked Then
                .Parameters.Add("@MUNDATTOL", SqlDbType.DateTime).Value = datMUNDATTOL.Value
            End If

            If datMUNDATIG.Checked Then
                .Parameters.Add("@MUNDATIG", SqlDbType.DateTime).Value = datMUNDATIG.Value
            End If

            If cmbALLAPOT.SelectedIndex <> -1 Then
                .Parameters.Add("@ALLAPOT", SqlDbType.Int).Value = cmbALLAPOT.SelectedValue
            End If

            If txtMUNKALAPID.Text <> "" Then
                .Parameters.Add("@MUNKALAPID", SqlDbType.Int).Value = CInt(txtMUNKALAPID.Text)
            End If

            If cmbTELEPHSZ.SelectedIndex <> -1 Then
                .Parameters.Add("@TELEPHSZ", SqlDbType.VarChar, 20).Value = cmbTELEPHSZ.SelectedValue
            End If

            If datMUNELV.Checked Then
                .Parameters.Add("@MUNELV", SqlDbType.DateTime).Value = datMUNELV.Value
            End If

        End With

        Dim dt As New DataTable
        dbadp.Fill(dt)
        dbadp.Dispose()
        grdMUNKALAP.DataSource = dt

        'Grid formazasa
        With grdMUNKALAP
            .AllowUserToAddRows = False 'Nem kell a grid aljan ures sor
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.DarkGray
                .ForeColor = Color.Gray
                .Font = New Font(grdMUNKALAP.Font, FontStyle.Bold)
            End With

            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Sorszám"
            .Columns(2).HeaderText = "Bejelentő"
            .Columns(3).HeaderText = "Kiáll. dátum"
            .Columns(4).HeaderText = "Végezhető"
            .Columns(5).HeaderText = "Szolg. jellege"
            .Columns(6).HeaderText = "Helyszín"
            .Columns(7).HeaderText = "Berendezés"
            .Columns(8).HeaderText = "Telep. hsz."
            .Columns(9).HeaderText = "Hiba leírása"
            .Columns(10).HeaderText = "Elvégzett munka"
            .Columns(11).HeaderText = "Dolgozó"
            .Columns(12).HeaderText = "Visszaírás"
            .Columns(13).HeaderText = "Munkaóra"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With

        'Munkaora osszeszamolasa
        Dim iOra As Long = 0
        Dim o As DataGridViewRow
        For Each o In grdMUNKALAP.Rows
            iOra += CLng(If(o.Cells(13).Value, 0))
        Next o
        txtMUNOSZ.Text = iOra

        'Talalatok szama
        txtTALALAT.Text = grdMUNKALAP.RowCount

        'Villogas vege
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Form001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)
        Me.Sp_Q335TableAdapter.Fill(Me.SZETAVDataSet.sp_Q335)
        Me.Sp_Q337TableAdapter.Fill(Me.SZETAVDataSet.sp_Q337)
        Me.Sp_Q310ATableAdapter.Fill(Me.SZETAVDataSet.sp_Q310A)
        Me.Sp_Q293TableAdapter.Fill(Me.SZETAVDataSet.sp_Q293)
        Me.Sp_Q291TableAdapter.Fill(Me.SZETAVDataSet.sp_Q291)
        Me.Sp_Q334TableAdapter1.Fill(Me.SZETAVDataSet.sp_Q334)

        datDATUMTOL.Value = DateAdd("m", -1, Now)
        datDATUMTOL.Checked = True
        datDATUMIG.Value = Now
        datDATUMIG.Checked = True
        datMUNDATTOL.Value = Now
        datMUNDATTOL.Checked = False
        datMUNDATIG.Value = Now
        datMUNDATIG.Checked = False
        datMUNELV.Value = Now
        datMUNELV.Checked = False

        cmbSZOLGJELL.SelectedIndex = -1
        cmbTIPUSH.SelectedIndex = -1
        cmbFSZAM.SelectedIndex = -1
        cmbMLAPTIP.SelectedValue = 1    'Uzemfenntartas
        cmbALLAPOT.SelectedValue = 5    'Nem sztornozott
        cmbOBJTIP.SelectedIndex = -1
        cmbDOLGID.SelectedIndex = -1

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

            'Objektum tipus alapjan telepitesi helyszam combobox feltoltese
            Dim dbadpTelephsz As New SqlDataAdapter("sp_FillObjTelephsz", GlobalVars.sConnStr)
            With dbadpTelephsz
                With .SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    Dim sParam As SqlParameter = .Parameters.Add("@pObjTip", SqlDbType.VarChar, 2)
                    sParam.Value = cmbOBJTIP.SelectedValue
                End With

                Dim dtTelephsz As New DataTable
                .Fill(dtTelephsz)
                .Dispose()
                cmbTELEPHSZ.DataSource = dtTelephsz
                cmbTELEPHSZ.DisplayMember = "MEGNEV"
                cmbTELEPHSZ.ValueMember = "ID"
                cmbTELEPHSZ.SelectedIndex = -1
            End With

            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub cmdMODOSIT_Click(sender As Object, e As EventArgs) Handles cmdMODOSIT.Click
        Form001a.Tag = grdMUNKALAP.SelectedRows(0).Cells(0).Value()   'Update
        Form001a.ShowDialog(Me)
        Form001a.Dispose()
    End Sub
End Class
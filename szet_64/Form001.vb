Imports System.Data.SqlClient

Public Class Form001

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click, cmdVISSZAIR.Click, cmdUJ.Click, cmdMODOSIT.Click, cmdMASOL.Click, cmdLIST.Click, cmdCSOPLIST.Click
        Me.Close()
    End Sub

    Private Sub cmdFRISSIT_Click(sender As Object, e As EventArgs) Handles cmdFRISSIT.Click
        Cursor.Current = Cursors.WaitCursor

        'Grid feltoltese tarolt eljarasbol
        Dim dbadp As New SqlDataAdapter("sp_LekerdMlap", "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")
        With dbadp.SelectCommand
            .CommandType = CommandType.StoredProcedure
            Dim aaa As SqlParameter = .Parameters.Add("@MLAPTIP", SqlDbType.VarChar, 1)
            If cmbMLAPTIP.SelectedValue <> -1 Then
                aaa.Value = cmbMLAPTIP.SelectedValue
            Else
                aaa.Value = ""
            End If
        End With

        Dim dt As New DataTable
        dbadp.Fill(dt)
        dbadp.Dispose()
        grdMUNKALAP.DataSource = dt

        'Grid formazasa
        With grdMUNKALAP
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            With grdMUNKALAP.ColumnHeadersDefaultCellStyle
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
        End With

        'Munkaora osszeszamolasa
        Dim iOra As Long = 0
        Dim t As String

        With grdMUNKALAP
            For i As Long = 1 To (.RowCount - 1)
                t = .Rows(i).Cells(14).Value
                If t <> "" Then iOra += CLng(t)
            Next i
        End With
        txtMUNOSZ.Text = iOra

        'Talalatok szama
        txtTALALAT.Text = grdMUNKALAP.RowCount - 1

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
        datDATUMTOL.Checked = False
        datDATUMIG.Value = Now
        datDATUMIG.Checked = False
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
            Dim dbadpObjid As New SqlDataAdapter("sp_FillObjMegnev", "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")
            With dbadpObjid
                With .SelectCommand
                    .CommandType = CommandType.StoredProcedure
                    Dim sParam As SqlParameter = .Parameters.Add("@pObjTip", SqlDbType.VarChar, 2)
                    sParam.Value = cmbOBJTIP.SelectedValue
                End With

                Dim dtObjid As New DataTable
                .Fill(dtObjid)
                .Dispose()
                cmbOBJID.DataSource = dtObjid
            End With

            'Objektum tipus alapjan telepitesi helyszam combobox feltoltese
            Dim dbadpTelephsz As New SqlDataAdapter("sp_FillObjTelephsz", "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")
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
            End With

            Cursor.Current = Cursors.Default
        End If
    End Sub

End Class
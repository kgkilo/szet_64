Public Class Form001

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdMUNKALAP.CellContentClick

    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click, cmdVISSZAIR.Click, cmdUJ.Click, cmdMODOSIT.Click, cmdMASOL.Click, cmdLIST.Click, cmdCSOPLIST.Click
        Me.Close()
    End Sub

    Private Sub cmdFRISSIT_Click(sender As Object, e As EventArgs) Handles cmdFRISSIT.Click
        Cursor.Current = Cursors.WaitCursor

        'Grid feltoltese tarolt eljarasbol
        Dim dbadp As New System.Data.SqlClient.SqlDataAdapter("sp_LekerdMlap", "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")
        dbadp.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        dbadp.Fill(dt)
        dbadp.Dispose()
        grdMUNKALAP.DataSource = dt

        'Grid formazasa
        With grdMUNKALAP
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

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

        datDATUMIG.Value = Now()
        datDATUMTOL.Value = DateAdd("m", -1, Now())
        datMUNDATTOL.Value = Now()
        datMUNDATIG.Value = Now()

        cmbSZOLGJELL.SelectedIndex = -1
        cmbTIPUSH.SelectedIndex = -1
        cmbFSZAM.SelectedIndex = -1
        cmbMLAPTIP.SelectedValue = 1    'TODO: check if integer works or string is needed
        cmbALLAPOT.SelectedValue = 5
        cmbOBJTIP.SelectedIndex = -1
        cmbDOLGID.SelectedIndex = -1

        Cursor.Current = Cursors.Default
    End Sub
End Class
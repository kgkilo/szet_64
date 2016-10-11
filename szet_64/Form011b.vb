Imports System.Data.SqlClient

Public Class Form011b
    Private sqlConn As SqlConnection

    Private Sub Form011b_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q272TableAdapter.Fill(Me.SZETAVDataSet.sp_Q272)
        Me.Sp_Q274TableAdapter.Fill(Me.SZETAVDataSet.sp_Q274)
        Me.Sp_Q275TableAdapter.Fill(Me.SZETAVDataSet.sp_Q275)
        Me.Sp_Q276TableAdapter.Fill(Me.SZETAVDataSet.sp_Q276)
        Me.Sp_Q277TableAdapter.Fill(Me.SZETAVDataSet.sp_Q277)
        Me.Sp_Q278TableAdapter.Fill(Me.SZETAVDataSet.sp_Q278)
        Me.Sp_Q281TableAdapter.Fill(Me.SZETAVDataSet.sp_Q281)
        Me.Sp_Q282TableAdapter.Fill(Me.SZETAVDataSet.sp_Q282)
        Me.Sp_Q283TableAdapter.Fill(Me.SZETAVDataSet.sp_Q283)
        Me.Sp_Q284TableAdapter.Fill(Me.SZETAVDataSet.sp_Q284)
        Me.Sp_Q288TableAdapter.Fill(Me.SZETAVDataSet.sp_Q288)
        Me.Sp_Q289TableAdapter.Fill(Me.SZETAVDataSet.sp_Q289)
        Me.Sp_Q327TableAdapter.Fill(Me.SZETAVDataSet.sp_Q327)
        Me.Sp_Q328TableAdapter.Fill(Me.SZETAVDataSet.sp_Q328)
        Me.Sp_Q329TableAdapter.Fill(Me.SZETAVDataSet.sp_Q329)
        Me.Sp_Q330TableAdapter.Fill(Me.SZETAVDataSet.sp_Q330)

        If Me.Tag > 0 Then  'Tag fel volt toltve ertelmes indexszel, be kell tolteni azt a rekordot
            LoadAltalanos()
        Else
            'Uj rekord insert
        End If

        Cursor.Current = Cursors.Default
    End Sub

    'Feltolti a lap control-jait
    Private Sub LoadAltalanos()
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As New SqlCommand("sp_LoadEpul", sqlConn)
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

            sqlConn.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    Dim p As Object
                    For Each p In {Me.GroupBox1, Me.GroupBox2}
                        For Each o As Object In p.controls
                            Try
                                Dim sName As String
                                sName = If(o.Name.StartsWith("dt"), o.Name.Substring(2), o.Name.Substring(3))
                                If o.Name.StartsWith("txt") Then
                                    o.Text = If(sqlReader.Item(sName).ToString, "")
                                ElseIf o.Name.StartsWith("cmb") Then
                                    CType(o, ComboBox).SelectedValue = If(sqlReader.Item(sName), -1)
                                ElseIf o.Name.StartsWith("dt") Then
                                    CType(o, DateTimePicker).Value = If(sqlReader.Item(sName), 0)
                                ElseIf o.Name.StartsWith("chk") Then
                                    CType(o, CheckBox).Checked = sqlReader.Item(sName).Equals("y")
                                End If
                            Catch
                                'Ez a catch azert ures, mert sok olyan mezo lehet a form-on, amit
                                'az SQL lekerdezes nem ad vissza. Ez nem gond, menni kell tovabb!
                            End Try
                        Next    'o
                    Next    'p
                End While   'SqlReader.Read
            End If   'HasRows
            sqlReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try
    End Sub

    Private Sub Form011b_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
    End Sub

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As SqlCommand
            If Me.Tag < 0 Then  'Uj rekordot kell rogziteni
                sqlComm = New SqlCommand("sp_InsEpul", sqlConn)
            Else    'Meglevo rekord update
                sqlComm = New SqlCommand("sp_UpdEpul", sqlConn)
                sqlComm.Parameters.AddWithValue("pID", Me.Tag)
            End If

            With sqlComm
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("IRSZAM", txtIRSZAM.Text)
                .Parameters.AddWithValue("VAROS", cmbVAROS.SelectedValue)
                .Parameters.AddWithValue("UTCA", txtUTCA.Text)
                .Parameters.AddWithValue("HSZ", txtHSZ.Text)
                .Parameters.AddWithValue("HELYR", txtHELYR.Text)
                .Parameters.AddWithValue("EPULSZ", txtEPULSZ.Text)
                .Parameters.AddWithValue("EPULTIP", cmbEPULTIP.SelectedValue)
                .Parameters.AddWithValue("EPULNEV", txtEPULNEV.Text)

                .Parameters.AddWithValue("FUTESMOD", cmbFUTESMOD.SelectedValue)
                .Parameters.AddWithValue("LEGTHELY", cmbLEGTHELY.SelectedValue)
                .Parameters.AddWithValue("FUTOTIP", cmbFUTOTIP.SelectedValue)
                .Parameters.AddWithValue("KARBANTAR", cmbKARBANTAR.SelectedValue)
                If txtLAKTERF.Text <> "" Then .Parameters.AddWithValue("LAKTERF", Double.Parse(txtLAKTERF.Text))
                If txtKOZOSTERF.Text <> "" Then .Parameters.AddWithValue("KOZOSTERF", Double.Parse(txtKOZOSTERF.Text))
                If txtTERF_ARAM.Text <> "" Then .Parameters.AddWithValue("TERF_ARAM", Double.Parse(txtTERF_ARAM.Text))
                If txtEPUL_ARAM.Text <> "" Then .Parameters.AddWithValue("EPUL_ARAM", Double.Parse(txtEPUL_ARAM.Text))
                .Parameters.AddWithValue("ATKOTES", If(chkATKOTES.Checked, "y", "n"))

                .Parameters.AddWithValue("FUTBESZAB", cmbFUTBESZAB.SelectedValue)
                .Parameters.AddWithValue("CIRK_MOD", cmbCIRK_MOD.SelectedValue)
                If txtNYOMKUL.Text <> "" Then .Parameters.AddWithValue("NYOMKUL", Double.Parse(txtNYOMKUL.Text))
                .Parameters.AddWithValue("FELOSZT", cmbFELOSZT.SelectedValue)
                .Parameters.AddWithValue("LEGTELTIP", cmbLEGTELTIP.SelectedValue)
                .Parameters.AddWithValue("EPULATAD", Date.Parse(txtEPULATAD.Text))
                .Parameters.AddWithValue("UZEMELT", cmbUZEMELT.SelectedValue)
                If txtEPULHOSZ.Text <> "" Then .Parameters.AddWithValue("EPULHOSZ", Double.Parse(txtEPULHOSZ.Text))

                If txtLEPCSOTERF.Text <> "" Then .Parameters.AddWithValue("LEPCSOTERF", Double.Parse(txtLEPCSOTERF.Text))
                If txtKOZULTERF.Text <> "" Then .Parameters.AddWithValue("KOZULTERF", Double.Parse(txtKOZULTERF.Text))
                .Parameters.AddWithValue("HOLEPCSO", cmbHOLEPCSO.SelectedValue)
                If txtCIRK_ARAM.Text <> "" Then .Parameters.AddWithValue("CIRK_ARAM", Double.Parse(txtCIRK_ARAM.Text))
                .Parameters.AddWithValue("CIRKUL", cmbCIRKUL.SelectedValue)
                .Parameters.AddWithValue("HMVRENDS", cmbHMVRENDS.SelectedValue)
                .Parameters.AddWithValue("FOELZ", cmbFOELZ.SelectedValue)
                .Parameters.AddWithValue("UTEM", cmbUTEM.SelectedValue)

                sqlConn.Open()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try

        Me.Close()
    End Sub

End Class
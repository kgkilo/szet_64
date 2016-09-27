Imports System.Data.SqlClient

Public Class Form011a
    Private sqlConn As SqlConnection

    Private Sub Form011a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q315TableAdapter.Fill(Me.SZETAVDataSet.sp_Q315)
        Me.Sp_Q310TableAdapter.Fill(Me.SZETAVDataSet.sp_Q310)
        Me.Sp_Q279TableAdapter.Fill(Me.SZETAVDataSet.sp_Q279)
        Me.Sp_Q314TableAdapter.Fill(Me.SZETAVDataSet.sp_Q314)
        Me.Sp_Q297TableAdapter.Fill(Me.SZETAVDataSet.sp_Q297)
        Me.Sp_Q313TableAdapter.Fill(Me.SZETAVDataSet.sp_Q313)
        Me.Sp_Q289TableAdapter.Fill(Me.SZETAVDataSet.sp_Q289)
        Me.Sp_Q317TableAdapter.Fill(Me.SZETAVDataSet.sp_Q317)
        Me.Sp_Q312TableAdapter.Fill(Me.SZETAVDataSet.sp_Q312)

        If Me.Tag > 0 Then  'Tag fel volt toltve ertelmes indexszel, be kell tolteni azt a rekordot
            Try
                sqlConn = New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As New SqlCommand("sp_LoadObjAlt", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

                sqlConn.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        txtMEGNEV.Text = sqlReader.Item("MEGNEV").ToString
                        txtTIPUS.Text = sqlReader.Item("TIPUS").ToString
                        txtGYSZAM.Text = sqlReader.Item("GYSZAM").ToString
                        cmbGYARTO.SelectedValue = sqlReader.Item("GYARTO")
                        dtUZEMIDO.Value = sqlReader.Item("UZEMIDO")
                        dtHITIDO.Value = sqlReader.Item("HITIDO")
                        txtTELEPHSZ.Text = sqlReader.Item("TELEPHSZ").ToString
                        cmbKATEG.SelectedValue = sqlReader.Item("KATEG")
                        cmbVAROS.SelectedValue = sqlReader.Item("VAROS")
                        txtUTCA.Text = sqlReader.Item("UTCA").ToString
                        txtHSZ.Text = sqlReader.Item("HSZ").ToString
                        txtGYARTM.Text = sqlReader.Item("GYARTM").ToString
                        txtELHELYEZ.Text = sqlReader.Item("ELHELYEZ").ToString
                        cmbVESZO.SelectedValue = sqlReader.Item("VESZO")
                        cmbUZALL.SelectedValue = sqlReader.Item("UZALL")
                        cmbFKOD.SelectedValue = sqlReader.Item("FKOD")
                        cmbALAIR.SelectedValue = sqlReader.Item("ALAIR")
                        txtNEVLTELJ.Text = sqlReader.Item("NEVLTELJ").ToString
                        cmbNEVLTELJME.SelectedValue = sqlReader.Item("NEVLTELJME")
                        cmbFSZAM.SelectedValue = sqlReader.Item("FSZAM")
                        txtMEGJ.Text = sqlReader.Item("MEGJ").ToString
                    End While
                End If   'HasRows
                sqlReader.Close()
            Catch
            End Try
        Else
            'Uj rekord insert
            'Az objektum tipusat -1-gyel szorozva kaptuk meg a Form.Tag-ben
            txtOBJTIP.Text = (-1 * CInt(Me.Tag)).ToString("00")
            MsgBox(txtOBJTIP.Text)
            cmbALAIR.SelectedIndex = -1
            cmbFKOD.SelectedIndex = -1
            cmbFSZAM.SelectedIndex = -1
            cmbGYARTO.SelectedIndex = -1
            cmbKATEG.SelectedIndex = -1
            cmbNEVLTELJME.SelectedIndex = -1
            cmbUZALL.SelectedIndex = -1
            cmbVAROS.SelectedIndex = -1
            cmbVESZO.SelectedIndex = -1

        End If

    End Sub

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As New SqlCommand()

            With sqlComm
                .Connection = sqlConn
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("MEGNEV", txtMEGNEV.Text)
                .Parameters.AddWithValue("TIPUS", txtTIPUS.Text)
                .Parameters.AddWithValue("VAROS", cmbVAROS.SelectedValue)
                .Parameters.AddWithValue("UTCA", txtUTCA.Text)
                .Parameters.AddWithValue("HSZ", txtHSZ.Text)
                .Parameters.AddWithValue("ELHELYEZ", txtELHELYEZ.Text)
                .Parameters.AddWithValue("GYSZAM", txtGYSZAM.Text)
                .Parameters.AddWithValue("GYARTO", cmbGYARTO.SelectedValue)
                .Parameters.AddWithValue("UZALL", cmbUZALL.SelectedValue)
                'If dtUZEMIDO.Value.EndsWith(".") Then
                '    txtUZEMIDO.Text = txtUZEMIDO.Text.Remove(txtUZEMIDO.TextLength - 1)
                'End If
                .Parameters.AddWithValue("UZEMIDO", dtUZEMIDO.Value)
                'If txtHITIDO.Text.EndsWith(".") Then
                '    txtHITIDO.Text = txtHITIDO.Text.Remove(txtHITIDO.TextLength - 1)
                'End If
                .Parameters.AddWithValue("HITIDO", dtHITIDO.Value)
                .Parameters.AddWithValue("GYARTM", txtGYARTM.Text)
                .Parameters.AddWithValue("TELEPHSZ", txtTELEPHSZ.Text)
                .Parameters.AddWithValue("VESZO", cmbVESZO.SelectedValue)
                .Parameters.AddWithValue("FKOD", cmbFKOD.SelectedValue)
                .Parameters.AddWithValue("ALAIR", cmbALAIR.SelectedValue)
                If txtNEVLTELJ.Text <> "" Then
                    .Parameters.AddWithValue("NEVLTELJ", Double.Parse(txtNEVLTELJ.Text))
                End If
                .Parameters.AddWithValue("NEVLTELJME", cmbNEVLTELJME.SelectedValue)
                .Parameters.AddWithValue("KATEG", cmbKATEG.SelectedValue)
                .Parameters.AddWithValue("FSZAM", cmbFSZAM.SelectedValue)
                .Parameters.AddWithValue("MEGJ", txtMEGJ.Text)
                .Parameters.AddWithValue("AKTIV", "y")

                If Me.Tag < 0 Then 'Uj rekordot kell rogziteni
                    .CommandText = "sp_InsObjAlt"
                    .Parameters.AddWithValue("pOBJTIP", txtOBJTIP.Text)
                Else    'Meglevo rekord update
                    .CommandText = "sp_UpdObjAlt"
                    .Parameters.AddWithValue("pID", Me.Tag)
                End If
            End With
            sqlConn.Open()
            sqlComm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try

        Me.Close()
    End Sub

    Private Sub Form011a_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
    End Sub

End Class
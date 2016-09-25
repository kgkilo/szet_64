Imports System.Data.SqlClient

Public Class Form011a
    Private sqlConn As SqlConnection

    Private Sub Form011a_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                        txtUZEMIDO.Text = sqlReader.Item("UZEMIDO").ToString
                        txtHITIDO.Text = sqlReader.Item("HITIDO").ToString
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

        End If
    End Sub

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        sqlConn = New SqlConnection(GlobalVars.sConnStr)
        Dim sqlComm As New SqlCommand()

        Using (sqlConn)
            If Me.Tag = -1 Then 'Uj rekordot kell rogziteni
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = "sp_InsDolgozo"
                    .CommandType = CommandType.StoredProcedure

                    '.Parameters.AddWithValue("NEV", txtNEV.Text)
                    '.Parameters.AddWithValue("LOGIN", txtLOGIN.Text)
                    '.Parameters.AddWithValue("SZEREGYS", cmbSZEREGYS.SelectedValue) 'Integer.Parse(txtAge.Text))
                    '.Parameters.AddWithValue("BEOSZT", cmbBEOSZT.SelectedValue)
                    '.Parameters.AddWithValue("UFR", "n")
                    '.Parameters.AddWithValue("UFW", "n")
                    '.Parameters.AddWithValue("UER", "n")
                    '.Parameters.AddWithValue("UEW", "n")
                End With

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            Else    'Meglevo rekord update
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = "sp_UpdDolgozo"
                    .CommandType = CommandType.StoredProcedure

                    '.Parameters.AddWithValue("pID", Me.Tag)
                    '.Parameters.AddWithValue("NEV", txtNEV.Text)
                    '.Parameters.AddWithValue("LOGIN", txtLOGIN.Text)
                    '.Parameters.AddWithValue("SZEREGYS", cmbSZEREGYS.SelectedValue) 'Integer.Parse(txtAge.Text))
                    '.Parameters.AddWithValue("BEOSZT", cmbBEOSZT.SelectedValue)
                    '.Parameters.AddWithValue("UFR", "n")
                    '.Parameters.AddWithValue("UFW", "n")
                    '.Parameters.AddWithValue("UER", "n")
                    '.Parameters.AddWithValue("UEW", "n")
                End With

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End If
        End Using
        Me.Close()
    End Sub

    Private Sub Form011a_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
    End Sub

End Class
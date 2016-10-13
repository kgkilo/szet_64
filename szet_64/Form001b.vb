Imports System.Data.SqlClient

Public Class Form001b

    Private Sub Form001b_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)
        cmbOBJTIP.SelectedIndex = -1
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
        End If
    End Sub

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If cmbOBJTIP.SelectedIndex <> -1 And cmbOBJID.SelectedIndex <> -1 Then
            With Form001a
                .spcOBJTIP.Text = cmbOBJTIP.SelectedValue
                .txtOBJID.Text = cmbOBJID.SelectedValue
                .txtLAKAS.Text = Me.txtLAKAS.Text
            End With
            Me.Close()
        End If
    End Sub
End Class
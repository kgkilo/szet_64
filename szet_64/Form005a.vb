Imports System.Data.SqlClient

Public Class Form005a
    Private sqlConn As SqlConnection

    Private Sub Form005a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q304TableAdapter.Fill(Me.SZETAVDataSet.sp_Q304)
        Me.Sp_Q271TableAdapter.Fill(Me.SZETAVDataSet.sp_Q271)

        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)

            If Me.Tag <> -1 Then    'Tag fel volt toltve ertelmes indexszel, be kell tolteni azt a rekordot
                Dim sqlComm As SqlCommand = New SqlCommand("sp_LoadDolgozo", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

                sqlConn.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                With sqlReader
                    If .HasRows Then
                        While (.Read())
                            txtNEV.Text = .GetString(1)
                            Try
                                txtLOGIN.Text = .GetString(2)  'Ez lehet NULL is es ettol lehalna a form
                            Catch ex As Exception
                                txtLOGIN.Text = ""
                            End Try
                            cmbSZEREGYS.SelectedValue = .GetString(3)
                            cmbBEOSZT.SelectedValue = .GetString(4)
                        End While
                    End If  'HasRows
                    .Close()
                End With    'sqlReader
            Else    'Me.Tag
                'Uj rekord insert
                'Itt es most nem kell csinalni semmit...
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try
    End Sub

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As SqlCommand

            If Me.Tag = -1 Then 'Uj rekordot kell rogziteni
                sqlComm = New SqlCommand("sp_InsDolgozo", sqlConn)
                With sqlComm
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("NEV", txtNEV.Text)
                    .Parameters.AddWithValue("LOGIN", txtLOGIN.Text)
                    .Parameters.AddWithValue("SZEREGYS", cmbSZEREGYS.SelectedValue) 'Integer.Parse(txtAge.Text))
                    .Parameters.AddWithValue("BEOSZT", cmbBEOSZT.SelectedValue)
                    .Parameters.AddWithValue("UFR", "n")
                    .Parameters.AddWithValue("UFW", "n")
                    .Parameters.AddWithValue("UER", "n")
                    .Parameters.AddWithValue("UEW", "n")
                End With    'sqlComm

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            Else    'Meglevo rekord update
                sqlComm = New SqlCommand("sp_UpdDolgozo", sqlConn)
                With sqlComm
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("pID", Me.Tag)
                    .Parameters.AddWithValue("NEV", txtNEV.Text)
                    .Parameters.AddWithValue("LOGIN", txtLOGIN.Text)
                    .Parameters.AddWithValue("SZEREGYS", cmbSZEREGYS.SelectedValue) 'Integer.Parse(txtAge.Text))
                    .Parameters.AddWithValue("BEOSZT", cmbBEOSZT.SelectedValue)
                    .Parameters.AddWithValue("UFR", "n")
                    .Parameters.AddWithValue("UFW", "n")
                    .Parameters.AddWithValue("UER", "n")
                    .Parameters.AddWithValue("UEW", "n")
                End With    'sqlComm

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End If  'Me.Tag
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try
    End Sub

End Class
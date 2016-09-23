Imports System.Data.SqlClient

Public Class Form005a
    Private sqlConn As SqlConnection

    Private Sub Form005a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q304TableAdapter.Fill(Me.SZETAVDataSet.sp_Q304)
        Me.Sp_Q271TableAdapter.Fill(Me.SZETAVDataSet.sp_Q271)

        sqlConn = New SqlConnection(GlobalVars.sConnStr)

        If Me.Tag <> -1 Then    'Tag fel volt toltve ertelmes indexszel, be kell tolteni azt a rekordot
            Using (sqlConn)
                Dim sqlComm As SqlCommand = New SqlCommand("sp_LoadDolgozo", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

                sqlConn.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        txtNEV.Text = sqlReader.GetString(1)
                        Try
                            txtLOGIN.Text = sqlReader.GetString(2)  'Ez lehet NULL is es ettol lehalna a form
                        Catch ex As Exception
                            txtLOGIN.Text = ""
                        End Try
                        cmbSZEREGYS.SelectedValue = sqlReader.GetString(3)
                        cmbBEOSZT.SelectedValue = sqlReader.GetString(4)
                    End While
                End If
                sqlReader.Close()
            End Using
        Else
            'Uj rekord insert
            'Itt es most nem kell csinalni semmit...
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

                    .Parameters.AddWithValue("NEV", txtNEV.Text)
                    .Parameters.AddWithValue("LOGIN", txtLOGIN.Text)
                    .Parameters.AddWithValue("SZEREGYS", cmbSZEREGYS.SelectedValue) 'Integer.Parse(txtAge.Text))
                    .Parameters.AddWithValue("BEOSZT", cmbBEOSZT.SelectedValue)
                    .Parameters.AddWithValue("UFR", "n")
                    .Parameters.AddWithValue("UFW", "n")
                    .Parameters.AddWithValue("UER", "n")
                    .Parameters.AddWithValue("UEW", "n")
                End With

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            Else    'Meglevo rekord update
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = "sp_UpdDolgozo"
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
                End With

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End If
        End Using
        Me.Close()
    End Sub
End Class
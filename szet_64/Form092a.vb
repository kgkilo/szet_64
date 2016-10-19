Imports System.Data.SqlClient

Public Class Form092a
    Private sqlConn As SqlConnection

    Private Sub Form092a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)

            If Me.Tag <> -1 Then    'Tag fel volt toltve ertelmes indexszel, be kell tolteni azt a rekordot
                Dim sqlComm As SqlCommand = New SqlCommand("sp_LoadKodszot", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

                sqlConn.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                With sqlReader
                    If .HasRows Then
                        While (.Read())
                            txtERTEK.Text = .GetString(1)
                            Try
                                txtNEV.Text = .GetString(2)  'Ez lehet NULL is es ettol lehalna a form
                            Catch ex As Exception
                                txtNEV.Text = ""
                            End Try
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
                sqlComm = New SqlCommand("sp_InsKodszot", sqlConn)
                With sqlComm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("KODTIP", txtKODTIP.text)
                    .Parameters.AddWithValue("KODERT", txtERTEK.Text)
                    .Parameters.AddWithValue("KODENEV", txtNEV.Text)
                End With    'sqlComm

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            Else    'Meglevo rekord update
                sqlComm = New SqlCommand("sp_UpdKodszot", sqlConn)
                With sqlComm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("KODTIP", txtKODTIP.text)
                    .Parameters.AddWithValue("KODERT", txtERTEK.Text)
                    .Parameters.AddWithValue("KODENEV", txtNEV.Text)
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
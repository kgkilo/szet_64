Imports System.Data.SqlClient

Public Class Form001a
    Public sConnStr As String
    Private sqlConn As SqlConnection

    Private Function FillCombobox()
        Dim ret As Boolean = False
        Try
            Dim dbadp As New SqlDataAdapter("sp_Q271", sConnStr)
            Dim dTable As New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbSZEREGYS
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With
            With Me.cmbMUNSZ
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q334", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbMFDOLG
                .DisplayMember = "NEV"
                .ValueMember = "ID"
                .DataSource = dTable
            End With
            With Me.cmbMKAP
                .DisplayMember = "NEV"
                .ValueMember = "ID"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q291", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbSZOLGJELL
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q310a", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbFSZAM
                .DisplayMember = "FSZNEV"
                .ValueMember = "FSZAM"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q293", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbTIPUSH
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q298", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbMUVEL
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q306", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbMUNVEGZ
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q309", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbSZOLTIP
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With

            dbadp = New SqlDataAdapter("sp_Q300", sConnStr)
            dTable = New DataTable
            With dbadp
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(dTable)
                .Dispose()
            End With
            With Me.cmbKARBTIP
                .DisplayMember = "KODENEV"
                .ValueMember = "KODERT"
                .DataSource = dTable
            End With
            ret = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ret
    End Function

    Private Sub Form001a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        If Me.Tag = -1 Then
            Me.Text = "Form001a - Új munkalap"
        Else
            Me.Text = "Form001a - " + Me.Tag.ToString + " munkalap módosítása"
        End If

        'Comboboxok feltoltese
        Me.FillCombobox()

        Cursor.Current = Cursors.Default
    End Sub
End Class
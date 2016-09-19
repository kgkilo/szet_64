Imports System.Data.SqlClient

Public Class Form001a
    Public sConnStr As String
    Private sqlConn As SqlConnection

    Private Sub Form001a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Tag = -1 Then
            Me.Text = "Form001a - Új munkalap"
        Else
            Me.Text = "Form001a - " + Me.Tag.ToString + " munkalap módosítása"
        End If
    End Sub
End Class
Imports System.Data.SqlClient

Public Class FormStart
    Private sConnStr As String

    Private Sub cmdMunkalap_Click(sender As Object, e As EventArgs) Handles cmdMunkalap.Click
        Form001.sConnStr = Me.sConnStr
        Form001.Show(Me)
    End Sub

    Private Sub cmdJegyz_Click(sender As Object, e As EventArgs) Handles cmdJegyz.Click
        'Form003.Show(Me)
    End Sub

    Private Sub cmdRAKTAR_Click(sender As Object, e As EventArgs) Handles cmdRAKTAR.Click
        'Form004.Show(Me)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FormStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read connection string from the registry
        Dim keyValue As Object
        keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Formel\SZET_64\Settings", "ConnectionName", "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")
        If (keyValue) Then
            sConnStr = keyValue.ToString
        Else
            MsgBox("bing")
            sConnStr = "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;"
        End If
        'My.Settings.Item("ConnectionString") = keyValue
        'SZETAVDataSet...

    End Sub
End Class

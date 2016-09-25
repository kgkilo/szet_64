Imports System.Data.SqlClient

Module GlobalVars
    Public iWorkMode As Integer = 0

    Public Const NORMAL = 0
    Public Const DISZPECSER = 1
    Public Const LABOR = 2
    Public Const MLAP = 3
    Public Const VISSZAIR = 4

    Public sConnStr As String
End Module

Public Class FormStart
    Private Sub cmdMunkalap_Click(sender As Object, e As EventArgs) Handles cmdMunkalap.Click
        Form001.Show(Me)
    End Sub

    Private Sub cmdJegyz_Click(sender As Object, e As EventArgs) Handles cmdJegyz.Click
        'Form003.Show(Me)
    End Sub

    Private Sub cmdDOLGOZO_Click(sender As Object, e As EventArgs) Handles cmdDOLGOZO.Click
        Form005.Show(Me)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FormStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read connection string from the registry
        GlobalVars.sConnStr = "DRIVER={SQL Server};Server=NTSERVER;uid=sa;pwd=;database=SZETAV"
        Try
            Dim keyValue As Object
            'Ez valamiert nem mukodik, pedig a connection az gep szintu beallitas kellene legyen, nem user-szintu.
            'Esetleg valami jogosultsag???
            'keyValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Formel\SZET_64", "ConnectionString", "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")

            'Ez mukodik, de user-specifikus :(
            keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Formel\SZET_64", _
                                                     "ConnectionString", _
                                                     "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")

            GlobalVars.sConnStr = If(keyValue.ToString, "")
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try

        My.Settings.Item("SZETAVConnectionString") = GlobalVars.sConnStr   'Ez allitja be az ossze bound DataSet eleresi utjat!!!

    End Sub

    Private Sub cmdBERENDEZES_Click(sender As Object, e As EventArgs) Handles cmdBERENDEZES.Click
        Form011.Show(Me)
    End Sub
End Class

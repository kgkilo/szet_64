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

    Private Sub cmdDOLGOZO_Click(sender As Object, e As EventArgs) Handles cmdDOLGOZO.Click
        Form005.sConnStr = Me.sConnStr
        Form005.Show(Me)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FormStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read connection string from the registry
        sConnStr = "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;"
        Try
            Dim keyValue As Object
            'Ez valamiert nem mukodik, pedig a connection az gep szintu beallitas kellene legyen, nem user-szintu.
            'Esetleg valami jogosultsag???
            'keyValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Formel\SZET_64", "ConnectionString", "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")

            'Ez mukodik, de user-specifikus :(
            keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Formel\SZET_64", _
                                                     "ConnectionString", _
                                                     "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName=C:\Users\kilo\Documents\SZETAV.mdf;")

            sConnStr = If(keyValue.ToString, "")
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try

        My.Settings.Item("SZETAVConnectionString") = sConnStr   'Ez allitja be az ossze bound DataSet eleresi utjat!!!

    End Sub
End Class

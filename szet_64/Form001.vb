Public Class Form001

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub cmdEXIT_Click(sender As Object, e As EventArgs) Handles cmdEXIT.Click, cmdVISSZAIR.Click, cmdUJ.Click, cmdMODOSIT.Click, cmdFRISSIT.Click, cmdMASOL.Click, cmdLIST.Click, cmdCSOPLIST.Click
        Me.Close()
    End Sub

    Private Sub Form001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor

        datDATUMIG.Value = Now()
        datDATUMTOL.Value = DateAdd("m", -1, Now())
        datMUNDATTOL.Value = Now()
        datMUNDATIG.Value=Now()

        Cursor.Current = Cursors.Default
    End Sub
End Class
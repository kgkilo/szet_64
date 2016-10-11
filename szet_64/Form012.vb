Public Class Form012

    Private Sub Form012_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SZETAVDataSet.sp_Q296' table. You can move, or remove it, as needed.
        Me.Sp_Q296TableAdapter.Fill(Me.SZETAVDataSet.sp_Q296)

    End Sub
End Class
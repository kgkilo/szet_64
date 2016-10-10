Public Class Form011b

    Private Sub Form011b_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form011b_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
    End Sub

End Class
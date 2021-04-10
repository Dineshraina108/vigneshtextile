Public Class OrderRev
    Private Sub lblormain_Click(sender As Object, e As EventArgs) Handles lblormain.Click

    End Sub

    Private Sub txtordid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtordid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbotype.Focus()

        End If
    End Sub

    Private Sub cbotype_KeyDown(sender As Object, e As KeyEventArgs) Handles cbotype.KeyDown

    End Sub

    Private Sub txtgoods_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgoods.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtordid.Focus()
        End If
    End Sub
End Class
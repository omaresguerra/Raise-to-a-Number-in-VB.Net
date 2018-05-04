Public Class frmRaise


    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you really want to exit?", _
                          "Close Form", MessageBoxButtons.YesNo, _
                          MessageBoxIcon.Question) = _
                          Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNum.Text = ""
        txtNum.Focus()
        lstAnswer.Items.Clear()

    End Sub

    Private Sub btnEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluate.Click
        Dim intCount As Integer
        intCount = Val(txtNum.Text)

        For count As Integer = 1 To intCount
            lstAnswer.Items.Add("2 ^ " & count.ToString & " = " & 2 ^ count)
        Next

    End Sub
End Class

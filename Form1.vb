Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToFoodmenuButton_Click(sender As Object, e As EventArgs) Handles ToFoodmenuButton.Click
        FoodmenuForm.Show()
        Me.Hide()
    End Sub
End Class

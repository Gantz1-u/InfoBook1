Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub Bt_LogoutHistory_Click(sender As Object, e As EventArgs) Handles Bt_LogoutHistory.Click
        PNL_LogOut.Visible = True

    End Sub

    Private Sub Bt_YesHistory_Click(sender As Object, e As EventArgs) Handles Bt_YesHistory.Click
        Dim Login As New LoginForm()
        Login.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_History1_Click(sender As Object, e As EventArgs) Handles Bt_History1.Click
        Dim history As New History()
        history.Show()

        Me.Hide()


    End Sub

    Private Sub Bt_ManageHistory_Click(sender As Object, e As EventArgs) Handles Bt_ManageHistory.Click
        Dim Manageform As New Manage()
        Manageform.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_ReturnHistory_Click(sender As Object, e As EventArgs) Handles Bt_ReturnHistory.Click
        Dim returnform As New ReturnForm()
        returnform.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_BooksHistory_Click(sender As Object, e As EventArgs) Handles Bt_BooksHistory.Click
        Dim Booksadmin As New BooksAdmin1()
        Booksadmin.Show()

        Me.Hide()

    End Sub
End Class
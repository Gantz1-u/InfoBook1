Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.AutoScaleMode = AutoScaleMode.Dpi

    End Sub

    Private Sub Bt_LogoutHistory_Click(sender As Object, e As EventArgs) Handles Bt_LogoutHistory.Click
        PNL_LogOut.Visible = True

    End Sub

    Private Sub Bt_YesHistory_Click(sender As Object, e As EventArgs) Handles Bt_YesHistory.Click
        Dim Login As New LoginForm()
        Login.Show()

        Me.Close()

    End Sub

    Private Sub Bt_History1_Click(sender As Object, e As EventArgs) Handles Bt_History1.Click
        Dim history As New History()
        history.Show()

        Me.Close()


    End Sub

    Private Sub Bt_ManageHistory_Click(sender As Object, e As EventArgs) Handles Bt_ManageHistory.Click
        Dim Manageform As New Manage()
        Manageform.Show()

        Me.Close()

    End Sub

    Private Sub Bt_ReturnHistory_Click(sender As Object, e As EventArgs) Handles Bt_ReturnHistory.Click
        Dim returnform As New ReturnForm()
        returnform.Show()

        Me.Close()

    End Sub

    Private Sub Bt_BooksHistory_Click(sender As Object, e As EventArgs) Handles Bt_BooksHistory.Click
        Dim Booksadmin As New BooksAdmin1()
        Booksadmin.Show()

        Me.Close()

    End Sub
End Class
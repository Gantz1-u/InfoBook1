Public Class BookUnavailable
    Private Sub BookUnavailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub Bt_BackBU_Click(sender As Object, e As EventArgs) Handles Bt_BackBU.Click
        Dim BookAdminForm As New BooksAdmin1()
        BookAdminForm.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_ReturnBU_Click(sender As Object, e As EventArgs) Handles Bt_ReturnBU.Click
        Dim returnform As New ReturnForm()
        returnform.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_ManageBU_Click(sender As Object, e As EventArgs) Handles Bt_ManageBU.Click
        Dim manageform As New Manage()
        manageform.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_HistoryBU_Click(sender As Object, e As EventArgs) Handles Bt_HistoryBU.Click
        Dim history As New History()
        history.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_BookBU_Click(sender As Object, e As EventArgs) Handles Bt_BookBU.Click

    End Sub
End Class
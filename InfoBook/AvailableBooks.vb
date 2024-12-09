Public Class AvailableBook
    Private Sub AvailableBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PNL_TermsNCond.Visible = True

    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        PNL_TermsNCond.Visible = False

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        PNL_BorrowDetails.Visible = True

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim BooksAdminForm As New BooksAdmin1()
        BooksAdminForm.Show()

        Me.Hide()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Borrowed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Bt_BookAB_Click(sender As Object, e As EventArgs) Handles Bt_BookAB.Click
        Dim BooksAdmin As New BooksAdmin1()
        BooksAdmin.Show()

        Me.Hide()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim returnform As New ReturnForm()
        returnform.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_ManageAB_Click(sender As Object, e As EventArgs) Handles Bt_ManageAB.Click
        Dim manageform As New Manage()
        manageform.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_HistoryAB_Click(sender As Object, e As EventArgs) Handles Bt_HistoryAB.Click
        Dim history As New History()
        history.Show()

        Me.Hide()


    End Sub
End Class
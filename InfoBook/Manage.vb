Public Class Manage
    Private Sub Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.AutoScaleMode = AutoScaleMode.Dpi
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim BooksAdminForm As New BooksAdmin1()
        BooksAdminForm.Show()

        Me.Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim returnform As New ReturnForm()
        returnform.Show()

        Me.Close()

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim HistoryForm As New History()
        HistoryForm.Show()

        Me.Close()

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        PNL_Reports.Visible = True

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        PNL_AddBook.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PNL_ReportBookList.Visible = True
        PNL_Reports.Visible = False

    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        PNL_ReportBookList.Visible = False
        PNL_Reports.Visible = True

    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        PNL_BorrowedBookList.Visible = True
        PNL_Reports.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PNL_BorrowedBooks.Visible = True
        PNL_BorrowedBookList.Visible = False
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        PNL_Reports.Visible = True
        PNL_BorrowedBookList.Visible = False
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) Handles Guna2Button15.Click
        PNL_BorrowedBookList.Visible = True
        PNL_BorrowedBooks.Visible = False
    End Sub

    Private Sub Guna2Button16_Click(sender As Object, e As EventArgs) Handles Guna2Button16.Click
        PNL_BorrowersInfo.Visible = True
        PNL_BorrowedBooks.Visible = False
    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs) Handles Guna2Button17.Click
        PNL_BorrowedBookList.Visible = True
        PNL_BorrowersInfo.Visible = False
    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs) Handles Guna2Button20.Click
        PNL_AddBook.Visible = False
        PNL_NameOfBook.Visible = True

    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs) Handles Guna2Button18.Click
        PNL_AddBook.Visible = True
    End Sub

    Private Sub Guna2Button19_Click(sender As Object, e As EventArgs) Handles Guna2Button19.Click
        PNL_RemoveBook.Visible = True
        PNL_AddBook.Visible = False

    End Sub

    Private Sub Guna2Button22_Click(sender As Object, e As EventArgs) Handles Guna2Button22.Click
        PNL_AddBook.Visible = True
        PNL_NameOfBook.Visible = False
    End Sub

    Private Sub Guna2Button21_Click(sender As Object, e As EventArgs) Handles Guna2Button21.Click
        Dim result As DialogResult = MessageBox.Show("Done?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Book Added to the Library", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Guna2Button23_Click(sender As Object, e As EventArgs) Handles Guna2Button23.Click
        PNL_AddBook.Visible = True
        PNL_RemoveBook.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PNL_RemoveBook.Visible = False
        PNL_RemoveBookDetails.Visible = True

    End Sub

    Private Sub Guna2Button25_Click(sender As Object, e As EventArgs) Handles Guna2Button25.Click
        PNL_RemoveBook.Visible = True
        PNL_RemoveBookDetails.Visible = False

    End Sub

    Private Sub Guna2Button26_Click(sender As Object, e As EventArgs) Handles Guna2Button26.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Book Removed from the Library", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
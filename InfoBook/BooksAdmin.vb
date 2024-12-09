Public Class BooksAdmin1
    Private Sub BooksAdmin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub
    Private Sub Bt_NextP1BA_Click(sender As Object, e As EventArgs) Handles Bt_NextP1BA.Click
        PNL_2ndpageBA.Visible = True

    End Sub

    Private Sub Bt_BackBAP2_Click(sender As Object, e As EventArgs) Handles Bt_BackBAP2.Click
        PNL_2ndpageBA.Visible = False

        Me.Show()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PNL_2ndpageBA.Visible = False

        Dim AvailablebookForm As New AvailableBook()
        AvailablebookForm.Show()

        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PNL_2ndpageBA.Visible = False

        Dim UnavailablebookForm As New AvailableBook()
        UnavailablebookForm.Show()

        Me.Hide()


    End Sub

    Private Sub Bt_Return_Click(sender As Object, e As EventArgs) Handles Bt_Return.Click
        Dim Returnform As New ReturnForm()
        Returnform.Show()

        Me.Hide()


    End Sub

    Private Sub Bt_Manage_Click(sender As Object, e As EventArgs) Handles Bt_Manage.Click
        Dim manageform As New Manage()
        manageform.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_History_Click(sender As Object, e As EventArgs) Handles Bt_History.Click
        Dim history As New History()
        history.Show()

        Me.Hide()

    End Sub

    Private Sub Bt_Book_Click(sender As Object, e As EventArgs) Handles Bt_Book.Click

    End Sub
End Class
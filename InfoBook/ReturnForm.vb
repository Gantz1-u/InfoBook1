Public Class ReturnForm
    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.AutoScaleMode = AutoScaleMode.Dpi

    End Sub

    Private Sub Bt_NextReturn_Click(sender As Object, e As EventArgs) Handles Bt_NextReturn.Click
        PNL_Return2ndPage.Visible = True
    End Sub

    Private Sub Bt_BackPage2_Click(sender As Object, e As EventArgs) Handles Bt_BackPage2.Click
        PNL_Return2ndPage.Visible = False
        Me.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PNL_BookDescription.Visible = True

    End Sub

    Private Sub Bt_Return2_Click(sender As Object, e As EventArgs) Handles Bt_Return2.Click
        PNL_ReturnDetails.Visible = True
    End Sub

    Private Sub Bt_BackReturn1_Click(sender As Object, e As EventArgs) Handles Bt_BackReturn1.Click
        PNL_BookDescription.Visible = False
        Me.Show()

    End Sub

    Private Sub Bt_BackReturn_Click(sender As Object, e As EventArgs) Handles Bt_BackReturn.Click
        PNL_ReturnDetails.Visible = False
        Me.Show()

    End Sub

    Private Sub Bt_ManageReturn_Click(sender As Object, e As EventArgs) Handles Bt_ManageReturn.Click
        Dim ManageForm As New Manage()
        ManageForm.Show()

        Me.Close()

    End Sub

    Private Sub Bt_BooksReturn_Click(sender As Object, e As EventArgs) Handles Bt_BooksReturn.Click
        Dim Booksadmin As New BooksAdmin1()
        Booksadmin.Show()

        Me.Close()

    End Sub

    Private Sub Bt_HistoryReturn_Click(sender As Object, e As EventArgs) Handles Bt_HistoryReturn.Click
        Dim history As New History()
        history.Show()

        Me.Close()

    End Sub
End Class
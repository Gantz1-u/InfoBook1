Public Class BooksAdmin1
    Private Sub BooksAdmin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.AutoScaleMode = AutoScaleMode.Dpi
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

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PNL_2ndpageBA.Visible = False

        Dim UnavailablebookForm As New AvailableBook()
        UnavailablebookForm.Show()

        Me.Close()


    End Sub

    Private Sub Bt_Return_Click(sender As Object, e As EventArgs) Handles Bt_Return.Click
        Dim Returnform As New ReturnForm()
        Returnform.Show()

        Me.Close()


    End Sub

    Private Sub Bt_Manage_Click(sender As Object, e As EventArgs) Handles Bt_Manage.Click
        Dim manageform As New Manage()
        manageform.Show()

        Me.Close()

    End Sub

    Private Sub Bt_History_Click(sender As Object, e As EventArgs) Handles Bt_History.Click
        Dim history As New History()
        history.Show()

        Me.Close()

    End Sub
End Class
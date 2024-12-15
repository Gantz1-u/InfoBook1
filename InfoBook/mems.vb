Public Class mems
    Private books1 As books_int
    Private bookDetails As BookDetails
    Public Event Swap As EventHandler
    Private Sub mems_int_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Panel3.Visible = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If books1 Is Nothing OrElse books1.IsDisposed Then
            books1 = New books_int

            books1.MdiParent = Me
            books1.FormBorderStyle = FormBorderStyle.None
            books1.Dock = DockStyle.Fill

            books1.Show()


            AddHandler books1.Swap, AddressOf SwitchForm
        Else
            books1.BringToFront()
        End If
    End Sub

    Private Sub SwitchForm(sender As Object, e As EventArgs)
        If books1 IsNot Nothing AndAlso Not books1.IsDisposed Then
            books1.Close()
        End If

        bookDetails = New BookDetails()

        bookDetails.MdiParent = Me
        bookDetails.FormBorderStyle = FormBorderStyle.None
        bookDetails.Dock = DockStyle.Fill

        bookDetails.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Panel3.Visible = True
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        LoginForm.Show()

    End Sub
End Class


Imports Azure.Core.HttpHeader

Public Class BooksAdmin1
    Private books1 As books_int
    Private bookDetails As BookDetails
    Public Event Swap As EventHandler
    Private Return1 As ReturnForm
    Public form3 As New BookDetails()
    Private logut1 As logut

    Private Sub BooksAdmin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub


    Private Sub Bt_Book_Click(sender As Object, e As EventArgs) Handles Bt_Book.Click


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

    Private Sub Bt_logout_Click(sender As Object, e As EventArgs) Handles Bt_logout.Click

        If logut1 Is Nothing OrElse logut1.IsDisposed Then
            logut1 = New logut()

            logut1.MdiParent = Me
            logut1.FormBorderStyle = FormBorderStyle.None
            logut1.Dock = DockStyle.Fill

            logut1.Show()
        Else
            logut1.BringToFront()
        End If
    End Sub

    Private Sub Bt_Return_Click(sender As Object, e As EventArgs)

        Dim btn_return = "RETURN"
        Dim bookDetailsForm = New BookDetails



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

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        Hide()
        LoginForm.Show()

    End Sub
End Class
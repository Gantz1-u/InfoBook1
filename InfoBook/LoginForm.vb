Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.AutoScaleMode = AutoScaleMode.Dpi

    End Sub

    Private Sub Bt_Login_Click(sender As Object, e As EventArgs) Handles Bt_Login.Click
        Dim username As String = "user"
        Dim password As String = "password"

        Dim EnteredUsername As String = Guna2TextBox1.Text
        Dim EnteredPassword As String = Guna2TextBox2.Text

        If EnteredUsername = username AndAlso EnteredPassword = password Then
            MessageBox.Show("Log in Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim BookAdminForm As New BooksAdmin1()
            BookAdminForm.Show()

            Me.Close()

        Else
            MessageBox.Show("Log in Failed. Check your Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim SignUpForm As New SignUp()
        SignUpForm.Show()

        Me.Close()
    End Sub
End Class
Public Class SignUp
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = "user"
        Dim password As String = "password"

        Dim EnteredUsername As String = Guna2TextBox1.Text
        Dim EnteredPassword As String = Guna2TextBox2.Text

        If EnteredUsername = username AndAlso EnteredPassword = password Then
            MessageBox.Show("Sign in Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim Login As New LoginForm()
            Login.Show()

            Me.Hide()

        Else
            MessageBox.Show("Sign in Failed. Please fill out the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub linkReturn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkReturn.LinkClicked
        Dim login As New LoginForm()
        login.Show()

        Me.Hide()

    End Sub
End Class
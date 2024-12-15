Imports Microsoft.Data.SqlClient

Public Class LoginForm
    Private sqlConnect1 As SqlConnection

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        sqlConnect1 = New SqlConnection("Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Accounts;TrustServerCertificate=True")

        Dim Sql As New sqlConnect

    End Sub

    Private Sub Bt_Login_Click(sender As Object, e As EventArgs) Handles Bt_Login.Click
        Dim EnteredUsername As String = Guna2TextBox1.Text
        Dim EnteredPassword As String = Guna2TextBox2.Text

        If String.IsNullOrWhiteSpace(EnteredUsername) OrElse String.IsNullOrWhiteSpace(EnteredPassword) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim queryAdmin As String = "SELECT COUNT(*) FROM dbo.tbl_Admin WHERE col_username = @Username AND col_password = @Password"
        Dim queryMember As String = "SELECT COUNT(*) FROM dbo.tbl_member WHERE col_Username = @MUsername AND col_password = @MPassword"

        Dim resultAdmin As Integer
        Dim resultMember As Integer

        Using sqlCommand As New SqlCommand()
            Try
                If sqlConnect1.State = ConnectionState.Closed Then
                    sqlConnect1.Open()
                End If

                sqlCommand.Connection = sqlConnect1
                sqlCommand.CommandText = queryAdmin
                sqlCommand.Parameters.Clear()
                sqlCommand.Parameters.AddWithValue("@Username", EnteredUsername)
                sqlCommand.Parameters.AddWithValue("@Password", EnteredPassword)

                resultAdmin = Convert.ToInt32(sqlCommand.ExecuteScalar())

                sqlCommand.CommandText = queryMember
                sqlCommand.Parameters.Clear()
                sqlCommand.Parameters.AddWithValue("@MUsername", EnteredUsername)
                sqlCommand.Parameters.AddWithValue("@MPassword", EnteredPassword)

                resultMember = Convert.ToInt32(sqlCommand.ExecuteScalar())

                If resultAdmin > 0 Then
                    MessageBox.Show("Login successful as Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim BookAdminForm As New BooksAdmin1()
                    BookAdminForm.ShowDialog()
                    Me.Hide()

                ElseIf resultMember > 0 Then
                    MessageBox.Show("Login successful as Member!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim BookMemForm As New mems()
                    BookMemForm.ShowDialog()
                    Me.Hide()

                Else
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                If sqlConnect1.State = ConnectionState.Open Then
                    sqlConnect1.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        SignUp.Show()

    End Sub
End Class
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class SignUp

    Private sqlConnect1 As SqlConnection

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConnect1 = New SqlConnection("Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Accounts;TrustServerCertificate=True")

        Dim Sql As New sqlConnect
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub Bt_SignIn_Click(sender As Object, e As EventArgs) Handles Bt_SignIn.Click

        Dim Lname As String = Guna2TextBox1.Text.Trim()
        Dim Fname As String = Guna2TextBox2.Text.Trim()
        Dim Mname As String = Guna2TextBox3.Text.Trim()
        Dim email As String = Guna2TextBox4.Text.Trim()
        Dim Address As String = Guna2TextBox5.Text.Trim()
        Dim Username As String = Guna2TextBox6.Text.Trim()
        Dim Password As String = Guna2TextBox7.Text.Trim()


        If String.IsNullOrEmpty(Fname) OrElse
       String.IsNullOrEmpty(Lname) OrElse
       String.IsNullOrEmpty(Mname) OrElse
       String.IsNullOrEmpty(email) OrElse
       String.IsNullOrEmpty(Address) OrElse
        String.IsNullOrEmpty(Username) OrElse
        String.IsNullOrEmpty(Password) Then



            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.tbl_member WHERE col_Username = @Username"
        Using checkCommand As New SqlCommand(checkQuery, sqlConnect1)
            checkCommand.Parameters.AddWithValue("@Username", Username)

            Try
                If sqlConnect1.State = ConnectionState.Closed Then
                    sqlConnect1.Open()
                End If

                Dim userCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If userCount > 0 Then
                    MessageBox.Show("Username already exists. Try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

            Catch ex As Exception
                MessageBox.Show($"An error occurred while checking the username: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Finally
                If sqlConnect1.State = ConnectionState.Open Then
                    sqlConnect1.Close()
                End If
            End Try
        End Using

        Dim query As String = "INSERT INTO dbo.tbl_member (col_LastName, col_FirstName, col_MiddleName, col_email, col_Address, col_Username, col_password) " &
                          "VALUES (@Lname, @Fname, @Mname, @email, @Address, @Username, @Password)"

        Using command As New SqlCommand(query, sqlConnect1)

            command.Parameters.AddWithValue("@Lname", Lname)
            command.Parameters.AddWithValue("@fname", Fname)
            command.Parameters.AddWithValue("@Mname", Mname)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@Address", Address)
            command.Parameters.AddWithValue("@Username", Username)
            command.Parameters.AddWithValue("@Password", Password)


            Try
                If sqlConnect1.State = ConnectionState.Closed Then
                    sqlConnect1.Open()
                End If

                command.ExecuteNonQuery()

                MessageBox.Show("Sign up Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                LoginForm.Show()


            Catch ex As Exception
                MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If sqlConnect1.State = ConnectionState.Open Then
                    sqlConnect1.Close()
                End If
            End Try
        End Using









        Me.Hide()
        LoginForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Guna2TextBox7.PasswordChar = ChrW(0) Then
            Guna2TextBox7.PasswordChar = "•"c
        Else
            Guna2TextBox7.PasswordChar = ChrW(0)
        End If
    End Sub
End Class
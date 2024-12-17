Imports Microsoft.Data.SqlClient

Public Class ReturnForm

    Private sqlConnect1 As SqlConnection

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        sqlConnect1 = New SqlConnection("Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True")

        Dim Sql As New sqlConnect
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim borrowerName As String = Guna2TextBox1.Text.Trim()
        Dim bookName As String = Guna2TextBox2.Text.Trim()
        Dim issue As String = Guna2TextBox5.Text.Trim()

        If String.IsNullOrEmpty(borrowerName) OrElse
           String.IsNullOrEmpty(bookName) OrElse
           String.IsNullOrEmpty(issue) Then

            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO dbo.tbl_return (col_returnerName, col_bookName, col_Issue)" & " VALUES (@BorrowerName, @BookName, @Issue)"

        Using command As New SqlCommand(query, sqlConnect1)
            command.Parameters.AddWithValue("@BorrowerName", borrowerName)
            command.Parameters.AddWithValue("@BookName", bookName)
            command.Parameters.AddWithValue("@Issue", issue)

            Try
                If sqlConnect1.State = ConnectionState.Closed Then
                    sqlConnect1.Open()
                End If

                command.ExecuteNonQuery()

                MessageBox.Show("Returned Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If sqlConnect1.State = ConnectionState.Open Then
                    sqlConnect1.Close()
                End If
            End Try
        End Using
    End Sub

End Class
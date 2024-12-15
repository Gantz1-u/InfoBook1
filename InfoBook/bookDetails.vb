Imports Microsoft.Data.SqlClient


Public Class BookDetails
    Private BORROW As Borrow
    Private sqlConnect1 As SqlConnection
    Private isBooksVisible As Boolean = False

    Public Sub UpdateText(Bname As String, bauthor As String, pDate As String, desc As String)
        Label1.Text = Bname
        Label2.Text = bauthor
        Label3.Text = pDate
        RichTextBox1.Text = desc

    End Sub
    Public Sub UpdateText1(Bname1 As String, bauthor1 As String, pDate1 As String, desc1 As String)
        Label1.Text = Bname1
        Label2.Text = bauthor1
        Label3.Text = pDate1
        RichTextBox1.Text = desc1
    End Sub
    Public Sub UpdateText2(Bname2 As String, bauthor2 As String, pDate2 As String, desc2 As String)
        Label1.Text = Bname2
        Label1.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Label2.Text = bauthor2
        Label3.Text = pDate2
        RichTextBox1.Text = desc2
    End Sub
    Public Sub UpdateText3(Bname3 As String, bauthor3 As String, pDate3 As String, desc3 As String)
        Label1.Text = Bname3
        Label2.Text = bauthor3
        Label3.Text = pDate3
        RichTextBox1.Text = desc3
    End Sub
    Public Sub UpdateText4(Bname4 As String, bauthor4 As String, pDate4 As String, desc4 As String)
        Label1.Text = Bname4
        Label2.Text = bauthor4
        Label3.Text = pDate4
        RichTextBox1.Text = desc4
    End Sub

    Public Sub UpdateText5(Bname5 As String, bauthor5 As String, pDate5 As String, desc5 As String)
        Label1.Text = Bname5
        Label2.Text = bauthor5
        Label3.Text = pDate5
        RichTextBox1.Text = desc5
    End Sub





    Private Sub BooksMemberInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        sqlConnect1 = New SqlConnection("Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True")

        Dim Sql As New sqlConnect

    End Sub


    Private Sub Bt_LogoutMember_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Btn_YesLogout_Click(sender As Object, e As EventArgs)
        Dim Login As New LoginForm
        Login.Show()

        Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bt_BackMember_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        PNL_BorrowDetails.Visible = True


    End Sub










    Private Sub Bt_BackMember1_Click(sender As Object, e As EventArgs) Handles Bt_BackMember1.Click
        PNL_BorrowDetails.Visible = False

    End Sub

    Private Sub Bt_BorrowMember_Click(sender As Object, e As EventArgs) Handles Bt_BorrowMember.Click
        Dim borrowerName As String = Guna2TextBox2.Text.Trim()
        Dim bookName As String = Guna2TextBox3.Text.Trim()
        Dim email As String = Guna2TextBox4.Text.Trim()
        Dim course As String = Guna2TextBox6.Text.Trim()
        Dim studentNumber As String = Guna2TextBox7.Text.Trim()

        If String.IsNullOrEmpty(borrowerName) OrElse
       String.IsNullOrEmpty(bookName) OrElse
       String.IsNullOrEmpty(email) OrElse
       String.IsNullOrEmpty(course) OrElse
       String.IsNullOrEmpty(studentNumber) Then

            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO dbo.tbl_borrowData (col_borrowerName, col_bookName, col_email, col_course, col_studentNum) " &
                          "VALUES (@BorrowerName, @BookName, @Email, @Course, @StudentNumber)"

        Using command As New SqlCommand(query, sqlConnect1)
            command.Parameters.AddWithValue("@BorrowerName", borrowerName)
            command.Parameters.AddWithValue("@BookName", bookName)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Course", course)
            command.Parameters.AddWithValue("@StudentNumber", studentNumber)

            Try
                If sqlConnect1.State = ConnectionState.Closed Then
                    sqlConnect1.Open()
                End If

                command.ExecuteNonQuery()

                MessageBox.Show("Borrow data has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If sqlConnect1.State = ConnectionState.Open Then
                    sqlConnect1.Close()
                End If
            End Try
        End Using
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        PNL_TermsandCond.Visible = True

    End Sub

    Private Sub Bt_BackBMTND_Click(sender As Object, e As EventArgs) Handles Bt_BackBMTND.Click
        PNL_TermsandCond.Visible = False

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PNL_TermsandCond.Visible = False



    End Sub

    Private Sub Bt_BooksMember_Click(sender As Object, e As EventArgs)

        PNL_BorrowDetails.Visible = False
        PNL_TermsandCond.Visible = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PNL_BorrowDetails_Paint(sender As Object, e As PaintEventArgs) Handles PNL_BorrowDetails.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        PNL_TermsandCond.Visible = True

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If BORROW Is Nothing OrElse BORROW.IsDisposed Then
            BORROW = New Borrow()
            BORROW.MdiParent = Me.MdiParent
            BORROW.FormBorderStyle = FormBorderStyle.None
            BORROW.Dock = DockStyle.Fill
            BORROW.Show()
        Else
            BORROW.BringToFront()
        End If


    End Sub
End Class
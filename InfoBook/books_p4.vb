Imports Microsoft.Data.SqlClient

Public Class books_p4
    Private p0 As books_int
    Private p1 As books_p1
    Private p2 As books_p2
    Private p3 As books_p3
    Private p4 As books_p4
    Private booksDetailForm As BookDetails
    Public Event Swap(sender As Object, e As EventArgs)
    Private return1 As ReturnForm


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If p0 Is Nothing OrElse p0.IsDisposed Then
            p0 = New books_int()
            p0.MdiParent = Me.MdiParent
            p0.FormBorderStyle = FormBorderStyle.None
            p0.Dock = DockStyle.Fill
            p0.Show()
            p0.Button8.BackColor = Color.FromArgb(64, 64, 64)

        Else
            p0.BringToFront()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If p0 Is Nothing OrElse p0.IsDisposed Then
            p0 = New books_int()
            p0.MdiParent = Me.MdiParent
            p0.FormBorderStyle = FormBorderStyle.None
            p0.Dock = DockStyle.Fill
            p0.Show()
            p0.Button8.BackColor = Color.FromArgb(64, 64, 64)

        Else
            p0.BringToFront()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If p3 Is Nothing OrElse p3.IsDisposed Then
            p3 = New books_p3()
            p3.MdiParent = Me.MdiParent
            p3.FormBorderStyle = FormBorderStyle.None
            p3.Dock = DockStyle.Fill
            p3.Show()
            p3.Button1.BackColor = Color.FromArgb(64, 64, 64)

        Else
            p3.BringToFront()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If p3 Is Nothing OrElse p3.IsDisposed Then
            p3 = New books_p3()
            p3.MdiParent = Me.MdiParent
            p3.FormBorderStyle = FormBorderStyle.None
            p3.Dock = DockStyle.Fill
            p3.Show()
            p3.Button1.BackColor = Color.FromArgb(64, 64, 64)

        Else
            p3.BringToFront()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If p2 Is Nothing OrElse p2.IsDisposed Then
            p2 = New books_p2()
            p2.MdiParent = Me.MdiParent
            p2.FormBorderStyle = FormBorderStyle.None
            p2.Dock = DockStyle.Fill
            p2.Show()
            p2.Button3.BackColor = Color.FromArgb(64, 64, 64)

        Else
            p2.BringToFront()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If p1 Is Nothing OrElse p1.IsDisposed Then
            p1 = New books_p1()
            p1.MdiParent = Me.MdiParent
            p1.FormBorderStyle = FormBorderStyle.None
            p1.Dock = DockStyle.Fill
            p1.Show()
            p1.Button2.BackColor = Color.FromArgb(64, 64, 64)

        Else
            p1.BringToFront()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Bname24 As String = "The Philippines: A Unique Nation"
        Dim bauthor24 As String = "Sandro M. R. Montero"
        Dim pDate24 As String = "2004"
        Dim desc24 As String = "This book explores the unique cultural, historical, and social makeup of the Philippines. It focuses on the country's distinctiveness and challenges in achieving national unity, providing insights into Filipino identity, politics, and governance.
"
        Dim pic24 As Image = My.Resources.Resources.ph_unique_nation


        PictureBox1.Image = pic24

        Dim bookId As Integer = 24

        Guna2Button1.Tag = bookId

        Dim connectionString As String = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True"
        Dim sqlQuery As String = "SELECT col_status FROM tbl_Books WHERE col_Id = @bookId"
        Dim status As Integer = -1


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@bookId", bookId)


                    status = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking book status: " & ex.Message)
                Return
            End Try
        End Using


        If status = 0 Then
            Guna2Button1.FillColor = Color.Gray
            MessageBox.Show("The book is already borrowed.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            If return1 Is Nothing OrElse booksDetailForm.IsDisposed Then
                return1 = New ReturnForm()
                return1.MdiParent = Me.MdiParent
                return1.FormBorderStyle = FormBorderStyle.None
                return1.Dock = DockStyle.Fill
                return1.Show()
            Else
                return1.BringToFront()
            End If

            Return
        ElseIf status > 0 Then
            Guna2Button1.FillColor = SystemColors.Control
        End If

        If booksDetailForm Is Nothing OrElse booksDetailForm.IsDisposed Then
            booksDetailForm = New BookDetails()
            booksDetailForm.MdiParent = Me.MdiParent
            booksDetailForm.FormBorderStyle = FormBorderStyle.None
            booksDetailForm.Dock = DockStyle.Fill
            booksDetailForm.Show()
        Else
            booksDetailForm.BringToFront()
        End If

        booksDetailForm.UpdateAll13(Bname24, bauthor24, pDate24, desc24, pic24)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Bname25 As String = "Introduction to Philippine Literature"
        Dim bauthor25 As String = "Isagani R. Cruz"
        Dim pDate25 As String = "1994"
        Dim desc25 As String = "This book serves as an introduction to the rich literary tradition of the Philippines, discussing key authors, literary forms, and historical contexts. It provides an accessible guide to Filipino literature from pre-colonial times to the modern era.
"
        Dim pic25 As Image = My.Resources.Resources.intro_to_ph_literature


        PictureBox2.Image = pic25

        Dim bookId As Integer = 25

        Guna2Button2.Tag = bookId

        Dim connectionString As String = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True"
        Dim sqlQuery As String = "SELECT col_status FROM tbl_Books WHERE col_Id = @bookId"
        Dim status As Integer = -1


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@bookId", bookId)


                    status = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking book status: " & ex.Message)
                Return
            End Try
        End Using


        If status = 0 Then
            Guna2Button2.FillColor = Color.Gray
            MessageBox.Show("The book is already borrowed.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            If return1 Is Nothing OrElse booksDetailForm.IsDisposed Then
                return1 = New ReturnForm()
                return1.MdiParent = Me.MdiParent
                return1.FormBorderStyle = FormBorderStyle.None
                return1.Dock = DockStyle.Fill
                return1.Show()
            Else
                return1.BringToFront()
            End If

            Return
        ElseIf status > 0 Then
            Guna2Button2.FillColor = SystemColors.Control
        End If

        If booksDetailForm Is Nothing OrElse booksDetailForm.IsDisposed Then
            booksDetailForm = New BookDetails()
            booksDetailForm.MdiParent = Me.MdiParent
            booksDetailForm.FormBorderStyle = FormBorderStyle.None
            booksDetailForm.Dock = DockStyle.Fill
            booksDetailForm.Show()
        Else
            booksDetailForm.BringToFront()
        End If

        booksDetailForm.UpdateAll14(Bname25, bauthor25, pDate25, desc25, pic25)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim Bname26 As String = "The Philippine Economy: Development and Crisis"
        Dim bauthor26 As String = "Margarita M. Siso"
        Dim pDate26 As String = "2007"
        Dim desc26 As String = "Sison’s book covers the economic history of the Philippines, addressing the impact of both external and internal factors on the country’s economic development. It discusses significant events, such as the impact of colonization and the global economy, on the Philippines' economic trajectory.
"
        Dim pic26 As Image = My.Resources.Resources.Critique_in_the_ph_economy


        PictureBox3.Image = pic26

        Dim bookId As Integer = 26

        Guna2Button3.Tag = bookId

        Dim connectionString As String = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True"
        Dim sqlQuery As String = "SELECT col_status FROM tbl_Books WHERE col_Id = @bookId"
        Dim status As Integer = -1


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@bookId", bookId)


                    status = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking book status: " & ex.Message)
                Return
            End Try
        End Using


        If status = 0 Then
            Guna2Button3.FillColor = Color.Gray
            MessageBox.Show("The book is already borrowed.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            If return1 Is Nothing OrElse booksDetailForm.IsDisposed Then
                return1 = New ReturnForm()
                return1.MdiParent = Me.MdiParent
                return1.FormBorderStyle = FormBorderStyle.None
                return1.Dock = DockStyle.Fill
                return1.Show()
            Else
                return1.BringToFront()
            End If

            Return
        ElseIf status > 0 Then
            Guna2Button3.FillColor = SystemColors.Control
        End If

        If booksDetailForm Is Nothing OrElse booksDetailForm.IsDisposed Then
            booksDetailForm = New BookDetails()
            booksDetailForm.MdiParent = Me.MdiParent
            booksDetailForm.FormBorderStyle = FormBorderStyle.None
            booksDetailForm.Dock = DockStyle.Fill
            booksDetailForm.Show()
        Else
            booksDetailForm.BringToFront()
        End If

        booksDetailForm.UpdateAll15(Bname26, bauthor26, pDate26, desc26, pic26)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Bname27 As String = "Philippine Government and Constitution"
        Dim bauthor27 As String = "Cynthia R. Neri"
        Dim pDate27 As String = "2009"
        Dim desc27 As String = "This book provides an in-depth look at the structure, history, and principles of the Philippine government. It discusses the Constitution, the political system, the branches of government, and the roles of the citizenry in a democratic society. It is widely used in Philippine schools and universities for courses on political science and civics, offering students an accessible yet comprehensive understanding of how the Philippine government functions.
"
        Dim pic27 As Image = My.Resources.Resources.Ph_constiturion_book


        PictureBox4.Image = pic27

        Dim bookId As Integer = 27

        Guna2Button4.Tag = bookId

        Dim connectionString As String = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True"
        Dim sqlQuery As String = "SELECT col_status FROM tbl_Books WHERE col_Id = @bookId"
        Dim status As Integer = -1


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@bookId", bookId)


                    status = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking book status: " & ex.Message)
                Return
            End Try
        End Using


        If status = 0 Then
            Guna2Button4.FillColor = Color.Gray
            MessageBox.Show("The book is already borrowed.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            If return1 Is Nothing OrElse booksDetailForm.IsDisposed Then
                return1 = New ReturnForm()
                return1.MdiParent = Me.MdiParent
                return1.FormBorderStyle = FormBorderStyle.None
                return1.Dock = DockStyle.Fill
                return1.Show()
            Else
                return1.BringToFront()
            End If

            Return
        ElseIf status > 0 Then
            Guna2Button4.FillColor = SystemColors.Control
        End If

        If booksDetailForm Is Nothing OrElse booksDetailForm.IsDisposed Then
            booksDetailForm = New BookDetails()
            booksDetailForm.MdiParent = Me.MdiParent
            booksDetailForm.FormBorderStyle = FormBorderStyle.None
            booksDetailForm.Dock = DockStyle.Fill
            booksDetailForm.Show()
        Else
            booksDetailForm.BringToFront()
        End If

        booksDetailForm.UpdateAll16(Bname27, bauthor27, pDate27, desc27, pic27)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim Bname28 As String = "Filipino Values"
        Dim bauthor28 As String = "Jessica Hagedorn"
        Dim pDate28 As String = "1997"
        Dim desc28 As String = "delves into the values that define Filipino culture, discussing concepts like bayanihan, kapwa, and pagkatao. It offers an in-depth look at the core beliefs that shape Filipino behavior and social interactions
"
        Dim pic28 As Image = My.Resources.Resources.Filipino_val


        PictureBox5.Image = pic28

        Dim bookId As Integer = 28

        Guna2Button5.Tag = bookId

        Dim connectionString As String = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True"
        Dim sqlQuery As String = "SELECT col_status FROM tbl_Books WHERE col_Id = @bookId"
        Dim status As Integer = -1


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@bookId", bookId)


                    status = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking book status: " & ex.Message)
                Return
            End Try
        End Using


        If status = 0 Then
            Guna2Button5.FillColor = Color.Gray
            MessageBox.Show("The book is already borrowed.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            If return1 Is Nothing OrElse booksDetailForm.IsDisposed Then
                return1 = New ReturnForm()
                return1.MdiParent = Me.MdiParent
                return1.FormBorderStyle = FormBorderStyle.None
                return1.Dock = DockStyle.Fill
                return1.Show()
            Else
                return1.BringToFront()
            End If

            Return
        ElseIf status > 0 Then
            Guna2Button5.FillColor = SystemColors.Control
        End If

        If booksDetailForm Is Nothing OrElse booksDetailForm.IsDisposed Then
            booksDetailForm = New BookDetails()
            booksDetailForm.MdiParent = Me.MdiParent
            booksDetailForm.FormBorderStyle = FormBorderStyle.None
            booksDetailForm.Dock = DockStyle.Fill
            booksDetailForm.Show()
        Else
            booksDetailForm.BringToFront()
        End If

        booksDetailForm.UpdateAll17(Bname28, bauthor28, pDate28, desc28, pic28)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Bname29 As String = "The Art of Thinking Clearly"
        Dim bauthor29 As String = "Rolf Dobelli"
        Dim pDate29 As String = "2011"
        Dim desc29 As String = "This book delves into cognitive biases and errors that cloud our judgment. It provides practical advice on how to think more rationally by recognizing common pitfalls in decision-making. While the title doesn’t imply thinking like an idiot, it encourages a clearer, more deliberate way of thinking that can help you avoid mistakes that might otherwise seem foolish."
        Dim pic29 As Image = My.Resources.Resources.Filipino_val


        PictureBox6.Image = pic29

        Dim bookId As Integer = 28

        Guna2Button6.Tag = bookId

        Dim connectionString As String = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True"
        Dim sqlQuery As String = "SELECT col_status FROM tbl_Books WHERE col_Id = @bookId"
        Dim status As Integer = -1


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@bookId", bookId)


                    status = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking book status: " & ex.Message)
                Return
            End Try
        End Using


        If status = 0 Then
            Guna2Button6.FillColor = Color.Gray
            MessageBox.Show("The book is already borrowed.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            If return1 Is Nothing OrElse booksDetailForm.IsDisposed Then
                return1 = New ReturnForm()
                return1.MdiParent = Me.MdiParent
                return1.FormBorderStyle = FormBorderStyle.None
                return1.Dock = DockStyle.Fill
                return1.Show()
            Else
                return1.BringToFront()
            End If

            Return
        ElseIf status > 0 Then
            Guna2Button6.FillColor = SystemColors.Control
        End If

        If booksDetailForm Is Nothing OrElse booksDetailForm.IsDisposed Then
            booksDetailForm = New BookDetails()
            booksDetailForm.MdiParent = Me.MdiParent
            booksDetailForm.FormBorderStyle = FormBorderStyle.None
            booksDetailForm.Dock = DockStyle.Fill
            booksDetailForm.Show()
        Else
            booksDetailForm.BringToFront()
        End If

        booksDetailForm.UpdateAll18(Bname29, bauthor29, pDate29, desc29, pic29)
    End Sub
End Class
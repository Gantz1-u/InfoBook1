Imports Microsoft.Data.SqlClient

Public Class books_p1
    Private booksDetailForm As BookDetails
    Public Event Swap(sender As Object, e As EventArgs)
    Private return1 As ReturnForm
    Private p0 As books_int
    Private p2 As books_p2
    Private p3 As books_p3
    Private p4 As books_p4

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Bname6 As String = "Ibong Adarna"
        Dim bauthor6 As String = "Virgilio S. Almario"
        Dim pDate6 As String = "1941"
        Dim desc6 As String = "Ibong Adarna is a classic Filipino epic poem that tells the story of three princes—Don Juan, Don Diego, and Don Pedro—who embark on a quest to capture the mythical Ibong Adarna (Adarna Bird) to heal their ailing father, King Fernando. The poem is rich in symbolism and themes, including family loyalty, forgiveness, and the consequences of greed. Known for its poetic structure and vivid storytelling, it remains a cornerstone of Philippine literature and cultural heritage."
        Dim pic6 As Image = My.Resources.Resources.Ibong_Adarna '
        PictureBox1.Image = pic6

        Dim bookId As Integer = 1

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

        booksDetailForm.UpdateText6(Bname6, bauthor6, pDate6, desc6)
        booksDetailForm.UpdatePicture6(pic6)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Bname7 As String = "Engineering Fundamentals: An Introduction to Engineering"
        Dim bauthor7 As String = "Saeed Moaveno"
        Dim pDate7 As String = "2000"
        Dim desc7 As String = "This book provides a comprehensive introduction to the field of engineering, covering basic principles, problem-solving techniques, and the various disciplines of engineering (mechanical, civil, electrical, etc.). It’s an ideal starting point for students entering engineering programs, offering real-world examples and hands-on projects to inspire future engineers."
        Dim pic7 As Image = My.Resources.Resources.enginneer
        PictureBox2.Image = pic7

        Dim bookId As Integer = 2

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

        booksDetailForm.UpdateText7(Bname7, bauthor7, pDate7, desc7)
        booksDetailForm.UpdatePicture7(pic7)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim Bname8 As String = "Macarthur"
        Dim bauthor8 As String = "Bob Ong"
        Dim pDate8 As String = "2001"
        Dim desc8 As String = "Macarthur is a satirical novel that reflects Filipino culture, identity, and the absurdities of everyday life. The protagonist, Macarthur, embarks on a series of humorous and critical events, offering social commentary on Filipino society. Through witty dialogue and a relatable narrative, Bob Ong critiques issues such as politics, education, and social norms, often using absurdity to highlight the contrast between aspirations and reality.

"
        Dim pic8 As Image = My.Resources.Resources.macartur
        PictureBox3.Image = pic8

        Dim bookId As Integer = 3

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

        booksDetailForm.UpdateText8(Bname8, bauthor8, pDate8, desc8)
        booksDetailForm.UpdatePicture8(pic8)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Bname9 As String = "Abanakakapagbasanapalaako"
        Dim bauthor9 As String = "Bob Ong"
        Dim pDate9 As String = "2003"
        Dim desc9 As String = "Abanakakapagbasanapalaako is a comedic and satirical book that showcases Bob Ong's distinct style of humor. In this work, he addresses various societal issues in the Philippines, particularly the struggles of the common Filipino. It explores the challenges of education, class disparity, and the complexities of daily life. The title itself, a tongue-twister, reflects the playful and whimsical nature of the book. As in many of his works, Ong combines humor with social commentary, making it both entertaining and thought-provoking for readers.

"
        Dim pic9 As Image = My.Resources.Resources.Abanakakapagbasanapalaako
        PictureBox4.Image = pic9

        Dim bookId As Integer = 4

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

        booksDetailForm.UpdateText9(Bname9, bauthor9, pDate9, desc9)
        booksDetailForm.UpdatePicture9(pic9)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim Bname10 As String = "Fan Girl"
        Dim bauthor10 As String = "Rainbow Rowell"
        Dim pDate10 As String = "2013"
        Dim desc10 As String = "Fangirl follows Cath, a shy and introverted college freshman who is obsessed with writing fanfiction about a popular book series. She struggles with her social anxiety and her complicated relationship with her twin sister, Wren, who is becoming more independent as they navigate their first year away from home. As Cath faces challenges in her personal life, family dynamics, and romantic relationships, she learns to find her own voice and balance her love for fandom with her real-world connections.

"
        Dim pic10 As Image = My.Resources.Resources.fangirl
        PictureBox5.Image = pic10

        Dim bookId As Integer = 5

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

        booksDetailForm.UpdateText10(Bname10, bauthor10, pDate10, desc10)
        booksDetailForm.UpdatePicture10(pic10)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Bname11 As String = "Forrest Gump"
        Dim bauthor11 As String = "Winston Groom"
        Dim pDate11 As String = "1986"
        Dim desc11 As String = "A slow-witted man stumbles his way through life, accidentally causing chaos and making millions while completely oblivious to it all. He somehow ends up everywhere—football, war, and even running across the country—while his childhood crush self-destructs in a series of poor life choices. Everyone around him just tolerates him, and despite never understanding what's going on, he somehow manages to win at everything. Meanwhile, his ex-girlfriend spirals into drugs, bad relationships, and tragedy. Forrest? He just runs, because why not?"
        Dim pic11 As Image = My.Resources.Resources.fangirl
        PictureBox6.Image = pic11

        Dim bookId As Integer = 6

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

        booksDetailForm.UpdateText11(Bname11, bauthor11, pDate11, desc11)
        booksDetailForm.UpdatePicture11(pic11)
    End Sub

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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

    Private Sub books_p1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If p4 Is Nothing OrElse p4.IsDisposed Then
            p4 = New books_p4()
            p4.MdiParent = Me.MdiParent
            p4.FormBorderStyle = FormBorderStyle.None
            p4.Dock = DockStyle.Fill
            p4.Show()
            p4.Button4.BackColor = Color.FromArgb(64, 64, 64)

        Else
            p4.BringToFront()
        End If
    End Sub
End Class
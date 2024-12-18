Imports Microsoft.Data.SqlClient

Public Class books_p3
    Private booksDetailForm As BookDetails
    Public Event Swap(sender As Object, e As EventArgs)
    Private return1 As ReturnForm
    Private p0 As books_int
    Private p1 As books_p1
    Private p2 As books_p2
    Private p4 As books_p4


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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Bname18 As String = "Rich Dad Poor Dad"
        Dim bauthor18 As String = " Robert T. Kiyosaki"
        Dim pDate18 As String = "1997"
        Dim desc18 As String = "Rich Dad Poor Dad** by Robert T. Kiyosaki is a bestselling personal finance book that challenges traditional beliefs about money and investing. Through the lens of two father figures—his biological Poor Dad and his mentor Rich Dad—Kiyosaki shares key lessons on building wealth, managing finances, and achieving financial freedom. The book emphasizes the importance of financial education, investing in assets, and adopting a mindset that prioritizes long-term wealth over short-term security."
        Dim pic18 As Image = My.Resources.Resources.richdad
        PictureBox1.Image = pic18

        Dim bookId As Integer = 18

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

        booksDetailForm.UpdateAll7(Bname18, bauthor18, pDate18, desc18, pic18)
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Bname19 As String = "Why We Sleep: Unlocking the Power of Sleep and Dreams"
        Dim bauthor19 As String = "Matthew Walker"
        Dim pDate19 As String = "2017"
        Dim desc19 As String = "This book provides an in-depth look at the science of sleep, covering why it is essential for physical and mental health. Walker explains the various stages of sleep, how it impacts memory, learning, and creativity, and offers tips on improving sleep quality. The book emphasizes the critical role of sleep in our daily lives and explores the consequences of sleep deprivation."
        Dim pic19 As Image = My.Resources.Resources.why_we_sleep
        PictureBox2.Image = pic19

        Dim bookId As Integer = 19

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

        booksDetailForm.UpdateAll8(Bname19, bauthor19, pDate19, desc19, pic19)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim Bname20 As String = "Biag ni Lam-Ang"
        Dim bauthor20 As String = "Unknown"
        Dim pDate20 As String = "1700"
        Dim desc20 As String = "Biag ni Lam-ang tells the story of Lam-ang, a heroic figure with superhuman abilities. His birth is miraculous, as he is able to speak immediately after birth. Lam-ang embarks on several adventures, including seeking revenge for the death of his father, battling giant creatures, and winning the heart of Ines Kannoyan, the woman he loves. His life is filled with daring feats, bravery, and triumphs, showcasing his extraordinary powers, from being able to communicate with animals to surviving dangerous battles.
The epic also reflects the Ilocano values of heroism, bravery, loyalty, and love. Lam-ang’s quest for vengeance and love ultimately brings him to great heights, making him a symbol of heroism and a subject of reverence in Ilocano folklore.
"
        Dim pic20 As Image = My.Resources.Resources.Biag_ni_lam
        PictureBox3.Image = pic20

        Dim bookId As Integer = 20

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

        booksDetailForm.UpdateAll9(Bname20, bauthor20, pDate20, desc20, pic20)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Bname21 As String = "Mein Kampf"
        Dim bauthor21 As String = "Adolf Hitler"
        Dim pDate21 As String = "1925"
        Dim desc21 As String = "Mein Kampf is one of the most infamous works of the 20th century. In it, Hitler describes his early life, his time in prison, and his ideological framework, which later influenced the Nazi regime. The book discusses his views on race, particularly his belief in the supremacy of the Aryan race, and his plans for the expansion of Germany. It became a key text for Nazi propaganda.
"
        Dim pic21 As Image = My.Resources.Resources.hitler

        PictureBox4.Image = pic21

        Dim bookId As Integer = 21

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

        booksDetailForm.UpdateAll10(Bname21, bauthor21, pDate21, desc21, pic21)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim Bname22 As String = "Kapitan Sino"
        Dim bauthor22 As String = "Jessica Hagedorn"
        Dim pDate22 As String = "2005"
        Dim desc22 As String = "Kapitan Sino is a novel that blends humor, social commentary, and superhero tropes. It follows an unnamed protagonist who adopts the persona of a superhero, Kapitan Sino, as a means of addressing the social and political issues in the Philippines. The novel critiques corruption, inequality, and moral dilemmas, using satire to discuss the reality of being a hero in modern society. The protagonist's transformation and struggles serve as a metaphor for the everyday challenges faced by Filipinos."
        Dim pic22 As Image = My.Resources.Resources.kapitan_sino


        PictureBox5.Image = pic22

        Dim bookId As Integer = 22

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

        booksDetailForm.UpdateAll111(Bname22, bauthor22, pDate22, desc22, pic22)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Bname23 As String = "Dogeaters"
        Dim bauthor23 As String = "Alicia P. L. Lutz"
        Dim pDate23 As String = "1997"
        Dim desc23 As String = "Dogeaters is a vibrant and multilayered narrative that captures the chaos and contradictions of Filipino society. The novel presents a snapshot of Manila's urban landscape, combining the stark realities of poverty and inequality with the glitzy world of entertainment and politics. Through a cast of complex characters, Hagedorn weaves a story of survival, desire, and power. The title itself refers to a derogatory term that can reflect both the characters’ struggle to survive in a brutal, competitive world and the changing cultural identities within a post-colonial society.
"
        Dim pic23 As Image = My.Resources.Resources.kapitan_sino


        PictureBox6.Image = pic23

        Dim bookId As Integer = 23

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

        booksDetailForm.UpdateAll12(Bname23, bauthor23, pDate23, desc23, pic23)
    End Sub
End Class
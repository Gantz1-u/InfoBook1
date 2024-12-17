Imports Microsoft.Data.SqlClient

Public Class books_p2

    Private booksDetailForm As BookDetails
    Public Event Swap(sender As Object, e As EventArgs)
    Private return1 As ReturnForm
    Private p0 As books_int
    Private p1 As books_p1
    Private p2 As books_p2
    Private p3 As books_p3
    Private p4 As books_p4
    Private Sub books_p2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Bname12 As String = "Flipped"
        Dim bauthor12 As String = "Wendelin Van Draanen"
        Dim pDate12 As String = "2003"
        Dim desc12 As String = "Flipped is a heartwarming coming-of-age story about two young neighbors, Juli and Bryce, who have a complicated relationship over the years. Juli, an enthusiastic and free-spirited girl, has had a crush on Bryce since they were kids, but Bryce is initially put off by her and tries to avoid her. As they grow older, their perspectives on each other flip. Bryce begins to see Juli in a new light, while Juli becomes disillusioned with him. The novel explores themes of first love, personal growth, and the impact of family and community. It's a story about how our perceptions of others can change over time, often revealing deeper truths about ourselves.



"
        Dim pic12 As Image = My.Resources.Resources.Abanakakapagbasanapalaako
        PictureBox1.Image = pic12

        Dim bookId As Integer = 7

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

        booksDetailForm.UpdateAll1(Bname12, bauthor12, pDate12, desc12, pic12)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Bname13 As String = "florante at laura"
        Dim bauthor13 As String = "Francisco Balagtas"
        Dim pDate13 As String = "1838"
        Dim desc13 As String = "Florante at Laura is a narrative poem that centers around the story of Florante, a prince, and his beloved Laura, set against the backdrop of the kingdom of Albanya. The poem explores themes such as love, betrayal, political intrigue, and heroism. The plot revolves around Florante's love for Laura, his battles against rivals, and his struggles with fate, but also touches on political corruption, loyalty, and justice. The work is also a reflection of Balagtas’ views on Filipino society during the Spanish colonial period."
        Dim pic13 As Image = My.Resources.Resources.florante_at_laura
        PictureBox2.Image = pic13

        Dim bookId As Integer = 8

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

        booksDetailForm.UpdateAll2(Bname13, bauthor13, pDate13, desc13, pic13)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim Bname14 As String = "Inside the Criminal Mind"
        Dim bauthor14 As String = "Stanton E. Samenows"
        Dim pDate14 As String = "1984"
        Dim desc14 As String = "This book delves into the psychology of criminals, debunking myths about crime being purely a product of environment or poverty. Samenow explores how criminals think, make decisions, and justify their actions. It's an essential read for anyone interested in criminology, psychology, or law "
        Dim pic14 As Image = My.Resources.Resources.criminal_minds
        PictureBox3.Image = pic14

        Dim bookId As Integer = 10

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

        booksDetailForm.UpdateAll3(Bname14, bauthor14, pDate14, desc14, pic14)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Bname15 As String = "Information Technology Project Management"
        Dim bauthor15 As String = "Kathy Schwalbe"
        Dim pDate15 As String = "2000"
        Dim desc15 As String = "This textbook provides a comprehensive guide to managing IT projects, covering essential tools, techniques, and frameworks aligned with PMBOK (Project Management Body of Knowledge). It integrates real-world examples, case studies, and exercises to help students and professionals master project planning, execution, monitoring, and closure in the IT context. "
        Dim pic15 As Image = My.Resources.Resources.info_1
        PictureBox4.Image = pic15

        Dim bookId As Integer = 12

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

        booksDetailForm.UpdateAll4(Bname15, bauthor15, pDate15, desc15, pic15)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim Bname16 As String = "Noli Me Tangere"
        Dim bauthor16 As String = "José Rizal"
        Dim pDate16 As String = "1887"
        Dim desc16 As String = "Noli Me Tangere (Latin for Touch Me Not is a novel written by Dr. José Rizal that depicts the social, political, and economic struggles of the Philippines under Spanish colonial rule. The story follows Crisostomo Ibarra, a young man who returns to the Philippines after studying abroad, only to find his homeland plagued by corruption, injustice, and oppression. The novel explores themes of inequality, love, betrayal, and the need for reform. It played a crucial role in awakening the Filipino people to the need for change, making it a key piece of Philippine literature and history. "
        Dim pic16 As Image = My.Resources.Resources.NoliMeTangere
        PictureBox5.Image = pic16

        Dim bookId As Integer = 16

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

        booksDetailForm.UpdateAll5(Bname16, bauthor16, pDate16, desc16, pic16)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Bname17 As String = "El Filibusterismo"
        Dim bauthor17 As String = "José Rizal"
        Dim pDate17 As String = "1891"
        Dim desc17 As String = "El Filibusterismo (The Reign of Greed) is José Rizal’s darker and more political sequel to Noli Me Tangere. The novel follows the character of Simoun, a wealthy jeweler who is secretly a revolutionary aiming to incite a rebellion against Spanish rule in the Philippines. The novel critiques the corruption and abuses of the Spanish colonial government and the clergy, and it explores the themes of revenge, corruption, and the complexities of societal reform. Unlike its predecessor, which called for peaceful reform, El Filibusterismo advocates for radical change through revolutionary means. The novel is a call to action, urging Filipinos to fight for their freedom."
        Dim pic17 As Image = My.Resources.Resources.Elfi
        PictureBox6.Image = pic17

        Dim bookId As Integer = 17

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

        booksDetailForm.UpdateAll6(Bname17, bauthor17, pDate17, desc17, pic17)
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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
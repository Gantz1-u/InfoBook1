Imports Azure.Core.HttpHeader
Imports Microsoft.Data.SqlClient


Public Class books_int
    Private booksDetailForm As BookDetails
    Public Event Swap(sender As Object, e As EventArgs)
    Private return1 As ReturnForm
    Private p1 As books_p1
    Private p2 As books_p2
    Private p3 As books_p3
    Private p4 As books_p4



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Bname As String = "Philippine History"
        Dim bauthor As String = "Teodoro A. Agoncillo"
        Dim pDate As String = "1960"
        Dim desc As String = "Teodoro Agoncillo’s Philippine History is one of the most widely used textbooks in Philippine education, covering the historical development of the Philippines from pre-colonial times to the modern era. It highlights key events, figures, and social movements that shaped the nation's history, including the arrival of the Spaniards, the Philippine Revolution, and the country's journey to independence."
        Dim pic As Image = My.Resources.Resources.Ph_history
        PictureBox1.Image = pic

        Dim bookId As Integer = 15

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

        booksDetailForm.UpdateText(Bname, bauthor, pDate, desc)
        booksDetailForm.UpdatePicture(pic)

    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Bname1 As String = "49 Laws Of Power"
        Dim bauthor1 As String = "Robert Greene"
        Dim pDate1 As String = "1988"
        Dim desc1 As String = "This book distills centuries of wisdom from historical leaders, strategists, and philosophers into 48 laws for achieving and maintaining power. It offers lessons on strategy, manipulation, and self-control, making it a controversial yet widely-read guide for those navigating power dynamics in life and business."
        Dim pic1 As Image = My.Resources.Resources._49laws_of_power
        PictureBox2.Image = pic1
        Dim bookId As Integer = 9

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
            MessageBox.Show("The book is unavailable.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        booksDetailForm.UpdateText1(Bname1, bauthor1, pDate1, desc1)
        booksDetailForm.UpdatePicture1(pic1)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        Dim Bname2 As String = "Accelerate: The Science of Lean Software and DevOps"
        Dim bauthor2 As String = "Nicole Forsgren, Jez Humble, and Gene Kim"
        Dim pDate2 As String = "2018"
        Dim desc2 As String = "This book examines the science behind high-performing software development and IT teams, based on extensive research. It explores metrics that predict success, practices that lead to efficiency, and how organizations can implement DevOps and Lean principles to scale effectively. It's essential reading for anyone in technology looking to improve delivery performance and organizational outcomes."
        Dim pic2 As Image = My.Resources.Resources.accelaerate
        PictureBox3.Image = pic2

        Dim bookId As Integer = 11

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
            MessageBox.Show("The book is unavailable.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        booksDetailForm.UpdateText2(Bname2, bauthor2, pDate2, desc2)
        booksDetailForm.UpdatePicture2(pic2)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Bname3 As String = "Geology For Dummies"
        Dim bauthor3 As String = " Alecia M. Spooner"
        Dim pDate3 As String = "2011"
        Dim desc3 As String = " This beginner-friendly guide introduces the fundamental concepts of geology, including Earth’s structure, rock types, plate tectonics, and geological processes like erosion and earthquakes. With simple explanations and practical examples, it’s perfect for students, enthusiasts, or anyone curious about the science of Earth."
        Dim pic3 As Image = My.Resources.Resources.geology_dummies
        PictureBox4.Image = pic3
        Dim bookId As Integer = 13

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
            MessageBox.Show("The book is unavailable.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        booksDetailForm.UpdateText3(Bname3, bauthor3, pDate3, desc3)
        booksDetailForm.UpdatePicture3(pic3)

    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim Bname4 As String = "Principles of Geology"
        Dim bauthor4 As String = "Charles Lyell"
        Dim pDate4 As String = "1830"
        Dim desc4 As String = "A groundbreaking work in geology, this book introduced the concept of uniformitarianism, the idea that Earth's geological features are shaped by continuous and observable processes over time. Lyell's work laid the foundation for modern geology and influenced thinkers like Charles Darwin. It remains a historical and scientific cornerstone for understanding Earth's dynamic systems."
        Dim pic4 As Image = My.Resources.Resources.principles_of_geo
        PictureBox5.Image = pic4



        Dim bookId As Integer = 30


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
            MessageBox.Show("The book is unavailable.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        booksDetailForm.UpdateText4(Bname4, bauthor4, pDate4, desc4)
        booksDetailForm.UpdatePicture4(pic4)

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Bname5 As String = "Jose Rizal: His Life, Works, and Writing"
        Dim bauthor5 As String = "Gregorio F. Zaide"
        Dim pDate5 As String = "1941"
        Dim desc5 As String = "This book is one of the most popular references for studying the life and works of Dr. Jose Rizal, the national hero of the Philippines. It covers his early life, education, achievements, and the significant impact of his writings, especially Noli Me Tangere and El Filibusterismo, on the Philippine revolution against Spanish colonization. Zaide’s book also explores Rizal's ideals, struggles, and his ultimate martyrdom, highlighting his role in shaping the nation's identity and independence."
        Dim pic5 As Image = My.Resources.Resources.JoseRizal_LifeWorks
        PictureBox6.Image = pic5

        Dim bookId As Integer = 14

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
            MessageBox.Show("The book is unavailable.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        booksDetailForm.UpdateText5(Bname5, bauthor5, pDate5, desc5)
        booksDetailForm.UpdatePicture5(pic5)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub books_int_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

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



Imports Azure.Core.HttpHeader

Public Class books_int
    Private booksDetailForm As BookDetails
    Public Event Swap(sender As Object, e As EventArgs)

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Bname As String = "Philippine History"
        Dim bauthor As String = "Teodoro A. Agoncillo"
        Dim pDate As String = "1960"
        Dim desc As String = "Teodoro Agoncillo’s Philippine History is one of the most widely used textbooks in Philippine education, covering the historical development of the Philippines from pre-colonial times to the modern era. It highlights key events, figures, and social movements that shaped the nation's history, including the arrival of the Spaniards, the Philippine Revolution, and the country's journey to independence."

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
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Bname1 As String = "49 Laws Of Power"
        Dim bauthor1 As String = "Robert Greene"
        Dim pDate1 As String = "1988"
        Dim desc1 As String = "This book distills centuries of wisdom from historical leaders, strategists, and philosophers into 48 laws for achieving and maintaining power. It offers lessons on strategy, manipulation, and self-control, making it a controversial yet widely-read guide for those navigating power dynamics in life and business."

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
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        Dim Bname2 As String = "Accelerate: The Science of Lean Software and DevOps"
        Dim bauthor2 As String = "Nicole Forsgren, Jez Humble, and Gene Kim"
        Dim pDate2 As String = "2018"
        Dim desc2 As String = "This book examines the science behind high-performing software development and IT teams, based on extensive research. It explores metrics that predict success, practices that lead to efficiency, and how organizations can implement DevOps and Lean principles to scale effectively. It's essential reading for anyone in technology looking to improve delivery performance and organizational outcomes."

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
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Bname3 As String = "Geology For Dummies"
        Dim bauthor3 As String = " Alecia M. Spooner"
        Dim pDate3 As String = "2011"
        Dim desc3 As String = " This beginner-friendly guide introduces the fundamental concepts of geology, including Earth’s structure, rock types, plate tectonics, and geological processes like erosion and earthquakes. With simple explanations and practical examples, it’s perfect for students, enthusiasts, or anyone curious about the science of Earth."

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
    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim Bname4 As String = "Principles of Geology"
        Dim bauthor4 As String = "Charles Lyell"
        Dim pDate4 As String = "1830"
        Dim desc4 As String = "A groundbreaking work in geology, this book introduced the concept of uniformitarianism, the idea that Earth's geological features are shaped by continuous and observable processes over time. Lyell's work laid the foundation for modern geology and influenced thinkers like Charles Darwin. It remains a historical and scientific cornerstone for understanding Earth's dynamic systems."

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
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Bname5 As String = "Jose Rizal: His Life, Works, and Writing"
        Dim bauthor5 As String = "Gregorio F. Zaide"
        Dim pDate5 As String = "1941"
        Dim desc5 As String = "This book is one of the most popular references for studying the life and works of Dr. Jose Rizal, the national hero of the Philippines. It covers his early life, education, achievements, and the significant impact of his writings, especially Noli Me Tangere and El Filibusterismo, on the Philippine revolution against Spanish colonization. Zaide’s book also explores Rizal's ideals, struggles, and his ultimate martyrdom, highlighting his role in shaping the nation's identity and independence."

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
    End Sub
End Class


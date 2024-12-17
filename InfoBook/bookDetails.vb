Imports Guna.UI2.WinForms
Imports Microsoft.Data.SqlClient


Public Class BookDetails
    Private BORROW As Borrow
    Private sqlConnect1 As SqlConnection

    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        sqlConnect1 = New SqlConnection("Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True")

        Dim Sql As New sqlConnect

    End Sub




    Public Sub UpdateText(Bname As String, bauthor As String, pDate As String, desc As String)
        Label1.Text = Bname
        Label2.Text = bauthor
        Label3.Text = pDate
        RichTextBox1.Text = desc

    End Sub

    Public Sub UpdatePicture(pic As Image)
        PictureBox1.Image = pic
    End Sub
    Public Sub UpdatePicture1(pic1 As Image)
        PictureBox1.Image = pic1
    End Sub
    Public Sub UpdatePicture2(pic2 As Image)
        PictureBox1.Image = pic2
    End Sub
    Public Sub UpdatePicture3(pic3 As Image)
        PictureBox1.Image = pic3
    End Sub
    Public Sub UpdatePicture4(pic4 As Image)
        PictureBox1.Image = pic4
    End Sub
    Public Sub UpdatePicture5(pic5 As Image)
        PictureBox1.Image = pic5
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


    End Sub





    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        PNL_TermsandCond.Visible = True

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If BORROW Is Nothing OrElse BORROW.IsDisposed Then
            BORROW = New Borrow
            BORROW.MdiParent = MdiParent
            BORROW.FormBorderStyle = FormBorderStyle.None
            BORROW.Dock = DockStyle.Fill
            BORROW.Show()
        Else
            BORROW.BringToFront()
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
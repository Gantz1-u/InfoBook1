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
    Public Sub UpdatePicture55(pic5 As Image)
        PictureBox1.Image = pic5
    End Sub
    Public Sub UpdatePicture6(pic6 As Image)
        PictureBox1.Image = pic6
    End Sub
    Public Sub UpdatePicture5(pic5 As Image)
        PictureBox1.Image = pic5
    End Sub
    Public Sub UpdatePicture7(pic7 As Image)
        PictureBox1.Image = pic7
    End Sub
    Public Sub UpdatePicture8(pic8 As Image)
        PictureBox1.Image = pic8
    End Sub
    Public Sub UpdatePicture9(pic9 As Image)
        PictureBox1.Image = pic9
    End Sub
    Public Sub UpdatePicture10(pic10 As Image)
        PictureBox1.Image = pic10
    End Sub
    Public Sub UpdatePicture11(pic11 As Image)
        PictureBox1.Image = pic11
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

    Public Sub UpdateText6(Bname6 As String, bauthor6 As String, pDate6 As String, desc6 As String)
        Label1.Text = Bname6
        Label2.Text = bauthor6
        Label3.Text = pDate6
        RichTextBox1.Text = desc6
    End Sub

    Public Sub UpdateText7(Bname7 As String, bauthor7 As String, pDate7 As String, desc7 As String)
        Label1.Text = Bname7
        Label1.Font = New Font("Segoe UI", 14, FontStyle.Bold)

        Label2.Text = bauthor7
        Label3.Text = pDate7
        RichTextBox1.Text = desc7

    End Sub

    Public Sub UpdateText8(Bname8 As String, bauthor8 As String, pDate8 As String, desc8 As String)
        Label1.Text = Bname8
        Label2.Text = bauthor8
        Label3.Text = pDate8
        RichTextBox1.Text = desc8
    End Sub

    Public Sub UpdateText9(Bname9 As String, bauthor9 As String, pDate9 As String, desc9 As String)
        Label1.Text = Bname9
        Label2.Text = bauthor9
        Label3.Text = pDate9
        RichTextBox1.Text = desc9
    End Sub

    Public Sub UpdateText10(Bname10 As String, bauthor10 As String, pDate10 As String, desc10 As String)
        Label1.Text = Bname10
        Label2.Text = bauthor10
        Label3.Text = pDate10
        RichTextBox1.Text = desc10
    End Sub

    Public Sub UpdateText11(Bname11 As String, bauthor11 As String, pDate11 As String, desc11 As String)
        Label1.Text = Bname11
        Label2.Text = bauthor11
        Label3.Text = pDate11
        RichTextBox1.Text = desc11
    End Sub

    Public Sub UpdateAll1(Bname12 As String, bauthor12 As String, pDate12 As String, desc12 As String, pic12 As Image)
        Label1.Text = Bname12
        Label2.Text = bauthor12
        Label3.Text = pDate12
        RichTextBox1.Text = desc12
        PictureBox1.Image = pic12
    End Sub

    Public Sub UpdateAll2(Bname13 As String, bauthor13 As String, pDate13 As String, desc13 As String, pic13 As Image)
        Label1.Text = Bname13
        Label2.Text = bauthor13
        Label3.Text = pDate13
        RichTextBox1.Text = desc13
        PictureBox1.Image = pic13
    End Sub
    Public Sub UpdateAll3(Bname14 As String, bauthor14 As String, pDate14 As String, desc14 As String, pic14 As Image)
        Label1.Text = Bname14
        Label2.Text = bauthor14
        Label3.Text = pDate14
        RichTextBox1.Text = desc14
        PictureBox1.Image = pic14
    End Sub
    Public Sub UpdateAll4(Bname15 As String, bauthor15 As String, pDate15 As String, desc15 As String, pic15 As Image)
        Label1.Text = Bname15
        Label1.Font = New Font("Segoe UI", 16, FontStyle.Bold)

        Label2.Text = bauthor15
        Label3.Text = pDate15
        RichTextBox1.Text = desc15
        PictureBox1.Image = pic15
    End Sub
    Public Sub UpdateAll5(Bname16 As String, bauthor16 As String, pDate16 As String, desc16 As String, pic16 As Image)
        Label1.Text = Bname16
        Label2.Text = bauthor16
        Label3.Text = pDate16
        RichTextBox1.Text = desc16
        PictureBox1.Image = pic16
    End Sub
    Public Sub UpdateAll6(Bname17 As String, bauthor17 As String, pDate17 As String, desc17 As String, pic17 As Image)
        Label1.Text = Bname17
        Label2.Text = bauthor17
        Label3.Text = pDate17
        RichTextBox1.Text = desc17
        PictureBox1.Image = pic17
    End Sub

    Public Sub UpdateAll7(Bname18 As String, bauthor18 As String, pDate18 As String, desc18 As String, pic18 As Image)
        Label1.Text = Bname18
        Label2.Text = bauthor18
        Label3.Text = pDate18
        RichTextBox1.Text = desc18
        PictureBox1.Image = pic18
    End Sub
    Public Sub UpdateAll8(Bname19 As String, bauthor19 As String, pDate19 As String, desc19 As String, pic19 As Image)
        Label1.Text = Bname19
        Label1.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Label2.Text = bauthor19
        Label3.Text = pDate19
        RichTextBox1.Text = desc19
        PictureBox1.Image = pic19
    End Sub
    Public Sub UpdateAll9(Bname20 As String, bauthor20 As String, pDate20 As String, desc20 As String, pic20 As Image)
        Label1.Text = Bname20
        Label2.Text = bauthor20
        Label3.Text = pDate20
        RichTextBox1.Text = desc20
        PictureBox1.Image = pic20
    End Sub
    Public Sub UpdateAll10(Bname21 As String, bauthor21 As String, pDate21 As String, desc21 As String, pic21 As Image)
        Label1.Text = Bname21
        Label2.Text = bauthor21
        Label3.Text = pDate21
        RichTextBox1.Text = desc21
        PictureBox1.Image = pic21
    End Sub
    Public Sub UpdateAll11(Bname22 As String, bauthor22 As String, pDate22 As String, desc22 As String, pic22 As Image)
        Label1.Text = Bname22
        Label2.Text = bauthor22
        Label3.Text = pDate22
        RichTextBox1.Text = desc22
        PictureBox1.Image = pic22
    End Sub
    Public Sub UpdateAll111(Bname22 As String, bauthor22 As String, pDate22 As String, desc22 As String, pic22 As Image)
        Label1.Text = Bname22
        Label2.Text = bauthor22
        Label3.Text = pDate22
        RichTextBox1.Text = desc22
        PictureBox1.Image = pic22
    End Sub

    Public Sub UpdateAll12(Bname23 As String, bauthor23 As String, pDate23 As String, desc23 As String, pic23 As Image)
        Label1.Text = Bname23
        Label2.Text = bauthor23
        Label3.Text = pDate23
        RichTextBox1.Text = desc23
        PictureBox1.Image = pic23
    End Sub

    Public Sub UpdateAll13(Bname24 As String, bauthor24 As String, pDate24 As String, desc24 As String, pic24 As Image)
        Label1.Text = Bname24
        Label2.Text = bauthor24
        Label3.Text = pDate24
        RichTextBox1.Text = desc24
        PictureBox1.Image = pic24
    End Sub
    Public Sub UpdateAll14(Bname25 As String, bauthor25 As String, pDate25 As String, desc25 As String, pic25 As Image)
        Label1.Text = Bname25
        Label2.Text = bauthor25
        Label3.Text = pDate25
        RichTextBox1.Text = desc25
        PictureBox1.Image = pic25
    End Sub

    Public Sub UpdateAll15(Bname26 As String, bauthor26 As String, pDate26 As String, desc26 As String, pic26 As Image)
        Label1.Text = Bname26
        Label1.Font = New Font("Segoe UI", 16, FontStyle.Bold)

        Label2.Text = bauthor26
        Label3.Text = pDate26
        RichTextBox1.Text = desc26
        PictureBox1.Image = pic26
    End Sub

    Public Sub UpdateAll16(Bname27 As String, bauthor27 As String, pDate27 As String, desc27 As String, pic27 As Image)
        Label1.Text = Bname27
        Label2.Text = bauthor27
        Label3.Text = pDate27
        RichTextBox1.Text = desc27
        PictureBox1.Image = pic27
    End Sub

    Public Sub UpdateAll17(Bname28 As String, bauthor28 As String, pDate28 As String, desc28 As String, pic28 As Image)
        Label1.Text = Bname28
        Label2.Text = bauthor28
        Label3.Text = pDate28
        RichTextBox1.Text = desc28
        PictureBox1.Image = pic28
    End Sub

    Public Sub UpdateAll18(Bname29 As String, bauthor29 As String, pDate29 As String, desc29 As String, pic29 As Image)
        Label1.Text = Bname29
        Label2.Text = bauthor29
        Label3.Text = pDate29
        RichTextBox1.Text = desc29
        PictureBox1.Image = pic29
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

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PNL_TermsandCond.Visible = False

    End Sub
End Class
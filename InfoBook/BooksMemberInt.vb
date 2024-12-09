Public Class BooksMemberInt
    Private Sub BooksMemberInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub
    Private Sub Bt_LogoutMember_Click(sender As Object, e As EventArgs) Handles Bt_LogoutMember.Click
        PNL_LogoutMember.Visible = True


    End Sub

    Private Sub Btn_YesLogout_Click(sender As Object, e As EventArgs) Handles Btn_YesLogout.Click
        Dim Login As New LoginForm()
        Login.Show()

        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PNL_MemberBorrowBook.Visible = True

    End Sub

    Private Sub Bt_BackMember_Click(sender As Object, e As EventArgs) Handles Bt_BackMember.Click
        PNL_MemberBorrowBook.Visible = False

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        PNL_MemberBorrowBook.Visible = False
        PNL_BorrowDetails.Visible = True


    End Sub

    Private Sub Bt_BackMember1_Click(sender As Object, e As EventArgs) Handles Bt_BackMember1.Click
        PNL_MemberBorrowBook.Visible = True
        PNL_BorrowDetails.Visible = False

    End Sub

    Private Sub Bt_BorrowMember_Click(sender As Object, e As EventArgs) Handles Bt_BorrowMember.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            MessageBox.Show("Borrowed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PNL_TermsandCond.Visible = True

    End Sub

    Private Sub Bt_BackBMTND_Click(sender As Object, e As EventArgs) Handles Bt_BackBMTND.Click
        PNL_TermsandCond.Visible = False
        PNL_MemberBorrowBook.Visible = True

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PNL_TermsandCond.Visible = False
        PNL_MemberBorrowBook.Visible = True


    End Sub

    Private Sub Bt_BooksMember_Click(sender As Object, e As EventArgs) Handles Bt_BooksMember.Click

    End Sub
End Class
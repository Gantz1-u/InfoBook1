Public Class books_p4
    Private p0 As books_int
    Private p1 As books_p1
    Private p2 As books_p2
    Private p3 As books_p3
    Private p4 As books_p4



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
End Class
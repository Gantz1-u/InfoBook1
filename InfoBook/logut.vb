Public Class logut
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()

        For Each openForm As Form In Application.OpenForms
            If openForm IsNot Me AndAlso Not TypeOf openForm Is LoginForm Then
                openForm.Hide()
            End If
        Next

        Dim loginFormInstance As LoginForm = Nothing

        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is LoginForm Then
                loginFormInstance = CType(openForm, LoginForm)
                Exit For
            End If
        Next

        If loginFormInstance Is Nothing Then
            loginFormInstance = New LoginForm()
        End If

        If Not loginFormInstance.Visible Then
            loginFormInstance.Show()
        End If
    End Sub
End Class
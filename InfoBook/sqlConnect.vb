Imports Microsoft.Data.SqlClient

Public Class sqlConnect
    ' Initialize connections for two databases
    Public BooksDBCon As New SqlConnection With {
        .ConnectionString = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Books;TrustServerCertificate=True"
    }

    Public AccountsDBCon As New SqlConnection With {
        .ConnectionString = "Server=DESKTOP-H54BSR0\SQLEXPRESS;User ID=sa;Password=12345678;Database=Accounts;TrustServerCertificate=True"
    }

    Public SQLCmd As SqlCommand

    ' Function to check if connection to Books database is working
    Public Function HasConnectionBooks() As Boolean
        Try
            BooksDBCon.Open()
            BooksDBCon.Close()
            Return True
        Catch ex As Exception
            MsgBox($"Books DB Connection failed: {ex.Message}", MsgBoxStyle.Critical, "SQL Connection Error")
            Return False
        End Try
    End Function

    ' Function to check if connection to Accounts database is working
    Public Function HasConnectionAccounts() As Boolean
        Try
            AccountsDBCon.Open()
            AccountsDBCon.Close()
            Return True
        Catch ex As Exception
            MsgBox($"Accounts DB Connection failed: {ex.Message}", MsgBoxStyle.Critical, "SQL Connection Error")
            Return False
        End Try
    End Function
End Class



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksAdmin1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Bt_Manage = New Guna.UI2.WinForms.Guna2Button()
        Bt_History = New Guna.UI2.WinForms.Guna2Button()
        Bt_Book = New Guna.UI2.WinForms.Guna2Button()
        Bt_logout = New Guna.UI2.WinForms.Guna2Button()
        Panel2 = New Panel()
        Label6 = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Bt_Manage
        ' 
        Bt_Manage.BackColor = Color.Transparent
        Bt_Manage.BorderRadius = 20
        Bt_Manage.CustomizableEdges = CustomizableEdges1
        Bt_Manage.DisabledState.BorderColor = Color.DarkGray
        Bt_Manage.DisabledState.CustomBorderColor = Color.DarkGray
        Bt_Manage.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Bt_Manage.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Bt_Manage.FillColor = Color.White
        Bt_Manage.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Bt_Manage.ForeColor = Color.Black
        Bt_Manage.Location = New Point(6, 78)
        Bt_Manage.Margin = New Padding(3, 2, 3, 2)
        Bt_Manage.Name = "Bt_Manage"
        Bt_Manage.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Bt_Manage.Size = New Size(134, 47)
        Bt_Manage.TabIndex = 9
        Bt_Manage.Text = "MANAGE"
        ' 
        ' Bt_History
        ' 
        Bt_History.BackColor = Color.Transparent
        Bt_History.BorderRadius = 20
        Bt_History.CustomizableEdges = CustomizableEdges3
        Bt_History.DisabledState.BorderColor = Color.DarkGray
        Bt_History.DisabledState.CustomBorderColor = Color.DarkGray
        Bt_History.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Bt_History.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Bt_History.FillColor = Color.White
        Bt_History.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Bt_History.ForeColor = Color.Black
        Bt_History.Location = New Point(6, 144)
        Bt_History.Margin = New Padding(3, 2, 3, 2)
        Bt_History.Name = "Bt_History"
        Bt_History.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Bt_History.Size = New Size(134, 47)
        Bt_History.TabIndex = 10
        Bt_History.Text = "HISTORY"
        ' 
        ' Bt_Book
        ' 
        Bt_Book.BackColor = Color.Transparent
        Bt_Book.BorderRadius = 20
        Bt_Book.CustomizableEdges = CustomizableEdges5
        Bt_Book.DisabledState.BorderColor = Color.DarkGray
        Bt_Book.DisabledState.CustomBorderColor = Color.DarkGray
        Bt_Book.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Bt_Book.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Bt_Book.FillColor = Color.White
        Bt_Book.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Bt_Book.ForeColor = Color.Black
        Bt_Book.Location = New Point(6, 19)
        Bt_Book.Margin = New Padding(3, 2, 3, 2)
        Bt_Book.Name = "Bt_Book"
        Bt_Book.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Bt_Book.Size = New Size(134, 47)
        Bt_Book.TabIndex = 7
        Bt_Book.Text = "BOOKS"
        ' 
        ' Bt_logout
        ' 
        Bt_logout.BackColor = Color.Transparent
        Bt_logout.BorderRadius = 20
        Bt_logout.CustomizableEdges = CustomizableEdges7
        Bt_logout.DisabledState.BorderColor = Color.DarkGray
        Bt_logout.DisabledState.CustomBorderColor = Color.DarkGray
        Bt_logout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Bt_logout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Bt_logout.FillColor = Color.White
        Bt_logout.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Bt_logout.ForeColor = Color.Black
        Bt_logout.Location = New Point(6, 208)
        Bt_logout.Margin = New Padding(3, 2, 3, 2)
        Bt_logout.Name = "Bt_logout"
        Bt_logout.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Bt_logout.Size = New Size(134, 47)
        Bt_logout.TabIndex = 11
        Bt_logout.Text = "LOG OUT"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.Returndetails
        Panel2.Controls.Add(Label6)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(885, 49)
        Panel2.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(340, 4)
        Label6.Name = "Label6"
        Label6.Size = New Size(205, 47)
        Label6.TabIndex = 2
        Label6.Text = "InfoBridge"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Bt_Book)
        Panel1.Controls.Add(Bt_History)
        Panel1.Controls.Add(Bt_Manage)
        Panel1.Controls.Add(Bt_logout)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(156, 483)
        Panel1.TabIndex = 17
        ' 
        ' BooksAdmin1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(168), CByte(131), CByte(93))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(885, 532)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        IsMdiContainer = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "BooksAdmin1"
        StartPosition = FormStartPosition.CenterScreen
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Bt_Manage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Bt_History As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Bt_Book As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Bt_logout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class

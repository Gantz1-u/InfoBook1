<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel2 = New Panel()
        Bt_SignIn = New Guna.UI2.WinForms.Guna2Button()
        LinkLabel1 = New LinkLabel()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(168), CByte(131), CByte(93))
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(Bt_SignIn)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(Guna2TextBox2)
        Panel2.Controls.Add(Guna2TextBox1)
        Panel2.Controls.Add(lblPassword)
        Panel2.Controls.Add(lblUsername)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 450)
        Panel2.TabIndex = 1
        ' 
        ' Bt_SignIn
        ' 
        Bt_SignIn.BackColor = Color.Transparent
        Bt_SignIn.BorderRadius = 20
        Bt_SignIn.CustomizableEdges = CustomizableEdges1
        Bt_SignIn.DisabledState.BorderColor = Color.DarkGray
        Bt_SignIn.DisabledState.CustomBorderColor = Color.DarkGray
        Bt_SignIn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Bt_SignIn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Bt_SignIn.FillColor = Color.FromArgb(CByte(191), CByte(188), CByte(188))
        Bt_SignIn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bt_SignIn.ForeColor = Color.Black
        Bt_SignIn.Location = New Point(448, 309)
        Bt_SignIn.Name = "Bt_SignIn"
        Bt_SignIn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Bt_SignIn.Size = New Size(112, 35)
        Bt_SignIn.TabIndex = 12
        Bt_SignIn.Text = "Sign In"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.FromArgb(CByte(158), CByte(138), CByte(255))
        LinkLabel1.Location = New Point(190, 309)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(141, 43)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "return to log in"
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BackColor = Color.Transparent
        Guna2TextBox2.BorderRadius = 20
        Guna2TextBox2.CustomizableEdges = CustomizableEdges3
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FillColor = Color.FromArgb(CByte(252), CByte(246), CByte(219))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F)
        Guna2TextBox2.ForeColor = Color.Black
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(311, 248)
        Guna2TextBox2.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderForeColor = Color.DimGray
        Guna2TextBox2.PlaceholderText = "Enter your Password"
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox2.Size = New Size(249, 46)
        Guna2TextBox2.TabIndex = 9
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BackColor = Color.Transparent
        Guna2TextBox1.BorderRadius = 20
        Guna2TextBox1.CustomizableEdges = CustomizableEdges5
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FillColor = Color.FromArgb(CByte(252), CByte(246), CByte(219))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F)
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(311, 185)
        Guna2TextBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderForeColor = Color.DimGray
        Guna2TextBox1.PlaceholderText = "Enter your Username"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TextBox1.Size = New Size(249, 46)
        Guna2TextBox1.TabIndex = 8
        ' 
        ' lblPassword
        ' 
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(182, 262)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(123, 32)
        lblPassword.TabIndex = 7
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(182, 200)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(131, 31)
        lblUsername.TabIndex = 6
        lblUsername.Text = "Username:"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignUp"
        Text = "SignUp"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Bt_SignIn As Guna.UI2.WinForms.Guna2Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        lblUsername = New Label()
        lblPassword = New Label()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Bt_Login = New Guna.UI2.WinForms.Guna2Button()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(552, 433)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(242, 63)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(552, 575)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(242, 63)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BackColor = Color.Transparent
        Guna2TextBox1.BorderRadius = 30
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
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
        Guna2TextBox1.Location = New Point(762, 421)
        Guna2TextBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderForeColor = Color.DimGray
        Guna2TextBox1.PlaceholderText = "Enter your Username"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(447, 75)
        Guna2TextBox1.TabIndex = 2
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BackColor = Color.Transparent
        Guna2TextBox2.BorderRadius = 30
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
        Guna2TextBox2.Location = New Point(762, 563)
        Guna2TextBox2.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderForeColor = Color.DimGray
        Guna2TextBox2.PlaceholderText = "Enter your Password"
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox2.Size = New Size(447, 75)
        Guna2TextBox2.TabIndex = 3
        ' 
        ' Bt_Login
        ' 
        Bt_Login.BackColor = Color.Transparent
        Bt_Login.BorderRadius = 30
        Bt_Login.CustomizableEdges = CustomizableEdges5
        Bt_Login.DisabledState.BorderColor = Color.DarkGray
        Bt_Login.DisabledState.CustomBorderColor = Color.DarkGray
        Bt_Login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Bt_Login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Bt_Login.FillColor = Color.FromArgb(CByte(191), CByte(188), CByte(188))
        Bt_Login.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bt_Login.ForeColor = Color.Black
        Bt_Login.Location = New Point(984, 690)
        Bt_Login.Name = "Bt_Login"
        Bt_Login.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Bt_Login.Size = New Size(225, 59)
        Bt_Login.TabIndex = 4
        Bt_Login.Text = "Log in"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.FromArgb(CByte(158), CByte(138), CByte(255))
        LinkLabel1.Location = New Point(552, 701)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(206, 48)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "sign up"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(168), CByte(131), CByte(93))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1080)
        ControlBox = False
        Controls.Add(LinkLabel1)
        Controls.Add(Bt_Login)
        Controls.Add(Guna2TextBox2)
        Controls.Add(Guna2TextBox1)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Bt_Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookDetails))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PNL_TermsandCond = New Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Bt_BackBMTND = New Guna.UI2.WinForms.Guna2Button()
        SqlCommandBuilder1 = New Microsoft.Data.SqlClient.SqlCommandBuilder()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RichTextBox1 = New RichTextBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        CheckBox1 = New CheckBox()
        PNL_TermsandCond.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PNL_TermsandCond
        ' 
        PNL_TermsandCond.BackgroundImage = CType(resources.GetObject("PNL_TermsandCond.BackgroundImage"), Image)
        PNL_TermsandCond.BackgroundImageLayout = ImageLayout.Stretch
        PNL_TermsandCond.Controls.Add(Guna2Button1)
        PNL_TermsandCond.Controls.Add(Bt_BackBMTND)
        PNL_TermsandCond.Location = New Point(198, 21)
        PNL_TermsandCond.Margin = New Padding(3, 2, 3, 2)
        PNL_TermsandCond.Name = "PNL_TermsandCond"
        PNL_TermsandCond.Size = New Size(65, 66)
        PNL_TermsandCond.TabIndex = 2
        PNL_TermsandCond.Visible = False
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.BorderRadius = 20
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Gray
        Guna2Button1.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold)
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(191, 407)
        Guna2Button1.Margin = New Padding(3, 2, 3, 2)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(137, 31)
        Guna2Button1.TabIndex = 1
        Guna2Button1.Text = "Ok"
        ' 
        ' Bt_BackBMTND
        ' 
        Bt_BackBMTND.BackColor = Color.Transparent
        Bt_BackBMTND.CustomizableEdges = CustomizableEdges3
        Bt_BackBMTND.DisabledState.BorderColor = Color.DarkGray
        Bt_BackBMTND.DisabledState.CustomBorderColor = Color.DarkGray
        Bt_BackBMTND.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Bt_BackBMTND.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Bt_BackBMTND.FillColor = Color.FromArgb(CByte(252), CByte(246), CByte(219))
        Bt_BackBMTND.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bt_BackBMTND.ForeColor = Color.Black
        Bt_BackBMTND.Location = New Point(859, 538)
        Bt_BackBMTND.Margin = New Padding(3, 2, 3, 2)
        Bt_BackBMTND.Name = "Bt_BackBMTND"
        Bt_BackBMTND.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Bt_BackBMTND.Size = New Size(124, 38)
        Bt_BackBMTND.TabIndex = 0
        Bt_BackBMTND.Text = "Back"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Ph_history
        PictureBox1.Location = New Point(39, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(164, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 37)
        Label1.TabIndex = 13
        Label1.Text = "NAME OF THE BOOK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(169, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 14
        Label2.Text = "AUTHOR"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(169, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(212, 25)
        Label3.TabIndex = 15
        Label3.Text = "DATE OF PUBLISHMENT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(271, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 37)
        Label4.TabIndex = 16
        Label4.Text = "DESCRIPTION"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.ScrollBar
        RichTextBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(39, 229)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(638, 126)
        RichTextBox1.TabIndex = 18
        RichTextBox1.Text = ""
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BackColor = Color.Transparent
        Guna2Button2.BorderRadius = 20
        Guna2Button2.CustomizableEdges = CustomizableEdges5
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = SystemColors.Control
        Guna2Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.Black
        Guna2Button2.Location = New Point(284, 394)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button2.Size = New Size(180, 45)
        Guna2Button2.TabIndex = 19
        Guna2Button2.Text = "BORROW"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.SteelBlue
        CheckBox1.Location = New Point(51, 380)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(136, 17)
        CheckBox1.TabIndex = 20
        CheckBox1.Text = "Terms and Condtions"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' BookDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = My.Resources.Resources.Returndetails
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(844, 495)
        ControlBox = False
        Controls.Add(PNL_TermsandCond)
        Controls.Add(CheckBox1)
        Controls.Add(Guna2Button2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "BookDetails"
        StartPosition = FormStartPosition.CenterScreen
        PNL_TermsandCond.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PNL_TermsandCond As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Bt_BackBMTND As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SqlCommandBuilder1 As Microsoft.Data.SqlClient.SqlCommandBuilder
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CheckBox1 As CheckBox
End Class

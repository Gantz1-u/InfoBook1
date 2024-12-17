<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logut
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
        Label1 = New Label()
        Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(140, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 50)
        Label1.TabIndex = 15
        Label1.Text = "DO YOU WANT TO LOGOUT?"
        ' 
        ' Guna2Button4
        ' 
        Guna2Button4.BackColor = Color.Transparent
        Guna2Button4.BorderRadius = 20
        Guna2Button4.CustomizableEdges = CustomizableEdges1
        Guna2Button4.DisabledState.BorderColor = Color.DarkGray
        Guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button4.FillColor = Color.Gray
        Guna2Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button4.ForeColor = Color.Black
        Guna2Button4.Location = New Point(451, 246)
        Guna2Button4.Name = "Guna2Button4"
        Guna2Button4.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button4.Size = New Size(133, 35)
        Guna2Button4.TabIndex = 14
        Guna2Button4.Text = "CANCEL"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.Transparent
        Guna2Button3.BorderRadius = 20
        Guna2Button3.CustomizableEdges = CustomizableEdges3
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.Gray
        Guna2Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button3.ForeColor = Color.Black
        Guna2Button3.Location = New Point(184, 246)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button3.Size = New Size(133, 35)
        Guna2Button3.TabIndex = 13
        Guna2Button3.Text = "YES"
        ' 
        ' logut
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Returndetails
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Guna2Button4)
        Controls.Add(Guna2Button3)
        FormBorderStyle = FormBorderStyle.None
        Name = "logut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "logut"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class

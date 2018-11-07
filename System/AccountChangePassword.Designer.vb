<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountChangePassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConfirmNewPW = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewPW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnChangePW = New System.Windows.Forms.Button()
        Me.txtCurrentPW = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCurrentPWInfo = New System.Windows.Forms.Label()
        Me.lblNewPWInfo = New System.Windows.Forms.Label()
        Me.lblConfirmNewPWInfo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtConfirmNewPW)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNewPW)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnChangePW)
        Me.GroupBox1.Controls.Add(Me.txtCurrentPW)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 269)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password"
        '
        'txtConfirmNewPW
        '
        Me.txtConfirmNewPW.Location = New System.Drawing.Point(6, 199)
        Me.txtConfirmNewPW.MaxLength = 16
        Me.txtConfirmNewPW.Name = "txtConfirmNewPW"
        Me.txtConfirmNewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmNewPW.Size = New System.Drawing.Size(235, 26)
        Me.txtConfirmNewPW.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm New Password"
        '
        'txtNewPW
        '
        Me.txtNewPW.Location = New System.Drawing.Point(6, 150)
        Me.txtNewPW.MaxLength = 16
        Me.txtNewPW.Name = "txtNewPW"
        Me.txtNewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPW.Size = New System.Drawing.Size(235, 26)
        Me.txtNewPW.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "New Password"
        '
        'btnChangePW
        '
        Me.btnChangePW.Location = New System.Drawing.Point(6, 232)
        Me.btnChangePW.Name = "btnChangePW"
        Me.btnChangePW.Size = New System.Drawing.Size(235, 31)
        Me.btnChangePW.TabIndex = 3
        Me.btnChangePW.Text = "Change Password"
        Me.btnChangePW.UseVisualStyleBackColor = True
        '
        'txtCurrentPW
        '
        Me.txtCurrentPW.Location = New System.Drawing.Point(6, 98)
        Me.txtCurrentPW.MaxLength = 16
        Me.txtCurrentPW.Name = "txtCurrentPW"
        Me.txtCurrentPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPW.Size = New System.Drawing.Size(235, 26)
        Me.txtCurrentPW.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(6, 45)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(235, 26)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Old Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'lblCurrentPWInfo
        '
        Me.lblCurrentPWInfo.AutoSize = True
        Me.lblCurrentPWInfo.Location = New System.Drawing.Point(525, 235)
        Me.lblCurrentPWInfo.Name = "lblCurrentPWInfo"
        Me.lblCurrentPWInfo.Size = New System.Drawing.Size(140, 20)
        Me.lblCurrentPWInfo.TabIndex = 6
        Me.lblCurrentPWInfo.Text = "(lblCurrentPWInfo)"
        '
        'lblNewPWInfo
        '
        Me.lblNewPWInfo.AutoSize = True
        Me.lblNewPWInfo.Location = New System.Drawing.Point(525, 286)
        Me.lblNewPWInfo.Name = "lblNewPWInfo"
        Me.lblNewPWInfo.Size = New System.Drawing.Size(118, 20)
        Me.lblNewPWInfo.TabIndex = 7
        Me.lblNewPWInfo.Text = "(lblNewPWInfo)"
        '
        'lblConfirmNewPWInfo
        '
        Me.lblConfirmNewPWInfo.AutoSize = True
        Me.lblConfirmNewPWInfo.Location = New System.Drawing.Point(525, 337)
        Me.lblConfirmNewPWInfo.Name = "lblConfirmNewPWInfo"
        Me.lblConfirmNewPWInfo.Size = New System.Drawing.Size(173, 20)
        Me.lblConfirmNewPWInfo.TabIndex = 8
        Me.lblConfirmNewPWInfo.Text = "(lblConfirmNewPWInfo)"
        '
        'AccountChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 537)
        Me.Controls.Add(Me.lblConfirmNewPWInfo)
        Me.Controls.Add(Me.lblNewPWInfo)
        Me.Controls.Add(Me.lblCurrentPWInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AccountChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AccountChangePassword"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmNewPW As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewPW As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnChangePW As System.Windows.Forms.Button
    Friend WithEvents txtCurrentPW As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentPWInfo As System.Windows.Forms.Label
    Friend WithEvents lblNewPWInfo As System.Windows.Forms.Label
    Friend WithEvents lblConfirmNewPWInfo As System.Windows.Forms.Label
End Class

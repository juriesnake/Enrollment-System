<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCreateNew
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
        Me.rdoEmployee = New System.Windows.Forms.RadioButton()
        Me.rdoAdministrator = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConfirmPW = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsernameInfo = New System.Windows.Forms.Label()
        Me.lblAccessTypeInfo = New System.Windows.Forms.Label()
        Me.lblPWInfo = New System.Windows.Forms.Label()
        Me.lblConfirmPWInfo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoEmployee)
        Me.GroupBox1.Controls.Add(Me.rdoAdministrator)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPW)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPW)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnCreateNew)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 269)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Account"
        '
        'rdoEmployee
        '
        Me.rdoEmployee.AutoSize = True
        Me.rdoEmployee.Checked = True
        Me.rdoEmployee.Location = New System.Drawing.Point(137, 97)
        Me.rdoEmployee.Name = "rdoEmployee"
        Me.rdoEmployee.Size = New System.Drawing.Size(71, 17)
        Me.rdoEmployee.TabIndex = 11
        Me.rdoEmployee.TabStop = True
        Me.rdoEmployee.Text = "Employee"
        Me.rdoEmployee.UseVisualStyleBackColor = True
        '
        'rdoAdministrator
        '
        Me.rdoAdministrator.AutoSize = True
        Me.rdoAdministrator.Location = New System.Drawing.Point(10, 97)
        Me.rdoAdministrator.Name = "rdoAdministrator"
        Me.rdoAdministrator.Size = New System.Drawing.Size(85, 17)
        Me.rdoAdministrator.TabIndex = 10
        Me.rdoAdministrator.TabStop = True
        Me.rdoAdministrator.Text = "Administrator"
        Me.rdoAdministrator.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Access Type"
        '
        'txtConfirmPW
        '
        Me.txtConfirmPW.Location = New System.Drawing.Point(6, 200)
        Me.txtConfirmPW.MaxLength = 16
        Me.txtConfirmPW.Name = "txtConfirmPW"
        Me.txtConfirmPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPW.Size = New System.Drawing.Size(235, 26)
        Me.txtConfirmPW.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm Password"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(6, 149)
        Me.txtPW.MaxLength = 16
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(235, 26)
        Me.txtPW.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'btnCreateNew
        '
        Me.btnCreateNew.Location = New System.Drawing.Point(6, 232)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(235, 31)
        Me.btnCreateNew.TabIndex = 3
        Me.btnCreateNew.Text = "Create New Account"
        Me.btnCreateNew.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(6, 45)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(235, 26)
        Me.txtUsername.TabIndex = 1
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
        'lblUsernameInfo
        '
        Me.lblUsernameInfo.AutoSize = True
        Me.lblUsernameInfo.Location = New System.Drawing.Point(525, 182)
        Me.lblUsernameInfo.Name = "lblUsernameInfo"
        Me.lblUsernameInfo.Size = New System.Drawing.Size(136, 20)
        Me.lblUsernameInfo.TabIndex = 7
        Me.lblUsernameInfo.Text = "(lblUsernameInfo)"
        '
        'lblAccessTypeInfo
        '
        Me.lblAccessTypeInfo.AutoSize = True
        Me.lblAccessTypeInfo.Location = New System.Drawing.Point(525, 229)
        Me.lblAccessTypeInfo.Name = "lblAccessTypeInfo"
        Me.lblAccessTypeInfo.Size = New System.Drawing.Size(148, 20)
        Me.lblAccessTypeInfo.TabIndex = 8
        Me.lblAccessTypeInfo.Text = "(lblAccessTypeInfo)"
        '
        'lblPWInfo
        '
        Me.lblPWInfo.AutoSize = True
        Me.lblPWInfo.Location = New System.Drawing.Point(525, 289)
        Me.lblPWInfo.Name = "lblPWInfo"
        Me.lblPWInfo.Size = New System.Drawing.Size(87, 20)
        Me.lblPWInfo.TabIndex = 9
        Me.lblPWInfo.Text = "(lblPWInfo)"
        '
        'lblConfirmPWInfo
        '
        Me.lblConfirmPWInfo.AutoSize = True
        Me.lblConfirmPWInfo.Location = New System.Drawing.Point(525, 334)
        Me.lblConfirmPWInfo.Name = "lblConfirmPWInfo"
        Me.lblConfirmPWInfo.Size = New System.Drawing.Size(142, 20)
        Me.lblConfirmPWInfo.TabIndex = 10
        Me.lblConfirmPWInfo.Text = "(lblConfirmPWInfo)"
        '
        'AccountCreateNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 537)
        Me.Controls.Add(Me.lblConfirmPWInfo)
        Me.Controls.Add(Me.lblPWInfo)
        Me.Controls.Add(Me.lblAccessTypeInfo)
        Me.Controls.Add(Me.lblUsernameInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AccountCreateNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AccountCreateNew"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPW As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCreateNew As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAdministrator As System.Windows.Forms.RadioButton
    Friend WithEvents lblUsernameInfo As System.Windows.Forms.Label
    Friend WithEvents lblAccessTypeInfo As System.Windows.Forms.Label
    Friend WithEvents lblPWInfo As System.Windows.Forms.Label
    Friend WithEvents lblConfirmPWInfo As System.Windows.Forms.Label
End Class

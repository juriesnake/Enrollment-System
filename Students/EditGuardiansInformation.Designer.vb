<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditGuardiansInformation
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGuardianCellphoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGuardianEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtGuardianAddress = New System.Windows.Forms.TextBox()
        Me.txtGuardiaName = New System.Windows.Forms.TextBox()
        Me.cboGuardianRelationship = New System.Windows.Forms.ComboBox()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(214, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Guardian Cellphone Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 20)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Guardian Email Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 20)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Guardian Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 20)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Guardian Relationship:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Guardian Name:"
        '
        'txtGuardianCellphoneNumber
        '
        Me.txtGuardianCellphoneNumber.Location = New System.Drawing.Point(232, 250)
        Me.txtGuardianCellphoneNumber.Name = "txtGuardianCellphoneNumber"
        Me.txtGuardianCellphoneNumber.Size = New System.Drawing.Size(220, 26)
        Me.txtGuardianCellphoneNumber.TabIndex = 75
        '
        'txtGuardianEmailAddress
        '
        Me.txtGuardianEmailAddress.Location = New System.Drawing.Point(232, 218)
        Me.txtGuardianEmailAddress.Name = "txtGuardianEmailAddress"
        Me.txtGuardianEmailAddress.Size = New System.Drawing.Size(220, 26)
        Me.txtGuardianEmailAddress.TabIndex = 76
        '
        'txtGuardianAddress
        '
        Me.txtGuardianAddress.Location = New System.Drawing.Point(232, 186)
        Me.txtGuardianAddress.Name = "txtGuardianAddress"
        Me.txtGuardianAddress.Size = New System.Drawing.Size(220, 26)
        Me.txtGuardianAddress.TabIndex = 77
        '
        'txtGuardiaName
        '
        Me.txtGuardiaName.Location = New System.Drawing.Point(232, 120)
        Me.txtGuardiaName.Name = "txtGuardiaName"
        Me.txtGuardiaName.Size = New System.Drawing.Size(220, 26)
        Me.txtGuardiaName.TabIndex = 79
        '
        'cboGuardianRelationship
        '
        Me.cboGuardianRelationship.FormattingEnabled = True
        Me.cboGuardianRelationship.Items.AddRange(New Object() {"Mother", "Father", "GrandMother", "GrandFather", "Aunt", "Uncle", "Sister", "Brother", "Cousin(male)", "Cousin(female)", "Neighbor(male)", "Neighbor(female)", "(others. pls specify)"})
        Me.cboGuardianRelationship.Location = New System.Drawing.Point(232, 152)
        Me.cboGuardianRelationship.Name = "cboGuardianRelationship"
        Me.cboGuardianRelationship.Size = New System.Drawing.Size(220, 28)
        Me.cboGuardianRelationship.TabIndex = 80
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(165, 20)
        Me.lblStudentNumber.TabIndex = 94
        Me.lblStudentNumber.Text = "(lblStudentNumber)"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(344, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 31)
        Me.btnSave.TabIndex = 93
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'EditGuardiansInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 282)
        Me.Controls.Add(Me.lblStudentNumber)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboGuardianRelationship)
        Me.Controls.Add(Me.txtGuardiaName)
        Me.Controls.Add(Me.txtGuardianAddress)
        Me.Controls.Add(Me.txtGuardianEmailAddress)
        Me.Controls.Add(Me.txtGuardianCellphoneNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditGuardiansInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Guardians Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGuardianCellphoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtGuardianEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtGuardianAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtGuardiaName As System.Windows.Forms.TextBox
    Friend WithEvents cboGuardianRelationship As System.Windows.Forms.ComboBox
    Friend WithEvents lblStudentNumber As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class

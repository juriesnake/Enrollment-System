<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabStudentInformation = New System.Windows.Forms.TabPage()
        Me.lblEditBasicInformation = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblRegistrationDate = New System.Windows.Forms.Label()
        Me.lblParentMaritalStatus = New System.Windows.Forms.Label()
        Me.lblHealthProblem = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabGuardianInformation = New System.Windows.Forms.TabPage()
        Me.lblEditGuardiansInformation = New System.Windows.Forms.Label()
        Me.lblGuardianCellphoneNumber = New System.Windows.Forms.Label()
        Me.lblGuardianEmailAddress = New System.Windows.Forms.Label()
        Me.lblGuardianAddress = New System.Windows.Forms.Label()
        Me.lblGuardianRelationship = New System.Windows.Forms.Label()
        Me.lblGuardianName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPaymentStatus = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblMethodOfPayment = New System.Windows.Forms.Label()
        Me.lblRegistrationDate1 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabStudentInformation.SuspendLayout()
        Me.tabGuardianInformation.SuspendLayout()
        Me.txtPaymentStatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstStudents
        '
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.ItemHeight = 20
        Me.lstStudents.Location = New System.Drawing.Point(12, 61)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(78, 464)
        Me.lstStudents.TabIndex = 0
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboYear.Location = New System.Drawing.Point(12, 27)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(78, 28)
        Me.cboYear.TabIndex = 34
        Me.cboYear.Text = "View as"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(100, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 31)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabStudentInformation)
        Me.TabControl1.Controls.Add(Me.tabGuardianInformation)
        Me.TabControl1.Controls.Add(Me.txtPaymentStatus)
        Me.TabControl1.Location = New System.Drawing.Point(96, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(682, 464)
        Me.TabControl1.TabIndex = 36
        '
        'tabStudentInformation
        '
        Me.tabStudentInformation.Controls.Add(Me.lblEditBasicInformation)
        Me.tabStudentInformation.Controls.Add(Me.lblStatus)
        Me.tabStudentInformation.Controls.Add(Me.lblRegistrationDate)
        Me.tabStudentInformation.Controls.Add(Me.lblParentMaritalStatus)
        Me.tabStudentInformation.Controls.Add(Me.lblHealthProblem)
        Me.tabStudentInformation.Controls.Add(Me.lblBirthDate)
        Me.tabStudentInformation.Controls.Add(Me.lblSex)
        Me.tabStudentInformation.Controls.Add(Me.lblAddress)
        Me.tabStudentInformation.Controls.Add(Me.lblMiddleName)
        Me.tabStudentInformation.Controls.Add(Me.lblFirstName)
        Me.tabStudentInformation.Controls.Add(Me.lblLastName)
        Me.tabStudentInformation.Controls.Add(Me.Label18)
        Me.tabStudentInformation.Controls.Add(Me.Label13)
        Me.tabStudentInformation.Controls.Add(Me.Label16)
        Me.tabStudentInformation.Controls.Add(Me.Label15)
        Me.tabStudentInformation.Controls.Add(Me.Label6)
        Me.tabStudentInformation.Controls.Add(Me.Label5)
        Me.tabStudentInformation.Controls.Add(Me.Label4)
        Me.tabStudentInformation.Controls.Add(Me.Label3)
        Me.tabStudentInformation.Controls.Add(Me.Label2)
        Me.tabStudentInformation.Controls.Add(Me.Label1)
        Me.tabStudentInformation.Location = New System.Drawing.Point(4, 29)
        Me.tabStudentInformation.Name = "tabStudentInformation"
        Me.tabStudentInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStudentInformation.Size = New System.Drawing.Size(674, 431)
        Me.tabStudentInformation.TabIndex = 0
        Me.tabStudentInformation.Text = "Basic Information"
        Me.tabStudentInformation.UseVisualStyleBackColor = True
        '
        'lblEditBasicInformation
        '
        Me.lblEditBasicInformation.AutoSize = True
        Me.lblEditBasicInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditBasicInformation.Location = New System.Drawing.Point(493, 408)
        Me.lblEditBasicInformation.Name = "lblEditBasicInformation"
        Me.lblEditBasicInformation.Size = New System.Drawing.Size(175, 20)
        Me.lblEditBasicInformation.TabIndex = 65
        Me.lblEditBasicInformation.Text = "(Edit Basic Information)"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(227, 294)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(120, 20)
        Me.lblStatus.TabIndex = 64
        Me.lblStatus.Text = "(lblLastName)"
        '
        'lblRegistrationDate
        '
        Me.lblRegistrationDate.AutoSize = True
        Me.lblRegistrationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationDate.Location = New System.Drawing.Point(227, 265)
        Me.lblRegistrationDate.Name = "lblRegistrationDate"
        Me.lblRegistrationDate.Size = New System.Drawing.Size(120, 20)
        Me.lblRegistrationDate.TabIndex = 63
        Me.lblRegistrationDate.Text = "(lblLastName)"
        '
        'lblParentMaritalStatus
        '
        Me.lblParentMaritalStatus.AutoSize = True
        Me.lblParentMaritalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentMaritalStatus.Location = New System.Drawing.Point(227, 233)
        Me.lblParentMaritalStatus.Name = "lblParentMaritalStatus"
        Me.lblParentMaritalStatus.Size = New System.Drawing.Size(120, 20)
        Me.lblParentMaritalStatus.TabIndex = 62
        Me.lblParentMaritalStatus.Text = "(lblLastName)"
        '
        'lblHealthProblem
        '
        Me.lblHealthProblem.AutoSize = True
        Me.lblHealthProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthProblem.Location = New System.Drawing.Point(227, 201)
        Me.lblHealthProblem.Name = "lblHealthProblem"
        Me.lblHealthProblem.Size = New System.Drawing.Size(120, 20)
        Me.lblHealthProblem.TabIndex = 61
        Me.lblHealthProblem.Text = "(lblLastName)"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(227, 169)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(120, 20)
        Me.lblBirthDate.TabIndex = 60
        Me.lblBirthDate.Text = "(lblLastName)"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(227, 137)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(120, 20)
        Me.lblSex.TabIndex = 59
        Me.lblSex.Text = "(lblLastName)"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(227, 105)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(120, 20)
        Me.lblAddress.TabIndex = 58
        Me.lblAddress.Text = "(lblLastName)"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(227, 73)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(120, 20)
        Me.lblMiddleName.TabIndex = 57
        Me.lblMiddleName.Text = "(lblLastName)"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(227, 41)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(121, 20)
        Me.lblFirstName.TabIndex = 56
        Me.lblFirstName.Text = "(lblFirstName)"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(227, 9)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(120, 20)
        Me.lblLastName.TabIndex = 37
        Me.lblLastName.Text = "(lblLastName)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(83, 265)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(138, 20)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Registration Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(161, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Status:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(149, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Address:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(116, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Middle Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Parent Marital Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Health Problem:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Birth Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Sex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Last Name:"
        '
        'tabGuardianInformation
        '
        Me.tabGuardianInformation.Controls.Add(Me.lblEditGuardiansInformation)
        Me.tabGuardianInformation.Controls.Add(Me.lblGuardianCellphoneNumber)
        Me.tabGuardianInformation.Controls.Add(Me.lblGuardianEmailAddress)
        Me.tabGuardianInformation.Controls.Add(Me.lblGuardianAddress)
        Me.tabGuardianInformation.Controls.Add(Me.lblGuardianRelationship)
        Me.tabGuardianInformation.Controls.Add(Me.lblGuardianName)
        Me.tabGuardianInformation.Controls.Add(Me.Label11)
        Me.tabGuardianInformation.Controls.Add(Me.Label10)
        Me.tabGuardianInformation.Controls.Add(Me.Label9)
        Me.tabGuardianInformation.Controls.Add(Me.Label8)
        Me.tabGuardianInformation.Controls.Add(Me.Label7)
        Me.tabGuardianInformation.Location = New System.Drawing.Point(4, 29)
        Me.tabGuardianInformation.Name = "tabGuardianInformation"
        Me.tabGuardianInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGuardianInformation.Size = New System.Drawing.Size(674, 431)
        Me.tabGuardianInformation.TabIndex = 1
        Me.tabGuardianInformation.Text = "Guardian Information"
        Me.tabGuardianInformation.UseVisualStyleBackColor = True
        '
        'lblEditGuardiansInformation
        '
        Me.lblEditGuardiansInformation.AutoSize = True
        Me.lblEditGuardiansInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditGuardiansInformation.Location = New System.Drawing.Point(455, 408)
        Me.lblEditGuardiansInformation.Name = "lblEditGuardiansInformation"
        Me.lblEditGuardiansInformation.Size = New System.Drawing.Size(213, 20)
        Me.lblEditGuardiansInformation.TabIndex = 70
        Me.lblEditGuardiansInformation.Text = "(Edit Guardian's Information)"
        '
        'lblGuardianCellphoneNumber
        '
        Me.lblGuardianCellphoneNumber.AutoSize = True
        Me.lblGuardianCellphoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardianCellphoneNumber.Location = New System.Drawing.Point(226, 137)
        Me.lblGuardianCellphoneNumber.Name = "lblGuardianCellphoneNumber"
        Me.lblGuardianCellphoneNumber.Size = New System.Drawing.Size(120, 20)
        Me.lblGuardianCellphoneNumber.TabIndex = 69
        Me.lblGuardianCellphoneNumber.Text = "(lblLastName)"
        '
        'lblGuardianEmailAddress
        '
        Me.lblGuardianEmailAddress.AutoSize = True
        Me.lblGuardianEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardianEmailAddress.Location = New System.Drawing.Point(226, 105)
        Me.lblGuardianEmailAddress.Name = "lblGuardianEmailAddress"
        Me.lblGuardianEmailAddress.Size = New System.Drawing.Size(120, 20)
        Me.lblGuardianEmailAddress.TabIndex = 68
        Me.lblGuardianEmailAddress.Text = "(lblLastName)"
        '
        'lblGuardianAddress
        '
        Me.lblGuardianAddress.AutoSize = True
        Me.lblGuardianAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardianAddress.Location = New System.Drawing.Point(226, 73)
        Me.lblGuardianAddress.Name = "lblGuardianAddress"
        Me.lblGuardianAddress.Size = New System.Drawing.Size(120, 20)
        Me.lblGuardianAddress.TabIndex = 67
        Me.lblGuardianAddress.Text = "(lblLastName)"
        '
        'lblGuardianRelationship
        '
        Me.lblGuardianRelationship.AutoSize = True
        Me.lblGuardianRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardianRelationship.Location = New System.Drawing.Point(226, 41)
        Me.lblGuardianRelationship.Name = "lblGuardianRelationship"
        Me.lblGuardianRelationship.Size = New System.Drawing.Size(120, 20)
        Me.lblGuardianRelationship.TabIndex = 66
        Me.lblGuardianRelationship.Text = "(lblLastName)"
        '
        'lblGuardianName
        '
        Me.lblGuardianName.AutoSize = True
        Me.lblGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardianName.Location = New System.Drawing.Point(226, 9)
        Me.lblGuardianName.Name = "lblGuardianName"
        Me.lblGuardianName.Size = New System.Drawing.Size(120, 20)
        Me.lblGuardianName.TabIndex = 65
        Me.lblGuardianName.Text = "(lblLastName)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(214, 20)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Guardian Cellphone Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Guardian Email Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Guardian Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Guardian Relationship:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Guardian Name:"
        '
        'txtPaymentStatus
        '
        Me.txtPaymentStatus.Controls.Add(Me.GroupBox1)
        Me.txtPaymentStatus.Controls.Add(Me.lblBalance)
        Me.txtPaymentStatus.Controls.Add(Me.lblMethodOfPayment)
        Me.txtPaymentStatus.Controls.Add(Me.lblRegistrationDate1)
        Me.txtPaymentStatus.Controls.Add(Me.lblStatus1)
        Me.txtPaymentStatus.Controls.Add(Me.Label19)
        Me.txtPaymentStatus.Controls.Add(Me.Label17)
        Me.txtPaymentStatus.Controls.Add(Me.Label12)
        Me.txtPaymentStatus.Controls.Add(Me.Label14)
        Me.txtPaymentStatus.Location = New System.Drawing.Point(4, 29)
        Me.txtPaymentStatus.Name = "txtPaymentStatus"
        Me.txtPaymentStatus.Size = New System.Drawing.Size(674, 431)
        Me.txtPaymentStatus.TabIndex = 2
        Me.txtPaymentStatus.Text = "Payment Status"
        Me.txtPaymentStatus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 283)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotes.Enabled = False
        Me.txtNotes.Location = New System.Drawing.Point(6, 25)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(648, 215)
        Me.txtNotes.TabIndex = 72
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(546, 246)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 31)
        Me.btnSave.TabIndex = 74
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(432, 246)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(108, 31)
        Me.btnEdit.TabIndex = 75
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(226, 105)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(120, 20)
        Me.lblBalance.TabIndex = 71
        Me.lblBalance.Text = "(lblLastName)"
        '
        'lblMethodOfPayment
        '
        Me.lblMethodOfPayment.AutoSize = True
        Me.lblMethodOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethodOfPayment.Location = New System.Drawing.Point(226, 73)
        Me.lblMethodOfPayment.Name = "lblMethodOfPayment"
        Me.lblMethodOfPayment.Size = New System.Drawing.Size(120, 20)
        Me.lblMethodOfPayment.TabIndex = 70
        Me.lblMethodOfPayment.Text = "(lblLastName)"
        '
        'lblRegistrationDate1
        '
        Me.lblRegistrationDate1.AutoSize = True
        Me.lblRegistrationDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationDate1.Location = New System.Drawing.Point(226, 41)
        Me.lblRegistrationDate1.Name = "lblRegistrationDate1"
        Me.lblRegistrationDate1.Size = New System.Drawing.Size(120, 20)
        Me.lblRegistrationDate1.TabIndex = 69
        Me.lblRegistrationDate1.Text = "(lblLastName)"
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.Location = New System.Drawing.Point(226, 9)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(120, 20)
        Me.lblStatus1.TabIndex = 68
        Me.lblStatus1.Text = "(lblLastName)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(82, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 20)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Registration Date:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(160, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 20)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Status:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 20)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Method of Payment:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(149, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 20)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Balance:"
        '
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 537)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.lstStudents)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Students"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "EnrollmentOldStudent"
        Me.TabControl1.ResumeLayout(False)
        Me.tabStudentInformation.ResumeLayout(False)
        Me.tabStudentInformation.PerformLayout()
        Me.tabGuardianInformation.ResumeLayout(False)
        Me.tabGuardianInformation.PerformLayout()
        Me.txtPaymentStatus.ResumeLayout(False)
        Me.txtPaymentStatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstStudents As System.Windows.Forms.ListBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabStudentInformation As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabGuardianInformation As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentStatus As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRegistrationDate As System.Windows.Forms.Label
    Friend WithEvents lblParentMaritalStatus As System.Windows.Forms.Label
    Friend WithEvents lblHealthProblem As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblGuardianCellphoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblGuardianEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblGuardianAddress As System.Windows.Forms.Label
    Friend WithEvents lblGuardianRelationship As System.Windows.Forms.Label
    Friend WithEvents lblGuardianName As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblMethodOfPayment As System.Windows.Forms.Label
    Friend WithEvents lblRegistrationDate1 As System.Windows.Forms.Label
    Friend WithEvents lblStatus1 As System.Windows.Forms.Label
    Friend WithEvents lblEditBasicInformation As System.Windows.Forms.Label
    Friend WithEvents lblEditGuardiansInformation As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class

Public Class EnrollmentNewStudent
    Dim sex, health, parentMaritalStatus, status, paymentType As String
    Dim numberOfStudents, balance As Integer
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LoadInitialValues()
    End Sub
    Private Sub LoadInitialValues()
        Try
            Dim tableSchoolData As New DataTable()
            Dim command As String
            Dim recordCount As Integer
            Dim adapter As OleDb.OleDbDataAdapter
            command = "select * from SchoolData where DataName='Full'"
            adapter = New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            tableSchoolData.Clear()
            recordCount = adapter.Fill(tableSchoolData)
            lblFull.Text = "P" & CStr(tableSchoolData.Rows(0)(1))
            command = "select * from SchoolData where DataName='DownPayment'"
            adapter = New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            tableSchoolData.Clear()
            recordCount = adapter.Fill(tableSchoolData)
            lblInstallment.Text = CStr(tableSchoolData.Rows(0)(1))

            command = "select * from SchoolData where DataName='DPMonthly'"
            adapter = New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            tableSchoolData.Clear()
            recordCount = adapter.Fill(tableSchoolData)
            lblInstallment.Text = "P" & lblInstallment.Text & " downpayment + 10x P" & CStr(tableSchoolData.Rows(0)(1)) & " monthly"
            balance = CInt(tableSchoolData.Rows(0)(1)) * 10
            command = "select * from SchoolData where DataName='" & Today.Year & "'"
            adapter = New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            tableSchoolData.Clear()
            recordCount = adapter.Fill(tableSchoolData)
            numberOfStudents = CInt(tableSchoolData.Rows(0)(1))
            txtStudentNumber.Text = Format(numberOfStudents + 1, "000") & "-" & CStr(Today.Year)

        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        End Try
        txtFirstName.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtAddress.Text = ""
        rdoMale.Checked = False
        rdoFemale.Checked = False
        dtpBirthDate.Value = Date.Now
        rdoNo.Checked = False
        rdoYes.Checked = False
        txtHealthProblem.Text = ""
        rdoMarried.Checked = False
        rdoSeparated.Checked = False
        rdoWidowed.Checked = False
        rdoSingle.Checked = False
        rdoNursery.Checked = False
        rdoKinderGarten.Checked = False
        rdoPreparatory.Checked = False
        txtGuardianName.Text = ""
        cboGuardianRelationship.Text = ""
        txtGuardianAddress.Text = ""
        txtGuardianEmail.Text = ""
        txtGuardianCellphone.Text = ""
        rdoFull.Checked = False
        rdoInstallment.Checked = False
        txtCash.Text = ""
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If InformationTest() = True Then
            AddStudent()
            UpdateSchoolData()
            LoadInitialValues()
            MessageBox.Show("Registration Succesfull", "Enrollment Status", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
    End Sub

    Private Function InformationTest() As Boolean
        If txtLastName.Text = "" Or txtFirstName.Text = "" Or txtMiddleName.Text = "" Then
            MessageBox.Show("Please fill student's name", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If txtAddress.Text = "" Then
            MessageBox.Show("Please fill student's address", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If rdoMale.Checked Then
            sex = "Male"
        ElseIf rdoFemale.Checked Then
            sex = "Female"
        Else
            MessageBox.Show("Please select student's sex or gender", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If rdoNo.Checked Then
            health = "No"
        ElseIf rdoYes.Checked And txtHealthProblem.Text <> "" Then
            health = txtHealthProblem.Text
        Else
            MessageBox.Show("Please specify is this child have any health problems", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If rdoMarried.Checked Then
            parentMaritalStatus = "Married"
        ElseIf rdoSeparated.Checked Then
            parentMaritalStatus = "Separated"
        ElseIf rdoWidowed.Checked Then
            parentMaritalStatus = "Widowed"
        ElseIf rdoSingle.Checked Then
            parentMaritalStatus = "Single"
        Else
            MessageBox.Show("Please select parents marital status", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If rdoNursery.Checked Then
            status = "Nursery"
        ElseIf rdoKinderGarten.Checked Then
            status = "KinderGarten"
        ElseIf rdoPreparatory.Checked Then
            status = "Preparatory"
        Else
            MessageBox.Show("Please select student's status", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If txtGuardianName.Text = "" Or cboGuardianRelationship.Text = "" Or txtGuardianAddress.Text = "" Then
            MessageBox.Show("Please fill guardian's information", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If rdoFull.Checked Then
            paymentType = "Full"
            balance = 0
        ElseIf rdoInstallment.Checked Then
            paymentType = "Installment"
        ElseIf rdoFull.Checked = False And rdoInstallment.Checked = False Then
            MessageBox.Show("Please select method of payment", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If (txtLastName.Text <> "" And txtFirstName.Text <> "" And txtMiddleName.Text <> "" And txtAddress.Text <> "" And txtGuardianName.Text <> "" And cboGuardianRelationship.Text <> "" And txtGuardianAddress.Text <> "") And (rdoNo.Checked Or (rdoYes.Checked And txtHealthProblem.Text <> "")) And (rdoMale.Checked Or rdoFemale.Checked) And (rdoMarried.Checked Or rdoSeparated.Checked Or rdoWidowed.Checked Or rdoSingle.Checked) And (rdoNursery.Checked Or rdoKinderGarten.Checked Or rdoPreparatory.Checked) And (rdoFull.Checked Or rdoInstallment.Checked) Then
            MessageBox.Show("Registration Successfull", "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AddStudent()
        Dim connection As New OleDb.OleDbConnection(modData.dbConnect)
        Dim oleDbInsertCommand = New OleDb.OleDbCommand()
        Dim command As String
        Dim adapter As New OleDb.OleDbDataAdapter()
        Try
            connection.Open()
            command = "insert into Students (StudentNumber, LastName, FirstName, MiddleName, Address, Sex, BirthDate, HealthProblem, ParentMaritalStatus, GuardianName, GuardianRelationship, GuardianAddress, GuardianEmail, GuardianCellphone, Status, RegistrationDate, RegistrationYear, PaymentType, Balance, Notes) values('" & txtStudentNumber.Text & "', '" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & txtAddress.Text & "', '" & sex & "', '" & dtpBirthDate.Value & "', '" & health & "', '" & parentMaritalStatus & "', '" & txtGuardianName.Text & "', '" & cboGuardianRelationship.Text & "', '" & txtGuardianAddress.Text & "', '" & txtGuardianEmail.Text & "', '" & txtGuardianCellphone.Text & "', '" & status & "', '" & Date.Now & "', '" & Date.Now.Year & "', '" & paymentType & "', '" & balance & "', '')"
            oleDbInsertCommand.Connection = connection
            oleDbInsertCommand.CommandText = command
            adapter.InsertCommand = oleDbInsertCommand
            ' do the insert
            adapter.InsertCommand.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub UpdateSchoolData()
        Dim connection As New OleDb.OleDbConnection(modData.dbConnect)
        Dim oleDbUpdateCommand = New OleDb.OleDbCommand()
        Dim x As Integer
        x = numberOfStudents + 1
        Try
            connection.Open()
            Dim adapter As New OleDb.OleDbDataAdapter()
            Dim command As String
            command = "update SchoolData set DataAmount='" & x & "' where DataName='" & CStr(Today.Year) & "'"
            oleDbUpdateCommand.Connection = connection
            oleDbUpdateCommand.CommandText = command
            adapter.UpdateCommand = oleDbUpdateCommand
            adapter.UpdateCommand.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub rdoNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNo.CheckedChanged
        txtHealthProblem.Enabled = False
        txtHealthProblem.Text = ""
    End Sub

    Private Sub rdoYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoYes.CheckedChanged
        txtHealthProblem.Enabled = True
    End Sub
End Class
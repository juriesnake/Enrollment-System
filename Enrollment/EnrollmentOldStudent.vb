Public Class EnrollmentOldStudent
    Dim health, parentMaritalStatus, status, paymentType As String
    Dim balance As Integer
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
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        End Try
        txtLastName.Text = ""
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
    Private Sub LoadStudentInfo()
        Try
            Dim tableStudents As New DataTable()
            Dim command As String
            Dim recordCount As Integer
            'set up an SQL query
            command = "select * from Students where StudentNumber = '" & txtStudentNumber.Text & "'"
            'create an adapter, incorporating a select command
            Dim adapter As New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            'do the query
            tableStudents.Clear()
            recordCount = adapter.Fill(tableStudents)
            'display any result
            If recordCount <> 0 Then ' we have a result
                txtLastName.Text = CStr(tableStudents.Rows(0)(1))
                txtFirstName.Text = CStr(tableStudents.Rows(0)(2))
                txtMiddleName.Text = CStr(tableStudents.Rows(0)(3))
                txtAddress.Text = CStr(tableStudents.Rows(0)(4))
                If CStr(tableStudents.Rows(0)(5)) = "Male" Then
                    rdoMale.Checked = True
                Else
                    rdoFemale.Checked = True
                End If
                dtpBirthDate.Value = CDate(tableStudents.Rows(0)(6))
                If CStr(tableStudents.Rows(0)(7)) = "No" Then
                    rdoNo.Checked = True
                Else
                    rdoYes.Checked = True
                    txtHealthProblem.Text = CStr(tableStudents.Rows(0)(7))
                End If
                If CStr(tableStudents.Rows(0)(8)) = "Married" Then
                    rdoMarried.Checked = True
                ElseIf CStr(tableStudents.Rows(0)(8)) = "Separated" Then
                    rdoSeparated.Checked = True
                ElseIf CStr(tableStudents.Rows(0)(8)) = "Widowed" Then
                    rdoWidowed.Checked = True
                Else
                    rdoSingle.Checked = True
                End If
                txtGuardianName.Text = CStr(tableStudents.Rows(0)(9))
                cboGuardianRelationship.Text = CStr(tableStudents.Rows(0)(10))
                txtGuardianAddress.Text = CStr(tableStudents.Rows(0)(11))
                txtGuardianEmail.Text = CStr(tableStudents.Rows(0)(12))
                txtGuardianCellphone.Text = CStr(tableStudents.Rows(0)(13))
                btnPrint.Enabled = True
                btnPrint.Enabled = True
            Else
                MessageBox.Show("Student Not Found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        End Try
    End Sub

    Private Sub txtStudentNumber_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNumber.Leave
        If txtStudentNumber.Text <> "" Then
            LoadStudentInfo()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If InformationTest() = True Then
            UpdateStudentInformation()
            MessageBox.Show("Enrollment Successful", "Enrollment Status", MessageBoxButtons.OK, MessageBoxIcon.None)
            ClearForm()
        End If
    End Sub
    Private Sub UpdateStudentInformation()
        Dim connection As New OleDb.OleDbConnection(modData.dbConnect)
        Dim oleDbUpdateCommand = New OleDb.OleDbCommand()
        Try
            connection.Open()
            Dim adapter As New OleDb.OleDbDataAdapter()
            Dim command As String
            'set up an SQL update, using text boxes
            command = "update Students set Address = '" & txtAddress.Text & "', " & "HealthProblem = '" & health & "', ParentMaritalStatus = '" & parentMaritalStatus & "', GuardianName = '" & txtGuardianName.Text & "', GuardianRelationship = '" & cboGuardianRelationship.Text & "', GuardianAddress = '" & txtGuardianAddress.Text & "', GuardianEmail = '" & txtGuardianEmail.Text & "', GuardianCellphone = '" & txtGuardianCellphone.Text & "', Status = '" & status & "', PaymentType = '" & paymentType & "', Balance = '" & balance & "' where StudentNumber = '" & txtStudentNumber.Text & "'"
            'put the update command in the adapter
            oleDbUpdateCommand.Connection = connection
            oleDbUpdateCommand.CommandText = command
            adapter.UpdateCommand = oleDbUpdateCommand
            'do the update
            adapter.UpdateCommand.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Function InformationTest() As Boolean
        If txtAddress.Text = "" Then
            MessageBox.Show("Please fill student's address", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        If (txtAddress.Text <> "" And txtGuardianName.Text <> "" And cboGuardianRelationship.Text <> "" And txtGuardianAddress.Text <> "") And (rdoNo.Checked Or (rdoYes.Checked And txtHealthProblem.Text <> "")) And (rdoMale.Checked Or rdoFemale.Checked) And (rdoMarried.Checked Or rdoSeparated.Checked Or rdoWidowed.Checked Or rdoSingle.Checked) And (rdoNursery.Checked Or rdoKinderGarten.Checked Or rdoPreparatory.Checked) And (rdoFull.Checked Or rdoInstallment.Checked) Then
            MessageBox.Show("Enrollment Successfull", "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ClearForm()
        txtStudentNumber.Text = ""
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadInitialValues()
    End Sub
    Private Sub rdoNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNo.CheckedChanged
        txtHealthProblem.Enabled = False
        txtHealthProblem.Text = ""
    End Sub

    Private Sub rdoYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoYes.CheckedChanged
        txtHealthProblem.Enabled = True
    End Sub
End Class
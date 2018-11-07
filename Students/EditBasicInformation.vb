Public Class EditBasicInformation
    Private tableStudents As New DataTable()
    Private command, newValue As String
    Private adapter As New OleDb.OleDbDataAdapter()
    Private connection As New OleDb.OleDbConnection()
    Private oleDbUpdateCommand As New OleDb.OleDbCommand()
    Public Sub UpdateBasicInformation()
        Try
            connection.Open()
            Dim adapter As New OleDb.OleDbDataAdapter()
            Dim command As String
            'set up an SQL update, using text boxes
            command = "update Students set LastName = '" & txtLastName.Text & "', FirstName = '" & txtFirstName.Text & "', MiddleName = '" & txtMiddleName.Text & "', Address = '" & txtAddress.Text & "', Sex = '" & cboSex.Text & "', BirthDate = '" & dtpBirthDate.Value & "', HealthProblem = '" & txtHealthProblem.Text & "', ParentMaritalStatus = '" & cboParentMaritalStatus.Text & "' where StudentNumber = '" & lblStudentNumber.Text & "'"
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
    Public Sub LoadBasicInformation()
        Try
            Dim recordCount As Integer
            'set up an SQL query
            command = "select * from Students where StudentNumber = '" & Students.lstStudents.Text & "'"
            'create an adapter, incorporating a select command
            Dim adapter As New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            'do the query
            tableStudents.Clear()
            recordCount = adapter.Fill(tableStudents)
            If recordCount <> 0 Then
                lblStudentNumber.Text = CStr(tableStudents.Rows(0)(0))
                txtLastName.Text = CStr(tableStudents.Rows(0)(1))
                txtFirstName.Text = CStr(tableStudents.Rows(0)(2))
                txtMiddleName.Text = CStr(tableStudents.Rows(0)(3))
                txtAddress.Text = CStr(tableStudents.Rows(0)(4))
                cboSex.Text = CStr(tableStudents.Rows(0)(5))
                dtpBirthDate.Value = CDate(tableStudents.Rows(0)(6))
                txtHealthProblem.Text = CStr(tableStudents.Rows(0)(7))
                cboParentMaritalStatus.Text = CStr(tableStudents.Rows(0)(8))
            End If
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        adapter = New OleDb.OleDbDataAdapter(command, modData.dbConnect)
        connection = New OleDb.OleDbConnection(modData.dbConnect)
        ' Add any initialization after the InitializeComponent() call.
        LoadBasicInformation()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        UpdateBasicInformation()
        LoadStudentData()
        Me.Close()
    End Sub

    Private Sub LoadStudentData()
        Students.lblLastName.Text = txtLastName.Text
        Students.lblFirstName.Text = txtFirstName.Text
        Students.lblMiddleName.Text = txtMiddleName.Text
        Students.lblAddress.Text = txtAddress.Text
        Students.lblSex.Text = cboSex.Text
        Students.lblBirthDate.Text = CStr(dtpBirthDate.Value.ToString("MMMM d yyyy") & " (Age: " & (DateDiff(DateInterval.Day, CDate(dtpBirthDate.Value), Date.Now) \ 365) & ")")
        Students.lblParentMaritalStatus.Text = cboParentMaritalStatus.Text
    End Sub
End Class
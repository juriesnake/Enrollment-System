Public Class EditGuardiansInformation
        Private tableStudents As New DataTable()
        Private command, newValue As String
        Private adapter As New OleDb.OleDbDataAdapter()
        Private connection As New OleDb.OleDbConnection()
        Private oleDbUpdateCommand As New OleDb.OleDbCommand()
    Public Sub UpdateGuardianInformation()
        Try
            connection.Open()
            Dim adapter As New OleDb.OleDbDataAdapter()
            Dim command As String
            'set up an SQL update, using text boxes
            command = "update Students set GuardianName = '" & txtGuardiaName.Text & "', GuardianRelationship = '" & cboGuardianRelationship.Text & "', GuardianAddress = '" & txtGuardianAddress.Text & "', GuardianEmail = '" & txtGuardianEmailAddress.Text & "', GuardianCellphone = '" & txtGuardianCellphoneNumber.Text & "' where StudentNumber = '" & lblStudentNumber.Text & "'"
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
    Public Sub LoadGuardianInformation()
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
                txtGuardiaName.Text = CStr(tableStudents.Rows(0)(9))
                cboGuardianRelationship.Text = CStr(tableStudents.Rows(0)(10))
                txtGuardianAddress.Text = CStr(tableStudents.Rows(0)(11))
                txtGuardianEmailAddress.Text = CStr(tableStudents.Rows(0)(12))
                txtGuardianCellphoneNumber.Text = CStr(tableStudents.Rows(0)(13))
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
        LoadGuardianInformation()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        UpdateGuardianInformation()
        LoadStudentData()
        Me.Close()
    End Sub

    Private Sub LoadStudentData()
        Students.lblGuardianName.Text = txtGuardiaName.Text
        Students.lblGuardianRelationship.Text = cboGuardianRelationship.Text
        Students.lblGuardianAddress.Text = txtGuardianAddress.Text
        Students.lblGuardianEmailAddress.Text = txtGuardianEmailAddress.Text
        Students.lblGuardianCellphoneNumber.Text = txtGuardianCellphoneNumber.Text
    End Sub
End Class
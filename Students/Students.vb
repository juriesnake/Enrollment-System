Imports Microsoft.VisualBasic.ControlChars
Public Class Students
    Private tableStudents As New DataTable()
    Private command, newValue As String
    Private adapter As New OleDb.OleDbDataAdapter()
    Private connection As New OleDb.OleDbConnection()
    Private oleDbUpdateCommand As New OleDb.OleDbCommand()

    Private Sub LoadListStudents()
        Try
            Dim recordCount As Integer
            'set up an SQL query
            If cboYear.Text = "View as" Then
                command = "select * from Students"
            Else
                command = "select * from Students where RegistrationYear = '" & cboYear.Text & "'"
            End If
            'create an adapter, incorporating a select command
            Dim adapter As New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            'do the query
            tableStudents.Clear()
            recordCount = adapter.Fill(tableStudents)
            lstStudents.Items.Clear()
            For x = 0 To recordCount - 1
                lstStudents.Items.Add(CStr(tableStudents.Rows(x)(0)))
            Next
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
        LoadListStudents()
        ClearData()
    End Sub

    Private Sub lstStudents_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstStudents.SelectedValueChanged
        Dim index As Integer = lstStudents.Items.IndexOf(lstStudents.Text)
        lblLastName.Text = CStr(tableStudents.Rows(index)(1))
        lblFirstName.Text = CStr(tableStudents.Rows(index)(2))
        lblMiddleName.Text = CStr(tableStudents.Rows(index)(3))
        lblAddress.Text = CStr(tableStudents.Rows(index)(4))
        lblSex.Text = CStr(tableStudents.Rows(index)(5))
        lblBirthDate.Text = CDate(tableStudents.Rows(index)(6)).ToString("MMMM d yyyy") & " (Age: " & (DateDiff(DateInterval.Day, CDate(tableStudents.Rows(index)(6)), Date.Now) \ 365) & ")"
        lblHealthProblem.Text = CStr(tableStudents.Rows(index)(7))
        lblParentMaritalStatus.Text = CStr(tableStudents.Rows(index)(8))
        lblRegistrationDate.Text = CStr(tableStudents.Rows(index)(15))
        lblStatus.Text = CStr(tableStudents.Rows(index)(14))
        lblGuardianName.Text = CStr(tableStudents.Rows(index)(9))
        lblGuardianRelationship.Text = CStr(tableStudents.Rows(index)(10))
        lblGuardianAddress.Text = CStr(tableStudents.Rows(index)(11))
        lblGuardianEmailAddress.Text = CStr(tableStudents.Rows(index)(12))
        lblGuardianCellphoneNumber.Text = CStr(tableStudents.Rows(index)(13))
        lblStatus1.Text = lblStatus.Text
        lblRegistrationDate1.Text = lblRegistrationDate.Text
        lblMethodOfPayment.Text = CStr(tableStudents.Rows(index)(17))
        lblBalance.Text = CStr(CInt(tableStudents.Rows(index)(18)))
        txtNotes.Text = CStr(tableStudents.Rows(index)(19))
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim recordCount As Integer
            'set up an SQL query
            command = "select * from Students where StudentNumber = '" & InputBox("StudentNumber") & "'"
            'create an adapter, incorporating a select command
            Dim adapter As New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            'do the query
            tableStudents.Clear()
            recordCount = adapter.Fill(tableStudents)
            If recordCount <> 0 Then
                lstStudents.Items.Clear()
                lstStudents.Items.Add(CStr(tableStudents.Rows(0)(0)))
                lstStudents.Text = CStr(tableStudents.Rows(0)(0))
                cboYear.Text = "View as"
            Else
                MessageBox.Show("Student not found")
            End If
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        End Try
    End Sub

    Private Sub cboYear_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedValueChanged
        lstStudents.Items.Clear()
        LoadListStudents()
        ClearData()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtNotes.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            connection.Open()
            Dim adapter As New OleDb.OleDbDataAdapter()
            Dim command As String
            'set up an SQL update, using text boxes
            command = "update Students set Notes = '" & txtNotes.Text & "' where StudentNumber = '" & lstStudents.Text & "'"
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

    Private Sub ClearData()
        lblLastName.Text = ""
        lblFirstName.Text = ""
        lblMiddleName.Text = ""
        lblAddress.Text = ""
        lblSex.Text = ""
        lblBirthDate.Text = ""
        lblHealthProblem.Text = ""
        lblParentMaritalStatus.Text = ""
        lblRegistrationDate.Text = ""
        lblStatus.Text = ""
        lblGuardianName.Text = ""
        lblGuardianRelationship.Text = ""
        lblGuardianAddress.Text = ""
        lblGuardianEmailAddress.Text = ""
        lblGuardianCellphoneNumber.Text = ""
        lblStatus1.Text = ""
        lblRegistrationDate1.Text = ""
        lblMethodOfPayment.Text = ""
        lblBalance.Text = ""
        txtNotes.Text = ""
    End Sub

    Private Sub lblEditBasicInformation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEditBasicInformation.DoubleClick
        EditBasicInformation.Show()
    End Sub

    Private Sub lblEditGuardiansInformation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEditGuardiansInformation.DoubleClick
        EditGuardiansInformation.Show()
    End Sub
End Class
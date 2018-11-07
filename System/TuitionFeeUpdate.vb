Public Class TuitionFeeUpdate
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadInitialValues()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        UpdateTuitionFee()
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
            txtFull.Text = CStr(tableSchoolData.Rows(0)(1))
            command = "select * from SchoolData where DataName='DownPayment'"
            adapter = New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            tableSchoolData.Clear()
            recordCount = adapter.Fill(tableSchoolData)
            txtDownPayment.Text = CStr(tableSchoolData.Rows(0)(1))

            command = "select * from SchoolData where DataName='DPMonthly'"
            adapter = New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            tableSchoolData.Clear()
            recordCount = adapter.Fill(tableSchoolData)
            txtMonthly.Text = CStr(tableSchoolData.Rows(0)(1))
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        End Try
    End Sub

    Private Sub UpdateTuitionFee()
        Dim connection As New OleDb.OleDbConnection(modData.dbConnect)
        Dim oleDbUpdateCommand = New OleDb.OleDbCommand()
        Try
            connection.Open()
            Dim adapter As New OleDb.OleDbDataAdapter()
            Dim command As String
            command = "update SchoolData set DataAmount='" & CInt(txtFull.Text) & "' where DataName='Full'"
            oleDbUpdateCommand.Connection = connection
            oleDbUpdateCommand.CommandText = command
            adapter.UpdateCommand = oleDbUpdateCommand
            adapter.UpdateCommand.ExecuteNonQuery()
            command = "update SchoolData set DataAmount='" & CInt(txtDownPayment.Text) & "' where DataName='Downpayment'"
            oleDbUpdateCommand.Connection = connection
            oleDbUpdateCommand.CommandText = command
            adapter.UpdateCommand = oleDbUpdateCommand
            adapter.UpdateCommand.ExecuteNonQuery()
            command = "update SchoolData set DataAmount='" & CInt(txtMonthly.Text) & "' where DataName='DPMonthly'"
            oleDbUpdateCommand.Connection = connection
            oleDbUpdateCommand.CommandText = command
            adapter.UpdateCommand = oleDbUpdateCommand
            adapter.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Tuition Fee Updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
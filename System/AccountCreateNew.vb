Public Class AccountCreateNew
    Private dbInfo As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=resources\dbSchool.mdb"

    Private Sub btnCreateNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNew.Click
        If SearchExisting() = False And txtUsername.Text <> "" And txtPW.Text <> "" And txtPW.Text = txtConfirmPW.Text Then
            NewAccount()
            MessageBox.Show("Succesfull")
            Me.Close()
        End If
        If SearchExisting() = True Then
            lblUsernameInfo.Text = "Username already exist"
        ElseIf txtUsername.Text = "" Then
            lblUsernameInfo.Text = "Please enter desired username"
        Else
            lblUsernameInfo.Text = ""
        End If
        If txtPW.Text = "" Then
            lblPWInfo.Text = "Please enter desired password"
            lblConfirmPWInfo.Text = ""
        ElseIf txtConfirmPW.Text = "" Then
            lblPWInfo.Text = ""
            lblConfirmPWInfo.Text = "Please confirm desired password"
        ElseIf txtPW.Text <> txtConfirmPW.Text Then
            lblPWInfo.Text = ""
            lblConfirmPWInfo.Text = "Password didn't match"
        Else
            lblPWInfo.Text = ""
            lblConfirmPWInfo.Text = ""
        End If
    End Sub

    Private Function SearchExisting() As Boolean
        Try
            Dim tableAccounts As New DataTable()
            Dim command As String
            command = "select * from Accounts where UN = '" & txtUsername.Text & "'"
            Dim adapter As New OleDb.OleDbDataAdapter(command, modData.dbConnect)
            If adapter.Fill(tableAccounts) = 1 Then
                Return True
            Else
                Return False
            End If
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
            Return False
        End Try
    End Function

    Private Sub NewAccount()
        Dim connection As New OleDb.OleDbConnection(dbInfo)
        Dim oleDbInsertCommand = New OleDb.OleDbCommand()
        Dim command As String
        Dim adapter As New OleDb.OleDbDataAdapter()
        Dim accessType As String
        Try
            connection.Open()
            'make an SQL insert command
            If rdoAdministrator.Checked = True Then
                accessType = "Administrator"
            Else
                accessType = "Employee"
            End If
            command = "insert into Accounts (UN, PW, AccessType) values('" & txtUsername.Text & "', '" & txtPW.Text & "', '" & accessType & "')"
            'put the insert command into the adapter
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblUsernameInfo.Text = ""
        lblAccessTypeInfo.Text = ""
        lblPWInfo.Text = ""
        lblConfirmPWInfo.Text = ""
    End Sub
End Class
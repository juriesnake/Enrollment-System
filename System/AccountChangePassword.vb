Public Class AccountChangePassword
    Private un, pw As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        un = modData.Username
        pw = modData.Password
        txtUsername.Text = un
        lblCurrentPWInfo.Text = ""
        lblNewPWInfo.Text = ""
        lblConfirmNewPWInfo.Text = ""
    End Sub

    Private Sub btnChangePW_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePW.Click
        If txtCurrentPW.Text = pw And txtNewPW.Text <> "" And txtConfirmNewPW.Text <> "" And txtNewPW.Text = txtConfirmNewPW.Text Then
            UpdatePassword()
            MessageBox.Show("Password has been successfully changed")
            modData.Password = txtNewPW.Text
            Me.Close()
        End If
        If txtCurrentPW.Text = "" Then
            lblCurrentPWInfo.Text = "Please enter your current password"
        ElseIf txtCurrentPW.Text <> pw Then
            lblCurrentPWInfo.Text = "Current password did not match"
        Else
            lblCurrentPWInfo.Text = ""
        End If
        If txtNewPW.Text = "" Then
            lblNewPWInfo.Text = "Please enter your new password"
            lblConfirmNewPWInfo.Text = ""
        ElseIf lblConfirmNewPWInfo.Text = "" Then
            lblNewPWInfo.Text = ""
            lblConfirmNewPWInfo.Text = "Please confirm your new password"
        ElseIf txtNewPW.Text <> txtConfirmNewPW.Text Then
            lblNewPWInfo.Text = ""
            lblConfirmNewPWInfo.Text = "New Password did not match"
        Else
            lblNewPWInfo.Text = ""
            lblConfirmNewPWInfo.Text = ""
        End If
    End Sub

    Private Sub UpdatePassword()
        Dim connection As New OleDb.OleDbConnection(modData.dbConnect)
        Dim oleDbUpdateCommand = New OleDb.OleDbCommand()
        Try
            connection.Open()
            Dim adapter As New OleDb.OleDbDataAdapter()
            Dim command As String
            'set up an SQL update, using text boxes
            command = "update Accounts set PW='" & txtNewPW.Text & "' where UN='" & txtUsername.Text & "'"
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
End Class
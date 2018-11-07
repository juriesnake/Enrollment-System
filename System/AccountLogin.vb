Public Class AccountLogin
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text <> "" Then
            Try
                Dim tableAccounts As New DataTable()
                Dim command As String
                command = "select * from Accounts where UN = '" & txtUsername.Text & "'"
                Dim adapter As New OleDb.OleDbDataAdapter(command, modData.dbConnect)
                If adapter.Fill(tableAccounts) <> 0 Then
                    If txtPassword.Text = CStr(tableAccounts.Rows(0)(1)) Then
                        modData.Username = CStr(tableAccounts.Rows(0)(0))
                        modData.Password = CStr(tableAccounts.Rows(0)(1))
                        modData.AccessType = CStr(tableAccounts.Rows(0)(2))
                        Main.mnuStrip.Enabled = True
                        SecurityAccess()
                        grpLogin.Visible = False
                    ElseIf txtPassword.Text = "" Then
                        MessageBox.Show("Please enter your password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Wrong Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Username not found", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch exceptionObject As Exception
                MessageBox.Show(exceptionObject.Message)
            End Try
        Else
            MessageBox.Show("Please login using your username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        
    End Sub

    Private Sub SecurityAccess()
        If modData.AccessType = "Administrator" Then
            Main.UpdateToolStripMenuItem1.Enabled = True
            Main.CreateNewToolStripMenuItem1.Enabled = True
        Else
            Main.UpdateToolStripMenuItem1.Enabled = False
            Main.CreateNewToolStripMenuItem1.Enabled = False
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

    End Sub
End Class
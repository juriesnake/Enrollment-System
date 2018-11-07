Public Class Lock

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtPassword.Text = modData.Password Then
            Main.Enabled = True
            Me.Close()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter your password")
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtUsername.Text = modData.Username
    End Sub
End Class
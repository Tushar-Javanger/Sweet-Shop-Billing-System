Public Class Login

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")
    Dim query As String
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim t As Integer

    ' This sub first checks if the user enters empty string or not. Then it checks whether the password matches or not. If true login the user false otherwise.
    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If Trim(txtUserName.Text).Length = 0 Or Trim(txtUserPassword.Text).Length = 0 Then
            MsgBox("Username or Password Cant't be Empty", MsgBoxStyle.Critical, "Login Failed")
            Exit Sub
        End If
        query = "select * from LoginCredentials"
        Dim cmd As New OleDb.OleDbCommand(query, conn)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            If txtUserName.Text = dr.Item(0) And txtUserPassword.Text = dr.Item(1) Then
                Main.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Id Or Passsword", MsgBoxStyle.Critical, "Unauthentic Login")
            End If
        End While
    End Sub

    'This sub will Show or Hide the password entered by the user.
    Private Sub ShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked Then
            txtUserPassword.PasswordChar = ""
        Else
            txtUserPassword.PasswordChar = "*"
        End If
    End Sub


    ' On form load we are testing whether the connection is established or not.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'This sub will close the application.
    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    'This sub will take the user to the ChangePassword window.
    Private Sub lbChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbChangePassword.Click
        Me.Close()
        Change_Password.Show()
    End Sub

    'This sub will take the user to the ChangePassword window on picture click.    
    Private Sub changepasswordicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepasswordicon.Click
        Me.Close()
        Change_Password.Show()
    End Sub

End Class

Public Class Change_Password
    Dim query As String
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")

    ' This sub is for changing the user password.
    Private Sub btok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btok.Click
        Dim AdminPin As String = "1234"   'Sets the admin PIN

        If Trim(txtAdminPin.Text).Length = 0 Then
            MsgBox("PIN cannot be Empty", MsgBoxStyle.Critical, "Failure")     ' Checks for Empty PIN.
            Exit Sub
        End If

        If txtAdminPin.Text <> AdminPin Then    'verify the admin pin
            MsgBox("Incorrect Pin", MsgBoxStyle.Exclamation, "Failure")
            txtAdminPin.Clear()
            txtAdminPin.Focus()
            Exit Sub
        End If

        If Trim(txtNewPassword.Text).Length = 0 Or Trim(txtConfirmPassword.Text).Length = 0 Then    'Checks whether the password is empty or not.
            MsgBox("Password Cannot Be Empty!!", MsgBoxStyle.Critical, "Password Error")
            Exit Sub
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then  'verify password and confirm password.
            MsgBox("Password Mismatches!!", MsgBoxStyle.Critical, "Password Error")
            Exit Sub
        End If

        'Changes the password.
        query = "Update LoginCredentials set [Password]='" & Trim(txtNewPassword.Text) & "' where Username='scott' "
        Try
            Dim cmd As New OleDb.OleDbCommand(query, conn)
            Dim t As Integer = cmd.ExecuteNonQuery()
            MsgBox("Password Changed Successfully!!", , "Success")
            txtAdminPin.Clear()
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    ' This sub establishes the connection on form load.
    Private Sub Change_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub


    'This sub will take the user to the login form.
    Private Sub btBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBack.Click
        Login.Show()
        Me.Close()
    End Sub

    
  
    
End Class
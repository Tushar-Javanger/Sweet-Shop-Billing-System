Public Class ChangePrice

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")
    Dim query As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim cmd As OleDb.OleDbCommand
    Dim dt As DataTable


    ' This sub enbales the textbox and button and retreives the current price of selected sweet
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSweetnameList.SelectedIndexChanged
        txtchangePrice.Enabled = True
        btChangePrice.Enabled = True
        query = "select Sweetprice from Menu where Sweetname ='" & CbSweetnameList.SelectedItem & "'"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        txtchangePrice.Text = dt.Rows(0).Item(0)            ' It shows price of currently selected item
        txtchangePrice.Focus()
    End Sub

    ' This sub will test for the connection to database and disables changePrice_textbox and ChangePrice_button
    Private Sub ChangePrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        txtchangePrice.Enabled = False
        btChangePrice.Enabled = False
    End Sub

    ' This sub will updates the price of selected sweet when button is clicked
    Private Sub btChangePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btChangePrice.Click
        Try
            If txtchangePrice.Text = 0 Then
                MsgBox("Price cannot be null", MsgBoxStyle.Critical, "Empty Field")
                txtchangePrice.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Please enter numeric value", MsgBoxStyle.Exclamation, "Wrong Input")
            txtchangePrice.Focus()
        End Try
        query = "update Menu set Sweetprice = " & CInt(txtchangePrice.Text) & " where Sweetname = '" & CbSweetnameList.SelectedItem & "'"
        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Price Changed Successfully", , "Success")

    End Sub
End Class
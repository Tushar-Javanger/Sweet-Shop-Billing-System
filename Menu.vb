Public Class menuform

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")
    Dim query As String
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim Sweetprice(14) As Integer
    Dim Sweetname(14) As String
    Dim checkboxName As String
    Dim UserClick As CheckBox

    ' Add button working.
    Private Sub btadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btadd.Click
        Dim userquantity = txtQuantity.Text
        Try                                                                     ' Tests for quantity is empty or null.
            If userquantity = 0 Then
                MsgBox("Quantity cannot be Empty", MsgBoxStyle.Critical, "Empty field")
                txtQuantity.Focus()
                Exit Sub
            End If
        Catch ex As Exception                                                   'Handles the exception like string value is entered for quantity. 
            MsgBox("Please enter numeric value", MsgBoxStyle.Exclamation, "Wrong Input")
            txtQuantity.Focus()
        End Try

        If rbKg.Checked Then                                                'Checks for which radio button is selected.
            calKg(checkboxName, Sweetname, Sweetprice, userquantity)
        Else
            calGram(checkboxName, Sweetname, Sweetprice, userquantity)
        End If

        UserClick.Checked = False                                           'Unchecks the checkbox selected by the user.

    End Sub


    ' This sub will get the sweet price and calculate the amount for kg and add the record in database.
    Public Sub calKg(ByVal checkboxName As String, ByVal Sweetname As Array, ByVal Sweetprice As Array, ByVal quantity As Integer)
        Dim index As Integer
        'This loop will fetch the index of selected checkbox.
        For i As Integer = 0 To Sweetname.Length - 1
            If checkboxName = Sweetname(i) Then
                index = i
                Exit For
            End If
        Next
        query = "select SweetQuantity from Menu where Sweetname = '" & checkboxName & "'"
        Dim da As New OleDb.OleDbDataAdapter(query, conn)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)

        If quantity * 1000 > dt.Rows(0).Item(0) Then      'Checks if quantity of selected item in Kilograms is available in database or not
            MsgBox("Not enough quantity", MsgBoxStyle.Information, "Insufficient Quantity")
            Exit Sub
        End If


        query = "update Menu set SweetQuantity = " & dt.Rows(0).Item(0) - quantity * 1000 & " where Sweetname = '" & checkboxName & "'"     ' Subtracts user quantity from database
        Dim cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()


        Dim amount As Integer
        amount = quantity * Sweetprice(index)   'Using index to get the sweet price and calculate amount.
        query = "insert into Cart values('" & checkboxName & "'," & Sweetprice(index) & "," & quantity * 1000 & "," & amount & ")"
        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()                   ' adds the record in cart table.
    End Sub



    ' This sub will get the sweet price and calculate the amount for gram and add the record in database.
    Public Sub calGram(ByVal checkboxName As String, ByVal Sweetname As Array, ByVal Sweetprice As Array, ByVal quantity As Integer)
        Dim index As Integer
        'This loop will fetch the index of selected checkbox.
        For i As Integer = 0 To Sweetname.Length - 1
            If checkboxName = Sweetname(i) Then
                index = i
                Exit For
            End If
        Next

        query = "select SweetQuantity from Menu where Sweetname = '" & checkboxName & "'"
        Dim da As New OleDb.OleDbDataAdapter(query, conn)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)

        If quantity > dt.Rows(0).Item(0) Then      'Checks if quantity of selected item in grams is available in database or not
            MsgBox("Not enough quantity", MsgBoxStyle.Information, "Insufficient Quantity")
            Exit Sub
        End If
       
        query = "update Menu set SweetQuantity = " & dt.Rows(0).Item(0) - quantity & " where Sweetname = '" & checkboxName & "'"     ' Subtracts user quantity from database
        Dim cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        Dim amount As Double
        amount = (quantity / 1000.0) * Sweetprice(index) 'Using index to get the sweet price and calculate amount.
        query = "insert into Cart values('" & checkboxName & "'," & Sweetprice(index) & "," & quantity & "," & amount & ")"
        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()   ' adds the record in cart table.
    End Sub

    ' Handles all the checkbox clicks.
    Private Sub Multihandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged, CheckBox7.CheckedChanged, CheckBox8.CheckedChanged, CheckBox9.CheckedChanged, CheckBox10.CheckedChanged, CheckBox11.CheckedChanged, CheckBox12.CheckedChanged, CheckBox13.CheckedChanged, CheckBox14.CheckedChanged, CheckBox15.CheckedChanged
        For Each ch As Control In Checkboxpanel.Controls
            If TypeOf ch Is CheckBox Then
                UserClick = CType(ch, CheckBox)
                If UserClick.Checked Then
                    checkboxName = UserClick.Text                                 'Storing the selected checkbox name in checkboxName Variable.
                    txtQuantity.Enabled = True
                    txtQuantity.Focus()
                    btadd.Enabled = True
                    For Each ch1 As Control In Checkboxpanel.Controls
                        If TypeOf ch1 Is CheckBox Then
                            Dim chk1 As CheckBox = CType(ch1, CheckBox)
                            If chk1.Text <> UserClick.Text Then
                                chk1.Enabled = False                        'Disables all the checkboxes except the selected one.
                            End If
                        End If
                    Next
                    Exit For
                Else
                    txtQuantity.Enabled = False
                    txtQuantity.Text = "Quantity"
                    btadd.Enabled = False
                    UserClick.Enabled = True        'Enables all the checkbox
                End If
            End If
        Next
    End Sub


    'Creates Dynamic Labels and storing data in two arrays.
    Private Sub menuform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim y As Integer = 114
        Dim i As Integer
        query = "select * from Menu"

        Try                                             ' Test for connection 
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim da As New OleDb.OleDbDataAdapter(query, conn)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)

        For counter = 0 To dt.Rows.Count() - 1
            Sweetname(i) = dt.Rows(counter).Item(0)   'Stores the sweet names in Sweetname() array.
            Sweetprice(i) = dt.Rows(counter).Item(1)  'Stores the sweet price in Sweetprice() array.
            i += 1                      ' i counts total number of records in table.
        Next

        'Creating dynamic Labels for price using database.
        For j As Integer = 0 To i - 1
            Dim label As New Label()
            label.Location = New Point(392, y)
            label.Size = New Size(265, 67)
            label.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold)
            label.Name = "label_" & i
            label.Text = "Rs " & Sweetprice(j) & "/kg"
            Panel1.Controls.Add(label)
            y += 195
        Next

    End Sub


End Class
Public Class quantityform

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")
    Dim query As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim cmd As OleDb.OleDbCommand
    Dim dt As DataTable
    Dim kilograms, grams As Integer

    ' This sub will test the connection and disables other controls.
    Private Sub quantityform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        btAddQuantity.Enabled = False
        txtAddQuantity.Enabled = False
        lbShowQuantity.Enabled = False

    End Sub


    ' This sub will show the current quantity of selected sweet in label
    Private Sub cbsweetname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsweetname.SelectedIndexChanged
        btAddQuantity.Enabled = True
        query = "select SweetQuantity from Menu where Sweetname ='" & cbsweetname.SelectedItem & "'"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        kilograms = dt.Rows(0).Item(0) \ 1000       'Converting data to kilograms
        grams = dt.Rows(0).Item(0) Mod 1000         'Converting data to grams
        lbShowQuantity.Enabled = True
        txtAddQuantity.Enabled = True
        lbShowQuantity.Text = "Current Quantity is: " & kilograms & " kg " & grams & " g"
        txtAddQuantity.Focus()
        txtAddQuantity.Text = Nothing
    End Sub


    ' This sub will add the quantity and also shows the updated quantity in label
    Private Sub btAddQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddQuantity.Click
        Dim newQuantity As Integer
        Try
            If txtAddQuantity.Text = 0 Then
                MsgBox("Quantity cannot be Empty", MsgBoxStyle.Critical, "Empty Field")
                txtAddQuantity.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Please enter numeric value", MsgBoxStyle.Exclamation, "Wrong Input")
            txtAddQuantity.Focus()
        End Try

        If rbkilograms.Checked Then
            newQuantity = txtAddQuantity.Text * 1000        'Converting data to grams because we use grams unit in database
        End If
        If rbgrams.Checked Then
            newQuantity = txtAddQuantity.Text
        End If


        query = "update Menu set SweetQuantity = " & newQuantity + dt.Rows(0).Item(0) & " where Sweetname = '" & cbsweetname.SelectedItem & "'"
        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        query = "select SweetQuantity from Menu where Sweetname ='" & cbsweetname.SelectedItem & "'"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        kilograms = dt.Rows(0).Item(0) \ 1000           'Converting data to kilograms
        grams = dt.Rows(0).Item(0) Mod 1000             'Converting data to grams
        lbShowQuantity.Text = "Current Quantity is: " & kilograms & " kg " & grams & " g"


    End Sub

   
End Class
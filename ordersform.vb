Public Class ordersform
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")
    Dim query As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim sales As Integer

    'This sub will show data and total sales of particular selected date.
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datePicker.ValueChanged
        query = "select * from Orders where Day = #" & datePicker.Value.Date.ToString("MM/dd/yyyy") & "# order by Id"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        dgOrders.DataSource = dt
        sales = 0
        For i As Integer = 0 To dt.Rows.Count() - 1         'Calculating Total sales of Particular date.
            sales = sales + dt.Rows(i).Item(2)
        Next

        lbSales.Text = "Rs " & sales
    End Sub

    'This sub will show data and total sales of current date.
    Private Sub ordersform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        query = "select * from Orders where Day = #" & Date.Now.Date().ToString("MM/dd/yyyy") & "# order by Id"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        dgOrders.DataSource = dt

        For i As Integer = 0 To dt.Rows.Count() - 1         'Calculating Total sales of current date.
            sales = sales + dt.Rows(i).Item(2)
        Next

        lbSales.Text = "Rs " & sales
    End Sub

End Class
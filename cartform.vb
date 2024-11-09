Imports System.Drawing.Printing
Public Class cartform
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")
    Dim query As String
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim totalAmount As Integer = 0
    Dim uniqueId As Integer

    ' This sub will calculate the Payable amount by the customer. 
    Private Sub cartform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'TODO: This line of code loads data into the 'ProjectDBDataSet1.Cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter1.Fill(Me.ProjectDBDataSet1.Cart)
        'TODO: This line of code loads data into the 'ProjectDBDataSet.Cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.ProjectDBDataSet.Cart)

        query = "select * from Cart"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        dgCart.DataSource = dt

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                totalAmount = totalAmount + dt.Rows(i).Item(3)
            Next
        End If

        lbAmount.Text = "Rs " & totalAmount
    End Sub


    ' This sub will delete all the items at once from the Cart table if user did not want to buy anything.
    Private Sub btclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclear.Click
        Dim cmd As New OleDb.OleDbCommand
        For i = 0 To dgCart.RowCount() - 1

            query = "select SweetQuantity from Menu where Sweetname = '" & dgCart.Rows(i).Cells(0).Value & "'"     ' Gets the current Sweetquantity
            da = New OleDb.OleDbDataAdapter(query, conn)
            dt = New DataTable
            dt.Clear()
            da.Fill(dt)

            query = "update Menu set SweetQuantity = " & dt.Rows(0).Item(0) + dgCart.Rows(i).Cells(2).Value & " where Sweetname = '" & dgCart.Rows(i).Cells(0).Value & "'"     ' Sets back the quantity if one item is deleted.
            cmd = New OleDb.OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
        Next

        query = "delete * from Cart"
        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()
        query = "select * from Cart"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        lbAmount.Text = "Rs 0"
        dgCart.DataSource = dt
    End Sub


    'This sub will delete only one item at a time from the Cart table and updates the Payable Amount by the customer.
    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        query = "select SweetQuantity from Menu where Sweetname = '" & dgCart.SelectedRows.Item(0).Cells(0).Value & "'"     ' Gets the current Sweetquantity
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)

        query = "update Menu set SweetQuantity = " & dt.Rows(0).Item(0) + dgCart.SelectedRows.Item(0).Cells(2).Value & " where Sweetname = '" & dgCart.SelectedRows.Item(0).Cells(0).Value & "'"     ' Sets back the quantity if one item is deleted.
        Dim cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        query = "delete from Cart where Sweetname = '" & dgCart.SelectedRows.Item(0).Cells(0).Value & "' AND Quantity = " & dgCart.SelectedRows.Item(0).Cells(2).Value
        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()
        da = New OleDb.OleDbDataAdapter("select * from Cart", conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        dgCart.DataSource = dt
        totalAmount = 0

        For i As Integer = 0 To dt.Rows.Count - 1
            totalAmount = totalAmount + dt.Rows(i).Item(3)
        Next

        lbAmount.Text = "Rs " & totalAmount
    End Sub

    'This sub will generate the bill and insert data in order Table.
    Private Sub btGenerateBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGenerateBill.Click
        If dgCart.RowCount = 0 Then
            MsgBox("No Data Found!!", MsgBoxStyle.Information, "Lack of data")
            Exit Sub
        End If

        query = "select * from Orders where Day = #" & Date.Now.Date().ToString("MM/dd/yyyy") & "#"       ' Creating Unique Id for the current date.
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        uniqueId = dt.Rows.Count() + 1

        query = "insert into Orders values(" & uniqueId & "," & dgCart.RowCount() & "," & totalAmount & ",#" & Date.Now.Date().ToString("MM/dd/yyyy") & "#)"
        Dim cmd As New OleDb.OleDbCommand(query, conn)          'inserting data in Orders Table
        cmd.ExecuteNonQuery()

        printDoc.DefaultPageSettings.PaperSize = New PaperSize("mysize", 250, 600)          'Creating paper
        ppd.PrintPreviewControl.Zoom = 2.5                                                  'Zooming Dialog Box
        ppd.ClientSize = New Size(1920, 1080)                                               'Setting Dialog Box
        ppd.Document = printDoc                                                             'Setting paper inside Dialog Box
        ppd.ShowDialog()                                                                    'Showing Dialog Box

        query = "delete * from Cart"
        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()
        query = "select * from Cart"
        da = New OleDb.OleDbDataAdapter(query, conn)
        dt = New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        lbAmount.Text = "Rs 0"
        dgCart.DataSource = dt
    End Sub

    'Generates the data and shapes on paper.
    Private Sub printDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        Dim f8 As New Font("Arial", 6, FontStyle.Regular)           'Creating new font
        Dim f8b As New Font("Verdana", 10, FontStyle.Bold)

        Dim left, right, center As New StringFormat                 'Setting alignments
        left.Alignment = StringAlignment.Near
        center.Alignment = StringAlignment.Center
        right.Alignment = StringAlignment.Far

        'Shop name, Address And Phone number. 
        Dim rect1 As New Rectangle(5, 5, 240, 17)                    'Drawing Rectangle(x,y,width,height)
        Dim rect2 As New Rectangle(5, 22, 240, 17)
        Dim rect3 As New Rectangle(5, 39, 240, 17)
        e.Graphics.DrawRectangle(Pens.Black, rect1)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect3)
        e.Graphics.DrawString("Shri BalaJi Sweet House", f8b, Brushes.Black, rect1, center)
        e.Graphics.DrawString("Street No.4, Circular Road", f8, Brushes.Black, rect2, center)
        e.Graphics.DrawString("+91 94637-84061", f8, Brushes.Black, rect3, center)

        '-----------------------------------------------------------------------------------------
        Dim rect4 As New Rectangle(5, 73, 60, 25)                       ' Making Headings for column headers
        Dim rect5 As New Rectangle(65, 73, 60, 25)
        Dim rect6 As New Rectangle(125, 73, 60, 25)
        Dim rect7 As New Rectangle(185, 73, 60, 25)
        e.Graphics.DrawRectangle(Pens.Black, rect4)
        e.Graphics.DrawRectangle(Pens.Black, rect5)
        e.Graphics.DrawRectangle(Pens.Black, rect6)
        e.Graphics.DrawRectangle(Pens.Black, rect7)
        e.Graphics.DrawString("Sweet Name", f8, Brushes.Black, rect4, center)
        e.Graphics.DrawString("Sweet Price", f8, Brushes.Black, rect5, center)
        e.Graphics.DrawString("Quantity", f8, Brushes.Black, rect6, center)
        e.Graphics.DrawString("Amount", f8, Brushes.Black, rect7, center)

        '-------------------------------------------------------------------------------------------
        Dim y As Integer = 98                                           'Making Columns and inserting Data into them using Loop
        For i As Integer = 0 To dgCart.Rows.Count - 1
            Dim rect8 As New Rectangle(5, y, 60, 25)
            Dim rect9 As New Rectangle(65, y, 60, 25)
            Dim rect10 As New Rectangle(125, y, 60, 25)
            Dim rect11 As New Rectangle(185, y, 60, 25)
            e.Graphics.DrawRectangle(Pens.Black, rect8)
            e.Graphics.DrawRectangle(Pens.Black, rect9)
            e.Graphics.DrawRectangle(Pens.Black, rect10)
            e.Graphics.DrawRectangle(Pens.Black, rect11)
            e.Graphics.DrawString(dgCart.Rows(i).Cells(0).Value, f8, Brushes.Black, rect8, center)
            e.Graphics.DrawString(dgCart.Rows(i).Cells(1).Value, f8, Brushes.Black, rect9, center)
            e.Graphics.DrawString(dgCart.Rows(i).Cells(2).Value \ 1000 & "kg , " & dgCart.Rows(i).Cells(2).Value Mod 1000 & "g", f8, Brushes.Black, rect10, center)
            e.Graphics.DrawString(dgCart.Rows(i).Cells(3).Value, f8, Brushes.Black, rect11, center)

            y = y + 25
        Next
        '--------------------------------------------------------------------------------------------
        Dim rect12 As New Rectangle(5, y, 240, 25)                          'Total Bill Column
        e.Graphics.DrawRectangle(Pens.Black, rect12)
        e.Graphics.DrawString("Total Bill :", f8b, Brushes.Black, rect12, center)
        Dim rect13 As New Rectangle(185, y, 60, 25)
        e.Graphics.DrawString(totalAmount, f8b, Brushes.Black, rect13, center)
    End Sub

End Class
Public Class Main

    'This sub will open the different forms(Main.vb,cart.vb,ordersform.vb,....) in the Main.vb form.
    Sub childForm(ByVal subForm As Form)
        Panel1.Controls.Clear()     'Clears the already placed controls on the panel.
        subForm.TopLevel = False      'Form will no more be a parent
        subForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        subForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(subForm)  'Adds the form on the panel.
        subForm.Show()                'Visible the form.
    End Sub

    Private Sub MENUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MENUToolStripMenuItem.Click
        menuform.Close()
        childForm(menuform)
    End Sub

    Private Sub CARTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARTToolStripMenuItem.Click
        cartform.Close()        ' To reload the form so that new data can be reterived.
        childForm(cartform)
    End Sub

    Private Sub QUANTITYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUANTITYToolStripMenuItem.Click
        quantityform.Close()
        childForm(quantityform)
    End Sub

    Private Sub ORDERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORDERToolStripMenuItem.Click
        ordersform.Close()      ' To reload the form so that new data can be reterived.
        childForm(ordersform)
    End Sub



    Private Sub ChangePriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePriceToolStripMenuItem.Click
        childForm(ChangePrice)
    End Sub


    'This sub closes the connection and takes the user to the Login Page.
    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tushar\OneDrive\Documents\ProjectDB.accdb")
        conn.Close()
        Me.Close()
        Login.Show()
    End Sub

End Class
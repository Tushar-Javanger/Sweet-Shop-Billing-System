<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordersform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.dgOrders = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbSales = New System.Windows.Forms.Label()
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datePicker
        '
        Me.datePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker.Location = New System.Drawing.Point(35, 580)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(279, 53)
        Me.datePicker.TabIndex = 0
        '
        'dgOrders
        '
        Me.dgOrders.AllowUserToAddRows = False
        Me.dgOrders.AllowUserToDeleteRows = False
        Me.dgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgOrders.Location = New System.Drawing.Point(0, 0)
        Me.dgOrders.MultiSelect = False
        Me.dgOrders.Name = "dgOrders"
        Me.dgOrders.ReadOnly = True
        Me.dgOrders.RowTemplate.Height = 24
        Me.dgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrders.Size = New System.Drawing.Size(1236, 524)
        Me.dgOrders.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(431, 580)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Sales : "
        '
        'lbSales
        '
        Me.lbSales.AutoSize = True
        Me.lbSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSales.Location = New System.Drawing.Point(848, 580)
        Me.lbSales.Name = "lbSales"
        Me.lbSales.Size = New System.Drawing.Size(0, 58)
        Me.lbSales.TabIndex = 3
        '
        'ordersform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1236, 768)
        Me.Controls.Add(Me.lbSales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgOrders)
        Me.Controls.Add(Me.datePicker)
        Me.Name = "ordersform"
        Me.Text = "Orders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgOrders As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbSales As System.Windows.Forms.Label
End Class
